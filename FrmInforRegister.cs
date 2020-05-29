using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MultiFaceRec
{
    public partial class FrmInforRegister : Form
    {
        public FrmInforRegister(Image<Gray, byte> image)
        {
            InitializeComponent();
            imageBox1.Image = image;
        }
    }
}
