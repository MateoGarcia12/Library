using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libreria.userControls;

namespace libreria
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
           
            if (Program.logged.IsAdmin != true)
            {

                button2.Hide();
            }
        }

        private void Index_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserUc userUc = new UserUc();
            addUserControl(userUc);
        }

        private void addUserControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
            uc.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BooksUc booksUc = new BooksUc();
            addUserControl(booksUc);
        }
    }
}
