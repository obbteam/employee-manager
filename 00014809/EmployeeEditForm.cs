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
    public partial class EmployeeEditForm : Form
    {
        public EmployeeEditForm()
        {
            InitializeComponent();
        }

        //code was taken from intranet lectures by Vasiliy kuznesov
        public Employee Employee { get; set; }

        public FormMode Mode { get; set; }
        //code was taken from intranet lectures by Vasiliy kuznesov
        public void CreateNewEmployee()
        {
            Mode = FormMode.CreateNew;
            Employee = new Employee();
            InitializeControls();
            MdiParent = MyForms.GetForm<ParentForm>();
            Show();
        }

        public void UpdateEmployee(Employee employee)
        {
            Mode = FormMode.Update;
            Employee = employee;
            InitializeControls();
            ShowEmployeeInControls();
            MdiParent = MyForms.GetForm<ParentForm>();
            Show();
        }

        private void InitializeControls()
        {
        }

        private void ShowEmployeeInControls()
        {
            NameTxt.Text = Employee.Name;
            IsActiveBox.Checked = Employee.IsActive;
            dateTimePicker1.Value = Employee.StartDate;
            dateTimePicker2.Value = Employee.DischargeDate;

        }

        private void GrabUserInput()
        {
            Employee.Name = NameTxt.Text;
            Employee.IsActive = IsActiveBox.Checked;
            Employee.StartDate = dateTimePicker1.Value;
            Employee.DischargeDate = dateTimePicker2.Value;
        }
     

        

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {

        }
        //validation
        public void NameTxt_TextChanged(object sender, EventArgs e)
        {
            //this code will not allow to the user to put numbers on the textbox.

            if (!System.Text.RegularExpressions.Regex.IsMatch(NameTxt.Text, "^[a-zA-Z ]"))
            {
                MessageBox.Show("This textbox accepts only alphabetical characters");
                NameTxt.Text.Remove(NameTxt.Text.Length - 1);
            }
        }

        private void EmployeeEditForm_Load(object sender, EventArgs e)
        {

        }

        private void EmployeeEditForm_Load_1(object sender, EventArgs e)
        {

        }

        private void CancelBtn_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveBtn_Click_1(object sender, EventArgs e)
        {
            //this code will block user to put number in the textbox name when the user will click on the Save button.
            if (!System.Text.RegularExpressions.Regex.IsMatch(NameTxt.Text, "^[a-zA-Z ]"))
            {
                MessageBox.Show("This textbox accepts only alphabetical characters");
                NameTxt.Text.Remove(NameTxt.Text.Length - 1);
            }

            try
            {
                GrabUserInput();
                var manager = new EmployeeManager();
                if (Mode == FormMode.CreateNew)
                    manager.Create(Employee);
                else
                    manager.Update(Employee);

                MyForms.GetForm<EmployeeListForm>().LoadData();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
