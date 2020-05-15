using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackatonMagic
{
    public partial class AddCounter : Form
    {
        public string _cardName { get; set; } 
        public string _counterType { get; set; }
        public int _nbreCounter { get; set; }
        public AddCounter()
        {
            InitializeComponent();

            // Ajout des options dans la combo box
            cbType.Items.Add("+1/+1 counter");
            cbType.Items.Add("-1/-1 counter");
            cbType.Items.Add("Charge counter");
            cbType.Items.Add("Loyalty counter");
            cbType.Items.Add("Energy counter");
            cbType.Items.Add("Experience counter");
            cbType.Items.Add("Poison counter");
            cbType.Items.Add("Time counter");
        }

        // Action du bouton pour valider la création du marqueur 
        private void btnValidate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCardName.Text) || string.IsNullOrWhiteSpace(txtNbreCounter.Text)|| cbType.SelectedIndex.Equals(-1))
            {
                lblInfoValidate.Text = "Entrer toutes les informations !";
            }
            else
            {
                this._cardName = txtCardName.Text;
                this._counterType = cbType.SelectedItem.ToString();
                this._nbreCounter = int.Parse(txtNbreCounter.Text);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }
    }
}
