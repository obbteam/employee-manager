using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _00014809
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var m = new AboutForm();
            m.ShowDialog();
        }

        private void AllEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyForms.GetForm<EmployeeListForm>().Show();
        }

        private void ParentForm_Load(object sender, EventArgs e)
        {

        }

        private void NewEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EmployeeEditForm().CreateNewEmployee();
        }

        private void AllSwipesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyForms.GetForm<SwipeListForm>().Show();
        }

        private void NewSwipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SwipeEditForm().CreateNewSwipe();
        }
    }
}
