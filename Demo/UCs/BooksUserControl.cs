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
    public partial class BooksUserControl : UserControl
    {
        public BooksUserControl()
        {
            InitializeComponent();
            BooksdataGridView();
        }

        private void BooksUserControl_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SearchAccNoField.Text = null;
            SearchAuthorField.Text = null;
            AccNoField.Text = null;
            BookNameField.Text = null;
            AuthorNameField.Text = null;
            PublisherField.Text = null;
            IsbnField.Text = null;
            DepartmentField.Text = null;
        }
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\DemoDatabase.mdf\";Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {

            String a=AccNoField.Text;
            String b=BookNameField.Text;
            String c=AuthorNameField.Text;
            String d=PublisherField.Text;
            String ee=IsbnField.Text;
            String f=DepartmentField.Text;
            
            if(a!=""&&b!=""&&c!=""&&d!=""&&ee!=""&&f!="")
            {
                SqlCommand cmd = new SqlCommand("AddBooks_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@accNo", AccNoField.Text);
                cmd.Parameters.AddWithValue("@isbn", IsbnField.Text);
                cmd.Parameters.AddWithValue("@Name", BookNameField.Text);
                cmd.Parameters.AddWithValue("@Author", AuthorNameField.Text);
                cmd.Parameters.AddWithValue("@publisher", PublisherField.Text);
                cmd.Parameters.AddWithValue("@dept_id", DepartmentField.Text);

                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    AddedLabel.ForeColor = Color.DarkGreen;
                    AddedLabel.Text = "Book added successfully!";
                    AddedLabel.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
                con.Close();
                BooksdataGridView();
            }
            else
            {
                AddedLabel.ForeColor = Color.Red;
                AddedLabel.Text = "Values cannot be empty!";
                AddedLabel.Show();
                
            }
        }

        public void BooksdataGridView()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("BooksView_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception er)
                {
                    MessageBox.Show("" + er);
                }
                con.Close();
                dataGridView1.DataSource = ds.Tables[0];
                this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch(Exception er)
            {
                MessageBox.Show("" + er);
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
