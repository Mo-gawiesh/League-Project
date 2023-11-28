using System;
using System.Windows.Forms;

namespace League
{
    public partial class PlayersForm : Form
    {
        public PlayersForm()
        {
            InitializeComponent();
        }

        private void PlayersForm_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "leagueDataSet.Player". При необходимости она может быть перемещена или удалена.
                this.playerTableAdapter.Fill(this.leagueDataSet.Player);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void journalBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                bindingSource1.EndEdit();
                this.playerTableAdapter.Update(this.leagueDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AddPlayerForm form = new AddPlayerForm(this);
            form.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                this.playerTableAdapter.FillTop5ByGoals(this.leagueDataSet.Player);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                this.playerTableAdapter.FillTop5ByMatches(this.leagueDataSet.Player);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        public void AddPlayer(string surname, string name, string amplua,
            byte age, byte weight, string cityzen, int status, int progress,
            int contract, byte[] img)
        {
            try
            {
                this.playerTableAdapter.InsertPlayer(surname, name, amplua, age,
                    weight, cityzen,
                    status, progress, contract, img);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
