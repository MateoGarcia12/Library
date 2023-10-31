using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libreria.Context;
using libreria.Models;

namespace libreria.userControls
{
    public partial class BooksUc : UserControl
    {
        public BooksUc()
        {
            InitializeComponent();
            loadBooks();
        }

        private void loadBooks()
        {
            var context = new AppDbContext();
            var books = new BindingList<Book>(context.Books.ToList());
            bookBindingSource.DataSource = books;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormBooks formbook = new FormBooks();
            DialogResult create = formbook.ShowDialog();
            if (create == DialogResult.OK)
            {
                loadBooks();
            }
        }
    }
}
