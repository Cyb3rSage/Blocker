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
using System.Threading;

namespace Blocker
{
    public partial class frmBlock : Form

    {
        


        //Path to host file 
        public static string hostspath = "C:\\Windows\\system32\\drivers\\etc\\hosts";
        public string Blocklist = null;
        public string Clear = "";

        
    
        public frmBlock()
        {
            InitializeComponent();
            //Check first run

            

            //List blocked sites in text box. 
            Blocklist = File.ReadAllText(hostspath);           
                 
          Listboxpopulate();
        
        }
            public void Listboxpopulate()
        {
            //Populate Listbox with websites
            foreach (string line in File.ReadLines(hostspath))
            {
                lstbWebsites.Items.Add(line.Replace("127.0.0.1", ""));               
            }

            //Removes Whitespace in list
            int count = lstbWebsites.Items.Count;
            for (int i = count - 1; i >=0; i--)
            {
                if (String.IsNullOrWhiteSpace(lstbWebsites.Items[i].ToString()))
                {
                    lstbWebsites.Items.RemoveAt(i);

                }

            }
           
        }         


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            //Add website to host file. 

            
            btnSave.Enabled = false;
            try
            {

                string Newwebsite = " \r\n" + "127.0.0.1" + " " + (txtbAdd.Text);
                File.AppendAllText(hostspath, Newwebsite);
                Blocklist = File.ReadAllText(hostspath);
                lstbWebsites.Text = Blocklist.Replace("127.0.0.1", "").ToString();
                lstbWebsites.Items.Clear();
                Listboxpopulate();
                

            }
            catch
            {
                MessageBox.Show("Run application as Administrator");
            }

            btnSave.Enabled = true;
            
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clears Listbox
            try
            {
                File.WriteAllText(hostspath, Clear);
                Blocklist = File.ReadAllText(hostspath);               
                lstbWebsites.Text = Blocklist.Replace("127.0.0.1", "").ToString();
                lstbWebsites.Items.Clear();
                Listboxpopulate();
            }
            catch
            {
                MessageBox.Show("Run application as Administrator");
            }


        }

        private void lstbWebsites_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Removes Selected Item
            try
            {
                btnRemove.Enabled = false;
                string removal = "\r\n" + "127.0.0.1" + lstbWebsites.SelectedItem.ToString();
                 Blocklist = Blocklist.Replace(removal, " ");
                File.WriteAllText(hostspath, Blocklist);
                lstbWebsites.Text = Blocklist.Replace("127.0.0.1", "").ToString();
                lstbWebsites.Items.Clear();
                Listboxpopulate();

            }
            catch
            {
                MessageBox.Show("Select a Website First");
            }

            btnRemove.Enabled = true;
        }

        private void frmBlock_Shown(object sender, EventArgs e)
        {
            //Focuses Text box when form loads
            txtbAdd.Focus();
        }
    }
}
