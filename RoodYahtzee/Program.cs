using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoodYahtzee
{
    public class ScoreBlock
    {

    }

    public class Die
    {
        public int Value { get; set; }
        public bool Keep { get; set; }

        public Die()
        {
            Keep = false;
            Value = 0;
        }

        public void RollDie()
        {
            if (Keep == false)
            {
                Random rand = new Random();
                Value = rand.Next(1, 7);
            }
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }

    public class GlobalVars
    {
        public bool InitialRoll { get; set; }

        public GlobalVars()
        {
            InitialRoll = false;
        }
    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new YahtzeePrimaryForm());
        }
    }
}
