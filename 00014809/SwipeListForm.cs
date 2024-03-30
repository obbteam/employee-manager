﻿using System;
using _00014809.DAL;
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
    public partial class SwipeListForm : Form
    {
        public SwipeListForm()
        {
            InitializeComponent();
        }

        private void SwipeListForm_Load(object sender, EventArgs e)
        {
            MdiParent = MyForms.GetForm<ParentForm>();
            LoadData();
        }
        public void LoadData()
        {
            dgv.DataMember = "";
            dgv.DataSource = null;
            dgv.DataSource = new SwipeManager().GetAll();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            new SwipeEditForm().CreateNewSwipe();
        }


    }
}
