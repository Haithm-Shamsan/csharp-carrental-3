using CarRental_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using NCarRental_Bussnies;
using Guna.UI2.WinForms;
using CarRental_3_.Properties;

namespace CarRental_V2_
{
    public partial class frmAddNewEditCustomer : Form
    { 
        enum enMode { AddNew,Update};
        enMode Mode;

        int _CustomerID;
        clsCustomers _Customer;
        int _PersonID;

        public delegate void DataBackEventHandler(object sender, int CustomerID);
       public  DataBackEventHandler DataBack;
        public frmAddNewEditCustomer(int CustomerID)
        {
            InitializeComponent();
            _CustomerID = CustomerID;
            if(_CustomerID==-1)
            {
                Mode=enMode.AddNew;
                lblMode.Text = "Add New Customer";
            }else
            {
                Mode=enMode.Update;
                lblMode.Text = "Update Customer Info";
            }
        }

        void _LoadUpdateCustomerInfo()
        {
            _Customer = clsCustomers.Find(_CustomerID);

            if( _Customer == null )
            {
                MessageBox1.Show();
                return;
            }
            lblPersonID.Text = _Customer.CustomerID.ToString();
          
            txtFirstName.Text = _Customer.FirstName;
            txtSecondName.Text = _Customer.SecondName;
            txtLastName.Text= _Customer.LastName;
            txtNationalNo.Text= _Customer.NationalNo;
            _PersonID = clsPerson.GetPerson(txtNationalNo.Text).PersonID;
            txtPhone.Text= _Customer.Phone;
            txtEmail.Text=_Customer.Email;
            txtDLNumber.Text = _Customer.DriverLicenseNumber;
            dtDateOfBirth.Value=_Customer.DateOfBirth;
            txtThird.Text = _Customer.ThirdName;
            pbImage.ImageLocation = _Customer.ImagePath;
            
        }

        void _LoadAddNewCustomerInfo()
        {
            _Customer = new clsCustomers();
           
            lblPersonID.Text = "[???]";
            txtDLNumber.Text = "";
            txtEmail.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtNationalNo.Text = "";
            txtPhone.Text = "";
            txtSecondName.Text = "";
            txtThird.Text = "";
            pbImage.ImageLocation= "C:\\Users\\haythm.DESKTOP-E1ODE62\\source\\repos\\CarRental(3)\\Resources\\person_man.png";
            dtDateOfBirth.MinDate = DateTime.Now.AddYears(-18);
            dtDateOfBirth.Value = DateTime.Now;
           
        }
        private void frmAddNewEditPerson_Load(object sender, EventArgs e)
        {
            
            
               
           if(Mode==enMode.Update)
            {
                _LoadUpdateCustomerInfo();
                return;
            } 
            _LoadAddNewCustomerInfo();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RemovePhoto_Click(object sender, EventArgs e)
        {
            pbImage.Image = null;
        }

        private void btnAddPhoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                //MessageBox.Show("Selected Image is:" + selectedFilePath);

                pbImage.ImageLocation=(selectedFilePath);
            }
        }



        bool _HandlImage()
        {
            if (_Customer.ImagePath != pbImage.ImageLocation)
            {

                if (pbImage.ImageLocation != "")
                {
                    try
                    {  
                        File.Delete(_Customer.ImagePath);


                    }
                    catch
                    {

                    }
                  
                }

                if (pbImage.ImageLocation != null)
                {
                    string SourcePath = pbImage.ImageLocation;

                    if (clsUtil.CopyImageToProjectFile(ref SourcePath))
                    {
                        pbImage.ImageLocation = SourcePath;
                        return true;
                    }
                    else
                    {
                        MessageBoxImage.Show();
                        return false;
                    }
                }
            }
            return true;
        }







        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure do you want to save this Customer ?", "Confrim", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

           
            if (!this.ValidateChildren())
            {
                return;
            }

            if (!_HandlImage())
                return;


            txtFirstName.Focus();
           
            _Customer.FirstName = txtFirstName.Text;
            _Customer.LastName = txtLastName.Text;
    
            if(string.IsNullOrEmpty(txtEmail.Text))
            {
                txtEmail.Text ="";
            }else
            {
               _Customer.Email = txtEmail.Text;
            }
           
            _Customer.Phone = txtPhone.Text;
            _Customer.ThirdName = txtThird.Text;
            _Customer.SecondName = txtSecondName.Text;
            _Customer.DateOfBirth = dtDateOfBirth.Value;
            _Customer.DriverLicenseNumber=txtDLNumber.Text;
            _Customer.NationalNo = txtNationalNo.Text;
            
            _Customer.PersonID= _PersonID;
            if(string.IsNullOrEmpty(pbImage.ImageLocation))
            {
                pbImage.ImageLocation = "";
            }
            else
            {
                _Customer.ImagePath = pbImage.ImageLocation;
            }
            _Customer.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            if(_Customer.Save())
            {
                MessageBox1.Text=("Saved Secussfully");
                MessageBox1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                MessageBox1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                MessageBox1.Show();
              
                lblPersonID.Text = _Customer.PersonID.ToString();
                lblMode.Text = "Update Person Info";

                  
                    DataBack?.Invoke(this, _Customer.CustomerID);
              
            }
          

        }

        private void editInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
         
        private void ValidatingEmptyTextBox(Guna2TextBox sender,CancelEventArgs e)
        {
            Guna2TextBox Temp =(Guna2TextBox)sender;

            if(string.IsNullOrEmpty(Temp.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This Filed is required");

            }else
            {
                errorProvider1.Clear();
            }
        }
        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
          if(!clsUtil.IsValiedEmail(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "Invalied Email !");
                e.Cancel = true;
              
            }else
            {
                errorProvider1.Clear();
               
            }
        }

        private void txtEmail_Validated(object sender, EventArgs e)
        {
            
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtThird_Validating(object sender, CancelEventArgs e)
        {

        }

        private void ValidatingEmptyTextBox(object sender, EventArgs e)
        {

        }
    }
}
