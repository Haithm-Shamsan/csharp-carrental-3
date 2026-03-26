using CarRental_BussnissLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Caching;
using System.Windows.Forms;

namespace CarRental_3_
{
    public partial class ctrVehcileCard : UserControl
    {   static public int _VehicleID;

        public void EnableChooseButton(bool Resulte)
        {
            btnChoseVehicle.Enabled = Resulte;
          
        }
        public ctrVehcileCard()
        {
            InitializeComponent();
        }
     
        public class DataSentEventArgs : EventArgs
        {
            public DataSentEventArgs(int vehicleID, string model, string make, int year, decimal price)
            {
                VehicleID = vehicleID;
                Model = model;
                Make = make;
                Year = year;
                Price = price;
                _VehicleID = vehicleID;
            }


            public int VehicleID { get; }
            public string Model { get; }
            public string Make { get; }

            public int Year { get; }
            public decimal Price {get;}
           

           
        } 
        public delegate void DataSentEventHandler(object sender, DataSentEventArgs e);

            // Define the event using the delegate
           static public event DataSentEventHandler DataSent;
        public int VehicleID { set; get; }
        public string Model { set; get; }
        public string Make { set; get; }

        public int Year { set; get; }
         
        public decimal Price { set; get; }
         public string ImagePath{ set; get; }


        public void LoadInfo()
        {
            pbImage.Load(ImagePath);
            lblMake.Text = Make;
            lblYear.Text = Year.ToString();
            lblModel.Text = Model;
            lblPrice.Text= Price.ToString()+" $";
        }
        private void ctrVehcileInfo_Load(object sender, EventArgs e)
        {
            LoadInfo();
        }
         
        
        protected virtual void RaisEvent(object sender,DataSentEventArgs e)
        {
            DataSent?.Invoke(sender, e);
        }

        private void pbImage_Click(object sender, EventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
      
        private  void btnChoseVehicle_Click(object sender, EventArgs e)
        {
           
            RaisEvent(this,new DataSentEventArgs(VehicleID, Model, Make, Year,Price));

        }
    }
}
