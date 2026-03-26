using CarRental_Business;
using NCarRental_Bussnies;
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
using Guna.UI2.WinForms;

namespace CarRental_3_
{
    public partial class frmAddEditUser : Form
    {  
        enum enMode { AddNew ,Update}
        enMode Mode;

        int _UserID;
        clsUser _User;
        public frmAddEditUser()
        {
            InitializeComponent();
            Mode = enMode.AddNew;
            lblMode.Text = "Add New User";
            _User=new clsUser();

        }
        public frmAddEditUser(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
            lblMode.Text = "Update User";
            Mode = enMode.Update;

        }

        void LoadUserInfo()
        {
            if (Mode == enMode.AddNew)
                return;

            _User = clsUser.GetUser(_UserID);

            if(_User == null)
            {
                MessageBox.Show("There is no User With this ID","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            chkIsActive.Checked = _User.IsActive;
            lblPersonID.Text = _User.PersonID.ToString();
            txtFirstName.Text = _User.FirstName;
            txtSecondName.Text = _User.SecondName;
            txtLastName.Text = _User.LastName;
            txtNationalNo.Text = _User.NationalNo;
            txtPhone.Text = _User.Phone;
            txtEmail.Text = _User.Email;
            dtDateOfBirth.Value = _User.DateOfBirth;
            txtThird.Text = _User.ThirdName;
            pbImage.ImageLocation = _User.ImagePath;
            txtUserName.Text=_User.UserName;
            txtPassword.Text = _User.Password;
            txtConfirm.Text = txtPassword.Text;
          

        }


        bool _HandlImage()
        {
            if (_User.ImagePath != pbImage.ImageLocation)
            {

                if (pbImage.ImageLocation != "")
                {
                    try
                    {
                       File.Delete(_User.ImagePath);


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
                        MessageBox.Show("Image Saveing Failed","Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!ValidateChildren())
                return;

            if (!_HandlImage())
                return;


           

            _User.UserName = txtUserName.Text;
            _User.Password = txtPassword.Text;
            _User.FirstName = txtFirstName.Text;
            _User.SecondName=txtSecondName.Text;
            _User.LastName = txtLastName.Text;
            _User.ThirdName = txtThird.Text;
            _User.Email = txtEmail.Text;
            _User.NationalNo=txtNationalNo.Text;
            _User.Phone = txtPhone.Text;
            _User.ImagePath = pbImage.ImageLocation;
            _User.DateOfBirth=dtDateOfBirth.Value;
            _User.IsActive = chkIsActive.Checked;
            _User.CreatedByUserID = clsGlobal.CurrentUser.UserID;
             
            if(_User.Save())
            {
                MessageBox.Show("User Saved Seccussfuly","Saved",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                lblPersonID.Text = _User.UserID.ToString();
                Mode = enMode.Update;
            }

        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddEditUser_Load(object sender, EventArgs e)
        {
            LoadUserInfo();
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

                pbImage.ImageLocation = (selectedFilePath);
            }
        }

        private void RemovePhoto_Click(object sender, EventArgs e)
        {
            pbImage.ImageLocation = null;
        }
        private void ValidatingEmptyTextBox(Guna2TextBox sender, CancelEventArgs e)
        {
            Guna2TextBox Temp = (Guna2TextBox)sender;

            if (string.IsNullOrEmpty(Temp.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This Filed is required");

            }
            else
            {
                errorProvider1.Clear();
            }
        }
        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!clsUtil.IsValiedEmail(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "Invalied Email !");
                e.Cancel = true;

            }
            else
            {
                errorProvider1.Clear();

            }
        }
        private void txtConfirm_Validating(object sender, CancelEventArgs e)
        {
            if(txtConfirm.Text!=txtPassword.Text)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirm, "it should be the same as password");
            }else
            {
                errorProvider1.Clear();
                
            }
        }

        private void ValidatingEmptyTextBox(object sender, CancelEventArgs e)
        {
            Guna2TextBox Temp = (Guna2TextBox)sender;

            if (string.IsNullOrEmpty(Temp.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This Filed is required");

            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
