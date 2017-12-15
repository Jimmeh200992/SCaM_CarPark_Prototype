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
    public partial class UIForm : Form
    { 

        public UIForm()
        {
            InitializeComponent();
        }

        private void BtnPinEntry_Click(object sender, EventArgs e)
        {
            (new PinForm()).Show();
            btnEnter.Visible = true;
            btnPin.Visible = false;
        }

        private void btnDispenseCoin_Click(object sender, EventArgs e)
        {
            btnPin.Visible = true;
            btnDispenseCoin.Visible = false;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            btnPark.Visible = true;
            btnEnter.Visible = false;
        }

        

        private void btnPark_Click(object sender, EventArgs e)
        {
            btnPark.Visible = false;
            btnInsertCoin.Visible = true;
        }

        private void btnLeaveCarPark_Click(object sender, EventArgs e)
        {
            btnLeaveCarPark.Visible = false;
            Application.Exit();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            (new PinForm()).Show();
            btnPayment.Visible = false;
            btnLeaveCarPark.Visible = true;
        }

        private void btnInsertCoin_Click(object sender, EventArgs e)
        {
            btnPaymentPin.Visible = true;
            btnInsertCoin.Visible = false;
        }

        private void btnPaymentPin_Click(object sender, EventArgs e)
        {
            (new PaymentForm()).Show();
            btnPaymentPin.Visible = false;
            btnPayment.Visible = true;
        }
    }
}
