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
    public partial class frmVehicleMintenanceHistory : Form
    {
        int _VehicleID;
        public frmVehicleMintenanceHistory(int VehicleID)
        {
            InitializeComponent();

            _VehicleID= VehicleID;
        }

        void Refreash()
        {
            dgvMaintencance.DataSource = clsMaintenance.GetMaintenanceHistory(_VehicleID);
        }
        private void frmVehicleMintenanceHistory_Load(object sender, EventArgs e)
        {
            Refreash();   
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNewVehicle_Click(object sender, EventArgs e)
        {
            frmAddNewEditMaintenance frm = new frmAddNewEditMaintenance(_VehicleID);
                frm.ShowDialog();
            Refresh();
        }

        private void customerInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void dgvMaintencance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void editInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewEditMaintenance frm = new frmAddNewEditMaintenance(_VehicleID, (int)dgvMaintencance.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            Refresh();
        }
    }
}
