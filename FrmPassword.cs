using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MultiFaceRec
{
    public partial class FrmPassword : Form
    {
        private string password;
        private Thread thread;
        public FrmPassword(string password, string name)
        {
            InitializeComponent();
            this.password = password;
            txtTitle.Text = "Hello: " + name;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(password))
            {
                thread = new Thread(openFrmInfor);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
                this.Close();
            }
            else {
                MessageBox.Show("Password is incorrect","Incorrect",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void openFrmInfor()
        {
            Application.Run(new FrmInfor());
        }
    }
}
