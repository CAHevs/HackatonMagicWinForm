namespace HackatonMagic
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
            this.components = new System.ComponentModel.Container();
            this.txtNameP1 = new System.Windows.Forms.TextBox();
            this.txtNameP2 = new System.Windows.Forms.TextBox();
            this.lblDice6Value = new System.Windows.Forms.Label();
            this.lblDice20Value = new System.Windows.Forms.Label();
            this.lblDiceXValue = new System.Windows.Forms.Label();
            this.btnRoll6 = new System.Windows.Forms.Button();
            this.btnRoll20 = new System.Windows.Forms.Button();
            this.BtnRollX = new System.Windows.Forms.Button();
            this.txtDiceX = new System.Windows.Forms.TextBox();
            this.gameTime = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblInfoCarte = new System.Windows.Forms.Label();
            this.lblInfoMarqueurs = new System.Windows.Forms.Label();
            this.nupJ1 = new System.Windows.Forms.NumericUpDown();
            this.lblLifeP1 = new System.Windows.Forms.Label();
            this.nupJ2 = new System.Windows.Forms.NumericUpDown();
            this.lblLifeP2 = new System.Windows.Forms.Label();
            this.btnAddCounter = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSearchCard = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nupJ1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupJ2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNameP1
            // 
            this.txtNameP1.Location = new System.Drawing.Point(255, 64);
            this.txtNameP1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNameP1.Name = "txtNameP1";
            this.txtNameP1.Size = new System.Drawing.Size(185, 22);
            this.txtNameP1.TabIndex = 6;
            this.txtNameP1.Text = "Player 1";
            this.txtNameP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNameP2
            // 
            this.txtNameP2.Location = new System.Drawing.Point(524, 64);
            this.txtNameP2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNameP2.Name = "txtNameP2";
            this.txtNameP2.Size = new System.Drawing.Size(185, 22);
            this.txtNameP2.TabIndex = 7;
            this.txtNameP2.Text = "Player 2";
            this.txtNameP2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDice6Value
            // 
            this.lblDice6Value.AutoSize = true;
            this.lblDice6Value.Location = new System.Drawing.Point(364, 121);
            this.lblDice6Value.Name = "lblDice6Value";
            this.lblDice6Value.Size = new System.Drawing.Size(13, 17);
            this.lblDice6Value.TabIndex = 11;
            this.lblDice6Value.Text = "-";
            // 
            // lblDice20Value
            // 
            this.lblDice20Value.AutoSize = true;
            this.lblDice20Value.Location = new System.Drawing.Point(364, 171);
            this.lblDice20Value.Name = "lblDice20Value";
            this.lblDice20Value.Size = new System.Drawing.Size(13, 17);
            this.lblDice20Value.TabIndex = 12;
            this.lblDice20Value.Text = "-";
            // 
            // lblDiceXValue
            // 
            this.lblDiceXValue.AutoSize = true;
            this.lblDiceXValue.Location = new System.Drawing.Point(364, 223);
            this.lblDiceXValue.Name = "lblDiceXValue";
            this.lblDiceXValue.Size = new System.Drawing.Size(13, 17);
            this.lblDiceXValue.TabIndex = 13;
            this.lblDiceXValue.Text = "-";
            // 
            // btnRoll6
            // 
            this.btnRoll6.Location = new System.Drawing.Point(309, 117);
            this.btnRoll6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRoll6.Name = "btnRoll6";
            this.btnRoll6.Size = new System.Drawing.Size(49, 23);
            this.btnRoll6.TabIndex = 14;
            this.btnRoll6.Text = "Roll";
            this.btnRoll6.UseVisualStyleBackColor = true;
            this.btnRoll6.Click += new System.EventHandler(this.btnRoll6_Click);
            // 
            // btnRoll20
            // 
            this.btnRoll20.Location = new System.Drawing.Point(309, 167);
            this.btnRoll20.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRoll20.Name = "btnRoll20";
            this.btnRoll20.Size = new System.Drawing.Size(49, 23);
            this.btnRoll20.TabIndex = 15;
            this.btnRoll20.Text = "Roll";
            this.btnRoll20.UseVisualStyleBackColor = true;
            this.btnRoll20.Click += new System.EventHandler(this.btnRoll20_Click);
            // 
            // BtnRollX
            // 
            this.BtnRollX.Location = new System.Drawing.Point(309, 220);
            this.BtnRollX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRollX.Name = "BtnRollX";
            this.BtnRollX.Size = new System.Drawing.Size(49, 23);
            this.BtnRollX.TabIndex = 16;
            this.BtnRollX.Text = "Roll";
            this.BtnRollX.UseVisualStyleBackColor = true;
            this.BtnRollX.Click += new System.EventHandler(this.BtnRollX_Click);
            // 
            // txtDiceX
            // 
            this.txtDiceX.Location = new System.Drawing.Point(259, 220);
            this.txtDiceX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiceX.Name = "txtDiceX";
            this.txtDiceX.Size = new System.Drawing.Size(44, 22);
            this.txtDiceX.TabIndex = 17;
            // 
            // gameTime
            // 
            this.gameTime.Interval = 1000;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(24, 22);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(61, 23);
            this.btnStart.TabIndex = 19;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(103, 25);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(13, 17);
            this.lblTime.TabIndex = 20;
            this.lblTime.Text = "-";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(525, 114);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 22);
            this.textBox1.TabIndex = 21;
            // 
            // lblInfoCarte
            // 
            this.lblInfoCarte.AutoSize = true;
            this.lblInfoCarte.Location = new System.Drawing.Point(524, 158);
            this.lblInfoCarte.Name = "lblInfoCarte";
            this.lblInfoCarte.Size = new System.Drawing.Size(153, 17);
            this.lblInfoCarte.TabIndex = 22;
            this.lblInfoCarte.Text = "Information de la carte ";
            // 
            // lblInfoMarqueurs
            // 
            this.lblInfoMarqueurs.AutoSize = true;
            this.lblInfoMarqueurs.Location = new System.Drawing.Point(255, 266);
            this.lblInfoMarqueurs.Name = "lblInfoMarqueurs";
            this.lblInfoMarqueurs.Size = new System.Drawing.Size(76, 17);
            this.lblInfoMarqueurs.TabIndex = 26;
            this.lblInfoMarqueurs.Text = "Marqueurs";
            // 
            // nupJ1
            // 
            this.nupJ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupJ1.Location = new System.Drawing.Point(357, 12);
            this.nupJ1.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nupJ1.Name = "nupJ1";
            this.nupJ1.Size = new System.Drawing.Size(83, 36);
            this.nupJ1.TabIndex = 27;
            this.nupJ1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nupJ1.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // lblLifeP1
            // 
            this.lblLifeP1.AutoSize = true;
            this.lblLifeP1.Location = new System.Drawing.Point(250, 25);
            this.lblLifeP1.Name = "lblLifeP1";
            this.lblLifeP1.Size = new System.Drawing.Size(101, 17);
            this.lblLifeP1.TabIndex = 28;
            this.lblLifeP1.Text = "Point de vie J1";
            // 
            // nupJ2
            // 
            this.nupJ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupJ2.Location = new System.Drawing.Point(629, 12);
            this.nupJ2.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nupJ2.Name = "nupJ2";
            this.nupJ2.Size = new System.Drawing.Size(83, 36);
            this.nupJ2.TabIndex = 29;
            this.nupJ2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nupJ2.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // lblLifeP2
            // 
            this.lblLifeP2.AutoSize = true;
            this.lblLifeP2.Location = new System.Drawing.Point(522, 25);
            this.lblLifeP2.Name = "lblLifeP2";
            this.lblLifeP2.Size = new System.Drawing.Size(101, 17);
            this.lblLifeP2.TabIndex = 30;
            this.lblLifeP2.Text = "Point de vie J2";
            // 
            // btnAddCounter
            // 
            this.btnAddCounter.Location = new System.Drawing.Point(255, 286);
            this.btnAddCounter.Name = "btnAddCounter";
            this.btnAddCounter.Size = new System.Drawing.Size(165, 33);
            this.btnAddCounter.TabIndex = 32;
            this.btnAddCounter.Text = "Ajouter un marqueur";
            this.btnAddCounter.UseVisualStyleBackColor = true;
            this.btnAddCounter.Click += new System.EventHandler(this.btnAddCounter_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HackatonMagic.Properties.Resources.spinedown20;
            this.pictureBox2.Location = new System.Drawing.Point(255, 160);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HackatonMagic.Properties.Resources.dice;
            this.pictureBox1.Location = new System.Drawing.Point(253, 114);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // btnSearchCard
            // 
            this.btnSearchCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearchCard.Image = global::HackatonMagic.Properties.Resources.search;
            this.btnSearchCard.Location = new System.Drawing.Point(715, 108);
            this.btnSearchCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchCard.Name = "btnSearchCard";
            this.btnSearchCard.Size = new System.Drawing.Size(43, 35);
            this.btnSearchCard.TabIndex = 23;
            this.btnSearchCard.UseVisualStyleBackColor = true;
            this.btnSearchCard.Click += new System.EventHandler(this.btnSearchCard_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 582);
            this.Controls.Add(this.btnAddCounter);
            this.Controls.Add(this.lblLifeP2);
            this.Controls.Add(this.nupJ2);
            this.Controls.Add(this.lblLifeP1);
            this.Controls.Add(this.nupJ1);
            this.Controls.Add(this.lblInfoMarqueurs);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSearchCard);
            this.Controls.Add(this.lblInfoCarte);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtDiceX);
            this.Controls.Add(this.BtnRollX);
            this.Controls.Add(this.btnRoll20);
            this.Controls.Add(this.btnRoll6);
            this.Controls.Add(this.lblDiceXValue);
            this.Controls.Add(this.lblDice20Value);
            this.Controls.Add(this.lblDice6Value);
            this.Controls.Add(this.txtNameP2);
            this.Controls.Add(this.txtNameP1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Hackaton Magic";
            ((System.ComponentModel.ISupportInitialize)(this.nupJ1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupJ2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNameP1;
        private System.Windows.Forms.TextBox txtNameP2;
        private System.Windows.Forms.Label lblDice6Value;
        private System.Windows.Forms.Label lblDice20Value;
        private System.Windows.Forms.Label lblDiceXValue;
        private System.Windows.Forms.Button btnRoll6;
        private System.Windows.Forms.Button btnRoll20;
        private System.Windows.Forms.Button BtnRollX;
        private System.Windows.Forms.TextBox txtDiceX;
        private System.Windows.Forms.Timer gameTime;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblInfoCarte;
        private System.Windows.Forms.Button btnSearchCard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblInfoMarqueurs;
        private System.Windows.Forms.NumericUpDown nupJ1;
        private System.Windows.Forms.Label lblLifeP1;
        private System.Windows.Forms.NumericUpDown nupJ2;
        private System.Windows.Forms.Label lblLifeP2;
        private System.Windows.Forms.Button btnAddCounter;
    }
}

