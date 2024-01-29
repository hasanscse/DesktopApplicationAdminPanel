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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

            Dashboard obj = new Dashboard();
            obj.MdiParent = this;
            obj.Show();

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
