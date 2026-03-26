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

namespace CarRental_3_.Return
{
    public partial class frmReturnsList : Form
    {

        DataTable _dtReturnList=clsVehicleReturn.GetVehicleReturns();
        public frmReturnsList()
        {
            InitializeComponent();
        }
         void _Refresh()
        {
            dgvReturns.DataSource = _dtReturnList;
            lblRecordNumber.Text=dgvReturns.RowCount.ToString();
        }
        private void frmReturnsList_Load(object sender, EventArgs e)
        {
            _Refresh();
        }

        private void btnAddNewVehicle_Click(object sender, EventArgs e)
        {
            AddNewEditReturn frm = new AddNewEditReturn();
            frm.ShowDialog();
            _Refresh();
              
           
        }

        private void customerInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void transactionDetailesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmShowTransaction frm = new frmShowTransaction((int)dgvReturns.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
