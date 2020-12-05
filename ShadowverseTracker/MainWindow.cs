using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace ShadowverseTracker
{
    public partial class MainWindow : Form
    {
        private readonly string[] MODELIST = {
                                                "All",
                                                "Ranked",
                                                "Unranked",
                                                "TakeTwo"
                                             };
        private readonly string[] TURNLIST = {
                                                 "All",
                                                 "First",
                                                 "Second"
                                             };
        private readonly string[] CRAFTLIST = {
                                                "All",
                                                "Forestcraft",
                                                "Swordcraft",
                                                "Runecraft",
                                                "Dragoncraft",
                                                "Shadowcraft",
                                                "Bloodcraft",
                                                "Havencraft"
                                              };
        private readonly Color COLOR_BEIGE = ColorTranslator.FromHtml("#E6E2AF");
        private readonly Color COLOR_BEIGE2 = ColorTranslator.FromHtml("#dbd7a4");
        private readonly Color COLOR_LIGHT_BLUE = ColorTranslator.FromHtml("#046380");
        private readonly Color COLOR_DARK_BLUE = ColorTranslator.FromHtml("#002F2F");
        private readonly Color COLOR_BACKGROUND = ColorTranslator.FromHtml("#192123");
        private readonly Color COLOR_BACKGROUND_PANEL = ColorTranslator.FromHtml("#223c46");
        private readonly Color COLOR_BUTTON = ColorTranslator.FromHtml("#295b6e");
        private readonly Color COLOR_BUTTON_SEL = ColorTranslator.FromHtml("#129524");
        private readonly Color COLOR_BUTTON_LOSE = ColorTranslator.FromHtml("#c75353");

        private ViewMode mViewMode = ViewMode.Stats;

        //filtering vars
        private Craft mSelectedCraft = Craft.All;
        private Craft mOpponentCraft = Craft.All;
        private Deck mSelectedDeck = null;
        private Deck mOpponentDeck = null;
        private Mode mSelectedMode = Mode.All;
        private Turn mSelectedTurn = Turn.All;

        //add game vars
        private Craft mGameSelectedCraft = Craft.Forest;
        private Craft mGameOpponentCraft = Craft.Forest;
        private Deck[] mGamePlayerDecks = null;
        private Deck[] mGameOpponentDecks = null;
        private bool mGameFirstSelected = true;
        private Mode mGameModeSelected = Mode.Ranked;
        private bool mGameWonSelected = true;

        //data
        private Data mData;
        private Game[] mCurrentGameList;
        private Deck[] mCurrentDeckList;
        private Deck[] mCurrentOpponentDeckList;

        public MainWindow()
        {
            InitializeComponent();
            buttonAll.Click += new EventHandler(craftButtonClick);
            buttonForest.Click += new EventHandler(craftButtonClick);
            buttonSword.Click += new EventHandler(craftButtonClick);
            buttonRune.Click += new EventHandler(craftButtonClick);
            buttonDragon.Click += new EventHandler(craftButtonClick);
            buttonShadow.Click += new EventHandler(craftButtonClick);
            buttonBlood.Click += new EventHandler(craftButtonClick);
            buttonHaven.Click += new EventHandler(craftButtonClick);
            opponentCraftSelector.SelectedIndexChanged += new EventHandler(craftOpponentChanged);
            opponentDeckSelector.SelectedIndexChanged += new EventHandler(filterDeckChanged);
            playerDeckSelector.SelectedIndexChanged += new EventHandler(filterDeckChanged);
            gameModeSelector.SelectedIndexChanged += new EventHandler(gameModeChanged);
            turnSelector.SelectedIndexChanged += new EventHandler(turnChanged);
            statsButton.Click += new EventHandler(statsButtonClick);
            decksButton.Click += new EventHandler(decksButtonClick);
            matchupsButton.Click += new EventHandler(matchupsButtonClick);
            exportButton.Click += new EventHandler(exportButtonClick);
            addGameFirstBtn.Click += new EventHandler(addGameTurnClick);
            addGameSecondBtn.Click += new EventHandler(addGameTurnClick);
            addGameRankedBtn.Click += new EventHandler(addGameModeClick);
            addGameUnrankedBtn.Click += new EventHandler(addGameModeClick);
            addGameTakeTwoBtn.Click += new EventHandler(addGameModeClick);
            addGameLoseBtn.Click += new EventHandler(addGameWinClick);
            addGameWinBtn.Click += new EventHandler(addGameWinClick);
            addDeckButton.Click += new EventHandler(addDeckButtonClick);
            addGameButton.Click += new EventHandler(addGameButtonClick);
            addGamePlayerCraftList.SelectedIndexChanged += new EventHandler(addGameCraftPlayerChanged);
            addGameOpponentCraftList.SelectedIndexChanged += new EventHandler(addGameCraftOpponentChanged);
            prevGamesDataGrid.CellClick += new DataGridViewCellEventHandler(deckDataGrid_CellClick);
            customColours();
            setup();
        }

        private void setup()
        {
            mData = new Data();

            foreach (string mode in MODELIST)
            {
                gameModeSelector.Items.Add(mode);
            }
            gameModeSelector.SelectedIndex = 0;
            foreach (string turn in TURNLIST)
            {
                turnSelector.Items.Add(turn);
            }
            turnSelector.SelectedIndex = 0;
            foreach (string name in CRAFTLIST)
            {
                opponentCraftSelector.Items.Add(name);
                if (!name.Equals(getCraftName(Craft.All)))
                {
                    addGamePlayerCraftList.Items.Add(name);
                    addGameOpponentCraftList.Items.Add(name);
                    addDeckCraftSelector.Items.Add(name);
                }
            }
            opponentCraftSelector.SelectedIndex = 0;
            addDeckCraftSelector.SelectedIndex = 0;
            addGamePlayerCraftList.SelectedIndex = 0;
            addGameOpponentCraftList.SelectedIndex = 0;

            setButtonImages();
            this.buttonAll.BackgroundImage = global::ShadowverseTracker.Properties.Resources.btn_all_sel;
            this.buttonAll.BackColor = COLOR_BACKGROUND_PANEL;
            updateUI();
        }

        private void updateUI()
        {
            updateDecks();
            updateGameDecks();
            updateGames();
            updateViewPanel();
            updateTurnButtons();
            updateModeButtons();
            updateWinButtons();
        }

        private void updateViewPanel()
        {
            decksPanel.Visible = mViewMode == ViewMode.Decks;
            statsPanel.Visible = mViewMode == ViewMode.Stats;
            matchupsPanel.Visible = mViewMode == ViewMode.Matchups;
        }

        private void updateDecks()
        {
            mCurrentDeckList = mData.getDeckList(mSelectedCraft);
            mCurrentOpponentDeckList = mData.getDeckList(mOpponentCraft);

            int playerPrev = playerDeckSelector.SelectedIndex;
            int opponentPrev = opponentDeckSelector.SelectedIndex;

            playerDeckSelector.Items.Clear();
            playerDeckSelector.Items.Add("All");
            foreach (Deck deck in mCurrentDeckList)
            {
                playerDeckSelector.Items.Add(deck.name);
            }
            opponentDeckSelector.Items.Clear();
            opponentDeckSelector.Items.Add("All");
            foreach (Deck deck in mCurrentOpponentDeckList)
            {
                opponentDeckSelector.Items.Add(deck.name);
            }

            playerDeckSelector.SelectedIndex = playerPrev < playerDeckSelector.Items.Count && playerPrev >= 0 ? playerPrev : 0;
            opponentDeckSelector.SelectedIndex = opponentPrev < opponentDeckSelector.Items.Count && opponentPrev >= 0 ? opponentPrev : 0;
        }

        private void updateGameDecks()
        {
            mGamePlayerDecks = mData.getDeckList(mGameSelectedCraft);
            mGameOpponentDecks = mData.getDeckList(mGameOpponentCraft);

            int playerPrev = addGamePlayerDeckList.SelectedIndex;
            int opponentPrev = addGameOpponentDeckList.SelectedIndex;

            addGamePlayerDeckList.Items.Clear();
            foreach (Deck deck in mGamePlayerDecks)
            {
                addGamePlayerDeckList.Items.Add(deck.name);
            }
            addGameOpponentDeckList.Items.Clear();
            foreach (Deck deck in mGameOpponentDecks)
            {
                addGameOpponentDeckList.Items.Add(deck.name);
            }

            addGamePlayerDeckList.SelectedIndex = playerPrev < addGamePlayerDeckList.Items.Count ? playerPrev : -1;
            addGameOpponentDeckList.SelectedIndex = opponentPrev < addGameOpponentDeckList.Items.Count ? opponentPrev : -1;

            if (playerPrev < 0 && addGamePlayerDeckList.Items.Count > 0) addGamePlayerDeckList.SelectedIndex = 0;
            if (opponentPrev < 0 && addGameOpponentDeckList.Items.Count > 0) addGameOpponentDeckList.SelectedIndex = 0;
        }

        private void updateGames()
        {
            mCurrentGameList = mData.getGameList(mSelectedCraft, mOpponentCraft, mSelectedDeck, mOpponentDeck, mSelectedMode, mSelectedTurn);

            //stats
            Dictionary<int, DeckStat> decks = new Dictionary<int,DeckStat>();
            Dictionary<int, DeckStat> matchups = new Dictionary<int, DeckStat>();
            int deckID;
            int oppID;
            DeckStat stat;
            DeckStat matchStat;
            long totalGames = 0;
            double totalWins = 0;
            long firstGames = 0;
            double firstWins = 0;
            long secondGames = 0;
            double secondWins = 0;
            long forestGames = 0;
            double forestWins = 0;
            long swordGames = 0;
            double swordWins = 0;
            long runeGames = 0;
            double runeWins = 0;
            long dragonGames = 0;
            double dragonWins = 0;
            long shadowGames = 0;
            double shadowWins = 0;
            long bloodGames = 0;
            double bloodWins = 0;
            long havenGames = 0;
            double havenWins = 0;
            foreach (Game game in mCurrentGameList)
            {
                deckID = game.playerDeckID;
                oppID = game.opponentDeckID;
                stat = new DeckStat();
                matchStat = new DeckStat();
                if (decks.ContainsKey(deckID))
                {
                    decks.TryGetValue(deckID, out stat);
                    decks.Remove(deckID);
                }
                if (matchups.ContainsKey(oppID))
                {
                    matchups.TryGetValue(oppID, out matchStat);
                    matchups.Remove(oppID);
                }
                totalGames++;
                stat.games++;
                matchStat.games++;
                if (game.first) firstGames++;
                else secondGames++;
                if (game.won)
                {
                    totalWins++;
                    stat.wins++;
                    matchStat.wins++;
                    if (game.first) firstWins++;
                    else secondWins++;
                }
                decks.Add(deckID, stat);
                matchups.Add(oppID, matchStat);
                if (game.opponentCraft == Craft.Forest)
                {
                    forestGames++;
                    if (game.won) forestWins++;
                }
                else if (game.opponentCraft == Craft.Sword)
                {
                    swordGames++;
                    if (game.won) swordWins++;
                }
                else if (game.opponentCraft == Craft.Rune)
                {
                    runeGames++;
                    if (game.won) runeWins++;
                }
                else if (game.opponentCraft == Craft.Dragon)
                {
                    dragonGames++;
                    if (game.won) dragonWins++;
                }
                else if (game.opponentCraft == Craft.Shadow)
                {
                    shadowGames++;
                    if (game.won) shadowWins++;
                }
                else if (game.opponentCraft == Craft.Blood)
                {
                    bloodGames++;
                    if (game.won) bloodWins++;
                }
                else if (game.opponentCraft == Craft.Haven)
                {
                    havenGames++;
                    if (game.won) havenWins++;
                }
            }
            totalWinNumLabel.Text = String.Format("Total: {0} / {1:0.00}%", totalGames, totalWins / totalGames * 100);
            firstWinNumLabel.Text = String.Format("First: {0} / {1:0.00}%", firstGames, firstWins / firstGames * 100);
            secondWinNumLabel.Text = String.Format("Second: {0} / {1:0.00}%", secondGames, secondWins / secondGames * 100);
            forestWinLabel.Text = String.Format("vs Forestcraft: {0} / {1:0.00}%", forestGames, forestWins / forestGames * 100);
            swordWinLabel.Text = String.Format("vs Swordcraft: {0} / {1:0.00}%", swordGames, swordWins / swordGames * 100);
            runeWinLabel.Text = String.Format("vs Runecraft: {0} / {1:0.00}%", runeGames, runeWins / runeGames * 100);
            dragonWinLabel.Text = String.Format("vs Dragoncraft: {0} / {1:0.00}%", dragonGames, dragonWins / dragonGames * 100);
            shadowWinLabel.Text = String.Format("vs Shadowcraft: {0} / {1:0.00}%", shadowGames, shadowWins / shadowGames * 100);
            bloodWinLabel.Text = String.Format("vs Bloodcraft: {0} / {1:0.00}%", bloodGames, bloodWins / bloodGames * 100);
            havenWinLabel.Text = String.Format("vs Havencraft: {0} / {1:0.00}%", havenGames, havenWins / havenGames * 100);

            //decks
            deckDataGrid.Rows.Clear();
            DeckStat results;
            Deck deck;
            foreach (int id in decks.Keys)
            {
                deck = mData.getDeckByID(id);
                if (decks.TryGetValue(id, out results))
                {
                    object[] row = { deck.name, getCraftName(deck.craft), results.games, Math.Round(results.wins / results.games * 100, 2) };
                    deckDataGrid.Rows.Add(row);
                }
            }

            //matchups
            matchupsDataGrid.Rows.Clear();
            foreach (int id in matchups.Keys)
            {
                deck = mData.getDeckByID(id);
                if (matchups.TryGetValue(id, out results))
                {
                    object[] row = { deck.name, getCraftName(deck.craft), results.games, Math.Round(results.wins / results.games * 100, 2) };
                    matchupsDataGrid.Rows.Add(row);
                }
            }

            //grid
            prevGamesDataGrid.Rows.Clear();
            Game curGame;
            for (int i = 0; i < 10; i++)
            {
                if (i == mCurrentGameList.Length)
                {
                    break;
                }
                else
                {
                    curGame = mCurrentGameList[mCurrentGameList.Length - 1 - i];
                    string[] row = { getCraftName(curGame.playerCraft),
                                       mData.getDeckByID(curGame.playerDeckID).name,
                                       getCraftName(curGame.opponentCraft),
                                       curGame.mode.ToString(),
                                       (curGame.first ? "First" : "Second") + (curGame.turns == 0 ? "" : " ("+curGame.turns+"}"),
                                       curGame.won ? "Won" : "Lost" };
                    prevGamesDataGrid.Rows.Add(row);
                    foreach (DataGridViewCell cell in prevGamesDataGrid.Rows[i].Cells)
                    {
                        if (cell is DataGridViewImageCell)
                        {
                            cell.Value = curGame.id < 0 ? Properties.Resources.btn_delete_disabled : Properties.Resources.btn_delete;
                        }
                        else if (curGame.notes != null && curGame.notes.Length > 0)
                        {
                            cell.ToolTipText = "Note: " + curGame.notes;
                        }
                    }
                }
            }
        }

        void filterDeckChanged(object sender, EventArgs e)
        {
            int opponentIndex = opponentDeckSelector.SelectedIndex - 1;
            int playerIndex = playerDeckSelector.SelectedIndex - 1;

            try
            {
                mOpponentDeck = opponentIndex < 0 ? null : mCurrentOpponentDeckList[opponentIndex];
                mSelectedDeck = playerIndex < 0 ? null : mCurrentDeckList[playerIndex];
            }
            catch (Exception x)
            {
                Console.WriteLine("Exception occurred while trying to adjust to changed deck selection: " + x.ToString());
                MessageBox.Show("Filtering by deck failed.");
            }

            updateGames();
        }

        void gameModeChanged(object sender, EventArgs e)
        {
            mSelectedMode = getModeFromIndex(gameModeSelector.SelectedIndex);
            updateGames();
        }

        void turnChanged(object sender, EventArgs e)
        {
            mSelectedTurn = getTurnFromIndex(turnSelector.SelectedIndex);
            updateGames();
        }

        void statsButtonClick(object sender, EventArgs e)
        {
            mViewMode = ViewMode.Stats;
            updateViewPanel();
        }

        void decksButtonClick(object sender, EventArgs e)
        {
            mViewMode = ViewMode.Decks;
            updateViewPanel();
        }

        void matchupsButtonClick(object sender, EventArgs e)
        {
            mViewMode = ViewMode.Matchups;
            updateViewPanel();
        }

        void exportButtonClick(object sender, EventArgs e)
        {
            mData.exportCSV();
        }

        void craftOpponentChanged(object sender, EventArgs e)
        {
            mOpponentCraft = getCraftFromIndex(opponentCraftSelector.SelectedIndex);
            opponentDeckSelector.SelectedIndex = opponentDeckSelector.Items.Count == 0 ? -1 : 0;
            updateDecks();
        }

        void addGameCraftPlayerChanged(object sender, EventArgs e)
        {
            mGameSelectedCraft = getCraftFromIndex(addGamePlayerCraftList.SelectedIndex + 1);
            addGamePlayerDeckList.SelectedIndex = -1;
            updateGameDecks();
        }

        void addGameCraftOpponentChanged(object sender, EventArgs e)
        {
            mGameOpponentCraft = getCraftFromIndex(addGameOpponentCraftList.SelectedIndex + 1);
            addGameOpponentDeckList.SelectedIndex = -1;
            updateGameDecks();
        }

        void addGameButtonClick(object sender, EventArgs e)
        {
            int selectedCraft = addGamePlayerCraftList.SelectedIndex + 1;
            int opponentCraft = addGameOpponentCraftList.SelectedIndex + 1;
            int selectedDeck = addGamePlayerDeckList.SelectedIndex;
            int opponentDeck = addGameOpponentDeckList.SelectedIndex;

            if (selectedDeck >= 0 && opponentDeck >= 0)
            {
                try
                {
                    Craft player = getCraftFromIndex(selectedCraft);
                    Craft opponent = getCraftFromIndex(opponentCraft);
                    Deck pDeck = mGamePlayerDecks[selectedDeck];
                    Deck oDeck = mGameOpponentDecks[opponentDeck];
                    int numTurns = Convert.ToInt32(addGameNumTurnsSelector.Value);
                    string notes = addGameNotesText.Text;
                    mData.addGame(mGameSelectedCraft, mGameOpponentCraft, pDeck, oDeck, mGameFirstSelected, mGameModeSelected, mGameWonSelected, numTurns, notes == null ? "" : notes);
                    addGameNumTurnsSelector.Value = 0;
                    addGameNotesText.Text = "";
                    updateGames();
                }
                catch (Exception x)
                {
                    Console.WriteLine("Exception while trying to add game: " + x.ToString());
                    MessageBox.Show("Failed to add game.");
                }
            }
            else
            {
                Console.WriteLine("Could not add game, invalid params");
                MessageBox.Show("Need to select decks.");
            }
        }

        void addDeckButtonClick(object sender, EventArgs e)
        {
            int selected = addDeckCraftSelector.SelectedIndex + 1;
            string name = addDeckNameText.Text;
            if (selected >= 0 && name != null && name.Length > 0)
            {
                Craft craft = getCraftFromIndex(selected);
                mData.addDeck(craft, name);
                addDeckNameText.Text = "";
                updateDecks();
                updateGameDecks();
            }
            else
            {
                Console.WriteLine("Could not add deck, invalid params");
                MessageBox.Show("Need to enter a deck name.");
            }
        }

        void addGameWinClick(object sender, EventArgs e)
        {
            if (sender == addGameLoseBtn)
            {
                mGameWonSelected = false;
            }
            else if (sender == addGameWinBtn)
            {
                mGameWonSelected = true;
            }
            updateWinButtons();
        }

        void addGameModeClick(object sender, EventArgs e)
        {
            if (sender == addGameRankedBtn)
            {
                mGameModeSelected = Mode.Ranked;
            }
            else if (sender == addGameUnrankedBtn)
            {
                mGameModeSelected = Mode.Unranked;
            }
            else if (sender == addGameTakeTwoBtn)
            {
                mGameModeSelected = Mode.TakeTwo;
            }
            updateModeButtons();
        }

        void addGameTurnClick(object sender, EventArgs e)
        {
            if (sender == addGameFirstBtn)
            {
                mGameFirstSelected = true;
            }
            else if (sender == addGameSecondBtn)
            {
                mGameFirstSelected = false;
            }
            updateTurnButtons();
        }

        void deckDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex >= 0)
            {
                int row = e.RowIndex;
                if (row < mCurrentGameList.Length)
                {
                    Game game = mCurrentGameList[mCurrentGameList.Length - row - 1];
                    if (game.id < 0)
                    {
                        Console.WriteLine("Can't safely delete games with index -1");
                        MessageBox.Show("Sorry, can't safely delete this game as it was not indexed properly.");
                    }
                    else
                    {
                        mData.deleteGame(game.id);
                        updateGames();
                    }
                }
                else
                {
                    Console.WriteLine("Could not remove game in row " + row);
                    MessageBox.Show("Could not remove game.");
                }
            }
        }

        private void updateTurnButtons()
        {
            addGameFirstBtn.BackColor = mGameFirstSelected ? COLOR_BUTTON_LOSE : COLOR_BUTTON;
            addGameSecondBtn.BackColor = mGameFirstSelected ? COLOR_BUTTON : COLOR_BUTTON_SEL;
        }

        private void updateModeButtons()
        {
            addGameRankedBtn.BackColor = mGameModeSelected == Mode.Ranked ? COLOR_BUTTON_SEL : COLOR_BUTTON;
            addGameUnrankedBtn.BackColor = mGameModeSelected == Mode.Unranked ? COLOR_BUTTON_LOSE : COLOR_BUTTON;
            addGameTakeTwoBtn.BackColor = mGameModeSelected == Mode.TakeTwo ? COLOR_BUTTON_SEL : COLOR_BUTTON;
        }

        private void updateWinButtons()
        {
            addGameWinBtn.BackColor = mGameWonSelected ? COLOR_BUTTON_SEL : COLOR_BUTTON;
            addGameLoseBtn.BackColor = mGameWonSelected ? COLOR_BUTTON : COLOR_BUTTON_LOSE;
        }

        private void selectCraft(Craft craft)
        {
            mSelectedCraft = craft;

            playerDeckSelector.SelectedIndex = 0;
            updateUI();
        }

        private void setButtonImages()
        {
            this.buttonAll.BackgroundImage = global::ShadowverseTracker.Properties.Resources.btn_all;
            this.buttonHaven.BackgroundImage = global::ShadowverseTracker.Properties.Resources.btn_haven;
            this.buttonForest.BackgroundImage = global::ShadowverseTracker.Properties.Resources.btn_forest;
            this.buttonBlood.BackgroundImage = global::ShadowverseTracker.Properties.Resources.btn_blood;
            this.buttonSword.BackgroundImage = global::ShadowverseTracker.Properties.Resources.btn_sword;
            this.buttonShadow.BackgroundImage = global::ShadowverseTracker.Properties.Resources.btn_shadow;
            this.buttonRune.BackgroundImage = global::ShadowverseTracker.Properties.Resources.btn_rune;
            this.buttonDragon.BackgroundImage = global::ShadowverseTracker.Properties.Resources.btn_dragon;
            foreach (Control control in this.buttonpanel.Controls)
            {
                if (control is Button)
                {
                    control.BackColor = COLOR_BUTTON;
                }
            }
        }

        void craftButtonClick(object sender, EventArgs e)
        {
            setButtonImages();
            if (sender == buttonAll)
            {
                this.buttonAll.BackgroundImage = global::ShadowverseTracker.Properties.Resources.btn_all_sel;
                this.buttonAll.BackColor = COLOR_BACKGROUND_PANEL;
                selectCraft(Craft.All);
            }
            else if (sender == buttonForest)
            {
                this.buttonForest.BackgroundImage = global::ShadowverseTracker.Properties.Resources.btn_forest_sel;
                this.buttonForest.BackColor = COLOR_BACKGROUND_PANEL;
                selectCraft(Craft.Forest);
            }
            else if (sender == buttonSword)
            {
                this.buttonSword.BackgroundImage = global::ShadowverseTracker.Properties.Resources.btn_sword_sel;
                this.buttonSword.BackColor = COLOR_BACKGROUND_PANEL;
                selectCraft(Craft.Sword);
            }
            else if (sender == buttonRune)
            {
                this.buttonRune.BackgroundImage = global::ShadowverseTracker.Properties.Resources.btn_rune_sel;
                this.buttonRune.BackColor = COLOR_BACKGROUND_PANEL;
                selectCraft(Craft.Rune);
            }
            else if (sender == buttonDragon)
            {
                this.buttonDragon.BackgroundImage = global::ShadowverseTracker.Properties.Resources.btn_dragon_sel;
                this.buttonDragon.BackColor = COLOR_BACKGROUND_PANEL;
                selectCraft(Craft.Dragon);
            }
            else if (sender == buttonShadow)
            {
                this.buttonShadow.BackgroundImage = global::ShadowverseTracker.Properties.Resources.btn_shadow_sel;
                this.buttonShadow.BackColor = COLOR_BACKGROUND_PANEL;
                selectCraft(Craft.Shadow);
            }
            else if (sender == buttonBlood)
            {
                this.buttonBlood.BackgroundImage = global::ShadowverseTracker.Properties.Resources.btn_blood_sel;
                this.buttonBlood.BackColor = COLOR_BACKGROUND_PANEL;
                selectCraft(Craft.Blood);
            }
            else if (sender == buttonHaven)
            {
                this.buttonHaven.BackgroundImage = global::ShadowverseTracker.Properties.Resources.btn_haven_sel;
                this.buttonHaven.BackColor = COLOR_BACKGROUND_PANEL;
                selectCraft(Craft.Haven);
            }
        }

        private Craft getCraftFromName(string name)
        {
            if (name.Equals(getCraftName(Craft.Forest)))
            {
                return Craft.Forest;
            }
            else if (name.Equals(getCraftName(Craft.Sword)))
            {
                return Craft.Sword;
            }
            else if (name.Equals(getCraftName(Craft.Rune)))
            {
                return Craft.Rune;
            }
            else if (name.Equals(getCraftName(Craft.Dragon)))
            {
                return Craft.Dragon;
            }
            else if (name.Equals(getCraftName(Craft.Shadow)))
            {
                return Craft.Shadow;
            }
            else if (name.Equals(getCraftName(Craft.Blood)))
            {
                return Craft.Blood;
            }
            else if (name.Equals(getCraftName(Craft.Haven)))
            {
                return Craft.Haven;
            }
            return Craft.All;
        }

        private Craft getCraftFromIndex(int index)
        {
            switch (index)
            {
                case 0: return Craft.All;
                case 1: return Craft.Forest;
                case 2: return Craft.Sword;
                case 3: return Craft.Rune;
                case 4: return Craft.Dragon;
                case 5: return Craft.Shadow;
                case 6: return Craft.Blood;
                case 7: return Craft.Haven;
            }
            return Craft.All;
        }

        private string getCraftName(Craft craft)
        {
            switch (craft)
            {
                case Craft.All: return CRAFTLIST[0];
                case Craft.Forest: return CRAFTLIST[1];
                case Craft.Sword: return CRAFTLIST[2];
                case Craft.Rune: return CRAFTLIST[3];
                case Craft.Dragon: return CRAFTLIST[4];
                case Craft.Shadow: return CRAFTLIST[5];
                case Craft.Blood: return CRAFTLIST[6];
                case Craft.Haven: return CRAFTLIST[7];
            }
            return "Unknown";
        }

        private Mode getModeFromIndex(int index)
        {
            switch (index)
            {
                case 0: return Mode.All;
                case 1: return Mode.Ranked;
                case 2: return Mode.Unranked;
                case 3: return Mode.TakeTwo;
            }
            return Mode.All;
        }

        private Mode getModeFromName(string name)
        {
            if (name.Equals(getModeName(Mode.Ranked)))
            {
                return Mode.Ranked;
            }
            else if (name.Equals(getModeName(Mode.Unranked)))
            {
                return Mode.Unranked;
            }
            else if (name.Equals(getModeName(Mode.TakeTwo)))
            {
                return Mode.TakeTwo;
            }
            return Mode.All;
        }

        private string getModeName(Mode mode)
        {
            switch (mode)
            {
                case Mode.All:
                    return MODELIST[0];
                case Mode.Ranked:
                    return MODELIST[1];
                case Mode.Unranked:
                    return MODELIST[2];
                case Mode.TakeTwo:
                    return MODELIST[3];
            }
            return "Unknown";
        }

        private Turn getTurnFromIndex(int index)
        {
            switch (index)
            {
                case 0: return Turn.All;
                case 1: return Turn.First;
                case 2: return Turn.Second;
            }
            return Turn.All;
        }

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont,uint cbFont, 
          IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection pfc = new PrivateFontCollection();

        private void customColours()
        {
            /* Custom Colours */
            try
            {
                unsafe
                {
                    fixed (byte* pFontData = Properties.Resources.roboto)
                    {
                        uint dummy = 0;
                        pfc.AddMemoryFont((IntPtr)pFontData, Properties.Resources.roboto.Length);
                        AddFontMemResourceEx((IntPtr)pFontData, (uint)Properties.Resources.roboto.Length, IntPtr.Zero, ref dummy);
                    }
                }
            }
            catch (Exception x)
            {
                Console.WriteLine("failed to load font " + x.ToString());
            }
            Font defFont = pfc.Families.Length > 0 ? new Font(pfc.Families[0], 9, FontStyle.Bold) : new Font(FontFamily.GenericSansSerif, 9, FontStyle.Regular);

            this.BackColor = COLOR_BACKGROUND;
            this.filtersPanel.BackColor = COLOR_BACKGROUND_PANEL;
            this.dataPanel.BackColor = COLOR_BACKGROUND_PANEL;
            this.addDeckPanel.BackColor = COLOR_BACKGROUND_PANEL;
            this.addGamePanel.BackColor = COLOR_BACKGROUND_PANEL;
            this.statsPanel.BackColor = COLOR_BACKGROUND_PANEL;
            this.decksPanel.BackColor = COLOR_BACKGROUND_PANEL;
            this.statsDividerPanel.BackColor = COLOR_BEIGE;
            DataGridViewCellStyle rowStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle alternateRowStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            rowStyle.BackColor = COLOR_BEIGE;
            rowStyle.SelectionBackColor = COLOR_BEIGE;
            rowStyle.Font = defFont;
            rowStyle.ForeColor = COLOR_DARK_BLUE;
            rowStyle.SelectionForeColor = COLOR_DARK_BLUE;
            alternateRowStyle.BackColor = COLOR_BEIGE2;
            alternateRowStyle.SelectionBackColor = COLOR_BEIGE2;
            alternateRowStyle.Font = defFont;
            alternateRowStyle.ForeColor = COLOR_DARK_BLUE;
            alternateRowStyle.SelectionForeColor = COLOR_DARK_BLUE;
            headerStyle.BackColor = COLOR_LIGHT_BLUE;
            headerStyle.SelectionBackColor = COLOR_LIGHT_BLUE;
            headerStyle.ForeColor = COLOR_BEIGE;
            headerStyle.SelectionForeColor = COLOR_BEIGE;
            headerStyle.Font = defFont;
            this.deckDataGrid.BackgroundColor = COLOR_BACKGROUND_PANEL;
            this.deckDataGrid.RowsDefaultCellStyle = rowStyle;
            this.deckDataGrid.AlternatingRowsDefaultCellStyle = alternateRowStyle;
            this.deckDataGrid.ColumnHeadersDefaultCellStyle = headerStyle;
            this.deckDataGrid.EnableHeadersVisualStyles = false;
            this.deckDataGrid.BorderStyle = BorderStyle.None;
            this.prevGamesDataGrid.BackgroundColor = COLOR_BACKGROUND_PANEL;
            this.prevGamesDataGrid.RowsDefaultCellStyle = rowStyle;
            this.prevGamesDataGrid.AlternatingRowsDefaultCellStyle = alternateRowStyle;
            this.prevGamesDataGrid.ColumnHeadersDefaultCellStyle = headerStyle;
            this.prevGamesDataGrid.EnableHeadersVisualStyles = false;
            this.prevGamesDataGrid.BorderStyle = BorderStyle.None;
            this.matchupsDataGrid.BackgroundColor = COLOR_BACKGROUND_PANEL;
            this.matchupsDataGrid.RowsDefaultCellStyle = rowStyle;
            this.matchupsDataGrid.AlternatingRowsDefaultCellStyle = alternateRowStyle;
            this.matchupsDataGrid.ColumnHeadersDefaultCellStyle = headerStyle;
            this.matchupsDataGrid.EnableHeadersVisualStyles = false;
            this.matchupsDataGrid.BorderStyle = BorderStyle.None;
            foreach (Control control in this.buttonpanel.Controls)
            {
                if (control is Button)
                {
                    control.BackColor = COLOR_BUTTON;
                    control.ForeColor = COLOR_BEIGE;
                    ((Button)control).FlatAppearance.BorderSize = 0;
                }
            }
            foreach (Control control in this.dataPanel.Controls)
            {
                if (control is Button)
                {
                    control.BackColor = COLOR_BUTTON;
                    control.ForeColor = COLOR_BEIGE;
                    control.Font = defFont;
                }
                else if (control is Label)
                {
                    control.ForeColor = COLOR_BEIGE;
                    control.Font = defFont;
                }
            }
            foreach (Control control in this.statsPanel.Controls)
            {
                if (control is Label)
                {
                    control.ForeColor = COLOR_BEIGE;
                    control.Font = defFont;
                }
            }
            foreach (Control control in this.filtersPanel.Controls)
            {
                if (control is Label)
                {
                    control.ForeColor = COLOR_BEIGE;
                    control.Font = defFont;
                }
                else if (control is ComboBox)
                {
                    control.BackColor = COLOR_LIGHT_BLUE;
                    control.ForeColor = COLOR_BEIGE;
                    ((ComboBox)control).FlatStyle = FlatStyle.Flat;
                    ((ComboBox)control).Font = new Font(pfc.Families[0], 9, FontStyle.Bold);
                }
            }
            foreach (Control control in this.addDeckPanel.Controls)
            {
                if (control is Label)
                {
                    control.ForeColor = COLOR_BEIGE;
                    control.Font = defFont;
                }
                else if (control is ComboBox)
                {
                    control.BackColor = COLOR_LIGHT_BLUE;
                    control.ForeColor = COLOR_BEIGE;
                    ((ComboBox)control).FlatStyle = FlatStyle.Flat;
                    ((ComboBox)control).Font = defFont;
                }
                else if (control is TextBox)
                {
                    control.BackColor = COLOR_LIGHT_BLUE;
                    control.ForeColor = COLOR_BEIGE;
                    control.Font = defFont;
                }
                else if (control is Button)
                {
                    control.BackColor = COLOR_BUTTON;
                    control.ForeColor = COLOR_BEIGE;
                    control.Font = defFont;
                }
            }
            foreach (Control control in this.addGamePanel.Controls)
            {
                if (control is Label)
                {
                    control.ForeColor = COLOR_BEIGE;
                    control.Font = defFont;
                }
                else if (control is ComboBox)
                {
                    control.BackColor = COLOR_LIGHT_BLUE;
                    control.ForeColor = COLOR_BEIGE;
                    ((ComboBox)control).FlatStyle = FlatStyle.Flat;
                    ((ComboBox)control).Font = defFont;
                }
                else if (control is TextBox)
                {
                    control.BackColor = COLOR_LIGHT_BLUE;
                    control.ForeColor = COLOR_BEIGE;
                    control.Font = defFont;
                }
                else if (control is NumericUpDown)
                {
                    control.BackColor = COLOR_LIGHT_BLUE;
                    control.ForeColor = COLOR_BEIGE;
                    control.Font = defFont;
                }
                else if (control is Button)
                {
                    control.BackColor = COLOR_BUTTON;
                    control.ForeColor = COLOR_BEIGE;
                    control.Font = defFont;
                }
            }
        }

        private class DeckStat
        {
            public long games = 0;
            public double wins = 0;

            public DeckStat()
            {

            }
        }
    }
}
