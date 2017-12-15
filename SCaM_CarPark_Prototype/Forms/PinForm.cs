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
    public partial class PinForm : Form
    {

        public PinForm()
        {
            InitializeComponent();
        }

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

        private void btnEnter_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
