using CarRental_BussnissLayer;
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
    public partial class ctrVehicleInfo : UserControl
    {
        clsVehicle _Vehicle;
        public ctrVehicleInfo()
        {
            InitializeComponent();
            
        }
        public void LoadVehicleInfo(int VehicleID)
        {
            _Vehicle = clsVehicle.GetVehicle(VehicleID);
            if( _Vehicle == null )
            {
                MessageBox.Show("Couldnt Load Vehicle Information !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            llVehicleMaintentance.Enabled = true;
            lblCategory.Text = _Vehicle.VehicleCategoryInfo.CategoryName;
            lblFuleType.Text = _Vehicle.VehicleFuleType.FuleType;
             if(_Vehicle.IsAvailableForRent)
            {
                lblIsActive.Text = "Yes";
            }
            else
            {
                lblIsActive.Text = "False";
            }
             lblMake.Text=_Vehicle.Make;
            lblMileage.Text = _Vehicle.Mileage.ToString();
            lblModel.Text = _Vehicle.Model;
            lblPlateNo.Text=_Vehicle.PlateNumber.ToString();
            lblRentalPrice.Text=_Vehicle.RentalPricePerDay.ToString();
            lblVehicleID.Text = _Vehicle.VehicleID.ToString();
            lblYear.Text = _Vehicle.Year.ToString();
            pbImage.Load(_Vehicle.ImagePath);
            

        }
        private void ctrVehicleInfo_Load(object sender, EventArgs e)
        {

        }

        private void llVehicleMaintentance_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmVehicleMintenanceHistory frm = new frmVehicleMintenanceHistory(_Vehicle.VehicleID);
            frm.ShowDialog();
        }
    }
}
