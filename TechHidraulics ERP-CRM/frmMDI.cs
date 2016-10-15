using System;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using TechHidraulics_ERP_CRM.Clientes;
using TechHidraulics_ERP_CRM.Empleados;
using TechHidraulics_ERP_CRM.Inventarios;
using TechHidraulics_ERP_CRM.Proveedores;
using TechHidraulics_ERP_CRM.Servicios;

namespace TechHidraulics_ERP_CRM
{
    public partial class FrmMdi : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly XtraForm _parent;
        public FrmMdi(XtraForm parent)
        {
            _parent = parent;
            InitializeComponent();
            AbrirFormulario(new FrmBienvenido());
        }

       

        public void AbrirFormulario(XtraForm form)
        {
            if (VerificarFormulario(form)) return;
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private bool VerificarFormulario(Control form)
        {
            foreach (var xtraform in MdiChildren)
            {
                var index = (XtraForm)xtraform;
                var xtraForm = index;
                if (form.Text != xtraForm.Text) continue;
                xtraForm.WindowState = FormWindowState.Maximized;
                xtraForm.Focus();
                return true;
            }
            return false;
        }



        private void btnInventario_ItemClick(object sender, ItemClickEventArgs e)
        {
            AbrirFormulario(new FrmInventario());
        }
        private void btnEmpleados_ItemClick(object sender, ItemClickEventArgs e)
        {
            AbrirFormulario(new FrmEmpleados());
        }

        private void btnServicios_ItemClick(object sender, ItemClickEventArgs e)
        {
            AbrirFormulario(new FrmServicios());
        }

        private void btnNuevaOrden_ItemClick(object sender, ItemClickEventArgs e)
        {
            AbrirFormulario(new FrmRegOrdenServicio());
        }

        private void btnNuevoArticulo_ItemClick(object sender, ItemClickEventArgs e)
        {
            new FrmRegArticulo().ShowDialog();
        }

        private void btnClientes_ItemClick(object sender, ItemClickEventArgs e)
        {
            AbrirFormulario(new FrmClientes());
        }

        private void btnHome_ItemClick(object sender, ItemClickEventArgs e)
        {
            MdiChildren[0].Show();
        }

        private void btnProveedores_ItemClick(object sender, ItemClickEventArgs e)
        {
            AbrirFormulario(new FrmProveedores());
        }

        private void btnVehiculos_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnProductos_ItemClick(object sender, ItemClickEventArgs e)
        {
            new FrmRegProducto().ShowDialog();}

        private void btnOrdenes_ItemClick(object sender, ItemClickEventArgs e)
        {
            AbrirFormulario(new FrmOrdenes());
        }

        private void FrmMdi_FormClosed(object sender, FormClosedEventArgs e)
        {
          _parent.Close();
        }
    }
}