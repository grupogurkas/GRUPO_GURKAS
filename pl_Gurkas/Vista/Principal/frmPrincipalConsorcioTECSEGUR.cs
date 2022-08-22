using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
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

        private void conexionAhInternetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Uri Url = new System.Uri("http://www.google.com/");
            System.Net.WebRequest WebRequest;
            WebRequest = System.Net.WebRequest.Create(Url);
            System.Net.WebResponse objResp;
            try
            {
                DateTime fecha = DateTime.Now;
                String anio = Convert.ToString(fecha.Year);
                objResp = WebRequest.GetResponse();
                result = "Su dispositivo está correctamente conectado a internet " + " Copyright © " + anio;
                estado = 1;
                objResp.Close();
                WebRequest = null;
                MessageBox.Show(result, "Conexion Exitosa");
            }
            catch (Exception ex)
            {
                result = "Error al intentar conectarse a internet ";
                estado = 2;
                WebRequest = null;
                MessageBox.Show(result, "Sin Conexion");
            }
        }

        private void conexionAlServidorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ping Pings = new Ping();
            int timeout = 10;

            if (Pings.Send("26.11.117.148", timeout).Status == IPStatus.Success)
            {
                DateTime fecha = DateTime.Now;
                String anio = Convert.ToString(fecha.Year);
                result = "Su dispositivo está correctamente conectado  al servidor " + " Copyright © " + anio;
                estado = 1;
                MessageBox.Show(result, "Conexion Exitosa");
            }
            else
            {
                result = "Error al intentar conectarse al sistema \n Verificar la conexion de la red VPN";
                estado = 2;
                MessageBox.Show(result, "Sin Conexion");
            }
        }

        private void vercionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version" + " " + Application.ProductVersion);
            modulo.auditoria("Archivos", "Comprobar la vercion del sistema  Gurkas", "", "");
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const string titulo = "Cerrar Sesión";
            const string mensaje = "Estas seguro que deseas Cerrar Sesión";
            var resutlado = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resutlado == DialogResult.Yes)
            {
                DateTime fecha = DateTime.Now;
                obtenerip_nombre();

                modulo.auditoria("Archivos", "Cerrar Sesión Sistema", "", "");

                this.Close();
                Vista.frmLogin objLogin = new Vista.frmLogin();
                objLogin.Show();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const string titulo = "Exit";
            const string mensaje = "Estas seguro que deseas Cerrar el Sistema";
            var resutlado = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resutlado == DialogResult.Yes)
            {
                DateTime fecha = DateTime.Now;
                obtenerip_nombre();

                modulo.auditoria("Archivos", "Salir del Sistema por Completo", "", "");

                Application.Exit();
            }
        }

        private void registroDePersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlvistaformulario.ControlVista(this, new Vista.RRHH.frmRegistroDatosPersonal());
            modulo.auditoria("Recursos Humanos", "Personal", "Registro de Datos Personales RRHH", "");
        }

        private void registroDeDatosFamiliaresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlvistaformulario.ControlVista(this, new Vista.RRHH.frmRegistroDatosFamiliarez());
            modulo.auditoria("Recursos Humanos", "Personal", "Registro de Datos Familiares RRHH", "");
        }

        private void registroDeDatosLaboralesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            controlvistaformulario.ControlVista(this, new Vista.RRHH.frmRegistrarDatosLaboralesRRHH());
            modulo.auditoria("Recursos Humanos", "Personal", "Registro de Datos Laborales RRHH", "");
        }

        private void reporteGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlvistaformulario.ControlVista(this, new Vista.RRHH.ReportesRRHH.frmReporteGenrenalPersonal());
            modulo.auditoria("Recursos Humanos", "Modulo de Reporte", "Reporte General", "");
        }

        private void personalPorUnidadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            controlvistaformulario.ControlVista(this, new Vista.RRHH.ReportesRRHH.frmPersonalPorUnidad());
            modulo.auditoria("Recursos Humanos", "Modulo de Reporte", "Reporte de Personal", "Personal Por Unidad");
        }

        private void personalPorSedeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            controlvistaformulario.ControlVista(this, new Vista.RRHH.ReportesRRHH.frmPersonalPorSede());
            modulo.auditoria("Recursos Humanos", "Modulo de Reporte", "Reporte de Personal", "Personal Por Sede");
        }

        private void personalPorEdadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            controlvistaformulario.ControlVista(this, new Vista.RRHH.ReportesRRHH.frmPersonalPorEdad());
            modulo.auditoria("Recursos Humanos", "Modulo de Reporte", "Reporte de Personal", "Personal Por Edad");
        }

        private void personalPorEmpresaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            controlvistaformulario.ControlVista(this, new Vista.RRHH.ReportesRRHH.frmPersonalPorEmpresa());
            modulo.auditoria("Recursos Humanos", "Modulo de Reporte", "Reporte de Personal", " / Personal Por Empresa");
        }

        private void personalPorEstaturaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            controlvistaformulario.ControlVista(this, new Vista.RRHH.ReportesRRHH.frmEstaturaPersonal());
            modulo.auditoria("Recursos Humanos", "Modulo de Reporte", "Reporte de Personal", "Personal Por Estatura");
        }

        private void personalPorTurnoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            controlvistaformulario.ControlVista(this, new Vista.RRHH.ReportesRRHH.frmTurnoEmpleado());
            modulo.auditoria("Recursos Humanos", "Modulo de Reporte", "Reporte de Personal", "Personal Por Turno");
        }

        private void personalPorFechaInicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlvistaformulario.ControlVista(this, new Vista.RRHH.ReportesRRHH.frmPersonalPorFechaIngreso());
            modulo.auditoria("Recursos Humanos", "Modulo de Reporte", "Reporte de Personal", "Personal Por Fecha Ingreso");
        }

        private void personalPorDNIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlvistaformulario.ControlVista(this, new Vista.RRHH.ReportesRRHH.frmPersonalPorDni());
            modulo.auditoria("Recursos Humanos", "Modulo de Reporte", "Reporte de Personal", "Personal Por DNI");
        }

        private void asistenciaDePersonalToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            controlvistaformulario.ControlVista(this, new Vista.RRHH.ReportesRRHH.frmAsistenciaPersonaIndividual());
            modulo.auditoria("Recursos Humanos", "Modulo de Reporte", "Reporte de Asistencia de Personal", "Asistencia de Personal");
        }

        private void asistenciaGeneralDePersoanalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlvistaformulario.ControlVista(this, new Vista.RRHH.ReportesRRHH.frmAsistenciaGneralPersonal());
            modulo.auditoria("Recursos Humanos", "Modulo de Reporte", "Reporte de Asistencia de Personal", "Asistencia de General de Personal");
        }

        private void asistenciaPorUnidadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            controlvistaformulario.ControlVista(this, new Vista.RRHH.ReportesRRHH.frmAsistenciaPersonalPorUnidad());
            modulo.auditoria("Recursos Humanos", "Modulo de Reporte", "Reporte de Asistencia de Personal", "Asistencia de Personal");
        }

        private void asistenciaPorSedeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            controlvistaformulario.ControlVista(this, new Vista.RRHH.ReportesRRHH.frmAsistenciaGeneralPersonalPorSede());
            modulo.auditoria("Recursos Humanos", "Modulo de Reporte", "Reporte de Asistencia de Personal", "Asistencia por Sede");
        }

        private void bajaDePersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlvistaformulario.ControlVista(this, new Vista.RRHH.ReportesRRHH.frmBajaPersonal());
            modulo.auditoria("Recursos Humanos", "Modulo de Reporte", "Reporte de Baja de Personal", "");
        }

        private void moverPersonalEntreEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlvistaformulario.ControlVista(this, new Vista.RRHH.frmMoverEmpresa());
            modulo.auditoria("Recursos Humanos", "Mover Personal Entre Empresa", "", "");
        }

        private void estadoDelPersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlvistaformulario.ControlVista(this, new RRHH.frmActualizarEstadoPersonal());
            modulo.auditoria("Recursos Humanos", "Modulo de Estado de Personal", "", "");
        }

        private void cargaMasivaDeDatosLaboralesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlvistaformulario.ControlVista(this, new Vista.RRHH.CargaDatos.frmCargaDatosIngresantesPlanillas());
            modulo.auditoria("Recursos Humanos", "Carga Masiva de los Datos Laborales", "", "");
        }

        private void postulanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlvistaformulario.ControlVista(this, new Vista.RRHH.Postulante.frmPostulante());
            modulo.auditoria("RRHH", "Modulo de postulante", "", "");
        }

        private void registroPersonalC4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlvistaformulario.ControlVista(this, new Vista.RRHH.RRHHC4.frmRegistroC4());
            modulo.auditoria("Recursos Humanos", "Registro Personal C4", "", "");
        }

        private void personalActivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlvistaformulario.ControlVista(this, new Vista.RRHH.frmReporteRRHHPersonalActivo());
            modulo.auditoria("Recursos Humanos", "Personal Activo RRHH", "", "");
        }

        private void asistenciaDePersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlvistaformulario.ControlVista(this, new Vista.CentroControl.frmAsistenciaPersonal());
            modulo.auditoria("Modulo de Centro de Control", "Tareaje de Personal", "", "");
        }

        private void cantidadDeAsistencaiDeCadaSedeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlvistaformulario.ControlVista(this, new Vista.CentroControl.ReporteCentroControl.frmConsultaDeCantidadDeAsistenciaDeCadaSede());
            modulo.auditoria("Centro de Control", "Reportes - C. CONTROL", "Cantidad de Asistencia de Cada Sede", "");
        }

        private void marcacionPorFechaYTurnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlvistaformulario.ControlVista(this, new Vista.CentroControl.ReporteCentroControl.frmReportedeMarcacionpoFecahYturno());
            modulo.auditoria("Centro de Control", "Reportes - C. CONTROL", "Marcacion por Fecha y Turno", "");
        }

        private void consultaDeAsistenciaPorPersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlvistaformulario.ControlVista(this, new Vista.CentroControl.ReporteCentroControl.fmrConsultaDeAsistenciaPorPersonal());
            modulo.auditoria("Centro de Control", "Reportes - C. CONTROL", "Consulta de Asistencia por personal", "");
        }

        private void asistenciaGeneralDelPersonalDetalladoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlvistaformulario.ControlVista(this, new Vista.CentroControl.ReporteCentroControl.frmAsistenciaDetalladoPorEmpleado());
            modulo.auditoria("Centro de Control", "Reportes - C. CONTROL", "Asistencia General del Personal Detallado", "");
        }

        private void asistenciaDePersonalPorDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlvistaformulario.ControlVista(this, new Vista.CentroControl.ReporteAsistencia.frmPersonalsistenciaporDia());
            modulo.auditoria("Centro de Control", "Reporte Asistencia", "Asistencia de Personal por Dia", "");
        }

        private void personalSinMarcacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlvistaformulario.ControlVista(this, new Vista.CentroControl.ReporteAsistencia.frmPersonalSinMarcacion());
            modulo.auditoria("Centro de Control", "Reporte Asistencia", "Personal sin Marcacion", "");
        }

        private void asistenciaDePersonalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            controlvistaformulario.ControlVista(this, new Vista.CentroControl.ReporteAsistencia.frmAsistenciadePersonal());
            modulo.auditoria("Centro de Control", "Reporte Asistencia", "Asistencia de Personal", "");
        }

        private void asistenciaDePersonalDetalladoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlvistaformulario.ControlVista(this, new Vista.CentroControl.ReporteAsistencia.frmAsistenciaDePersonalDetallado());
            modulo.auditoria("Centro de Control", "Reporte Asistencia", "Asistencia de Personal Detallado", "");
        }

        private void asistenciaGeneralDePersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlvistaformulario.ControlVista(this, new Vista.Operaciones.ReporteOperaciones.frmReportePersonalGeneral());
            modulo.auditoria("Centro Control", "Reporte", "Modulo de asistencia personal completo", "");
        }

        private void reporteDeBloqueosDePersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlvistaformulario.ControlVista(this, new Vista.CentroControl.ReporteCentroControl.frmBloqueosPersonal());
            modulo.auditoria("Centro de Control", "Bloqueos de Personal", "Reporte de Bloqueos de Personal", "");
        }

        private void bloqueosDePersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlvistaformulario.ControlVista(this, new Vista.CentroControl.CargaDeDatos.frmBloqueosPersonal());
            modulo.auditoria("Centro de Control", "Bloqueos de Personal", "Carga de Bloqueos de Personal", "");
        }

        private void migrarAsistenciaAAndroidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlvistaformulario.ControlVista(this, new Vista.CentroControl.Android.frmMigrarAndroidAsistencia());
            modulo.auditoria("Modulo de Centro de Control", "Migracion de asistencia a android", "", "");
        }

        private void activarUnidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlvistaformulario.ControlVista(this, new Vista.Operaciones.Unidad.frmActivarUnidad());
            modulo.auditoria("Operaciones", "Unidad", "Activar Unidad", "");
        }

        private void activarSedeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlvistaformulario.ControlVista(this, new Vista.Operaciones.Sede.frmSede());
            modulo.auditoria("Operaciones", "Sede", "Activar Sede", "");
        }

        private void consultaDeAsistenciaPorPersonalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            controlvistaformulario.ControlVista(this, new Vista.Operaciones.ReporteOperaciones.frmConsultadeAsistenciaPersonal());
            modulo.auditoria("Operaciones", "Reporte", "Consulta de Asistencia por Personal", "");
        }

        private void personalSinMarcacionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            controlvistaformulario.ControlVista(this, new Vista.CentroControl.ReporteAsistencia.frmPersonalSinMarcacion());
            modulo.auditoria("Operaciones", "Reporte", "Personal sin Marcacion", "");
        }

        private void estadoDePersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlvistaformulario.ControlVista(this, new Vista.Operaciones.ReporteOperaciones.frmEstadoPersonal());
            modulo.auditoria("Operaciones", "Reporte", "Estado de Personal", "");
        }

        private void constultaDeAsistenciaPersonalCompletoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlvistaformulario.ControlVista(this, new Vista.Operaciones.ReporteOperaciones.frmReportePersonalGeneral());
            modulo.auditoria("Operaciones", "Reporte", "Modulo de asistencia personal completo", "");
        }

        private void reclamoAgenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlvistaformulario.ControlVista(this, new Vista.Reclamo.frmReclamoEmpleado());
            modulo.auditoria("Operaciones", "Reclamo Agente", "", "");
        }
    }
}
