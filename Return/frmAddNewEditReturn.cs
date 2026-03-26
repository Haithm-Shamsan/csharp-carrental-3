using CarRental_BussnissLayer;
using Guna.UI2.WinForms;
using NCarRental_Bussnies;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental_3_.Return
{
    public partial class AddNewEditReturn : Form
    {
        int? OnBookingSelected;
      
        clsVehicleReturn _Return;
  
        public AddNewEditReturn()
        {
            InitializeComponent();
        }

        private void ctrBookingDetilesWithFilter1_OnBookingSelected(object sender, Booking.ctrBookingDetilesWithFilter.clsBookingEventArgs e)
        {
            OnBookingSelected = e.BookingID;
            
        }

        int CalculateAcualRentalDays()
        {

         
            int DiffDays = (dtReturnDate.Value.Date - ctrBookingDetilesWithFilter1._BookingInfo.RentalStartDate.Date).Days;

            return DiffDays;
        }
        decimal CalculateActualTotalAmount()
        {
            
           return (CalculateAcualRentalDays()*ctrBookingDetilesWithFilter1._VehicleInfo.RentalPricePerDay)+short.Parse(txtAdditionalCharges.Text);
        }

        int CalculateConsumedMailage()
        {
            int Mileage = ctrBookingDetilesWithFilter1._VehicleInfo.Mileage;
            return  Convert.ToInt16(txtCurrentMailege.Text)-Mileage ;
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if(OnBookingSelected == null) 
            { MessageBox.Show("You Should Chose Booking First !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ; return;
            }

            MainTab.SelectedTab = MainTab.TabPages["tbReturn"];

        
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbBookingInformation_Click(object sender, EventArgs e)
        {

        }

            
        decimal? CaluclateRefoundAmount()
        {
           decimal InitialAmount= ctrBookingDetilesWithFilter1._TransactionInfo.PaidInitialTotalDueAmount;
            decimal TotalDueAmount = Convert.ToDecimal(lblTotalDueAmount.Text);

            var resulte = InitialAmount - TotalDueAmount;

           return resulte < 0 ? AddtionalCharges(resulte):resulte;
          
        }

        decimal AddtionalCharges(decimal AddtionalCharges)
        {
            txtAdditionalCharges.Text= AddtionalCharges.ToString();

            return AddtionalCharges;
        }

        
        private void dtReturnDate_ValueChanged(object sender, EventArgs e)
        {  
            
      
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure do you want to save the return ?","Confrim",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            if (!this.ValidateChildren())
                return;
            _Return = new clsVehicleReturn();
           
            _Return.ActualReturnDate = dtReturnDate.Value;
            _Return.Mileage=short.Parse( txtCurrentMailege.Text);
            _Return.ConsumedMileage = CalculateConsumedMailage();
            _Return.AdditionalCharges=short.Parse(txtAdditionalCharges.Text);
            _Return.FinalCheckNotes = txtNote.Text;
            _Return.ActualTotalDueAmount = CalculateActualTotalAmount();
            _Return.ActualRentalDays = Convert.ToByte(CalculateAcualRentalDays());
            _Return.IsAvilableForRent = true;
            _Return.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            if(!_Return.Save())
            {
               MessageBox.Show("Failed Saving Return ","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;

            }
           if(!_Return.UpdateTransactionAfterReturn(ctrBookingDetilesWithFilter1._BookingInfo.TransactionID))
            {
                MessageBox.Show("Failed Update Trnasaction ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ctrBookingDetilesWithFilter1._BookingInfo._VehicleInfo.SetAvilableVehicle();
            ctrBookingDetilesWithFilter1._BookingInfo.SetBookingStatusComplete();
                lblReturnID.Text = _Return.ReturenID.ToString();

            lblActualRentalDays.Text = _Return.ActualRentalDays.ToString();
            lblCensomedMailage.Text = _Return.ConsumedMileage.ToString();
            lblTotalDueAmount.Text= _Return.ActualTotalDueAmount.ToString();

            MessageBox.Show("Return Saved  Seccussfully ", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        void GenralTextBox_Validating(object sender,CancelEventArgs e)
        {
        Guna2TextBox Temp = (Guna2TextBox)sender;

            if (string.IsNullOrEmpty(Temp.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This Filed is required");

            }
            else
            {
                errorProvider1.Clear();
            }
        }
        private void txtCurrentMailege_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void AddNewEditReturn_Load(object sender, EventArgs e)
        {dtReturnDate.MinDate=DateTime.Now;

        }

        private void txtCurrentMailege_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtAdditionalCharges_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        private void tbReturn_Click(object sender, EventArgs e)
        {

        }
    }
}
