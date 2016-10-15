using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Entidades;
using Negocio;
using Negocio.Entidades;

namespace TechHidraulics_ERP_CRM.Inventarios
{

    [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Assert, Unrestricted = true)]
    public partial class FrmRegArticulo : XtraForm
    {
        public FrmRegArticulo()
        {
            InitializeComponent();
            LlenarCombos();
        }

        public int _IdArticulo;
        private EArticulo _articulo = new EArticulo();

        public FrmRegArticulo(int idArticulo)
        {
            _IdArticulo = Convert.ToInt32(idArticulo);
            InitializeComponent();
            LlenarCombos();
            CargarArticulo();
        }


        void LlenarCombos()
        {
            ComboBox.LlenarCombo(cbxCategoria, ComboBox.Catalogos.Categorias);
            ComboBox.LlenarCombo(cbxSubCategoria, ComboBox.Catalogos.Subcategorias);
            ComboBox.LlenarCombo(cbxMedida, ComboBox.Catalogos.Medidas);
        }


        private void btnAnadir_Click(object sender, EventArgs e)
        {
            RegistrarArticulo();
        }


        private void RegistrarArticulo()
        {
            NegArticulo articuloLogico = new NegArticulo();
            _articulo.Id = _IdArticulo;
            _articulo.Codigo = txtCodigo.Text;
            _articulo.Nombre = txtNombre.Text;
            _articulo.Descripcion = memoDescripcion.Text;
            _articulo.Categoria = string.IsNullOrEmpty(cbxCategoria.Text) ? 0 : Convert.ToInt32(((ComboBox.ComboBoxItem)cbxCategoria.SelectedItem).Value);
            _articulo.TipoUnidad = string.IsNullOrEmpty(cbxMedida.Text) ? 0 : Convert.ToInt32(((ComboBox.ComboBoxItem)cbxMedida.SelectedItem).Value);
            _articulo.Subcategoria = string.IsNullOrEmpty(cbxSubCategoria.Text) ? 0 : Convert.ToInt32(((ComboBox.ComboBoxItem)cbxSubCategoria.SelectedItem).Value);
            _articulo.CantidadExistencia = Convert.ToInt32(txtCantidadExistencias.Text);
            _articulo.Estatus = 1;
            _articulo.Marca = txtMarca.Text;
            _articulo.Precio = Convert.ToDecimal(txtPrecio.EditValue);
            articuloLogico.Registrar(_articulo);

            //En caso de que la validacion del articulo no se cumpla, mostramos un error
            if (articuloLogico.StringBuilder.Length > 0)
                XtraMessageBox.Show(articuloLogico.StringBuilder.ToString());
            else
            {
                GuardarFoto();
                DialogResult = DialogResult.OK;
            }

        }
        private void GuardarFoto()
        {
            if (picArticulo.Image == null) return;
            if (_articulo.Id == 0)
            {
                var maxId = Conexion.ExQy_One_Data("select max(id_articulo) from articulo");
                string path = AccesoCarpetas.ObtenerDireccionCarpeta(Carpetas.Articulos) + maxId + ".jpg";
                picArticulo.Image.Save(path);
            }
            else
            {
                string path = AccesoCarpetas.ObtenerDireccionCarpeta(Carpetas.Articulos) + _IdArticulo + ".jpg";
                var fi = new FileInfo(path);
                if (fi.Exists)
                    fi.Delete();
                picArticulo.Image.Save(path);
            }
        }

       
                

        private void frmArticulo_Load(object sender, EventArgs e)
        {
           
        }

        private void CargarArticulo()
        {
            NegArticulo articuloLogico = new NegArticulo();
            _articulo = articuloLogico.TraerPorId(_IdArticulo);

            txtNombre.Text = _articulo.Nombre;
            memoDescripcion.Text = _articulo.Descripcion;
            txtCantidadExistencias.Text = _articulo.CantidadExistencia.ToString(CultureInfo.InvariantCulture);
            txtCantidadBaja.Text = _articulo.CantidadMinima.ToString(CultureInfo.InvariantCulture);
            txtPrecio.EditValue = _articulo.Precio;
            ComboBox.SelectById(cbxMedida, _articulo.TipoUnidad);
            ComboBox.SelectById(cbxCategoria, _articulo.Categoria);
            ComboBox.SelectById(cbxSubCategoria, _articulo.Subcategoria);
            txtMarca.Text = _articulo.Marca;
            txtCodigo.Text = _articulo.Codigo;
            picArticulo.Image = Imagenes.ObtenerImagen(Imagenes.Categoria.Articulos, _articulo.Id);
        }

        private void txtCantidadExistencias_EditValueChanged(object sender, EventArgs e)
        {
            if ( string.IsNullOrEmpty(txtCantidadExistencias.Text))
            {
                txtCantidadExistencias.Text = @"0";
            }
        }
        
        
    }
}