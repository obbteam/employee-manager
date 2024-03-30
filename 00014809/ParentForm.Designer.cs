
namespace _00014809
{
    partial class ParentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AllEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.swipesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewSwipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AllSwipesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.employeesToolStripMenuItem,
            this.swipesToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(141, 34);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewEmployeeToolStripMenuItem,
            this.AllEmployeesToolStripMenuItem});
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(114, 29);
            this.employeesToolStripMenuItem.Text = "Employees";
            // 
            // NewEmployeeToolStripMenuItem
            // 
            this.NewEmployeeToolStripMenuItem.Name = "NewEmployeeToolStripMenuItem";
            this.NewEmployeeToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.NewEmployeeToolStripMenuItem.Text = "New employee";
            this.NewEmployeeToolStripMenuItem.Click += new System.EventHandler(this.NewEmployeeToolStripMenuItem_Click);
            // 
            // AllEmployeesToolStripMenuItem
            // 
            this.AllEmployeesToolStripMenuItem.Name = "AllEmployeesToolStripMenuItem";
            this.AllEmployeesToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.AllEmployeesToolStripMenuItem.Text = "All employees";
            this.AllEmployeesToolStripMenuItem.Click += new System.EventHandler(this.AllEmployeesToolStripMenuItem_Click);
            // 
            // swipesToolStripMenuItem
            // 
            this.swipesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewSwipeToolStripMenuItem,
            this.AllSwipesToolStripMenuItem});
            this.swipesToolStripMenuItem.Name = "swipesToolStripMenuItem";
            this.swipesToolStripMenuItem.Size = new System.Drawing.Size(83, 29);
            this.swipesToolStripMenuItem.Text = "Swipes";
            // 
            // NewSwipeToolStripMenuItem
            // 
            this.NewSwipeToolStripMenuItem.Name = "NewSwipeToolStripMenuItem";
            this.NewSwipeToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.NewSwipeToolStripMenuItem.Text = "New swipe";
            this.NewSwipeToolStripMenuItem.Click += new System.EventHandler(this.NewSwipeToolStripMenuItem_Click);
            // 
            // AllSwipesToolStripMenuItem
            // 
            this.AllSwipesToolStripMenuItem.Name = "AllSwipesToolStripMenuItem";
            this.AllSwipesToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.AllSwipesToolStripMenuItem.Text = "All swipes";
            this.AllSwipesToolStripMenuItem.Click += new System.EventHandler(this.AllSwipesToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(164, 34);
            this.AboutToolStripMenuItem.Text = "About";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ParentForm";
            this.Text = "00014809";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ParentForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AllEmployeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem swipesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewSwipeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AllSwipesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
    }
}