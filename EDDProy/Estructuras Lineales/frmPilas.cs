using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using EDDemo.Clases;

namespace EDDemo
{
    public partial class frmPilas : Form
    {
        public frmPilas()
        {
            InitializeComponent();
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            String var2;

            Pilas miPila = new Pilas();
            miPila.Push();          
        }
    }
}
