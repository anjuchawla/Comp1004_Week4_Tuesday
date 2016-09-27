using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comp1004_Week4_Tuesday
{
    public partial class frmPromotions : Form
    {
        public frmPromotions()
        {
            InitializeComponent();
        }

        private void frmPromotions_Load(object sender, EventArgs e)
        {
            //default settings when the form loads
            grpDepartment.Enabled = false;
            rtfWelcome.Visible = false;
            txtPromotion.Visible = false;
            chkImageVisible.Visible = false;
            picDepartment.Visible = false;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            //allow the user to sign in; show welcome message
            rtfWelcome.Visible = true;
            rtfWelcome.Text = "Welcome " + txtName.Text
                + Environment.NewLine + "Member Id: " + mskMemberId.Text;

            //hide the controls not needed
            lblName.Visible = false;
            lblMemberId.Visible = false;
            txtName.Visible = false;
            mskMemberId.Visible = false;

            //show the controls that are required for input
            grpDepartment.Enabled = true;
            chkImageVisible.Visible = true;
            picDepartment.Visible = true;
            txtPromotion.Visible = true;

            //disable sign in
            btnSignIn.Enabled = false;


        }
    }
}
