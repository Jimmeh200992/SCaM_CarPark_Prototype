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

        private void btnPayFee_Click(object sender, EventArgs e)
        {
            btnPayFee.Visible = false;
            btnPayment.Visible = true;
        }

        private void btnPark_Click(object sender, EventArgs e)
        {
            btnPayFee.Visible = true;
            btnPark.Visible = false;
        }

        private void btnLeaveCarPark_Click(object sender, EventArgs e)
        {
            btnLeaveCarPark.Visible = false;
            Application.Exit();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            (new PaymentForm()).Show();
            btnPayment.Visible = false;
            btnLeaveCarPark.Visible = true;
        }

        /// 
        /// Section below is for PIN entry elements
        /// 
        private void btnNum0_Click(object sender, EventArgs e)
        {
            if (txtEnterPin.Text == "Please Enter Your Secure Pin")
            {
                txtEnterPin.Text = "";
            }
            txtEnterPin.Text += "0";
        }

        private void BtnNum1_Click(object sender, EventArgs e)
        {
            if (txtEnterPin.Text == "Please Enter Your Secure Pin")
            {
                txtEnterPin.Text = "";
            }
            txtEnterPin.Text += "1";
        }

        private void BtnNum2_Click(object sender, EventArgs e)
        {
            if (txtEnterPin.Text == "Please Enter Your Secure Pin")
            {
                txtEnterPin.Text = "";
            }
            txtEnterPin.Text += "2";
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            if (txtEnterPin.Text == "Please Enter Your Secure Pin")
            {
                txtEnterPin.Text = "";
            }
            txtEnterPin.Text += "3";
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            if (txtEnterPin.Text == "Please Enter Your Secure Pin")
            {
                txtEnterPin.Text = "";
            }
            txtEnterPin.Text += "4";
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            if (txtEnterPin.Text == "Please Enter Your Secure Pin")
            {
                txtEnterPin.Text = "";
            }
            txtEnterPin.Text += "5";
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            if (txtEnterPin.Text == "Please Enter Your Secure Pin")
            {
                txtEnterPin.Text = "";
            }
            txtEnterPin.Text += "6";
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            if (txtEnterPin.Text == "Please Enter Your Secure Pin")
            {
                txtEnterPin.Text = "";
            }
            txtEnterPin.Text += "7";
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            if (txtEnterPin.Text == "Please Enter Your Secure Pin")
            {
                txtEnterPin.Text = "";
            }
            txtEnterPin.Text += "8";
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            if (txtEnterPin.Text == "Please Enter Your Secure Pin")
            {
                txtEnterPin.Text = "";
            }
            txtEnterPin.Text += "9";
        }

        private void btnHash_Click(object sender, EventArgs e)
        {
            if (txtEnterPin.Text == "Please Enter Your Secure Pin")
            {
                txtEnterPin.Text = "";
            }
            txtEnterPin.Text += "#";
        }

        private void btnAsterisk_Click(object sender, EventArgs e)
        {
            if (txtEnterPin.Text == "Please Enter Your Secure Pin")
            {
                txtEnterPin.Text = "";
            }
            txtEnterPin.Text += "*";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEnterPin.Text = "Please Enter Your Secure Pin";
        }

        private void btnPinEnter_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
