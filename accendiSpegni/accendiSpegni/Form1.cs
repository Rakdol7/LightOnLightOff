using Microsoft.VisualBasic.ApplicationServices;
using System.Windows.Forms;

namespace accendiSpegni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //label1.BackColor = Color.Yellow;
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        //inizializzazione delle coordinate
        int x = 328;
        int y = 223;
        private void button3_Click(object sender, EventArgs e)
        {
            if (y > 0)
            {
                y = y - 10;
                pictureBox1.Location = new Point(x, y);
                pictureBox2.Location = new Point(x, y);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (y < 270)
            {
                y = y + 10;
                pictureBox1.Location = new Point(x, y);
                pictureBox2.Location = new Point(x, y);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            x = 328;
            y = 223;
            pictureBox1.Location = new Point(x, y);
            pictureBox2.Location = new Point(x, y);
        }
    }
}