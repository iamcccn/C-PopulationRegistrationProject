using System;
using System.Windows.Forms;

namespace PopulationCountry.so
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void butt_Click(object sender, EventArgs e)
        {

            Form2 frm = new Form2();

            frm.Show();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
