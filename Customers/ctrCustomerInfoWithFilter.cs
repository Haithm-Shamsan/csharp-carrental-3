using CarRental_Business;
using CarRental_V2_;
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
    public partial class ctrCustomerInfoWithFilter : UserControl
    {

      int OnSelectedCustomerID;
        clsCustomers _Customer;

        public class clsCustomerInfoFoundArgs : EventArgs
        {
            public int CustomerID { get; }
          

            public clsCustomerInfoFoundArgs(int CustomerID)
            {
                this.CustomerID = CustomerID;

            }
        }

        public event EventHandler<clsCustomerInfoFoundArgs> CustomerInfo;

        public void RaiseOnPersonInfoFound(int CustomerID)
        {
            RaiseCustomerFound(new clsCustomerInfoFoundArgs(CustomerID));
        }

        protected virtual void RaiseCustomerFound(clsCustomerInfoFoundArgs e)
        {
            CustomerInfo?.Invoke(this, e);
        }


        public ctrCustomerInfoWithFilter()
        {
            InitializeComponent();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
          
            switch (cmFilter.SelectedItem)
            {
               
                case "CustomerID":

                    _Customer = clsCustomers.Find(int.Parse(txtSearch.Text));

                    break;
               
            }

            if (txtSearch.Text == "" || cmFilter.Text == "None")
            {
                
                return;
            }
           
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmFilter.Text == "CustomerID")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            frmAddNewEditCustomer frm = new frmAddNewEditCustomer(-1);
            frm.DataBack += DataBack;
            frm.ShowDialog();

            if (OnSelectedCustomerID == 0 || OnSelectedCustomerID == -1)
            {
                return;
            }
            ctrPersonInfo1.LoadPersonInfo(clsCustomers.Find((int)OnSelectedCustomerID).PersonID);
            MessageBox.Show("CustomerID=" + OnSelectedCustomerID);
            
                
        }
        void DataBack(object sender,int CustomerID)
        {
            OnSelectedCustomerID=CustomerID;
        }

        private void btnAddNewVehicle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                return;
            }
            OnSelectedCustomerID = int.Parse(txtSearch.Text);
          
            _Customer=clsCustomers.Find(OnSelectedCustomerID);
            if(_Customer == null)
            {
                MessageBox.Show("Couldnt found Customer Try a correct Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ctrPersonInfo1.LoadPersonInfo(_Customer.PersonID);
            if (CustomerInfo != null)
                RaiseCustomerFound(new clsCustomerInfoFoundArgs(OnSelectedCustomerID));




        }
      
        private void cmFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Visible = true;
            txtSearch.Text = "";
        }

        private void ctrPersonInfo1_PersonInfo(object sender, ctrPersonInfo.clsPersonInfoFoundArgs e)
        {
            
        }

        public void LoadCustomerInfo(int CustomerID)
        {
            OnSelectedCustomerID=CustomerID;
            _Customer = clsCustomers.Find(OnSelectedCustomerID);
            txtSearch.Visible = true;
            txtSearch.Text=_Customer.CustomerID.ToString();
            gbFilter.Enabled = false;
            ctrPersonInfo1.LoadPersonInfo(_Customer.PersonID);
           
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ctrPersonInfo1_Load(object sender, EventArgs e)
        {

        }

        private void gbFilter_Enter(object sender, EventArgs e)
        {

        }
    }
}
