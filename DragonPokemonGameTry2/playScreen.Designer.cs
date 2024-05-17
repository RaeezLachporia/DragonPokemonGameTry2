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
            BTNattack = new Button();
            BTNspecial = new Button();
            btnBlock = new Button();
            textBox1 = new TextBox();
            GBActivePlayer.SuspendLayout();
            SuspendLayout();
            // 
            // GBActivePlayer
            // 
            GBActivePlayer.Controls.Add(btnBlock);
            GBActivePlayer.Controls.Add(BTNspecial);
            GBActivePlayer.Controls.Add(BTNattack);
            GBActivePlayer.Location = new Point(29, 83);
            GBActivePlayer.Name = "GBActivePlayer";
            GBActivePlayer.Size = new Size(257, 459);
            GBActivePlayer.TabIndex = 0;
            GBActivePlayer.TabStop = false;
            GBActivePlayer.Text = "groupBox1";
            // 
            // BTNattack
            // 
            BTNattack.Location = new Point(6, 64);
            BTNattack.Name = "BTNattack";
            BTNattack.Size = new Size(174, 81);
            BTNattack.TabIndex = 0;
            BTNattack.Text = "Attack";
            BTNattack.UseVisualStyleBackColor = true;
            // 
            // BTNspecial
            // 
            BTNspecial.Location = new Point(6, 226);
            BTNspecial.Name = "BTNspecial";
            BTNspecial.Size = new Size(174, 81);
            BTNspecial.TabIndex = 1;
            BTNspecial.Text = "Special Attack";
            BTNspecial.UseVisualStyleBackColor = true;
            // 
            // btnBlock
            // 
            btnBlock.Location = new Point(6, 360);
            btnBlock.Name = "btnBlock";
            btnBlock.Size = new Size(174, 81);
            btnBlock.TabIndex = 2;
            btnBlock.Text = "Block";
            btnBlock.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(332, 266);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(534, 276);
            textBox1.TabIndex = 1;
            // 
            // playScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 581);
            Controls.Add(textBox1);
            Controls.Add(GBActivePlayer);
            Name = "playScreen";
            Text = "playScreen";
            Load += playScreen_Load;
            GBActivePlayer.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox GBActivePlayer;
        private Button btnBlock;
        private Button BTNspecial;
        private Button BTNattack;
        private TextBox textBox1;
    }
}