using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
            InitializeComponent();//
        }

        //
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\DemoDatabase.mdf\";Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;

        private void button1_Click(object sender, EventArgs e)
        {
            String Username, Password, tempP;
            Username = usernameField.Text;
            Password = passwordField.Text;
            try
            {
                con.Open();
                String syntax = "SELECT password FROM AdminTable WHERE username='" + Username + "'";
                cmd = new SqlCommand(syntax, con);
                try
                {
                    dr = cmd.ExecuteReader();
                    dr.Read();
                }
                catch (Exception)
                {
                    WrongInputLabel.Show();
                    con.Close();
                }
                tempP = dr[0].ToString();
                con.Close();
                if (Password.Equals(tempP))
                {
                    MessageBox.Show("\tWelcome\n\t" + Username);
                    this.Hide();
                    MainBody mb = new MainBody();
                    mb.Show();
                }
                else
                {
                    WrongInputLabel.Show();
                    con.Close();
                }
            }
            catch (Exception)
            {
                WrongInputLabel.Show();
                con.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void usernameField_MouseClick(object sender, MouseEventArgs e)
        {
            WrongInputLabel.Hide();
        }

        private void passwordField_MouseClick(object sender, MouseEventArgs e)
        {
            WrongInputLabel.Hide();
        }
        
        private void usernameField_TextChanged(object sender, EventArgs e)
        {

        }
        AddAdminUserControl addAdminUserControl = new AddAdminUserControl();
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            con.Close();
            CloseAddAdmin.Show();
            AddAdminPanel.Controls.Add(addAdminUserControl);
            addAdminUserControl.Dock = DockStyle.Fill;                        
            addAdminUserControl.BringToFront();
            AddAdminPanel.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AddAdminPanel.Hide();
            CloseAddAdmin.Hide();
        }

        private void AddAdminPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
