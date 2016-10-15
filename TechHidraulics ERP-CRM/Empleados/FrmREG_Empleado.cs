using System;
using System.IO;
using DevExpress.XtraEditors;
using Entidades;
using System.Windows.Forms;
using Negocio;
using Negocio.Entidades;

namespace TechHidraulics_ERP_CRM.Empleados
{
    public partial class FrmRegEmpleado : XtraForm
    {
        readonly int _idEmpleado;
        EEmpleado _empleado = new EEmpleado();

        public FrmRegEmpleado()
        {
            InitializeComponent();
            Inicializar();
        }
        public FrmRegEmpleado(int idEmpleado)
        {
            InitializeComponent();
            _idEmpleado = idEmpleado;
            Inicializar();
            CargarEmpleado();
        }

        private void Inicializar()
        {
            ComboBox.LlenarCombo(cbxPuesto, ComboBox.Catalogos.Puestos);
            ComboBox.LlenarCombo(cbxDepartamento, ComboBox.Catalogos.Departamentos);
            cbxDepartamento.SelectedIndex = 0;
            cbxPuesto.SelectedIndex = 0;

        }


        private void CargarEmpleado()
        {
            NegEmpleado empleadoLogico = new NegEmpleado();
            _empleado = empleadoLogico.TraerPorId(_idEmpleado);
            if (_empleado == null) return;

            txtNombre.Text = _empleado.Nombre;
            txtApellidos.Text = _empleado.Apellido;
            txtCiudad.Text = _empleado.Telefono;
            txtCalle.Text = _empleado.Direccion;
            cbxPuesto.Text = _empleado.Puesto;
            ComboBox.SelectById(cbxDepartamento, _empleado.Departamento);
            txtUsuario.Text = _empleado.NombreUsuario;
            txtContrasena.Text = _empleado.Contrasena;
            txtFicha.Text = _empleado.NumeroEmpleado;
            txtRFC.Text = _empleado.Rfc;
            txtEstatura.Text = _empleado.Estatura;
            txtPeso.EditValue = _empleado.Peso;
            txtReferencia.Text = _empleado.ContactoPersonal;
            txtTipoSangre.Text = _empleado.TipoSangre;
            dateContratacion.DateTime = _empleado.FechaContratacion;
            dateTerminacion.DateTime = _empleado.FechaTerminacion;
            dateNacimiento.DateTime = _empleado.FechaNacimiento;
            txtReferencia.Text = _empleado.Referencia;
            chkM.Checked = _empleado.Genero == 'M';
            chkAdministrador.Checked = _empleado.Administrador==1;
            txtCalle.Text = _empleado.Calle;
            txtColonia.Text = _empleado.Colonia;
            txtCiudad.Text = _empleado.Ciudad;
            txtCP.EditValue = _empleado.CodigoPostal;
            txtCurp.Text = _empleado.Curp;
            txtImss.Text = _empleado.NumeroAfiliacion;
            txtInfonavit.Text = _empleado.CreditoInfonavit;

            picPhoto.Image = Imagenes.ObtenerImagen(Imagenes.Categoria.Empleados, _empleado.Id);
        }
        


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Registrar();
        }

        void Registrar()
        {
            
            var empleadoLogico = new Negocio.Entidades.NegEmpleado();
            _empleado.Id = _idEmpleado;
            _empleado.Nombre = txtNombre.Text;
            _empleado.Apellido = txtApellidos.Text;
            _empleado.Telefono = txtTelefono.Text;
            _empleado.Direccion=txtCalle.Text;
            _empleado.Puesto = cbxPuesto.Text;
            _empleado.Departamento =Convert.ToInt32(((ComboBox.ComboBoxItem)cbxDepartamento.SelectedItem).Value);
            _empleado.NombreUsuario = txtUsuario.Text;
            _empleado.Contrasena=txtContrasena.Text;
            _empleado.NumeroEmpleado=txtFicha.Text;
            _empleado.Rfc= txtRFC.Text;
            _empleado.Estatura=txtEstatura.Text;
            _empleado.Peso=Convert.ToDouble(txtPeso.EditValue);
            _empleado.ContactoPersonal=txtReferencia.Text;
            _empleado.TipoSangre=txtTipoSangre.Text;
            _empleado.FechaContratacion = dateContratacion.DateTime;
            _empleado.FechaTerminacion = dateTerminacion.DateTime;
            _empleado.FechaNacimiento = dateNacimiento.DateTime;
            _empleado.Referencia = txtReferencia.Text;
            _empleado.Genero = chkM.Checked ? 'M' : 'F';
            if (chkAdministrador.Checked)
            _empleado.Administrador = 1;

            _empleado.Calle = txtCalle.Text;
            _empleado.Colonia = txtColonia.Text;
            _empleado.Ciudad = txtCiudad.Text;
            _empleado.CodigoPostal = Convert.ToInt32(txtCP.EditValue);
            _empleado.Curp = txtCurp.Text;
            _empleado.NumeroAfiliacion = txtImss.Text;
            _empleado.CreditoInfonavit = txtInfonavit.Text;

            empleadoLogico.Registrar(_empleado);
            if (empleadoLogico.StringBuilder.Length > 0)
                XtraMessageBox.Show(empleadoLogico.StringBuilder.ToString());
            else
            {
                GuardarFoto();
                DialogResult = DialogResult.OK;
            }

        }
        private void GuardarFoto()
        {
            if (picPhoto.Image == null) return;
            if (_idEmpleado <= 0)
            {
                var maxId = Conexion.ExQy_One_Data("select max(id_empleado) from empleado");
                picPhoto.Image.Save(AccesoCarpetas.ObtenerDireccionCarpeta(Carpetas.Empleados) + maxId + ".jpg");
            }
            else
            {
                string path = AccesoCarpetas.ObtenerDireccionCarpeta(Carpetas.Empleados) + _idEmpleado + ".jpg";
                var fi = new FileInfo(path);
                if (fi.Exists)
                    fi.Delete();
                picPhoto.Image.Save(path);
            }
        }

        private void FrmREG_Empleado_Load(object sender, EventArgs e)
        {

        }

        private void btnCargarFoto_Click(object sender, EventArgs e)
        {
            picPhoto.LoadImage();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Borrar imagen
        }
    }
}