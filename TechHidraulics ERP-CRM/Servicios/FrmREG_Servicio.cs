using System;
using DevExpress.XtraEditors;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using Entidades;
using Negocio.Entidades;
using TechHidraulics_ERP_CRM.Inventarios;

namespace TechHidraulics_ERP_CRM.Servicios
{
    public partial class FrmRegServicio : XtraForm
    {
        private readonly int _idServicio;
        private readonly NegServicios _servicioLogico = new NegServicios();
        private readonly DataTable _table;
        public FrmRegServicio()
        {
            InitializeComponent();
            _table = _servicioLogico.TempTable;
        }

        public FrmRegServicio(int id)
        {
            _idServicio = id;
            InitializeComponent();
            _table = _servicioLogico.TempTable;
        }

        private void frmNuevaActividad_Load(object sender, EventArgs e)
        {
            CargarServicio();
        }

        private void CargarServicio()
        {
            if (_idServicio == 0) return;
            EServicio servicio = _servicioLogico.TraerPorId(_idServicio);
            txtNombre.Text = servicio.Nombre;
            txtCostoBase.EditValue = servicio.CostoManoObra;
            DataTable dataTable = _servicioLogico.TraerArticulos(servicio.Id);
            foreach (DataRow row in dataTable.Rows)
                _table.ImportRow(row);
            gridArticulos.DataSource = _table;
            CargarTotales();
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
                Registrar();
        }
        
        private void Registrar()
        {
            EServicio servicio = new EServicio
            {
                Nombre = txtNombre.Text,
                CostoManoObra = Convert.ToDecimal(txtCostoBase.EditValue)
            };
            var servicioArticuloArreglo= new EServicioArticulo[viewArticulo.RowCount];
            for (var i = 0; i < viewArticulo.RowCount; i++)
            {
                EServicioArticulo servicioArticulo = new EServicioArticulo
                {
                    IdArticulo = Convert.ToInt32(viewArticulo.GetRowCellValue(i, "id_articulo")),
                    Cantidad = Convert.ToInt32(viewArticulo.GetRowCellValue(i, "cantidad"))
                };
                servicioArticuloArreglo[i] = servicioArticulo;
            }
           _servicioLogico.Registrar(servicio, servicioArticuloArreglo);

            if (_servicioLogico.StringBuilder.Length > 0)
            {
                XtraMessageBox.Show(_servicioLogico.StringBuilder.ToString());
                return;
            }
            DialogResult = DialogResult.OK;
        }

        private void CargarTotales()
        {
            var totalArticulosAcumulado = 0.0;
            for (var i = 0; i < viewArticulo.RowCount; i++)
            {
                var total = double.Parse(viewArticulo.GetRowCellValue(i, "total").ToString());
                totalArticulosAcumulado += total;
            }
            txtArticulos.Text = totalArticulosAcumulado.ToString(CultureInfo.InvariantCulture);
            var costoManoObra = double.Parse(txtCostoBase.EditValue.ToString());
            var totalNeto = costoManoObra + totalArticulosAcumulado;
            txtTotal.Text = totalNeto.ToString(CultureInfo.InvariantCulture);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            var frmAsignarArticulo = new FrmAsignarArticulo();
            if (frmAsignarArticulo.ShowDialog() != DialogResult.OK) return;
            var dataRow = _table.NewRow();
            dataRow["id_articulo"] = frmAsignarArticulo.IdArticulo;
            dataRow["nombre"] = frmAsignarArticulo.Nombre;
            dataRow["cantidad"] = frmAsignarArticulo.Cantidad;
            dataRow["precio_unitario"] = frmAsignarArticulo.Precio;
            dataRow["total"] = frmAsignarArticulo.Total;
            _table.Rows.Add(dataRow);
            gridArticulos.DataSource = _table;
            CargarTotales();
        }

        private void txtCostoBase_EditValueChanged(object sender, EventArgs e)
        {
            CargarTotales();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Borrar();
        }

        private void Borrar()
        {
            if (viewArticulo.SelectedRowsCount <= 0) return;
            var index = viewArticulo.GetVisibleIndex(viewArticulo.GetSelectedRows()[0]);
             _table.Rows.Remove(_table.Rows[index]);
            CargarTotales();
        }

        private void gridArticulos_ProcessGridKey_1(object sender, KeyEventArgs e)
        {
            Borrar();
        }
    }
}