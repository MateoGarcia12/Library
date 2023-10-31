namespace libreria
{
    partial class FormUser
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
            label1 = new Label();
            label2 = new Label();
            username = new TextBox();
            label3 = new Label();
            password = new TextBox();
            label4 = new Label();
            name = new TextBox();
            label5 = new Label();
            lastName = new TextBox();
            label6 = new Label();
            isAdmin = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(372, 9);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "Add User";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(366, 46);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 1;
            label2.Text = "UserName";
            // 
            // username
            // 
            username.Location = new Point(353, 74);
            username.Name = "username";
            username.Size = new Size(100, 23);
            username.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(372, 109);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 3;
            label3.Text = "Password\r\n";
            label3.Click += label3_Click;
            // 
            // password
            // 
            password.Location = new Point(353, 142);
            password.Name = "password";
            password.Size = new Size(100, 23);
            password.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(372, 177);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 5;
            label4.Text = "Name";
            // 
            // name
            // 
            name.Location = new Point(353, 207);
            name.Name = "name";
            name.Size = new Size(100, 23);
            name.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(368, 242);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 7;
            label5.Text = "LastName";
            // 
            // lastName
            // 
            lastName.Location = new Point(353, 271);
            lastName.Name = "lastName";
            lastName.Size = new Size(100, 23);
            lastName.TabIndex = 8;
            lastName.TextChanged += textBox4_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(372, 313);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 9;
            label6.Text = "IsAdmin";
            // 
            // isAdmin
            // 
            isAdmin.Location = new Point(353, 343);
            isAdmin.Name = "isAdmin";
            isAdmin.Size = new Size(100, 23);
            isAdmin.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(321, 403);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(402, 403);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 12;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FormUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(isAdmin);
            Controls.Add(label6);
            Controls.Add(lastName);
            Controls.Add(label5);
            Controls.Add(name);
            Controls.Add(label4);
            Controls.Add(password);
            Controls.Add(label3);
            Controls.Add(username);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormUser";
            Text = "FormUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox username;
        private Label label3;
        private TextBox password;
        private Label label4;
        private TextBox name;
        private Label label5;
        private TextBox lastName;
        private Label label6;
        private TextBox isAdmin;
        private Button button1;
        private Button button2;
    }
}