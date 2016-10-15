using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Negocio.Entidades;

namespace TechHidraulics_ERP_CRM.Proveedores
{
    public partial class FrmProveedores : XtraForm
    {
        public FrmProveedores()
        {
            InitializeComponent();
        }

        readonly NegProveedor _negProveedor = new NegProveedor();

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            gridProveedor.DataSource = _negProveedor.Registros();
        }

        private void btnNuevoProveedor_Click(object sender, EventArgs e)
        {

            if (new FrmRegProveedor().ShowDialog() == DialogResult.OK)
                gridProveedor.DataSource = _negProveedor.Registros();
        }

        private void Editar()
        {
            if (viewProveedor.SelectedRowsCount != 1) return;
            var dataRow = viewProveedor.GetDataRow(viewProveedor.GetSelectedRows()[0]);
            int idEmpleado = Convert.ToInt32(dataRow["id_proveedor"]);
            if (new FrmRegProveedor(idEmpleado).ShowDialog() == DialogResult.OK)
                gridProveedor.DataSource = _negProveedor.Registros();
        }

        private void viewProveedor_DoubleClick(object sender, EventArgs e)
        {
            Editar();
        }

        private void frmEditarProveedor_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void btnBorrarArticulo_Click(object sender, EventArgs e)
        {
            if (viewProveedor.SelectedRowsCount != 1) return;
            var dataRow = viewProveedor.GetDataRow(viewProveedor.GetSelectedRows()[0]);
            int idEmpleado = Convert.ToInt32(dataRow["id_proveedor"]);
            _negProveedor.Eliminar(idEmpleado);
            gridProveedor.DataSource = _negProveedor.Registros();
        }
    }
}