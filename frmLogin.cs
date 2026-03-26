using System.Diagnostics;
using System;
using Microsoft.Win32;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static Guna.UI2.WinForms.Suite.Descriptions;
using CarRental_3_.Properties;
using CarRental_Business;
using NCarRental_Bussnies;
using System.Security.Principal;
using System.Security;


namespace CarRental_V2_
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\CarRentalManagementSystemRegistry";
        string UserNameRegistryKey = "UserName";
        string PasswordRegistryKey = "Password";
        private void guna2Button1_Click(object sender, EventArgs e)
        {
             
              
            
           
           
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        { 
           
          
                try {
                            txtUserName.Text = Registry.GetValue(keyPath, UserNameRegistryKey, null) as string;
                            txtPassword.Text = Registry.GetValue(keyPath, PasswordRegistryKey, null) as string;


              

          
                 } catch(Exception ex)
           
                   {
                       MessageBox.Show("Failed Login Registry !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                   }

            
          

         

        }

       

        private void guna2ImageCheckBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            
          

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != null && txtPassword.Text != null)

            {
                clsUser User = clsUser.Login(txtUserName.Text, txtPassword.Text);
                clsGlobal.CurrentUser = User;
                if (User == null)
                {
                    string SourceName = "Car Managment System";



                    HandleLogErrors(SourceName);





                    return;
                }
                if (chkRememberMe.Checked == true)
                {
                    RegestriyHelper.SaveEncryptedPasswordIfNotExists(txtUserName.Text, txtPassword.Text);
                }
                else
                {
                    RegestriyHelper.ClearEncryptedPassword();
                }

                if (!User.IsActive)
                {
                    string SourceName = "Car Managment System";

                    if (!EventLog.SourceExists(SourceName))
                    {
                        EventLog.CreateEventSource(SourceName, "Application");

                    }
                    MessageBox.Show("This Account Is UnActive to solve that Contact Your Admin  ", "UnActive Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    EventLog.WriteEntry(SourceName, "The Error is in Login Screen When UnActive User Account Try To Enter The System  ", EventLogEntryType.Error);
                    return;

                }

                frmMain frm = new frmMain();
                frm.ShowDialog();


            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        private void guna2CustomCheckBox1_Click(object sender, EventArgs e)
        {

        }
        private void HandleLogErrors(string SourceName)
        {
            try
            {
                if (!EventLog.SourceExists(SourceName))
                {
                    if (IsUserAdministrator())
                    {
                        EventLog.CreateEventSource(SourceName, "Application");
                    }
                    else
                    {
                        MessageBox.Show("Insufficient permissions to create event source. Please run the application as an administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                EventLog.WriteEntry(SourceName, "The Error is in Login Screen When You Click Login and Could not find the User so it returns null.", EventLogEntryType.Error);
            }
            catch (SecurityException secEx)
            {
                MessageBox.Show("Wrong UserName OR Password Contact Your Admin", "Wrong Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private bool IsUserAdministrator()
        {
            try
            {
                WindowsIdentity user = WindowsIdentity.GetCurrent();
                WindowsPrincipal principal = new WindowsPrincipal(user);
                return principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
            catch
            {
                return false;
            }
        }

        private void chkRememberMe_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
