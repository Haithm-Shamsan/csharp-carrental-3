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

namespace CarRental_3_
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            
         
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            lblTotalBooking.Text=clsRentalBooking.GetRentalBooking().Rows.Count.ToString();
            lblAvilableVehicles.Text = clsVehicle.GetActiveVehicles().Rows.Count.ToString();
            lblCustomerNum.Text=clsCustomers.GetCustomer().Rows.Count.ToString();   
            lblTotalReturns.Text=clsVehicleReturn.GetVehicleReturns().Rows.Count.ToString();
            lblVehiclesNumber.Text = clsVehicle.GetVehicles().Rows.Count.ToString();
        }
    }
}
