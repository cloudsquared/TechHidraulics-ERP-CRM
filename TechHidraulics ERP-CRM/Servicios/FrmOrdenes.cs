using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Negocio.Entidades;

namespace TechHidraulics_ERP_CRM.Servicios
{
    public partial class FrmOrdenes : XtraForm
    {
        readonly NegOrdenServicio _negOrdenServicio= new NegOrdenServicio();

        public FrmOrdenes()
        {
            InitializeComponent();
        }

        private void FrmOrdenes_Load(object sender, EventArgs e)
        {
            gridOrdenes.DataSource = _negOrdenServicio.RegistrosVista();
        }
       
        private void gridOrdenes_DoubleClick(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(viewOrdenes.GetRowCellValue(viewOrdenes.GetSelectedRows()[0], "id_orden"));
            if (new FrmRegOrdenServicio(id).ShowDialog() == DialogResult.OK)
                gridOrdenes.DataSource = _negOrdenServicio.Registros();
        }

        private void gridOrdenes_ProcessGridKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Delete || viewOrdenes.SelectedRowsCount != 1) return;
            var id = Convert.ToInt32(viewOrdenes.GetRowCellValue(viewOrdenes.GetSelectedRows()[0], "id_orden"));
            _negOrdenServicio.Eliminar(id);
        }
    }
}