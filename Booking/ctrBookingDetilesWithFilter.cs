using CarRental_Business;
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

namespace CarRental_3_.Booking
{
    public partial class ctrBookingDetilesWithFilter : UserControl
    { 
      
        public ctrBookingDetilesWithFilter()
        {
            InitializeComponent();
        }
         clsRentalBooking _Booking ;

        public clsRentalTransaction _TransactionInfo
        {
            get { return ctrBookingInfo1._TransactionInfo; }
        }
        public clsVehicle _VehicleInfo
        {
            get { return ctrBookingInfo1._VehicleInfo;}
        }

        public clsRentalBooking _BookingInfo
        {
            get { return _Booking; }
        }
        public class clsBookingEventArgs : EventArgs
        {
           public int BookingID { get; }

            public clsBookingEventArgs(int bookingID)
            {
                BookingID = bookingID;
            }
        }

        public event EventHandler<clsBookingEventArgs> OnBookingSelected;


        void RaisOnBookingFound(int bookingID)
        {
            RaisEvent(this, new clsBookingEventArgs(bookingID));
        }

        void RaisEvent(object sender, clsBookingEventArgs e)
        {
            OnBookingSelected.Invoke(sender, e);
        }
        private void ctrBookingDetilesWithFilter_Load(object sender, EventArgs e)
        {

        }

        private void btnFindCustomer_Click(object sender, EventArgs e)
        {
           

            switch (cmFilter.SelectedItem)
            {

                case "CustomerID":
                    _Booking = clsRentalBooking.GetRentalBookingByCustomerID(int.Parse(txtSearch.Text));
                    break;

                case "BookingID":
                    _Booking = clsRentalBooking.GetRentalBooking(int.Parse(txtSearch.Text));
                    break;
                    

            }

            if (cmFilter.Text == "" || cmFilter.Text == "None")
            {

                return;
            }
            
            if(_Booking==null)
            {
                MessageBox.Show("Couldnt find booking","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            ctrBookingInfo1.LoadBookingInfo(_Booking.BookingID);
            if (OnBookingSelected != null)
                RaisOnBookingFound(_Booking.BookingID);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmFilter.Text == "CustomerID"||cmFilter.Text=="BookingID")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            frmAddNewEditBooking frm = new frmAddNewEditBooking();
            
            frm.ShowDialog();
        }

        private void cmFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Visible = true;
            txtSearch.Text = "";
        }

        private void ctrBookingInfo1_Load(object sender, EventArgs e)
        {

        }
    }
}
           
        

    

