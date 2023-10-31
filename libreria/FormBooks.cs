using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libreria.Context;
using libreria.Models;
using Microsoft.EntityFrameworkCore;

namespace libreria
{
    public partial class FormBooks : Form
    {
        string situacion;
        int idEdit;
        string fileName;
        public FormBooks()
        {
            InitializeComponent();
            dateTimePicker1.MaxDate = DateTime.Today;
            loadTags();
            loadAuthors();
            situacion = "creacion";


        }

        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image Files (*.png;*.jpg;*.jpeg;*.gif;*.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp";
            openFileDialog.Title = "Select an Image File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filePath = openFileDialog.FileName;
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(filePath);
                    string destinationPath = Path.Combine(Application.StartupPath, "img", fileName);
                    File.Copy(filePath, destinationPath);


                    // Set the selected file as the image for the PictureBox
                    pictureBox1.Image = new Bitmap(openFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading the image: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void loadTags()
        {
            try
            {
                var context = new AppDbContext();

                var availableTags = context.Tags.Select(tag => tag.TagId).ToList();

                checkedListBox1.DataSource = availableTags;

            }
            catch (Exception e)
            {

                throw new Exception("something went wrong while loading the tags: " + e.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var selectedTags = new List<string>();
            foreach (var item in checkedListBox1.CheckedItems)
            {
                selectedTags.Add(item.ToString());
            }

            // Limit to 5 tags
            if (selectedTags.Count > 5)
            {
                MessageBox.Show("Please select up to 5 tags.");
                return;
            }

            var selectedAuthors = new List<string>();
            foreach (var item in checkedListBox2.CheckedItems)
            {
                selectedAuthors.Add(item.ToString());
            }

            // Limit to 5 tags
            if (selectedAuthors.Count > 3)
            {
                MessageBox.Show("Please select up to 3 authors.");
                return;
            }
        }

        private void loadAuthors()
        {
            try
            {
                var context = new AppDbContext();

                var authors = context.Authors.ToList();

                // Set the DisplayMember and ValueMember properties of CheckedListBox
                checkedListBox2.DisplayMember = "Name"; // Replace "Name" with the actual property name in your Author class representing the author's name
                checkedListBox2.ValueMember = "AuthorId"; // Replace "AuthorId" with the actual property name in your Author class representing the author's ID

                // Bind the CheckedListBox to the list of authors
                checkedListBox2.DataSource = authors;
                checkedListBox2.ValueMember = "AuthorId";
            }
            catch (Exception e)
            {

                throw new Exception("something went wrong while loading the tags: " + e.Message);
            }
        }

        private void create()
        {
            try
            {
                Book book = new Book
                {
                    Title = textBox1.Text,
                    Description = textBox2.Text,
                    PublishedOn = dateTimePicker1.Value,
                    Publisher = textBox3.Text,
                    Price = Convert.ToDecimal(textBox4.Text),
                    ImageUrl = $"img/{fileName}"

                };
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
