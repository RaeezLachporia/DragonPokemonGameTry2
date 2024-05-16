namespace DragonPokemonGameTry2
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
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            LBLPlayername = new Label();
            label1 = new Label();
            LBLDragonName = new Label();
            LBLDragonAttack = new Label();
            LBLSPATTACK = new Label();
            LBLBlock = new Label();
            LBLdragonHealth = new Label();
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
            // textBox5
            // 
            textBox5.Location = new Point(223, 335);
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
            LBLPlayername.Size = new Size(62, 15);
            LBLPlayername.TabIndex = 9;
            LBLPlayername.Text = "labelname";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(577, 65);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 10;
            label1.Text = "lablename";
            label1.Click += label1_Click;
            // 
            // LBLDragonName
            // 
            LBLDragonName.AutoSize = true;
            LBLDragonName.Location = new Point(223, 158);
            LBLDragonName.Name = "LBLDragonName";
            LBLDragonName.Size = new Size(100, 15);
            LBLDragonName.TabIndex = 11;
            LBLDragonName.Text = "labeldragonname";
            // 
            // LBLDragonAttack
            // 
            LBLDragonAttack.AutoSize = true;
            LBLDragonAttack.Location = new Point(223, 204);
            LBLDragonAttack.Name = "LBLDragonAttack";
            LBLDragonAttack.Size = new Size(102, 15);
            LBLDragonAttack.TabIndex = 13;
            LBLDragonAttack.Text = "labeldragonattack";
            // 
            // LBLSPATTACK
            // 
            LBLSPATTACK.AutoSize = true;
            LBLSPATTACK.Location = new Point(223, 246);
            LBLSPATTACK.Name = "LBLSPATTACK";
            LBLSPATTACK.Size = new Size(81, 15);
            LBLSPATTACK.TabIndex = 14;
            LBLSPATTACK.Text = "dragonspecial";
            // 
            // LBLBlock
            // 
            LBLBlock.AutoSize = true;
            LBLBlock.Location = new Point(223, 291);
            LBLBlock.Name = "LBLBlock";
            LBLBlock.Size = new Size(61, 15);
            LBLBlock.TabIndex = 15;
            LBLBlock.Text = "labelblock";
            LBLBlock.Click += LBLBlock_Click;
            // 
            // LBLdragonHealth
            // 
            LBLdragonHealth.AutoSize = true;
            LBLdragonHealth.Location = new Point(223, 120);
            LBLdragonHealth.Name = "LBLdragonHealth";
            LBLdragonHealth.Size = new Size(65, 15);
            LBLdragonHealth.TabIndex = 16;
            LBLdragonHealth.Text = "labelhealth";
            // 
            // GameScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 608);
            Controls.Add(LBLdragonHealth);
            Controls.Add(LBLBlock);
            Controls.Add(LBLSPATTACK);
            Controls.Add(LBLDragonAttack);
            Controls.Add(LBLDragonName);
            Controls.Add(label1);
            Controls.Add(LBLPlayername);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
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
        private TextBox textBox5;
        private TextBox textBox6;
        private Label LBLPlayername;
        private Label label1;
        private Label LBLDragonName;
        private Label LBLDragonAttack;
        private Label LBLSPATTACK;
        private Label LBLBlock;
        private Label LBLdragonHealth;
    }
}