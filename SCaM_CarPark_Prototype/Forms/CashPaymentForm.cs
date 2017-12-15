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
    public partial class CashPaymentForm : Form
    {
        public CashPaymentForm()
        {
            InitializeComponent();
        }

        private void btnPayCard_Click(object sender, EventArgs e)
        {
            (new CardPaymentForm()).Show();
            this.Hide();
        }
    }
}
