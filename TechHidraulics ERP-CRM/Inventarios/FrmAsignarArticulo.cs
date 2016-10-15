using DevExpress.XtraEditors;
using System;
using System.Globalization;
using System.Windows.Forms;
using Entidades;


namespace TechHidraulics_ERP_CRM.Inventarios
{
    public partial class FrmAsignarArticulo : XtraForm
    {

        public int IdArticulo
        {
            get;
            set;
        }

        public double Precio
        {
            get;
            set;
        }

        public double Cantidad
        {
            get;
            set;
        }

        public double Total
        {
            get;
            set;
        }

        public string Nombre
        {
            get;
            set;
        }

        public FrmAsignarArticulo()
        {
            InitializeComponent();
            ComboBox.LlenarCombo(cbxArticulo, ComboBox.Catalogos.Articulos);
        }

        private void frmAsignarArticulo_Load(object sender, EventArgs e)
        {

        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {

            Asignar();
        }

        private void Asignar()
        {
            if (cbxArticulo.SelectedIndex == -1) return;
            if (Convert.ToInt32(spinCantidad.EditValue.ToString()) <= 0) return;
            DialogResult = DialogResult.OK;
        }
    

        private void CargarArticulo(int idArticulo)
        {
            
            Negocio.Entidades.NegArticulo articuloLogico = new Negocio.Entidades.NegArticulo();
            EArticulo articulo = articuloLogico.TraerPorId(idArticulo);
            IdArticulo = articulo.Id;
            Nombre = articulo.Nombre;
            var precio = articulo.Precio;
            txtPrecio.EditValue = precio;
            Calcular();
        }

        private void cbxArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idArticulo = int.Parse(((ComboBox.ComboBoxItem)cbxArticulo.SelectedItem).Value.ToString());
            CargarArticulo(idArticulo);
        }

        private void Calcular()
        {
            double precioBase = double.Parse(txtPrecio.Text);
            Precio = precioBase;
            double cantidad = double.Parse(spinCantidad.Value.ToString(CultureInfo.InvariantCulture));
            Cantidad = cantidad;
            double total = cantidad * precioBase;
            Total = total;
            txtTotal.Text = total.ToString(CultureInfo.CurrentCulture);
        }

        private void spinCantidad_EditValueChanged(object sender, EventArgs e)
        {
            Calcular();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmRegArticulo obj = new FrmRegArticulo();
            if(obj.ShowDialog() == DialogResult.OK)
               ComboBox.LlenarCombo(cbxArticulo, ComboBox.Catalogos.Articulos);
            
        }
    }
}