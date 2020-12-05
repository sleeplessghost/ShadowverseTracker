using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShadowverseTracker
{
    public class Game
    {
        private Craft mPlayerCraft;
        private Craft mOpponentCraft;
        private int mPlayerDeckID;
        private int mOpponentDeckID;
        private bool mFirst;
        private Mode mGameMode;
        private bool mWon;
        private int mNumTurns = 0;
        private string mNotes = "";
        private long mID = -1;

        public Game()
        {
            //needed for XmlSerializer, do not use
        }

        public Game(Craft player, Craft opponent, Deck playerDeck, Deck opponentDeck, bool first, Mode mode, bool won, int numTurns, string notes)
        {
            this.mPlayerCraft = player;
            this.mOpponentCraft = opponent;
            this.mPlayerDeckID = playerDeck.id;
            this.mOpponentDeckID = opponentDeck.id;
            this.mFirst = first;
            this.mGameMode = mode;
            this.mWon = won;
            this.mNumTurns = numTurns;
            this.mNotes = notes;
        }

        public Craft playerCraft
        {
            get
            {
                return mPlayerCraft;
            }
            set
            {
                mPlayerCraft = value;
            }
        }

        public Craft opponentCraft
        {
            get
            {
                return mOpponentCraft;
            }
            set
            {
                mOpponentCraft = value;
            }
        }

        public int playerDeckID
        {
            get
            {
                return mPlayerDeckID;
            }
            set
            {
                mPlayerDeckID = value;
            }
        }

        public int opponentDeckID
        {
            get
            {
                return mOpponentDeckID;
            }
            set
            {
                mOpponentDeckID = value;
            }
        }

        public bool first
        {
            get
            {
                return mFirst;
            }
            set
            {
                mFirst = value;
            }
        }

        public Mode mode
        {
            get
            {
                return mGameMode;
            }
            set
            {
                mGameMode = value;
            }
        }

        public bool won
        {
            get
            {
                return mWon;
            }
            set
            {
                mWon = value;
            }
        }

        public int turns
        {
            get
            {
                return mNumTurns;
            }
            set
            {
                mNumTurns = value;
            }
        }

        public string notes
        {
            get
            {
                return mNotes;
            }
            set
            {
                mNotes = value;
            }
        }

        public long id
        {
            get
            {
                return mID;
            }
            set
            {
                mID = value;
            }
        }
    }
}
