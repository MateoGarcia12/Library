namespace libreria.userControls
{
    partial class BooksUc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            appDbContextBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            bookIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            publishedOnDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            publisherDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            imageUrlDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bookauthorsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceofferDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tagsTagsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            bookBindingSource = new BindingSource(components);
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)appDbContextBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).BeginInit();
            SuspendLayout();
            // 
            // appDbContextBindingSource
            // 
            appDbContextBindingSource.DataSource = typeof(Context.AppDbContext);
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { bookIdDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, publishedOnDataGridViewTextBoxColumn, publisherDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, imageUrlDataGridViewTextBoxColumn, bookauthorsDataGridViewTextBoxColumn, priceofferDataGridViewTextBoxColumn, tagsTagsDataGridViewTextBoxColumn, Edit, Delete });
            dataGridView1.DataSource = bookBindingSource;
            dataGridView1.Location = new Point(0, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(722, 298);
            dataGridView1.TabIndex = 0;
            // 
            // bookIdDataGridViewTextBoxColumn
            // 
            bookIdDataGridViewTextBoxColumn.DataPropertyName = "BookId";
            bookIdDataGridViewTextBoxColumn.HeaderText = "BookId";
            bookIdDataGridViewTextBoxColumn.Name = "bookIdDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Title";
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // publishedOnDataGridViewTextBoxColumn
            // 
            publishedOnDataGridViewTextBoxColumn.DataPropertyName = "PublishedOn";
            publishedOnDataGridViewTextBoxColumn.HeaderText = "PublishedOn";
            publishedOnDataGridViewTextBoxColumn.Name = "publishedOnDataGridViewTextBoxColumn";
            // 
            // publisherDataGridViewTextBoxColumn
            // 
            publisherDataGridViewTextBoxColumn.DataPropertyName = "Publisher";
            publisherDataGridViewTextBoxColumn.HeaderText = "Publisher";
            publisherDataGridViewTextBoxColumn.Name = "publisherDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // imageUrlDataGridViewTextBoxColumn
            // 
            imageUrlDataGridViewTextBoxColumn.DataPropertyName = "ImageUrl";
            imageUrlDataGridViewTextBoxColumn.HeaderText = "ImageUrl";
            imageUrlDataGridViewTextBoxColumn.Name = "imageUrlDataGridViewTextBoxColumn";
            // 
            // bookauthorsDataGridViewTextBoxColumn
            // 
            bookauthorsDataGridViewTextBoxColumn.DataPropertyName = "Bookauthors";
            bookauthorsDataGridViewTextBoxColumn.HeaderText = "Bookauthors";
            bookauthorsDataGridViewTextBoxColumn.Name = "bookauthorsDataGridViewTextBoxColumn";
            // 
            // priceofferDataGridViewTextBoxColumn
            // 
            priceofferDataGridViewTextBoxColumn.DataPropertyName = "Priceoffer";
            priceofferDataGridViewTextBoxColumn.HeaderText = "Priceoffer";
            priceofferDataGridViewTextBoxColumn.Name = "priceofferDataGridViewTextBoxColumn";
            // 
            // tagsTagsDataGridViewTextBoxColumn
            // 
            tagsTagsDataGridViewTextBoxColumn.DataPropertyName = "TagsTags";
            tagsTagsDataGridViewTextBoxColumn.HeaderText = "TagsTags";
            tagsTagsDataGridViewTextBoxColumn.Name = "tagsTagsDataGridViewTextBoxColumn";
            // 
            // Edit
            // 
            Edit.HeaderText = "Edit";
            Edit.Name = "Edit";
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.Name = "Delete";
            // 
            // bookBindingSource
            // 
            bookBindingSource.DataSource = typeof(Models.Book);
            // 
            // button1
            // 
            button1.Location = new Point(634, 21);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Add Book";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // BooksUc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "BooksUc";
            Size = new Size(722, 370);
            ((System.ComponentModel.ISupportInitialize)appDbContextBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource appDbContextBindingSource;
        private DataGridView dataGridView1;
        private BindingSource bookBindingSource;
        private DataGridViewTextBoxColumn bookIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn publishedOnDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn imageUrlDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bookauthorsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceofferDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tagsTagsDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private Button button1;
    }
}
