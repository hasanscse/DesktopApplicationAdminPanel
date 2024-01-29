using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApplicationAdminPanel
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            try 
            { 
            Home obj = new Home();  
            obj.Show();
            
            
            
            }
            catch { }



        }
    }
}
