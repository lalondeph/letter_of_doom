namespace COMP60_A2_Lalonde
{
    partial class LetterOfDoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LetterOfDoom));
            this.p1TxtBox = new System.Windows.Forms.TextBox();
            this.GuessLetterTxtBox = new System.Windows.Forms.TextBox();
            this.ScoreTxtBox = new System.Windows.Forms.TextBox();
            this.TargetWordTxtbox = new System.Windows.Forms.TextBox();
            this.startGame = new System.Windows.Forms.Button();
            this.PrizeImage = new System.Windows.Forms.PictureBox();
            this.pictureBoxLabel = new System.Windows.Forms.Label();
            this.p1Name = new System.Windows.Forms.Label();
            this.guessBox = new System.Windows.Forms.Label();
            this.p1CurrentScore = new System.Windows.Forms.Label();
            this.targetWord = new System.Windows.Forms.Label();
            this.newWord = new System.Windows.Forms.Button();
            this.GameTitle = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.labelE = new System.Windows.Forms.Label();
            this.labelI = new System.Windows.Forms.Label();
            this.labelM = new System.Windows.Forms.Label();
            this.labelQ = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelF = new System.Windows.Forms.Label();
            this.labelJ = new System.Windows.Forms.Label();
            this.labelN = new System.Windows.Forms.Label();
            this.labelR = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.labelD = new System.Windows.Forms.Label();
            this.labelG = new System.Windows.Forms.Label();
            this.labelH = new System.Windows.Forms.Label();
            this.labelK = new System.Windows.Forms.Label();
            this.labelL = new System.Windows.Forms.Label();
            this.labelO = new System.Windows.Forms.Label();
            this.labelP = new System.Windows.Forms.Label();
            this.labelS = new System.Windows.Forms.Label();
            this.labelT = new System.Windows.Forms.Label();
            this.labelZ = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.labelW = new System.Windows.Forms.Label();
            this.labelV = new System.Windows.Forms.Label();
            this.labelU = new System.Windows.Forms.Label();
            this.guessTrackLabel = new System.Windows.Forms.Label();
            this.guessHelper = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PrizeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // p1TxtBox
            // 
            this.p1TxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1TxtBox.Location = new System.Drawing.Point(111, 71);
            this.p1TxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.p1TxtBox.Name = "p1TxtBox";
            this.p1TxtBox.Size = new System.Drawing.Size(117, 23);
            this.p1TxtBox.TabIndex = 0;
            // 
            // GuessLetterTxtBox
            // 
            this.GuessLetterTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuessLetterTxtBox.Location = new System.Drawing.Point(111, 131);
            this.GuessLetterTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.GuessLetterTxtBox.MaxLength = 1;
            this.GuessLetterTxtBox.Name = "GuessLetterTxtBox";
            this.GuessLetterTxtBox.Size = new System.Drawing.Size(44, 38);
            this.GuessLetterTxtBox.TabIndex = 3;
            this.GuessLetterTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GuessLetterTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GuessDown);
            this.GuessLetterTxtBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GuessUp);
            // 
            // ScoreTxtBox
            // 
            this.ScoreTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreTxtBox.Location = new System.Drawing.Point(111, 92);
            this.ScoreTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.ScoreTxtBox.Name = "ScoreTxtBox";
            this.ScoreTxtBox.ReadOnly = true;
            this.ScoreTxtBox.Size = new System.Drawing.Size(117, 23);
            this.ScoreTxtBox.TabIndex = 10;
            // 
            // TargetWordTxtbox
            // 
            this.TargetWordTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TargetWordTxtbox.Location = new System.Drawing.Point(7, 221);
            this.TargetWordTxtbox.Margin = new System.Windows.Forms.Padding(2);
            this.TargetWordTxtbox.Name = "TargetWordTxtbox";
            this.TargetWordTxtbox.ReadOnly = true;
            this.TargetWordTxtbox.Size = new System.Drawing.Size(305, 38);
            this.TargetWordTxtbox.TabIndex = 4;
            this.TargetWordTxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // startGame
            // 
            this.startGame.BackColor = System.Drawing.Color.Maroon;
            this.startGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGame.ForeColor = System.Drawing.Color.Gold;
            this.startGame.Location = new System.Drawing.Point(253, 71);
            this.startGame.Margin = new System.Windows.Forms.Padding(2);
            this.startGame.Name = "startGame";
            this.startGame.Size = new System.Drawing.Size(117, 44);
            this.startGame.TabIndex = 1;
            this.startGame.Text = "Start Game";
            this.startGame.UseVisualStyleBackColor = false;
            this.startGame.Click += new System.EventHandler(this.StartGame_Click);
            this.startGame.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StartScoreSpin);
            // 
            // PrizeImage
            // 
            this.PrizeImage.Image = global::COMP60_A2_Lalonde.Properties.Resources._8;
            this.PrizeImage.Location = new System.Drawing.Point(11, 308);
            this.PrizeImage.Margin = new System.Windows.Forms.Padding(2);
            this.PrizeImage.Name = "PrizeImage";
            this.PrizeImage.Size = new System.Drawing.Size(200, 200);
            this.PrizeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PrizeImage.TabIndex = 2;
            this.PrizeImage.TabStop = false;
            // 
            // pictureBoxLabel
            // 
            this.pictureBoxLabel.AutoSize = true;
            this.pictureBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pictureBoxLabel.Location = new System.Drawing.Point(11, 289);
            this.pictureBoxLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pictureBoxLabel.Name = "pictureBoxLabel";
            this.pictureBoxLabel.Size = new System.Drawing.Size(95, 17);
            this.pictureBoxLabel.TabIndex = 3;
            this.pictureBoxLabel.Text = "Current Prize:";
            // 
            // p1Name
            // 
            this.p1Name.AutoSize = true;
            this.p1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1Name.Location = new System.Drawing.Point(4, 74);
            this.p1Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.p1Name.Name = "p1Name";
            this.p1Name.Size = new System.Drawing.Size(105, 17);
            this.p1Name.TabIndex = 4;
            this.p1Name.Text = "Player 1 Name:";
            // 
            // guessBox
            // 
            this.guessBox.AutoSize = true;
            this.guessBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessBox.Location = new System.Drawing.Point(4, 131);
            this.guessBox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.guessBox.Name = "guessBox";
            this.guessBox.Size = new System.Drawing.Size(107, 17);
            this.guessBox.TabIndex = 4;
            this.guessBox.Text = "Guess A Letter:";
            // 
            // p1CurrentScore
            // 
            this.p1CurrentScore.AutoSize = true;
            this.p1CurrentScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1CurrentScore.Location = new System.Drawing.Point(4, 97);
            this.p1CurrentScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.p1CurrentScore.Name = "p1CurrentScore";
            this.p1CurrentScore.Size = new System.Drawing.Size(100, 17);
            this.p1CurrentScore.TabIndex = 4;
            this.p1CurrentScore.Text = "Current Score:";
            // 
            // targetWord
            // 
            this.targetWord.AutoSize = true;
            this.targetWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.targetWord.Location = new System.Drawing.Point(5, 202);
            this.targetWord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.targetWord.Name = "targetWord";
            this.targetWord.Size = new System.Drawing.Size(92, 17);
            this.targetWord.TabIndex = 4;
            this.targetWord.Text = "Target Word:";
            // 
            // newWord
            // 
            this.newWord.BackColor = System.Drawing.Color.Maroon;
            this.newWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newWord.ForeColor = System.Drawing.Color.Gold;
            this.newWord.Location = new System.Drawing.Point(316, 217);
            this.newWord.Margin = new System.Windows.Forms.Padding(2);
            this.newWord.Name = "newWord";
            this.newWord.Size = new System.Drawing.Size(54, 44);
            this.newWord.TabIndex = 4;
            this.newWord.Text = "New Word";
            this.newWord.UseVisualStyleBackColor = false;
            this.newWord.Click += new System.EventHandler(this.NewWord_Click);
            // 
            // GameTitle
            // 
            this.GameTitle.AutoSize = true;
            this.GameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameTitle.ForeColor = System.Drawing.Color.Maroon;
            this.GameTitle.Location = new System.Drawing.Point(65, 13);
            this.GameTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GameTitle.Name = "GameTitle";
            this.GameTitle.Size = new System.Drawing.Size(249, 39);
            this.GameTitle.TabIndex = 4;
            this.GameTitle.Text = "Letter of Doom!";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelA.ForeColor = System.Drawing.Color.Black;
            this.labelA.Location = new System.Drawing.Point(245, 308);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(20, 20);
            this.labelA.TabIndex = 5;
            this.labelA.Text = "A";
            // 
            // labelE
            // 
            this.labelE.AutoSize = true;
            this.labelE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelE.ForeColor = System.Drawing.Color.Black;
            this.labelE.Location = new System.Drawing.Point(245, 337);
            this.labelE.Name = "labelE";
            this.labelE.Size = new System.Drawing.Size(20, 20);
            this.labelE.TabIndex = 5;
            this.labelE.Text = "E";
            // 
            // labelI
            // 
            this.labelI.AutoSize = true;
            this.labelI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelI.ForeColor = System.Drawing.Color.Black;
            this.labelI.Location = new System.Drawing.Point(245, 367);
            this.labelI.Name = "labelI";
            this.labelI.Size = new System.Drawing.Size(14, 20);
            this.labelI.TabIndex = 5;
            this.labelI.Text = "I";
            // 
            // labelM
            // 
            this.labelM.AutoSize = true;
            this.labelM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelM.ForeColor = System.Drawing.Color.Black;
            this.labelM.Location = new System.Drawing.Point(245, 396);
            this.labelM.Name = "labelM";
            this.labelM.Size = new System.Drawing.Size(22, 20);
            this.labelM.TabIndex = 5;
            this.labelM.Text = "M";
            // 
            // labelQ
            // 
            this.labelQ.AutoSize = true;
            this.labelQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQ.ForeColor = System.Drawing.Color.Black;
            this.labelQ.Location = new System.Drawing.Point(245, 428);
            this.labelQ.Name = "labelQ";
            this.labelQ.Size = new System.Drawing.Size(21, 20);
            this.labelQ.TabIndex = 5;
            this.labelQ.Text = "Q";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelB.ForeColor = System.Drawing.Color.Black;
            this.labelB.Location = new System.Drawing.Point(274, 308);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(20, 20);
            this.labelB.TabIndex = 5;
            this.labelB.Text = "B";
            // 
            // labelF
            // 
            this.labelF.AutoSize = true;
            this.labelF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelF.ForeColor = System.Drawing.Color.Black;
            this.labelF.Location = new System.Drawing.Point(274, 337);
            this.labelF.Name = "labelF";
            this.labelF.Size = new System.Drawing.Size(19, 20);
            this.labelF.TabIndex = 5;
            this.labelF.Text = "F";
            // 
            // labelJ
            // 
            this.labelJ.AutoSize = true;
            this.labelJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJ.ForeColor = System.Drawing.Color.Black;
            this.labelJ.Location = new System.Drawing.Point(274, 367);
            this.labelJ.Name = "labelJ";
            this.labelJ.Size = new System.Drawing.Size(17, 20);
            this.labelJ.TabIndex = 5;
            this.labelJ.Text = "J";
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelN.ForeColor = System.Drawing.Color.Black;
            this.labelN.Location = new System.Drawing.Point(274, 396);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(20, 20);
            this.labelN.TabIndex = 5;
            this.labelN.Text = "N";
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelR.ForeColor = System.Drawing.Color.Black;
            this.labelR.Location = new System.Drawing.Point(274, 428);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(21, 20);
            this.labelR.TabIndex = 5;
            this.labelR.Text = "R";
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelC.ForeColor = System.Drawing.Color.Black;
            this.labelC.Location = new System.Drawing.Point(303, 308);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(20, 20);
            this.labelC.TabIndex = 5;
            this.labelC.Text = "C";
            // 
            // labelD
            // 
            this.labelD.AutoSize = true;
            this.labelD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelD.ForeColor = System.Drawing.Color.Black;
            this.labelD.Location = new System.Drawing.Point(331, 308);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(21, 20);
            this.labelD.TabIndex = 5;
            this.labelD.Text = "D";
            // 
            // labelG
            // 
            this.labelG.AutoSize = true;
            this.labelG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelG.ForeColor = System.Drawing.Color.Black;
            this.labelG.Location = new System.Drawing.Point(303, 337);
            this.labelG.Name = "labelG";
            this.labelG.Size = new System.Drawing.Size(22, 20);
            this.labelG.TabIndex = 5;
            this.labelG.Text = "G";
            // 
            // labelH
            // 
            this.labelH.AutoSize = true;
            this.labelH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelH.ForeColor = System.Drawing.Color.Black;
            this.labelH.Location = new System.Drawing.Point(331, 337);
            this.labelH.Name = "labelH";
            this.labelH.Size = new System.Drawing.Size(21, 20);
            this.labelH.TabIndex = 5;
            this.labelH.Text = "H";
            // 
            // labelK
            // 
            this.labelK.AutoSize = true;
            this.labelK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelK.ForeColor = System.Drawing.Color.Black;
            this.labelK.Location = new System.Drawing.Point(303, 367);
            this.labelK.Name = "labelK";
            this.labelK.Size = new System.Drawing.Size(19, 20);
            this.labelK.TabIndex = 5;
            this.labelK.Text = "K";
            // 
            // labelL
            // 
            this.labelL.AutoSize = true;
            this.labelL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelL.ForeColor = System.Drawing.Color.Black;
            this.labelL.Location = new System.Drawing.Point(331, 367);
            this.labelL.Name = "labelL";
            this.labelL.Size = new System.Drawing.Size(18, 20);
            this.labelL.TabIndex = 5;
            this.labelL.Text = "L";
            // 
            // labelO
            // 
            this.labelO.AutoSize = true;
            this.labelO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelO.ForeColor = System.Drawing.Color.Black;
            this.labelO.Location = new System.Drawing.Point(303, 396);
            this.labelO.Name = "labelO";
            this.labelO.Size = new System.Drawing.Size(21, 20);
            this.labelO.TabIndex = 5;
            this.labelO.Text = "O";
            // 
            // labelP
            // 
            this.labelP.AutoSize = true;
            this.labelP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP.ForeColor = System.Drawing.Color.Black;
            this.labelP.Location = new System.Drawing.Point(331, 396);
            this.labelP.Name = "labelP";
            this.labelP.Size = new System.Drawing.Size(19, 20);
            this.labelP.TabIndex = 5;
            this.labelP.Text = "P";
            // 
            // labelS
            // 
            this.labelS.AutoSize = true;
            this.labelS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelS.ForeColor = System.Drawing.Color.Black;
            this.labelS.Location = new System.Drawing.Point(303, 428);
            this.labelS.Name = "labelS";
            this.labelS.Size = new System.Drawing.Size(20, 20);
            this.labelS.TabIndex = 5;
            this.labelS.Text = "S";
            // 
            // labelT
            // 
            this.labelT.AutoSize = true;
            this.labelT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelT.ForeColor = System.Drawing.Color.Black;
            this.labelT.Location = new System.Drawing.Point(331, 428);
            this.labelT.Name = "labelT";
            this.labelT.Size = new System.Drawing.Size(18, 20);
            this.labelT.TabIndex = 5;
            this.labelT.Text = "T";
            // 
            // labelZ
            // 
            this.labelZ.AutoSize = true;
            this.labelZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZ.ForeColor = System.Drawing.Color.Black;
            this.labelZ.Location = new System.Drawing.Point(274, 488);
            this.labelZ.Name = "labelZ";
            this.labelZ.Size = new System.Drawing.Size(19, 20);
            this.labelZ.TabIndex = 5;
            this.labelZ.Text = "Z";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelY.ForeColor = System.Drawing.Color.Black;
            this.labelY.Location = new System.Drawing.Point(245, 488);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(20, 20);
            this.labelY.TabIndex = 5;
            this.labelY.Text = "Y";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX.ForeColor = System.Drawing.Color.Black;
            this.labelX.Location = new System.Drawing.Point(331, 457);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(20, 20);
            this.labelX.TabIndex = 5;
            this.labelX.Text = "X";
            // 
            // labelW
            // 
            this.labelW.AutoSize = true;
            this.labelW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelW.ForeColor = System.Drawing.Color.Black;
            this.labelW.Location = new System.Drawing.Point(303, 457);
            this.labelW.Name = "labelW";
            this.labelW.Size = new System.Drawing.Size(24, 20);
            this.labelW.TabIndex = 5;
            this.labelW.Text = "W";
            // 
            // labelV
            // 
            this.labelV.AutoSize = true;
            this.labelV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelV.ForeColor = System.Drawing.Color.Black;
            this.labelV.Location = new System.Drawing.Point(274, 457);
            this.labelV.Name = "labelV";
            this.labelV.Size = new System.Drawing.Size(20, 20);
            this.labelV.TabIndex = 5;
            this.labelV.Text = "V";
            // 
            // labelU
            // 
            this.labelU.AutoSize = true;
            this.labelU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelU.ForeColor = System.Drawing.Color.Black;
            this.labelU.Location = new System.Drawing.Point(245, 457);
            this.labelU.Name = "labelU";
            this.labelU.Size = new System.Drawing.Size(21, 20);
            this.labelU.TabIndex = 5;
            this.labelU.Text = "U";
            // 
            // guessTrackLabel
            // 
            this.guessTrackLabel.AutoSize = true;
            this.guessTrackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessTrackLabel.Location = new System.Drawing.Point(246, 289);
            this.guessTrackLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.guessTrackLabel.Name = "guessTrackLabel";
            this.guessTrackLabel.Size = new System.Drawing.Size(106, 17);
            this.guessTrackLabel.TabIndex = 3;
            this.guessTrackLabel.Text = "Guess Tracker:";
            // 
            // guessHelper
            // 
            this.guessHelper.AutoSize = true;
            this.guessHelper.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessHelper.ForeColor = System.Drawing.Color.Maroon;
            this.guessHelper.Location = new System.Drawing.Point(186, 142);
            this.guessHelper.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.guessHelper.Name = "guessHelper";
            this.guessHelper.Size = new System.Drawing.Size(0, 17);
            this.guessHelper.TabIndex = 4;
            // 
            // LetterOfDoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(379, 522);
            this.Controls.Add(this.labelU);
            this.Controls.Add(this.labelV);
            this.Controls.Add(this.labelT);
            this.Controls.Add(this.labelS);
            this.Controls.Add(this.labelW);
            this.Controls.Add(this.labelR);
            this.Controls.Add(this.labelP);
            this.Controls.Add(this.labelQ);
            this.Controls.Add(this.labelO);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.labelL);
            this.Controls.Add(this.labelM);
            this.Controls.Add(this.labelK);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelJ);
            this.Controls.Add(this.labelH);
            this.Controls.Add(this.labelI);
            this.Controls.Add(this.labelG);
            this.Controls.Add(this.labelZ);
            this.Controls.Add(this.labelF);
            this.Controls.Add(this.labelD);
            this.Controls.Add(this.labelE);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.targetWord);
            this.Controls.Add(this.p1CurrentScore);
            this.Controls.Add(this.guessHelper);
            this.Controls.Add(this.guessBox);
            this.Controls.Add(this.GameTitle);
            this.Controls.Add(this.p1Name);
            this.Controls.Add(this.guessTrackLabel);
            this.Controls.Add(this.pictureBoxLabel);
            this.Controls.Add(this.PrizeImage);
            this.Controls.Add(this.newWord);
            this.Controls.Add(this.startGame);
            this.Controls.Add(this.TargetWordTxtbox);
            this.Controls.Add(this.ScoreTxtBox);
            this.Controls.Add(this.GuessLetterTxtBox);
            this.Controls.Add(this.p1TxtBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LetterOfDoom";
            this.Text = "Letter Of Doom";
            ((System.ComponentModel.ISupportInitialize)(this.PrizeImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox p1TxtBox;
        private System.Windows.Forms.TextBox GuessLetterTxtBox;
        private System.Windows.Forms.TextBox ScoreTxtBox;
        private System.Windows.Forms.TextBox TargetWordTxtbox;
        private System.Windows.Forms.Button startGame;
        private System.Windows.Forms.PictureBox PrizeImage;
        private System.Windows.Forms.Label pictureBoxLabel;
        private System.Windows.Forms.Label p1Name;
        private System.Windows.Forms.Label guessBox;
        private System.Windows.Forms.Label p1CurrentScore;
        private System.Windows.Forms.Label targetWord;
        private System.Windows.Forms.Button newWord;
        private System.Windows.Forms.Label GameTitle;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelE;
        private System.Windows.Forms.Label labelI;
        private System.Windows.Forms.Label labelM;
        private System.Windows.Forms.Label labelQ;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelF;
        private System.Windows.Forms.Label labelJ;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.Label labelG;
        private System.Windows.Forms.Label labelH;
        private System.Windows.Forms.Label labelK;
        private System.Windows.Forms.Label labelL;
        private System.Windows.Forms.Label labelO;
        private System.Windows.Forms.Label labelP;
        private System.Windows.Forms.Label labelS;
        private System.Windows.Forms.Label labelT;
        private System.Windows.Forms.Label labelZ;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelW;
        private System.Windows.Forms.Label labelV;
        private System.Windows.Forms.Label labelU;
        private System.Windows.Forms.Label guessTrackLabel;
        private System.Windows.Forms.Label guessHelper;
    }
}

