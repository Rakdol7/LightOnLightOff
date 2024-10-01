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

        int x = 328;
        int y = 223;
        private void button3_Click(object sender, EventArgs e)
        {
            y = y - 10;
            pictureBox1.Location = new Point(x, y);
            pictureBox2.Location = new Point(x, y);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            y = y + 10;
            pictureBox1.Location = new Point(x, y);
            pictureBox2.Location = new Point(x, y);
        }
    }
}