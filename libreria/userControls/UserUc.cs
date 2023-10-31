using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using libreria.Context;
using libreria.Controllers;
using libreria.Models;

namespace libreria.userControls
{
    public partial class UserUc : UserControl
    {
        public UserUc()
        {
            InitializeComponent();
            loadUsers();

        }

        private void loadUsers()
        {
            var context = new AppDbContext();
            var users = new BindingList<User>(context.Users.ToList());
            userBindingSource.DataSource = users;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dataGridView1.Columns["Edit"].Index)
                {
                    int userId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["UserId"].Value);
                    User user = UserController.getById(userId);
                    FormUser editUserForm = new FormUser(user); // Pass the user ID to the edit form constructor
                    DialogResult editResult = editUserForm.ShowDialog();
                    if (editResult == DialogResult.OK)
                    {
                        loadUsers();

                    }


                }

                if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index)
                {
                    int userId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["UserId"].Value);
                    UserController.deleteUser(userId);
                    loadUsers();
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormUser formuser = new FormUser();
            DialogResult create = formuser.ShowDialog();
            if (create == DialogResult.OK)
            {
                loadUsers();
            }
        }
    }
}

