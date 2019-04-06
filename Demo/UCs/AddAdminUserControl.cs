using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Demo
{
    public partial class AddAdminUserControl : UserControl
    {
        public AddAdminUserControl()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            WrongInputLabel.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            WrongInputLabel.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameField_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            String username, password, name,phone, cpassword;
            username = usernameField.Text;           
            password = passwordField.Text;
            cpassword = password2Field.Text;
            name = nameField.Text;
            phone = phoneField.Text;//
            //
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\DemoDatabase.mdf\";Integrated Security=True");

            if(username!="" && password !="" && name!="")
            {
                if (password.Equals(cpassword))
                {
                    //string syntax = "INSERT INTO AdminTable VALUES('" + username + "','" + password + "','" + name + "','" + phone + "');";
                    SqlCommand cmd = new SqlCommand("AdminTable_SP", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    con.Open();
                    try
                    {
                        cmd.ExecuteReader();
                        MessageBox.Show("You're successfully registered");
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show("" + er);
                        con.Close();
                    }
                    con.Close();
                }
                else
                {
                    WrongInputLabel.Text = "Passwords do not match!";
                    WrongInputLabel.Show();
                }
            }
            else
            {
                WrongInputLabel.Text = "Values cannot be empty!";
                WrongInputLabel.Show();
            }
        }

        private void CearButton_Click(object sender, EventArgs e)
        {
            nameField.Text = null;
            usernameField.Text = null;
            phoneField.Text = null;
            passwordField.Text = null;
            password2Field.Text = null;
        }

        private void WrongInputLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
