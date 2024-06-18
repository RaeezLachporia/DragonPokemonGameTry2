namespace DragonPokemonGameTry2
{
    partial class playScreen
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
            GBActivePlayer = new GroupBox();
            BTNRest = new Button();
            LBLdragonHP = new Label();
            btnBlock = new Button();
            BTNspecial = new Button();
            BTNattack = new Button();
            TXTbattlelog = new TextBox();
            LBLplayername = new Label();
            GBenemyPlayer = new GroupBox();
            LBLEnemyHp = new Label();
            LBLEdragname = new Label();
            GBActivePlayer.SuspendLayout();
            GBenemyPlayer.SuspendLayout();
            SuspendLayout();
            // 
            // GBActivePlayer
            // 
            GBActivePlayer.Controls.Add(BTNRest);
            GBActivePlayer.Controls.Add(LBLdragonHP);
            GBActivePlayer.Controls.Add(btnBlock);
            GBActivePlayer.Controls.Add(BTNspecial);
            GBActivePlayer.Controls.Add(BTNattack);
            GBActivePlayer.Location = new Point(29, 83);
            GBActivePlayer.Name = "GBActivePlayer";
            GBActivePlayer.Size = new Size(297, 459);
            GBActivePlayer.TabIndex = 0;
            GBActivePlayer.TabStop = false;
            GBActivePlayer.Text = "groupBox1";
            // 
            // BTNRest
            // 
            BTNRest.Location = new Point(186, 226);
            BTNRest.Name = "BTNRest";
            BTNRest.Size = new Size(105, 81);
            BTNRest.TabIndex = 4;
            BTNRest.Text = "Rest";
            BTNRest.UseVisualStyleBackColor = true;
            // 
            // LBLdragonHP
            // 
            LBLdragonHP.AutoSize = true;
            LBLdragonHP.Location = new Point(38, 65);
            LBLdragonHP.Name = "LBLdragonHP";
            LBLdragonHP.Size = new Size(0, 15);
            LBLdragonHP.TabIndex = 3;
            // 
            // btnBlock
            // 
            btnBlock.Location = new Point(6, 345);
            btnBlock.Name = "btnBlock";
            btnBlock.Size = new Size(174, 81);
            btnBlock.TabIndex = 2;
            btnBlock.Text = "Block";
            btnBlock.UseVisualStyleBackColor = true;
            btnBlock.Click += btnBlock_Click;
            // 
            // BTNspecial
            // 
            BTNspecial.Location = new Point(6, 226);
            BTNspecial.Name = "BTNspecial";
            BTNspecial.Size = new Size(174, 81);
            BTNspecial.TabIndex = 1;
            BTNspecial.Text = "Special Attack";
            BTNspecial.UseVisualStyleBackColor = true;
            BTNspecial.Click += BTNspecial_Click;
            // 
            // BTNattack
            // 
            BTNattack.Location = new Point(6, 117);
            BTNattack.Name = "BTNattack";
            BTNattack.Size = new Size(174, 81);
            BTNattack.TabIndex = 0;
            BTNattack.Text = "Attack";
            BTNattack.UseVisualStyleBackColor = true;
            BTNattack.Click += BTNattack_Click;
            // 
            // TXTbattlelog
            // 
            TXTbattlelog.Location = new Point(332, 266);
            TXTbattlelog.Multiline = true;
            TXTbattlelog.Name = "TXTbattlelog";
            TXTbattlelog.Size = new Size(534, 276);
            TXTbattlelog.TabIndex = 1;
            // 
            // LBLplayername
            // 
            LBLplayername.AutoSize = true;
            LBLplayername.Location = new Point(54, 31);
            LBLplayername.Name = "LBLplayername";
            LBLplayername.Size = new Size(69, 15);
            LBLplayername.TabIndex = 2;
            LBLplayername.Text = "playername";
            // 
            // GBenemyPlayer
            // 
            GBenemyPlayer.Controls.Add(LBLEnemyHp);
            GBenemyPlayer.Controls.Add(LBLEdragname);
            GBenemyPlayer.Location = new Point(332, 83);
            GBenemyPlayer.Name = "GBenemyPlayer";
            GBenemyPlayer.Size = new Size(534, 159);
            GBenemyPlayer.TabIndex = 3;
            GBenemyPlayer.TabStop = false;
            GBenemyPlayer.Text = "groupBox1";
            // 
            // LBLEnemyHp
            // 
            LBLEnemyHp.AutoSize = true;
            LBLEnemyHp.Location = new Point(37, 92);
            LBLEnemyHp.Name = "LBLEnemyHp";
            LBLEnemyHp.Size = new Size(0, 15);
            LBLEnemyHp.TabIndex = 1;
            // 
            // LBLEdragname
            // 
            LBLEdragname.AutoSize = true;
            LBLEdragname.Location = new Point(27, 39);
            LBLEdragname.Name = "LBLEdragname";
            LBLEdragname.Size = new Size(0, 15);
            LBLEdragname.TabIndex = 0;
            // 
            // playScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 581);
            Controls.Add(GBenemyPlayer);
            Controls.Add(LBLplayername);
            Controls.Add(TXTbattlelog);
            Controls.Add(GBActivePlayer);
            Name = "playScreen";
            Text = "playScreen";
            Load += playScreen_Load;
            GBActivePlayer.ResumeLayout(false);
            GBActivePlayer.PerformLayout();
            GBenemyPlayer.ResumeLayout(false);
            GBenemyPlayer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox GBActivePlayer;
        private Button btnBlock;
        private Button BTNspecial;
        private Button BTNattack;
        private TextBox TXTbattlelog;
        private Label LBLdragonHP;
        private Label LBLplayername;
        private GroupBox GBenemyPlayer;
        private Label LBLEnemyHp;
        private Label LBLEdragname;
        private Button BTNRest;
    }
}