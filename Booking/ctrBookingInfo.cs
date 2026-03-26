using CarRental_BussnissLayer;
using CarRental_V2_;
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
    public partial class ctrBookingInfo : UserControl
    {
        clsRentalBooking _Booking;
        public ctrBookingInfo()
        {
            InitializeComponent();
        }
        

          clsRentalTransaction TransactionInfo;
        public clsRentalTransaction _TransactionInfo
        {
            get { return TransactionInfo; }
        }

        clsVehicle VehicleInfo;
        public clsVehicle _VehicleInfo
        {
            get { return VehicleInfo; }
        }
        public void LoadBookingInfo(int BookingID)
        {
            _Booking=clsRentalBooking.GetRentalBooking(BookingID);

            if (_Booking == null)
            {
                MessageBox.Show("Cannto Load Booking Information !","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            TransactionInfo = clsRentalTransaction.GetPaymentByBookingID(BookingID);
            VehicleInfo = clsVehicle.GetVehicle(_Booking.VehicleID);

             lblBookingID.Text = BookingID.ToString();
            lblCustomerID.Text=_Booking.CustomerID.ToString();
            lblVehicleID.Text = _Booking.VehicleID.ToString();
            lblNationalNo.Text = _Booking._CustomerInfo.NationalNo;
            lblFullName.Text= _Booking._CustomerInfo.FullName;
            lblNote.Text=_Booking.InitialCheckNotes.ToString();
            lblPickUpLoacation.Text = _Booking.PickupLocation;
            lblDopOffLocation.Text = _Booking.DropoffLocation;
            lblEndDate.Text = _Booking.RentalEndDate.ToString("dd/MMM/yyyy");
            lblStartDate.Text=_Booking.RentalStartDate.ToString("dd/MMM/yyyy");
            lblTotalPrice.Text = _Booking.InitialTotalDueAmount.ToString();
            lblrentalDays.Text = _Booking.InitialRentalDays.ToString();
            lblRentalPrice.Text=_Booking._VehicleInfo.RentalPricePerDay.ToString();

        }
        private void ctrBookingInfo_Load(object sender, EventArgs e)
        {

        }

        private void llCustomerInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonInfo frm = new frmShowPersonInfo(_Booking._CustomerInfo.PersonID);
            frm.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
