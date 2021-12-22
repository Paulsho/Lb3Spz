using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace lb3
{
    public partial class MainView : Form
    {
        private BindingSource _bsTasks, _bsComputers;
        public MainView()
        {
            InitializeComponent();

            _bsTasks = new BindingSource();
            _bsComputers = new BindingSource();

            _bsTasks.DataSource = ComputerManager.Tasks.Keys.ToList();
            lbTasks.DataSource = _bsTasks;

            _bsComputers.DataSource = ComputerManager.Computers;
            lbComputers.DataSource = _bsComputers;

            dgActiveTasks.DefaultCellStyle.BackColor = Color.Green;
        }

        private void btAddTask_Click(object sender, EventArgs e)
        {
            var dialog = new EditView();
            dialog.dgData.DataSource = _bsTasks;
            dialog.ShowDialog();
        }

        private void btAddComputer_Click(object sender, EventArgs e)
        {
            if (ComputerManager.AmountComputers > ComputerManager.Computers.Count)
            {
                var dialog = new EditView();
                dialog.dgData.DataSource = _bsComputers;
                dialog.ShowDialog();
            }
            else 
                MessageBox.Show("Недостатньо комп'ютерів!", "Помилка!");

        }

        private void btExecute_Click(object sender, EventArgs e)
        {
            var chTask = (Task)lbTasks.SelectedItem;
            try
            {
                ComputerManager.SetTask(chTask, (Computer)lbComputers.SelectedItem);
                RefreshDg();
                chTask.OnComplete += ChTask_OnComplete;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Помилка!");
            }
        }

        private void ChTask_OnComplete(Task task)
        {
            RefreshDg();
        }

        private void RefreshDg()
        {
            if(dgActiveTasks.InvokeRequired)
            {
                Action refresh = delegate { RefreshDg(); };
                dgActiveTasks.Invoke(refresh);
            }
            else
            {
                dgActiveTasks.DataSource = ComputerManager.Tasks.ToList();
            }
        }
        private void lbTasks_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var dialog = new EditView();
            dialog.dgData.DataSource = _bsTasks;
            dialog.ShowDialog();
        }

        private void lbComputers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var dialog = new EditView();
            dialog.dgData.DataSource = _bsComputers;
            dialog.ShowDialog();
        }
        private void numComputers_ValueChanged(object sender, EventArgs e)
        {
            ComputerManager.AmountComputers = (int)numComputers.Value;
        }

        private void numWorkPlaces_ValueChanged(object sender, EventArgs e)
        {
            ComputerManager.AmountWorkplaces = (int)numWorkPlaces.Value;
        }

        private void chbRouter_CheckedChanged(object sender, EventArgs e)
        {
            lPasswordOut.Enabled = !lPasswordOut.Enabled;
            var pass = new Random();
            if (lPasswordOut.Enabled)
                lPasswordOut.Text = pass.Next(1000, 9999).ToString();
            else
                lPasswordOut.Text = string.Empty;
        }


        private void MainView_Load(object sender, EventArgs e)
        {
            var dialog = new StartView();
            dialog.ShowDialog();

            if (dialog.DialogResult != DialogResult.OK) 
                this.Close();
            else 
                lManagerOut.Text = dialog.iName;
        }

    }
}
