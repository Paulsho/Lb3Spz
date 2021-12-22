using System;
using System.Windows.Forms;

namespace lb3
{
    public partial class StartView : Form
    {
        public string iName = "Менеджер";
        public StartView()
        {
            InitializeComponent();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            iName = tbName.Text;
            DialogResult = DialogResult.OK;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
