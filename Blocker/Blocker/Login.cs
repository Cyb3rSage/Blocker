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
using Microsoft.Win32;
using System.Threading;

namespace Blocker
{

    public partial class frmLogin : Form
    {
        
        //String Values
        string RegistryKey = @"HKEY_CURRENT_USER\Blocker";
        string RegistryValue = "FirstRun";
        string RegistryValuepass = "Password";

        public  frmLogin()
        {
            InitializeComponent();
            Firstrun();      
           
        }
        public void Firstrun()
        {
            //Check to see if its first Run 
            
            
            if (Convert.ToInt32(Microsoft.Win32.Registry.GetValue(RegistryKey, RegistryValue, 0)) == 0)
            {
                try
                {
                    FileInfo fileInfo = new FileInfo(frmBlock.hostspath);
                    fileInfo.IsReadOnly = false;
                    File.WriteAllText(frmBlock.hostspath, String.Empty);
                }
                catch
                {
                    MessageBox.Show("Please run as Administrator");
                    
                }

                MessageBox.Show("Welcome Please Setup Your Password ");                
                btnLogin.Visible = false;
                lblPassword.Text = "Enter password below then press save";
              
            }
            else
            {
                
                lblPassword.Text = "Enter Password";
                btnSave.Visible = false;

            }           
          

        }


        public void label1_Click(object sender, EventArgs e)
        {

        }

        public void txtbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        public void btnLogin_Click(object sender, EventArgs e)
        {
            //Login Button Logic
           var password = (string) Registry.GetValue(RegistryKey, RegistryValuepass,0);           
             string userinput = txtbPassword.Text;
            if (userinput==password)
            {
                this.Visible = false;
                 frmBlock form = new frmBlock();
      
                form.Show();

            }
            else
            {
                
                MessageBox.Show("       Wrong Password");
                
                Application.Exit();
            }
        }

        public void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Save Button Logic
            if (txtbPassword.Text == String.Empty)
            {
                MessageBox.Show("Blank Password's Not Accepted");
            }
            else
            {
                Registry.SetValue(RegistryKey, RegistryValuepass, txtbPassword.Text);
                this.Visible = false;
                frmBlock form = new frmBlock();
                //Change the value since the program has run once now
                Microsoft.Win32.Registry.SetValue(RegistryKey, RegistryValue, 1, Microsoft.Win32.RegistryValueKind.DWord);

                form.Show();
            }
            
        }

        private void frmLogin_Shown(object sender, EventArgs e)
        {
            //Focuses Text box when form loads
            txtbPassword.Focus();
        }
    }
}
