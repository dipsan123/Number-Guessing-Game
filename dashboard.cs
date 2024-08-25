using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Number_Guessing_Game
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();


        }
        public int number; 

        private void start_btn_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            number= rand.Next(1,20);

        }

        private void guess_btn_Click(object sender, EventArgs e)
        {
            int guessd = Int32.Parse(guess_text.Text);
            if (guessd < number) {

                high_or_low.Text = "Too Low!!!";
            }else if(guessd > number)
            {
                high_or_low.Text = "Too High!!!";
            }
            else
            {
                high_or_low.Text = "Correct" + number;
            }
        }

        private void guess_text_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
