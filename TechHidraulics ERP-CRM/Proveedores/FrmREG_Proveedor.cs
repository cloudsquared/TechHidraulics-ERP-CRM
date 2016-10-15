using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Converter;
using Entidades;
using Negocio.Entidades;

namespace TechHidraulics_ERP_CRM.Proveedores
{
    public partial class FrmRegProveedor : XtraForm
    {
        public int IdProveedor;
        public NegProveedor ProveedorLogico = new NegProveedor();


        public FrmRegProveedor()
        {
            InitializeComponent();
        }

        public FrmRegProveedor(int id)
        {
            InitializeComponent();

            IdProveedor = id;
            Inicializar();
            CargarProveedor();
        }
        private void CargarProveedor()
        {
            EProveedor proveedor = ProveedorLogico.TraerPorId(IdProveedor);
            txtNombre.Text = proveedor.Nombre;
            txtCalle.Text = proveedor.Calle;
            txtCiudad.Text = proveedor.Ciudad;
            txtCodigo.Text = proveedor.CodigoProveedor;
            txtCP.EditValue = proveedor.CodigoPostal;
            txtColonia.Text = proveedor.Colonia;
            txtCorreo.Text = proveedor.CorreoElectronico;
            txtDescripcion.Text = proveedor.Observaciones;
            txtPagina.Text = proveedor.PaginaWeb;
            cbxSector.Text = proveedor.Sector;
            txtTelefono.EditValue = proveedor.Telefono;

            txtContactoMail.Text = proveedor.ContactoEmail; 
            txtTelefono_Contacto.Text = proveedor.ContactoTelefono;
            txtNombre_Contacto.Text = proveedor.ContactoNombre;
            txtDireccion_Contacto.Text = proveedor.ContactoDireccion;

            txtTelefono_Contacto2.Text = proveedor.ContactoTelefono2;
            txtDireccion_Contacto2.Text = proveedor.ContactoDireccion2;
            txtContactoMail2.Text = proveedor.ContactoEmail2;
            txtNombre_Contacto2.Text = proveedor.ContactoNombre2;

        }

        private void Registrar()
        {
            EProveedor proveedor = new EProveedor();
            proveedor.Nombre = txtNombre.Text;
            proveedor.Calle = txtCalle.Text; 
            proveedor.Ciudad = txtCiudad.Text;
            proveedor.CodigoProveedor = txtCodigo.Text;
            proveedor.CodigoPostal = Convert.ToInt32(txtCP.EditValue);
            proveedor.Colonia = txtColonia.Text;
            proveedor.CorreoElectronico = txtCorreo.Text;
            proveedor.Observaciones = txtDescripcion.Text;
            proveedor.PaginaWeb = txtPagina.Text;
            proveedor.Sector = cbxSector.Text;
            proveedor.Telefono= txtTelefono.EditValue.ToString();

            proveedor.ContactoEmail = txtContactoMail.Text;
            proveedor.ContactoTelefono = txtTelefono_Contacto.Text;
            proveedor.ContactoNombre = txtNombre_Contacto.Text;
            proveedor.ContactoDireccion = txtDireccion_Contacto.Text;

            proveedor.ContactoTelefono2 = txtTelefono_Contacto2.Text;
            proveedor.ContactoDireccion2 = txtDireccion_Contacto2.Text;
            proveedor.ContactoEmail2 = txtContactoMail2.Text; 
            proveedor.ContactoNombre2 = txtNombre_Contacto2.Text;

            ProveedorLogico.Registrar(proveedor);

            if (ProveedorLogico.StringBuilder.Length > 0)
            {
                XtraMessageBox.Show(ProveedorLogico.StringBuilder.ToString());
                return;
            }
            DialogResult = DialogResult.OK;
        }

        private void Inicializar()
        {
            ComboBox.LlenarCombo(cbxSector, ComboBox.Catalogos.Sector);

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Registrar();
        }
    }
}