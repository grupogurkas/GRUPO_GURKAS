using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pl_Gurkas.Vista.Principal
{
    public partial class frmPrincipalConsorcioTECSEGUR : Form
    {
        public frmPrincipalConsorcioTECSEGUR()
        {
            InitializeComponent();
        }
        public int _idempresa;
        public string _nombreempresa;
        public string _usuario;
        public string _perfil;
        public int _codrol;
        string ipuser = "";
        string nombrepc = "";
        string result = "";
        int estado = 0;
        Datos.Conexiondbo conexion = new Datos.Conexiondbo();
        Datos.AuditoriaModulos modulo = new Datos.AuditoriaModulos();
        Vista.ControlVistaFormulario controlvistaformulario = new Vista.ControlVistaFormulario();
        public void obtenerip_nombre()
        {
            string strHostName = string.Empty;
            // Obteniendo la dirección IP de la máquina local…
            // Primero obtenga el nombre de host de la máquina local.
            strHostName = Dns.GetHostName();
            // Luego, usando el nombre de host, obtenga la lista de direcciones IP.
            IPAddress[] hostIPs = Dns.GetHostAddresses(strHostName);
            for (int i = 0; i < hostIPs.Length; i++)
            {
                ipuser = "Direccion IP: " + hostIPs[i].ToString();

            }
            nombrepc = "Nombre de la computadora: " + strHostName;
        }
        public void perfiles()
        {
            int nivel = _codrol;
            if (nivel == 1)
            {
                recursosHumanosToolStripMenuItem.Enabled = true;
                centroDeControlToolStripMenuItem.Enabled = true;
                operacionesToolStripMenuItem.Enabled = true;
                comercialToolStripMenuItem.Enabled = true;
                logisticaToolStripMenuItem.Enabled = true;
                planillaToolStripMenuItem.Enabled = true;
                contabilidadToolStripMenuItem.Enabled = true;
                sucamecToolStripMenuItem.Enabled = true;
                administradorToolStripMenuItem.Enabled = true;
            }
            if (nivel == 2)
            {
                centroDeControlToolStripMenuItem.Enabled = false;
                operacionesToolStripMenuItem.Enabled = false;
                comercialToolStripMenuItem.Enabled = false;
                logisticaToolStripMenuItem.Enabled = false;
                planillaToolStripMenuItem.Enabled = false;
                contabilidadToolStripMenuItem.Enabled = false;
                sucamecToolStripMenuItem.Enabled = false;
                administradorToolStripMenuItem.Enabled = false;
            }
            if (nivel == 3)
            {
                recursosHumanosToolStripMenuItem.Enabled = false;
                //centroDeControlToolStripMenuItem.Enabled = false;
                operacionesToolStripMenuItem.Enabled = false;
                comercialToolStripMenuItem.Enabled = false;
                logisticaToolStripMenuItem.Enabled = false;
                planillaToolStripMenuItem.Enabled = false;
                contabilidadToolStripMenuItem.Enabled = false;
                sucamecToolStripMenuItem.Enabled = false;
                administradorToolStripMenuItem.Enabled = false;
            }
            if (nivel == 4)
            {
                recursosHumanosToolStripMenuItem.Enabled = false;
                centroDeControlToolStripMenuItem.Enabled = false;
                //operacionesToolStripMenuItem.Enabled = false;
                comercialToolStripMenuItem.Enabled = false;
                logisticaToolStripMenuItem.Enabled = false;
                planillaToolStripMenuItem.Enabled = false;
                contabilidadToolStripMenuItem.Enabled = false;
                sucamecToolStripMenuItem.Enabled = false;
                administradorToolStripMenuItem.Enabled = false;
            }
            if (nivel == 5)
            {
                recursosHumanosToolStripMenuItem.Enabled = false;
                centroDeControlToolStripMenuItem.Enabled = false;
                operacionesToolStripMenuItem.Enabled = false;
                // comercialToolStripMenuItem.Enabled = false;
                logisticaToolStripMenuItem.Enabled = false;
                planillaToolStripMenuItem.Enabled = false;
                contabilidadToolStripMenuItem.Enabled = false;
                sucamecToolStripMenuItem.Enabled = false;
                administradorToolStripMenuItem.Enabled = false;
            }
            if (nivel == 6)
            {
                recursosHumanosToolStripMenuItem.Enabled = false;
                centroDeControlToolStripMenuItem.Enabled = false;
                operacionesToolStripMenuItem.Enabled = false;
                comercialToolStripMenuItem.Enabled = false;
                // logisticaToolStripMenuItem.Enabled = false;
                planillaToolStripMenuItem.Enabled = false;
                contabilidadToolStripMenuItem.Enabled = false;
                sucamecToolStripMenuItem.Enabled = false;
                administradorToolStripMenuItem.Enabled = false;
            }
            if (nivel == 7)
            {
                recursosHumanosToolStripMenuItem.Enabled = false;
                centroDeControlToolStripMenuItem.Enabled = false;
                operacionesToolStripMenuItem.Enabled = false;
                comercialToolStripMenuItem.Enabled = false;
                logisticaToolStripMenuItem.Enabled = false;
                //planillaToolStripMenuItem.Enabled = false;
                contabilidadToolStripMenuItem.Enabled = false;
                sucamecToolStripMenuItem.Enabled = false;
                administradorToolStripMenuItem.Enabled = false;
            }
            if (nivel == 8)
            {
                recursosHumanosToolStripMenuItem.Enabled = false;
                centroDeControlToolStripMenuItem.Enabled = false;
                operacionesToolStripMenuItem.Enabled = false;
                comercialToolStripMenuItem.Enabled = false;
                logisticaToolStripMenuItem.Enabled = false;
                planillaToolStripMenuItem.Enabled = false;
                //contabilidadToolStripMenuItem.Enabled = false;
                sucamecToolStripMenuItem.Enabled = false;
                administradorToolStripMenuItem.Enabled = false;
            }
            if (nivel == 9)
            {
                recursosHumanosToolStripMenuItem.Enabled = false;
                centroDeControlToolStripMenuItem.Enabled = false;
                operacionesToolStripMenuItem.Enabled = false;
                comercialToolStripMenuItem.Enabled = false;
                logisticaToolStripMenuItem.Enabled = false;
                planillaToolStripMenuItem.Enabled = false;
                contabilidadToolStripMenuItem.Enabled = false;
                //sucamecToolStripMenuItem.Enabled = false;
                administradorToolStripMenuItem.Enabled = false;
            }
        }
        private void frmPrincipalConsorcioTECSEGUR_Load(object sender, EventArgs e)
        {
            lblempresanombre.Text = _nombreempresa;
            lblperfil.Text = _perfil;
            lblusuario.Text = _usuario;
            IsMdiContainer = true;
            perfiles();
        }

    }
}
