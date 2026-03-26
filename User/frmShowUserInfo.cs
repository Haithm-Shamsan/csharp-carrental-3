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
    public partial class frmShowUserInfo : Form
    { 
        int UserID;
        clsUser _User;
        public frmShowUserInfo(int userID)
        {
            InitializeComponent();
            UserID = userID;
        }

         
        private void frmShowUserInfo_Load(object sender, EventArgs e)
        {
            _User = clsUser.GetUser(UserID);
            ctrPersonInfo1.LoadPersonInfo(_User.PersonID);
            lblUserName.Text=_User.UserName;
    
                
                if(clsUser.GetUser(UserID).IsActive)
            {
                lblIsActive.Text = "Yes";
            }else
            {
                lblIsActive.Text = "No";
            }
        }

        private void ctrPersonInfo1_Load(object sender, EventArgs e)
        {

        }
    }
}
