using System.Windows.Forms;

namespace BenderAndURL
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GroupboxInitialSettings = new System.Windows.Forms.GroupBox();
            this.LabelStepsPerEpisode = new System.Windows.Forms.Label();
            this.TextboxInitialSettingsNumberOfSteps = new System.Windows.Forms.TextBox();
            this.TextboxInitialSettingsEta = new System.Windows.Forms.TextBox();
            this.LabelEpsilon = new System.Windows.Forms.Label();
            this.TextboxInitialSettingsGamma = new System.Windows.Forms.TextBox();
            this.TextboxInitialSettingsEpsilon = new System.Windows.Forms.TextBox();
            this.GroupboxRewards = new System.Windows.Forms.GroupBox();
            this.TextboxInitialSettingsRewardsBeer = new System.Windows.Forms.TextBox();
            this.LabelSuccessfulMove = new System.Windows.Forms.Label();
            this.TextboxInitialSettingsRewardsEmptyGrab = new System.Windows.Forms.TextBox();
            this.TextboxInitialSettingsRewardsSuccessMove = new System.Windows.Forms.TextBox();
            this.LabelBeer = new System.Windows.Forms.Label();
            this.LabelHitsAWall = new System.Windows.Forms.Label();
            this.TextboxInitialSettingsRewardsWall = new System.Windows.Forms.TextBox();
            this.LabelEmptyGrab = new System.Windows.Forms.Label();
            this.LabelInitialGamma = new System.Windows.Forms.Label();
            this.LabelInitialEpisodes = new System.Windows.Forms.Label();
            this.LabelInitialEta = new System.Windows.Forms.Label();
            this.TextboxInitialSettingsNumberOfEpisodes = new System.Windows.Forms.TextBox();
            this.ButtonStopAlgorithm = new System.Windows.Forms.Button();
            this.ComboboxQmatrixSelect = new System.Windows.Forms.ComboBox();
            this.TextboxQmatrixValuesCurrent = new System.Windows.Forms.TextBox();
            this.LabelQmatrixValuesGrab = new System.Windows.Forms.Label();
            this.TextboxQmatrixValuesUp = new System.Windows.Forms.TextBox();
            this.LabelQmatrixValuesUp = new System.Windows.Forms.Label();
            this.TextboxQmatrixValuesDown = new System.Windows.Forms.TextBox();
            this.TextboxQmatrixValuesRight = new System.Windows.Forms.TextBox();
            this.LabelQmatrixValuesRight = new System.Windows.Forms.Label();
            this.LabelQmatrixValuesDown = new System.Windows.Forms.Label();
            this.LabelQmatrixValuesLeft = new System.Windows.Forms.Label();
            this.TextboxQmatrixValuesLeft = new System.Windows.Forms.TextBox();
            this.GroupboxQmatrix = new System.Windows.Forms.GroupBox();
            this.LabelQmatrixStoredEntries = new System.Windows.Forms.Label();
            this.TextboxQmatrixStoredEntries = new System.Windows.Forms.TextBox();
            this.GroupboxQmatrixSelect = new System.Windows.Forms.GroupBox();
            this.LabelQmatrixComboboxLeft = new System.Windows.Forms.Label();
            this.LabelQmatrixComboboxUp = new System.Windows.Forms.Label();
            this.ComboboxQmatrixGrab = new System.Windows.Forms.ComboBox();
            this.LabelQmatrixComboboxDown = new System.Windows.Forms.Label();
            this.ComboboxQmatrixUp = new System.Windows.Forms.ComboBox();
            this.LabelQmatrixComboboxRight = new System.Windows.Forms.Label();
            this.ComboboxQmatrixDown = new System.Windows.Forms.ComboBox();
            this.LabelQmatrixComboboxGrab = new System.Windows.Forms.Label();
            this.ComboboxQmatrixRight = new System.Windows.Forms.ComboBox();
            this.ComboboxQmatrixLeft = new System.Windows.Forms.ComboBox();
            this.GroupboxQmatrixValues = new System.Windows.Forms.GroupBox();
            this.ComboboxHistoryEpisode = new System.Windows.Forms.ComboBox();
            this.GroupboxHistory = new System.Windows.Forms.GroupBox();
            this.ComboboxHistoryStep = new System.Windows.Forms.ComboBox();
            this.GroupboxAlgorithmProgress = new System.Windows.Forms.GroupBox();
            this.CheckboxLoopUntilChasing = new System.Windows.Forms.CheckBox();
            this.LabelMsDelayPerStep = new System.Windows.Forms.Label();
            this.ComboboxDelayMS = new System.Windows.Forms.ComboBox();
            this.LabelNumberOfEpisodes = new System.Windows.Forms.Label();
            this.LabelNumberOfSteps = new System.Windows.Forms.Label();
            this.ComboboxAdvanceEpisodes = new System.Windows.Forms.ComboBox();
            this.ComboboxAdvanceSteps = new System.Windows.Forms.ComboBox();
            this.ButtonAdvanceStepsDropDown = new System.Windows.Forms.Button();
            this.GroupboxCountDown = new System.Windows.Forms.GroupBox();
            this.ButtonStop = new System.Windows.Forms.Button();
            this.LabelInProgressSteps = new System.Windows.Forms.Label();
            this.TextboxInProgressSteps = new System.Windows.Forms.TextBox();
            this.LabelInProgressTime = new System.Windows.Forms.Label();
            this.TextboxInProgressTime = new System.Windows.Forms.TextBox();
            this.GroupboxConfiguration = new System.Windows.Forms.GroupBox();
            this.GroupboxConfigurationRewards = new System.Windows.Forms.GroupBox();
            this.LabelRewardsMovedWithoutHittingWall = new System.Windows.Forms.Label();
            this.ComboboxRewardsMovedWithoutHittingWall = new System.Windows.Forms.ComboBox();
            this.LabelRewardsRanIntoWall = new System.Windows.Forms.Label();
            this.ComboboxRewardsGrabbedEmptySquare = new System.Windows.Forms.ComboBox();
            this.LabelRewardsGrabbedEmptySquare = new System.Windows.Forms.Label();
            this.ComboboxRewardsCollectedBeer = new System.Windows.Forms.ComboBox();
            this.ComboboxRewardsRanIntoWall = new System.Windows.Forms.ComboBox();
            this.LabelRewardsCollectedBeer = new System.Windows.Forms.Label();
            this.ButtonConfigurationReset = new System.Windows.Forms.Button();
            this.ButtonConfigurationStartAlgorithm = new System.Windows.Forms.Button();
            this.LabelConfigurationNumberOfEpisodes = new System.Windows.Forms.Label();
            this.LabelConfigurationComboboxEpsilon = new System.Windows.Forms.Label();
            this.ComboboxConfigurationNumberOfEpisodes = new System.Windows.Forms.ComboBox();
            this.LabelConfigurationComboboxGamma = new System.Windows.Forms.Label();
            this.ComboboxConfigurationEta = new System.Windows.Forms.ComboBox();
            this.ComboboxConfigurationEpsilon = new System.Windows.Forms.ComboBox();
            this.LabelConfigurationComboboxEta = new System.Windows.Forms.Label();
            this.LabelConfigurationComboboxNumberOfStepsPerEpisode = new System.Windows.Forms.Label();
            this.ComboboxConfigurationNumberOfStepsPerEpisode = new System.Windows.Forms.ComboBox();
            this.ComboboxConfigurationGamma = new System.Windows.Forms.ComboBox();
            this.PictureboxFrySquinting = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.pictureBox26 = new System.Windows.Forms.PictureBox();
            this.pictureBox27 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.GroupboxStatusMessage = new System.Windows.Forms.GroupBox();
            this.RichTextboxStatusMessage = new System.Windows.Forms.RichTextBox();
            this.GroupboxSessionProgress = new System.Windows.Forms.GroupBox();
            this.GroupboxCanDataThisEpisode = new System.Windows.Forms.GroupBox();
            this.LabelCanDataCollected = new System.Windows.Forms.Label();
            this.TextboxCanDataCollected = new System.Windows.Forms.TextBox();
            this.TextboxCanDataRemaining = new System.Windows.Forms.TextBox();
            this.LabelCanDataRemaining = new System.Windows.Forms.Label();
            this.GroupboxRewardData = new System.Windows.Forms.GroupBox();
            this.LabelRewardDataTotal = new System.Windows.Forms.Label();
            this.TextboxRewardsDataTotal = new System.Windows.Forms.TextBox();
            this.TextboxRewardsDataThisEpisode = new System.Windows.Forms.TextBox();
            this.LabelRewardDataThisEpisode = new System.Windows.Forms.Label();
            this.LabelSessionProgressGamma = new System.Windows.Forms.Label();
            this.LabelSessionProgressEpisodeNumber = new System.Windows.Forms.Label();
            this.TextboxSessionProgressEpisodeNumber = new System.Windows.Forms.TextBox();
            this.TextboxSessionProgressStepNumber = new System.Windows.Forms.TextBox();
            this.GroupboxCurrentPercepts = new System.Windows.Forms.GroupBox();
            this.TextboxCurrentPerceptsCurrentSquare = new System.Windows.Forms.TextBox();
            this.LabelCurrentPreceptsCurrentSquare = new System.Windows.Forms.Label();
            this.TextboxCurrentPerceptsUp = new System.Windows.Forms.TextBox();
            this.LabelCurrentPerceptsUp = new System.Windows.Forms.Label();
            this.TextboxCurrentPerceptsDown = new System.Windows.Forms.TextBox();
            this.TextboxCurrentPerceptsRight = new System.Windows.Forms.TextBox();
            this.LabelCurrentPerceptsRight = new System.Windows.Forms.Label();
            this.LabelCurrentPerceptsDown = new System.Windows.Forms.Label();
            this.LabelCurrentPereptsLeft = new System.Windows.Forms.Label();
            this.TextboxCurrentPerceptsLeft = new System.Windows.Forms.TextBox();
            this.LabelSessionProgressEpsilon = new System.Windows.Forms.Label();
            this.LabelSessionProgressStepNumber = new System.Windows.Forms.Label();
            this.TextboxSessionProgessEpsilon = new System.Windows.Forms.TextBox();
            this.TextboxSessionProgressGamma = new System.Windows.Forms.TextBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.GroupboxInitialSettings.SuspendLayout();
            this.GroupboxRewards.SuspendLayout();
            this.GroupboxQmatrix.SuspendLayout();
            this.GroupboxQmatrixSelect.SuspendLayout();
            this.GroupboxQmatrixValues.SuspendLayout();
            this.GroupboxHistory.SuspendLayout();
            this.GroupboxAlgorithmProgress.SuspendLayout();
            this.GroupboxCountDown.SuspendLayout();
            this.GroupboxConfiguration.SuspendLayout();
            this.GroupboxConfigurationRewards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureboxFrySquinting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.GroupboxStatusMessage.SuspendLayout();
            this.GroupboxSessionProgress.SuspendLayout();
            this.GroupboxCanDataThisEpisode.SuspendLayout();
            this.GroupboxRewardData.SuspendLayout();
            this.GroupboxCurrentPercepts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // groupboxInitialsettings
            // 
            this.GroupboxInitialSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.GroupboxInitialSettings.Controls.Add(this.LabelStepsPerEpisode);
            this.GroupboxInitialSettings.Controls.Add(this.TextboxInitialSettingsNumberOfSteps);
            this.GroupboxInitialSettings.Controls.Add(this.TextboxInitialSettingsEta);
            this.GroupboxInitialSettings.Controls.Add(this.LabelEpsilon);
            this.GroupboxInitialSettings.Controls.Add(this.TextboxInitialSettingsGamma);
            this.GroupboxInitialSettings.Controls.Add(this.TextboxInitialSettingsEpsilon);
            this.GroupboxInitialSettings.Controls.Add(this.GroupboxRewards);
            this.GroupboxInitialSettings.Controls.Add(this.LabelInitialGamma);
            this.GroupboxInitialSettings.Controls.Add(this.LabelInitialEpisodes);
            this.GroupboxInitialSettings.Controls.Add(this.LabelInitialEta);
            this.GroupboxInitialSettings.Controls.Add(this.TextboxInitialSettingsNumberOfEpisodes);
            this.GroupboxInitialSettings.Location = new System.Drawing.Point(1407, 13);
            this.GroupboxInitialSettings.Name = "GroupboxInitialSettings";
            this.GroupboxInitialSettings.Size = new System.Drawing.Size(569, 145);
            this.GroupboxInitialSettings.TabIndex = 10;
            this.GroupboxInitialSettings.TabStop = false;
            this.GroupboxInitialSettings.Text = "Initial Settings";
            // 
            // LabelStepsPerEpisode
            // 
            this.LabelStepsPerEpisode.AutoSize = true;
            this.LabelStepsPerEpisode.Location = new System.Drawing.Point(109, 43);
            this.LabelStepsPerEpisode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelStepsPerEpisode.Name = "LabelStepsPerEpisode";
            this.LabelStepsPerEpisode.Size = new System.Drawing.Size(123, 17);
            this.LabelStepsPerEpisode.TabIndex = 14;
            this.LabelStepsPerEpisode.Text = "Steps per episode";
            // 
            // TextboxInitialNumberofSteps
            // 
            this.TextboxInitialSettingsNumberOfSteps.Location = new System.Drawing.Point(122, 63);
            this.TextboxInitialSettingsNumberOfSteps.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxInitialSettingsNumberOfSteps.Name = "TextboxInitialSettingsNumberOfSteps";
            this.TextboxInitialSettingsNumberOfSteps.ReadOnly = true;
            this.TextboxInitialSettingsNumberOfSteps.Size = new System.Drawing.Size(157, 22);
            this.TextboxInitialSettingsNumberOfSteps.TabIndex = 15;
            // 
            // TextboxInitialNInitial
            // 
            this.TextboxInitialSettingsEta.Location = new System.Drawing.Point(210, 104);
            this.TextboxInitialSettingsEta.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxInitialSettingsEta.Name = "TextboxInitialSettingsEta";
            this.TextboxInitialSettingsEta.ReadOnly = true;
            this.TextboxInitialSettingsEta.Size = new System.Drawing.Size(66, 22);
            this.TextboxInitialSettingsEta.TabIndex = 19;
            // 
            // LabelEpsilon
            // 
            this.LabelEpsilon.AutoSize = true;
            this.LabelEpsilon.Location = new System.Drawing.Point(31, 87);
            this.LabelEpsilon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelEpsilon.Name = "LabelEpsilon";
            this.LabelEpsilon.Size = new System.Drawing.Size(17, 17);
            this.LabelEpsilon.TabIndex = 18;
            this.LabelEpsilon.Text = "Ɛ";
            // 
            // TextboxInitialY
            // 
            this.TextboxInitialSettingsGamma.Location = new System.Drawing.Point(122, 104);
            this.TextboxInitialSettingsGamma.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxInitialSettingsGamma.Name = "TextboxInitialSettingsGamma";
            this.TextboxInitialSettingsGamma.ReadOnly = true;
            this.TextboxInitialSettingsGamma.Size = new System.Drawing.Size(69, 22);
            this.TextboxInitialSettingsGamma.TabIndex = 13;
            // 
            // TextboxInitialEpsilon
            // 
            this.TextboxInitialSettingsEpsilon.Location = new System.Drawing.Point(33, 104);
            this.TextboxInitialSettingsEpsilon.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxInitialSettingsEpsilon.Name = "TextboxInitialSettingsEpsilon";
            this.TextboxInitialSettingsEpsilon.ReadOnly = true;
            this.TextboxInitialSettingsEpsilon.Size = new System.Drawing.Size(70, 22);
            this.TextboxInitialSettingsEpsilon.TabIndex = 17;
            // 
            // GroupboxRewards
            // 
            this.GroupboxRewards.Controls.Add(this.TextboxInitialSettingsRewardsBeer);
            this.GroupboxRewards.Controls.Add(this.LabelSuccessfulMove);
            this.GroupboxRewards.Controls.Add(this.TextboxInitialSettingsRewardsEmptyGrab);
            this.GroupboxRewards.Controls.Add(this.TextboxInitialSettingsRewardsSuccessMove);
            this.GroupboxRewards.Controls.Add(this.LabelBeer);
            this.GroupboxRewards.Controls.Add(this.LabelHitsAWall);
            this.GroupboxRewards.Controls.Add(this.TextboxInitialSettingsRewardsWall);
            this.GroupboxRewards.Controls.Add(this.LabelEmptyGrab);
            this.GroupboxRewards.Location = new System.Drawing.Point(286, 20);
            this.GroupboxRewards.Name = "GroupboxRewards";
            this.GroupboxRewards.Size = new System.Drawing.Size(276, 119);
            this.GroupboxRewards.TabIndex = 59;
            this.GroupboxRewards.TabStop = false;
            this.GroupboxRewards.Text = "Rewards";
            // 
            // TextboxInitialBeerReward
            // 
            this.TextboxInitialSettingsRewardsBeer.Location = new System.Drawing.Point(15, 84);
            this.TextboxInitialSettingsRewardsBeer.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxInitialSettingsRewardsBeer.Name = "TextboxInitialSettingsRewardsBeer";
            this.TextboxInitialSettingsRewardsBeer.ReadOnly = true;
            this.TextboxInitialSettingsRewardsBeer.Size = new System.Drawing.Size(110, 22);
            this.TextboxInitialSettingsRewardsBeer.TabIndex = 25;
            // 
            // LabelSuccessfulMove
            // 
            this.LabelSuccessfulMove.AutoSize = true;
            this.LabelSuccessfulMove.Location = new System.Drawing.Point(11, 24);
            this.LabelSuccessfulMove.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelSuccessfulMove.Name = "LabelSuccessfulMove";
            this.LabelSuccessfulMove.Size = new System.Drawing.Size(114, 17);
            this.LabelSuccessfulMove.TabIndex = 26;
            this.LabelSuccessfulMove.Text = "Successful move";
            // 
            // TextboxInitialEmptySquare
            // 
            this.TextboxInitialSettingsRewardsEmptyGrab.Location = new System.Drawing.Point(148, 84);
            this.TextboxInitialSettingsRewardsEmptyGrab.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxInitialSettingsRewardsEmptyGrab.Name = "TextboxInitialSettingsRewardsEmptyGrab";
            this.TextboxInitialSettingsRewardsEmptyGrab.ReadOnly = true;
            this.TextboxInitialSettingsRewardsEmptyGrab.Size = new System.Drawing.Size(111, 22);
            this.TextboxInitialSettingsRewardsEmptyGrab.TabIndex = 23;
            // 
            // TextboxRewardsSuccessMove
            // 
            this.TextboxInitialSettingsRewardsSuccessMove.Location = new System.Drawing.Point(14, 43);
            this.TextboxInitialSettingsRewardsSuccessMove.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxInitialSettingsRewardsSuccessMove.Name = "TextboxInitialSettingsRewardsSuccessMove";
            this.TextboxInitialSettingsRewardsSuccessMove.ReadOnly = true;
            this.TextboxInitialSettingsRewardsSuccessMove.Size = new System.Drawing.Size(111, 22);
            this.TextboxInitialSettingsRewardsSuccessMove.TabIndex = 27;
            // 
            // LabelBeer
            // 
            this.LabelBeer.AutoSize = true;
            this.LabelBeer.Location = new System.Drawing.Point(11, 67);
            this.LabelBeer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelBeer.Name = "LabelBeer";
            this.LabelBeer.Size = new System.Drawing.Size(38, 17);
            this.LabelBeer.TabIndex = 24;
            this.LabelBeer.Text = "Beer";
            // 
            // LabelHitsAWall
            // 
            this.LabelHitsAWall.AutoSize = true;
            this.LabelHitsAWall.Location = new System.Drawing.Point(149, 25);
            this.LabelHitsAWall.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelHitsAWall.Name = "LabelHitsAWall";
            this.LabelHitsAWall.Size = new System.Drawing.Size(71, 17);
            this.LabelHitsAWall.TabIndex = 20;
            this.LabelHitsAWall.Text = "Hits a wall";
            // 
            // TextboxInitialWallPunishment
            // 
            this.TextboxInitialSettingsRewardsWall.Location = new System.Drawing.Point(148, 43);
            this.TextboxInitialSettingsRewardsWall.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxInitialSettingsRewardsWall.Name = "TextboxInitialSettingsRewardsWall";
            this.TextboxInitialSettingsRewardsWall.ReadOnly = true;
            this.TextboxInitialSettingsRewardsWall.Size = new System.Drawing.Size(111, 22);
            this.TextboxInitialSettingsRewardsWall.TabIndex = 21;
            // 
            // LabelEmptyGrab
            // 
            this.LabelEmptyGrab.AutoSize = true;
            this.LabelEmptyGrab.Location = new System.Drawing.Point(145, 69);
            this.LabelEmptyGrab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelEmptyGrab.Name = "LabelEmptyGrab";
            this.LabelEmptyGrab.Size = new System.Drawing.Size(80, 17);
            this.LabelEmptyGrab.TabIndex = 22;
            this.LabelEmptyGrab.Text = "Empty grab";
            // 
            // LabelInitialGamma
            // 
            this.LabelInitialGamma.AutoSize = true;
            this.LabelInitialGamma.Location = new System.Drawing.Point(121, 85);
            this.LabelInitialGamma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelInitialGamma.Name = "LabelInitialGamma";
            this.LabelInitialGamma.Size = new System.Drawing.Size(15, 17);
            this.LabelInitialGamma.TabIndex = 12;
            this.LabelInitialGamma.Text = "γ";
            // 
            // LabelInitialEpisodes
            // 
            this.LabelInitialEpisodes.AutoSize = true;
            this.LabelInitialEpisodes.Location = new System.Drawing.Point(32, 43);
            this.LabelInitialEpisodes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelInitialEpisodes.Name = "LabelInitialEpisodes";
            this.LabelInitialEpisodes.Size = new System.Drawing.Size(66, 17);
            this.LabelInitialEpisodes.TabIndex = 12;
            this.LabelInitialEpisodes.Text = "Episodes";
            // 
            // LabelInitialEta
            // 
            this.LabelInitialEta.AutoSize = true;
            this.LabelInitialEta.Location = new System.Drawing.Point(208, 85);
            this.LabelInitialEta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelInitialEta.Name = "LabelInitialEta";
            this.LabelInitialEta.Size = new System.Drawing.Size(16, 17);
            this.LabelInitialEta.TabIndex = 16;
            this.LabelInitialEta.Text = "η";
            // 
            // TextboxInitialNumberofepisodes
            // 
            this.TextboxInitialSettingsNumberOfEpisodes.Location = new System.Drawing.Point(34, 63);
            this.TextboxInitialSettingsNumberOfEpisodes.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxInitialSettingsNumberOfEpisodes.Name = "TextboxInitialSettingsNumberOfEpisodes";
            this.TextboxInitialSettingsNumberOfEpisodes.ReadOnly = true;
            this.TextboxInitialSettingsNumberOfEpisodes.Size = new System.Drawing.Size(69, 22);
            this.TextboxInitialSettingsNumberOfEpisodes.TabIndex = 13;
            // 
            // ButtonStopAlgorithm
            // 
            this.ButtonStopAlgorithm.Enabled = false;
            this.ButtonStopAlgorithm.Location = new System.Drawing.Point(36, 155);
            this.ButtonStopAlgorithm.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonStopAlgorithm.Name = "ButtonStopAlgorithm";
            this.ButtonStopAlgorithm.Size = new System.Drawing.Size(210, 27);
            this.ButtonStopAlgorithm.TabIndex = 5;
            this.ButtonStopAlgorithm.Text = "Stop algorithm";
            this.ButtonStopAlgorithm.UseVisualStyleBackColor = true;
            this.ButtonStopAlgorithm.Click += new System.EventHandler(this.RestartAlgorithmButtonClicked);
            // 
            // ComboboxQmatrixSelect
            // 
            this.ComboboxQmatrixSelect.FormattingEnabled = true;
            this.ComboboxQmatrixSelect.Items.AddRange(new object[] {
            "No board states have been added yet."});
            this.ComboboxQmatrixSelect.Location = new System.Drawing.Point(27, 21);
            this.ComboboxQmatrixSelect.Name = "ComboboxQmatrixSelect";
            this.ComboboxQmatrixSelect.Size = new System.Drawing.Size(518, 24);
            this.ComboboxQmatrixSelect.TabIndex = 0;
            this.ComboboxQmatrixSelect.Text = "Select a board state...";
            this.ComboboxQmatrixSelect.SelectedIndexChanged += new System.EventHandler(this.ComboboxQmatrixSelectIndexChanged);
            // 
            // TextboxQmatrixCurrent
            // 
            this.TextboxQmatrixValuesCurrent.Location = new System.Drawing.Point(375, 38);
            this.TextboxQmatrixValuesCurrent.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxQmatrixValuesCurrent.Name = "TextboxQmatrixValuesCurrent";
            this.TextboxQmatrixValuesCurrent.ReadOnly = true;
            this.TextboxQmatrixValuesCurrent.Size = new System.Drawing.Size(75, 22);
            this.TextboxQmatrixValuesCurrent.TabIndex = 21;
            // 
            // LabelQmatrixValuesGrab
            // 
            this.LabelQmatrixValuesGrab.AutoSize = true;
            this.LabelQmatrixValuesGrab.Location = new System.Drawing.Point(370, 21);
            this.LabelQmatrixValuesGrab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelQmatrixValuesGrab.Name = "LabelQmatrixValuesGrab";
            this.LabelQmatrixValuesGrab.Size = new System.Drawing.Size(55, 17);
            this.LabelQmatrixValuesGrab.TabIndex = 20;
            this.LabelQmatrixValuesGrab.Text = "Grab";
            // 
            // TextboxQmatrixValuesUp
            // 
            this.TextboxQmatrixValuesUp.Location = new System.Drawing.Point(291, 38);
            this.TextboxQmatrixValuesUp.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxQmatrixValuesUp.Name = "TextboxQmatrixValuesUp";
            this.TextboxQmatrixValuesUp.ReadOnly = true;
            this.TextboxQmatrixValuesUp.Size = new System.Drawing.Size(75, 22);
            this.TextboxQmatrixValuesUp.TabIndex = 19;
            // 
            // LabelQmatrixValuesUp
            // 
            this.LabelQmatrixValuesUp.AutoSize = true;
            this.LabelQmatrixValuesUp.Location = new System.Drawing.Point(287, 19);
            this.LabelQmatrixValuesUp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelQmatrixValuesUp.Name = "LabelQmatrixValuesUp";
            this.LabelQmatrixValuesUp.Size = new System.Drawing.Size(26, 17);
            this.LabelQmatrixValuesUp.TabIndex = 18;
            this.LabelQmatrixValuesUp.Text = "Up";
            // 
            // TextboxQmatrixValuesDown
            // 
            this.TextboxQmatrixValuesDown.Location = new System.Drawing.Point(203, 38);
            this.TextboxQmatrixValuesDown.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxQmatrixValuesDown.Name = "TextboxQmatrixValuesDown";
            this.TextboxQmatrixValuesDown.ReadOnly = true;
            this.TextboxQmatrixValuesDown.Size = new System.Drawing.Size(79, 22);
            this.TextboxQmatrixValuesDown.TabIndex = 15;
            // 
            // TextboxQmatrixValuesRight
            // 
            this.TextboxQmatrixValuesRight.Location = new System.Drawing.Point(115, 38);
            this.TextboxQmatrixValuesRight.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxQmatrixValuesRight.Name = "TextboxQmatrixValuesRight";
            this.TextboxQmatrixValuesRight.ReadOnly = true;
            this.TextboxQmatrixValuesRight.Size = new System.Drawing.Size(79, 22);
            this.TextboxQmatrixValuesRight.TabIndex = 17;
            // 
            // LabelQmatrixValuesRight
            // 
            this.LabelQmatrixValuesRight.AutoSize = true;
            this.LabelQmatrixValuesRight.Location = new System.Drawing.Point(108, 19);
            this.LabelQmatrixValuesRight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelQmatrixValuesRight.Name = "LabelQmatrixValuesRight";
            this.LabelQmatrixValuesRight.Size = new System.Drawing.Size(41, 17);
            this.LabelQmatrixValuesRight.TabIndex = 16;
            this.LabelQmatrixValuesRight.Text = "Right";
            // 
            // LabelQmatrixValuesDown
            // 
            this.LabelQmatrixValuesDown.AutoSize = true;
            this.LabelQmatrixValuesDown.Location = new System.Drawing.Point(197, 19);
            this.LabelQmatrixValuesDown.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelQmatrixValuesDown.Name = "LabelQmatrixValuesDown";
            this.LabelQmatrixValuesDown.Size = new System.Drawing.Size(43, 17);
            this.LabelQmatrixValuesDown.TabIndex = 14;
            this.LabelQmatrixValuesDown.Text = "Down";
            // 
            // LabelQmatrixValuesLeft
            // 
            this.LabelQmatrixValuesLeft.AutoSize = true;
            this.LabelQmatrixValuesLeft.Location = new System.Drawing.Point(21, 18);
            this.LabelQmatrixValuesLeft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelQmatrixValuesLeft.Name = "LabelQmatrixValuesLeft";
            this.LabelQmatrixValuesLeft.Size = new System.Drawing.Size(32, 17);
            this.LabelQmatrixValuesLeft.TabIndex = 12;
            this.LabelQmatrixValuesLeft.Text = "Left";
            // 
            // TextboxQmatrixValuesLeft
            // 
            this.TextboxQmatrixValuesLeft.Location = new System.Drawing.Point(27, 38);
            this.TextboxQmatrixValuesLeft.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxQmatrixValuesLeft.Name = "TextboxQmatrixValuesLeft";
            this.TextboxQmatrixValuesLeft.ReadOnly = true;
            this.TextboxQmatrixValuesLeft.Size = new System.Drawing.Size(79, 22);
            this.TextboxQmatrixValuesLeft.TabIndex = 13;
            // 
            // groupboxQmatrix
            // 
            this.GroupboxQmatrix.Controls.Add(this.LabelQmatrixStoredEntries);
            this.GroupboxQmatrix.Controls.Add(this.TextboxQmatrixStoredEntries);
            this.GroupboxQmatrix.Controls.Add(this.GroupboxQmatrixSelect);
            this.GroupboxQmatrix.Controls.Add(this.GroupboxQmatrixValues);
            this.GroupboxQmatrix.Enabled = false;
            this.GroupboxQmatrix.Location = new System.Drawing.Point(1408, 165);
            this.GroupboxQmatrix.Margin = new System.Windows.Forms.Padding(4);
            this.GroupboxQmatrix.Name = "GroupboxQmatrix";
            this.GroupboxQmatrix.Padding = new System.Windows.Forms.Padding(4);
            this.GroupboxQmatrix.Size = new System.Drawing.Size(568, 204);
            this.GroupboxQmatrix.TabIndex = 12;
            this.GroupboxQmatrix.TabStop = false;
            this.GroupboxQmatrix.Text = "Q-Matrix";
            // 
            // LabelQmatrixStoredEntries
            // 
            this.LabelQmatrixStoredEntries.AutoSize = true;
            this.LabelQmatrixStoredEntries.Location = new System.Drawing.Point(470, 146);
            this.LabelQmatrixStoredEntries.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelQmatrixStoredEntries.Name = "LabelQmatrixStoredEntries";
            this.LabelQmatrixStoredEntries.Size = new System.Drawing.Size(97, 17);
            this.LabelQmatrixStoredEntries.TabIndex = 62;
            this.LabelQmatrixStoredEntries.Text = "Stored entries";
            // 
            // TextboxQmatrixStoredEntries
            // 
            this.TextboxQmatrixStoredEntries.Location = new System.Drawing.Point(473, 163);
            this.TextboxQmatrixStoredEntries.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxQmatrixStoredEntries.Name = "TextboxQmatrixStoredEntries";
            this.TextboxQmatrixStoredEntries.ReadOnly = true;
            this.TextboxQmatrixStoredEntries.Size = new System.Drawing.Size(79, 22);
            this.TextboxQmatrixStoredEntries.TabIndex = 61;
            // 
            // GroupboxQmatrixSelect
            // 
            this.GroupboxQmatrixSelect.Controls.Add(this.LabelQmatrixComboboxLeft);
            this.GroupboxQmatrixSelect.Controls.Add(this.LabelQmatrixComboboxUp);
            this.GroupboxQmatrixSelect.Controls.Add(this.ComboboxQmatrixGrab);
            this.GroupboxQmatrixSelect.Controls.Add(this.LabelQmatrixComboboxDown);
            this.GroupboxQmatrixSelect.Controls.Add(this.ComboboxQmatrixUp);
            this.GroupboxQmatrixSelect.Controls.Add(this.LabelQmatrixComboboxRight);
            this.GroupboxQmatrixSelect.Controls.Add(this.ComboboxQmatrixDown);
            this.GroupboxQmatrixSelect.Controls.Add(this.LabelQmatrixComboboxGrab);
            this.GroupboxQmatrixSelect.Controls.Add(this.ComboboxQmatrixRight);
            this.GroupboxQmatrixSelect.Controls.Add(this.ComboboxQmatrixLeft);
            this.GroupboxQmatrixSelect.Controls.Add(this.ComboboxQmatrixSelect);
            this.GroupboxQmatrixSelect.Location = new System.Drawing.Point(7, 18);
            this.GroupboxQmatrixSelect.Name = "GroupboxQmatrixSelect";
            this.GroupboxQmatrixSelect.Size = new System.Drawing.Size(554, 110);
            this.GroupboxQmatrixSelect.TabIndex = 59;
            this.GroupboxQmatrixSelect.TabStop = false;
            this.GroupboxQmatrixSelect.Text = "Select";
            // 
            // LabelQmatrixComboboxLeft
            // 
            this.LabelQmatrixComboboxLeft.AutoSize = true;
            this.LabelQmatrixComboboxLeft.Location = new System.Drawing.Point(24, 53);
            this.LabelQmatrixComboboxLeft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelQmatrixComboboxLeft.Name = "LabelQmatrixComboboxLeft";
            this.LabelQmatrixComboboxLeft.Size = new System.Drawing.Size(32, 17);
            this.LabelQmatrixComboboxLeft.TabIndex = 22;
            this.LabelQmatrixComboboxLeft.Text = "Left";
            // 
            // LabelQmatrixComboboxUp
            // 
            this.LabelQmatrixComboboxUp.AutoSize = true;
            this.LabelQmatrixComboboxUp.Location = new System.Drawing.Point(290, 51);
            this.LabelQmatrixComboboxUp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelQmatrixComboboxUp.Name = "LabelQmatrixComboboxUp";
            this.LabelQmatrixComboboxUp.Size = new System.Drawing.Size(26, 17);
            this.LabelQmatrixComboboxUp.TabIndex = 25;
            this.LabelQmatrixComboboxUp.Text = "Up";
            // 
            // ComboboxQmatrixGrab
            // 
            this.ComboboxQmatrixGrab.FormattingEnabled = true;
            this.ComboboxQmatrixGrab.Location = new System.Drawing.Point(376, 69);
            this.ComboboxQmatrixGrab.Name = "ComboboxQmatrixGrab";
            this.ComboboxQmatrixGrab.Size = new System.Drawing.Size(75, 24);
            this.ComboboxQmatrixGrab.TabIndex = 5;
            this.ComboboxQmatrixGrab.SelectedIndexChanged += new System.EventHandler(this.QmatrixSmallDropdownChanged);
            // 
            // LabelQmatrixComboboxDown
            // 
            this.LabelQmatrixComboboxDown.AutoSize = true;
            this.LabelQmatrixComboboxDown.Location = new System.Drawing.Point(200, 50);
            this.LabelQmatrixComboboxDown.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelQmatrixComboboxDown.Name = "LabelQmatrixComboboxDown";
            this.LabelQmatrixComboboxDown.Size = new System.Drawing.Size(43, 17);
            this.LabelQmatrixComboboxDown.TabIndex = 23;
            this.LabelQmatrixComboboxDown.Text = "Down";
            // 
            // ComboboxQmatrixUp
            // 
            this.ComboboxQmatrixUp.FormattingEnabled = true;
            this.ComboboxQmatrixUp.Location = new System.Drawing.Point(291, 69);
            this.ComboboxQmatrixUp.Name = "ComboboxQmatrixUp";
            this.ComboboxQmatrixUp.Size = new System.Drawing.Size(79, 24);
            this.ComboboxQmatrixUp.TabIndex = 4;
            this.ComboboxQmatrixUp.SelectedIndexChanged += new System.EventHandler(this.QmatrixSmallDropdownChanged);
            // 
            // LabelQmatrixComboboxRight
            // 
            this.LabelQmatrixComboboxRight.AutoSize = true;
            this.LabelQmatrixComboboxRight.Location = new System.Drawing.Point(111, 51);
            this.LabelQmatrixComboboxRight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelQmatrixComboboxRight.Name = "LabelQmatrixComboboxRight";
            this.LabelQmatrixComboboxRight.Size = new System.Drawing.Size(41, 17);
            this.LabelQmatrixComboboxRight.TabIndex = 24;
            this.LabelQmatrixComboboxRight.Text = "Right";
            // 
            // ComboboxQmatrixDown
            // 
            this.ComboboxQmatrixDown.FormattingEnabled = true;
            this.ComboboxQmatrixDown.Location = new System.Drawing.Point(203, 69);
            this.ComboboxQmatrixDown.Name = "ComboboxQmatrixDown";
            this.ComboboxQmatrixDown.Size = new System.Drawing.Size(79, 24);
            this.ComboboxQmatrixDown.TabIndex = 3;
            this.ComboboxQmatrixDown.SelectedIndexChanged += new System.EventHandler(this.QmatrixSmallDropdownChanged);
            // 
            // LabelQmatrixComboboxGrab
            // 
            this.LabelQmatrixComboboxGrab.AutoSize = true;
            this.LabelQmatrixComboboxGrab.Location = new System.Drawing.Point(372, 51);
            this.LabelQmatrixComboboxGrab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelQmatrixComboboxGrab.Name = "LabelQmatrixComboboxGrab";
            this.LabelQmatrixComboboxGrab.Size = new System.Drawing.Size(103, 17);
            this.LabelQmatrixComboboxGrab.TabIndex = 26;
            this.LabelQmatrixComboboxGrab.Text = "Grab";
            // 
            // ComboboxQmatrixRight
            // 
            this.ComboboxQmatrixRight.FormattingEnabled = true;
            this.ComboboxQmatrixRight.Location = new System.Drawing.Point(115, 70);
            this.ComboboxQmatrixRight.Name = "ComboboxQmatrixRight";
            this.ComboboxQmatrixRight.Size = new System.Drawing.Size(79, 24);
            this.ComboboxQmatrixRight.TabIndex = 2;
            this.ComboboxQmatrixRight.SelectedIndexChanged += new System.EventHandler(this.QmatrixSmallDropdownChanged);
            // 
            // ComboboxQmatrixLeft
            // 
            this.ComboboxQmatrixLeft.FormattingEnabled = true;
            this.ComboboxQmatrixLeft.Location = new System.Drawing.Point(27, 70);
            this.ComboboxQmatrixLeft.Name = "ComboboxQmatrixLeft";
            this.ComboboxQmatrixLeft.Size = new System.Drawing.Size(79, 24);
            this.ComboboxQmatrixLeft.TabIndex = 1;
            this.ComboboxQmatrixLeft.SelectedIndexChanged += new System.EventHandler(this.QmatrixSmallDropdownChanged);
            // 
            // GroupboxQmatrixValues
            // 
            this.GroupboxQmatrixValues.Controls.Add(this.LabelQmatrixValuesLeft);
            this.GroupboxQmatrixValues.Controls.Add(this.TextboxQmatrixValuesUp);
            this.GroupboxQmatrixValues.Controls.Add(this.TextboxQmatrixValuesRight);
            this.GroupboxQmatrixValues.Controls.Add(this.TextboxQmatrixValuesLeft);
            this.GroupboxQmatrixValues.Controls.Add(this.TextboxQmatrixValuesCurrent);
            this.GroupboxQmatrixValues.Controls.Add(this.LabelQmatrixValuesUp);
            this.GroupboxQmatrixValues.Controls.Add(this.LabelQmatrixValuesDown);
            this.GroupboxQmatrixValues.Controls.Add(this.LabelQmatrixValuesRight);
            this.GroupboxQmatrixValues.Controls.Add(this.LabelQmatrixValuesGrab);
            this.GroupboxQmatrixValues.Controls.Add(this.TextboxQmatrixValuesDown);
            this.GroupboxQmatrixValues.Location = new System.Drawing.Point(7, 125);
            this.GroupboxQmatrixValues.Name = "GroupboxQmatrixValues";
            this.GroupboxQmatrixValues.Size = new System.Drawing.Size(460, 71);
            this.GroupboxQmatrixValues.TabIndex = 59;
            this.GroupboxQmatrixValues.TabStop = false;
            this.GroupboxQmatrixValues.Text = "Q-matrix values";
            // 
            // ComboboxHistoryEpisode
            // 
            this.ComboboxHistoryEpisode.FormattingEnabled = true;
            this.ComboboxHistoryEpisode.Location = new System.Drawing.Point(35, 23);
            this.ComboboxHistoryEpisode.Name = "ComboboxHistoryEpisode";
            this.ComboboxHistoryEpisode.Size = new System.Drawing.Size(211, 24);
            this.ComboboxHistoryEpisode.TabIndex = 22;
            this.ComboboxHistoryEpisode.Text = "View prior episodes...";
            this.ComboboxHistoryEpisode.SelectionChangeCommitted += new System.EventHandler(this.HistoryIndexChanged);
            this.ComboboxHistoryEpisode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboboxHistoryEpisodeKeyPressed);
            // 
            // GroupboxHistory
            // 
            this.GroupboxHistory.Controls.Add(this.ComboboxHistoryStep);
            this.GroupboxHistory.Controls.Add(this.ComboboxHistoryEpisode);
            this.GroupboxHistory.Enabled = false;
            this.GroupboxHistory.Location = new System.Drawing.Point(1146, 903);
            this.GroupboxHistory.Name = "GroupboxHistory";
            this.GroupboxHistory.Size = new System.Drawing.Size(257, 97);
            this.GroupboxHistory.TabIndex = 22;
            this.GroupboxHistory.TabStop = false;
            this.GroupboxHistory.Text = "History";
            // 
            // ComboboxHistoryStep
            // 
            this.ComboboxHistoryStep.FormattingEnabled = true;
            this.ComboboxHistoryStep.Location = new System.Drawing.Point(35, 53);
            this.ComboboxHistoryStep.Name = "ComboboxHistoryStep";
            this.ComboboxHistoryStep.Size = new System.Drawing.Size(211, 24);
            this.ComboboxHistoryStep.TabIndex = 23;
            this.ComboboxHistoryStep.Text = "View prior steps...";
            this.ComboboxHistoryStep.DropDown += new System.EventHandler(this.DropdownOpened);
            this.ComboboxHistoryStep.SelectionChangeCommitted += new System.EventHandler(this.ComboboxHistorystepSelectedIndexChanged);
            this.ComboboxHistoryStep.DropDownClosed += new System.EventHandler(this.DropdownClosed);
            this.ComboboxHistoryStep.Click += new System.EventHandler(this.ComboboxClickedClearText);
            this.ComboboxHistoryStep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboboxHistoryStepKeyPressed);
            // 
            // GroupboxAlgorithmProgress
            // 
            this.GroupboxAlgorithmProgress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GroupboxAlgorithmProgress.Controls.Add(this.CheckboxLoopUntilChasing);
            this.GroupboxAlgorithmProgress.Controls.Add(this.LabelMsDelayPerStep);
            this.GroupboxAlgorithmProgress.Controls.Add(this.ComboboxDelayMS);
            this.GroupboxAlgorithmProgress.Controls.Add(this.LabelNumberOfEpisodes);
            this.GroupboxAlgorithmProgress.Controls.Add(this.LabelNumberOfSteps);
            this.GroupboxAlgorithmProgress.Controls.Add(this.ComboboxAdvanceEpisodes);
            this.GroupboxAlgorithmProgress.Controls.Add(this.ComboboxAdvanceSteps);
            this.GroupboxAlgorithmProgress.Controls.Add(this.ButtonStopAlgorithm);
            this.GroupboxAlgorithmProgress.Controls.Add(this.ButtonAdvanceStepsDropDown);
            this.GroupboxAlgorithmProgress.Enabled = false;
            this.GroupboxAlgorithmProgress.Location = new System.Drawing.Point(1146, 553);
            this.GroupboxAlgorithmProgress.Name = "GroupboxAlgorithmProgress";
            this.GroupboxAlgorithmProgress.Size = new System.Drawing.Size(257, 189);
            this.GroupboxAlgorithmProgress.TabIndex = 12;
            this.GroupboxAlgorithmProgress.TabStop = false;
            this.GroupboxAlgorithmProgress.Text = "Control Progress";
            // 
            // CheckboxLoopUntilChasing
            // 
            this.CheckboxLoopUntilChasing.AutoSize = true;
            this.CheckboxLoopUntilChasing.Location = new System.Drawing.Point(35, 127);
            this.CheckboxLoopUntilChasing.Name = "CheckboxLoopUntilChasing";
            this.CheckboxLoopUntilChasing.Size = new System.Drawing.Size(145, 21);
            this.CheckboxLoopUntilChasing.TabIndex = 27;
            this.CheckboxLoopUntilChasing.Text = "Loop until chasing";
            this.CheckboxLoopUntilChasing.UseVisualStyleBackColor = true;
            this.CheckboxLoopUntilChasing.CheckedChanged += new System.EventHandler(this.CheckBox1Changed);
            // 
            // LabelMsDelayPerStep
            // 
            this.LabelMsDelayPerStep.AutoSize = true;
            this.LabelMsDelayPerStep.Location = new System.Drawing.Point(26, 72);
            this.LabelMsDelayPerStep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelMsDelayPerStep.Name = "LabelMsDelayPerStep";
            this.LabelMsDelayPerStep.Size = new System.Drawing.Size(120, 17);
            this.LabelMsDelayPerStep.TabIndex = 26;
            this.LabelMsDelayPerStep.Text = "ms delay per step";
            // 
            // comboboxDelayms
            // 
            this.ComboboxDelayMS.FormattingEnabled = true;
            this.ComboboxDelayMS.Items.AddRange(new object[] {
            "0",
            "5",
            "10",
            "15",
            "20",
            "25",
            "50"});
            this.ComboboxDelayMS.Location = new System.Drawing.Point(35, 92);
            this.ComboboxDelayMS.Name = "ComboboxDelayMS";
            this.ComboboxDelayMS.Size = new System.Drawing.Size(89, 24);
            this.ComboboxDelayMS.TabIndex = 26;
            this.ComboboxDelayMS.Text = "5";
            this.ComboboxDelayMS.DropDown += new System.EventHandler(this.DropdownOpened);
            this.ComboboxDelayMS.DropDownClosed += new System.EventHandler(this.DropdownClosed);
            this.ComboboxDelayMS.Click += new System.EventHandler(this.ComboboxClickedClearText);
            this.ComboboxDelayMS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboboxDelayMsKeyPressed);
            this.ComboboxDelayMS.Leave += new System.EventHandler(this.ComboboxDelayMsLeave);
            // 
            // LabelNumberOfEpisodes
            // 
            this.LabelNumberOfEpisodes.AutoSize = true;
            this.LabelNumberOfEpisodes.Location = new System.Drawing.Point(152, 17);
            this.LabelNumberOfEpisodes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelNumberOfEpisodes.Name = "LabelNumberOfEpisodes";
            this.LabelNumberOfEpisodes.Size = new System.Drawing.Size(93, 17);
            this.LabelNumberOfEpisodes.TabIndex = 23;
            this.LabelNumberOfEpisodes.Text = "# of episodes";
            // 
            // LabelNumberOfSteps
            // 
            this.LabelNumberOfSteps.AutoSize = true;
            this.LabelNumberOfSteps.Location = new System.Drawing.Point(32, 17);
            this.LabelNumberOfSteps.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelNumberOfSteps.Name = "LabelNumberOfSteps";
            this.LabelNumberOfSteps.Size = new System.Drawing.Size(70, 17);
            this.LabelNumberOfSteps.TabIndex = 22;
            this.LabelNumberOfSteps.Text = "# of steps";
            // 
            // ComboboxAdvanceepisodes
            // 
            this.ComboboxAdvanceEpisodes.FormattingEnabled = true;
            this.ComboboxAdvanceEpisodes.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "5",
            "10",
            "25",
            "50",
            "100",
            "500",
            "1000",
            "5000"});
            this.ComboboxAdvanceEpisodes.Location = new System.Drawing.Point(155, 36);
            this.ComboboxAdvanceEpisodes.Name = "ComboboxAdvanceEpisodes";
            this.ComboboxAdvanceEpisodes.Size = new System.Drawing.Size(90, 24);
            this.ComboboxAdvanceEpisodes.TabIndex = 21;
            this.ComboboxAdvanceEpisodes.DropDown += new System.EventHandler(this.DropdownOpened);
            this.ComboboxAdvanceEpisodes.SelectedIndexChanged += new System.EventHandler(this.ComboboxAdvanceEpisodesSelectedIndexChanged);
            this.ComboboxAdvanceEpisodes.DropDownClosed += new System.EventHandler(this.DropdownClosed);
            this.ComboboxAdvanceEpisodes.Leave += new System.EventHandler(this.ComboboxAdvanceEpisodesLeave);
            // 
            // ComboboxAdvanceSteps
            // 
            this.ComboboxAdvanceSteps.FormattingEnabled = true;
            this.ComboboxAdvanceSteps.Items.AddRange(new object[] {
            "1",
            "2",
            "5",
            "10",
            "25",
            "100"});
            this.ComboboxAdvanceSteps.Location = new System.Drawing.Point(35, 35);
            this.ComboboxAdvanceSteps.Name = "ComboboxAdvanceSteps";
            this.ComboboxAdvanceSteps.Size = new System.Drawing.Size(89, 24);
            this.ComboboxAdvanceSteps.TabIndex = 19;
            this.ComboboxAdvanceSteps.DropDown += new System.EventHandler(this.DropdownOpened);
            this.ComboboxAdvanceSteps.DropDownClosed += new System.EventHandler(this.DropdownClosed);
            this.ComboboxAdvanceSteps.Click += new System.EventHandler(this.ComboboxClickedClearText);
            this.ComboboxAdvanceSteps.Leave += new System.EventHandler(this.ComboboxAdvanceStepsLeave);
            // 
            // ButtonAdvanceStepsDropDown
            // 
            this.ButtonAdvanceStepsDropDown.Location = new System.Drawing.Point(155, 90);
            this.ButtonAdvanceStepsDropDown.Name = "ButtonAdvanceStepsDropDown";
            this.ButtonAdvanceStepsDropDown.Size = new System.Drawing.Size(90, 27);
            this.ButtonAdvanceStepsDropDown.TabIndex = 20;
            this.ButtonAdvanceStepsDropDown.Text = "Step";
            this.ButtonAdvanceStepsDropDown.UseVisualStyleBackColor = true;
            this.ButtonAdvanceStepsDropDown.Click += new System.EventHandler(this.ButtonAdvanceStepsComboboxClicked);
            // 
            // GroupboxCountDown
            // 
            this.GroupboxCountDown.Controls.Add(this.ButtonStop);
            this.GroupboxCountDown.Controls.Add(this.LabelInProgressSteps);
            this.GroupboxCountDown.Controls.Add(this.TextboxInProgressSteps);
            this.GroupboxCountDown.Controls.Add(this.LabelInProgressTime);
            this.GroupboxCountDown.Controls.Add(this.TextboxInProgressTime);
            this.GroupboxCountDown.Enabled = false;
            this.GroupboxCountDown.Location = new System.Drawing.Point(1146, 762);
            this.GroupboxCountDown.Name = "GroupboxCountDown";
            this.GroupboxCountDown.Size = new System.Drawing.Size(257, 119);
            this.GroupboxCountDown.TabIndex = 60;
            this.GroupboxCountDown.TabStop = false;
            this.GroupboxCountDown.Text = "In progress";
            // 
            // ButtonStop
            // 
            this.ButtonStop.Location = new System.Drawing.Point(35, 74);
            this.ButtonStop.Name = "ButtonStop";
            this.ButtonStop.Size = new System.Drawing.Size(211, 27);
            this.ButtonStop.TabIndex = 30;
            this.ButtonStop.Text = "Stop";
            this.ButtonStop.UseVisualStyleBackColor = true;
            this.ButtonStop.Click += new System.EventHandler(this.ButtonStopClicked);
            // 
            // LabelInProgressSteps
            // 
            this.LabelInProgressSteps.AutoSize = true;
            this.LabelInProgressSteps.Location = new System.Drawing.Point(148, 18);
            this.LabelInProgressSteps.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelInProgressSteps.Name = "LabelInProgressSteps";
            this.LabelInProgressSteps.Size = new System.Drawing.Size(44, 17);
            this.LabelInProgressSteps.TabIndex = 29;
            this.LabelInProgressSteps.Text = "Steps";
            // 
            // TextboxInProgressSteps
            // 
            this.TextboxInProgressSteps.Location = new System.Drawing.Point(155, 36);
            this.TextboxInProgressSteps.Name = "TextboxInProgressSteps";
            this.TextboxInProgressSteps.ReadOnly = true;
            this.TextboxInProgressSteps.Size = new System.Drawing.Size(91, 22);
            this.TextboxInProgressSteps.TabIndex = 28;
            this.TextboxInProgressSteps.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LabelInProgressTime
            // 
            this.LabelInProgressTime.AutoSize = true;
            this.LabelInProgressTime.Location = new System.Drawing.Point(32, 18);
            this.LabelInProgressTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelInProgressTime.Name = "LabelInProgressTime";
            this.LabelInProgressTime.Size = new System.Drawing.Size(39, 17);
            this.LabelInProgressTime.TabIndex = 27;
            this.LabelInProgressTime.Text = "Time";
            // 
            // TextboxInProgressTime
            // 
            this.TextboxInProgressTime.Location = new System.Drawing.Point(35, 35);
            this.TextboxInProgressTime.Name = "TextboxInProgressTime";
            this.TextboxInProgressTime.ReadOnly = true;
            this.TextboxInProgressTime.Size = new System.Drawing.Size(89, 22);
            this.TextboxInProgressTime.TabIndex = 0;
            this.TextboxInProgressTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GroupboxConfiguration
            // 
            this.GroupboxConfiguration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.GroupboxConfiguration.Controls.Add(this.GroupboxConfigurationRewards);
            this.GroupboxConfiguration.Controls.Add(this.ButtonConfigurationReset);
            this.GroupboxConfiguration.Controls.Add(this.ButtonConfigurationStartAlgorithm);
            this.GroupboxConfiguration.Controls.Add(this.LabelConfigurationNumberOfEpisodes);
            this.GroupboxConfiguration.Controls.Add(this.LabelConfigurationComboboxEpsilon);
            this.GroupboxConfiguration.Controls.Add(this.ComboboxConfigurationNumberOfEpisodes);
            this.GroupboxConfiguration.Controls.Add(this.LabelConfigurationComboboxGamma);
            this.GroupboxConfiguration.Controls.Add(this.ComboboxConfigurationEta);
            this.GroupboxConfiguration.Controls.Add(this.ComboboxConfigurationEpsilon);
            this.GroupboxConfiguration.Controls.Add(this.LabelConfigurationComboboxEta);
            this.GroupboxConfiguration.Controls.Add(this.LabelConfigurationComboboxNumberOfStepsPerEpisode);
            this.GroupboxConfiguration.Controls.Add(this.ComboboxConfigurationNumberOfStepsPerEpisode);
            this.GroupboxConfiguration.Controls.Add(this.ComboboxConfigurationGamma);
            this.GroupboxConfiguration.Controls.Add(this.PictureboxFrySquinting);
            this.GroupboxConfiguration.Location = new System.Drawing.Point(1146, 13);
            this.GroupboxConfiguration.Name = "GroupboxConfiguration";
            this.GroupboxConfiguration.Size = new System.Drawing.Size(257, 534);
            this.GroupboxConfiguration.TabIndex = 11;
            this.GroupboxConfiguration.TabStop = false;
            this.GroupboxConfiguration.Text = "Configuration";
            // 
            // GroupboxConfigurationRewards
            // 
            this.GroupboxConfigurationRewards.Controls.Add(this.LabelRewardsMovedWithoutHittingWall);
            this.GroupboxConfigurationRewards.Controls.Add(this.ComboboxRewardsMovedWithoutHittingWall);
            this.GroupboxConfigurationRewards.Controls.Add(this.LabelRewardsRanIntoWall);
            this.GroupboxConfigurationRewards.Controls.Add(this.ComboboxRewardsGrabbedEmptySquare);
            this.GroupboxConfigurationRewards.Controls.Add(this.LabelRewardsGrabbedEmptySquare);
            this.GroupboxConfigurationRewards.Controls.Add(this.ComboboxRewardsCollectedBeer);
            this.GroupboxConfigurationRewards.Controls.Add(this.ComboboxRewardsRanIntoWall);
            this.GroupboxConfigurationRewards.Controls.Add(this.LabelRewardsCollectedBeer);
            this.GroupboxConfigurationRewards.Location = new System.Drawing.Point(16, 202);
            this.GroupboxConfigurationRewards.Name = "GroupboxConfigurationRewards";
            this.GroupboxConfigurationRewards.Size = new System.Drawing.Size(228, 232);
            this.GroupboxConfigurationRewards.TabIndex = 67;
            this.GroupboxConfigurationRewards.TabStop = false;
            this.GroupboxConfigurationRewards.Text = "Rewards";
            // 
            // LabelRewardsMovedWithoutHittingWall
            // 
            this.LabelRewardsMovedWithoutHittingWall.AutoSize = true;
            this.LabelRewardsMovedWithoutHittingWall.Location = new System.Drawing.Point(16, 177);
            this.LabelRewardsMovedWithoutHittingWall.Name = "LabelRewardsMovedWithoutHittingWall";
            this.LabelRewardsMovedWithoutHittingWall.Size = new System.Drawing.Size(179, 17);
            this.LabelRewardsMovedWithoutHittingWall.TabIndex = 69;
            this.LabelRewardsMovedWithoutHittingWall.Text = "Moved without hitting a wall";
            // 
            // ComboboxMovedWithoutHittingWall
            // 
            this.ComboboxRewardsMovedWithoutHittingWall.FormattingEnabled = true;
            this.ComboboxRewardsMovedWithoutHittingWall.Items.AddRange(new object[] {
            "-20",
            "-10",
            "-5",
            "0",
            "5",
            "10",
            "20"});
            this.ComboboxRewardsMovedWithoutHittingWall.Location = new System.Drawing.Point(19, 195);
            this.ComboboxRewardsMovedWithoutHittingWall.Name = "ComboboxMovedWithoutHittingWall";
            this.ComboboxRewardsMovedWithoutHittingWall.Size = new System.Drawing.Size(202, 24);
            this.ComboboxRewardsMovedWithoutHittingWall.TabIndex = 17;
            this.ComboboxRewardsMovedWithoutHittingWall.DropDown += new System.EventHandler(this.DropdownOpened);
            this.ComboboxRewardsMovedWithoutHittingWall.SelectedIndexChanged += new System.EventHandler(this.ComboboxRewardsMovedWithoutHittingWallClicked);
            this.ComboboxRewardsMovedWithoutHittingWall.DropDownClosed += new System.EventHandler(this.DropdownClosed);
            this.ComboboxRewardsMovedWithoutHittingWall.Click += new System.EventHandler(this.ComboboxClickedClearText);
            this.ComboboxRewardsMovedWithoutHittingWall.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboboxMovedWithoutWallKeyPressed);
            // 
            // LabelRewardsRanIntoWall
            // 
            this.LabelRewardsRanIntoWall.AutoSize = true;
            this.LabelRewardsRanIntoWall.Location = new System.Drawing.Point(16, 124);
            this.LabelRewardsRanIntoWall.Name = "LabelRewardsRanIntoWall";
            this.LabelRewardsRanIntoWall.Size = new System.Drawing.Size(100, 17);
            this.LabelRewardsRanIntoWall.TabIndex = 64;
            this.LabelRewardsRanIntoWall.Text = "Ran into a wall";
            // 
            // ComboboxRewardsGrabbedEmptySquare
            // 
            this.ComboboxRewardsGrabbedEmptySquare.FormattingEnabled = true;
            this.ComboboxRewardsGrabbedEmptySquare.Items.AddRange(new object[] {
            "-20",
            "-10",
            "-5",
            "0",
            "5",
            "10",
            "20"});
            this.ComboboxRewardsGrabbedEmptySquare.Location = new System.Drawing.Point(19, 90);
            this.ComboboxRewardsGrabbedEmptySquare.Name = "ComboboxRewardsGrabbedEmptySquare";
            this.ComboboxRewardsGrabbedEmptySquare.Size = new System.Drawing.Size(202, 24);
            this.ComboboxRewardsGrabbedEmptySquare.TabIndex = 13;
            this.ComboboxRewardsGrabbedEmptySquare.DropDown += new System.EventHandler(this.DropdownOpened);
            this.ComboboxRewardsGrabbedEmptySquare.SelectedIndexChanged += new System.EventHandler(this.ComboboxRewardsGrabbedEmptySquareClicked);
            this.ComboboxRewardsGrabbedEmptySquare.DropDownClosed += new System.EventHandler(this.DropdownClosed);
            this.ComboboxRewardsGrabbedEmptySquare.Click += new System.EventHandler(this.ComboboxClickedClearText);
            this.ComboboxRewardsGrabbedEmptySquare.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboboxEmptysquareKeyPressed);
            // 
            // LabelRewardsGrabbedEmptySquare
            // 
            this.LabelRewardsGrabbedEmptySquare.AutoSize = true;
            this.LabelRewardsGrabbedEmptySquare.Location = new System.Drawing.Point(16, 71);
            this.LabelRewardsGrabbedEmptySquare.Name = "LabelRewardsGrabbedEmptySquare";
            this.LabelRewardsGrabbedEmptySquare.Size = new System.Drawing.Size(163, 17);
            this.LabelRewardsGrabbedEmptySquare.TabIndex = 66;
            this.LabelRewardsGrabbedEmptySquare.Text = "Incorrectly grabbed beer";
            // 
            // ComboboxRewardsCollectedBeer
            // 
            this.ComboboxRewardsCollectedBeer.FormattingEnabled = true;
            this.ComboboxRewardsCollectedBeer.Items.AddRange(new object[] {
            "-20",
            "-10",
            "-5",
            "0",
            "5",
            "10",
            "20"});
            this.ComboboxRewardsCollectedBeer.Location = new System.Drawing.Point(19, 38);
            this.ComboboxRewardsCollectedBeer.Name = "ComboboxRewardsCollectedBeer";
            this.ComboboxRewardsCollectedBeer.Size = new System.Drawing.Size(202, 24);
            this.ComboboxRewardsCollectedBeer.TabIndex = 11;
            this.ComboboxRewardsCollectedBeer.DropDown += new System.EventHandler(this.DropdownOpened);
            this.ComboboxRewardsCollectedBeer.SelectedIndexChanged += new System.EventHandler(this.ComboboxRewardsCollectedBeerClicked);
            this.ComboboxRewardsCollectedBeer.DropDownClosed += new System.EventHandler(this.DropdownClosed);
            this.ComboboxRewardsCollectedBeer.Click += new System.EventHandler(this.ComboboxClickedClearText);
            this.ComboboxRewardsCollectedBeer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboboxBeerKeyPressed);
            // 
            // ComboboxRewardsRanIntoWall
            // 
            this.ComboboxRewardsRanIntoWall.FormattingEnabled = true;
            this.ComboboxRewardsRanIntoWall.Items.AddRange(new object[] {
            "-20",
            "-10",
            "-5",
            "0",
            "5",
            "10",
            "20"});
            this.ComboboxRewardsRanIntoWall.Location = new System.Drawing.Point(19, 143);
            this.ComboboxRewardsRanIntoWall.Name = "ComboboxRewardsRanIntoWall";
            this.ComboboxRewardsRanIntoWall.Size = new System.Drawing.Size(202, 24);
            this.ComboboxRewardsRanIntoWall.TabIndex = 15;
            this.ComboboxRewardsRanIntoWall.DropDown += new System.EventHandler(this.DropdownOpened);
            this.ComboboxRewardsRanIntoWall.SelectedIndexChanged += new System.EventHandler(this.ComboboxRewardsRanIntoWallClicked);
            this.ComboboxRewardsRanIntoWall.DropDownClosed += new System.EventHandler(this.DropdownClosed);
            this.ComboboxRewardsRanIntoWall.Click += new System.EventHandler(this.ComboboxClickedClearText);
            this.ComboboxRewardsRanIntoWall.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboboxWallpunishmentKeyPressed);
            // 
            // LabelRewardsCollectedBeer
            // 
            this.LabelRewardsCollectedBeer.AutoSize = true;
            this.LabelRewardsCollectedBeer.Location = new System.Drawing.Point(16, 18);
            this.LabelRewardsCollectedBeer.Name = "LabelRewardsCollectedBeer";
            this.LabelRewardsCollectedBeer.Size = new System.Drawing.Size(99, 17);
            this.LabelRewardsCollectedBeer.TabIndex = 65;
            this.LabelRewardsCollectedBeer.Text = "Collected beer";
            // 
            // ButtonConfigurationReset
            // 
            this.ButtonConfigurationReset.Location = new System.Drawing.Point(35, 476);
            this.ButtonConfigurationReset.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonConfigurationReset.Name = "ButtonConfigurationReset";
            this.ButtonConfigurationReset.Size = new System.Drawing.Size(201, 28);
            this.ButtonConfigurationReset.TabIndex = 12;
            this.ButtonConfigurationReset.Text = "Reset config";
            this.ButtonConfigurationReset.UseVisualStyleBackColor = true;
            this.ButtonConfigurationReset.Click += new System.EventHandler(this.ResetConfigButtonClicked);
            // 
            // ButtonConfigurastionStartAlgorithm
            // 
            this.ButtonConfigurationStartAlgorithm.Location = new System.Drawing.Point(35, 441);
            this.ButtonConfigurationStartAlgorithm.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonConfigurationStartAlgorithm.Name = "ButtonConfigurastionStartAlgorithm";
            this.ButtonConfigurationStartAlgorithm.Size = new System.Drawing.Size(202, 28);
            this.ButtonConfigurationStartAlgorithm.TabIndex = 7;
            this.ButtonConfigurationStartAlgorithm.Text = "Start algorithm";
            this.ButtonConfigurationStartAlgorithm.UseVisualStyleBackColor = true;
            this.ButtonConfigurationStartAlgorithm.Click += new System.EventHandler(this.StartAlgorithm);
            // 
            // LabelConfigurationNumberOfEpisodes
            // 
            this.LabelConfigurationNumberOfEpisodes.AutoSize = true;
            this.LabelConfigurationNumberOfEpisodes.Location = new System.Drawing.Point(32, 43);
            this.LabelConfigurationNumberOfEpisodes.Name = "LabelConfigurationNumberOfEpisodes";
            this.LabelConfigurationNumberOfEpisodes.Size = new System.Drawing.Size(93, 17);
            this.LabelConfigurationNumberOfEpisodes.TabIndex = 59;
            this.LabelConfigurationNumberOfEpisodes.Text = "# of episodes";
            // 
            // LabelConfigurationComboboxEpsilon
            // 
            this.LabelConfigurationComboboxEpsilon.AutoSize = true;
            this.LabelConfigurationComboboxEpsilon.Location = new System.Drawing.Point(178, 146);
            this.LabelConfigurationComboboxEpsilon.Name = "LabelConfigurationComboboxEpsilon";
            this.LabelConfigurationComboboxEpsilon.Size = new System.Drawing.Size(17, 17);
            this.LabelConfigurationComboboxEpsilon.TabIndex = 63;
            this.LabelConfigurationComboboxEpsilon.Text = "Ɛ";
            // 
            // ComboboxConfigurationNumberOfEpisodes
            // 
            this.ComboboxConfigurationNumberOfEpisodes.FormattingEnabled = true;
            this.ComboboxConfigurationNumberOfEpisodes.Items.AddRange(new object[] {
            "1000",
            "2500",
            "5000",
            "10000",
            "50000"});
            this.ComboboxConfigurationNumberOfEpisodes.Location = new System.Drawing.Point(35, 63);
            this.ComboboxConfigurationNumberOfEpisodes.Name = "ComboboxConfigurationNumberOfEpisodes";
            this.ComboboxConfigurationNumberOfEpisodes.Size = new System.Drawing.Size(201, 24);
            this.ComboboxConfigurationNumberOfEpisodes.TabIndex = 1;
            this.ComboboxConfigurationNumberOfEpisodes.DropDown += new System.EventHandler(this.DropdownOpened);
            this.ComboboxConfigurationNumberOfEpisodes.SelectedIndexChanged += new System.EventHandler(this.SetEpisodeFromCombobox);
            this.ComboboxConfigurationNumberOfEpisodes.DropDownClosed += new System.EventHandler(this.DropdownClosedNumberEpisodes);
            this.ComboboxConfigurationNumberOfEpisodes.Click += new System.EventHandler(this.ComboboxClickedClearText);
            this.ComboboxConfigurationNumberOfEpisodes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboboxEpisodeKeyPress);
            // 
            // LabelConfigurationComboboxGamma
            // 
            this.LabelConfigurationComboboxGamma.AutoSize = true;
            this.LabelConfigurationComboboxGamma.Location = new System.Drawing.Point(32, 143);
            this.LabelConfigurationComboboxGamma.Name = "LabelConfigurationComboboxGamma";
            this.LabelConfigurationComboboxGamma.Size = new System.Drawing.Size(15, 17);
            this.LabelConfigurationComboboxGamma.TabIndex = 62;
            this.LabelConfigurationComboboxGamma.Text = "γ";
            // 
            // ComboboxConfigurationEta
            // 
            this.ComboboxConfigurationEta.FormattingEnabled = true;
            this.ComboboxConfigurationEta.Location = new System.Drawing.Point(108, 163);
            this.ComboboxConfigurationEta.Name = "ComboboxConfigurationEta";
            this.ComboboxConfigurationEta.Size = new System.Drawing.Size(60, 24);
            this.ComboboxConfigurationEta.TabIndex = 5;
            this.ComboboxConfigurationEta.DropDown += new System.EventHandler(this.DropdownOpened);
            this.ComboboxConfigurationEta.SelectedIndexChanged += new System.EventHandler(this.SetEtaFromCombobox);
            this.ComboboxConfigurationEta.DropDownClosed += new System.EventHandler(this.DropdownClosed);
            this.ComboboxConfigurationEta.Click += new System.EventHandler(this.ComboboxClickedClearText);
            this.ComboboxConfigurationEta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboboxEtaKeyPressed);
            // 
            // ComboboxConfigurationEpsilon
            // 
            this.ComboboxConfigurationEpsilon.FormattingEnabled = true;
            this.ComboboxConfigurationEpsilon.Location = new System.Drawing.Point(178, 163);
            this.ComboboxConfigurationEpsilon.Name = "ComboboxConfigurationEpsilon";
            this.ComboboxConfigurationEpsilon.Size = new System.Drawing.Size(58, 24);
            this.ComboboxConfigurationEpsilon.TabIndex = 9;
            this.ComboboxConfigurationEpsilon.DropDown += new System.EventHandler(this.DropdownOpened);
            this.ComboboxConfigurationEpsilon.SelectedIndexChanged += new System.EventHandler(this.ComboboxConfigurationEpsilonClicked);
            this.ComboboxConfigurationEpsilon.DropDownClosed += new System.EventHandler(this.DropdownClosed);
            this.ComboboxConfigurationEpsilon.Click += new System.EventHandler(this.ComboboxClickedClearText);
            this.ComboboxConfigurationEpsilon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboboxEpsilonKeyPressed);
            // 
            // LabelConfigurationComboboxEta
            // 
            this.LabelConfigurationComboboxEta.AutoSize = true;
            this.LabelConfigurationComboboxEta.Location = new System.Drawing.Point(106, 144);
            this.LabelConfigurationComboboxEta.Name = "LabelConfigurationComboboxEta";
            this.LabelConfigurationComboboxEta.Size = new System.Drawing.Size(16, 17);
            this.LabelConfigurationComboboxEta.TabIndex = 61;
            this.LabelConfigurationComboboxEta.Text = "η";
            // 
            // LabelConfigurationComboboxNumberOfStepsPerEpisode
            // 
            this.LabelConfigurationComboboxNumberOfStepsPerEpisode.AutoSize = true;
            this.LabelConfigurationComboboxNumberOfStepsPerEpisode.Location = new System.Drawing.Point(32, 91);
            this.LabelConfigurationComboboxNumberOfStepsPerEpisode.Name = "LabelConfigurationComboboxNumberOfStepsPerEpisode";
            this.LabelConfigurationComboboxNumberOfStepsPerEpisode.Size = new System.Drawing.Size(149, 17);
            this.LabelConfigurationComboboxNumberOfStepsPerEpisode.TabIndex = 60;
            this.LabelConfigurationComboboxNumberOfStepsPerEpisode.Text = "# of steps per episode";
            // 
            // ComboboxConfigurationNumberOfStepsPerEpisode
            // 
            this.ComboboxConfigurationNumberOfStepsPerEpisode.FormattingEnabled = true;
            this.ComboboxConfigurationNumberOfStepsPerEpisode.Items.AddRange(new object[] {
            "50",
            "100",
            "200",
            "400",
            "1000"});
            this.ComboboxConfigurationNumberOfStepsPerEpisode.Location = new System.Drawing.Point(35, 114);
            this.ComboboxConfigurationNumberOfStepsPerEpisode.Name = "ComboboxConfigurationNumberOfStepsPerEpisode";
            this.ComboboxConfigurationNumberOfStepsPerEpisode.Size = new System.Drawing.Size(201, 24);
            this.ComboboxConfigurationNumberOfStepsPerEpisode.TabIndex = 3;
            this.ComboboxConfigurationNumberOfStepsPerEpisode.DropDown += new System.EventHandler(this.DropdownOpened);
            this.ComboboxConfigurationNumberOfStepsPerEpisode.SelectedIndexChanged += new System.EventHandler(this.SetStepsFromCombobox);
            this.ComboboxConfigurationNumberOfStepsPerEpisode.DropDownClosed += new System.EventHandler(this.DropdownClosed);
            this.ComboboxConfigurationNumberOfStepsPerEpisode.Click += new System.EventHandler(this.ComboboxClickedClearText);
            this.ComboboxConfigurationNumberOfStepsPerEpisode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboboxStepsKeyPress);
            // 
            // ComboboxConfigurationGamma
            // 
            this.ComboboxConfigurationGamma.FormattingEnabled = true;
            this.ComboboxConfigurationGamma.Location = new System.Drawing.Point(35, 163);
            this.ComboboxConfigurationGamma.Name = "ComboboxConfigurationGamma";
            this.ComboboxConfigurationGamma.Size = new System.Drawing.Size(60, 24);
            this.ComboboxConfigurationGamma.TabIndex = 7;
            this.ComboboxConfigurationGamma.DropDown += new System.EventHandler(this.DropdownOpened);
            this.ComboboxConfigurationGamma.SelectedIndexChanged += new System.EventHandler(this.SetYFromCombobox);
            this.ComboboxConfigurationGamma.DropDownClosed += new System.EventHandler(this.DropdownClosed);
            this.ComboboxConfigurationGamma.Click += new System.EventHandler(this.ComboboxClickedClearText);
            this.ComboboxConfigurationGamma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboboxGammaKeyPressed);
            // 
            // PictureboxFrySquinting
            // 
            this.PictureboxFrySquinting.BackColor = System.Drawing.Color.Transparent;
            this.PictureboxFrySquinting.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.PictureboxFrySquinting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureboxFrySquinting.Location = new System.Drawing.Point(195, 13);
            this.PictureboxFrySquinting.Name = "PictureboxFrySquinting";
            this.PictureboxFrySquinting.Size = new System.Drawing.Size(40, 52);
            this.PictureboxFrySquinting.TabIndex = 61;
            this.PictureboxFrySquinting.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(34, 102);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(29, 41);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 59;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(38, 192);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(25, 30);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 58;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(38, 377);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(25, 30);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 57;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(38, 282);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(25, 30);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox13.TabIndex = 56;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox24
            // 
            this.pictureBox24.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox24.Image")));
            this.pictureBox24.Location = new System.Drawing.Point(38, 472);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new System.Drawing.Size(25, 30);
            this.pictureBox24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox24.TabIndex = 55;
            this.pictureBox24.TabStop = false;
            // 
            // pictureBox26
            // 
            this.pictureBox26.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox26.Image")));
            this.pictureBox26.Location = new System.Drawing.Point(38, 652);
            this.pictureBox26.Name = "pictureBox26";
            this.pictureBox26.Size = new System.Drawing.Size(25, 30);
            this.pictureBox26.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox26.TabIndex = 53;
            this.pictureBox26.TabStop = false;
            // 
            // pictureBox27
            // 
            this.pictureBox27.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox27.Image")));
            this.pictureBox27.Location = new System.Drawing.Point(38, 557);
            this.pictureBox27.Name = "pictureBox27";
            this.pictureBox27.Size = new System.Drawing.Size(25, 30);
            this.pictureBox27.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox27.TabIndex = 52;
            this.pictureBox27.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(38, 832);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(25, 30);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 47;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(38, 742);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(25, 30);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 46;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox16
            // 
            this.pictureBox16.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox16.Image")));
            this.pictureBox16.Location = new System.Drawing.Point(818, 998);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(25, 30);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox16.TabIndex = 43;
            this.pictureBox16.TabStop = false;
            // 
            // pictureBox18
            // 
            this.pictureBox18.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox18.Image")));
            this.pictureBox18.Location = new System.Drawing.Point(618, 998);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(25, 30);
            this.pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox18.TabIndex = 41;
            this.pictureBox18.TabStop = false;
            // 
            // pictureBox19
            // 
            this.pictureBox19.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox19.Image")));
            this.pictureBox19.Location = new System.Drawing.Point(718, 998);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(25, 30);
            this.pictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox19.TabIndex = 40;
            this.pictureBox19.TabStop = false;
            // 
            // pictureBox20
            // 
            this.pictureBox20.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox20.Image")));
            this.pictureBox20.Location = new System.Drawing.Point(418, 998);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(25, 30);
            this.pictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox20.TabIndex = 39;
            this.pictureBox20.TabStop = false;
            // 
            // pictureBox21
            // 
            this.pictureBox21.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox21.Image")));
            this.pictureBox21.Location = new System.Drawing.Point(518, 998);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(25, 30);
            this.pictureBox21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox21.TabIndex = 38;
            this.pictureBox21.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(218, 998);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(25, 30);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 31;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(318, 998);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(25, 30);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 30;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(118, 998);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // GroupboxStatusMessage
            // 
            this.GroupboxStatusMessage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupboxStatusmessage.BackgroundImage")));
            this.GroupboxStatusMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GroupboxStatusMessage.Controls.Add(this.RichTextboxStatusMessage);
            this.GroupboxStatusMessage.Location = new System.Drawing.Point(1409, 605);
            this.GroupboxStatusMessage.Name = "GroupboxStatusMessage";
            this.GroupboxStatusMessage.Size = new System.Drawing.Size(569, 374);
            this.GroupboxStatusMessage.TabIndex = 23;
            this.GroupboxStatusMessage.TabStop = false;
            this.GroupboxStatusMessage.Text = "Status message";
            // 
            // TextboxStatusMessage
            // 
            this.RichTextboxStatusMessage.Location = new System.Drawing.Point(33, 24);
            this.RichTextboxStatusMessage.Name = "RichTextboxStatusMessage";
            this.RichTextboxStatusMessage.ReadOnly = true;
            this.RichTextboxStatusMessage.Size = new System.Drawing.Size(530, 317);
            this.RichTextboxStatusMessage.TabIndex = 0;
            this.RichTextboxStatusMessage.Text = "";
            // 
            // GroupboxSessionProgress
            // 
            this.GroupboxSessionProgress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupboxSessionprogress.BackgroundImage")));
            this.GroupboxSessionProgress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GroupboxSessionProgress.Controls.Add(this.GroupboxCanDataThisEpisode);
            this.GroupboxSessionProgress.Controls.Add(this.GroupboxRewardData);
            this.GroupboxSessionProgress.Controls.Add(this.LabelSessionProgressGamma);
            this.GroupboxSessionProgress.Controls.Add(this.LabelSessionProgressEpisodeNumber);
            this.GroupboxSessionProgress.Controls.Add(this.TextboxSessionProgressEpisodeNumber);
            this.GroupboxSessionProgress.Controls.Add(this.TextboxSessionProgressStepNumber);
            this.GroupboxSessionProgress.Controls.Add(this.GroupboxCurrentPercepts);
            this.GroupboxSessionProgress.Controls.Add(this.LabelSessionProgressEpsilon);
            this.GroupboxSessionProgress.Controls.Add(this.LabelSessionProgressStepNumber);
            this.GroupboxSessionProgress.Controls.Add(this.TextboxSessionProgessEpsilon);
            this.GroupboxSessionProgress.Controls.Add(this.TextboxSessionProgressGamma);
            this.GroupboxSessionProgress.Enabled = false;
            this.GroupboxSessionProgress.Location = new System.Drawing.Point(1409, 367);
            this.GroupboxSessionProgress.Name = "GroupboxSessionProgress";
            this.GroupboxSessionProgress.Size = new System.Drawing.Size(569, 237);
            this.GroupboxSessionProgress.TabIndex = 18;
            this.GroupboxSessionProgress.TabStop = false;
            this.GroupboxSessionProgress.Text = "Session progress";
            // 
            // GroupboxCanDataThisEpisode
            // 
            this.GroupboxCanDataThisEpisode.Controls.Add(this.LabelCanDataCollected);
            this.GroupboxCanDataThisEpisode.Controls.Add(this.TextboxCanDataCollected);
            this.GroupboxCanDataThisEpisode.Controls.Add(this.TextboxCanDataRemaining);
            this.GroupboxCanDataThisEpisode.Controls.Add(this.LabelCanDataRemaining);
            this.GroupboxCanDataThisEpisode.Location = new System.Drawing.Point(22, 66);
            this.GroupboxCanDataThisEpisode.Name = "GroupboxCanDataThisEpisode";
            this.GroupboxCanDataThisEpisode.Size = new System.Drawing.Size(190, 76);
            this.GroupboxCanDataThisEpisode.TabIndex = 59;
            this.GroupboxCanDataThisEpisode.TabStop = false;
            this.GroupboxCanDataThisEpisode.Text = "Can data this episode";
            // 
            // LabelCanDataCollected
            // 
            this.LabelCanDataCollected.AutoSize = true;
            this.LabelCanDataCollected.Location = new System.Drawing.Point(99, 21);
            this.LabelCanDataCollected.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelCanDataCollected.Name = "LabelCanDataCollected";
            this.LabelCanDataCollected.Size = new System.Drawing.Size(66, 17);
            this.LabelCanDataCollected.TabIndex = 29;
            this.LabelCanDataCollected.Text = "Collected";
            // 
            // TextboxCanDataCollected
            // 
            this.TextboxCanDataCollected.Location = new System.Drawing.Point(99, 39);
            this.TextboxCanDataCollected.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxCanDataCollected.Name = "TextboxCanDataCollected";
            this.TextboxCanDataCollected.ReadOnly = true;
            this.TextboxCanDataCollected.Size = new System.Drawing.Size(79, 22);
            this.TextboxCanDataCollected.TabIndex = 28;
            // 
            // TextboxCanDataRemaining
            // 
            this.TextboxCanDataRemaining.Location = new System.Drawing.Point(11, 39);
            this.TextboxCanDataRemaining.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxCanDataRemaining.Name = "TextboxCanDataRemaining";
            this.TextboxCanDataRemaining.ReadOnly = true;
            this.TextboxCanDataRemaining.Size = new System.Drawing.Size(79, 22);
            this.TextboxCanDataRemaining.TabIndex = 23;
            // 
            // LabelCanDataRemaining
            // 
            this.LabelCanDataRemaining.AutoSize = true;
            this.LabelCanDataRemaining.Location = new System.Drawing.Point(14, 21);
            this.LabelCanDataRemaining.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelCanDataRemaining.Name = "LabelCanDataRemaining";
            this.LabelCanDataRemaining.Size = new System.Drawing.Size(75, 17);
            this.LabelCanDataRemaining.TabIndex = 22;
            this.LabelCanDataRemaining.Text = "Remaining";
            // 
            // GroupboxRewardData
            // 
            this.GroupboxRewardData.Controls.Add(this.LabelRewardDataTotal);
            this.GroupboxRewardData.Controls.Add(this.TextboxRewardsDataTotal);
            this.GroupboxRewardData.Controls.Add(this.TextboxRewardsDataThisEpisode);
            this.GroupboxRewardData.Controls.Add(this.LabelRewardDataThisEpisode);
            this.GroupboxRewardData.Location = new System.Drawing.Point(282, 66);
            this.GroupboxRewardData.Name = "GroupboxRewardData";
            this.GroupboxRewardData.Size = new System.Drawing.Size(184, 76);
            this.GroupboxRewardData.TabIndex = 60;
            this.GroupboxRewardData.TabStop = false;
            this.GroupboxRewardData.Text = "Reward data";
            // 
            // LabelRewardDataTotal
            // 
            this.LabelRewardDataTotal.AutoSize = true;
            this.LabelRewardDataTotal.Location = new System.Drawing.Point(100, 22);
            this.LabelRewardDataTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelRewardDataTotal.Name = "LabelRewardDataTotal";
            this.LabelRewardDataTotal.Size = new System.Drawing.Size(40, 17);
            this.LabelRewardDataTotal.TabIndex = 29;
            this.LabelRewardDataTotal.Text = "Total";
            // 
            // TextboxRewardDataTotal
            // 
            this.TextboxRewardsDataTotal.Location = new System.Drawing.Point(100, 40);
            this.TextboxRewardsDataTotal.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxRewardsDataTotal.Name = "TextboxRewardsDataTotal";
            this.TextboxRewardsDataTotal.ReadOnly = true;
            this.TextboxRewardsDataTotal.Size = new System.Drawing.Size(75, 22);
            this.TextboxRewardsDataTotal.TabIndex = 28;
            // 
            // TextboxRewardDataThisEpisode
            // 
            this.TextboxRewardsDataThisEpisode.Location = new System.Drawing.Point(14, 40);
            this.TextboxRewardsDataThisEpisode.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxRewardsDataThisEpisode.Name = "TextboxRewardsDataThisEpisode";
            this.TextboxRewardsDataThisEpisode.ReadOnly = true;
            this.TextboxRewardsDataThisEpisode.Size = new System.Drawing.Size(76, 22);
            this.TextboxRewardsDataThisEpisode.TabIndex = 23;
            // 
            // LabelRewardDataThisEpisode
            // 
            this.LabelRewardDataThisEpisode.AutoSize = true;
            this.LabelRewardDataThisEpisode.Location = new System.Drawing.Point(10, 23);
            this.LabelRewardDataThisEpisode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelRewardDataThisEpisode.Name = "LabelRewardDataThisEpisode";
            this.LabelRewardDataThisEpisode.Size = new System.Drawing.Size(89, 17);
            this.LabelRewardDataThisEpisode.TabIndex = 22;
            this.LabelRewardDataThisEpisode.Text = "This episode";
            // 
            // LabelSessionProgressGamma
            // 
            this.LabelSessionProgressGamma.AutoSize = true;
            this.LabelSessionProgressGamma.Location = new System.Drawing.Point(125, 16);
            this.LabelSessionProgressGamma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelSessionProgressGamma.Name = "LabelSessionProgressGamma";
            this.LabelSessionProgressGamma.Size = new System.Drawing.Size(15, 17);
            this.LabelSessionProgressGamma.TabIndex = 20;
            this.LabelSessionProgressGamma.Text = "γ";
            // 
            // LabelSessionProgressEpisodeNumber
            // 
            this.LabelSessionProgressEpisodeNumber.AutoSize = true;
            this.LabelSessionProgressEpisodeNumber.Location = new System.Drawing.Point(387, 18);
            this.LabelSessionProgressEpisodeNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelSessionProgressEpisodeNumber.Name = "LabelSessionProgressEpisodeNumber";
            this.LabelSessionProgressEpisodeNumber.Size = new System.Drawing.Size(71, 17);
            this.LabelSessionProgressEpisodeNumber.TabIndex = 12;
            this.LabelSessionProgressEpisodeNumber.Text = "Episode #";
            // 
            // TextboxSessionProgressEpisodeNumber
            // 
            this.TextboxSessionProgressEpisodeNumber.Location = new System.Drawing.Point(383, 37);
            this.TextboxSessionProgressEpisodeNumber.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxSessionProgressEpisodeNumber.Name = "TextboxSessionProgressEpisodeNumber";
            this.TextboxSessionProgressEpisodeNumber.ReadOnly = true;
            this.TextboxSessionProgressEpisodeNumber.Size = new System.Drawing.Size(75, 22);
            this.TextboxSessionProgressEpisodeNumber.TabIndex = 13;
            // 
            // textboxStepsprogress
            // 
            this.TextboxSessionProgressStepNumber.Location = new System.Drawing.Point(298, 37);
            this.TextboxSessionProgressStepNumber.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxSessionProgressStepNumber.Name = "TextboxSessionProgressStepNumber";
            this.TextboxSessionProgressStepNumber.ReadOnly = true;
            this.TextboxSessionProgressStepNumber.Size = new System.Drawing.Size(79, 22);
            this.TextboxSessionProgressStepNumber.TabIndex = 15;
            // 
            // GroupboxCurrentPercepts
            // 
            this.GroupboxCurrentPercepts.Controls.Add(this.TextboxCurrentPerceptsCurrentSquare);
            this.GroupboxCurrentPercepts.Controls.Add(this.LabelCurrentPreceptsCurrentSquare);
            this.GroupboxCurrentPercepts.Controls.Add(this.TextboxCurrentPerceptsUp);
            this.GroupboxCurrentPercepts.Controls.Add(this.LabelCurrentPerceptsUp);
            this.GroupboxCurrentPercepts.Controls.Add(this.TextboxCurrentPerceptsDown);
            this.GroupboxCurrentPercepts.Controls.Add(this.TextboxCurrentPerceptsRight);
            this.GroupboxCurrentPercepts.Controls.Add(this.LabelCurrentPerceptsRight);
            this.GroupboxCurrentPercepts.Controls.Add(this.LabelCurrentPerceptsDown);
            this.GroupboxCurrentPercepts.Controls.Add(this.LabelCurrentPereptsLeft);
            this.GroupboxCurrentPercepts.Controls.Add(this.TextboxCurrentPerceptsLeft);
            this.GroupboxCurrentPercepts.Location = new System.Drawing.Point(21, 143);
            this.GroupboxCurrentPercepts.Margin = new System.Windows.Forms.Padding(4);
            this.GroupboxCurrentPercepts.Name = "GroupboxCurrentPercepts";
            this.GroupboxCurrentPercepts.Padding = new System.Windows.Forms.Padding(4);
            this.GroupboxCurrentPercepts.Size = new System.Drawing.Size(445, 85);
            this.GroupboxCurrentPercepts.TabIndex = 6;
            this.GroupboxCurrentPercepts.TabStop = false;
            this.GroupboxCurrentPercepts.Text = "Current percepts";
            // 
            // TextboxCurrentPerceptsCurrentSquare
            // 
            this.TextboxCurrentPerceptsCurrentSquare.Location = new System.Drawing.Point(363, 43);
            this.TextboxCurrentPerceptsCurrentSquare.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxCurrentPerceptsCurrentSquare.Name = "TextboxCurrentPerceptsCurrentSquare";
            this.TextboxCurrentPerceptsCurrentSquare.ReadOnly = true;
            this.TextboxCurrentPerceptsCurrentSquare.Size = new System.Drawing.Size(75, 22);
            this.TextboxCurrentPerceptsCurrentSquare.TabIndex = 9;
            // 
            // LabelCurrentPreceptsCurrentSquare
            // 
            this.LabelCurrentPreceptsCurrentSquare.AutoSize = true;
            this.LabelCurrentPreceptsCurrentSquare.Location = new System.Drawing.Point(361, 24);
            this.LabelCurrentPreceptsCurrentSquare.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelCurrentPreceptsCurrentSquare.Name = "LabelCurrentPreceptsCurrentSquare";
            this.LabelCurrentPreceptsCurrentSquare.Size = new System.Drawing.Size(55, 17);
            this.LabelCurrentPreceptsCurrentSquare.TabIndex = 8;
            this.LabelCurrentPreceptsCurrentSquare.Text = "Current";
            // 
            // TextboxCurrentPerceptsUp
            // 
            this.TextboxCurrentPerceptsUp.Location = new System.Drawing.Point(275, 43);
            this.TextboxCurrentPerceptsUp.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxCurrentPerceptsUp.Name = "TextboxCurrentPerceptsUp";
            this.TextboxCurrentPerceptsUp.ReadOnly = true;
            this.TextboxCurrentPerceptsUp.Size = new System.Drawing.Size(80, 22);
            this.TextboxCurrentPerceptsUp.TabIndex = 7;
            // 
            // LabelCurrentPerceptsUp
            // 
            this.LabelCurrentPerceptsUp.AutoSize = true;
            this.LabelCurrentPerceptsUp.Location = new System.Drawing.Point(275, 24);
            this.LabelCurrentPerceptsUp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelCurrentPerceptsUp.Name = "LabelCurrentPerceptsUp";
            this.LabelCurrentPerceptsUp.Size = new System.Drawing.Size(26, 17);
            this.LabelCurrentPerceptsUp.TabIndex = 6;
            this.LabelCurrentPerceptsUp.Text = "Up";
            // 
            // TextboxCurrentPerceptsDown
            // 
            this.TextboxCurrentPerceptsDown.Location = new System.Drawing.Point(187, 43);
            this.TextboxCurrentPerceptsDown.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxCurrentPerceptsDown.Name = "TextboxCurrentPerceptsDown";
            this.TextboxCurrentPerceptsDown.ReadOnly = true;
            this.TextboxCurrentPerceptsDown.Size = new System.Drawing.Size(80, 22);
            this.TextboxCurrentPerceptsDown.TabIndex = 3;
            // 
            // TextboxCurrentPerceptsRight
            // 
            this.TextboxCurrentPerceptsRight.Location = new System.Drawing.Point(99, 43);
            this.TextboxCurrentPerceptsRight.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxCurrentPerceptsRight.Name = "TextboxCurrentPerceptsRight";
            this.TextboxCurrentPerceptsRight.ReadOnly = true;
            this.TextboxCurrentPerceptsRight.Size = new System.Drawing.Size(80, 22);
            this.TextboxCurrentPerceptsRight.TabIndex = 5;
            // 
            // LabelCurrentPerceptsRight
            // 
            this.LabelCurrentPerceptsRight.AutoSize = true;
            this.LabelCurrentPerceptsRight.Location = new System.Drawing.Point(96, 22);
            this.LabelCurrentPerceptsRight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelCurrentPerceptsRight.Name = "LabelCurrentPerceptsRight";
            this.LabelCurrentPerceptsRight.Size = new System.Drawing.Size(41, 17);
            this.LabelCurrentPerceptsRight.TabIndex = 4;
            this.LabelCurrentPerceptsRight.Text = "Right";
            // 
            // LabelCurrentPerceptsDown
            // 
            this.LabelCurrentPerceptsDown.AutoSize = true;
            this.LabelCurrentPerceptsDown.Location = new System.Drawing.Point(185, 24);
            this.LabelCurrentPerceptsDown.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelCurrentPerceptsDown.Name = "LabelCurrentPerceptsDown";
            this.LabelCurrentPerceptsDown.Size = new System.Drawing.Size(43, 17);
            this.LabelCurrentPerceptsDown.TabIndex = 2;
            this.LabelCurrentPerceptsDown.Text = "Down";
            // 
            // LabelCurrentPereptsLeft
            // 
            this.LabelCurrentPereptsLeft.AutoSize = true;
            this.LabelCurrentPereptsLeft.Location = new System.Drawing.Point(9, 23);
            this.LabelCurrentPereptsLeft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelCurrentPereptsLeft.Name = "LabelCurrentPereptsLeft";
            this.LabelCurrentPereptsLeft.Size = new System.Drawing.Size(32, 17);
            this.LabelCurrentPereptsLeft.TabIndex = 0;
            this.LabelCurrentPereptsLeft.Text = "Left";
            // 
            // TextboxCurrentPerceptsLeft
            // 
            this.TextboxCurrentPerceptsLeft.Location = new System.Drawing.Point(11, 43);
            this.TextboxCurrentPerceptsLeft.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxCurrentPerceptsLeft.Name = "TextboxCurrentPerceptsLeft";
            this.TextboxCurrentPerceptsLeft.ReadOnly = true;
            this.TextboxCurrentPerceptsLeft.Size = new System.Drawing.Size(80, 22);
            this.TextboxCurrentPerceptsLeft.TabIndex = 1;
            // 
            // LabelSessionProgressEpsilon
            // 
            this.LabelSessionProgressEpsilon.AutoSize = true;
            this.LabelSessionProgressEpsilon.Location = new System.Drawing.Point(36, 17);
            this.LabelSessionProgressEpsilon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelSessionProgressEpsilon.Name = "LabelSessionProgressEpsilon";
            this.LabelSessionProgressEpsilon.Size = new System.Drawing.Size(17, 17);
            this.LabelSessionProgressEpsilon.TabIndex = 20;
            this.LabelSessionProgressEpsilon.Text = "Ɛ";
            // 
            // LabelSessionProgressStepNumber
            // 
            this.LabelSessionProgressStepNumber.AutoSize = true;
            this.LabelSessionProgressStepNumber.Location = new System.Drawing.Point(296, 18);
            this.LabelSessionProgressStepNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelSessionProgressStepNumber.Name = "LabelSessionProgressStepNumber";
            this.LabelSessionProgressStepNumber.Size = new System.Drawing.Size(49, 17);
            this.LabelSessionProgressStepNumber.TabIndex = 14;
            this.LabelSessionProgressStepNumber.Text = "Step #";
            // 
            // TextboxSessionProgessEpsilon
            // 
            this.TextboxSessionProgessEpsilon.Location = new System.Drawing.Point(33, 37);
            this.TextboxSessionProgessEpsilon.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxSessionProgessEpsilon.Name = "TextboxSessionProgessEpsilon";
            this.TextboxSessionProgessEpsilon.ReadOnly = true;
            this.TextboxSessionProgessEpsilon.Size = new System.Drawing.Size(79, 22);
            this.TextboxSessionProgessEpsilon.TabIndex = 17;
            // 
            // TextboxSessionProgressGamma
            // 
            this.TextboxSessionProgressGamma.Location = new System.Drawing.Point(122, 37);
            this.TextboxSessionProgressGamma.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxSessionProgressGamma.Name = "TextboxSessionProgressGamma";
            this.TextboxSessionProgressGamma.ReadOnly = true;
            this.TextboxSessionProgressGamma.Size = new System.Drawing.Size(79, 22);
            this.TextboxSessionProgressGamma.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.PictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBox1.Location = new System.Drawing.Point(43, 12);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PictureBox1.Name = "pictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(1063, 55);
            this.PictureBox1.TabIndex = 0;
            this.PictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(38, 932);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox17
            // 
            this.pictureBox17.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox17.Image")));
            this.pictureBox17.Location = new System.Drawing.Point(914, 998);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(25, 30);
            this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox17.TabIndex = 42;
            this.pictureBox17.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(997, 993);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(29, 41);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 27;
            this.pictureBox5.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2040, 1055);
            this.Controls.Add(this.GroupboxCountDown);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox24);
            this.Controls.Add(this.pictureBox26);
            this.Controls.Add(this.pictureBox27);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox16);
            this.Controls.Add(this.pictureBox18);
            this.Controls.Add(this.pictureBox19);
            this.Controls.Add(this.pictureBox20);
            this.Controls.Add(this.pictureBox21);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.GroupboxStatusMessage);
            this.Controls.Add(this.GroupboxHistory);
            this.Controls.Add(this.GroupboxQmatrix);
            this.Controls.Add(this.GroupboxSessionProgress);
            this.Controls.Add(this.GroupboxAlgorithmProgress);
            this.Controls.Add(this.GroupboxConfiguration);
            this.Controls.Add(this.GroupboxInitialSettings);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox17);
            this.Controls.Add(this.pictureBox5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1KeyPressed);
            this.GroupboxInitialSettings.ResumeLayout(false);
            this.GroupboxInitialSettings.PerformLayout();
            this.GroupboxRewards.ResumeLayout(false);
            this.GroupboxRewards.PerformLayout();
            this.GroupboxQmatrix.ResumeLayout(false);
            this.GroupboxQmatrix.PerformLayout();
            this.GroupboxQmatrixSelect.ResumeLayout(false);
            this.GroupboxQmatrixSelect.PerformLayout();
            this.GroupboxQmatrixValues.ResumeLayout(false);
            this.GroupboxQmatrixValues.PerformLayout();
            this.GroupboxHistory.ResumeLayout(false);
            this.GroupboxAlgorithmProgress.ResumeLayout(false);
            this.GroupboxAlgorithmProgress.PerformLayout();
            this.GroupboxCountDown.ResumeLayout(false);
            this.GroupboxCountDown.PerformLayout();
            this.GroupboxConfiguration.ResumeLayout(false);
            this.GroupboxConfiguration.PerformLayout();
            this.GroupboxConfigurationRewards.ResumeLayout(false);
            this.GroupboxConfigurationRewards.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureboxFrySquinting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.GroupboxStatusMessage.ResumeLayout(false);
            this.GroupboxSessionProgress.ResumeLayout(false);
            this.GroupboxSessionProgress.PerformLayout();
            this.GroupboxCanDataThisEpisode.ResumeLayout(false);
            this.GroupboxCanDataThisEpisode.PerformLayout();
            this.GroupboxRewardData.ResumeLayout(false);
            this.GroupboxRewardData.PerformLayout();
            this.GroupboxCurrentPercepts.ResumeLayout(false);
            this.GroupboxCurrentPercepts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Label LabelCurrentPreceptsCurrentSquare;
        private Label LabelCurrentPerceptsUp;
        private Label LabelCurrentPerceptsRight;
        private Label LabelCurrentPerceptsDown;
        private Label LabelCurrentPereptsLeft;
        private Label LabelInitialGamma;
        private Label LabelInitialEpisodes;
        private Label LabelInitialEta;
        private Label LabelStepsPerEpisode;
        private Label LabelSessionProgressEpisodeNumber;
        private Label LabelSessionProgressStepNumber;
        private Label LabelEpsilon;
        private Label LabelSessionProgressGamma;
        private Label LabelSessionProgressEpsilon;
        private Label LabelQmatrixValuesGrab;
        private Label LabelQmatrixValuesUp;
        private Label LabelQmatrixValuesRight;
        private Label LabelQmatrixValuesDown;
        private Label LabelQmatrixValuesLeft;
        private Label LabelBeer;
        private Label LabelEmptyGrab;
        private Label LabelHitsAWall;
        private Label LabelCanDataRemaining;
        private Label LabelCanDataCollected;
        private Label LabelRewardDataTotal;
        private Label LabelRewardDataThisEpisode;
        private Label LabelQmatrixComboboxLeft;
        private Label LabelQmatrixComboboxUp;
        private Label LabelQmatrixComboboxDown;
        private Label LabelQmatrixComboboxRight;
        private Label LabelQmatrixComboboxGrab;
        private Label LabelSuccessfulMove;
        private Label LabelRewardsRanIntoWall;
        private Label LabelConfigurationNumberOfEpisodes;
        private Label LabelConfigurationComboboxEpsilon;
        private Label LabelConfigurationComboboxGamma;
        private Label LabelConfigurationComboboxEta;
        private Label LabelConfigurationComboboxNumberOfStepsPerEpisode;
        private Label LabelRewardsGrabbedEmptySquare;
        private Label LabelRewardsCollectedBeer;
        private Label LabelMsDelayPerStep;
        private Label LabelNumberOfEpisodes;
        private Label LabelNumberOfSteps;
        private Label LabelQmatrixStoredEntries;
        private Label LabelRewardsMovedWithoutHittingWall;
        private Label LabelInProgressSteps;
        private Label LabelInProgressTime;

        private PictureBox PictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox16;
        private PictureBox pictureBox17;
        private PictureBox pictureBox18;
        private PictureBox pictureBox19;
        private PictureBox pictureBox20;
        private PictureBox pictureBox21;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private PictureBox pictureBox24;
        private PictureBox pictureBox26;
        private PictureBox pictureBox27;
        private PictureBox pictureBox12;
        private PictureBox pictureBox13;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox PictureboxFrySquinting;

        private TextBox TextboxQmatrixStoredEntries;
        private TextBox TextboxInProgressTime;
        private TextBox TextboxInProgressSteps;
        private TextBox TextboxCurrentPerceptsCurrentSquare;
        private TextBox TextboxCurrentPerceptsUp;
        private TextBox TextboxCurrentPerceptsRight;
        private TextBox TextboxCurrentPerceptsDown;
        private TextBox TextboxCurrentPerceptsLeft;
        private TextBox TextboxInitialSettingsGamma;
        private TextBox TextboxInitialSettingsEpsilon;
        private TextBox TextboxInitialSettingsEta;
        private TextBox TextboxInitialSettingsNumberOfEpisodes;
        private TextBox TextboxInitialSettingsNumberOfSteps;
        private TextBox TextboxInitialSettingsRewardsBeer;
        private TextBox TextboxInitialSettingsRewardsEmptyGrab;
        private TextBox TextboxInitialSettingsRewardsWall;
        private TextBox TextboxInitialSettingsRewardsSuccessMove;
        private TextBox TextboxSessionProgressGamma;
        private TextBox TextboxSessionProgessEpsilon;
        private TextBox TextboxSessionProgressEpisodeNumber;
        private TextBox TextboxSessionProgressStepNumber;
        private TextBox TextboxQmatrixValuesCurrent;
        private TextBox TextboxQmatrixValuesUp;
        private TextBox TextboxQmatrixValuesDown;
        private TextBox TextboxQmatrixValuesRight;
        private TextBox TextboxQmatrixValuesLeft;
        private TextBox TextboxCanDataRemaining;
        private TextBox TextboxCanDataCollected;
        private TextBox TextboxRewardsDataTotal;
        private TextBox TextboxRewardsDataThisEpisode;

        private GroupBox GroupboxCurrentPercepts;
        private GroupBox GroupboxConfiguration;
        private GroupBox GroupboxInitialSettings;
        private GroupBox GroupboxAlgorithmProgress;
        private GroupBox GroupboxSessionProgress;
        private GroupBox GroupboxQmatrix;
        private GroupBox GroupboxHistory;
        private GroupBox GroupboxStatusMessage;
        private GroupBox GroupboxCanDataThisEpisode;
        private GroupBox GroupboxRewardData;
        private GroupBox GroupboxQmatrixValues;
        private GroupBox GroupboxQmatrixSelect;
        private GroupBox GroupboxRewards;
        private GroupBox GroupboxCountDown;
        private GroupBox GroupboxConfigurationRewards;

        private ComboBox ComboboxConfigurationNumberOfEpisodes;
        private ComboBox ComboboxConfigurationNumberOfStepsPerEpisode;
        private ComboBox ComboboxConfigurationEta;
        private ComboBox ComboboxConfigurationGamma;
        private ComboBox ComboboxAdvanceSteps;
        private ComboBox ComboboxAdvanceEpisodes;
        private ComboBox ComboboxQmatrixSelect;
        private ComboBox ComboboxRewardsCollectedBeer;
        private ComboBox ComboboxRewardsGrabbedEmptySquare;
        private ComboBox ComboboxRewardsRanIntoWall;
        private ComboBox ComboboxConfigurationEpsilon;
        private ComboBox ComboboxHistoryEpisode;
        private ComboBox ComboboxHistoryStep;
        private ComboBox ComboboxQmatrixGrab;
        private ComboBox ComboboxQmatrixUp;
        private ComboBox ComboboxQmatrixDown;
        private ComboBox ComboboxQmatrixRight;
        private ComboBox ComboboxQmatrixLeft;
        private ComboBox ComboboxRewardsMovedWithoutHittingWall;
        private ComboBox ComboboxDelayMS;

        private RichTextBox RichTextboxStatusMessage;

        private Button ButtonStopAlgorithm;
        private Button ButtonConfigurationStartAlgorithm;
        private Button ButtonConfigurationReset;
        private Button ButtonAdvanceStepsDropDown;
        private Button ButtonStop;

        private CheckBox CheckboxLoopUntilChasing;
    }
}

