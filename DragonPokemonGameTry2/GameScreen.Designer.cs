﻿namespace DragonPokemonGameTry2
{
    partial class GameScreen
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
            BTNattack = new Button();
            BTNSPecial = new Button();
            BTNBlock = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            LBLPlayername = new Label();
            SuspendLayout();
            // 
            // BTNattack
            // 
            BTNattack.Location = new Point(66, 120);
            BTNattack.Name = "BTNattack";
            BTNattack.Size = new Size(114, 62);
            BTNattack.TabIndex = 0;
            BTNattack.Text = "Attack";
            BTNattack.UseVisualStyleBackColor = true;
            // 
            // BTNSPecial
            // 
            BTNSPecial.Location = new Point(66, 267);
            BTNSPecial.Name = "BTNSPecial";
            BTNSPecial.Size = new Size(114, 63);
            BTNSPecial.TabIndex = 1;
            BTNSPecial.Text = "Special Attack ";
            BTNSPecial.UseVisualStyleBackColor = true;
            // 
            // BTNBlock
            // 
            BTNBlock.Location = new Point(66, 425);
            BTNBlock.Name = "BTNBlock";
            BTNBlock.Size = new Size(114, 81);
            BTNBlock.TabIndex = 2;
            BTNBlock.Text = "Block";
            BTNBlock.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(223, 120);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(171, 98);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(577, 65);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(95, 23);
            textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(577, 120);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(171, 98);
            textBox4.TabIndex = 6;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(259, 307);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 7;
            textBox5.Text = "Battle log ";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(223, 392);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(525, 187);
            textBox6.TabIndex = 8;
            // 
            // LBLPlayername
            // 
            LBLPlayername.AutoSize = true;
            LBLPlayername.Location = new Point(223, 65);
            LBLPlayername.Name = "LBLPlayername";
            LBLPlayername.Size = new Size(38, 15);
            LBLPlayername.TabIndex = 9;
            LBLPlayername.Text = "label1";
            // 
            // GameScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 608);
            Controls.Add(LBLPlayername);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(BTNBlock);
            Controls.Add(BTNSPecial);
            Controls.Add(BTNattack);
            Name = "GameScreen";
            Text = "GameScreen";
            Load += GameScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTNattack;
        private Button BTNSPecial;
        private Button BTNBlock;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label LBLPlayername;
    }
}