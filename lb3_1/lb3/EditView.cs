using System;
using System.Windows.Forms;

namespace lb3
{
    public partial class EditView : Form
    {
        public EditView()
        {
            InitializeComponent();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
