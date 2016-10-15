using System;
using System.Collections;
using System.Globalization;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Entidades;
using Negocio.Entidades;

namespace TechHidraulics_ERP_CRM.Clientes
{
    public partial class FrmRegCliente : XtraForm
    {
        public int IdCliente;
        public NegCliente ClienteLogico = new NegCliente();

        public FrmRegCliente()
        {
            InitializeComponent();
        }

        public FrmRegCliente(int id)
        {
            InitializeComponent();
            IdCliente = id;
            Inicializar();
            CargarCliente();
        }

        private void Inicializar()
        {
            ComboBox.LlenarCombo(cbxSector, ComboBox.Catalogos.Sector);
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {

        }

        private void CargarCliente()
        {
            ECliente cliente = ClienteLogico.TraerPorId(IdCliente);
            txtNombre.Text = cliente.Nombre;
            txtCalle.Text = cliente.Calle;
            txtCiudad.Text = cliente.Ciudad;
            txtCodigo.Text = cliente.Codigo;
            txtCP.EditValue = cliente.CodigoPostal;
            txtColonia.Text = cliente.Colonia;
            txtContacto_Mail.Text = cliente.ContactoEmail;
            txtMovil_Contacto.Text = cliente.ContactoMovil;
            txtNombre_Contacto.Text = cliente.ContactoNombre;
            txtTelefono_Contacto.Text = cliente.ContactoTelefono;
            txtCorreo.Text = cliente.Correo;
            txtDescripcion.Text = cliente.Descripcion;
            txtDescuento.Text = cliente.Descuento.ToString(CultureInfo.InvariantCulture);
            txtCredito.Text = cliente.DiasCredito.ToString();
            txtPagina.Text = cliente.PaginaWeb;
            chkEstatus.Checked = Convert.ToBoolean(cliente.Estatus) ;
            txtRazonSocial.Text = cliente.RazonSocial;
            cbxSector.Text = cliente.Sector;
            txtTelefono.EditValue = cliente.Telefono;

            ArrayList array = ClienteLogico.TraerEmpresas(cliente.Id);

            foreach (int index in array)
            {
                switch (index)
                {
                    case 1:
                        chkSsyasa.Checked = true;
                        break;
                    case 2:
                        chkLubano.Checked = true;
                        break;
                    case 3:
                        chkDiego.Checked = true;
                        break;
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Registrar();
        }


        private void Registrar()
        {
            if (!chkSsyasa.Checked && !chkDiego.Checked && !chkLubano.Checked)
            {
                XtraMessageBox.Show("Seleccione por lo menos una empresa");
                return;
            }

            var cliente = new ECliente();
            cliente.Id = IdCliente;
            cliente.Nombre = txtNombre.Text;
            cliente.Calle = txtCalle.Text;
            cliente.Ciudad = txtCiudad.Text;
            cliente.Codigo = txtCodigo.Text;
            cliente.CodigoPostal = Convert.ToInt32(txtCP.EditValue);
            cliente.Colonia = txtColonia.Text;
            cliente.ContactoEmail = txtContacto_Mail.Text;
            cliente.ContactoMovil = txtMovil_Contacto.Text;
            cliente.ContactoNombre = txtNombre_Contacto.Text;
            cliente.ContactoTelefono = txtTelefono_Contacto.Text;
            cliente.Correo = txtCorreo.Text;
            cliente.Descripcion = txtDescripcion.Text;
            cliente.Descuento = Convert.ToInt32(txtDescuento.Text);
            cliente.DiasCredito = Convert.ToInt32(txtCredito.Text);
            cliente.Direccion = "";
            cliente.PaginaWeb = txtPagina.Text;
            cliente.Estatus = chkEstatus.Checked ? 1 : 0;
            cliente.RazonSocial = txtRazonSocial.Text;
            cliente.Sector = cbxSector.Text;
            cliente.Telefono = txtTelefono.EditValue.ToString();

            ArrayList idsEmpresa = new ArrayList();
            if (chkSsyasa.Checked) idsEmpresa.Add(1);
            if (chkLubano.Checked) idsEmpresa.Add(2);
            if (chkDiego.Checked) idsEmpresa.Add(3);

            ClienteLogico.Registrar(cliente, idsEmpresa);

            if (ClienteLogico.StringBuilder.Length > 0)
            {
                XtraMessageBox.Show(ClienteLogico.StringBuilder.ToString());
                return;
            }
            DialogResult = DialogResult.OK;
        }
    }
}