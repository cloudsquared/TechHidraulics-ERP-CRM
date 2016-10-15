using System;
using DevExpress.XtraEditors;

namespace TechHidraulics_ERP_CRM
{
    public partial class FrmBienvenido : XtraForm
    {
        public FrmBienvenido()
        {
            InitializeComponent();
        }

        private void frmBienvenido_Load(object sender, EventArgs e)
        {
            lblNombre.Text = Usuario.Usuario.NombreCompleto;
        }
    }
}