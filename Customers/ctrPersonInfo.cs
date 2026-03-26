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
    public partial class ctrPersonInfo : UserControl
    {
        public ctrPersonInfo()
        {
            InitializeComponent();
        }
        clsPerson _Person;


        public class clsPersonInfoFoundArgs : EventArgs
        {
          public int _PersonID { get; }
          public string _PersonName { get; }
          public string _NationalNo { get; }

            public clsPersonInfoFoundArgs(int PerosnId, string PersonName, string NationalNo)
            {
                _PersonID = PerosnId;
                _PersonName = PersonName;
                _NationalNo = NationalNo;

            }
        }

        public event EventHandler<clsPersonInfoFoundArgs>PersonInfo;

        public void RaiseOnPersonInfoFound(int PersonId, string PersonName, string NationalNo)
        {
            RaisePersonFound(new clsPersonInfoFoundArgs(PersonId,PersonName,NationalNo));
        }

        protected virtual void RaisePersonFound(clsPersonInfoFoundArgs e)
        {
            PersonInfo?.Invoke(this, e);
        }



     

        public void LoadPersonInfo(int PersonID)
        { 
            _Person=clsPerson.GetPerson(PersonID);

            if(_Person==null)
            {
                MessageBox.Show("There Is no Perosn With this ID !","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            lblCustomerID.Text=_Person.PersonID.ToString();
            lblFullName.Text=_Person.FullName;
            lblEmail.Text=_Person.Email;
            lblDateOfBirth.Text=_Person.DateOfBirth.ToString("yyyy/MM/dd");
            lblNationalNO.Text = _Person.NationalNo;
            lblPhone.Text= _Person.Phone;
            pbPersonImage.Load(_Person.ImagePath);

            if(PersonInfo!=null)
            {
                RaiseOnPersonInfoFound(_Person.PersonID, _Person.FullName, _Person.NationalNo);
            }
            
        }

        //public void LoadCustomerInfo(int CustomerID)
        //{
        //    _Customer =clsCustomers.Find(CustomerID);

        //    if (_Customer == null)
        //    {
        //        MessageBox.Show("There Is no Customer With this ID !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }
        //    lblCustomerID.Text =_Customer.CustomerID.ToString();


        //}

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ctrPersonInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
