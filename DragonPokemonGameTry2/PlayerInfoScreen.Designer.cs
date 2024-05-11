namespace DragonPokemonGameTry2
{
    partial class PlayerInfoScreen
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
            GBP1details = new GroupBox();
            TXTPlayer1DragonName = new TextBox();
            TXTPlayer1Name = new TextBox();
            label2 = new Label();
            label1 = new Label();
            GBP1dragontype = new GroupBox();
            checkBoxP1Water = new CheckBox();
            checkBoxP1Earth = new CheckBox();
            checkBoxP1Wind = new CheckBox();
            checkboxP1fire = new CheckBox();
            BTNP1Details = new Button();
            GBP2details = new GroupBox();
            TXTPlayer2DragonName = new TextBox();
            GBP2dragontype = new GroupBox();
            checkBoxP2Water = new CheckBox();
            BTNP2Details = new Button();
            checkBoxP2Earth = new CheckBox();
            checkBoxP2Wind = new CheckBox();
            checkBoxP2Fire = new CheckBox();
            TXTPlayer2Name = new TextBox();
            label4 = new Label();
            label3 = new Label();
            BTNStartGame = new Button();
            BTNBack = new Button();
            GBP1details.SuspendLayout();
            GBP1dragontype.SuspendLayout();
            GBP2details.SuspendLayout();
            GBP2dragontype.SuspendLayout();
            SuspendLayout();
            // 
            // GBP1details
            // 
            GBP1details.Controls.Add(TXTPlayer1DragonName);
            GBP1details.Controls.Add(TXTPlayer1Name);
            GBP1details.Controls.Add(label2);
            GBP1details.Controls.Add(label1);
            GBP1details.Controls.Add(GBP1dragontype);
            GBP1details.Location = new Point(63, 103);
            GBP1details.Margin = new Padding(4, 5, 4, 5);
            GBP1details.Name = "GBP1details";
            GBP1details.Padding = new Padding(4, 5, 4, 5);
            GBP1details.Size = new Size(430, 730);
            GBP1details.TabIndex = 0;
            GBP1details.TabStop = false;
            GBP1details.Text = "Player 1 details";
            GBP1details.Enter += GBP1details_Enter;
            // 
            // TXTPlayer1DragonName
            // 
            TXTPlayer1DragonName.Location = new Point(159, 133);
            TXTPlayer1DragonName.Margin = new Padding(4, 5, 4, 5);
            TXTPlayer1DragonName.Name = "TXTPlayer1DragonName";
            TXTPlayer1DragonName.Size = new Size(197, 31);
            TXTPlayer1DragonName.TabIndex = 4;
            // 
            // TXTPlayer1Name
            // 
            TXTPlayer1Name.Location = new Point(159, 47);
            TXTPlayer1Name.Margin = new Padding(4, 5, 4, 5);
            TXTPlayer1Name.Name = "TXTPlayer1Name";
            TXTPlayer1Name.Size = new Size(197, 31);
            TXTPlayer1Name.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 138);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(128, 25);
            label2.TabIndex = 2;
            label2.Text = "Dragon Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 52);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(115, 25);
            label1.TabIndex = 1;
            label1.Text = "Player Name:";
            // 
            // GBP1dragontype
            // 
            GBP1dragontype.Controls.Add(checkBoxP1Water);
            GBP1dragontype.Controls.Add(checkBoxP1Earth);
            GBP1dragontype.Controls.Add(checkBoxP1Wind);
            GBP1dragontype.Controls.Add(checkboxP1fire);
            GBP1dragontype.Controls.Add(BTNP1Details);
            GBP1dragontype.Location = new Point(9, 190);
            GBP1dragontype.Margin = new Padding(4, 5, 4, 5);
            GBP1dragontype.Name = "GBP1dragontype";
            GBP1dragontype.Padding = new Padding(4, 5, 4, 5);
            GBP1dragontype.Size = new Size(400, 530);
            GBP1dragontype.TabIndex = 0;
            GBP1dragontype.TabStop = false;
            GBP1dragontype.Text = "Player 1 dragon type";
            // 
            // checkBoxP1Water
            // 
            checkBoxP1Water.AutoSize = true;
            checkBoxP1Water.Location = new Point(29, 347);
            checkBoxP1Water.Margin = new Padding(4, 5, 4, 5);
            checkBoxP1Water.Name = "checkBoxP1Water";
            checkBoxP1Water.Size = new Size(147, 29);
            checkBoxP1Water.TabIndex = 4;
            checkBoxP1Water.Text = "Water dragon";
            checkBoxP1Water.UseVisualStyleBackColor = true;
            // 
            // checkBoxP1Earth
            // 
            checkBoxP1Earth.AutoSize = true;
            checkBoxP1Earth.Location = new Point(29, 265);
            checkBoxP1Earth.Margin = new Padding(4, 5, 4, 5);
            checkBoxP1Earth.Name = "checkBoxP1Earth";
            checkBoxP1Earth.Size = new Size(141, 29);
            checkBoxP1Earth.TabIndex = 3;
            checkBoxP1Earth.Text = "Earth dragon";
            checkBoxP1Earth.UseVisualStyleBackColor = true;
            // 
            // checkBoxP1Wind
            // 
            checkBoxP1Wind.AutoSize = true;
            checkBoxP1Wind.Location = new Point(29, 183);
            checkBoxP1Wind.Margin = new Padding(4, 5, 4, 5);
            checkBoxP1Wind.Name = "checkBoxP1Wind";
            checkBoxP1Wind.Size = new Size(143, 29);
            checkBoxP1Wind.TabIndex = 2;
            checkBoxP1Wind.Text = "Wind dragon";
            checkBoxP1Wind.UseVisualStyleBackColor = true;
            // 
            // checkboxP1fire
            // 
            checkboxP1fire.AutoSize = true;
            checkboxP1fire.Location = new Point(29, 100);
            checkboxP1fire.Margin = new Padding(4, 5, 4, 5);
            checkboxP1fire.Name = "checkboxP1fire";
            checkboxP1fire.Size = new Size(129, 29);
            checkboxP1fire.TabIndex = 1;
            checkboxP1fire.Text = "Fire dragon";
            checkboxP1fire.UseVisualStyleBackColor = true;
            checkboxP1fire.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // BTNP1Details
            // 
            BTNP1Details.Location = new Point(63, 465);
            BTNP1Details.Margin = new Padding(4, 5, 4, 5);
            BTNP1Details.Name = "BTNP1Details";
            BTNP1Details.Size = new Size(233, 38);
            BTNP1Details.TabIndex = 0;
            BTNP1Details.Text = "Save Player 1 details";
            BTNP1Details.UseVisualStyleBackColor = true;
            BTNP1Details.Click += BTNP1Details_Click;
            // 
            // GBP2details
            // 
            GBP2details.Controls.Add(TXTPlayer2DragonName);
            GBP2details.Controls.Add(GBP2dragontype);
            GBP2details.Controls.Add(TXTPlayer2Name);
            GBP2details.Controls.Add(label4);
            GBP2details.Controls.Add(label3);
            GBP2details.Location = new Point(526, 103);
            GBP2details.Margin = new Padding(4, 5, 4, 5);
            GBP2details.Name = "GBP2details";
            GBP2details.Padding = new Padding(4, 5, 4, 5);
            GBP2details.Size = new Size(430, 730);
            GBP2details.TabIndex = 1;
            GBP2details.TabStop = false;
            GBP2details.Text = "Player 2 details";
            // 
            // TXTPlayer2DragonName
            // 
            TXTPlayer2DragonName.Location = new Point(169, 133);
            TXTPlayer2DragonName.Margin = new Padding(4, 5, 4, 5);
            TXTPlayer2DragonName.Name = "TXTPlayer2DragonName";
            TXTPlayer2DragonName.Size = new Size(197, 31);
            TXTPlayer2DragonName.TabIndex = 8;
            // 
            // GBP2dragontype
            // 
            GBP2dragontype.Controls.Add(checkBoxP2Water);
            GBP2dragontype.Controls.Add(BTNP2Details);
            GBP2dragontype.Controls.Add(checkBoxP2Earth);
            GBP2dragontype.Controls.Add(checkBoxP2Wind);
            GBP2dragontype.Controls.Add(checkBoxP2Fire);
            GBP2dragontype.Location = new Point(9, 190);
            GBP2dragontype.Margin = new Padding(4, 5, 4, 5);
            GBP2dragontype.Name = "GBP2dragontype";
            GBP2dragontype.Padding = new Padding(4, 5, 4, 5);
            GBP2dragontype.Size = new Size(400, 530);
            GBP2dragontype.TabIndex = 1;
            GBP2dragontype.TabStop = false;
            GBP2dragontype.Text = "Player 2 dragon type";
            // 
            // checkBoxP2Water
            // 
            checkBoxP2Water.AutoSize = true;
            checkBoxP2Water.Location = new Point(41, 347);
            checkBoxP2Water.Margin = new Padding(4, 5, 4, 5);
            checkBoxP2Water.Name = "checkBoxP2Water";
            checkBoxP2Water.Size = new Size(147, 29);
            checkBoxP2Water.TabIndex = 8;
            checkBoxP2Water.Text = "Water dragon";
            checkBoxP2Water.UseVisualStyleBackColor = true;
            // 
            // BTNP2Details
            // 
            BTNP2Details.Location = new Point(84, 465);
            BTNP2Details.Margin = new Padding(4, 5, 4, 5);
            BTNP2Details.Name = "BTNP2Details";
            BTNP2Details.Size = new Size(221, 38);
            BTNP2Details.TabIndex = 1;
            BTNP2Details.Text = "Save Player 2 details";
            BTNP2Details.UseVisualStyleBackColor = true;
            BTNP2Details.Click += BTNP2Details_Click;
            // 
            // checkBoxP2Earth
            // 
            checkBoxP2Earth.AutoSize = true;
            checkBoxP2Earth.Location = new Point(41, 265);
            checkBoxP2Earth.Margin = new Padding(4, 5, 4, 5);
            checkBoxP2Earth.Name = "checkBoxP2Earth";
            checkBoxP2Earth.Size = new Size(141, 29);
            checkBoxP2Earth.TabIndex = 7;
            checkBoxP2Earth.Text = "Earth dragon";
            checkBoxP2Earth.UseVisualStyleBackColor = true;
            // 
            // checkBoxP2Wind
            // 
            checkBoxP2Wind.AutoSize = true;
            checkBoxP2Wind.Location = new Point(41, 183);
            checkBoxP2Wind.Margin = new Padding(4, 5, 4, 5);
            checkBoxP2Wind.Name = "checkBoxP2Wind";
            checkBoxP2Wind.Size = new Size(143, 29);
            checkBoxP2Wind.TabIndex = 6;
            checkBoxP2Wind.Text = "Wind dragon";
            checkBoxP2Wind.UseVisualStyleBackColor = true;
            checkBoxP2Wind.CheckedChanged += checkBox7_CheckedChanged;
            // 
            // checkBoxP2Fire
            // 
            checkBoxP2Fire.AutoSize = true;
            checkBoxP2Fire.Location = new Point(41, 100);
            checkBoxP2Fire.Margin = new Padding(4, 5, 4, 5);
            checkBoxP2Fire.Name = "checkBoxP2Fire";
            checkBoxP2Fire.Size = new Size(129, 29);
            checkBoxP2Fire.TabIndex = 5;
            checkBoxP2Fire.Text = "Fire dragon";
            checkBoxP2Fire.UseVisualStyleBackColor = true;
            // 
            // TXTPlayer2Name
            // 
            TXTPlayer2Name.Location = new Point(169, 47);
            TXTPlayer2Name.Margin = new Padding(4, 5, 4, 5);
            TXTPlayer2Name.Name = "TXTPlayer2Name";
            TXTPlayer2Name.Size = new Size(197, 31);
            TXTPlayer2Name.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 52);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(115, 25);
            label4.TabIndex = 5;
            label4.Text = "Player Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 138);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(128, 25);
            label3.TabIndex = 6;
            label3.Text = "Dragon Name:";
            // 
            // BTNStartGame
            // 
            BTNStartGame.Location = new Point(329, 908);
            BTNStartGame.Margin = new Padding(4, 5, 4, 5);
            BTNStartGame.Name = "BTNStartGame";
            BTNStartGame.Size = new Size(254, 87);
            BTNStartGame.TabIndex = 2;
            BTNStartGame.Text = "Start game";
            BTNStartGame.UseVisualStyleBackColor = true;
            // 
            // BTNBack
            // 
            BTNBack.Location = new Point(709, 908);
            BTNBack.Margin = new Padding(4, 5, 4, 5);
            BTNBack.Name = "BTNBack";
            BTNBack.Size = new Size(184, 87);
            BTNBack.TabIndex = 3;
            BTNBack.Text = "Back";
            BTNBack.UseVisualStyleBackColor = true;
            // 
            // PlayerInfoScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1347, 1042);
            Controls.Add(BTNBack);
            Controls.Add(BTNStartGame);
            Controls.Add(GBP2details);
            Controls.Add(GBP1details);
            Margin = new Padding(4, 5, 4, 5);
            Name = "PlayerInfoScreen";
            Text = "PlayerInfoScreen";
            GBP1details.ResumeLayout(false);
            GBP1details.PerformLayout();
            GBP1dragontype.ResumeLayout(false);
            GBP1dragontype.PerformLayout();
            GBP2details.ResumeLayout(false);
            GBP2details.PerformLayout();
            GBP2dragontype.ResumeLayout(false);
            GBP2dragontype.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GBP1details;
        private TextBox TXTPlayer1DragonName;
        private TextBox TXTPlayer1Name;
        private Label label2;
        private Label label1;
        private GroupBox GBP1dragontype;
        private CheckBox checkBoxP1Water;
        private CheckBox checkBoxP1Earth;
        private CheckBox checkBoxP1Wind;
        private CheckBox checkboxP1fire;
        private Button BTNP1Details;
        private GroupBox GBP2details;
        private TextBox TXTPlayer2DragonName;
        private GroupBox GBP2dragontype;
        private CheckBox checkBoxP2Water;
        private Button BTNP2Details;
        private CheckBox checkBoxP2Earth;
        private CheckBox checkBoxP2Wind;
        private CheckBox checkBoxP2Fire;
        private TextBox TXTPlayer2Name;
        private Label label4;
        private Label label3;
        private Button BTNStartGame;
        private Button BTNBack;
    }
}