using System;
using Negocio.Entidades;
using System.Windows.Forms;

namespace TechHidraulics_ERP_CRM.Clientes
{

    public partial class FrmClientes : DevExpress.XtraEditors.XtraForm
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        readonly NegCliente _clienteLogico = new NegCliente();


        private void FrmClientes_Load(object sender, EventArgs e)
        {
            gridCliente.DataSource = _clienteLogico.Registros();
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            if (new FrmRegCliente().ShowDialog() == DialogResult.OK)
                gridCliente.DataSource = _clienteLogico.Registros();
        }

        private void gridCliente_DoubleClick(object sender, EventArgs e)
        {
            Editar();
        }

        private void frmEditarArticulo_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void Editar()
        {
            if (viewCliente.SelectedRowsCount != 1) return;
            var dataRow = viewCliente.GetDataRow(viewCliente.GetSelectedRows()[0]);
            int idEmpleado = Convert.ToInt32(dataRow["id_cliente"]);
            if (new FrmRegCliente(idEmpleado).ShowDialog() == DialogResult.OK)
                gridCliente.DataSource = _clienteLogico.Registros();
        }
    }
}