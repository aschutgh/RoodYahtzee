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
        public YahtzeePrimaryForm()
        {
            InitializeComponent();
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
