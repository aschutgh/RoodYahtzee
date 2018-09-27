using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoodYahtzee
{
    public partial class YahtzeePrimaryForm : Form
    {
        public Die Die1;
        public Die Die2;
        public Die Die3;
        public Die Die4;
        public Die Die5;
        public List<Die> Dice;


        public YahtzeePrimaryForm()
        {
            InitializeComponent();
            Die1 = new Die();
            Die2 = new Die();
            Die3 = new Die();
            Die4 = new Die();
            Die5 = new Die();
            Dice = new List<Die>();
            Dice.Add(Die1);
            Dice.Add(Die2);
            Dice.Add(Die3);
            Dice.Add(Die4);
            Dice.Add(Die5);
        }

        private void YahtzeePrimaryForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonRoll_MouseClick(object sender, MouseEventArgs e)
        {
            Random rand = new Random();
            labelDie1.Text = rand.Next(1, 7).ToString();
            labelDie2.Text = rand.Next(1, 7).ToString();
            labelDie3.Text = rand.Next(1, 7).ToString();
            labelDie4.Text = rand.Next(1, 7).ToString();
            labelDie5.Text = rand.Next(1, 7).ToString();
        }
    }
}
