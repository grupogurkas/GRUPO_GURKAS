using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace pl_Gurkas.Vista.Logistica.Proveedores
{
    public partial class frmRegistrarProveedor : Form
    {
        Datos.Conexiondbo conexion = new Datos.Conexiondbo();
        Datos.LimpiarDatos LimpiarDatos = new Datos.LimpiarDatos();
        Datos.llenadoDatosLogistica Llenadocbo = new Datos.llenadoDatosLogistica();
        Datos.registrar registrar = new Datos.registrar();
        Datos.Actualizar actualizar = new Datos.Actualizar();

        public frmRegistrarProveedor()
        {
            InitializeComponent();
        }
        private void showDialogs(String message, Color bdColor)
        {
            Vista.MensajeEmergente.DialogForm dialog = new Vista.MensajeEmergente.DialogForm(message, bdColor);
            dialog.Show();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void GenerarCodigo()
        {
            string resultado = "";
            SqlCommand comando = new SqlCommand("select count(cod_proveedor) as 't' from t_proveedor ", conexion.conexionBD());

            SqlDataReader recorre = comando.ExecuteReader();
            while (recorre.Read())
            {
                resultado = recorre["t"].ToString();
            }
            int numero = Convert.ToInt32(resultado);
            if (numero< 10 )
            {
                txtcodproveedor.Text = "PROV000" + (numero + 1);
            }
            if (numero >9 && numero <100)
            {
                txtcodproveedor.Text = "PROV00" + (numero + 1);
            }
            if (numero>99 && numero <1000)
            {
                txtcodproveedor.Text = "PROV0" + (numero + 1);
            }
        }

        private void ValidarCamposVacios()
        {
          
            if (cboDepartamento.SelectedIndex == 0)
            {
                MessageBox.Show("Debe Seleccionar un Departamento", "Advertencia");
            }
            if (cboProvincia.SelectedIndex == 0)
            {
                MessageBox.Show("Debe Seleccionar una Provincia", "Advertencia");
            }
            if (cboDis.SelectedIndex == 0)
            {
                MessageBox.Show("Debe Seleccionar un Distrito", "Advertencia");
            }
            if (txtcodproveedor.Text.Length == 0)
            {
                MessageBox.Show("Debe Ingresar un Codigo", "Advertencia");
            }
            if (txtProveedor.Text.Length == 0)
            {
                MessageBox.Show("Debe Ingresar un Nombre", "Advertencia");
            }
            if (txtruc.Text.Length == 0)
            {
                MessageBox.Show("Debe Ingresar un RUC", "Advertencia");
            }
            if (txtObservacion.Text.Length == 0)
            {
                MessageBox.Show("Debe Ingresar una observacion", "Advertencia");
            }
            if (txtDireccion.Text.Length == 0)
            {
                MessageBox.Show("Debe Ingresar una Direccion", "Advertencia");
            }
            if (txtCelular.Text.Length == 0)
            {
                MessageBox.Show("Debe Ingresar un Numero de Celular", "Advertencia");
            }
            if (txtTelefono.Text.Length == 0)
            {
                MessageBox.Show("Debe Ingresar un Numero Telefonico", "Advertencia");
            }
            if (txtCorreo.Text.Length == 0)
            {
                MessageBox.Show("Debe Ingresar un Correo", "Advertencia");
            }
            if (txtCorreo2.Text.Length == 0)
            {
                MessageBox.Show("Debe Ingresar un comentario", "Advertencia");
            }
            if (txtpaginaweb.Text.Length == 0)
            {
                MessageBox.Show("Debe Ingresar una pagina web", "Advertencia");
            }
            if (txtRubro.Text.Length == 0)
            {
                MessageBox.Show("Debe Ingresar un Rubro", "Advertencia");
            }
            if (txtpaginaweb.Text.Length == 0)
            {
                MessageBox.Show("Debe Ingresar un nombre de contacto", "Advertencia");
            }
            if (txtObservacion.Text.Length == 0)
            {
                MessageBox.Show("Debe Ingresar un telefono 1", "Advertencia");
            }
            if (txtTelefono.Text.Length == 0)
            {
                MessageBox.Show("Debe Ingresar un telefono 2", "Advertencia");
            }
        }
        private void ActualizarPersonal()
        {
            try
            {
                string cod_proveedor_cbo = cboProveedor.SelectedValue.ToString();
                string Nombre = txtProveedor.Text;
                string ruc = txtruc.Text;
                string rubro = txtRubro.Text;
                string NombreContacto = txtNombreProveedor.Text;
                string Telefono = txtTelefono.Text;
                string Celular = txtCelular.Text;
                string Correo = txtCorreo.Text;
                string Correo2 = txtCorreo2.Text;
                string direccion = txtDireccion.Text;
                string Departamento = cboDepartamento.SelectedValue.ToString();
                int codDep = (int)Convert.ToInt64(Departamento);
                string Provincia = cboProvincia.SelectedValue.ToString();
                int codPro = (int)Convert.ToInt64(Provincia);
                string Distrito = cboDis.SelectedValue.ToString();
                int codDist = (int)Convert.ToInt64(Distrito);
                string paginaweb = txtpaginaweb.Text;
                int Tipoproveedor = cboTipoProveedor.SelectedIndex;
                //string TipoProveedor = cboTipoProveedor.SelectedValue.ToString();
                //int codTipoProveedor = (int)Convert.ToInt64(TipoProveedor);
                DateTime fregistro = dtpFechaRegistro.Value;
                string observacion = txtObservacion.Text;
                //Modulo Representante

                string Representante = txtRepresentante.Text;
                int tipoDoc = cboTipoDocIdentEmp.SelectedIndex;
                string numDoc = txtNumDocIdentEmpl.Text;
                string cargo = txtCargo.Text;
                string empresa = txtEmpresa.Text;
                int tipoEmpresa = cboTipoEmpresa.SelectedIndex;
                int Estado = cboEstadoProveedor.SelectedIndex;
                //Modulo Datos Certificacion

                int basc = cboCertificadoBasc.SelectedIndex;
                int no_basc = cboOtroCertificado.SelectedIndex;
                string autenticidad = txtAutenticidad.Text;
                string numero_certificado = txtNumCertificacion.Text;
                DateTime fechaOtorgamiento = dtpFechaInicio.Value;
                DateTime fechaCaducidad = dtpFechaCaducidad.Value;

                string pdfFilePath = lblRutaBasc.Text;
                byte[] pdfBasc = System.IO.File.ReadAllBytes(pdfFilePath);

                actualizar.actualizarProveedor(cod_proveedor_cbo, Nombre, ruc, observacion, codDep, codPro,
                                         codDist, direccion, Telefono, Celular, Correo, Correo2, fregistro,
                                         paginaweb, rubro, NombreContacto, Tipoproveedor, Representante, tipoDoc,
                                         numDoc, cargo, empresa, tipoEmpresa, Estado, basc, no_basc, autenticidad,
                                         numero_certificado, fechaOtorgamiento, fechaCaducidad);
                MessageBox.Show("Datos actualizado correptamente", "Correpto");

                LimpiarDatos.LimpiarGroupBox(groupBox1);
                LimpiarDatos.LimpiarGroupBox(groupBox3);
                LimpiarDatos.LimpiarGroupBox(groupBox2);
                // LimpiarDatos.LimpiarCampo(this);

                showDialogs("Datos Actualizados", Color.FromArgb(0, 200, 81));
                GenerarCodigo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede Actualizar los datos \n"+ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                showDialogs("Advertencia", Color.FromArgb(255, 187, 51));
            }
        }
        private void RegistrarProveedor()
        {
            try
            {
                string codProveedor = txtcodproveedor.Text;
                string Nombre = txtProveedor.Text;
                string ruc = txtruc.Text;
                string rubro = txtRubro.Text;
                string NombreContacto = txtNombreProveedor.Text;
                string Telefono = txtTelefono.Text;
                string Celular = txtCelular.Text;
                string Correo = txtCorreo.Text;
                string Correo2 = txtCorreo2.Text;
                string direccion = txtDireccion.Text;
                string Departamento = cboDepartamento.SelectedValue.ToString();
                int codDep = (int)Convert.ToInt64(Departamento);
                string Provincia = cboProvincia.SelectedValue.ToString();
                int codPro = (int)Convert.ToInt64(Provincia);
                string Distrito = cboDis.SelectedValue.ToString();
                int codDist = (int)Convert.ToInt64(Distrito);
                string paginaweb = txtpaginaweb.Text;

                int Tipoproveedor = cboTipoProveedor.SelectedIndex;
                DateTime fregistro = dtpFechaRegistro.Value;
                string observacion = txtObservacion.Text;
                //Modulo Representante

                string Representante = txtRepresentante.Text;
                int tipoDoc = cboTipoDocIdentEmp.SelectedIndex;
                string numDoc = txtNumDocIdentEmpl.Text;
                string cargo = txtCargo.Text;
                string empresa = txtEmpresa.Text;
                int tipoEmpresa = cboTipoEmpresa.SelectedIndex;
                int Estado = cboEstadoProveedor.SelectedIndex;
                //Modulo Datos Certificacion

                int basc = cboCertificadoBasc.SelectedIndex;
                int no_basc = cboOtroCertificado.SelectedIndex;
                string autenticidad = txtAutenticidad.Text;
                string numero_certificado = txtNumCertificacion.Text;
                DateTime fechaOtorgamiento = dtpFechaInicio.Value;
                DateTime fechaCaducidad = dtpFechaCaducidad.Value;

             

                registrar.registrarProveedor(codProveedor,  Nombre,  ruc,  observacion,  codDep,  codPro,
                                         codDist,  direccion,  Telefono,  Celular,  Correo,  Correo2,  fregistro,
                                         paginaweb,  rubro,  NombreContacto,  Tipoproveedor,  Representante,  tipoDoc,
                                         numDoc,  cargo,  empresa,  tipoEmpresa,  Estado,  basc,  no_basc,  autenticidad,
                                         numero_certificado,  fechaOtorgamiento,  fechaCaducidad);
                MessageBox.Show("Datos registrado correctamente", "Correcto");

                LimpiarDatos.LimpiarGroupBox(groupBox1);
                LimpiarDatos.LimpiarGroupBox(groupBox3);
                LimpiarDatos.LimpiarGroupBox(groupBox2);
                // LimpiarDatos.LimpiarCampo(this);

                showDialogs("Datos Registrados", Color.FromArgb(0, 200, 81));
                GenerarCodigo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                showDialogs("Advertencia", Color.FromArgb(255, 187, 51));
            }
        }
        private void frmRegistrarProveedor_Load(object sender, EventArgs e)
        {
            Llenadocbo.ObtenerDepartamentoLogistica(cboDepartamento);
            Llenadocbo.ObtenerProveedoresLogistico(cboProveedor);
            Llenadocbo.ObtenerTipoProveedor(cboTipoProveedor);
            Llenadocbo.ObtenerTipoDocumentologistica(cboTipoDocIdentEmp);
            Llenadocbo.ObtenerTipoEmpresalogistica(cboTipoEmpresa);
            Llenadocbo.ObtenerEstadoProveedorlogistica(cboEstadoProveedor);
            Llenadocbo.ObtenerEstadoCertifivadologistica(cboCertificadoBasc);
            Llenadocbo.ObtenerEstadoCertifivadologistica(cboOtroCertificado);
            txtcodproveedor.Enabled = false;
            GenerarCodigo();
        }

        private void cboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartamento.SelectedValue.ToString() != null)
            {
                string Cod_Departamento = cboDepartamento.SelectedValue.ToString();
                Llenadocbo.ObtenerProvinciaLogistica(cboProvincia, Cod_Departamento);
            }
        }

        private void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProvincia.SelectedValue.ToString() != null)
            {
                string Cod_Provincia = cboProvincia.SelectedValue.ToString();
                Llenadocbo.ObtenerDistritosLogistica(cboDis, Cod_Provincia);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ValidarCamposVacios();
            RegistrarProveedor();


        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarDatos.LimpiarGroupBox(groupBox1);
            LimpiarDatos.LimpiarGroupBox(groupBox3);
            //LimpiarDatos.LimpiarCampo(this);
            txtProveedor.Focus();
            GenerarCodigo();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ValidarCamposVacios();
            ActualizarPersonal();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string cod_provedor = cboProveedor.SelectedValue.ToString();

                SqlCommand comando = new SqlCommand("select *from t_proveedor where cod_proveedor = '" + cod_provedor + "'", conexion.conexionBD());

                SqlDataReader recorre = comando.ExecuteReader();
                while (recorre.Read())
                {
                    txtcodproveedor.Text = recorre["cod_proveedor"].ToString();
                    txtProveedor.Text = recorre["nomb_proveedor"].ToString();
                    txtruc.Text = recorre["ruc"].ToString();
                    txtRubro.Text = recorre["rubro"].ToString();
                    txtNombreProveedor.Text = recorre["nomb_contacto"].ToString();
                    txtTelefono.Text = recorre["telefono"].ToString();
                    txtCelular.Text = recorre["celular"].ToString();
                    txtCorreo.Text = recorre["correo"].ToString();
                    txtCorreo2.Text = recorre["correo2"].ToString();
                    txtDireccion.Text = recorre["direccion"].ToString();
                    cboDepartamento.SelectedValue = recorre["departamento"].ToString();
                    cboProvincia.SelectedValue = recorre["provincia"].ToString();
                    cboDis.SelectedValue = recorre["distrito"].ToString();
                    txtpaginaweb.Text = recorre["pagina_web"].ToString();
                    cboTipoProveedor.SelectedIndex = Convert.ToInt32(recorre["tipo_proveedor"].ToString());
                    dtpFechaRegistro.Text = (recorre["fecha_registro"].ToString());
                    txtObservacion.Text = recorre["observacion"].ToString();
                    //Representante 
                    txtRepresentante.Text = recorre["representante"].ToString();
                    cboTipoDocIdentEmp.SelectedIndex = Convert.ToInt32(recorre["tipo_documento"].ToString());
                    txtNumDocIdentEmpl.Text = recorre["numb_documento"].ToString();
                    txtCargo.Text = recorre["cargo"].ToString();
                    txtEmpresa.Text = recorre["empresa"].ToString();
                    cboTipoEmpresa.SelectedIndex = Convert.ToInt32(recorre["tipo_empresa"].ToString());
                    cboEstadoProveedor.SelectedIndex = Convert.ToInt32(recorre["estado_proveedor"].ToString());
                    //Modulo Datos Certificacion

                    cboCertificadoBasc.SelectedIndex = Convert.ToInt32(recorre["basc"].ToString());
                    cboOtroCertificado.SelectedIndex = Convert.ToInt32(recorre["no_basc"].ToString());
                    //aqui
                    txtAutenticidad.Text = recorre["autenticidad"].ToString();
                    txtNumCertificacion.Text = recorre["numero_certificado"].ToString();
                    dtpFechaInicio.Text = (recorre["fecha_otorgamiento"].ToString());
                    dtpFechaCaducidad.Text = (recorre["fecha_caducidad"].ToString());
                }

            }
            catch (Exception err)
            {
                MessageBox.Show("No se encontro ningun registro \n\n" + err, "ERROR");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            const string titulo = "Cerrar Registro de Personal";
            const string mensaje = "Estas seguro que deseas cerra el Registro de Proveedor";
            var resutlado = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resutlado == DialogResult.Yes)
            {
                //  DateTime fecha = DateTime.Now;
                //  obtenerip_nombre();
                // string username = Code.nivelUser._nombre;
                // string detalle = "Cerrar Registro de Personal";
                // string cod_buscado = "Cerro el registro de Personal";
                // registrar.RegistrarRRHH(fecha, nombrepc, username, ipuser, cod_buscado, detalle);
                this.Close();
            };
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {


            OpenFileDialog open = new OpenFileDialog();

            if (open.ShowDialog() == DialogResult.OK)
            {
                axAcroPDF1.src = open.FileName;
                string direccion = open.FileName;
                lblRutaBasc.Text = direccion;
            }
            else
            {
                MessageBox.Show("Seleccionar File");
            }

            /*OpenFileDialog abrir = new OpenFileDialog();
            if(abrir.ShowDialog() == DialogResult.OK)
            {
                //string direccion = abrir.FileName;
                //Process proceso = new Process();
                //proceso.StartInfo.FileName = direccion;
                //proceso.Start();xd

            }*/


        }
      

        /* private void cboTipoProveedor_SelectedIndexChanged(object sender, EventArgs e)
         {
             if (cboTipoProveedor.SelectedValue.ToString() != null)
             {
                 string idTipoProveedor = cboTipoProveedor.SelectedValue.ToString();
                 Llenadocbo.ObtenerTipoProveedorLogistica(cboTipoProveedor, idTipoProveedor);


             }
         }*/
    }
}
