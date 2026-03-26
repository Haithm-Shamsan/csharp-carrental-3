using CarRental_Business;
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
    public partial class frmUsersList : Form
    {
        DataTable _UserList=clsUser.GetUsers();
        public frmUsersList()
        {
            InitializeComponent();
        }

        private void btnAddNewVehicle_Click(object sender, EventArgs e)
        {
            frmAddEditUser frm = new frmAddEditUser();
            frm.ShowDialog();
            _Refreash();
        }
       void _Refreash()
        {
            dgvUsers.DataSource = clsUser.GetUsers() ;
            lblRecordNumber.Text=dgvUsers.RowCount.ToString();
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string CoulmnName = "";
            switch (cmFilter.SelectedItem)
            {
                case "UserID":

                    CoulmnName = "UserID";

                    break;
                case "PersonID":

                    CoulmnName = "PersonID";

                    break;
                case "NationalNo":

                    CoulmnName = "NationalNo";

                    break;
                case "Name":

                    CoulmnName = "FullName";

                    break;
                case "None":

                    CoulmnName = "None";

                    break;
            }

            if (cmFilter.Text == "" || cmFilter.Text == "None")
            {
                _Refreash();
                return;
            }
            if (cmFilter.Text == "UserID" || cmFilter.Text == "PersonID")
                _UserList.DefaultView.RowFilter = string.Format("[{0}]={1}", CoulmnName, txtSearch.Text);

            else

                _UserList.DefaultView.RowFilter = string.Format("[{0}] LIKE {1}", CoulmnName, txtSearch.Text);
        }

        private void cmFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Visible = true;
          
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmUsersList_Load(object sender, EventArgs e)
        {
            _Refreash();
        }

        private void editInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditUser frm = new frmAddEditUser((int)dgvUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _Refreash();
        }

        private void customerInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowUserInfo frm = new frmShowUserInfo((int)dgvUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
