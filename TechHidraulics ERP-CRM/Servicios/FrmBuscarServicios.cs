using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Negocio.Entidades;

namespace TechHidraulics_ERP_CRM.Servicios
{
    public partial class FrmBuscarServicios : XtraForm
    {
        public FrmBuscarServicios()
        {
            InitializeComponent();
        }

        private DataTable _dataTable;
        public DataRow Row { get; set; }

        readonly NegServicios _serviciosLogico = new NegServicios();
        

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Registro();
        }

        private void Registro()
        {
            if (viewServicio.SelectedRowsCount != 1) return;
            var internalRow = viewServicio.GetSelectedRows()[0];
            double cantidad = Convert.ToDouble(txtCantidad.Text);
            double costoManoObra = Convert.ToDouble(viewServicio.GetRowCellValue(internalRow, "costo_mo"));
            double costoArticulo = 0.0;
            if(viewServicio.GetRowCellValue(internalRow, "costo_articulo")!= DBNull.Value)
                costoArticulo = Convert.ToDouble(viewServicio.GetRowCellValue(internalRow, "costo_articulo"));

            double totalManoObra = costoManoObra * cantidad;
            double totalArticulos = costoArticulo * cantidad;

            Row = _dataTable.NewRow();
            Row["id_servicio"] = viewServicio.GetRowCellValue(internalRow, "id_servicio");
            Row["nombre"] = viewServicio.GetRowCellValue(internalRow, "nombre");
            Row["costo_mo"] = totalManoObra;
            Row["costo_articulo"] = totalArticulos;
            Row["costo_total"] = totalManoObra + totalArticulos;
            DialogResult = DialogResult.OK;
        }

        private void viewServicio_DoubleClick(object sender, EventArgs e)
        {
            Registro();
        }

        private void txtCantidad_EditValueChanged(object sender, EventArgs e)
        {
            var num = double.Parse(txtCantidad.Text);
            if (num < 1.0)
                txtCantidad.Text = @"1";
            
        }

        private void frmBuscarServicios_Load(object sender, EventArgs e)
        {
            gridServiciosBasicos.DataSource = _serviciosLogico.RegistrosVista();
            InicializarTabla();
        }

        private void InicializarTabla()
        {
            _dataTable = new DataTable();
            _dataTable.Columns.Add("id_servicio", typeof(int));
            _dataTable.Columns.Add("nombre", typeof(string));
            _dataTable.Columns.Add("costo_mo", typeof(double));
            _dataTable.Columns.Add("costo_articulo", typeof(double));
            _dataTable.Columns.Add("costo_total", typeof(double));
        }
    }
}