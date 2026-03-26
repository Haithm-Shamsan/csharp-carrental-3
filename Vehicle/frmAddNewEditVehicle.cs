using CarRental_BussnissLayer;
using NCarRental_Bussnies;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Guna.UI2.WinForms;
using System.Runtime.InteropServices;

namespace CarRental_3_
{
    public partial class frmAddNewCar : Form
    {   
        enum enMode { AddNew ,Update}
        enMode Mode;

        int _VehicleID;

        clsVehicle _Vehicle;

        public frmAddNewCar(int VehicleID)
        {
            InitializeComponent();
            _VehicleID= VehicleID;

                Mode=enMode.Update;
            

        }

        public frmAddNewCar()
        {
            InitializeComponent();
            Mode = enMode.AddNew;
        }
         
        //void LoadFuleType()
        //{
        //    DataTable Data = clsFuleType.GetFuleTypes();
        //    foreach(DataRow Item in Data.Rows)
        //    {
        //        cmFuelType.Items.Add(Item["FuleType"]);
        //    }
        //}  

        //void LoadCarCategory()
        //{
        //    DataTable Data = clsVehicleCategory.GetVehicleCategories();
        //    foreach (DataRow Row in Data.Rows)
        //    {
        //        cbCarCategory.Items.Add(Row["CategoryName"]);
        //    }
        //}

        bool _HandlImage()
        {
            if (_Vehicle.ImagePath != pbImage.ImageLocation)
            {

                if (_Vehicle.ImagePath != "")
                {
                    try
                    {
                        File.Delete(_Vehicle.ImagePath);


                    }
                    catch
                    {

                    }

                }

                if (pbImage.ImageLocation != null)
                {
                    string SourcePath = pbImage.ImageLocation;

                    if (clsUtil.CopyCarImageToProjectFile(ref SourcePath))
                    {
                        pbImage.ImageLocation = SourcePath;
                        return true;
                    }
                    else
                    {
                       MessageBox.Show("Failed Saveing Image !","Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }
        //private bool _HandlePersonImage()
        //{

        //    //this procedure will handle the person image,
        //    //it will take care of deleting the old image from the folder
        //    //in case the image changed. and it will rename the new image with guid and 
        //    // place it in the images folder.


        //    //_Person.ImagePath contains the old Image, we check if it changed then we copy the new image
        //    if (_Person.ImagePath != pbPersonImage.ImageLocation)
        //    {
        //        if (_Person.ImagePath != "")
        //        {
        //            //first we delete the old image from the folder in case there is any.

        //            try
        //            {
        //                File.Delete(_Person.ImagePath);
        //            }
        //            catch (IOException)
        //            {
        //                // We could not delete the file.
        //                //log it later   
        //            }
        //        }

        //        if (pbPersonImage.ImageLocation != null)
        //        {
        //            //then we copy the new image to the image folder after we rename it
        //            string SourceImageFile = pbPersonImage.ImageLocation.ToString();

        //            if (clsUtil.CopyImageToProjectImagesFolder(ref SourceImageFile))
        //            {
        //                pbPersonImage.ImageLocation = SourceImageFile;
        //                return true;
        //            }
        //            else
        //            {
        //                MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                return false;
        //            }
        //        }

        //    }
        //    return true;
        //}
        void _LoadVehicleInformation()
        {
            //LoadFuleType();
            //LoadCarCategory();
              
            _Vehicle = clsVehicle.GetVehicle(_VehicleID);

            if(_Vehicle == null)
            { txtMileage.Focus();
                _Vehicle= new clsVehicle();

                lblMode.Text = "Add New Vehicle";
                return;
            }

            txtMileage.Focus();


            cbCarCategory.SelectedIndex=cbCarCategory.FindString(_Vehicle.VehicleCategoryInfo.CategoryName);
            cmFuelType.SelectedIndex =cmFuelType.FindString(_Vehicle.VehicleFuleType.FuleType);
            lblMode.Text = "Update Vehicle Infomation";
            chkIsAvilable.Checked = _Vehicle.IsAvailableForRent;
            lblVehicleID.Text = _Vehicle.VehicleID.ToString();
            txtModel.Text=_Vehicle.Model;
            txtMileage.Text=_Vehicle.Mileage.ToString();
            txtMake.Text = _Vehicle.Make;
            txtPlateNumber.Text=_Vehicle.PlateNumber;
            txtRentalPrice.Text=Convert.ToString(_Vehicle.RentalPricePerDay);
            txtYear.Text= _Vehicle.Year.ToString();
            pbImage.ImageLocation = _Vehicle.ImagePath;
                                   
            
        }

     
        private void frmAddNewCar_Load(object sender, EventArgs e)
        {
            _LoadVehicleInformation();
        }

        private void btnSave_Click(object sender, EventArgs e)
        { 
            if(MessageBox.Show("Are you sure do you want to save this Vehicle","Cinform",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.No)
            {
                return;
            }

            if(!ValidateChildren())
            {
                return;
            }
            if (!_HandlImage())
                return;



            _Vehicle.Make = txtMake.Text;
            _Vehicle.Model=txtModel.Text;
            _Vehicle.CarCategoryID = clsVehicleCategory.GetCategoryByName(cbCarCategory.SelectedItem.ToString()).CategoryID;

            _Vehicle.FuelTypeID = clsFuleType.GetFuleTypeByName(cmFuelType.SelectedItem.ToString()).ID;
            _Vehicle.Mileage = int.Parse(txtMileage.Text);
            _Vehicle.PlateNumber = txtPlateNumber.Text;
            _Vehicle.RentalPricePerDay = Convert.ToDecimal(txtRentalPrice.Text);
            _Vehicle.Year = int.Parse(txtYear.Text);
            _Vehicle.IsAvailableForRent = chkIsAvilable.Checked;
            _Vehicle.ImagePath = pbImage.ImageLocation;
            _Vehicle.CreatedByUserID=clsGlobal.CurrentUser.UserID;
            if(_Vehicle.Save())
            {
                lblVehicleID.Text = _Vehicle.VehicleID.ToString();
                lblMode.Text = "Update Vehicle Informaiton";
                MessageBox.Show("Vehicle Saved Seccussfully","Saved",MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }else
            {
                MessageBox.Show("Vehicle Saveing Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }

       

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ValidatingEmptyTextBox(Guna2TextBox TextBox, CancelEventArgs e)
        {
             Guna2TextBox Temp=(Guna2TextBox)TextBox;
            if(string.IsNullOrEmpty(Temp.Text))
            {
                e.Cancel = true;
                errorProvider2.SetError(Temp,"it is Required");
            }else
            {
                errorProvider2.Clear();
            }
        }

        private void ValidatingEmptyTextBox(object sender, CancelEventArgs e)
        {

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
            pbImage.Image = null;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
