using CarRental_BussnissLayer;
using CarRental_V2_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental_3_
{
    public partial class frmBooking : Form
    {
        DataTable _Bookings = clsRentalBooking.GetRentalBooking();
        clsRentalBooking _Booking;
        public frmBooking()
        {
            InitializeComponent();
        } 
         
        void _Refresh()
        {
            dgvBooking.DataSource = _Bookings;
            lblRecordNumber.Text=dgvBooking.RowCount.ToString();
        }
        private void frmBooking_Load(object sender, EventArgs e)
        {
            _Refresh();
        }
       
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                _Refresh();
                return;
            }
            txtSearch.Visible = true;
            string CoulmnName = "";

            switch (cmFilter.SelectedItem)
            {
                case "None":
                    CoulmnName = "None";

                    break;
                case "BookingID":
                    CoulmnName = "BookingID";
                    break;
            
                case "NationalNo":
                    CoulmnName = "NationalNo";
                    break;
                case "FullName":
                    CoulmnName = "FullName";
                    break;
             
                default:
                    CoulmnName = "None";
                    break;


            }


            if (txtSearch.Text.Trim() == "" || CoulmnName == "None")
            {
                _Bookings.DefaultView.RowFilter = "";
                _Refresh();
                return;
            }

            if (CoulmnName == "CustomerID"||CoulmnName=="BookingID")
            {
                _Bookings.DefaultView.RowFilter = string.Format("[{0}]={1}", CoulmnName, txtSearch.Text);

            }
            else
            {
                _Bookings.DefaultView.RowFilter = string.Format("[{0}] Like'{1}'", CoulmnName, txtSearch.Text);
            }

            dgvBooking.DataSource = _Bookings;
        }

        private void cmFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Visible = (cmFilter.Text != "None");

            if (txtSearch.Visible)
            {
                txtSearch.Text = "";
                txtSearch.Focus();
            }

            _Bookings.DefaultView.RowFilter = "";
            lblRecordNumber.Text = dgvBooking.Rows.Count.ToString();

        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmFilter.Text == "CustomerID")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void btnAddNewVehicle_Click(object sender, EventArgs e)
        {
            frmAddNewEditBooking frm = new frmAddNewEditBooking();
            frm.ShowDialog();
            _Refresh();
        }

        private void dgvBooking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void customerInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBookingDetailes frm = new frmBookingDetailes((int)dgvBooking.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void editInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewEditBooking frm = new frmAddNewEditBooking((int)dgvBooking.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void maintentanceHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Booking = clsRentalBooking.GetRentalBooking((int)dgvBooking.CurrentRow.Cells[0].Value);
            frmShowPersonInfo frm = new frmShowPersonInfo(_Booking._CustomerInfo.PersonID);
            frm.ShowDialog();
        }

        private void vehicleInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Booking = clsRentalBooking.GetRentalBooking((int)dgvBooking.CurrentRow.Cells[0].Value);
            frmVehicleInfo frm=new frmVehicleInfo(_Booking.VehicleID);
            frm.ShowDialog();
        }

        private void transactionDetailesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowTransaction frm=new frmShowTransaction((int)dgvBooking.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void deleteBookingToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            int BookingID= (int)dgvBooking.CurrentRow.Cells[0].Value;
            if (MessageBox.Show("Are you sure do you want to delete this booking ?", "Confrim", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

           clsRentalBooking Booking = clsRentalBooking.GetRentalBooking(BookingID);
            Booking._VehicleInfo.SetUnAvilableVehicle();

            if(!clsRentalBooking.DeleteRentalBooking(BookingID))
            {
                MessageBox.Show("Failed Delete this Booking !","Failed",MessageBoxButtons.OK,MessageBoxIcon.Error); return;
            }
            else
            {
                MessageBox.Show("Booking Deleted  Seccussfuly !", "Seccessed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
            }


           

        }

        private void cancleBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsRentalBooking Booking = clsRentalBooking.GetRentalBooking((int)dgvBooking.CurrentRow.Cells[0].Value);
           
            if(MessageBox.Show("Are you sure do you want to cancel this booking ?","Comfrim",MessageBoxButtons.YesNo) == DialogResult.No) 
            {
                return;
            }

            if(clsRentalBooking.CancleBooking(Booking.BookingID,Booking.TransactionID))
            {
                Booking._VehicleInfo.SetAvilableVehicle();  
                MessageBox.Show("Booking Cancelled  Seccussfuly !", "Seccessed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
            }
            else
            {
                MessageBox.Show("Failed Delete this Booking !", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            _Refresh();
        }
    }
}
