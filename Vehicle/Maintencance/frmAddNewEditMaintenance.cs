using CarRental_BussnissLayer;
using Guna.UI2.WinForms;
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

namespace CarRental_3_
{
    public partial class frmAddNewEditMaintenance : Form
    {
        enum enMode { AddNew,Update}
        enMode Mode;

        int MaintenanceID;
        int VehicleID;
        clsMaintenance _Maintenance;
        public frmAddNewEditMaintenance(int VehicleID,int MaintenanceID)
        {
            InitializeComponent();
            this.MaintenanceID = MaintenanceID;
            this.VehicleID = VehicleID;
                Mode=enMode.Update;
            
        }
        public frmAddNewEditMaintenance(int VehicleID)
        {
            InitializeComponent();
            this.VehicleID = VehicleID;
            Mode = enMode.AddNew;
            
        
            
        }
        void LoadMaintencanceInfo()
        {
            if(Mode==enMode.AddNew)
            {
                lblMode.Text = "Add New Maintencance";
                _Maintenance = new clsMaintenance();
                return;
            }
            _Maintenance = clsMaintenance.GetMaintenance(MaintenanceID);

            if(_Maintenance == null)
            {
                MessageBox.Show("There Is No Maintenance Exist With This ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lblMode.Text = "Update Maintenance";
            lblMaintenanceID.Text=MaintenanceID.ToString();
            Date.Value = _Maintenance.MaintenanceDate;
            
            txtCost.Text = _Maintenance.Cost.ToString();
            txtDescription.Text=_Maintenance.Description;
        }
        private void frmAddNewEditMaintenance_Load(object sender, EventArgs e)
        {
            LoadMaintencanceInfo();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ValidatingEmptyTextBox(Guna2TextBox TextBox, CancelEventArgs e)
        {
            Guna2TextBox Temp = (Guna2TextBox)TextBox;
            if (string.IsNullOrEmpty(Temp.Text))
            {
                e.Cancel = true;
                errorProvider2.SetError(Temp, "it is Required");
            }
            else
            {
                errorProvider2.Clear();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            

            if(MessageBox.Show("Are you sure do you want to save it", "Comfirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            if (!ValidateChildren())
                return;

            _Maintenance.MaintenanceDate= Date.Value;
            _Maintenance.Cost = Convert.ToDecimal(txtCost.Text);
            _Maintenance.Description= txtDescription.Text;
            _Maintenance.VehicleID = VehicleID;
            _Maintenance.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            
            if(_Maintenance.Save())
            {
                MessageBox.Show("Maintencance Saved Seccussfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblMaintenanceID.Text = _Maintenance.MaintenanceID.ToString();
                Mode = enMode.Update;
                return;
            }
            
        }

        private void ValidatingEmptyTextBox(object sender, CancelEventArgs e)
        {

        }
    }
}
