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

namespace CarRental_V2_
{
    public partial class frmShowPersonInfo : Form
    {
        int _PerosnID;
        public frmShowPersonInfo(int PersonID)
        {
            InitializeComponent();
            _PerosnID = PersonID;
        }

       

      

        private void frmShowPersonInfo_Load(object sender, EventArgs e)
        {
            ctrPersonInfo1.LoadPersonInfo(_PerosnID);
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrPersonInfo1_PersonInfo(object sender, CarRental_3_.ctrPersonInfo.clsPersonInfoFoundArgs e)
        {
           
        }

        private void ctrPersonInfo1_PersonInfo_1(object sender, CarRental_3_.ctrPersonInfo.clsPersonInfoFoundArgs e)
        {
           
        }
    }
}
