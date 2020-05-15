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
    public partial class Form1 : Form
    {
        string cardName;
        string counterType;
        int nbreCounter;
        int minute = 0;
        int hour = 0;
        int second = 0;
        public Form1()
        {
            InitializeComponent();
            //Ajout de l'event sur le changement de valeur des NumericUpAndDown
            nupJ1.ValueChanged += new EventHandler(lifeChanged);
            nupJ2.ValueChanged += new EventHandler(lifeChanged);
        }
        
        // Méthode permettant de simuler un lancer de dé
        // Paramètre : 
        // int dice : donne la valeur du dé (6, 20 ou X)
        private int RollDice(int dice)
        {
            int value = 0;
            Random rnd = new Random();

            value = rnd.Next(1, dice + 1);

            return value;
        }

        // Méthode qui permet de "démarrer" une partie. Ajoute un Event sur le timer
        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            gameTime.Tick += new EventHandler(gameTime_Tick);
            gameTime.Start();
        }

        // Méthode du timer qui incrémente une variable second et affiche le résultat dans lblTime
        private void gameTime_Tick(object sender, EventArgs e)
        {
            second++;
            if(second == 60)
            {
                minute++;
                second = 0;
            }
            if (minute == 60)
            {
                hour++;
                minute = 0;
            }
            lblTime.Text = hour.ToString() + ":" + minute.ToString() + ":" + second.ToString();

        }

        // Méthode qui permet de vérifier, lors du changement de valeur de point de vie si l'un des deux joueurs a perdu
        private void lifeChanged(object sender, EventArgs e)
        {
            if (nupJ1.Value <= 0 || nupJ2.Value <= 0)
            {
                gameEnded();
            }
        }

        // Méthode qui permet de finir la partie et de réinitialliser les points de vie et le timer
        private void gameEnded()
        {
            gameTime.Stop();
            btnStart.Enabled = true;
            second = 0;
            lblTime.Text = "-";
            nupJ1.Value = 20;

        }

        // Appelle la méthode RollDice avec la valeur 6 et affiche le résultat dans lblDice6Value
        private void btnRoll6_Click(object sender, EventArgs e)
        {
            lblDice6Value.Text = RollDice(6).ToString();
        }

        // Appelle la méthode RollDice avec la valeur 20 et affiche le résultat dans lblDice20Value
        private void btnRoll20_Click(object sender, EventArgs e)
        {
            lblDice20Value.Text = RollDice(20).ToString();
        }

        // Appelle la méthode RollDice avec la valeur du txtDiceX et affiche le résultat dans lblDiceXValue
        private void BtnRollX_Click(object sender, EventArgs e)
        {
            int diceX;
            if(int.TryParse(txtDiceX.Text, out diceX))
            {
                lblDiceXValue.Text = RollDice(diceX).ToString();
            }
        }

        // Méthode pour aller chercher une carte dans la bd et afficher les info dans lblInfoCard
        private void btnSearchCard_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Méthode pour diminuer de un le compteur Storm
        private void button2_Click(object sender, EventArgs e)
        {
            var Stormvalue = Int32.Parse(StormTxt.Text);
            if (Stormvalue > 0)
            {
                Stormvalue--;
            }
            StormTxt.Text = Stormvalue.ToString();
        }

        // Méthode pour augmenter de un le compteur Storm
        private void StormPlus_Click_1(object sender, EventArgs e)
        {
            var Stormvalue =  Int32.Parse(StormTxt.Text);
            Stormvalue++;
            StormTxt.Text = Stormvalue.ToString(); 
        }

        // Méthode pour diminuer de un le compteur Blue
        private void BlueMinus_Click_1(object sender, EventArgs e)
        {
            var BlueValue = Int32.Parse(BlueTxT.Text);
            if (BlueValue > 0)
            {
                BlueValue--;
            }
            BlueTxT.Text = BlueValue.ToString();
        }

        // Méthode pour augmenter de un le compteur Blue
        private void BluePlus_Click_1(object sender, EventArgs e)
        {
            var Bluevalue = Int32.Parse(BlueTxT.Text);
            Bluevalue++;
            BlueTxT.Text = Bluevalue.ToString();
        }

        // Méthode pour diminuer de un le compteur White
        private void WhiteMinus_Click_1(object sender, EventArgs e)
        {
            var WhiteValue = Int32.Parse(WhiteTxt.Text);
            if (WhiteValue > 0)
            {
                WhiteValue--;
            }
            WhiteTxt.Text = WhiteValue.ToString();
        }

        // Méthode pour augmenter de un le compteur White
        private void WhitePlus_Click_1(object sender, EventArgs e)
        {
            var WhiteValue = Int32.Parse(WhiteTxt.Text);
            WhiteValue++;
            WhiteTxt.Text = WhiteValue.ToString();
        }

        // Méthode pour diminuer de un le compteur Black
        private void BlackMinus_Click_1(object sender, EventArgs e)
        {
            var BlackValue = Int32.Parse(BlackTxt.Text);
            if (BlackValue > 0)
            {
                BlackValue--;
            }
            BlackTxt.Text = BlackValue.ToString();
        }

        // Méthode pour augmenter de un le compteur Black
        private void BlackPlus_Click_1(object sender, EventArgs e)
        {
            var BlackValue = Int32.Parse(BlackTxt.Text);
            BlackValue++;
            BlackTxt.Text = BlackValue.ToString();
        }

        // Méthode pour diminuer de un le compteur Red
        private void RedMinus_Click_1(object sender, EventArgs e)
        {
            var RedValue = Int32.Parse(RedTxt.Text);
            if (RedValue > 0)
            {
                RedValue--;
            }
            RedTxt.Text = RedValue.ToString();
        }

        // Méthode pour augmenter de un le compteur Red
        private void RedPlus_Click_1(object sender, EventArgs e)
        {
            var RedValue = Int32.Parse(RedTxt.Text);
            RedValue++;
            RedTxt.Text = RedValue.ToString();
        }

        // Méthode pour diminuer de un le compteur Green
        private void GreenMinus_Click_1(object sender, EventArgs e)
        {
            var GreenValue = Int32.Parse(GreenTxt.Text);
            if (GreenValue > 0)
            {
                GreenValue--;
            }
            GreenTxt.Text = GreenValue.ToString();
        }

        // Méthode pour augmenter de un le compteur Green
        private void GreenPlus_Click_1(object sender, EventArgs e)
        {
            var GreenValue = Int32.Parse(GreenTxt.Text);
            GreenValue++;
            GreenTxt.Text = GreenValue.ToString();
        }

        // Méthode pour diminuer de un le compteur Colorless
        private void ColorlessMinus_Click_1(object sender, EventArgs e)
        {
            var ColorlessValue = Int32.Parse(ColorlessTxt.Text);
            if (ColorlessValue > 0)
            {
                ColorlessValue--;
            }
            ColorlessTxt.Text = ColorlessValue.ToString();
        }

        // Méthode pour augmenter de un le compteur Colorless
        private void ColorlessPlus_Click_1(object sender, EventArgs e)
        {
            var ColorlessValue = Int32.Parse(ColorlessTxt.Text);
            ColorlessValue++;
            ColorlessTxt.Text = ColorlessValue.ToString();
        }
        // Méthode pour ajouter un marqueur d'un type donnée dans une liste déroulante, à une carte choisie par le joueur
        // avec un nombre de marqueur donnée par le joueur
        private void btnAddCounter_Click(object sender, EventArgs e)
        {
            using(var addCounter = new AddCounter())
            {
                var result = addCounter.ShowDialog();
                if(result == DialogResult.OK)
                {
                    cardName = addCounter._cardName;
                    counterType = addCounter._counterType;
                    nbreCounter = addCounter._nbreCounter;
                }
            }
          }

        private void btnAddCounter_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void nupJ1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
