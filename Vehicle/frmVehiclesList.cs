using CarRental_3_;
using CarRental_BussnissLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental_V2_
{
    public partial class frmVehiclesList : Form
    {
        DataTable _DtVehicleList = clsVehicle.GetVehicles();
        public frmVehiclesList()
        {
            InitializeComponent();
        }

        void _Refreash()
        {
            dgvVehicles.DataSource = clsVehicle.GetVehicles() ;
            lblRecordNumber.Text=dgvVehicles.RowCount.ToString() ;
        }
        private void btnAddNewVehicle_Click(object sender, EventArgs e)
        {
            frmAddNewCar frm = new frmAddNewCar();
            frm.ShowDialog();
            _Refreash();
        }
        
        private void frmVehiclesList_Load(object sender, EventArgs e)
        {
            _Refreash();
        }

        private void editInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewCar frm=new frmAddNewCar((int)dgvVehicles.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _Refreash();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {  
            if(cmFilter.Text=="VehicleID"||cmFilter.Text=="Year")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

       
//        None
//  VehicleID
//Year
//Model
//Make
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string CoulmnName="";
            switch(cmFilter.SelectedItem)
            {
                case "VehicleID":

                    CoulmnName = "VehicleID";

                    break;
                case "Year":

                    CoulmnName = "Year";

                    break;
                case "Model":

                    CoulmnName = "Model";

                    break;
                case "Make":

                    CoulmnName = "Make";

                    break;
                case "None":

                    CoulmnName = "None";

                    break;
            }

            if(txtSearch.Text.Trim()==""||cmFilter.Text=="None")
            {
                _Refreash();
                return;
            }
            if (cmFilter.Text == "VehicleID" || cmFilter.Text == "Year")
                _DtVehicleList.DefaultView.RowFilter = string.Format("[{0}]={1}", CoulmnName, txtSearch.Text);

            else
            
                _DtVehicleList.DefaultView.RowFilter = string.Format("[{0}] LIKE {1}", CoulmnName, txtSearch.Text);
            

            dgvVehicles.DataSource=_DtVehicleList;
        }

        private void cmFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Visible = true;
        
        }

        private void dgvVehicles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void maintentanceHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVehicleMintenanceHistory frm = new frmVehicleMintenanceHistory((int)dgvVehicles.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _Refreash();
        }

        private void customerInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVehicleInfo frm = new frmVehicleInfo((int)dgvVehicles.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
