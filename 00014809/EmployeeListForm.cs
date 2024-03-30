using _00014809.DAL;
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
    public partial class EmployeeListForm : Form
    {
        
        public EmployeeListForm()
        {
            InitializeComponent();
        }

        private void EmployeeListForm_Load(object sender, EventArgs e)
        {
            MdiParent = MyForms.GetForm<ParentForm>();
            LoadData();
        }
        public void LoadData()
        {
            dgv.DataMember = "";
            dgv.DataSource = null;
            dgv.DataSource = new EmployeeManager().GetAll();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        //filter employees by is active property and is active false property

        private void Filter_Click(object sender, EventArgs e)
        {
            if (SortOptions.SelectedIndex < 0)
                MessageBox.Show("Select an attribute to search by");
            else if (SortOptions.SelectedIndex == 0)
                LoadData();
            else if (SortOptions.SelectedIndex == 1)
            {
                dgv.DataMember = "";
                dgv.DataSource = null;
                dgv.DataSource = new EmployeeManager().Search(ByAttribute.IsActive);
            }
            else
            {
                dgv.DataMember = "";
                dgv.DataSource = null;
                dgv.DataSource = new EmployeeManager().SearchFalse(ByAttribute.IsActive);
            }
        }

        //sorting by name
        private void SortByName_Click(object sender, EventArgs e)
        {
            dgv.DataMember = "";
            dgv.DataSource = null;
            dgv.DataSource = new EmployeeManager().Sort();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            new EmployeeEditForm().CreateNewEmployee();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
                MessageBox.Show("Please select an Employee");
            else
            {
                var c = (Employee)dgv.SelectedRows[0].DataBoundItem;
                new EmployeeEditForm().UpdateEmployee(c);
            }

        }
        //code was taken from intranet lectures by Vasiliy kuznesov
        //delete button logic
        private void Delete_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
                MessageBox.Show("Please select an employee to delete");
            else
            {
                var c = (Employee)dgv.SelectedRows[0].DataBoundItem;
                new EmployeeManager().Delete(c.Id);
                LoadData();
            }
        }

        private void dgv_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
