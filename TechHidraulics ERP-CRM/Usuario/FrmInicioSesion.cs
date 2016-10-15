using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TechHidraulics_ERP_CRM.Usuario
{
    public partial class FrmInicioSesion : DevExpress.XtraEditors.XtraForm
    {
        public FrmInicioSesion()
        {
            InitializeComponent();
        }

        private void FrmInicioSesion_Load(object sender, EventArgs e)
        { 

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;

            if( string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasena))
            {
                XtraMessageBox.Show("Favor de ingresar usuario y contraseña");
                return;
            }

            if (Negocio.AccesoLogico.VerificarUsuario(usuario, contrasena))
            {
                var datos = Negocio.AccesoLogico.DatosUsuario(usuario);
                Usuario.IdEmpleado = datos["id_empleado"].ToString();
                Usuario.NombreCompleto = datos["nombre"] + datos["apellido"].ToString();
                Usuario.Puesto = datos["puesto"].ToString();

                FrmMdi frm = new FrmMdi(this);
                frm.Show();
                Hide();
            }
            else
            {
                XtraMessageBox.Show("Error al iniciar sesion, contraseña y/o usuario invalidos.");
            }
        }

        private void txtUsuario_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) txtContrasena.Focus();
        }

        private void txtContrasena_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnLogin.PerformClick();
        }

        private void btnMultiuser_Click(object sender, EventArgs e)
        {
            Usuario.IdEmpleado = "0077";
            Usuario.NombreCompleto = "Daniel Castro Nañez";
            Usuario.Puesto = "Programador Senior";

            FrmMdi frm = new FrmMdi(this);
            frm.Show();
            Hide();
        }
    }
}