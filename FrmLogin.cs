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
    public partial class FrmLogin : Form
    {
        Thread thread;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //FrmPrincipal frm = new FrmPrincipal();
            thread = new Thread(openFormRegister);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
           
        }

        private void openFormRegister()
        {
            Application.Run(new FrmRegister());
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FrmPrincipal frm = new FrmPrincipal();
            frm.Show();
        }
    }
}
