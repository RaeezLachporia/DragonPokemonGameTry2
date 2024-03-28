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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            BTNP1Details = new Button();
            BTNP2Details = new Button();
            checkboxP1fire = new CheckBox();
            checkBoxP1Wind = new CheckBox();
            checkBoxP1Earth = new CheckBox();
            checkBoxP1Water = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            TXTPlayer1Name = new TextBox();
            TXTPlayer1DragonName = new TextBox();
            TXTPlayer2DragonName = new TextBox();
            TXTPlayer2Name = new TextBox();
            label3 = new Label();
            label4 = new Label();
            checkBoxP2Water = new CheckBox();
            checkBoxP2Earth = new CheckBox();
            checkBoxP2Wind = new CheckBox();
            checkBoxP2Fire = new CheckBox();
            BTNStartGame = new Button();
            BTNBack = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TXTPlayer1DragonName);
            groupBox1.Controls.Add(TXTPlayer1Name);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Location = new Point(44, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(301, 438);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(TXTPlayer2DragonName);
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(TXTPlayer2Name);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(368, 62);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(301, 438);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(checkBoxP1Water);
            groupBox3.Controls.Add(checkBoxP1Earth);
            groupBox3.Controls.Add(checkBoxP1Wind);
            groupBox3.Controls.Add(checkboxP1fire);
            groupBox3.Controls.Add(BTNP1Details);
            groupBox3.Location = new Point(6, 114);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(280, 318);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(checkBoxP2Water);
            groupBox4.Controls.Add(BTNP2Details);
            groupBox4.Controls.Add(checkBoxP2Earth);
            groupBox4.Controls.Add(checkBoxP2Wind);
            groupBox4.Controls.Add(checkBoxP2Fire);
            groupBox4.Location = new Point(6, 114);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(280, 318);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "groupBox4";
            // 
            // BTNP1Details
            // 
            BTNP1Details.Location = new Point(44, 279);
            BTNP1Details.Name = "BTNP1Details";
            BTNP1Details.Size = new Size(163, 23);
            BTNP1Details.TabIndex = 0;
            BTNP1Details.Text = "Save Player 1 details";
            BTNP1Details.UseVisualStyleBackColor = true;
            // 
            // BTNP2Details
            // 
            BTNP2Details.Location = new Point(59, 279);
            BTNP2Details.Name = "BTNP2Details";
            BTNP2Details.Size = new Size(155, 23);
            BTNP2Details.TabIndex = 1;
            BTNP2Details.Text = "Save Player 2 details";
            BTNP2Details.UseVisualStyleBackColor = true;
            // 
            // checkboxP1fire
            // 
            checkboxP1fire.AutoSize = true;
            checkboxP1fire.Location = new Point(20, 60);
            checkboxP1fire.Name = "checkboxP1fire";
            checkboxP1fire.Size = new Size(86, 19);
            checkboxP1fire.TabIndex = 1;
            checkboxP1fire.Text = "Fire dragon";
            checkboxP1fire.UseVisualStyleBackColor = true;
            checkboxP1fire.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBoxP1Wind
            // 
            checkBoxP1Wind.AutoSize = true;
            checkBoxP1Wind.Location = new Point(20, 110);
            checkBoxP1Wind.Name = "checkBoxP1Wind";
            checkBoxP1Wind.Size = new Size(95, 19);
            checkBoxP1Wind.TabIndex = 2;
            checkBoxP1Wind.Text = "Wind dragon";
            checkBoxP1Wind.UseVisualStyleBackColor = true;
            // 
            // checkBoxP1Earth
            // 
            checkBoxP1Earth.AutoSize = true;
            checkBoxP1Earth.Location = new Point(20, 159);
            checkBoxP1Earth.Name = "checkBoxP1Earth";
            checkBoxP1Earth.Size = new Size(94, 19);
            checkBoxP1Earth.TabIndex = 3;
            checkBoxP1Earth.Text = "Earth dragon";
            checkBoxP1Earth.UseVisualStyleBackColor = true;
            // 
            // checkBoxP1Water
            // 
            checkBoxP1Water.AutoSize = true;
            checkBoxP1Water.Location = new Point(20, 208);
            checkBoxP1Water.Name = "checkBoxP1Water";
            checkBoxP1Water.Size = new Size(98, 19);
            checkBoxP1Water.TabIndex = 4;
            checkBoxP1Water.Text = "Water dragon";
            checkBoxP1Water.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 31);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 1;
            label1.Text = "Player Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 83);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 2;
            label2.Text = "Dragon Name:";
            // 
            // TXTPlayer1Name
            // 
            TXTPlayer1Name.Location = new Point(111, 28);
            TXTPlayer1Name.Name = "TXTPlayer1Name";
            TXTPlayer1Name.Size = new Size(139, 23);
            TXTPlayer1Name.TabIndex = 3;
            // 
            // TXTPlayer1DragonName
            // 
            TXTPlayer1DragonName.Location = new Point(111, 80);
            TXTPlayer1DragonName.Name = "TXTPlayer1DragonName";
            TXTPlayer1DragonName.Size = new Size(139, 23);
            TXTPlayer1DragonName.TabIndex = 4;
            // 
            // TXTPlayer2DragonName
            // 
            TXTPlayer2DragonName.Location = new Point(118, 80);
            TXTPlayer2DragonName.Name = "TXTPlayer2DragonName";
            TXTPlayer2DragonName.Size = new Size(139, 23);
            TXTPlayer2DragonName.TabIndex = 8;
            // 
            // TXTPlayer2Name
            // 
            TXTPlayer2Name.Location = new Point(118, 28);
            TXTPlayer2Name.Name = "TXTPlayer2Name";
            TXTPlayer2Name.Size = new Size(139, 23);
            TXTPlayer2Name.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 83);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 6;
            label3.Text = "Dragon Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 31);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 5;
            label4.Text = "Player Name:";
            // 
            // checkBoxP2Water
            // 
            checkBoxP2Water.AutoSize = true;
            checkBoxP2Water.Location = new Point(29, 208);
            checkBoxP2Water.Name = "checkBoxP2Water";
            checkBoxP2Water.Size = new Size(98, 19);
            checkBoxP2Water.TabIndex = 8;
            checkBoxP2Water.Text = "Water dragon";
            checkBoxP2Water.UseVisualStyleBackColor = true;
            // 
            // checkBoxP2Earth
            // 
            checkBoxP2Earth.AutoSize = true;
            checkBoxP2Earth.Location = new Point(29, 159);
            checkBoxP2Earth.Name = "checkBoxP2Earth";
            checkBoxP2Earth.Size = new Size(94, 19);
            checkBoxP2Earth.TabIndex = 7;
            checkBoxP2Earth.Text = "Earth dragon";
            checkBoxP2Earth.UseVisualStyleBackColor = true;
            // 
            // checkBoxP2Wind
            // 
            checkBoxP2Wind.AutoSize = true;
            checkBoxP2Wind.Location = new Point(29, 110);
            checkBoxP2Wind.Name = "checkBoxP2Wind";
            checkBoxP2Wind.Size = new Size(95, 19);
            checkBoxP2Wind.TabIndex = 6;
            checkBoxP2Wind.Text = "Wind dragon";
            checkBoxP2Wind.UseVisualStyleBackColor = true;
            checkBoxP2Wind.CheckedChanged += checkBox7_CheckedChanged;
            // 
            // checkBoxP2Fire
            // 
            checkBoxP2Fire.AutoSize = true;
            checkBoxP2Fire.Location = new Point(29, 60);
            checkBoxP2Fire.Name = "checkBoxP2Fire";
            checkBoxP2Fire.Size = new Size(86, 19);
            checkBoxP2Fire.TabIndex = 5;
            checkBoxP2Fire.Text = "Fire dragon";
            checkBoxP2Fire.UseVisualStyleBackColor = true;
            // 
            // BTNStartGame
            // 
            BTNStartGame.Location = new Point(230, 545);
            BTNStartGame.Name = "BTNStartGame";
            BTNStartGame.Size = new Size(178, 52);
            BTNStartGame.TabIndex = 2;
            BTNStartGame.Text = "Start game";
            BTNStartGame.UseVisualStyleBackColor = true;
            // 
            // BTNBack
            // 
            BTNBack.Location = new Point(496, 545);
            BTNBack.Name = "BTNBack";
            BTNBack.Size = new Size(129, 52);
            BTNBack.TabIndex = 3;
            BTNBack.Text = "Back";
            BTNBack.UseVisualStyleBackColor = true;
            // 
            // PlayerInfoScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 625);
            Controls.Add(BTNBack);
            Controls.Add(BTNStartGame);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "PlayerInfoScreen";
            Text = "PlayerInfoScreen";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox TXTPlayer1DragonName;
        private TextBox TXTPlayer1Name;
        private Label label2;
        private Label label1;
        private GroupBox groupBox3;
        private CheckBox checkBoxP1Water;
        private CheckBox checkBoxP1Earth;
        private CheckBox checkBoxP1Wind;
        private CheckBox checkboxP1fire;
        private Button BTNP1Details;
        private GroupBox groupBox2;
        private TextBox TXTPlayer2DragonName;
        private GroupBox groupBox4;
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