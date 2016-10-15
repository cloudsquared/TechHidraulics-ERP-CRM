using System;
using System.Data;
using DevExpress.XtraEditors;

namespace TechHidraulics_ERP_CRM
{
    class ComboBox
    {
        public enum Catalogos
        {
            Clientes,
            Empleados,
            Proveedores,
            Articulos,
            Categorias,
            Subcategorias,
            Medidas,
            Departamentos,
            Puestos,
            Sector
        }

        public static void LlenarCombo(ComboBoxEdit combobox, Catalogos catalogo)
        {
            combobox.Properties.Items.Clear();

            DataTable tablaDatos = null;
            switch (catalogo)
            {
                case Catalogos.Clientes: tablaDatos = Negocio.DatosGenerales.ObtenerClientes(); break;
                case Catalogos.Empleados: tablaDatos = Negocio.DatosGenerales.ObtenerEmpleados(); break;
                case Catalogos.Proveedores: tablaDatos = Negocio.DatosGenerales.ObtenerProveedores(); break;
                case Catalogos.Articulos: tablaDatos = Negocio.DatosGenerales.ObtenerArticulos(); break;
                case Catalogos.Categorias: tablaDatos = Negocio.DatosGenerales.ObtenerCategorias(); break;
                case Catalogos.Subcategorias:tablaDatos = Negocio.DatosGenerales.ObtenerSubcategorias(); break;
                case Catalogos.Medidas: tablaDatos = Negocio.DatosGenerales.ObtenerMedidas(); break;
                case Catalogos.Departamentos: tablaDatos = Negocio.DatosGenerales.ObtenerDepartamentos(); break;
                case Catalogos.Puestos: tablaDatos = Negocio.DatosGenerales.ObtenerPuestos(); break;
                case Catalogos.Sector: tablaDatos = Negocio.DatosGenerales.ObtenerSectores(); break;




            }
            if (tablaDatos != null && tablaDatos.Rows.Count > 0)
            {
                foreach (DataRow row in tablaDatos.Rows)
                {
                    ComboBoxItem item = new ComboBoxItem
                    {
                        Text = row[1].ToString(),
                        Value = row[0]
                    };
                    combobox.Properties.Items.Add(item);
                }
            }
        }


        public static void LlenarComboBox(ComboBoxEdit cbx, string consulta, int field)
        {
            DataSet dataSet = Conexion.EjecutarQueryDataset(consulta);
            try
            {
                cbx.Properties.Items.Clear();
                var flag = dataSet.Tables[0].Rows.Count > 0;
                if (flag)
                {
                    foreach (DataRow dataRow2 in dataSet.Tables[0].Rows)
                    {
                        var item = new ComboBoxItem
                        {
                            Text = dataRow2[field].ToString(),
                            Value = dataRow2[0]
                        };
                        cbx.Properties.Items.Add(item);
                    }
                }
                else
                {
                    cbx.Text = @"Sin registros";
                }
            }
            catch
            {
                // ignored
            }
        }


        public static int SelectedIdToInt(ComboBoxEdit combobox)
        {
            return Convert.ToInt32(((ComboBoxItem) combobox.SelectedItem).Value);
        }


        public static void SelectById(ComboBoxEdit combobox, int value)
        {
            foreach (ComboBoxItem comboBoxItem in combobox.Properties.Items)
            {
                if (Convert.ToInt32(comboBoxItem.Value) != value) continue;
                combobox.SelectedItem = comboBoxItem;
            }
        }


        public class ComboBoxItem
        {
            public string Text
            {
                get;
                set;
            }

            public object Value
            {
                get;
                set;
            }

            public override string ToString()
            {
                return Text;
            }

            public ComboBoxItem()
            {
            }

            public ComboBoxItem(int value, string text)
            {
                Value = value;
                Text = text;
            }
        }




    }
}