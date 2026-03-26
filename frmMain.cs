using CarRental_3_;
using CarRental_3_.Return;
using CarRental_Business;
using NCarRental_Bussnies;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental_V2_
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblUserName.Text=clsGlobal.CurrentUser.UserName;
            pbCurrentUser.Image=Image.FromFile(clsGlobal.CurrentUser._PersonInfo.ImagePath);
           
        }

        Form activeForm = null;
        void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlChildForm.Controls.Add(childForm);
            pnlChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void guna2Button6_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            frmCustomersList frm = new frmCustomersList();
            openChildFormInPanel(frm);
        }

        private void btnVehicles_Click(object sender, EventArgs e)
        {
            frmVehiclesList frm = new frmVehiclesList();
            openChildFormInPanel(frm);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            frmUsersList frm = new frmUsersList();
            openChildFormInPanel(frm);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPictuer_Click(object sender, EventArgs e)
        {

        }

        private void pbCurrentUser_Click(object sender, EventArgs e)
        {
            frmShowUserInfo UserInfo = new frmShowUserInfo(clsGlobal.CurrentUser.UserID);
            UserInfo.ShowDialog();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            frmBooking frm = new frmBooking();
            openChildFormInPanel(frm);
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            frmTransactions frm = new frmTransactions();
            openChildFormInPanel(frm);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmReturnsList frm = new frmReturnsList();
            openChildFormInPanel(frm);

        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            frmDashboard frm = new frmDashboard();
            openChildFormInPanel(frm);
        }
    }
}
