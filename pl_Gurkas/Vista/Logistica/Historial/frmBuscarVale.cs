using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pl_Gurkas.Vista.Logistica.Historial
{
    public partial class frmBuscarVale : Form
    {
        string cod_personal;
        string nomb_personal;

        public frmBuscarVale()
        {
            InitializeComponent();
        }

        private void frmBuscarVale_Load(object sender, EventArgs e)
        {
            textBox1.Text = nomb_personal;
        }
    }
}
