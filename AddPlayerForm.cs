using System;
using System.IO;
using System.Windows.Forms;

namespace League
{
    public partial class AddPlayerForm : Form
    {
        byte[] img;
        PlayersForm playersForm;
        public AddPlayerForm(PlayersForm form)
        {
            InitializeComponent();
            this.playersForm = form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image files(*.jpeg)|*.jpeg|(*.jpg)|*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    img = File.ReadAllBytes(openFileDialog1.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    img = null;
                    return;
                }
                MessageBox.Show("Файл загружен");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" ||
                textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            byte age = Byte.Parse(numericUpDown1.Value.ToString());
            byte weught = Byte.Parse(numericUpDown2.Value.ToString());
            int status = Int32.Parse(numericUpDown3.Value.ToString());
            int progress = Int32.Parse(numericUpDown4.Value.ToString());
            int contract = Int32.Parse(numericUpDown5.Value.ToString());
            //if (contract == 0) contract = null;
            //if (progress == 0) progress = null;
            playersForm.AddPlayer(textBox1.Text, textBox2.Text, textBox3.Text,
                age, weught,
                textBox4.Text, status, progress, contract,
                img);

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
