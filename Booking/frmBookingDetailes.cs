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
    public partial class frmBookingDetailes : Form
    {
        int _BookingID;
        public frmBookingDetailes(int BookingID)
        {
            InitializeComponent();
            _BookingID = BookingID;
        }

        private void frmBookingDetailes_Load(object sender, EventArgs e)
        {
            ctrBookingInfo1.LoadBookingInfo(_BookingID);
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrBookingInfo1_Load(object sender, EventArgs e)
        {

        }
    }
}
