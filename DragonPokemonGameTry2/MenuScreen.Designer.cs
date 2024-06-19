namespace DragonPokemonGameTry2
{
    partial class MenuScreen
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
            textBox1 = new TextBox();
            BTNPlay = new Button();
            BTNBestiary = new Button();
            BTNQuit = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(301, 46);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(279, 52);
            textBox1.TabIndex = 0;
            textBox1.Text = "DRAGONMON";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // BTNPlay
            // 
            BTNPlay.Location = new Point(365, 176);
            BTNPlay.Name = "BTNPlay";
            BTNPlay.Size = new Size(149, 77);
            BTNPlay.TabIndex = 1;
            BTNPlay.Text = "Play";
            BTNPlay.UseVisualStyleBackColor = true;
            BTNPlay.Click += BTNPlay_Click;
            // 
            // BTNBestiary
            // 
            BTNBestiary.Location = new Point(365, 317);
            BTNBestiary.Name = "BTNBestiary";
            BTNBestiary.Size = new Size(149, 77);
            BTNBestiary.TabIndex = 2;
            BTNBestiary.Text = "Bestiary";
            BTNBestiary.UseVisualStyleBackColor = true;
            BTNBestiary.Click += BTNBestiary_Click;
            // 
            // BTNQuit
            // 
            BTNQuit.Location = new Point(365, 471);
            BTNQuit.Name = "BTNQuit";
            BTNQuit.Size = new Size(149, 77);
            BTNQuit.TabIndex = 3;
            BTNQuit.Text = "Quit";
            BTNQuit.UseVisualStyleBackColor = true;
            // 
            // MenuScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 632);
            Controls.Add(BTNQuit);
            Controls.Add(BTNBestiary);
            Controls.Add(BTNPlay);
            Controls.Add(textBox1);
            Name = "MenuScreen";
            Text = "MenuScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button BTNPlay;
        private Button BTNBestiary;
        private Button BTNQuit;
    }
}