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
            this.lblPVJ1 = new System.Windows.Forms.Label();
            this.lblPVJ2 = new System.Windows.Forms.Label();
            this.btnMinusJ1 = new System.Windows.Forms.Button();
            this.btnPlusJ1 = new System.Windows.Forms.Button();
            this.btnPlusJ2 = new System.Windows.Forms.Button();
            this.btnMinusJ2 = new System.Windows.Forms.Button();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSearchCard = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPVJ1
            // 
            this.lblPVJ1.AutoSize = true;
            this.lblPVJ1.Location = new System.Drawing.Point(252, 20);
            this.lblPVJ1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPVJ1.Name = "lblPVJ1";
            this.lblPVJ1.Size = new System.Drawing.Size(19, 13);
            this.lblPVJ1.TabIndex = 0;
            this.lblPVJ1.Text = "20";
            // 
            // lblPVJ2
            // 
            this.lblPVJ2.AutoSize = true;
            this.lblPVJ2.Location = new System.Drawing.Point(454, 20);
            this.lblPVJ2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPVJ2.Name = "lblPVJ2";
            this.lblPVJ2.Size = new System.Drawing.Size(19, 13);
            this.lblPVJ2.TabIndex = 1;
            this.lblPVJ2.Text = "20";
            // 
            // btnMinusJ1
            // 
            this.btnMinusJ1.Location = new System.Drawing.Point(192, 18);
            this.btnMinusJ1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMinusJ1.Name = "btnMinusJ1";
            this.btnMinusJ1.Size = new System.Drawing.Size(56, 19);
            this.btnMinusJ1.TabIndex = 2;
            this.btnMinusJ1.Text = "-";
            this.btnMinusJ1.UseVisualStyleBackColor = true;
            this.btnMinusJ1.Click += new System.EventHandler(this.btnMinusJ1_Click);
            // 
            // btnPlusJ1
            // 
            this.btnPlusJ1.Location = new System.Drawing.Point(275, 18);
            this.btnPlusJ1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPlusJ1.Name = "btnPlusJ1";
            this.btnPlusJ1.Size = new System.Drawing.Size(56, 19);
            this.btnPlusJ1.TabIndex = 3;
            this.btnPlusJ1.Text = "+";
            this.btnPlusJ1.UseVisualStyleBackColor = true;
            this.btnPlusJ1.Click += new System.EventHandler(this.btnPlusJ1_Click);
            // 
            // btnPlusJ2
            // 
            this.btnPlusJ2.Location = new System.Drawing.Point(477, 18);
            this.btnPlusJ2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPlusJ2.Name = "btnPlusJ2";
            this.btnPlusJ2.Size = new System.Drawing.Size(56, 19);
            this.btnPlusJ2.TabIndex = 4;
            this.btnPlusJ2.Text = "+";
            this.btnPlusJ2.UseVisualStyleBackColor = true;
            this.btnPlusJ2.Click += new System.EventHandler(this.btnPlusJ2_Click);
            // 
            // btnMinusJ2
            // 
            this.btnMinusJ2.Location = new System.Drawing.Point(394, 18);
            this.btnMinusJ2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMinusJ2.Name = "btnMinusJ2";
            this.btnMinusJ2.Size = new System.Drawing.Size(56, 19);
            this.btnMinusJ2.TabIndex = 5;
            this.btnMinusJ2.Text = "-";
            this.btnMinusJ2.UseVisualStyleBackColor = true;
            this.btnMinusJ2.Click += new System.EventHandler(this.btnMinusJ2_Click);
            // 
            // txtNameP1
            // 
            this.txtNameP1.Location = new System.Drawing.Point(191, 52);
            this.txtNameP1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNameP1.Name = "txtNameP1";
            this.txtNameP1.Size = new System.Drawing.Size(140, 20);
            this.txtNameP1.TabIndex = 6;
            this.txtNameP1.Text = "Player 1";
            this.txtNameP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNameP2
            // 
            this.txtNameP2.Location = new System.Drawing.Point(393, 52);
            this.txtNameP2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNameP2.Name = "txtNameP2";
            this.txtNameP2.Size = new System.Drawing.Size(140, 20);
            this.txtNameP2.TabIndex = 7;
            this.txtNameP2.Text = "Player 2";
            this.txtNameP2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDice6Value
            // 
            this.lblDice6Value.AutoSize = true;
            this.lblDice6Value.Location = new System.Drawing.Point(273, 98);
            this.lblDice6Value.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDice6Value.Name = "lblDice6Value";
            this.lblDice6Value.Size = new System.Drawing.Size(10, 13);
            this.lblDice6Value.TabIndex = 11;
            this.lblDice6Value.Text = "-";
            // 
            // lblDice20Value
            // 
            this.lblDice20Value.AutoSize = true;
            this.lblDice20Value.Location = new System.Drawing.Point(273, 139);
            this.lblDice20Value.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDice20Value.Name = "lblDice20Value";
            this.lblDice20Value.Size = new System.Drawing.Size(10, 13);
            this.lblDice20Value.TabIndex = 12;
            this.lblDice20Value.Text = "-";
            // 
            // lblDiceXValue
            // 
            this.lblDiceXValue.AutoSize = true;
            this.lblDiceXValue.Location = new System.Drawing.Point(273, 181);
            this.lblDiceXValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiceXValue.Name = "lblDiceXValue";
            this.lblDiceXValue.Size = new System.Drawing.Size(10, 13);
            this.lblDiceXValue.TabIndex = 13;
            this.lblDiceXValue.Text = "-";
            // 
            // btnRoll6
            // 
            this.btnRoll6.Location = new System.Drawing.Point(232, 95);
            this.btnRoll6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRoll6.Name = "btnRoll6";
            this.btnRoll6.Size = new System.Drawing.Size(37, 19);
            this.btnRoll6.TabIndex = 14;
            this.btnRoll6.Text = "Roll";
            this.btnRoll6.UseVisualStyleBackColor = true;
            this.btnRoll6.Click += new System.EventHandler(this.btnRoll6_Click);
            // 
            // btnRoll20
            // 
            this.btnRoll20.Location = new System.Drawing.Point(232, 136);
            this.btnRoll20.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRoll20.Name = "btnRoll20";
            this.btnRoll20.Size = new System.Drawing.Size(37, 19);
            this.btnRoll20.TabIndex = 15;
            this.btnRoll20.Text = "Roll";
            this.btnRoll20.UseVisualStyleBackColor = true;
            this.btnRoll20.Click += new System.EventHandler(this.btnRoll20_Click);
            // 
            // BtnRollX
            // 
            this.BtnRollX.Location = new System.Drawing.Point(232, 179);
            this.BtnRollX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnRollX.Name = "BtnRollX";
            this.BtnRollX.Size = new System.Drawing.Size(37, 19);
            this.BtnRollX.TabIndex = 16;
            this.BtnRollX.Text = "Roll";
            this.BtnRollX.UseVisualStyleBackColor = true;
            this.BtnRollX.Click += new System.EventHandler(this.BtnRollX_Click);
            // 
            // txtDiceX
            // 
            this.txtDiceX.Location = new System.Drawing.Point(194, 179);
            this.txtDiceX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDiceX.Name = "txtDiceX";
            this.txtDiceX.Size = new System.Drawing.Size(34, 20);
            this.txtDiceX.TabIndex = 17;
            // 
            // gameTime
            // 
            this.gameTime.Interval = 1000;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(18, 18);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(46, 19);
            this.btnStart.TabIndex = 19;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(77, 20);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(10, 13);
            this.lblTime.TabIndex = 20;
            this.lblTime.Text = "-";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(394, 93);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 20);
            this.textBox1.TabIndex = 21;
            // 
            // lblInfoCarte
            // 
            this.lblInfoCarte.AutoSize = true;
            this.lblInfoCarte.Location = new System.Drawing.Point(393, 128);
            this.lblInfoCarte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfoCarte.Name = "lblInfoCarte";
            this.lblInfoCarte.Size = new System.Drawing.Size(115, 13);
            this.lblInfoCarte.TabIndex = 22;
            this.lblInfoCarte.Text = "Information de la carte ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HackatonMagic.Properties.Resources.dice;
            this.pictureBox1.Location = new System.Drawing.Point(190, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // btnSearchCard
            // 
            this.btnSearchCard.Image = global::HackatonMagic.Properties.Resources.search;
            this.btnSearchCard.Location = new System.Drawing.Point(537, 92);
            this.btnSearchCard.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchCard.Name = "btnSearchCard";
            this.btnSearchCard.Size = new System.Drawing.Size(25, 22);
            this.btnSearchCard.TabIndex = 23;
            this.btnSearchCard.UseVisualStyleBackColor = true;
            this.btnSearchCard.Click += new System.EventHandler(this.btnSearchCard_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HackatonMagic.Properties.Resources.spinedown20;
            this.pictureBox2.Location = new System.Drawing.Point(191, 130);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
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
            this.Controls.Add(this.btnMinusJ2);
            this.Controls.Add(this.btnPlusJ2);
            this.Controls.Add(this.btnPlusJ1);
            this.Controls.Add(this.btnMinusJ1);
            this.Controls.Add(this.lblPVJ2);
            this.Controls.Add(this.lblPVJ1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Hackaton Magic";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPVJ1;
        private System.Windows.Forms.Label lblPVJ2;
        private System.Windows.Forms.Button btnMinusJ1;
        private System.Windows.Forms.Button btnPlusJ1;
        private System.Windows.Forms.Button btnPlusJ2;
        private System.Windows.Forms.Button btnMinusJ2;
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
    }
}

