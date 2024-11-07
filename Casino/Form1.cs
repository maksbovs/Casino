using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casino
{
    public partial class lbl_ : Form
    {
        public lbl_()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        Random rnd=new Random();
        int a, b, c, move;

        private void pictureBox1_Click_3(object sender, EventArgs e)
        {

        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please press the Bid button key & enter the Bid Amount inside the textbox to play..");
            }
            else {
                timer1.Enabled = true;
                lbl_casino.Text = "Casino";
                textBox1.Enabled = false;
                textBox1.BackColor = Color.Black;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            move++;
            if(move<30)
            {
                a = rnd.Next(5);
                b = rnd.Next(5);
                c = rnd.Next(5);
                switch (a)
                {
                    case 1:
                        pictureBox1.Image = Properties.Resources.Gold;
                        break;
                    case 2:
                        pictureBox1.Image = Properties.Resources.Silver;
                        break;
                    case 3:
                        pictureBox1.Image = Properties.Resources.Bronze;
                        break;
                }
                switch (b)
                {
                    case 1:
                        pictureBox2.Image = Properties.Resources.Gold;
                        break;
                    case 2:
                        pictureBox2.Image = Properties.Resources.Silver;
                        break;
                    case 3:
                        pictureBox2.Image = Properties.Resources.Bronze;
                        break;

                }
                switch (c)
                {
                    case 1:
                        pictureBox3.Image = Properties.Resources.Gold;
                        break;
                    case 2:
                        pictureBox3.Image = Properties.Resources.Silver;
                        break;
                    case 3:
                        pictureBox3.Image = Properties.Resources.Bronze;
                        break;
                }
            }
            else
            {
                timer1.Enabled = false;
                move = 0;
            }
        }
    }
}
