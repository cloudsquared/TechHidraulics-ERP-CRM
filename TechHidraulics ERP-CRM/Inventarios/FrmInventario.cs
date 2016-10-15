using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Negocio.Entidades;


namespace TechHidraulics_ERP_CRM.Inventarios
{
    public partial class FrmInventario : XtraForm
    {
        public FrmInventario()
        {
            InitializeComponent();
        }
        readonly NegArticulo _articuloLogico = new NegArticulo();
        private void btnNuevoArticulo_Click(object sender, EventArgs e)
        {
            if (new FrmRegArticulo().ShowDialog() == DialogResult.OK)
                CargarInventario();
        }

        private void  CargarInventario()
        {
            gridInventario.DataSource = _articuloLogico.Registros_Vista();
        }

        private void frmArticulo_Load(object sender, EventArgs e)
        {
            CargarInventario();
        }

        private void Editar()
        {
            if (viewArticulo.SelectedRowsCount != 1) return;
            int selectedId = Convert.ToInt32(viewArticulo.GetDataRow(viewArticulo.GetSelectedRows()[0])["id_articulo"].ToString());
            if (new FrmRegArticulo(selectedId).ShowDialog() == DialogResult.OK)
                CargarInventario();
        }

        private void viewInventario_DoubleClick(object sender, EventArgs e)
        {
            Editar();
        }
        
        private void frmEditarArticulo_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void btnBorrarArticulo_Click(object sender, EventArgs e)
        {
            if (viewArticulo.SelectedRowsCount != 1) return;
            int selectedId = Convert.ToInt32(viewArticulo.GetDataRow(viewArticulo.GetSelectedRows()[0])["id_articulo"].ToString());
            _articuloLogico.Eliminar(selectedId);
            CargarInventario();
        }
    }
}