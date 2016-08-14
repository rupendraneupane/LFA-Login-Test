using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            lblLoginAttempt.Visible = false;
            lblAttempt.Visible = false;
                        
        }

        private void lblDisplay_Click(object sender, EventArgs e)
        {

        }
        private int count = 0;
        private void btnLogin_Click(object sender, EventArgs e)
        {

          if (txtUsername.Text=="rupendra" && txtPassword.Text=="admin123")
            {
                
                    ManiWindow mw = new ManiWindow();
                    mw.Show();

            }

            else
            {
               count++;
                    //MessageBox.Show("Username / Password Incorrect : " + (3 - count) + " attempts more.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     
              
                     MessageBox.Show("Username / Password Incorrect", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     lblLoginAttempt.Text = Convert.ToString(3-count);
                     lblLoginAttempt.Visible = true;
                     lblAttempt.Visible = true;


                     if (count == 3)
                     {
                         Application.Exit();
                     }
            }
            
            
        }
        

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}