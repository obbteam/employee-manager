
namespace _00014809
{
    partial class SwipeListForm
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
            this.components = new System.ComponentModel.Container();
            this.AddBtn = new System.Windows.Forms.Button();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.swipeDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.swipeInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.swipeOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.swipeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swipeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddBtn.Location = new System.Drawing.Point(163, 358);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(304, 49);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RefreshBtn.Location = new System.Drawing.Point(473, 358);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(304, 49);
            this.RefreshBtn.TabIndex = 4;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoGenerateColumns = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.employeeIDDataGridViewTextBoxColumn,
            this.swipeDateDataGridViewTextBoxColumn,
            this.swipeInDataGridViewTextBoxColumn,
            this.swipeOutDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.swipeBindingSource;
            this.dgv.Location = new System.Drawing.Point(12, 12);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 62;
            this.dgv.RowTemplate.Height = 28;
            this.dgv.Size = new System.Drawing.Size(937, 313);
            this.dgv.TabIndex = 5;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // swipeDateDataGridViewTextBoxColumn
            // 
            this.swipeDateDataGridViewTextBoxColumn.DataPropertyName = "SwipeDate";
            this.swipeDateDataGridViewTextBoxColumn.HeaderText = "SwipeDate";
            this.swipeDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.swipeDateDataGridViewTextBoxColumn.Name = "swipeDateDataGridViewTextBoxColumn";
            this.swipeDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // swipeInDataGridViewTextBoxColumn
            // 
            this.swipeInDataGridViewTextBoxColumn.DataPropertyName = "SwipeIn";
            this.swipeInDataGridViewTextBoxColumn.HeaderText = "SwipeIn";
            this.swipeInDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.swipeInDataGridViewTextBoxColumn.Name = "swipeInDataGridViewTextBoxColumn";
            this.swipeInDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // swipeOutDataGridViewTextBoxColumn
            // 
            this.swipeOutDataGridViewTextBoxColumn.DataPropertyName = "SwipeOut";
            this.swipeOutDataGridViewTextBoxColumn.HeaderText = "SwipeOut";
            this.swipeOutDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.swipeOutDataGridViewTextBoxColumn.Name = "swipeOutDataGridViewTextBoxColumn";
            this.swipeOutDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // swipeBindingSource
            // 
            this.swipeBindingSource.DataSource = typeof(_00014809.DAL.Swipe);
            // 
            // SwipeListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 450);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.AddBtn);
            this.Name = "SwipeListForm";
            this.Text = "SwipeListForm";
            this.Load += new System.EventHandler(this.SwipeListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swipeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource swipeBindingSource;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn swipeDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn swipeInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn swipeOutDataGridViewTextBoxColumn;
    }
}