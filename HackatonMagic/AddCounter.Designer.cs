namespace HackatonMagic
{
    partial class AddCounter
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
            this.btnValidate = new System.Windows.Forms.Button();
            this.lblNomCarte = new System.Windows.Forms.Label();
            this.lblTypeMarqueur = new System.Windows.Forms.Label();
            this.lblNbreMarqueur = new System.Windows.Forms.Label();
            this.txtCardName = new System.Windows.Forms.TextBox();
            this.txtNbreCounter = new System.Windows.Forms.TextBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lblInfoValidate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(31, 134);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(75, 23);
            this.btnValidate.TabIndex = 0;
            this.btnValidate.Text = "Valider";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // lblNomCarte
            // 
            this.lblNomCarte.AutoSize = true;
            this.lblNomCarte.Location = new System.Drawing.Point(28, 24);
            this.lblNomCarte.Name = "lblNomCarte";
            this.lblNomCarte.Size = new System.Drawing.Size(108, 17);
            this.lblNomCarte.TabIndex = 1;
            this.lblNomCarte.Text = "Nom de la carte";
            // 
            // lblTypeMarqueur
            // 
            this.lblTypeMarqueur.AutoSize = true;
            this.lblTypeMarqueur.Location = new System.Drawing.Point(28, 60);
            this.lblTypeMarqueur.Name = "lblTypeMarqueur";
            this.lblTypeMarqueur.Size = new System.Drawing.Size(125, 17);
            this.lblTypeMarqueur.TabIndex = 2;
            this.lblTypeMarqueur.Text = "Type de marqueur";
            // 
            // lblNbreMarqueur
            // 
            this.lblNbreMarqueur.AutoSize = true;
            this.lblNbreMarqueur.Location = new System.Drawing.Point(28, 94);
            this.lblNbreMarqueur.Name = "lblNbreMarqueur";
            this.lblNbreMarqueur.Size = new System.Drawing.Size(143, 17);
            this.lblNbreMarqueur.TabIndex = 3;
            this.lblNbreMarqueur.Text = "Nombre de marqueur";
            // 
            // txtCardName
            // 
            this.txtCardName.Location = new System.Drawing.Point(190, 21);
            this.txtCardName.Name = "txtCardName";
            this.txtCardName.Size = new System.Drawing.Size(227, 22);
            this.txtCardName.TabIndex = 4;
            this.txtCardName.Text = "Nom de la carte";
            this.txtCardName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNbreCounter
            // 
            this.txtNbreCounter.Location = new System.Drawing.Point(190, 91);
            this.txtNbreCounter.Name = "txtNbreCounter";
            this.txtNbreCounter.Size = new System.Drawing.Size(100, 22);
            this.txtNbreCounter.TabIndex = 6;
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(190, 57);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(227, 24);
            this.cbType.TabIndex = 7;
            // 
            // lblInfoValidate
            // 
            this.lblInfoValidate.AutoSize = true;
            this.lblInfoValidate.Location = new System.Drawing.Point(190, 134);
            this.lblInfoValidate.Name = "lblInfoValidate";
            this.lblInfoValidate.Size = new System.Drawing.Size(0, 17);
            this.lblInfoValidate.TabIndex = 8;
            // 
            // AddCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 177);
            this.Controls.Add(this.lblInfoValidate);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.txtNbreCounter);
            this.Controls.Add(this.txtCardName);
            this.Controls.Add(this.lblNbreMarqueur);
            this.Controls.Add(this.lblTypeMarqueur);
            this.Controls.Add(this.lblNomCarte);
            this.Controls.Add(this.btnValidate);
            this.Name = "AddCounter";
            this.Text = "AddCounter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Label lblNomCarte;
        private System.Windows.Forms.Label lblTypeMarqueur;
        private System.Windows.Forms.Label lblNbreMarqueur;
        private System.Windows.Forms.TextBox txtCardName;
        private System.Windows.Forms.TextBox txtNbreCounter;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label lblInfoValidate;
    }
}