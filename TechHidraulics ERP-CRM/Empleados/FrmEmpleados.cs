using System;
using System.Windows.Forms;
using Negocio.Entidades;

namespace TechHidraulics_ERP_CRM.Empleados
{
    public partial class FrmEmpleados : DevExpress.XtraEditors.XtraForm
    {
        public FrmEmpleados()
        {
            InitializeComponent();
        }

        readonly NegEmpleado _empleadoLogico = new NegEmpleado();

        private void btnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            FrmRegEmpleado objForm = new FrmRegEmpleado();
            if (objForm.ShowDialog() != DialogResult.OK) return;
            gridEmpleado.DataSource = _empleadoLogico.Registros();
        }

        private void gridEmpleado_DoubleClick(object sender, EventArgs e)
        {
            Editar();
        }

        private void frmEditarEmpleado_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void Editar()
        {
            if (viewEmpleado.SelectedRowsCount != 1) return;
            var dataRow = viewEmpleado.GetDataRow(viewEmpleado.GetSelectedRows()[0]);
            int idEmpleado = Convert.ToInt32(dataRow["id_empleado"]);
            if (new FrmRegEmpleado(idEmpleado).ShowDialog() == DialogResult.OK)
                gridEmpleado.DataSource = _empleadoLogico.Registros();

        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            gridEmpleado.DataSource = _empleadoLogico.Registros();
        }

        
    }
}