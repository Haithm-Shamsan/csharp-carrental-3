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
    public partial class frmVehicleInfo : Form
    {
        int _VehicleID;
        public frmVehicleInfo(int VehicleID)
        {
            InitializeComponent();
            _VehicleID = VehicleID;
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrVehicleInfo1_Load(object sender, EventArgs e)
        {

        }

        private void frmVehicleInfo_Load(object sender, EventArgs e)
        {
            ctrVehicleInfo1.LoadVehicleInfo(_VehicleID);
        }
    }
}
