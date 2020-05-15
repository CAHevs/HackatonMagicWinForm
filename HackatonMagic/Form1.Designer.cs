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
            this.lblPVJ1 = new System.Windows.Forms.Label();
            this.lblPVJ2 = new System.Windows.Forms.Label();
            this.btnMinusJ1 = new System.Windows.Forms.Button();
            this.btnPlusJ1 = new System.Windows.Forms.Button();
            this.btnPlusJ2 = new System.Windows.Forms.Button();
            this.btnMinusJ2 = new System.Windows.Forms.Button();
            this.txtNameP1 = new System.Windows.Forms.TextBox();
            this.txtNameP2 = new System.Windows.Forms.TextBox();
            this.lblDice6 = new System.Windows.Forms.Label();
            this.lblDice20 = new System.Windows.Forms.Label();
            this.lblDice6Value = new System.Windows.Forms.Label();
            this.lblDice20Value = new System.Windows.Forms.Label();
            this.lblDiceXValue = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtDiceX = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPVJ1
            // 
            this.lblPVJ1.AutoSize = true;
            this.lblPVJ1.Location = new System.Drawing.Point(336, 25);
            this.lblPVJ1.Name = "lblPVJ1";
            this.lblPVJ1.Size = new System.Drawing.Size(24, 17);
            this.lblPVJ1.TabIndex = 0;
            this.lblPVJ1.Text = "20";
            // 
            // lblPVJ2
            // 
            this.lblPVJ2.AutoSize = true;
            this.lblPVJ2.Location = new System.Drawing.Point(605, 25);
            this.lblPVJ2.Name = "lblPVJ2";
            this.lblPVJ2.Size = new System.Drawing.Size(24, 17);
            this.lblPVJ2.TabIndex = 1;
            this.lblPVJ2.Text = "20";
            // 
            // btnMinusJ1
            // 
            this.btnMinusJ1.Location = new System.Drawing.Point(256, 22);
            this.btnMinusJ1.Name = "btnMinusJ1";
            this.btnMinusJ1.Size = new System.Drawing.Size(75, 23);
            this.btnMinusJ1.TabIndex = 2;
            this.btnMinusJ1.Text = "-";
            this.btnMinusJ1.UseVisualStyleBackColor = true;
            this.btnMinusJ1.Click += new System.EventHandler(this.btnMinusJ1_Click);
            // 
            // btnPlusJ1
            // 
            this.btnPlusJ1.Location = new System.Drawing.Point(367, 22);
            this.btnPlusJ1.Name = "btnPlusJ1";
            this.btnPlusJ1.Size = new System.Drawing.Size(75, 23);
            this.btnPlusJ1.TabIndex = 3;
            this.btnPlusJ1.Text = "+";
            this.btnPlusJ1.UseVisualStyleBackColor = true;
            this.btnPlusJ1.Click += new System.EventHandler(this.btnPlusJ1_Click);
            // 
            // btnPlusJ2
            // 
            this.btnPlusJ2.Location = new System.Drawing.Point(636, 22);
            this.btnPlusJ2.Name = "btnPlusJ2";
            this.btnPlusJ2.Size = new System.Drawing.Size(75, 23);
            this.btnPlusJ2.TabIndex = 4;
            this.btnPlusJ2.Text = "+";
            this.btnPlusJ2.UseVisualStyleBackColor = true;
            this.btnPlusJ2.Click += new System.EventHandler(this.btnPlusJ2_Click);
            // 
            // btnMinusJ2
            // 
            this.btnMinusJ2.Location = new System.Drawing.Point(525, 22);
            this.btnMinusJ2.Name = "btnMinusJ2";
            this.btnMinusJ2.Size = new System.Drawing.Size(75, 23);
            this.btnMinusJ2.TabIndex = 5;
            this.btnMinusJ2.Text = "-";
            this.btnMinusJ2.UseVisualStyleBackColor = true;
            this.btnMinusJ2.Click += new System.EventHandler(this.btnMinusJ2_Click);
            // 
            // txtNameP1
            // 
            this.txtNameP1.Location = new System.Drawing.Point(255, 64);
            this.txtNameP1.Name = "txtNameP1";
            this.txtNameP1.Size = new System.Drawing.Size(186, 22);
            this.txtNameP1.TabIndex = 6;
            this.txtNameP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNameP2
            // 
            this.txtNameP2.Location = new System.Drawing.Point(524, 64);
            this.txtNameP2.Name = "txtNameP2";
            this.txtNameP2.Size = new System.Drawing.Size(186, 22);
            this.txtNameP2.TabIndex = 7;
            this.txtNameP2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDice6
            // 
            this.lblDice6.AutoSize = true;
            this.lblDice6.Location = new System.Drawing.Point(256, 120);
            this.lblDice6.Name = "lblDice6";
            this.lblDice6.Size = new System.Drawing.Size(46, 17);
            this.lblDice6.TabIndex = 8;
            this.lblDice6.Text = "dice 6";
            // 
            // lblDice20
            // 
            this.lblDice20.AutoSize = true;
            this.lblDice20.Location = new System.Drawing.Point(256, 151);
            this.lblDice20.Name = "lblDice20";
            this.lblDice20.Size = new System.Drawing.Size(54, 17);
            this.lblDice20.TabIndex = 9;
            this.lblDice20.Text = "dice 20";
            // 
            // lblDice6Value
            // 
            this.lblDice6Value.AutoSize = true;
            this.lblDice6Value.Location = new System.Drawing.Point(364, 120);
            this.lblDice6Value.Name = "lblDice6Value";
            this.lblDice6Value.Size = new System.Drawing.Size(13, 17);
            this.lblDice6Value.TabIndex = 11;
            this.lblDice6Value.Text = "-";
            // 
            // lblDice20Value
            // 
            this.lblDice20Value.AutoSize = true;
            this.lblDice20Value.Location = new System.Drawing.Point(364, 151);
            this.lblDice20Value.Name = "lblDice20Value";
            this.lblDice20Value.Size = new System.Drawing.Size(13, 17);
            this.lblDice20Value.TabIndex = 12;
            this.lblDice20Value.Text = "-";
            // 
            // lblDiceXValue
            // 
            this.lblDiceXValue.AutoSize = true;
            this.lblDiceXValue.Location = new System.Drawing.Point(364, 183);
            this.lblDiceXValue.Name = "lblDiceXValue";
            this.lblDiceXValue.Size = new System.Drawing.Size(13, 17);
            this.lblDiceXValue.TabIndex = 13;
            this.lblDiceXValue.Text = "-";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(309, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Roll";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(309, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Roll";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(309, 180);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(49, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Roll";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txtDiceX
            // 
            this.txtDiceX.Location = new System.Drawing.Point(259, 180);
            this.txtDiceX.Name = "txtDiceX";
            this.txtDiceX.Size = new System.Drawing.Size(44, 22);
            this.txtDiceX.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDiceX);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblDiceXValue);
            this.Controls.Add(this.lblDice20Value);
            this.Controls.Add(this.lblDice6Value);
            this.Controls.Add(this.lblDice20);
            this.Controls.Add(this.lblDice6);
            this.Controls.Add(this.txtNameP2);
            this.Controls.Add(this.txtNameP1);
            this.Controls.Add(this.btnMinusJ2);
            this.Controls.Add(this.btnPlusJ2);
            this.Controls.Add(this.btnPlusJ1);
            this.Controls.Add(this.btnMinusJ1);
            this.Controls.Add(this.lblPVJ2);
            this.Controls.Add(this.lblPVJ1);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Label lblDice6;
        private System.Windows.Forms.Label lblDice20;
        private System.Windows.Forms.Label lblDice6Value;
        private System.Windows.Forms.Label lblDice20Value;
        private System.Windows.Forms.Label lblDiceXValue;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtDiceX;
    }
}

