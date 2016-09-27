/*
 * Name: Anju Chawla
 * Date: September 27, 2016
 * Purpose: Create an application for the fitness center.
 * Allow user to sign in and select promotions. 
 * Display the promotion details with appropriate images
 * 
 */
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
            txtPromotion.Visible = true;

            //disable sign in
            btnSignIn.Enabled = false;


        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //print the form
            printForm1.Print();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close(); 
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //reset the form to its start default state
            Application.Restart();
        }

        private void radClothing_CheckedChanged(object sender, EventArgs e)
        {
            //show the corresponding promotion and picture for clothing
            txtPromotion.Text = "30% off clearance items";
            picDepartment.Image = Comp1004_Week4_Tuesday.Properties.Resources.clothing;


        }

        private void radEquipmentAccessories_CheckedChanged(object sender, EventArgs e)
        {
            //show the corresponding promotion and picture for equipment/accessories
            txtPromotion.Text = "30% off all equipment";
            picDepartment.Image = Properties.Resources.equipment;
        }

        private void radJuiceBar_CheckedChanged(object sender, EventArgs e)
        {
            //show the corresponding promotion and picture for juice bar
            txtPromotion.Text = "Free serving of WheatBerry shake";
            picDepartment.Image = Properties.Resources.juice;
        }

        private void radMembership_CheckedChanged(object sender, EventArgs e)
        {
            //show the corresponding promotion and picture for membership
            txtPromotion.Text = "Free personal trainer for the first month";
            picDepartment.Image = Properties.Resources.member;
        }

        private void radPersonalTraining_CheckedChanged(object sender, EventArgs e)
        {
            //show the corresponding promotion and picture for personal training
            txtPromotion.Text = "3 free memberships with membership renewal";
            picDepartment.Image = Properties.Resources.training;
        }

        private void chkImageVisible_CheckedChanged(object sender, EventArgs e)
        {
            //picture displayed if image visible is checked
            /*
            if (chkImageVisible.Checked)  //==true
            {
                picDepartment.Visible = true;
            }
            else
            {
                picDepartment.Visible = false;
            }
            */
            picDepartment.Visible = chkImageVisible.Checked;
        }
    }
}
