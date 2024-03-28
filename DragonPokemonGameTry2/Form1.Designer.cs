namespace DragonPokemonGameTry2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BTNPlay = new Button();
            this.pictureBox1 = new PictureBox();
            BTNBestiary = new Button();
            BTNQuit = new Button();
            ((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BTNPlay
            // 
            BTNPlay.Location = new Point(332, 176);
            BTNPlay.Name = "BTNPlay";
            BTNPlay.Size = new Size(114, 61);
            BTNPlay.TabIndex = 0;
            BTNPlay.Text = "Play";
            BTNPlay.UseVisualStyleBackColor = true;
            BTNPlay.Click += button1_Click;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            this.pictureBox1.Location = new Point(158, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Size(442, 136);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // BTNBestiary
            // 
            BTNBestiary.Location = new Point(332, 272);
            BTNBestiary.Name = "BTNBestiary";
            BTNBestiary.Size = new Size(114, 61);
            BTNBestiary.TabIndex = 2;
            BTNBestiary.Text = "Bestiary";
            BTNBestiary.UseVisualStyleBackColor = true;
            // 
            // BTNQuit
            // 
            BTNQuit.Location = new Point(332, 362);
            BTNQuit.Name = "BTNQuit";
            BTNQuit.Size = new Size(114, 61);
            BTNQuit.TabIndex = 3;
            BTNQuit.Text = "Quit";
            BTNQuit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BTNQuit);
            Controls.Add(BTNBestiary);
            Controls.Add(this.pictureBox1);
            Controls.Add(BTNPlay);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BTNPlay;
        private Button BTNBestiary;
        private Button BTNQuit;
    }
}