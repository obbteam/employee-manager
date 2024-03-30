using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _00014809.DAL;

namespace _00014809
{
    //code was taken from intranet lectures by Vasiliy kuznesov
    public partial class SwipeEditForm : Form
    {
        public SwipeEditForm()
        {
            InitializeComponent();
        }
        public Employee Employee { get; set; }
        //save swipe logic
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
                {
                    GrabUserInput();
                    var manager = new SwipeManager();
                    manager.Create(Swipe);
                

                    MyForms.GetForm<SwipeListForm>().LoadData();
                    Close();
                }
            catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        public Swipe Swipe { get; set; }

        public FormMode Mode { get; set; }
        //new swipe logic

        public void CreateNewSwipe()
        {
            Mode = FormMode.CreateNew;
            Swipe = new Swipe();
            InitializeControls();
            MdiParent = MyForms.GetForm<ParentForm>();
            Show();
        }

       
        private void InitializeControls()
        {
            cbxEmployee.DataSource = new EmployeeManager().GetAll();
        }


        //code was taken from intranet lectures by Vasiliy kuznesov
        private void GrabUserInput()
        {
            Swipe.SwipeDate = dtpDate.Value;
            Swipe.SwipeIn = dtpIn.Value;
            Swipe.SwipeOut = dtpOut.Value;
            Swipe.EmployeeID = cbxEmployee.SelectedIndex;

        }

        private void cbxEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SwipeEditForm_Load(object sender, EventArgs e)
        {

        }
    }
}
