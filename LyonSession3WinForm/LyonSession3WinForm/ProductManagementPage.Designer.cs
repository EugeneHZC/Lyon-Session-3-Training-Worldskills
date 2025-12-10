namespace LyonSession3WinForm
{
    partial class ProductManagementPage
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
            components = new System.ComponentModel.Container();
            label2 = new Label();
            searchBarTbx = new TextBox();
            dataGridView1 = new DataGridView();
            ProductName = new DataGridViewTextBoxColumn();
            Actions = new DataGridViewLinkColumn();
            Delete = new DataGridViewLinkColumn();
            productBindingSource = new BindingSource(components);
            costDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            activeDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 71);
            label2.Name = "label2";
            label2.Size = new Size(211, 20);
            label2.TabIndex = 1;
            label2.Text = "Search on products/categories";
            // 
            // searchBarTbx
            // 
            searchBarTbx.Location = new Point(28, 100);
            searchBarTbx.Name = "searchBarTbx";
            searchBarTbx.Size = new Size(536, 27);
            searchBarTbx.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { activeDataGridViewCheckBoxColumn, ProductName, categoryDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, costDataGridViewTextBoxColumn, Actions, Delete });
            dataGridView1.Location = new Point(28, 164);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(736, 237);
            dataGridView1.TabIndex = 3;
            // 
            // ProductName
            // 
            ProductName.DataPropertyName = "ProductName";
            ProductName.HeaderText = "Product Name";
            ProductName.MinimumWidth = 6;
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            ProductName.Width = 125;
            // 
            // Actions
            // 
            Actions.HeaderText = "Actions";
            Actions.MinimumWidth = 6;
            Actions.Name = "Actions";
            Actions.ReadOnly = true;
            Actions.Width = 125;
            // 
            // Delete
            // 
            Delete.HeaderText = "";
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Width = 125;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(LyonSession3API.models.Product);
            // 
            // costDataGridViewTextBoxColumn
            // 
            costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            costDataGridViewTextBoxColumn.HeaderText = "Cost";
            costDataGridViewTextBoxColumn.MinimumWidth = 6;
            costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            costDataGridViewTextBoxColumn.ReadOnly = true;
            costDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            categoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            categoryDataGridViewTextBoxColumn.ReadOnly = true;
            categoryDataGridViewTextBoxColumn.Width = 125;
            // 
            // activeDataGridViewCheckBoxColumn
            // 
            activeDataGridViewCheckBoxColumn.DataPropertyName = "Active";
            activeDataGridViewCheckBoxColumn.HeaderText = "Active";
            activeDataGridViewCheckBoxColumn.MinimumWidth = 6;
            activeDataGridViewCheckBoxColumn.Name = "activeDataGridViewCheckBoxColumn";
            activeDataGridViewCheckBoxColumn.ReadOnly = true;
            activeDataGridViewCheckBoxColumn.Width = 125;
            // 
            // ProductManagementPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(searchBarTbx);
            Controls.Add(label2);
            Name = "ProductManagementPage";
            Text = "Product Management";
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(searchBarTbx, 0);
            Controls.SetChildIndex(dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox searchBarTbx;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewLinkColumn Actions;
        private DataGridViewLinkColumn Delete;
        private DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private BindingSource productBindingSource;
    }
}