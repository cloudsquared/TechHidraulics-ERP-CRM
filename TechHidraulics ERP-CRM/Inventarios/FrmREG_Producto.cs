using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Entidades;
using Negocio.Entidades;

namespace TechHidraulics_ERP_CRM.Inventarios
{
    public partial class FrmRegProducto :XtraForm
    {

        private readonly DataTable _table = new DataTable();
        private readonly NegProducto _productoLogico= new NegProducto();
        private readonly int _idProducto;

        public FrmRegProducto()
        {
            InitializeComponent();
        }

        public FrmRegProducto(int idProducto)
        {
            _idProducto = idProducto;
            InitializeComponent();
        }

        private void chkProducto_CheckedChanged(object sender, EventArgs e)
        {
            VerificarTipoProducto();
        }

        private void VerificarTipoProducto()
        {
            if(chkProducto.CheckState == CheckState.Checked)
            {
                lblPerc.Visible = true;
                lblPrecio.Visible = true;
                lblUtilidad.Visible = true;
                txtPrecio.Visible = true;
                txtUtilidadPorce.Visible = true;
                txtUtilidad.Visible = true;
                txtPrecioReal.Visible = true;
                lblPrecioReal.Visible = true;
            }
            else
            {
                lblPerc.Visible = false;
                lblPrecio.Visible = false;
                lblUtilidad.Visible = false;
                txtPrecio.Visible = false;
                txtUtilidadPorce.Visible = false;
                txtUtilidad.Visible = false;
                txtPrecioReal.Visible = false;
                lblPrecioReal.Visible = false;
            }
        }

        private void frmAE_Producto_Load(object sender, EventArgs e)
        {
            
            _table.Columns.Add("id_articulo", typeof(int));
            _table.Columns.Add("nombre", typeof(string));
            _table.Columns.Add("cantidad", typeof(int));
            _table.Columns.Add("precio_unitario", typeof(double));
            _table.Columns.Add("total", typeof(double));
            VerificarTipoProducto();
        }

        private void CargarTotales()
        {
            double articulosTotal = 0.0;
            for (int i = 0; i < viewArticulo.RowCount; i++)
            {
                double articulo = double.Parse(viewArticulo.GetRowCellValue(i, "total").ToString());
                articulosTotal += articulo;
            }
            txtArticulos.Text = articulosTotal.ToString(CultureInfo.InvariantCulture);
            double costoBase = double.Parse(txtCostoBase.EditValue.ToString());
            double costoTotal = costoBase + articulosTotal;
            txtTotal.Text = costoTotal.ToString(CultureInfo.InvariantCulture);

            double porcentajeUtilidad = double.Parse(txtUtilidadPorce.Text);
            double utilidad = porcentajeUtilidad * (costoTotal / 100.0);
            txtUtilidad.Text = utilidad.ToString(CultureInfo.InvariantCulture);

            double precio = costoTotal + utilidad;
            txtPrecio.Text = precio.ToString(CultureInfo.InvariantCulture);
            txtPrecioReal.Text = precio.ToString(CultureInfo.InvariantCulture);
        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            FrmAsignarArticulo frmAsignarArticulo = new FrmAsignarArticulo();
            if (frmAsignarArticulo.ShowDialog() != DialogResult.OK) return;
            DataRow dataRow = _table.NewRow();
            dataRow["id_articulo"] = frmAsignarArticulo.IdArticulo;
            dataRow["nombre"] = frmAsignarArticulo.Nombre;
            dataRow["cantidad"] = frmAsignarArticulo.Cantidad;
            dataRow["precio_unitario"] = frmAsignarArticulo.Precio;
            dataRow["total"] = frmAsignarArticulo.Total;
            _table.Rows.Add(dataRow);
            gridArticulos.DataSource = _table;
            CargarTotales();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
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

        private void txtCostoBase_EditValueChanged(object sender, EventArgs e)
        {
            CargarTotales();
        }

        private void txtUtilidadPorce_EditValueChanged(object sender, EventArgs e)
        {
            CargarTotales();
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            if(VerificarPrecio())
            Registrar();
        }


        /// <summary>
        /// Solicita la confirmacion del usuario que el precio de Venta sea mayor o igual al precio Sugerido
        /// </summary>
        /// <returns> Boolean</returns>
        private bool VerificarPrecio()
        {
            double sugerido = Convert.ToDouble(txtPrecio.EditValue);
            double real = Convert.ToDouble(txtPrecioReal.EditValue);
            if (sugerido > real)
                return XtraMessageBox.Show("El precio de VENTA es menor al precio SUGERIDO. ¿Desea Continuar?","Confirmar",MessageBoxButtons.YesNoCancel) == DialogResult.Yes;
            return true;
        }

        private void Registrar()
        {

            EProducto producto = new EProducto();

            producto.Id = _idProducto;
            producto.Nombre = txtNombre.Text;
            producto.Codigo = txtCodigo.Text;
            producto.TipoProducto = chkProducto.Checked ? 4 : 3;
            producto.Descripcion = txtDescripcion.Text;
            producto.CostoManoObra = Convert.ToDecimal(txtCostoBase.EditValue);
            producto.UtilidadPorcentaje = Convert.ToInt32(txtUtilidadPorce.EditValue);
            producto.PrecioVenta = Convert.ToDecimal(txtPrecioReal.EditValue);
         

            var productoArticuloArreglo = new EProductoArticulo[viewArticulo.RowCount];
            for (var i = 0; i < viewArticulo.RowCount; i++)
            {
                EProductoArticulo productoArticulo = new EProductoArticulo
                {
                    IdArticulo = Convert.ToInt32(viewArticulo.GetRowCellValue(i, "id_articulo")),
                    Cantidad = Convert.ToInt32(viewArticulo.GetRowCellValue(i, "cantidad"))
                };
                productoArticuloArreglo[i] = productoArticulo;
            }
            _productoLogico.Registrar(producto, productoArticuloArreglo);

            if (_productoLogico.StringBuilder.Length > 0)
            {
                XtraMessageBox.Show(_productoLogico.StringBuilder.ToString());
                return;
            }
            DialogResult = DialogResult.OK;
            
        }
    }
}