
#define AddNew
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
using System.Diagnostics;
using Guna;
using Guna.UI2.WinForms;
using System.Runtime.CompilerServices;

namespace CarRental_3_
{
    public partial class frmAddNewEditBooking : Form
    {
        int _BookingID;
        int TransactionID;
        public frmAddNewEditBooking(int BookingID)
        {
            InitializeComponent();
            _BookingID = BookingID;
            Mode = enMode.Update;

        }
        public frmAddNewEditBooking()
        {
            InitializeComponent();
            Mode = enMode.AddNew;
        }
        enum enMode { AddNew,Update}
        enMode Mode;
        Nullable<int> OnVehicleIDChoosen;
        Nullable<int> OnCustomerSelected;
        Nullable<Decimal> VehiclePrice;
        decimal TotalAmmount;
        clsRentalBooking _Booking=new clsRentalBooking();




        void _UpdateBooking()
        {
            _Booking = clsRentalBooking.GetRentalBooking(_BookingID);

            if(_Booking==null)
            {
                MessageBox.Show("Couldnt Find this Booking contact your Admin ","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            llTrancationDeteils.Enabled = true;
            OnVehicleIDChoosen = (int)_Booking.VehicleID;
            OnCustomerSelected = (int)_Booking.CustomerID;
            ctrCustomerInfoWithFilter2.LoadCustomerInfo((int)OnCustomerSelected);
            VehiclePrice = _Booking._VehicleInfo.RentalPricePerDay;
            lblBookingID.Text=_Booking.BookingID.ToString();
            lblrentalDays.Text=lblrentalDays.ToString();
            lblRentalPrice.Text = _Booking.RentalPricePerDay.ToString();
            lblTotalPrice.Text=_Booking.InitialTotalDueAmount.ToString();
            txtDropOffLocation.Text = _Booking.DropoffLocation;
            txtPickUpLocation.Text = _Booking.PickupLocation;
            dtStart.Value = _Booking.RentalStartDate;
            txtNote.Text = _Booking.InitialCheckNotes;
            dtEnd.Value= _Booking.RentalEndDate;
            TotalAmmount = _Booking.InitialTotalDueAmount;


        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        #region VehicleScreen
        void AddVehicle(int VehicleID,string VehicleName,string VehicleMake,int Year,decimal Price,string VehicleImage)
        {

            flowLayoutPanel1.Controls.Add(new ctrVehcileCard()
            {
                VehicleID = VehicleID,
                Make = VehicleMake,
                Model = VehicleName,
                Year = Year,
                ImagePath = VehicleImage,
                Price = Price


            }) ;
            EnableControlsAfterChoseOn();
            ctrVehcileCard.DataSent += ChoosenVehicle;

        }

        void EnableControlsAfterChoseOn()
        { 
            if(Mode==enMode.Update)
            foreach(ctrVehcileCard control in flowLayoutPanel1.Controls)
            {
                if(control.VehicleID!=_Booking.VehicleID)
                control.EnableChooseButton(false);
                else
                  control.EnableChooseButton(true);
                    
            }
           
        }
       void ChoosenVehicle(object sender,ctrVehcileCard.DataSentEventArgs e)
        { 
            
           OnVehicleIDChoosen=e.VehicleID;
            VehiclePrice = e.Price;
           
           foreach(ctrVehcileCard contorl in flowLayoutPanel1.Controls)
            {
                if(e.VehicleID==contorl.VehicleID)
                {
                    contorl.EnableChooseButton(true);
                }
                else
                {
                    contorl.EnableChooseButton(false);
                }
            }
         
        }
        private void frmAddNewEditBooking_Shown(object sender, EventArgs e)
        {
            DataTable Vehicles = clsVehicle.GetActiveVehicles();

            foreach(DataRow Row in Vehicles.Rows)
            {
                AddVehicle((int)Row["VehicleID"],(string)Row["Make"], (string)Row["Model"], (int)Row["Year"], (decimal)Row["RentalPricePerDay"],(string)Row["ImagePath"]) ;
               
            }
        }
   private void guna2Button2_Click(object sender, EventArgs e)
        { 
            if(OnVehicleIDChoosen!=null)
            MainTab.SelectedTab = MainTab.TabPages["tbCustomer"];
       
            else
            {
                MessageBox.Show("You should chose Vehicle To Complate the proccess","Worning",MessageBoxButtons.OK,MessageBoxIcon.Error);

            } 
            lblRentalPrice.Text = VehiclePrice.ToString()+" $";
        }
        #endregion
        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }
        
        private void btnSave_Click_1(object sender, EventArgs e)
        {

            if(MessageBox.Show("Are you sure do you want to save this booking ?","Confrim",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.No)
            {
                return;
            }

            if (!this.ValidateChildren())
                return;

            if (Convert.ToInt16(lblrentalDays.Text) <= 0) {
                MessageBox.Show("Invalied Perioed Enterd", "Error", MessageBoxButtons.OK);
                    return;
            }

            _Booking.CustomerID = (int)OnCustomerSelected;
            _Booking.VehicleID = (int)OnVehicleIDChoosen;
            _Booking.RentalStartDate = dtStart.Value;
            _Booking.RentalEndDate= dtEnd.Value;
            _Booking.PickupLocation=txtPickUpLocation.Text;
            _Booking.DropoffLocation=txtDropOffLocation.Text;
            _Booking.InitialRentalDays=Convert.ToByte(lblrentalDays.Text);
            _Booking.InitialTotalDueAmount=Convert.ToDecimal(lblTotalPrice.Text);
            _Booking.RentalPricePerDay = VehiclePrice.Value;
            _Booking.CreatedByUserID=clsGlobal.CurrentUser.UserID;
            _Booking.InitialCheckNotes = txtNote.Text;
            _Booking.BookingStatus = (byte)clsRentalBooking.enStatus.New;

            if(!_Booking.Save())
            {
               MessageBox.Show("Failed Save Booking try Again or conract your admin","Failed",MessageBoxButtons.OK,MessageBoxIcon.Error); 
                return;
                
            }


            MessageBox.Show("Booking Saved Secussfully ", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Mode = enMode.Update;

               llTrancationDeteils.Enabled = _Booking.TransactionID!= -1;
               




        }

      
      
        private void frmAddNewEditBooking_Load(object sender, EventArgs e)
        {
            if(Mode==enMode.Update)
            { 
                _UpdateBooking();
                EnableControlsAfterChoseOn();
                MainTab.SelectedTab = MainTab.TabPages["tbBooking"];
            }
           
           
        }

        private void btnNext_Click(object sender)
        {
          
            
        }
     void RentalPieroed()
        {

            TimeSpan Deff = new TimeSpan();

            DateTime End = new DateTime();
            End = dtEnd.Value;

            Deff = End.Subtract(dtStart.Value);
           lblrentalDays.Text = Deff.ToString("dd");

         Decimal RentalDays = Convert.ToDecimal(lblrentalDays.Text);
            Decimal TotalFees = RentalDays *(Decimal) VehiclePrice;
           lblTotalPrice.Text = TotalFees.ToString();
        }
       
    

      
   
        private void dtEnd_ValueChanged(object sender, EventArgs e)
        {

            RentalPieroed();
           



        }
        
        private void btnNext_Click(object sender, EventArgs e)
        {
           
      
           lblRentalPrice.Text = VehiclePrice.ToString();
            dtStart.MinDate = DateTime.Now.Date;
            dtEnd.MinDate=DateTime.Now.Date;
            if (OnCustomerSelected != null)
                MainTab.SelectedTab = MainTab.TabPages["tbBooking"];
            else
            {
                MessageBox.Show("You should chose Vehicle To Complate the proccess", "Worning", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void ctrCustomerInfoWithFilter1_CustomerInfo(object sender, ctrCustomerInfoWithFilter.clsCustomerInfoFoundArgs e)
        {
            OnCustomerSelected = e.CustomerID;
        }

        private void tbTransaction_Click(object sender, EventArgs e)
        {

        }

        void TransactionInfo()
        {
           
        }

        private void llTrancationDeteils_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowTransaction frm = new frmShowTransaction(_Booking.BookingID);
                frm.ShowDialog();
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

        private void ctrCustomerInfoWithFilter2_CustomerInfo(object sender, ctrCustomerInfoWithFilter.clsCustomerInfoFoundArgs e)
        {
             OnCustomerSelected=e.CustomerID;
        }

        private void tbCustomer_Click(object sender, EventArgs e)
        {

        }
    }
}
  