using CarRental_BussnissLayer;
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
    public partial class frmShowTransaction : Form
    {
      
        int _BookingID;
        clsRentalTransaction _Transaction;
        public frmShowTransaction(int BookingID)
        {
            InitializeComponent();
            _BookingID = BookingID;
         
        }

       

        


        void LoadTransactionInfo()
        {
            _Transaction = clsRentalTransaction.GetPaymentByBookingID(_BookingID);
            if (_Transaction == null) 
            {
                MessageBox.Show("Load Payment Info Failed Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            lblTransactionID.Text = _Transaction.TransactionID.ToString();
            lblActualTotalDueAmmount.Text = _Transaction.ActualTotalDueAmount.ToString();
        
            if(_Transaction.ReturnID==-1)
            {
                lblReturnID.Text = "Not Returned yet";
            }
            else
            {
                lblReturnID.Text= _Transaction.ReturnID.ToString();
            }
            lblTransactionDate.Text= _Transaction.TransactionDate.ToString("dd/MMM/yyyy");
            if (_Transaction.UpdatedTransactionDate == null)
            {
                lblUpdatedTransactionDate.Text = "Not Updated yet";
            }
            else
            {
                lblUpdatedTransactionDate.Text = _Transaction.UpdatedTransactionDate?.ToString("dd/mm/yyyy");
            }
          
            llblBookingID.Text = _Transaction.BookingID.ToString();
            lblTotalremaining.Text = _Transaction.TotalRemaining?.ToString();
            lblActualTotalDueAmmount.Text= _Transaction.ActualTotalDueAmount?.ToString();
            lblTotalDueAmount.Text = _Transaction.PaidInitialTotalDueAmount.ToString();
            lblTotalRefundedAmount.Text = _Transaction.TotalRefundedAmount?.ToString();

       
        }
        private void frmAddNewTransaction_Load(object sender, EventArgs e)
        {
            
                LoadTransactionInfo();
            
           
           
            

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
