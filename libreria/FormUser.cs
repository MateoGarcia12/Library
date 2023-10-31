using libreria.Controllers;
using libreria.Models;

namespace libreria
{

    public partial class FormUser : Form
    {
        string situacion;
        int idEdit;

        public FormUser()
        {
            InitializeComponent();
            situacion = "creacion";
        }

        public FormUser(User user)
        {
            InitializeComponent();
            idEdit = user.UserId;
            username.Text = user.UserName;
            password.Text = user.Password;
            name.Text = user.Name;
            lastName.Text = user.LastName;
            isAdmin.Text = Convert.ToString(user.IsAdmin);

            situacion = "edicion";
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (situacion == "creacion")
            {
                create();
            }

            if (situacion == "edicion")
            {
                edit();
            }

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void create()
        {
            try
            {
                User user = new User
                {
                    UserName = username.Text,
                    Password = password.Text,
                    Name = name.Text,
                    LastName = lastName.Text,
                    IsAdmin = Convert.ToBoolean(isAdmin.Text)
                };

                bool success = UserController.createUser(user);

                if (success)
                {
                    MessageBox.Show("User created");
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Failed to create user");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void edit()
        {
            try
            {
                User user = new User
                {
                    UserId = idEdit,
                    UserName = username.Text,
                    Password = password.Text,
                    Name = name.Text,
                    LastName = lastName.Text,
                    IsAdmin = Convert.ToBoolean(isAdmin.Text)
                };

                bool success = UserController.editUser(user);

                if (success)
                {
                    MessageBox.Show("User edited");
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Failed to edit user");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

