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
    public partial class TransactionsUserControl : UserControl
    {
        public TransactionsUserControl()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SearchTransactionNoField.Text = null;
            SearchBorrowersIdField.Text = null;
            BorrowersIdField.Text = null;
            AccessionNoField.Text = null;
            AuthorizedByField.Text = null;
        }
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\DemoDatabase.mdf\";Integrated Security=True");
        private void button7_Click(object sender, EventArgs e)
        {
            String b = AccessionNoField.Text;
            String c = BorrowersIdField.Text;
            String d = AuthorizedByField.Text;

            if (b != "" && c != "" && d != "")
            {
                SqlCommand cmd = new SqlCommand("AddTransaction_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;

                String Check;
                if (HasReturnedCheckBox.Checked == true)
                    Check = "Yes";
                else
                    Check = "No";
                cmd.Parameters.AddWithValue("@Date", DatePicker.Text);
                cmd.Parameters.AddWithValue("@Time", TimePicker.Text);
                cmd.Parameters.AddWithValue("@br_id", BorrowersIdField.Text);
                cmd.Parameters.AddWithValue("@acc_No", AccessionNoField.Text);
                cmd.Parameters.AddWithValue("@Authorized_by", AuthorizedByField.Text);
                cmd.Parameters.AddWithValue("@Return_Date", ReturnDateDatePicker.Text);
                cmd.Parameters.AddWithValue("@Has_returned", Check);

                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    TransactionDoneLabel.ForeColor = Color.DarkGreen;
                    TransactionDoneLabel.Text = "Transaction record saved";
                    TransactionDoneLabel.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
                con.Close();
                TransactiondataGridView();
            }
            else
            {
                TransactionDoneLabel.ForeColor = Color.Red;
                TransactionDoneLabel.Text = "Values cannot be empty!";
                TransactionDoneLabel.Show();

            }
        }

        public void TransactiondataGridView()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("TransactionsView_SP", con);
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
                this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            }
            catch (Exception er)
            {
                MessageBox.Show("" + er);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SearchTransaction_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;

                if (SearchTransactionNoField.Text != "" || SearchBorrowersIdField.Text != "")
                {
                    cmd.Parameters.AddWithValue("@tno", SearchTransactionNoField.Text);
                    cmd.Parameters.AddWithValue("@brid", SearchBorrowersIdField.Text);

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

                    if (ds.Tables[0].DataSet == null)
                    {
                        SearchLabel.ForeColor = Color.Red;
                        SearchLabel.Text = "Not found!";
                        SearchLabel.Show();
                    }
                    else
                    {
                        SearchLabel.ForeColor = Color.DarkGreen;
                        SearchLabel.Text = "Search completed!";
                        SearchLabel.Show();

                        dataGridView1.DataSource = ds.Tables[0];
                        this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        this.dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        this.dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        this.dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        this.dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    }
                }
                else
                {
                    SearchLabel.ForeColor = Color.Red;
                    SearchLabel.Text = "Value is empty!";
                    SearchLabel.Show();
                }
            }
            catch(Exception er)
            {
                MessageBox.Show("" + er);
            }
        }

        private void SearchTransactionNoField_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TransactionsUserControl_Load(object sender, EventArgs e)
        {
            TransactiondataGridView();
        }

        private void SearchTransactionNoField_MouseClick(object sender, MouseEventArgs e)
        {
            SearchLabel.Hide();
        }

        private void SearchBorrowersIdField_MouseClick(object sender, MouseEventArgs e)
        {
            SearchLabel.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            TransactiondataGridView();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {

        }
    }
}
