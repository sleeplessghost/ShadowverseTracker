using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System.Collections;
using System.Windows.Forms;

namespace ShadowverseTracker
{
    public class Data
    {
        private readonly string DATAFILE = "storeddata.xml";
        private readonly string EXPORTFILE = "exportedgames.csv";
        private readonly string EXPORTDELIMITER = ",";

        private DataBase mDataBase;

        public Data()
        {
            if (!File.Exists(DATAFILE))
            {
                Console.WriteLine(DATAFILE + " does not exist");
                mDataBase = new DataBase();
                addDeck(Craft.Forest, "Unknown");
                addDeck(Craft.Sword, "Unknown");
                addDeck(Craft.Rune, "Unknown");
                addDeck(Craft.Dragon, "Unknown");
                addDeck(Craft.Shadow, "Unknown");
                addDeck(Craft.Blood, "Unknown");
                addDeck(Craft.Haven, "Unknown");
            }
            else
            {
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(DataBase));
                    using (var reader = XmlReader.Create(DATAFILE))
                    {
                        mDataBase = (DataBase)serializer.Deserialize(reader);
                    }
                }
                catch (Exception x)
                {
                    Console.WriteLine("Exception occurred while reading from file: " + x.ToString());
                    mDataBase = new DataBase();
                }
            }
            rebuildIndexes();
        }

        public void rebuildIndexes()
        {
            //fix indexes of games (to allow porting old data to new version)
            Game game;
            Game rebuilt;
            int count = 0;
            for (int i = 0; i < mDataBase.games.Count; i++)
            {
                game = mDataBase.games[i];
                if (game.id < 0)
                {
                    //remove and insert fixed game at end
                    mDataBase.games.RemoveAt(i);
                    rebuilt = new Game(game.playerCraft, game.opponentCraft, getDeckByID(game.playerDeckID), getDeckByID(game.opponentDeckID), game.first, game.mode, game.won, game.turns, game.notes);

                    long id;
                    if (mDataBase.games.Count <= 0) id = 0;
                    else id = mDataBase.games.Last().id + 1;

                    game.id = id;
                    mDataBase.games.Add(rebuilt);
                    count++;
                    i--;
                }
            }
            Console.WriteLine("Rebuilt indexes for " + count + " games");
            saveData();
        }

        public void exportCSV()
        {
            using (TextWriter writer = new StreamWriter(EXPORTFILE, false, Encoding.UTF8))
            {
                //write headers
                StringBuilder builder = new StringBuilder()
                    .Append("Player Craft").Append(EXPORTDELIMITER)
                    .Append("Player Deck").Append(EXPORTDELIMITER)
                    .Append("Opponent Craft").Append(EXPORTDELIMITER)
                    .Append("Opponent Deck").Append(EXPORTDELIMITER)
                    .Append("Game Mode").Append(EXPORTDELIMITER)
                    .Append("Turn").Append(EXPORTDELIMITER)
                    .Append("Num Turns").Append(EXPORTDELIMITER)
                    .Append("Win/Loss").Append(EXPORTDELIMITER)
                    .Append("Notes").Append(EXPORTDELIMITER).Append("\r\n");
                writer.Write(builder.ToString());

                foreach (Game game in mDataBase.games)
                {
                    //write games
                    builder.Length = 0; //clear builder
                    builder.Append(game.playerCraft.ToString()).Append(EXPORTDELIMITER)
                        .Append("\"").Append(getDeckByID(game.playerDeckID).name.Replace("\"", "")).Append("\"").Append(EXPORTDELIMITER)
                        .Append(game.opponentCraft.ToString()).Append(EXPORTDELIMITER)
                        .Append("\"").Append(getDeckByID(game.opponentDeckID).name.Replace("\"", "")).Append("\"").Append(EXPORTDELIMITER)
                        .Append(game.mode.ToString()).Append(EXPORTDELIMITER)
                        .Append(game.first ? "First" : "Second").Append(EXPORTDELIMITER)
                        .Append(game.turns).Append(EXPORTDELIMITER)
                        .Append(game.won ? "Win" : "Loss").Append(EXPORTDELIMITER)
                        .Append(game.notes).Append(EXPORTDELIMITER).Append("\r\n");
                    writer.Write(builder.ToString());
                }

                writer.Flush();
            }
        }

        public void saveData()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(mDataBase.GetType());
                using (var writer = XmlWriter.Create(DATAFILE))
                {
                    serializer.Serialize(writer, mDataBase);
                }
            }
            catch (Exception x)
            {
                Console.WriteLine("Exception occurred while trying to save data to file: " + x.ToString());
            }
        }

        public Deck getDeckByID(int id)
        {
            foreach (Deck deck in mDataBase.decks)
            {
                if (deck.id == id)
                {
                    return deck;
                }
            }
            Deck res = new Deck();
            res.name = "Unknown";
            return res;
        }

        public void addDeck(Craft craft, string name)
        {
            Deck deck = new Deck(craft, name);

            int id;
            if (mDataBase.decks.Count <= 0) id = 0;
            else id = mDataBase.decks.Last().id + 1;

            deck.id = id;
            mDataBase.decks.Add(deck);
            saveData();
        }

        public void addGame(Craft playerCraft, Craft opponentCraft, Deck playerDeck, Deck opponentDeck, bool first, Mode mode, bool won, int numTurns, string notes)
        {
            Game game = new Game(playerCraft, opponentCraft, playerDeck, opponentDeck, first, mode, won, numTurns, notes);

            long id;
            if (mDataBase.games.Count <= 0) id = 0;
            else id = mDataBase.games.Last().id + 1;

            game.id = id;
            mDataBase.games.Add(game);
            saveData();
        }

        public void deleteGame(long gameID)
        {
            Console.WriteLine("remove gameid " + gameID);
            for (int i = mDataBase.games.Count - 1; i >= 0; i--) //--i
            {
                if (mDataBase.games[i].id == gameID)
                {
                    mDataBase.games.RemoveAt(i);
                    break;
                }
            }
            saveData();
        }

        public Game[] getGameList(Craft playerCraft, Craft opponentCraft, Deck playerDeck, Deck opponentDeck, Mode mode, Turn turn)
        {
            try
            {
                List<Game> matchingGames = new List<Game>();
                foreach (Game game in mDataBase.games)
                {
                    if ((playerCraft == Craft.All || game.playerCraft == playerCraft)
                        && (opponentCraft == Craft.All || game.opponentCraft == opponentCraft)
                        && (playerDeck == null || game.playerDeckID == playerDeck.id)
                        && (opponentDeck == null || game.opponentDeckID == opponentDeck.id)
                        && (mode == Mode.All || game.mode == mode)
                        && (turn == Turn.All || ((turn == Turn.First) == game.first)))
                    {
                        matchingGames.Add(game);
                    }
                }

                return matchingGames.ToArray();
            }
            catch (Exception x)
            {
                Console.WriteLine("Exception occurred getting game list for ["+playerCraft.ToString()+","+opponentCraft.ToString()+"]: " + x.ToString());
            }
            return new Game[] { };
        }

        public Deck[] getDeckList(Craft craft)
        {
            try
            {
                List<Deck> decks = mDataBase.decks;
                if (craft == Craft.All)
                {
                    return decks.ToArray();
                }
                else
                {
                    List<Deck> result = new List<Deck>();
                    foreach (Deck deck in decks)
                    {
                        if (deck.craft == craft)
                        {
                            result.Add(deck);
                        }
                    }
                    return result.ToArray();
                }
            }
            catch (Exception x)
            {
                Console.WriteLine("Exception occurred while getting decklist for craft " + craft.ToString() + ": " + x.ToString());
            }
            return new Deck[] { };
        }
    }
}
