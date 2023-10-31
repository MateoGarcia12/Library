using libreria.Controllers;

namespace libreria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UserController.authenticateUser(textBox1.Text, textBox2.Text))


            {
                Index index = new Index();
                index.Show();
                this.Hide();

            }

        }
    }
}