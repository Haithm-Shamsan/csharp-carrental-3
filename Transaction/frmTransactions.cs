using CarRental_BussnissLayer;
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
    public partial class frmTransactions : Form
    {
        DataTable dtTransactions = clsRentalTransaction.GetRentalTransaction();
        public frmTransactions()
        {
            InitializeComponent();
        }

        void _Refresh()
        {
            dgvTransaction.DataSource = dtTransactions;
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                _Refresh();
            }
          
                string CoulmnName = "";
        
            switch (cmFilter.Text)
            {
                case "BookingID":
                    CoulmnName = "BookingID";
                    break;
                case "TransactionID":
                    CoulmnName = "TransactionID";
                    break;
                case "None":
                    CoulmnName = "BookingID";
                    break;

                
            }
            if (txtSearch.Text.Trim() == "" || CoulmnName == "None")
                    {
                        dtTransactions.DefaultView.RowFilter = "";
                        _Refresh();
                        return;
                    }
                    else
                    {
                      dtTransactions.DefaultView.RowFilter = string.Format("[{0}]={1}", CoulmnName, txtSearch.Text);

                    }
        }

        private void cmFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
             txtSearch.Visible = true;
            if (txtSearch.Visible)
            {
                txtSearch.Text = "";
                txtSearch.Focus();
            }

            dtTransactions.DefaultView.RowFilter = "";
            lblRecordNumber.Text = dgvTransaction.Rows.Count.ToString();
        }

        private void frmTransactions_Load(object sender, EventArgs e)
        {
            _Refresh();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        { 
            if(cmFilter.Text!="None")
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void transactionDetailesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowTransaction frm = new frmShowTransaction((int)dgvTransaction.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
        }

        private void dgvTransaction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
