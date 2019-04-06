using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class MainBody : Form
    {
        BooksUserControl booksUserControl = new BooksUserControl();
        BorrowersUserControl borrowersUserControl = new BorrowersUserControl();
        TransactionsUserControl transactionsUserControl = new TransactionsUserControl();
        SettingsUserControl settingsUserControl = new SettingsUserControl();
        HelpUserControl helpUserControl = new HelpUserControl();
        AboutUserControl aboutUserControl = new AboutUserControl();

        public MainBody()
        {
            InitializeComponent();
            isSlidingPanelExtended = true;
            ExpandSlidingPanelGUI();
            ContentPanel.Controls.Add(booksUserControl);

        }

        private void LogoffButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Thank you for using our software!");
            LoginForm lf = new LoginForm();
            lf.Show();
        }

        Boolean isSlidingPanelExtended;
        const int MinSlidingPanelWidth=55;
        const int MaxSlidingPanelWidth = 170;
        const int MinContentPanelWidth=635;
        const int MaxContentPanelWidth =745;

        private void button1_Click(object sender, EventArgs e)
        { 
            SlidingPanelTimer.Start();
        }

        private void SlidingPanelTimer_Tick(object sender, EventArgs e)
        {
            BooksUserControl booksUserControl = new BooksUserControl();
            if (isSlidingPanelExtended)
            {
                SlidingPanel.Width -= 10;
                ContentPanel.Width += 10;
                
                booksUserControl.Width += 10;
                if (SlidingPanel.Width <= MinSlidingPanelWidth || ContentPanel.Width>=MaxContentPanelWidth)
                {
                    SlidingPanelTimer.Stop();
                    isSlidingPanelExtended = false;
                    RetractSlidingPanelGUI();
                    this.Refresh();
                }
            }
            else
            {
                SlidingPanel.Width += 10;
                ContentPanel.Width -= 10;
                booksUserControl.Width -= 10;
                if (SlidingPanel.Width >= MaxSlidingPanelWidth || ContentPanel.Width<=MinContentPanelWidth)
                {
                    SlidingPanelTimer.Stop();
                    isSlidingPanelExtended = true;
                    ExpandSlidingPanelGUI();
                    this.Refresh();
                }
            }
        }

        public void RetractSlidingPanelGUI()
        {
            SlidTabButton.Text = null;
            BooksTabButton.Text = null;
            BorrowersTabButton.Text = null;
            TransactionTabButton.Text = null;
            SettingsTabButton.Text = null;
            HelpTabButton.Text = null;
            AboutTabButton.Text = null;
            LogoutButton.Text = null;

            SlidTabButton.Image = Properties.Resources.Arrows_Right_Round_icon;
            BooksTabButton.Image = Properties.Resources.Books;
            BorrowersTabButton.Image = Properties.Resources.Borrowers;
            TransactionTabButton.Image = Properties.Resources.Transactions;
            SettingsTabButton.Image = Properties.Resources.Settings;
            HelpTabButton.Image = Properties.Resources.Help;
            AboutTabButton.Image = Properties.Resources.About;
            LogoutButton.Image = Properties.Resources.Logout;
        }

        public void ExpandSlidingPanelGUI()
        {
            SlidTabButton.Text = "Close";
            BooksTabButton.Text = "Books";
            BorrowersTabButton.Text = "Borrowers";
            TransactionTabButton.Text = "Transaction";
            SettingsTabButton.Text = "Settings";
            HelpTabButton.Text = "Help";
            AboutTabButton.Text = "About";
            LogoutButton.Text = "Logout";

            SlidTabButton.Image = Properties.Resources.Arrows_Left_Round_icon;
            BooksTabButton.Image = null;
            BorrowersTabButton.Image = null;
            TransactionTabButton.Image = null;
            SettingsTabButton.Image = null;
            HelpTabButton.Image = null;
            AboutTabButton.Image = null;
            LogoutButton.Image = null;
       }

        private void BooksTabButton_Click(object sender, EventArgs e)
        {
                //BooksUserControl booksUserControl = new BooksUserControl();
                ContentPanel.Controls.Add(booksUserControl);
                booksUserControl.Dock = DockStyle.Fill;
                booksUserControl.BringToFront();
        }

        private void BorrowersTabButton_Click(object sender, EventArgs e)
        {
                //BorrowersUserControl borrowersUserControl = new BorrowersUserControl();
                ContentPanel.Controls.Add(borrowersUserControl);
                borrowersUserControl.Dock = DockStyle.Fill;
                borrowersUserControl.BringToFront();
        }

        private void TransactionTabButton_Click(object sender, EventArgs e)
        {
            //TransactionsUserControl transactionsUserControl = new TransactionsUserControl();
            ContentPanel.Controls.Add(transactionsUserControl);
            transactionsUserControl.Dock = DockStyle.Fill;
            transactionsUserControl.BringToFront();
        }

        private void SettingsTabButton_Click(object sender, EventArgs e)
        {
            //SettingsUserControl settingsUserControl = new SettingsUserControl();
            ContentPanel.Controls.Add(settingsUserControl);
            settingsUserControl.Dock = DockStyle.Fill;
            settingsUserControl.BringToFront();
        }

        private void HelpTabButton_Click(object sender, EventArgs e)
        {
            //HelpUserControl helpUserControl = new HelpUserControl();
            ContentPanel.Controls.Add(helpUserControl);
            helpUserControl.Dock = DockStyle.Fill;
            helpUserControl.BringToFront();
        }

        private void AboutTabButton_Click(object sender, EventArgs e)
        {
            //AboutUserControl aboutUserControl = new AboutUserControl();
            ContentPanel.Controls.Add(aboutUserControl);
            aboutUserControl.Dock = DockStyle.Fill;
            aboutUserControl.BringToFront();
        }

        private void ContentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SlidingPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
