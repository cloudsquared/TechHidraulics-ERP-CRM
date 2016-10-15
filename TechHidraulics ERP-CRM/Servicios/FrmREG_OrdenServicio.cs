using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using Entidades;
using Negocio.Entidades;
using TH;

namespace TechHidraulics_ERP_CRM.Servicios
{
    public partial class FrmRegOrdenServicio : DevExpress.XtraEditors.XtraForm
    {
        private DataTable _table;
        private readonly NegOrdenServicio _negOrdenServicio = new NegOrdenServicio();
        private readonly EOrdenServicio _ordenServicio;
        public int IdOrden;

        public FrmRegOrdenServicio()
        {
            InitializeComponent();
            Inicializador();
        }

        public FrmRegOrdenServicio(int id)
        {
            InitializeComponent();
            Inicializador();
            IdOrden = id;
            _ordenServicio = _negOrdenServicio.TraerPorId(id);
            CargarOrdenServicio();
        }

        private void frmREG_OrdenServicio_Load(object sender, EventArgs e)
        {
        }

        private void Inicializador()
        {
            InicializarTabla();
            dateElaboracion.EditValue = DateTime.Today;
            ComboBox.LlenarCombo(cbxAutor, ComboBox.Catalogos.Empleados);
            ComboBox.LlenarCombo(cbxCliente, ComboBox.Catalogos.Clientes);
            ComboBox.LlenarCombo(cbxResponsable, ComboBox.Catalogos.Empleados);

        }

        private void InicializarTabla()
        {
            _table = new DataTable();
            _table.Columns.Add("id_servicio", typeof(int));
            _table.Columns.Add("nombre", typeof(string));
            _table.Columns.Add("costo_mo", typeof(double));
            _table.Columns.Add("costo_articulo", typeof(double));
            _table.Columns.Add("costo_total", typeof(double));
        }
        
        private void CargarOrdenServicio()
        {
            //Datos generales de la orden de servicio
            if (_ordenServicio == null) return;
            txtDias.Text = _ordenServicio.DiasCredito.ToString();
            txtNumeroOrden.Text = _ordenServicio.NumeroOrden.ToString();
            ComboBox.SelectById(cbxCliente, _ordenServicio.Cliente); 
            ComboBox.SelectById(cbxAutor,_ordenServicio.AutorOrder);
            ComboBox.SelectById(cbxResponsable, _ordenServicio.Responsable);
            memoConcepto.Text = _ordenServicio.Concepto;
            txtUtilidad.EditValue = _ordenServicio.Utilidad;
            dateElaboracion.EditValue = _ordenServicio.FechaElaboracion;
            dateCompromiso.EditValue = _ordenServicio.FechaCompromiso != DateTime.MinValue ? _ordenServicio.FechaCompromiso : null;
            dateComienzo.EditValue = _ordenServicio.FechaCompromiso != DateTime.MinValue ? _ordenServicio.FechaAprobacion : null;

            //Cargar la tabla con registros, esto lo hace el procedimiento
            DataTable dataTable = _negOrdenServicio.TraerServicios(_ordenServicio.Id);
            foreach (DataRow row in dataTable.Rows)
                _table.ImportRow(row);

            
            CargarTotales();
        }



        private void CargarTotales()
        {
            gridServiciosBasicos.DataSource = _table;
            if (viewServicios.RowCount == 0)
            {
                txtServicios.EditValue = 0;
                txtTotal.EditValue = 0;
                txtImpuesto.EditValue = 0;
                txtTotalAcumulado.EditValue = 0;
            }
            else
            {
                var costoServicioTotal = 0.0;
                for (var i = 0; i < viewServicios.RowCount; i++)
                {
                    double costoServicio = double.Parse(viewServicios.GetRowCellValue(i, "costo_total").ToString());
                    costoServicioTotal += costoServicio;
                }
                txtServicios.Text = costoServicioTotal.ToString(CultureInfo.InvariantCulture);
                double utilidad = double.Parse(txtUtilidad.EditValue.ToString());
                double costoBruto = utilidad + costoServicioTotal;
                txtTotal.Text = costoBruto.ToString(CultureInfo.InvariantCulture);
                double total = double.Parse(txtTotal.EditValue.ToString());
                double impuesto = total * 0.16;
                txtImpuesto.Text = impuesto.ToString(CultureInfo.InvariantCulture);
                double totalNeto = total + impuesto;
                txtTotalAcumulado.Text = totalNeto.ToString(CultureInfo.InvariantCulture);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Registrar();
        }

        private void Registrar()
        {
            EOrdenServicio ordenServicio = new EOrdenServicio();
              ordenServicio.Id = IdOrden;
              ordenServicio.NumeroOrden = Convert.ToInt32(txtNumeroOrden.Text);
              ordenServicio.Concepto = memoConcepto.Text;
              ordenServicio.FechaElaboracion = dateElaboracion.DateTime;
              ordenServicio.FechaAprobacion = dateComienzo.DateTime;
              ordenServicio.FechaCompromiso = dateCompromiso.DateTime;
              ordenServicio.Cliente = Convert.ToInt32(((ComboBox.ComboBoxItem)(cbxCliente.SelectedItem)).Value);
              ordenServicio.AutorOrder = Convert.ToInt32(((ComboBox.ComboBoxItem)(cbxAutor.SelectedItem)).Value);
              ordenServicio.Responsable = Convert.ToInt32(((ComboBox.ComboBoxItem)(cbxResponsable.SelectedItem)).Value);
              ordenServicio.Estatus = 1;
              ordenServicio.Vehiculo =  string.IsNullOrEmpty(lblIDVehiculo.Text) ? -1 : Convert.ToInt32(lblIDVehiculo.Text);
              ordenServicio.DiasCredito = Convert.ToInt32(txtDias.Text);
              ordenServicio.Utilidad = Convert.ToInt32(txtUtilidad.EditValue);
            

            var arregloServicios = new int[viewServicios.RowCount];
            for (var i = 0; i < viewServicios.RowCount; i++)
                arregloServicios[i] = Convert.ToInt32(viewServicios.GetRowCellValue(i, "id_servicio"));
            _negOrdenServicio.Registrar(ordenServicio, arregloServicios);

        }

        private void btnAgregarServicio_Click(object sender, EventArgs e)
        {
            AgregarServicio();
        }

        private void AgregarServicio()
        {
            FrmBuscarServicios buscarServicios = new FrmBuscarServicios();
            if (buscarServicios.ShowDialog() != DialogResult.OK) return;
            DataRow dataRow = _table.NewRow();
            dataRow.ItemArray = buscarServicios.Row.ItemArray.Clone() as object[];
            _table.Rows.Add(dataRow);
            gridServiciosBasicos.DataSource = _table;
            CargarTotales();
        }

        private void txtUtilidad_EditValueChanged(object sender, EventArgs e)
        {
            CargarTotales();
        }

        private void gridServiciosBasicos_ProcessGridKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                BorrarServicio();
        }

        private void BorrarServicio(){
            if (viewServicios.SelectedRowsCount == 0) return;
            var index = viewServicios.GetVisibleIndex(viewServicios.GetSelectedRows()[0]);
            _table.Rows.Remove(_table.Rows[index]);
            CargarTotales();
        }

        private void cbxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            NegCliente negCliente = new NegCliente();
            int idCliente = ComboBox.SelectedIdToInt(cbxCliente);
            ECliente cliente = negCliente.TraerPorId(idCliente);
            txtDireccion.Text = cliente.Calle + @" " + cliente.Colonia + @" , " + cliente.Ciudad;
            txtDias.Text = cliente.DiasCredito.ToString();
            txtTelefono.Text = cliente.Telefono;
        }


        private void PrevisualizarOrden()
        {
            new ReportPrintTool(new RepCotizacion
            {
                RequestParameters = false,
                lblEmitidoPara = { Text =  cbxCliente.Text },
                lblNotas = { Text = memNotas.Text },
                lblImpuesto ={Text = @"MX " + txtImpuesto.Text},
                lblSubtotal ={Text = @"MX " + txtTotal.Text},
                lblTotal ={Text = @"MX " + txtTotalAcumulado.Text},
                lblFecha ={Text = dateElaboracion.DateTime.ToString("D")},
                lblTelefono ={Text = txtTelefono.Text},
                lblDireccion ={Text = txtDireccion.Text},
                lblConcepto ={Text = memoConcepto.Text},
                DataSource = _table,
                cellCantidad ={DataBindings = {new XRBinding("Text", _table, "cantidad")}},
                cellCodigo ={DataBindings = {new XRBinding("Text", _table, "id_servicio")}},
                cellDescripcion ={DataBindings ={new XRBinding("Text", _table, "nombre")}},
                //RequestParameters = false
            })
            {
                AutoShowParametersPanel = false
            }.ShowPreview();

        }

        private void btnPrevizualizar_Click(object sender, EventArgs e)
        {
            PrevisualizarOrden();
        }

        //for (int i = 0; i < viewServicios.SelectedRowsCount; i++)
        //{
        //    string idServicio = viewServicios.GetRowCellValue(viewServicios.GetSelectedRows()[i], "id_servicio").ToString();
        //    for (int j = _table.Rows.Count - 1; j >= 0; j--)
        //    {
        //        if (idServicio == _table.Rows[j]["id_servicio"].ToString())
        //        {
        //            _table.Rows[j].Delete();
        //            CargarTotales();
        //            break;
        //        }
        //    }
        //}

    }
}