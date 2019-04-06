using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class BorrowersUserControl : UserControl
    {
        public BorrowersUserControl()
        {
            InitializeComponent();
        }

        private void BorrowersUserControl_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            BorrowersIdFied.Text = null;
            AccNoField.Text = null;
        }
    }
}
