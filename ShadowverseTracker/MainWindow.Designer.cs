using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System;
namespace ShadowverseTracker
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonpanel = new System.Windows.Forms.Panel();
            this.buttonAll = new System.Windows.Forms.Button();
            this.buttonHaven = new System.Windows.Forms.Button();
            this.buttonForest = new System.Windows.Forms.Button();
            this.buttonBlood = new System.Windows.Forms.Button();
            this.buttonSword = new System.Windows.Forms.Button();
            this.buttonShadow = new System.Windows.Forms.Button();
            this.buttonRune = new System.Windows.Forms.Button();
            this.buttonDragon = new System.Windows.Forms.Button();
            this.dataPanel = new System.Windows.Forms.Panel();
            this.exportButton = new System.Windows.Forms.Button();
            this.matchupsButton = new System.Windows.Forms.Button();
            this.prevGamesLabel = new System.Windows.Forms.Label();
            this.decksPanel = new System.Windows.Forms.Panel();
            this.deckDataGrid = new System.Windows.Forms.DataGridView();
            this.decksNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deckCraftsCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.decksGamesCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.decksWinCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statsPanel = new System.Windows.Forms.Panel();
            this.statsDividerPanel = new System.Windows.Forms.Panel();
            this.bloodWinLabel = new System.Windows.Forms.Label();
            this.runeWinLabel = new System.Windows.Forms.Label();
            this.shadowWinLabel = new System.Windows.Forms.Label();
            this.swordWinLabel = new System.Windows.Forms.Label();
            this.havenWinLabel = new System.Windows.Forms.Label();
            this.dragonWinLabel = new System.Windows.Forms.Label();
            this.forestWinLabel = new System.Windows.Forms.Label();
            this.hintLabel = new System.Windows.Forms.Label();
            this.totalWinNumLabel = new System.Windows.Forms.Label();
            this.matchupsPanel = new System.Windows.Forms.Panel();
            this.matchupsDataGrid = new System.Windows.Forms.DataGridView();
            this.matchupsNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matchupsCraftCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matchupsGamesCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matchupsWinCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.decksButton = new System.Windows.Forms.Button();
            this.statsButton = new System.Windows.Forms.Button();
            this.prevGamesDataGrid = new System.Windows.Forms.DataGridView();
            this.craftCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deckCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opponentCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteCol = new System.Windows.Forms.DataGridViewImageColumn();
            this.labelPlayerDeck = new System.Windows.Forms.Label();
            this.playerDeckSelector = new System.Windows.Forms.ComboBox();
            this.addDeckPanel = new System.Windows.Forms.Panel();
            this.addDeckButton = new System.Windows.Forms.Button();
            this.addDeckNameText = new System.Windows.Forms.TextBox();
            this.addDeckNameLabel = new System.Windows.Forms.Label();
            this.addDeckCraftSelector = new System.Windows.Forms.ComboBox();
            this.addDeckCraftLabel = new System.Windows.Forms.Label();
            this.addDeckLabel = new System.Windows.Forms.Label();
            this.addGamePanel = new System.Windows.Forms.Panel();
            this.addGameNumTurnsSelector = new System.Windows.Forms.NumericUpDown();
            this.addGameNotesText = new System.Windows.Forms.TextBox();
            this.addGameNotesLabel = new System.Windows.Forms.Label();
            this.addGameTakeTwoBtn = new System.Windows.Forms.Button();
            this.addGameNumTurnsLabel = new System.Windows.Forms.Label();
            this.addGameUnrankedBtn = new System.Windows.Forms.Button();
            this.addGameRankedBtn = new System.Windows.Forms.Button();
            this.addGameFirstBtn = new System.Windows.Forms.Button();
            this.addGameSecondBtn = new System.Windows.Forms.Button();
            this.addGameButton = new System.Windows.Forms.Button();
            this.addGameLoseBtn = new System.Windows.Forms.Button();
            this.addGameWinBtn = new System.Windows.Forms.Button();
            this.addGameOpponentDeckList = new System.Windows.Forms.ComboBox();
            this.addGameOpponentDeckLabel = new System.Windows.Forms.Label();
            this.addGamePlayerDeckList = new System.Windows.Forms.ComboBox();
            this.addGamePlayerDeckLabel = new System.Windows.Forms.Label();
            this.addGameOpponentCraftList = new System.Windows.Forms.ComboBox();
            this.addGameOpponentCraftLabel = new System.Windows.Forms.Label();
            this.addGamePlayerCraftList = new System.Windows.Forms.ComboBox();
            this.addGamePlayerCraftLabel = new System.Windows.Forms.Label();
            this.addGameLabel = new System.Windows.Forms.Label();
            this.opponentCraftSelector = new System.Windows.Forms.ComboBox();
            this.labelCraft = new System.Windows.Forms.Label();
            this.opponentDeckSelector = new System.Windows.Forms.ComboBox();
            this.labelOpponentDeck = new System.Windows.Forms.Label();
            this.gameModeSelector = new System.Windows.Forms.ComboBox();
            this.labelGameMode = new System.Windows.Forms.Label();
            this.filtersPanel = new System.Windows.Forms.Panel();
            this.turnSelector = new System.Windows.Forms.ComboBox();
            this.labelTurn = new System.Windows.Forms.Label();
            this.firstWinNumLabel = new System.Windows.Forms.Label();
            this.secondWinNumLabel = new System.Windows.Forms.Label();
            this.buttonpanel.SuspendLayout();
            this.dataPanel.SuspendLayout();
            this.decksPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deckDataGrid)).BeginInit();
            this.statsPanel.SuspendLayout();
            this.matchupsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matchupsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prevGamesDataGrid)).BeginInit();
            this.addDeckPanel.SuspendLayout();
            this.addGamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addGameNumTurnsSelector)).BeginInit();
            this.filtersPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonpanel
            // 
            this.buttonpanel.Controls.Add(this.buttonAll);
            this.buttonpanel.Controls.Add(this.buttonHaven);
            this.buttonpanel.Controls.Add(this.buttonForest);
            this.buttonpanel.Controls.Add(this.buttonBlood);
            this.buttonpanel.Controls.Add(this.buttonSword);
            this.buttonpanel.Controls.Add(this.buttonShadow);
            this.buttonpanel.Controls.Add(this.buttonRune);
            this.buttonpanel.Controls.Add(this.buttonDragon);
            this.buttonpanel.Location = new System.Drawing.Point(0, 1);
            this.buttonpanel.Name = "buttonpanel";
            this.buttonpanel.Size = new System.Drawing.Size(107, 628);
            this.buttonpanel.TabIndex = 8;
            // 
            // buttonAll
            // 
            this.buttonAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAll.Location = new System.Drawing.Point(0, 0);
            this.buttonAll.Name = "buttonAll";
            this.buttonAll.Size = new System.Drawing.Size(105, 78);
            this.buttonAll.TabIndex = 0;
            // 
            // buttonHaven
            // 
            this.buttonHaven.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonHaven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHaven.Location = new System.Drawing.Point(0, 546);
            this.buttonHaven.Name = "buttonHaven";
            this.buttonHaven.Size = new System.Drawing.Size(105, 78);
            this.buttonHaven.TabIndex = 7;
            // 
            // buttonForest
            // 
            this.buttonForest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonForest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonForest.Location = new System.Drawing.Point(0, 78);
            this.buttonForest.Name = "buttonForest";
            this.buttonForest.Size = new System.Drawing.Size(105, 78);
            this.buttonForest.TabIndex = 1;
            // 
            // buttonBlood
            // 
            this.buttonBlood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBlood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBlood.Location = new System.Drawing.Point(0, 468);
            this.buttonBlood.Name = "buttonBlood";
            this.buttonBlood.Size = new System.Drawing.Size(105, 78);
            this.buttonBlood.TabIndex = 6;
            // 
            // buttonSword
            // 
            this.buttonSword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSword.Location = new System.Drawing.Point(0, 156);
            this.buttonSword.Name = "buttonSword";
            this.buttonSword.Size = new System.Drawing.Size(105, 78);
            this.buttonSword.TabIndex = 2;
            // 
            // buttonShadow
            // 
            this.buttonShadow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonShadow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShadow.Location = new System.Drawing.Point(0, 390);
            this.buttonShadow.Name = "buttonShadow";
            this.buttonShadow.Size = new System.Drawing.Size(105, 78);
            this.buttonShadow.TabIndex = 5;
            // 
            // buttonRune
            // 
            this.buttonRune.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRune.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRune.Location = new System.Drawing.Point(0, 234);
            this.buttonRune.Name = "buttonRune";
            this.buttonRune.Size = new System.Drawing.Size(105, 78);
            this.buttonRune.TabIndex = 3;
            // 
            // buttonDragon
            // 
            this.buttonDragon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDragon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDragon.Location = new System.Drawing.Point(0, 312);
            this.buttonDragon.Name = "buttonDragon";
            this.buttonDragon.Size = new System.Drawing.Size(105, 78);
            this.buttonDragon.TabIndex = 4;
            // 
            // dataPanel
            // 
            this.dataPanel.Controls.Add(this.exportButton);
            this.dataPanel.Controls.Add(this.matchupsButton);
            this.dataPanel.Controls.Add(this.prevGamesLabel);
            this.dataPanel.Controls.Add(this.decksPanel);
            this.dataPanel.Controls.Add(this.statsPanel);
            this.dataPanel.Controls.Add(this.matchupsPanel);
            this.dataPanel.Controls.Add(this.decksButton);
            this.dataPanel.Controls.Add(this.statsButton);
            this.dataPanel.Controls.Add(this.prevGamesDataGrid);
            this.dataPanel.Location = new System.Drawing.Point(109, 136);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(561, 493);
            this.dataPanel.TabIndex = 9;
            // 
            // exportButton
            // 
            this.exportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportButton.Location = new System.Drawing.Point(482, 142);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(72, 37);
            this.exportButton.TabIndex = 27;
            this.exportButton.Text = "Export";
            // 
            // matchupsButton
            // 
            this.matchupsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.matchupsButton.Location = new System.Drawing.Point(482, 96);
            this.matchupsButton.Name = "matchupsButton";
            this.matchupsButton.Size = new System.Drawing.Size(72, 37);
            this.matchupsButton.TabIndex = 26;
            this.matchupsButton.Text = "Matchups";
            // 
            // prevGamesLabel
            // 
            this.prevGamesLabel.AutoSize = true;
            this.prevGamesLabel.Location = new System.Drawing.Point(-3, 226);
            this.prevGamesLabel.Name = "prevGamesLabel";
            this.prevGamesLabel.Size = new System.Drawing.Size(134, 13);
            this.prevGamesLabel.TabIndex = 25;
            this.prevGamesLabel.Text = "Latest 10 Matching Games";
            // 
            // decksPanel
            // 
            this.decksPanel.Controls.Add(this.deckDataGrid);
            this.decksPanel.Location = new System.Drawing.Point(1, 2);
            this.decksPanel.Name = "decksPanel";
            this.decksPanel.Size = new System.Drawing.Size(479, 209);
            this.decksPanel.TabIndex = 24;
            // 
            // deckDataGrid
            // 
            this.deckDataGrid.AllowUserToAddRows = false;
            this.deckDataGrid.AllowUserToDeleteRows = false;
            this.deckDataGrid.AllowUserToResizeColumns = false;
            this.deckDataGrid.AllowUserToResizeRows = false;
            this.deckDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deckDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.decksNameCol,
            this.deckCraftsCol,
            this.decksGamesCol,
            this.decksWinCol});
            this.deckDataGrid.Location = new System.Drawing.Point(1, 2);
            this.deckDataGrid.Name = "deckDataGrid";
            this.deckDataGrid.ReadOnly = true;
            this.deckDataGrid.RowHeadersVisible = false;
            this.deckDataGrid.Size = new System.Drawing.Size(476, 206);
            this.deckDataGrid.TabIndex = 0;
            // 
            // decksNameCol
            // 
            this.decksNameCol.HeaderText = "Deck";
            this.decksNameCol.MinimumWidth = 250;
            this.decksNameCol.Name = "decksNameCol";
            this.decksNameCol.ReadOnly = true;
            this.decksNameCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.decksNameCol.Width = 250;
            // 
            // deckCraftsCol
            // 
            this.deckCraftsCol.HeaderText = "Craft";
            this.deckCraftsCol.MinimumWidth = 85;
            this.deckCraftsCol.Name = "deckCraftsCol";
            this.deckCraftsCol.ReadOnly = true;
            this.deckCraftsCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.deckCraftsCol.Width = 85;
            // 
            // decksGamesCol
            // 
            this.decksGamesCol.HeaderText = "Games";
            this.decksGamesCol.MinimumWidth = 60;
            this.decksGamesCol.Name = "decksGamesCol";
            this.decksGamesCol.ReadOnly = true;
            this.decksGamesCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.decksGamesCol.Width = 60;
            // 
            // decksWinCol
            // 
            this.decksWinCol.HeaderText = "Win %";
            this.decksWinCol.MinimumWidth = 60;
            this.decksWinCol.Name = "decksWinCol";
            this.decksWinCol.ReadOnly = true;
            this.decksWinCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.decksWinCol.Width = 60;
            // 
            // statsPanel
            // 
            this.statsPanel.Controls.Add(this.secondWinNumLabel);
            this.statsPanel.Controls.Add(this.firstWinNumLabel);
            this.statsPanel.Controls.Add(this.statsDividerPanel);
            this.statsPanel.Controls.Add(this.bloodWinLabel);
            this.statsPanel.Controls.Add(this.runeWinLabel);
            this.statsPanel.Controls.Add(this.shadowWinLabel);
            this.statsPanel.Controls.Add(this.swordWinLabel);
            this.statsPanel.Controls.Add(this.havenWinLabel);
            this.statsPanel.Controls.Add(this.dragonWinLabel);
            this.statsPanel.Controls.Add(this.forestWinLabel);
            this.statsPanel.Controls.Add(this.hintLabel);
            this.statsPanel.Controls.Add(this.totalWinNumLabel);
            this.statsPanel.Location = new System.Drawing.Point(1, 2);
            this.statsPanel.Name = "statsPanel";
            this.statsPanel.Size = new System.Drawing.Size(476, 206);
            this.statsPanel.TabIndex = 23;
            // 
            // statsDividerPanel
            // 
            this.statsDividerPanel.Location = new System.Drawing.Point(0, 51);
            this.statsDividerPanel.Name = "statsDividerPanel";
            this.statsDividerPanel.Size = new System.Drawing.Size(478, 2);
            this.statsDividerPanel.TabIndex = 9;
            // 
            // bloodWinLabel
            // 
            this.bloodWinLabel.AutoSize = true;
            this.bloodWinLabel.Location = new System.Drawing.Point(323, 115);
            this.bloodWinLabel.Name = "bloodWinLabel";
            this.bloodWinLabel.Size = new System.Drawing.Size(58, 13);
            this.bloodWinLabel.TabIndex = 8;
            this.bloodWinLabel.Text = "Bloodcraft:";
            // 
            // runeWinLabel
            // 
            this.runeWinLabel.AutoSize = true;
            this.runeWinLabel.Location = new System.Drawing.Point(323, 75);
            this.runeWinLabel.Name = "runeWinLabel";
            this.runeWinLabel.Size = new System.Drawing.Size(57, 13);
            this.runeWinLabel.TabIndex = 7;
            this.runeWinLabel.Text = "Runecraft:";
            // 
            // shadowWinLabel
            // 
            this.shadowWinLabel.AutoSize = true;
            this.shadowWinLabel.Location = new System.Drawing.Point(165, 118);
            this.shadowWinLabel.Name = "shadowWinLabel";
            this.shadowWinLabel.Size = new System.Drawing.Size(70, 13);
            this.shadowWinLabel.TabIndex = 6;
            this.shadowWinLabel.Text = "Shadowcraft:";
            // 
            // swordWinLabel
            // 
            this.swordWinLabel.AutoSize = true;
            this.swordWinLabel.Location = new System.Drawing.Point(165, 75);
            this.swordWinLabel.Name = "swordWinLabel";
            this.swordWinLabel.Size = new System.Drawing.Size(61, 13);
            this.swordWinLabel.TabIndex = 5;
            this.swordWinLabel.Text = "Swordcraft:";
            // 
            // havenWinLabel
            // 
            this.havenWinLabel.AutoSize = true;
            this.havenWinLabel.Location = new System.Drawing.Point(4, 163);
            this.havenWinLabel.Name = "havenWinLabel";
            this.havenWinLabel.Size = new System.Drawing.Size(63, 13);
            this.havenWinLabel.TabIndex = 4;
            this.havenWinLabel.Text = "Havencraft:";
            // 
            // dragonWinLabel
            // 
            this.dragonWinLabel.AutoSize = true;
            this.dragonWinLabel.Location = new System.Drawing.Point(4, 118);
            this.dragonWinLabel.Name = "dragonWinLabel";
            this.dragonWinLabel.Size = new System.Drawing.Size(66, 13);
            this.dragonWinLabel.TabIndex = 3;
            this.dragonWinLabel.Text = "Dragoncraft:";
            // 
            // forestWinLabel
            // 
            this.forestWinLabel.AutoSize = true;
            this.forestWinLabel.Location = new System.Drawing.Point(4, 75);
            this.forestWinLabel.Name = "forestWinLabel";
            this.forestWinLabel.Size = new System.Drawing.Size(60, 13);
            this.forestWinLabel.TabIndex = 2;
            this.forestWinLabel.Text = "Forestcraft:";
            // 
            // hintLabel
            // 
            this.hintLabel.AutoSize = true;
            this.hintLabel.Location = new System.Drawing.Point(4, 6);
            this.hintLabel.Name = "hintLabel";
            this.hintLabel.Size = new System.Drawing.Size(159, 13);
            this.hintLabel.TabIndex = 1;
            this.hintLabel.Text = "Statistics (Total Games / Win %)";
            // 
            // totalWinNumLabel
            // 
            this.totalWinNumLabel.AutoSize = true;
            this.totalWinNumLabel.Location = new System.Drawing.Point(4, 29);
            this.totalWinNumLabel.Name = "totalWinNumLabel";
            this.totalWinNumLabel.Size = new System.Drawing.Size(37, 13);
            this.totalWinNumLabel.TabIndex = 0;
            this.totalWinNumLabel.Text = "Total: ";
            // 
            // matchupsPanel
            // 
            this.matchupsPanel.Controls.Add(this.matchupsDataGrid);
            this.matchupsPanel.Location = new System.Drawing.Point(1, 2);
            this.matchupsPanel.Name = "matchupsPanel";
            this.matchupsPanel.Size = new System.Drawing.Size(476, 206);
            this.matchupsPanel.TabIndex = 24;
            // 
            // matchupsDataGrid
            // 
            this.matchupsDataGrid.AllowUserToAddRows = false;
            this.matchupsDataGrid.AllowUserToDeleteRows = false;
            this.matchupsDataGrid.AllowUserToResizeColumns = false;
            this.matchupsDataGrid.AllowUserToResizeRows = false;
            this.matchupsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matchupsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matchupsNameCol,
            this.matchupsCraftCol,
            this.matchupsGamesCol,
            this.matchupsWinCol});
            this.matchupsDataGrid.Location = new System.Drawing.Point(1, 2);
            this.matchupsDataGrid.Name = "matchupsDataGrid";
            this.matchupsDataGrid.ReadOnly = true;
            this.matchupsDataGrid.RowHeadersVisible = false;
            this.matchupsDataGrid.Size = new System.Drawing.Size(476, 206);
            this.matchupsDataGrid.TabIndex = 0;
            // 
            // matchupsNameCol
            // 
            this.matchupsNameCol.HeaderText = "vs Deck";
            this.matchupsNameCol.MinimumWidth = 250;
            this.matchupsNameCol.Name = "matchupsNameCol";
            this.matchupsNameCol.ReadOnly = true;
            this.matchupsNameCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.matchupsNameCol.Width = 250;
            // 
            // matchupsCraftCol
            // 
            this.matchupsCraftCol.HeaderText = "Craft";
            this.matchupsCraftCol.MinimumWidth = 85;
            this.matchupsCraftCol.Name = "matchupsCraftCol";
            this.matchupsCraftCol.ReadOnly = true;
            this.matchupsCraftCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.matchupsCraftCol.Width = 85;
            // 
            // matchupsGamesCol
            // 
            this.matchupsGamesCol.HeaderText = "Games";
            this.matchupsGamesCol.MinimumWidth = 60;
            this.matchupsGamesCol.Name = "matchupsGamesCol";
            this.matchupsGamesCol.ReadOnly = true;
            this.matchupsGamesCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.matchupsGamesCol.Width = 60;
            // 
            // matchupsWinCol
            // 
            this.matchupsWinCol.HeaderText = "Win %";
            this.matchupsWinCol.MinimumWidth = 60;
            this.matchupsWinCol.Name = "matchupsWinCol";
            this.matchupsWinCol.ReadOnly = true;
            this.matchupsWinCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.matchupsWinCol.Width = 60;
            // 
            // decksButton
            // 
            this.decksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decksButton.Location = new System.Drawing.Point(482, 50);
            this.decksButton.Name = "decksButton";
            this.decksButton.Size = new System.Drawing.Size(72, 37);
            this.decksButton.TabIndex = 22;
            this.decksButton.Text = "Decks";
            // 
            // statsButton
            // 
            this.statsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statsButton.Location = new System.Drawing.Point(482, 4);
            this.statsButton.Name = "statsButton";
            this.statsButton.Size = new System.Drawing.Size(72, 37);
            this.statsButton.TabIndex = 21;
            this.statsButton.Text = "Wins";
            // 
            // prevGamesDataGrid
            // 
            this.prevGamesDataGrid.AllowUserToAddRows = false;
            this.prevGamesDataGrid.AllowUserToDeleteRows = false;
            this.prevGamesDataGrid.AllowUserToResizeColumns = false;
            this.prevGamesDataGrid.AllowUserToResizeRows = false;
            this.prevGamesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prevGamesDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.craftCol,
            this.deckCol,
            this.opponentCol,
            this.modeCol,
            this.turnCol,
            this.resultCol,
            this.deleteCol});
            this.prevGamesDataGrid.Location = new System.Drawing.Point(0, 246);
            this.prevGamesDataGrid.Name = "prevGamesDataGrid";
            this.prevGamesDataGrid.ReadOnly = true;
            this.prevGamesDataGrid.RowHeadersVisible = false;
            this.prevGamesDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.prevGamesDataGrid.Size = new System.Drawing.Size(555, 243);
            this.prevGamesDataGrid.TabIndex = 0;
            // 
            // craftCol
            // 
            this.craftCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.craftCol.HeaderText = "Craft";
            this.craftCol.MinimumWidth = 91;
            this.craftCol.Name = "craftCol";
            this.craftCol.ReadOnly = true;
            this.craftCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.craftCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.craftCol.Width = 91;
            // 
            // deckCol
            // 
            this.deckCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.deckCol.HeaderText = "Deck";
            this.deckCol.MinimumWidth = 123;
            this.deckCol.Name = "deckCol";
            this.deckCol.ReadOnly = true;
            this.deckCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.deckCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.deckCol.Width = 123;
            // 
            // opponentCol
            // 
            this.opponentCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.opponentCol.HeaderText = "Opponent";
            this.opponentCol.MinimumWidth = 91;
            this.opponentCol.Name = "opponentCol";
            this.opponentCol.ReadOnly = true;
            this.opponentCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.opponentCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.opponentCol.Width = 91;
            // 
            // modeCol
            // 
            this.modeCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.modeCol.HeaderText = "Mode";
            this.modeCol.MinimumWidth = 85;
            this.modeCol.Name = "modeCol";
            this.modeCol.ReadOnly = true;
            this.modeCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.modeCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.modeCol.Width = 85;
            // 
            // turnCol
            // 
            this.turnCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.turnCol.HeaderText = "Turn (Num)";
            this.turnCol.MinimumWidth = 80;
            this.turnCol.Name = "turnCol";
            this.turnCol.ReadOnly = true;
            this.turnCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.turnCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.turnCol.Width = 80;
            // 
            // resultCol
            // 
            this.resultCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.resultCol.HeaderText = "Result";
            this.resultCol.MinimumWidth = 50;
            this.resultCol.Name = "resultCol";
            this.resultCol.ReadOnly = true;
            this.resultCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.resultCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.resultCol.Width = 50;
            // 
            // deleteCol
            // 
            this.deleteCol.HeaderText = "";
            this.deleteCol.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.deleteCol.MinimumWidth = 30;
            this.deleteCol.Name = "deleteCol";
            this.deleteCol.ReadOnly = true;
            this.deleteCol.Width = 30;
            // 
            // labelPlayerDeck
            // 
            this.labelPlayerDeck.AutoSize = true;
            this.labelPlayerDeck.Location = new System.Drawing.Point(5, 56);
            this.labelPlayerDeck.Name = "labelPlayerDeck";
            this.labelPlayerDeck.Size = new System.Drawing.Size(68, 13);
            this.labelPlayerDeck.TabIndex = 10;
            this.labelPlayerDeck.Text = "Player Deck:";
            // 
            // playerDeckSelector
            // 
            this.playerDeckSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.playerDeckSelector.FormattingEnabled = true;
            this.playerDeckSelector.Location = new System.Drawing.Point(227, 53);
            this.playerDeckSelector.Name = "playerDeckSelector";
            this.playerDeckSelector.Size = new System.Drawing.Size(327, 21);
            this.playerDeckSelector.TabIndex = 11;
            // 
            // addDeckPanel
            // 
            this.addDeckPanel.Controls.Add(this.addDeckButton);
            this.addDeckPanel.Controls.Add(this.addDeckNameText);
            this.addDeckPanel.Controls.Add(this.addDeckNameLabel);
            this.addDeckPanel.Controls.Add(this.addDeckCraftSelector);
            this.addDeckPanel.Controls.Add(this.addDeckCraftLabel);
            this.addDeckPanel.Controls.Add(this.addDeckLabel);
            this.addDeckPanel.Location = new System.Drawing.Point(676, 9);
            this.addDeckPanel.Name = "addDeckPanel";
            this.addDeckPanel.Size = new System.Drawing.Size(253, 159);
            this.addDeckPanel.TabIndex = 12;
            // 
            // addDeckButton
            // 
            this.addDeckButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addDeckButton.Location = new System.Drawing.Point(2, 111);
            this.addDeckButton.Name = "addDeckButton";
            this.addDeckButton.Size = new System.Drawing.Size(246, 33);
            this.addDeckButton.TabIndex = 5;
            this.addDeckButton.Text = "Add";
            // 
            // addDeckNameText
            // 
            this.addDeckNameText.Location = new System.Drawing.Point(82, 69);
            this.addDeckNameText.Name = "addDeckNameText";
            this.addDeckNameText.Size = new System.Drawing.Size(157, 20);
            this.addDeckNameText.TabIndex = 4;
            // 
            // addDeckNameLabel
            // 
            this.addDeckNameLabel.AutoSize = true;
            this.addDeckNameLabel.Location = new System.Drawing.Point(9, 72);
            this.addDeckNameLabel.Name = "addDeckNameLabel";
            this.addDeckNameLabel.Size = new System.Drawing.Size(38, 13);
            this.addDeckNameLabel.TabIndex = 3;
            this.addDeckNameLabel.Text = "Name:";
            // 
            // addDeckCraftSelector
            // 
            this.addDeckCraftSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addDeckCraftSelector.FormattingEnabled = true;
            this.addDeckCraftSelector.Location = new System.Drawing.Point(82, 39);
            this.addDeckCraftSelector.Name = "addDeckCraftSelector";
            this.addDeckCraftSelector.Size = new System.Drawing.Size(157, 21);
            this.addDeckCraftSelector.TabIndex = 2;
            // 
            // addDeckCraftLabel
            // 
            this.addDeckCraftLabel.AutoSize = true;
            this.addDeckCraftLabel.Location = new System.Drawing.Point(9, 41);
            this.addDeckCraftLabel.Name = "addDeckCraftLabel";
            this.addDeckCraftLabel.Size = new System.Drawing.Size(32, 13);
            this.addDeckCraftLabel.TabIndex = 1;
            this.addDeckCraftLabel.Text = "Craft:";
            // 
            // addDeckLabel
            // 
            this.addDeckLabel.AutoSize = true;
            this.addDeckLabel.Location = new System.Drawing.Point(98, 5);
            this.addDeckLabel.Name = "addDeckLabel";
            this.addDeckLabel.Size = new System.Drawing.Size(55, 13);
            this.addDeckLabel.TabIndex = 0;
            this.addDeckLabel.Text = "Add Deck";
            this.addDeckLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // addGamePanel
            // 
            this.addGamePanel.Controls.Add(this.addGameNumTurnsSelector);
            this.addGamePanel.Controls.Add(this.addGameNotesText);
            this.addGamePanel.Controls.Add(this.addGameNotesLabel);
            this.addGamePanel.Controls.Add(this.addGameTakeTwoBtn);
            this.addGamePanel.Controls.Add(this.addGameNumTurnsLabel);
            this.addGamePanel.Controls.Add(this.addGameUnrankedBtn);
            this.addGamePanel.Controls.Add(this.addGameRankedBtn);
            this.addGamePanel.Controls.Add(this.addGameFirstBtn);
            this.addGamePanel.Controls.Add(this.addGameSecondBtn);
            this.addGamePanel.Controls.Add(this.addGameButton);
            this.addGamePanel.Controls.Add(this.addGameLoseBtn);
            this.addGamePanel.Controls.Add(this.addGameWinBtn);
            this.addGamePanel.Controls.Add(this.addGameOpponentDeckList);
            this.addGamePanel.Controls.Add(this.addGameOpponentDeckLabel);
            this.addGamePanel.Controls.Add(this.addGamePlayerDeckList);
            this.addGamePanel.Controls.Add(this.addGamePlayerDeckLabel);
            this.addGamePanel.Controls.Add(this.addGameOpponentCraftList);
            this.addGamePanel.Controls.Add(this.addGameOpponentCraftLabel);
            this.addGamePanel.Controls.Add(this.addGamePlayerCraftList);
            this.addGamePanel.Controls.Add(this.addGamePlayerCraftLabel);
            this.addGamePanel.Controls.Add(this.addGameLabel);
            this.addGamePanel.Location = new System.Drawing.Point(676, 174);
            this.addGamePanel.Name = "addGamePanel";
            this.addGamePanel.Size = new System.Drawing.Size(253, 455);
            this.addGamePanel.TabIndex = 13;
            // 
            // addGameNumTurnsSelector
            // 
            this.addGameNumTurnsSelector.Location = new System.Drawing.Point(82, 173);
            this.addGameNumTurnsSelector.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.addGameNumTurnsSelector.Name = "addGameNumTurnsSelector";
            this.addGameNumTurnsSelector.Size = new System.Drawing.Size(157, 20);
            this.addGameNumTurnsSelector.TabIndex = 23;
            // 
            // addGameNotesText
            // 
            this.addGameNotesText.Location = new System.Drawing.Point(82, 199);
            this.addGameNotesText.Name = "addGameNotesText";
            this.addGameNotesText.Size = new System.Drawing.Size(157, 20);
            this.addGameNotesText.TabIndex = 22;
            // 
            // addGameNotesLabel
            // 
            this.addGameNotesLabel.AutoSize = true;
            this.addGameNotesLabel.Location = new System.Drawing.Point(9, 202);
            this.addGameNotesLabel.Name = "addGameNotesLabel";
            this.addGameNotesLabel.Size = new System.Drawing.Size(38, 13);
            this.addGameNotesLabel.TabIndex = 21;
            this.addGameNotesLabel.Text = "Notes:";
            // 
            // addGameTakeTwoBtn
            // 
            this.addGameTakeTwoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addGameTakeTwoBtn.Location = new System.Drawing.Point(166, 291);
            this.addGameTakeTwoBtn.Name = "addGameTakeTwoBtn";
            this.addGameTakeTwoBtn.Size = new System.Drawing.Size(82, 37);
            this.addGameTakeTwoBtn.TabIndex = 20;
            this.addGameTakeTwoBtn.Text = "Take Two";
            // 
            // addGameNumTurnsLabel
            // 
            this.addGameNumTurnsLabel.AutoSize = true;
            this.addGameNumTurnsLabel.Location = new System.Drawing.Point(9, 176);
            this.addGameNumTurnsLabel.Name = "addGameNumTurnsLabel";
            this.addGameNumTurnsLabel.Size = new System.Drawing.Size(62, 13);
            this.addGameNumTurnsLabel.TabIndex = 6;
            this.addGameNumTurnsLabel.Text = "Num Turns:";
            // 
            // addGameUnrankedBtn
            // 
            this.addGameUnrankedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addGameUnrankedBtn.Location = new System.Drawing.Point(84, 291);
            this.addGameUnrankedBtn.Name = "addGameUnrankedBtn";
            this.addGameUnrankedBtn.Size = new System.Drawing.Size(82, 37);
            this.addGameUnrankedBtn.TabIndex = 19;
            this.addGameUnrankedBtn.Text = "Unranked";
            // 
            // addGameRankedBtn
            // 
            this.addGameRankedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addGameRankedBtn.Location = new System.Drawing.Point(2, 291);
            this.addGameRankedBtn.Name = "addGameRankedBtn";
            this.addGameRankedBtn.Size = new System.Drawing.Size(82, 37);
            this.addGameRankedBtn.TabIndex = 18;
            this.addGameRankedBtn.Text = "Ranked";
            // 
            // addGameFirstBtn
            // 
            this.addGameFirstBtn.BackColor = System.Drawing.SystemColors.Control;
            this.addGameFirstBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addGameFirstBtn.Location = new System.Drawing.Point(2, 245);
            this.addGameFirstBtn.Name = "addGameFirstBtn";
            this.addGameFirstBtn.Size = new System.Drawing.Size(119, 37);
            this.addGameFirstBtn.TabIndex = 17;
            this.addGameFirstBtn.Text = "First";
            this.addGameFirstBtn.UseVisualStyleBackColor = false;
            // 
            // addGameSecondBtn
            // 
            this.addGameSecondBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addGameSecondBtn.Location = new System.Drawing.Point(121, 245);
            this.addGameSecondBtn.Name = "addGameSecondBtn";
            this.addGameSecondBtn.Size = new System.Drawing.Size(127, 37);
            this.addGameSecondBtn.TabIndex = 16;
            this.addGameSecondBtn.Text = "Second";
            // 
            // addGameButton
            // 
            this.addGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addGameButton.Location = new System.Drawing.Point(2, 404);
            this.addGameButton.Name = "addGameButton";
            this.addGameButton.Size = new System.Drawing.Size(246, 33);
            this.addGameButton.TabIndex = 6;
            this.addGameButton.Text = "Add";
            // 
            // addGameLoseBtn
            // 
            this.addGameLoseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addGameLoseBtn.Location = new System.Drawing.Point(2, 338);
            this.addGameLoseBtn.Name = "addGameLoseBtn";
            this.addGameLoseBtn.Size = new System.Drawing.Size(119, 37);
            this.addGameLoseBtn.TabIndex = 15;
            this.addGameLoseBtn.Text = "Lose";
            // 
            // addGameWinBtn
            // 
            this.addGameWinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addGameWinBtn.Location = new System.Drawing.Point(121, 338);
            this.addGameWinBtn.Name = "addGameWinBtn";
            this.addGameWinBtn.Size = new System.Drawing.Size(127, 37);
            this.addGameWinBtn.TabIndex = 14;
            this.addGameWinBtn.Text = "Win";
            // 
            // addGameOpponentDeckList
            // 
            this.addGameOpponentDeckList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addGameOpponentDeckList.FormattingEnabled = true;
            this.addGameOpponentDeckList.Location = new System.Drawing.Point(82, 135);
            this.addGameOpponentDeckList.Name = "addGameOpponentDeckList";
            this.addGameOpponentDeckList.Size = new System.Drawing.Size(157, 21);
            this.addGameOpponentDeckList.TabIndex = 12;
            // 
            // addGameOpponentDeckLabel
            // 
            this.addGameOpponentDeckLabel.AutoSize = true;
            this.addGameOpponentDeckLabel.Location = new System.Drawing.Point(9, 137);
            this.addGameOpponentDeckLabel.Name = "addGameOpponentDeckLabel";
            this.addGameOpponentDeckLabel.Size = new System.Drawing.Size(36, 13);
            this.addGameOpponentDeckLabel.TabIndex = 11;
            this.addGameOpponentDeckLabel.Text = "Deck:";
            // 
            // addGamePlayerDeckList
            // 
            this.addGamePlayerDeckList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addGamePlayerDeckList.FormattingEnabled = true;
            this.addGamePlayerDeckList.Location = new System.Drawing.Point(82, 72);
            this.addGamePlayerDeckList.Name = "addGamePlayerDeckList";
            this.addGamePlayerDeckList.Size = new System.Drawing.Size(157, 21);
            this.addGamePlayerDeckList.TabIndex = 10;
            // 
            // addGamePlayerDeckLabel
            // 
            this.addGamePlayerDeckLabel.AutoSize = true;
            this.addGamePlayerDeckLabel.Location = new System.Drawing.Point(9, 74);
            this.addGamePlayerDeckLabel.Name = "addGamePlayerDeckLabel";
            this.addGamePlayerDeckLabel.Size = new System.Drawing.Size(36, 13);
            this.addGamePlayerDeckLabel.TabIndex = 9;
            this.addGamePlayerDeckLabel.Text = "Deck:";
            // 
            // addGameOpponentCraftList
            // 
            this.addGameOpponentCraftList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addGameOpponentCraftList.FormattingEnabled = true;
            this.addGameOpponentCraftList.Location = new System.Drawing.Point(82, 109);
            this.addGameOpponentCraftList.Name = "addGameOpponentCraftList";
            this.addGameOpponentCraftList.Size = new System.Drawing.Size(157, 21);
            this.addGameOpponentCraftList.TabIndex = 8;
            // 
            // addGameOpponentCraftLabel
            // 
            this.addGameOpponentCraftLabel.AutoSize = true;
            this.addGameOpponentCraftLabel.Location = new System.Drawing.Point(9, 111);
            this.addGameOpponentCraftLabel.Name = "addGameOpponentCraftLabel";
            this.addGameOpponentCraftLabel.Size = new System.Drawing.Size(57, 13);
            this.addGameOpponentCraftLabel.TabIndex = 7;
            this.addGameOpponentCraftLabel.Text = "Opponent:";
            // 
            // addGamePlayerCraftList
            // 
            this.addGamePlayerCraftList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addGamePlayerCraftList.FormattingEnabled = true;
            this.addGamePlayerCraftList.Location = new System.Drawing.Point(82, 46);
            this.addGamePlayerCraftList.Name = "addGamePlayerCraftList";
            this.addGamePlayerCraftList.Size = new System.Drawing.Size(157, 21);
            this.addGamePlayerCraftList.TabIndex = 6;
            // 
            // addGamePlayerCraftLabel
            // 
            this.addGamePlayerCraftLabel.AutoSize = true;
            this.addGamePlayerCraftLabel.Location = new System.Drawing.Point(9, 48);
            this.addGamePlayerCraftLabel.Name = "addGamePlayerCraftLabel";
            this.addGamePlayerCraftLabel.Size = new System.Drawing.Size(29, 13);
            this.addGamePlayerCraftLabel.TabIndex = 6;
            this.addGamePlayerCraftLabel.Text = "You:";
            // 
            // addGameLabel
            // 
            this.addGameLabel.AutoSize = true;
            this.addGameLabel.Location = new System.Drawing.Point(97, 12);
            this.addGameLabel.Name = "addGameLabel";
            this.addGameLabel.Size = new System.Drawing.Size(57, 13);
            this.addGameLabel.TabIndex = 0;
            this.addGameLabel.Text = "Add Game";
            // 
            // opponentCraftSelector
            // 
            this.opponentCraftSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.opponentCraftSelector.FormattingEnabled = true;
            this.opponentCraftSelector.Location = new System.Drawing.Point(227, 5);
            this.opponentCraftSelector.Name = "opponentCraftSelector";
            this.opponentCraftSelector.Size = new System.Drawing.Size(327, 21);
            this.opponentCraftSelector.TabIndex = 15;
            // 
            // labelCraft
            // 
            this.labelCraft.AutoSize = true;
            this.labelCraft.Location = new System.Drawing.Point(5, 9);
            this.labelCraft.Name = "labelCraft";
            this.labelCraft.Size = new System.Drawing.Size(82, 13);
            this.labelCraft.TabIndex = 14;
            this.labelCraft.Text = "Opponent Craft:";
            // 
            // opponentDeckSelector
            // 
            this.opponentDeckSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.opponentDeckSelector.FormattingEnabled = true;
            this.opponentDeckSelector.Location = new System.Drawing.Point(227, 29);
            this.opponentDeckSelector.Name = "opponentDeckSelector";
            this.opponentDeckSelector.Size = new System.Drawing.Size(327, 21);
            this.opponentDeckSelector.TabIndex = 17;
            // 
            // labelOpponentDeck
            // 
            this.labelOpponentDeck.AutoSize = true;
            this.labelOpponentDeck.Location = new System.Drawing.Point(5, 32);
            this.labelOpponentDeck.Name = "labelOpponentDeck";
            this.labelOpponentDeck.Size = new System.Drawing.Size(86, 13);
            this.labelOpponentDeck.TabIndex = 16;
            this.labelOpponentDeck.Text = "Opponent Deck:";
            // 
            // gameModeSelector
            // 
            this.gameModeSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gameModeSelector.FormattingEnabled = true;
            this.gameModeSelector.Location = new System.Drawing.Point(227, 78);
            this.gameModeSelector.Name = "gameModeSelector";
            this.gameModeSelector.Size = new System.Drawing.Size(327, 21);
            this.gameModeSelector.TabIndex = 19;
            // 
            // labelGameMode
            // 
            this.labelGameMode.AutoSize = true;
            this.labelGameMode.Location = new System.Drawing.Point(5, 81);
            this.labelGameMode.Name = "labelGameMode";
            this.labelGameMode.Size = new System.Drawing.Size(68, 13);
            this.labelGameMode.TabIndex = 18;
            this.labelGameMode.Text = "Game Mode:";
            // 
            // filtersPanel
            // 
            this.filtersPanel.Controls.Add(this.turnSelector);
            this.filtersPanel.Controls.Add(this.labelTurn);
            this.filtersPanel.Controls.Add(this.labelPlayerDeck);
            this.filtersPanel.Controls.Add(this.labelCraft);
            this.filtersPanel.Controls.Add(this.playerDeckSelector);
            this.filtersPanel.Controls.Add(this.opponentDeckSelector);
            this.filtersPanel.Controls.Add(this.labelOpponentDeck);
            this.filtersPanel.Controls.Add(this.gameModeSelector);
            this.filtersPanel.Controls.Add(this.labelGameMode);
            this.filtersPanel.Controls.Add(this.opponentCraftSelector);
            this.filtersPanel.Location = new System.Drawing.Point(109, 1);
            this.filtersPanel.Name = "filtersPanel";
            this.filtersPanel.Size = new System.Drawing.Size(560, 129);
            this.filtersPanel.TabIndex = 14;
            // 
            // turnSelector
            // 
            this.turnSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.turnSelector.FormattingEnabled = true;
            this.turnSelector.Location = new System.Drawing.Point(227, 103);
            this.turnSelector.Name = "turnSelector";
            this.turnSelector.Size = new System.Drawing.Size(327, 21);
            this.turnSelector.TabIndex = 21;
            // 
            // labelTurn
            // 
            this.labelTurn.AutoSize = true;
            this.labelTurn.Location = new System.Drawing.Point(5, 106);
            this.labelTurn.Name = "labelTurn";
            this.labelTurn.Size = new System.Drawing.Size(32, 13);
            this.labelTurn.TabIndex = 20;
            this.labelTurn.Text = "Turn:";
            // 
            // firstWinNumLabel
            // 
            this.firstWinNumLabel.AutoSize = true;
            this.firstWinNumLabel.Location = new System.Drawing.Point(165, 29);
            this.firstWinNumLabel.Name = "firstWinNumLabel";
            this.firstWinNumLabel.Size = new System.Drawing.Size(29, 13);
            this.firstWinNumLabel.TabIndex = 10;
            this.firstWinNumLabel.Text = "First:";
            // 
            // secondWinNumLabel
            // 
            this.secondWinNumLabel.AutoSize = true;
            this.secondWinNumLabel.Location = new System.Drawing.Point(323, 29);
            this.secondWinNumLabel.Name = "secondWinNumLabel";
            this.secondWinNumLabel.Size = new System.Drawing.Size(47, 13);
            this.secondWinNumLabel.TabIndex = 11;
            this.secondWinNumLabel.Text = "Second:";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 626);
            this.Controls.Add(this.filtersPanel);
            this.Controls.Add(this.addGamePanel);
            this.Controls.Add(this.addDeckPanel);
            this.Controls.Add(this.dataPanel);
            this.Controls.Add(this.buttonpanel);
            this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(FILEPATH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainWindow";
            this.Text = "Shadowverse Tracker";
            this.buttonpanel.ResumeLayout(false);
            this.dataPanel.ResumeLayout(false);
            this.dataPanel.PerformLayout();
            this.decksPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deckDataGrid)).EndInit();
            this.statsPanel.ResumeLayout(false);
            this.statsPanel.PerformLayout();
            this.matchupsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.matchupsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prevGamesDataGrid)).EndInit();
            this.addDeckPanel.ResumeLayout(false);
            this.addDeckPanel.PerformLayout();
            this.addGamePanel.ResumeLayout(false);
            this.addGamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addGameNumTurnsSelector)).EndInit();
            this.filtersPanel.ResumeLayout(false);
            this.filtersPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private readonly string FILEPATH = "ShadowverseTracker.exe";

        private System.Windows.Forms.Button buttonAll;
        private System.Windows.Forms.Button buttonForest;
        private System.Windows.Forms.Button buttonSword;
        private System.Windows.Forms.Button buttonRune;
        private System.Windows.Forms.Button buttonDragon;
        private System.Windows.Forms.Button buttonShadow;
        private System.Windows.Forms.Button buttonBlood;
        private System.Windows.Forms.Button buttonHaven;
        private System.Windows.Forms.Panel buttonpanel;
        private System.Windows.Forms.Panel dataPanel;
        private System.Windows.Forms.Label labelPlayerDeck;
        private System.Windows.Forms.ComboBox playerDeckSelector;
        private System.Windows.Forms.Panel addDeckPanel;
        private System.Windows.Forms.Panel addGamePanel;
        private System.Windows.Forms.Label addDeckNameLabel;
        private System.Windows.Forms.ComboBox addDeckCraftSelector;
        private System.Windows.Forms.Label addDeckCraftLabel;
        private System.Windows.Forms.Label addDeckLabel;
        private System.Windows.Forms.Label addGameLabel;
        private System.Windows.Forms.Button addDeckButton;
        private System.Windows.Forms.TextBox addDeckNameText;
        private System.Windows.Forms.ComboBox addGameOpponentCraftList;
        private System.Windows.Forms.Label addGameOpponentCraftLabel;
        private System.Windows.Forms.ComboBox addGamePlayerCraftList;
        private System.Windows.Forms.Label addGamePlayerCraftLabel;
        private System.Windows.Forms.ComboBox addGameOpponentDeckList;
        private System.Windows.Forms.Label addGameOpponentDeckLabel;
        private System.Windows.Forms.ComboBox addGamePlayerDeckList;
        private System.Windows.Forms.Label addGamePlayerDeckLabel;
        private System.Windows.Forms.Button addGameLoseBtn;
        private System.Windows.Forms.Button addGameWinBtn;
        private System.Windows.Forms.Button addGameButton;
        private System.Windows.Forms.ComboBox opponentCraftSelector;
        private System.Windows.Forms.Label labelCraft;
        private System.Windows.Forms.ComboBox opponentDeckSelector;
        private System.Windows.Forms.Label labelOpponentDeck;
        private System.Windows.Forms.Button addGameFirstBtn;
        private System.Windows.Forms.Button addGameSecondBtn;
        private System.Windows.Forms.Button addGameRankedBtn;
        private System.Windows.Forms.Button addGameTakeTwoBtn;
        private System.Windows.Forms.Button addGameUnrankedBtn;
        private ComboBox gameModeSelector;
        private Label labelGameMode;
        private Panel filtersPanel;
        private DataGridView prevGamesDataGrid;
        private Button decksButton;
        private Button statsButton;
        private Panel statsPanel;
        private Panel decksPanel;
        private Panel matchupsPanel;
        private Label hintLabel;
        private Label totalWinNumLabel;
        private Label bloodWinLabel;
        private Label runeWinLabel;
        private Label shadowWinLabel;
        private Label swordWinLabel;
        private Label havenWinLabel;
        private Label dragonWinLabel;
        private Label forestWinLabel;
        private Panel statsDividerPanel;
        private DataGridView deckDataGrid;
        private Label prevGamesLabel;
        private Button matchupsButton;
        private DataGridView matchupsDataGrid;
        private ComboBox turnSelector;
        private Label labelTurn;
        private Button exportButton;
        private DataGridViewTextBoxColumn matchupsNameCol;
        private DataGridViewTextBoxColumn matchupsCraftCol;
        private DataGridViewTextBoxColumn matchupsGamesCol;
        private DataGridViewTextBoxColumn matchupsWinCol;
        private DataGridViewTextBoxColumn decksNameCol;
        private DataGridViewTextBoxColumn deckCraftsCol;
        private DataGridViewTextBoxColumn decksGamesCol;
        private DataGridViewTextBoxColumn decksWinCol;
        private TextBox addGameNotesText;
        private Label addGameNotesLabel;
        private Label addGameNumTurnsLabel;
        private NumericUpDown addGameNumTurnsSelector;
        private DataGridViewTextBoxColumn craftCol;
        private DataGridViewTextBoxColumn deckCol;
        private DataGridViewTextBoxColumn opponentCol;
        private DataGridViewTextBoxColumn modeCol;
        private DataGridViewTextBoxColumn turnCol;
        private DataGridViewTextBoxColumn resultCol;
        private DataGridViewImageColumn deleteCol;
        private Label secondWinNumLabel;
        private Label firstWinNumLabel;
    }
}