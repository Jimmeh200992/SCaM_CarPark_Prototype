using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCaM_CarPark_Prototype
{
    public partial class CardPaymentForm : Form
    {
        public CardPaymentForm()
        {
            InitializeComponent();
        }

        private void btnPayCash_Click(object sender, EventArgs e)
        {
            (new CashPaymentForm()).Show();
            this.Hide();
        }
    }
}
