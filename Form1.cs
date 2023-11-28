using System;
using System.Windows.Forms;

namespace League
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlayersForm playersForm = new PlayersForm();
            playersForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersonalForm personalForm = new PersonalForm();
            personalForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ContractForm contractForm = new ContractForm();
            contractForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StatusForm statusForm = new StatusForm();
            statusForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ProgressForm progressForm = new ProgressForm();
            progressForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
