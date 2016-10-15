using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Negocio.Entidades;

namespace TechHidraulics_ERP_CRM.Servicios
{
    public partial class FrmServicios : DevExpress.XtraEditors.XtraForm
    {
        public FrmServicios()
        {
            InitializeComponent();
        }

        readonly NegServicios _servicioLogico = new NegServicios();

        private void btnNuevoServicioBasico_Click(object sender, EventArgs e)
        {
            if (new FrmRegServicio().ShowDialog() == DialogResult.OK)
                gridServiciosBasicos.DataSource = _servicioLogico.RegistrosVista();
        }

        private void FrmServicios_Load(object sender, EventArgs e)
        {
            gridServiciosBasicos.DataSource = _servicioLogico.RegistrosVista();
        }

        private void gridServiciosBasicos_ProcessGridKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Delete || viewServicio.SelectedRowsCount != 1) return;
            var id = Convert.ToInt32(viewServicio.GetRowCellValue(viewServicio.GetSelectedRows()[0], "id_servicio"));
            _servicioLogico.Eliminar(id);
        }

        private void gridServiciosBasicos_DoubleClick(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(viewServicio.GetRowCellValue(viewServicio.GetSelectedRows()[0], "id_servicio"));
            if (new FrmRegServicio(id).ShowDialog() == DialogResult.OK)
                gridServiciosBasicos.DataSource = _servicioLogico.RegistrosVista();
        }
    }
}