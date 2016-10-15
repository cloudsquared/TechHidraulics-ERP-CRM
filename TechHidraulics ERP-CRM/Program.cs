using System;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using TechHidraulics_ERP_CRM.Usuario;

namespace TechHidraulics_ERP_CRM
{
    static class Program
    {
        /// <summary>
        /// TechHidraulics_ERP_CRMe main entry point for TechHidraulics_ERP_CRMe application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            Application.Run(new FrmInicioSesion());
        }
    }
}
