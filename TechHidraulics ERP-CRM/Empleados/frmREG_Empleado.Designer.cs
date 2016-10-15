using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace TechHidraulics_ERP_CRM.Empleados
{
    partial class FrmRegEmpleado
    {
        private IContainer components = null;

        private LabelControl labelControl13;

        private TextEdit txtNombre;

        private LabelControl labelControl1;

        private TextEdit txtApellidos;

        private LabelControl labelControl2;

        private TextEdit txtCiudad;

        private LabelControl labelControl3;

        private TextEdit txtCalle;

        private LabelControl labelControl4;

        private TextEdit txtFicha;

        private SimpleButton btnCancelar;

        private SimpleButton btnRegistrar;

        private LabelControl labelControl5;

        private LabelControl labelControl6;

        private LabelControl labelControl8;

        private LabelControl labelControl9;

        private TextEdit txtUsuario;

        private GroupControl groupControl1;

        private GroupControl groupControl2;

        private TextEdit txtContrasena;

        private LabelControl labelControl11;

        private SimpleButton btnNuevoPuesto;

        private ComboBoxEdit cbxPuesto;

        private PictureEdit picPhoto;

        private TextEdit txtContrasenaConfirm;

        private LabelControl labelControl12;

        private LabelControl labelControl14;

        private DateEdit dateContratacion;

        private LabelControl labelControl15;

        private DateEdit dateNacimiento;

        private CheckEdit chkF;

        private CheckEdit chkM;

        private LabelControl labelControl16;

        private SimpleButton btnCargarFoto;

        private ComboBoxEdit cbxDepartamento;

        private LabelControl labelControl18;

        private LabelControl labelControl17;

        private DateEdit dateTerminacion;

        private SimpleButton btnNuevoDepartamento;

        private LabelControl labelControl22;

        private LabelControl labelControl21;

        private LabelControl labelControl26;

        private LabelControl labelControl27;

        private TextEdit txtRFC;

        private LabelControl labelControl29;

        private TextEdit txtReferencia;

        private LabelControl labelControl28;

        private LabelControl labelControl30;

        private CheckEdit chkAdministrador;
        /// <summary>
        /// Required designer variable.
        /// </summary>

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtApellidos = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtCiudad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtCalle = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtFicha = new DevExpress.XtraEditors.TextEdit();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnRegistrar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtUsuario = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.chkAdministrador = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl30 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl27 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl22 = new DevExpress.XtraEditors.LabelControl();
            this.btnNuevoDepartamento = new DevExpress.XtraEditors.SimpleButton();
            this.cbxDepartamento = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.dateTerminacion = new DevExpress.XtraEditors.DateEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.dateContratacion = new DevExpress.XtraEditors.DateEdit();
            this.txtContrasenaConfirm = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.btnNuevoPuesto = new DevExpress.XtraEditors.SimpleButton();
            this.cbxPuesto = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtContrasena = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtInfonavit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl24 = new DevExpress.XtraEditors.LabelControl();
            this.txtImss = new DevExpress.XtraEditors.TextEdit();
            this.labelControl34 = new DevExpress.XtraEditors.LabelControl();
            this.txtCurp = new DevExpress.XtraEditors.TextEdit();
            this.labelControl31 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl33 = new DevExpress.XtraEditors.LabelControl();
            this.txtRFC = new DevExpress.XtraEditors.TextEdit();
            this.labelControl21 = new DevExpress.XtraEditors.LabelControl();
            this.chkF = new DevExpress.XtraEditors.CheckEdit();
            this.chkM = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.dateNacimiento = new DevExpress.XtraEditors.DateEdit();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.txtReferencia = new DevExpress.XtraEditors.TextEdit();
            this.labelControl28 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl29 = new DevExpress.XtraEditors.LabelControl();
            this.btnCargarFoto = new DevExpress.XtraEditors.SimpleButton();
            this.picPhoto = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl26 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.txtTelefono = new DevExpress.XtraEditors.TextEdit();
            this.lbl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCP = new DevExpress.XtraEditors.TextEdit();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.txtColonia = new DevExpress.XtraEditors.TextEdit();
            this.labelControl32 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.txtTipoSangre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl36 = new DevExpress.XtraEditors.LabelControl();
            this.txtPeso = new DevExpress.XtraEditors.TextEdit();
            this.labelControl37 = new DevExpress.XtraEditors.LabelControl();
            this.txtEstatura = new DevExpress.XtraEditors.TextEdit();
            this.labelControl41 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApellidos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCiudad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCalle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFicha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkAdministrador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDepartamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTerminacion.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTerminacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateContratacion.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateContratacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContrasenaConfirm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxPuesto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContrasena.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInfonavit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImss.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRFC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkF.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNacimiento.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNacimiento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReferencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtColonia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoSangre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstatura.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Location = new System.Drawing.Point(27, 47);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(71, 18);
            this.labelControl13.TabIndex = 33;
            this.labelControl13.Text = "Nombre(s):";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(104, 44);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Properties.Appearance.Options.UseFont = true;
            this.txtNombre.Size = new System.Drawing.Size(260, 24);
            this.txtNombre.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(27, 77);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 18);
            this.labelControl1.TabIndex = 35;
            this.labelControl1.Text = "Apellidos:";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(104, 74);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Properties.Appearance.Options.UseFont = true;
            this.txtApellidos.Size = new System.Drawing.Size(260, 24);
            this.txtApellidos.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(27, 135);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(27, 18);
            this.labelControl2.TabIndex = 37;
            this.labelControl2.Text = "RFC:";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(120, 134);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCiudad.Properties.Appearance.Options.UseFont = true;
            this.txtCiudad.Properties.Mask.EditMask = "(\\d?\\d?\\d?) \\d\\d\\d-\\d\\d\\d\\d";
            this.txtCiudad.Size = new System.Drawing.Size(282, 24);
            this.txtCiudad.TabIndex = 12;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(27, 77);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(35, 18);
            this.labelControl3.TabIndex = 39;
            this.labelControl3.Text = "Calle:";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(120, 74);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalle.Properties.Appearance.Options.UseFont = true;
            this.txtCalle.Size = new System.Drawing.Size(282, 24);
            this.txtCalle.TabIndex = 10;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(27, 38);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(140, 18);
            this.labelControl4.TabIndex = 41;
            this.labelControl4.Text = "Numero de empleado:";
            // 
            // txtFicha
            // 
            this.txtFicha.Location = new System.Drawing.Point(173, 35);
            this.txtFicha.Name = "txtFicha";
            this.txtFicha.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFicha.Properties.Appearance.Options.UseFont = true;
            this.txtFicha.Properties.Mask.EditMask = "d";
            this.txtFicha.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtFicha.Size = new System.Drawing.Size(191, 24);
            this.txtFicha.TabIndex = 18;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Appearance.Options.UseFont = true;
            this.btnCancelar.Appearance.Options.UseTextOptions = true;
            this.btnCancelar.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(853, 591);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 30);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.ToolTip = "Le permite al usuario añadir un nuevo articulo al Inventario.";
            this.btnCancelar.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btnCancelar.ToolTipTitle = "Agregar";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Appearance.Options.UseFont = true;
            this.btnRegistrar.Appearance.Options.UseTextOptions = true;
            this.btnRegistrar.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnRegistrar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnRegistrar.Location = new System.Drawing.Point(960, 591);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(101, 30);
            this.btnRegistrar.TabIndex = 28;
            this.btnRegistrar.Text = "Aceptar";
            this.btnRegistrar.ToolTip = "Le permite al usuario añadir un nuevo articulo al Inventario.";
            this.btnRegistrar.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btnRegistrar.ToolTipTitle = "Agregar";
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(16, 77);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(7, 18);
            this.labelControl5.TabIndex = 44;
            this.labelControl5.Text = "*";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(14, 47);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(7, 18);
            this.labelControl6.TabIndex = 45;
            this.labelControl6.Text = "*";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Location = new System.Drawing.Point(27, 68);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(47, 18);
            this.labelControl8.TabIndex = 48;
            this.labelControl8.Text = "Puesto:";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Location = new System.Drawing.Point(467, 38);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(51, 18);
            this.labelControl9.TabIndex = 50;
            this.labelControl9.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(613, 35);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Properties.Appearance.Options.UseFont = true;
            this.txtUsuario.Size = new System.Drawing.Size(221, 24);
            this.txtUsuario.TabIndex = 23;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.chkAdministrador);
            this.groupControl1.Controls.Add(this.labelControl30);
            this.groupControl1.Controls.Add(this.labelControl27);
            this.groupControl1.Controls.Add(this.labelControl22);
            this.groupControl1.Controls.Add(this.btnNuevoDepartamento);
            this.groupControl1.Controls.Add(this.cbxDepartamento);
            this.groupControl1.Controls.Add(this.labelControl18);
            this.groupControl1.Controls.Add(this.labelControl17);
            this.groupControl1.Controls.Add(this.dateTerminacion);
            this.groupControl1.Controls.Add(this.labelControl14);
            this.groupControl1.Controls.Add(this.dateContratacion);
            this.groupControl1.Controls.Add(this.txtContrasenaConfirm);
            this.groupControl1.Controls.Add(this.labelControl12);
            this.groupControl1.Controls.Add(this.btnNuevoPuesto);
            this.groupControl1.Controls.Add(this.cbxPuesto);
            this.groupControl1.Controls.Add(this.txtContrasena);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtFicha);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.txtUsuario);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Location = new System.Drawing.Point(45, 369);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1016, 196);
            this.groupControl1.TabIndex = 55;
            this.groupControl1.Text = "Informacion empresarial:";
            // 
            // chkAdministrador
            // 
            this.chkAdministrador.Location = new System.Drawing.Point(613, 126);
            this.chkAdministrador.Name = "chkAdministrador";
            this.chkAdministrador.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.chkAdministrador.Properties.Appearance.Options.UseFont = true;
            this.chkAdministrador.Properties.Caption = "Administrador de sistema";
            this.chkAdministrador.Size = new System.Drawing.Size(208, 22);
            this.chkAdministrador.TabIndex = 26;
            this.chkAdministrador.TabStop = false;
            // 
            // labelControl30
            // 
            this.labelControl30.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl30.Location = new System.Drawing.Point(14, 68);
            this.labelControl30.Name = "labelControl30";
            this.labelControl30.Size = new System.Drawing.Size(7, 18);
            this.labelControl30.TabIndex = 75;
            this.labelControl30.Text = "*";
            // 
            // labelControl27
            // 
            this.labelControl27.Appearance.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl27.Location = new System.Drawing.Point(370, 161);
            this.labelControl27.Name = "labelControl27";
            this.labelControl27.Size = new System.Drawing.Size(40, 14);
            this.labelControl27.TabIndex = 74;
            this.labelControl27.Text = "Si aplica";
            // 
            // labelControl22
            // 
            this.labelControl22.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl22.Location = new System.Drawing.Point(14, 38);
            this.labelControl22.Name = "labelControl22";
            this.labelControl22.Size = new System.Drawing.Size(7, 18);
            this.labelControl22.TabIndex = 71;
            this.labelControl22.Text = "*";
            // 
            // btnNuevoDepartamento
            // 
            this.btnNuevoDepartamento.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoDepartamento.Appearance.Options.UseFont = true;
            this.btnNuevoDepartamento.Appearance.Options.UseTextOptions = true;
            this.btnNuevoDepartamento.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnNuevoDepartamento.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnNuevoDepartamento.Location = new System.Drawing.Point(374, 96);
            this.btnNuevoDepartamento.Name = "btnNuevoDepartamento";
            this.btnNuevoDepartamento.Size = new System.Drawing.Size(24, 21);
            this.btnNuevoDepartamento.TabIndex = 63;
            this.btnNuevoDepartamento.Text = "+";
            // 
            // cbxDepartamento
            // 
            this.cbxDepartamento.Location = new System.Drawing.Point(127, 95);
            this.cbxDepartamento.Name = "cbxDepartamento";
            this.cbxDepartamento.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.cbxDepartamento.Properties.Appearance.Options.UseFont = true;
            this.cbxDepartamento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxDepartamento.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbxDepartamento.Size = new System.Drawing.Size(237, 24);
            this.cbxDepartamento.TabIndex = 20;
            // 
            // labelControl18
            // 
            this.labelControl18.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl18.Location = new System.Drawing.Point(27, 98);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(94, 18);
            this.labelControl18.TabIndex = 61;
            this.labelControl18.Text = "Departamento:";
            // 
            // labelControl17
            // 
            this.labelControl17.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl17.Location = new System.Drawing.Point(27, 158);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(118, 18);
            this.labelControl17.TabIndex = 60;
            this.labelControl17.Text = "Fecha terminacion:";
            // 
            // dateTerminacion
            // 
            this.dateTerminacion.EditValue = null;
            this.dateTerminacion.Location = new System.Drawing.Point(164, 155);
            this.dateTerminacion.Name = "dateTerminacion";
            this.dateTerminacion.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.dateTerminacion.Properties.Appearance.Options.UseFont = true;
            this.dateTerminacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTerminacion.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTerminacion.Size = new System.Drawing.Size(200, 24);
            this.dateTerminacion.TabIndex = 22;
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl14.Location = new System.Drawing.Point(27, 128);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(120, 18);
            this.labelControl14.TabIndex = 58;
            this.labelControl14.Text = "Fecha contratacion:";
            // 
            // dateContratacion
            // 
            this.dateContratacion.EditValue = null;
            this.dateContratacion.Location = new System.Drawing.Point(164, 125);
            this.dateContratacion.Name = "dateContratacion";
            this.dateContratacion.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.dateContratacion.Properties.Appearance.Options.UseFont = true;
            this.dateContratacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateContratacion.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateContratacion.Size = new System.Drawing.Size(200, 24);
            this.dateContratacion.TabIndex = 21;
            // 
            // txtContrasenaConfirm
            // 
            this.txtContrasenaConfirm.Location = new System.Drawing.Point(613, 95);
            this.txtContrasenaConfirm.Name = "txtContrasenaConfirm";
            this.txtContrasenaConfirm.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasenaConfirm.Properties.Appearance.Options.UseFont = true;
            this.txtContrasenaConfirm.Properties.UseSystemPasswordChar = true;
            this.txtContrasenaConfirm.Size = new System.Drawing.Size(221, 24);
            this.txtContrasenaConfirm.TabIndex = 25;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Location = new System.Drawing.Point(467, 98);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(139, 18);
            this.labelControl12.TabIndex = 56;
            this.labelControl12.Text = "Confirmar Contraseña:";
            // 
            // btnNuevoPuesto
            // 
            this.btnNuevoPuesto.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoPuesto.Appearance.Options.UseFont = true;
            this.btnNuevoPuesto.Appearance.Options.UseTextOptions = true;
            this.btnNuevoPuesto.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnNuevoPuesto.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnNuevoPuesto.Location = new System.Drawing.Point(374, 66);
            this.btnNuevoPuesto.Name = "btnNuevoPuesto";
            this.btnNuevoPuesto.Size = new System.Drawing.Size(24, 21);
            this.btnNuevoPuesto.TabIndex = 54;
            this.btnNuevoPuesto.Text = "+";
            // 
            // cbxPuesto
            // 
            this.cbxPuesto.Location = new System.Drawing.Point(127, 65);
            this.cbxPuesto.Name = "cbxPuesto";
            this.cbxPuesto.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.cbxPuesto.Properties.Appearance.Options.UseFont = true;
            this.cbxPuesto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxPuesto.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbxPuesto.Size = new System.Drawing.Size(237, 24);
            this.cbxPuesto.TabIndex = 19;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(613, 65);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.Properties.Appearance.Options.UseFont = true;
            this.txtContrasena.Properties.UseSystemPasswordChar = true;
            this.txtContrasena.Size = new System.Drawing.Size(221, 24);
            this.txtContrasena.TabIndex = 24;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Location = new System.Drawing.Point(467, 68);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(74, 18);
            this.labelControl11.TabIndex = 52;
            this.labelControl11.Text = "Contraseña:";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.txtInfonavit);
            this.groupControl2.Controls.Add(this.labelControl24);
            this.groupControl2.Controls.Add(this.txtImss);
            this.groupControl2.Controls.Add(this.labelControl34);
            this.groupControl2.Controls.Add(this.txtCurp);
            this.groupControl2.Controls.Add(this.labelControl31);
            this.groupControl2.Controls.Add(this.labelControl33);
            this.groupControl2.Controls.Add(this.txtRFC);
            this.groupControl2.Controls.Add(this.labelControl21);
            this.groupControl2.Controls.Add(this.chkF);
            this.groupControl2.Controls.Add(this.chkM);
            this.groupControl2.Controls.Add(this.labelControl16);
            this.groupControl2.Controls.Add(this.labelControl15);
            this.groupControl2.Controls.Add(this.dateNacimiento);
            this.groupControl2.Controls.Add(this.labelControl13);
            this.groupControl2.Controls.Add(this.txtNombre);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.txtApellidos);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Location = new System.Drawing.Point(45, 30);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(377, 323);
            this.groupControl2.TabIndex = 56;
            this.groupControl2.Text = "Informacion personal";
            // 
            // txtInfonavit
            // 
            this.txtInfonavit.Location = new System.Drawing.Point(104, 224);
            this.txtInfonavit.Name = "txtInfonavit";
            this.txtInfonavit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfonavit.Properties.Appearance.Options.UseFont = true;
            this.txtInfonavit.Size = new System.Drawing.Size(260, 24);
            this.txtInfonavit.TabIndex = 7;
            // 
            // labelControl24
            // 
            this.labelControl24.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl24.Location = new System.Drawing.Point(27, 227);
            this.labelControl24.Name = "labelControl24";
            this.labelControl24.Size = new System.Drawing.Size(74, 18);
            this.labelControl24.TabIndex = 82;
            this.labelControl24.Text = "INFONAVIT:";
            // 
            // txtImss
            // 
            this.txtImss.Location = new System.Drawing.Point(104, 194);
            this.txtImss.Name = "txtImss";
            this.txtImss.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImss.Properties.Appearance.Options.UseFont = true;
            this.txtImss.Size = new System.Drawing.Size(260, 24);
            this.txtImss.TabIndex = 6;
            // 
            // labelControl34
            // 
            this.labelControl34.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl34.Location = new System.Drawing.Point(27, 197);
            this.labelControl34.Name = "labelControl34";
            this.labelControl34.Size = new System.Drawing.Size(30, 18);
            this.labelControl34.TabIndex = 79;
            this.labelControl34.Text = "IMSS";
            // 
            // txtCurp
            // 
            this.txtCurp.Location = new System.Drawing.Point(104, 162);
            this.txtCurp.Name = "txtCurp";
            this.txtCurp.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurp.Properties.Appearance.Options.UseFont = true;
            this.txtCurp.Size = new System.Drawing.Size(260, 24);
            this.txtCurp.TabIndex = 5;
            // 
            // labelControl31
            // 
            this.labelControl31.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl31.Location = new System.Drawing.Point(14, 165);
            this.labelControl31.Name = "labelControl31";
            this.labelControl31.Size = new System.Drawing.Size(7, 18);
            this.labelControl31.TabIndex = 77;
            this.labelControl31.Text = "*";
            // 
            // labelControl33
            // 
            this.labelControl33.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl33.Location = new System.Drawing.Point(27, 165);
            this.labelControl33.Name = "labelControl33";
            this.labelControl33.Size = new System.Drawing.Size(37, 18);
            this.labelControl33.TabIndex = 76;
            this.labelControl33.Text = "CURP:";
            // 
            // txtRFC
            // 
            this.txtRFC.Location = new System.Drawing.Point(104, 132);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRFC.Properties.Appearance.Options.UseFont = true;
            this.txtRFC.Size = new System.Drawing.Size(260, 24);
            this.txtRFC.TabIndex = 4;
            // 
            // labelControl21
            // 
            this.labelControl21.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl21.Location = new System.Drawing.Point(14, 135);
            this.labelControl21.Name = "labelControl21";
            this.labelControl21.Size = new System.Drawing.Size(7, 18);
            this.labelControl21.TabIndex = 70;
            this.labelControl21.Text = "*";
            // 
            // chkF
            // 
            this.chkF.Location = new System.Drawing.Point(145, 107);
            this.chkF.Name = "chkF";
            this.chkF.Properties.Caption = "F";
            this.chkF.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.chkF.Properties.RadioGroupIndex = 1;
            this.chkF.Size = new System.Drawing.Size(34, 19);
            this.chkF.TabIndex = 3;
            this.chkF.TabStop = false;
            // 
            // chkM
            // 
            this.chkM.Location = new System.Drawing.Point(104, 107);
            this.chkM.Name = "chkM";
            this.chkM.Properties.Caption = "M";
            this.chkM.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.chkM.Properties.RadioGroupIndex = 1;
            this.chkM.Size = new System.Drawing.Size(35, 19);
            this.chkM.TabIndex = 2;
            this.chkM.TabStop = false;
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl16.Location = new System.Drawing.Point(27, 107);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(50, 18);
            this.labelControl16.TabIndex = 63;
            this.labelControl16.Text = "Genero:";
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl15.Location = new System.Drawing.Point(25, 257);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(113, 18);
            this.labelControl15.TabIndex = 60;
            this.labelControl15.Text = "Fecha nacimiento:";
            // 
            // dateNacimiento
            // 
            this.dateNacimiento.EditValue = null;
            this.dateNacimiento.Location = new System.Drawing.Point(145, 254);
            this.dateNacimiento.Name = "dateNacimiento";
            this.dateNacimiento.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.dateNacimiento.Properties.Appearance.Options.UseFont = true;
            this.dateNacimiento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNacimiento.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNacimiento.Size = new System.Drawing.Size(217, 24);
            this.dateNacimiento.TabIndex = 8;
            // 
            // btnDelete
            // 
            this.btnDelete.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnDelete.Image = global::TechHidraulics_ERP_CRM.Properties.Resources.cancel_24px;
            this.btnDelete.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnDelete.Location = new System.Drawing.Point(1025, 243);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(36, 23);
            this.btnDelete.TabIndex = 80;
            this.btnDelete.ToolTip = "Borrar imagen";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtReferencia
            // 
            this.txtReferencia.Location = new System.Drawing.Point(120, 194);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReferencia.Properties.Appearance.Options.UseFont = true;
            this.txtReferencia.Properties.Mask.EditMask = "(\\d?\\d?\\d?) \\d\\d\\d-\\d\\d\\d\\d";
            this.txtReferencia.Size = new System.Drawing.Size(282, 24);
            this.txtReferencia.TabIndex = 14;
            // 
            // labelControl28
            // 
            this.labelControl28.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl28.Location = new System.Drawing.Point(27, 197);
            this.labelControl28.Name = "labelControl28";
            this.labelControl28.Size = new System.Drawing.Size(71, 18);
            this.labelControl28.TabIndex = 79;
            this.labelControl28.Text = "Referencia:";
            // 
            // labelControl29
            // 
            this.labelControl29.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl29.Location = new System.Drawing.Point(27, 137);
            this.labelControl29.Name = "labelControl29";
            this.labelControl29.Size = new System.Drawing.Size(47, 18);
            this.labelControl29.TabIndex = 75;
            this.labelControl29.Text = "Ciudad:";
            // 
            // btnCargarFoto
            // 
            this.btnCargarFoto.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnCargarFoto.Location = new System.Drawing.Point(880, 243);
            this.btnCargarFoto.Name = "btnCargarFoto";
            this.btnCargarFoto.Size = new System.Drawing.Size(139, 23);
            this.btnCargarFoto.TabIndex = 27;
            this.btnCargarFoto.Text = "Cargar foto";
            this.btnCargarFoto.Click += new System.EventHandler(this.btnCargarFoto_Click);
            // 
            // picPhoto
            // 
            this.picPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picPhoto.Location = new System.Drawing.Point(880, 30);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.picPhoto.Properties.Appearance.Options.UseBackColor = true;
            this.picPhoto.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.Image;
            this.picPhoto.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picPhoto.Size = new System.Drawing.Size(181, 200);
            this.picPhoto.TabIndex = 49;
            // 
            // labelControl26
            // 
            this.labelControl26.Appearance.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl26.Location = new System.Drawing.Point(45, 603);
            this.labelControl26.Name = "labelControl26";
            this.labelControl26.Size = new System.Drawing.Size(249, 18);
            this.labelControl26.TabIndex = 57;
            this.labelControl26.Text = "* Indica que los campos son obligatorios:";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.txtTelefono);
            this.groupControl3.Controls.Add(this.lbl1);
            this.groupControl3.Controls.Add(this.txtCP);
            this.groupControl3.Controls.Add(this.labelControl20);
            this.groupControl3.Controls.Add(this.txtColonia);
            this.groupControl3.Controls.Add(this.labelControl32);
            this.groupControl3.Controls.Add(this.txtCalle);
            this.groupControl3.Controls.Add(this.txtReferencia);
            this.groupControl3.Controls.Add(this.labelControl29);
            this.groupControl3.Controls.Add(this.labelControl28);
            this.groupControl3.Controls.Add(this.labelControl3);
            this.groupControl3.Controls.Add(this.txtCiudad);
            this.groupControl3.Location = new System.Drawing.Point(441, 30);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(414, 229);
            this.groupControl3.TabIndex = 58;
            this.groupControl3.Text = "Informacion contacto";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(120, 41);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Properties.Appearance.Options.UseFont = true;
            this.txtTelefono.Properties.Mask.EditMask = "(\\d?\\d?\\d?) \\d\\d\\d-\\d\\d\\d\\d";
            this.txtTelefono.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.txtTelefono.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtTelefono.Size = new System.Drawing.Size(168, 24);
            this.txtTelefono.TabIndex = 9;
            // 
            // lbl1
            // 
            this.lbl1.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(27, 44);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(60, 18);
            this.lbl1.TabIndex = 85;
            this.lbl1.Text = "Telefono:";
            // 
            // txtCP
            // 
            this.txtCP.EditValue = "0";
            this.txtCP.Location = new System.Drawing.Point(120, 164);
            this.txtCP.Name = "txtCP";
            this.txtCP.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCP.Properties.Appearance.Options.UseFont = true;
            this.txtCP.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCP.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtCP.Properties.Mask.EditMask = "d";
            this.txtCP.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCP.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtCP.Size = new System.Drawing.Size(92, 24);
            this.txtCP.TabIndex = 13;
            // 
            // labelControl20
            // 
            this.labelControl20.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl20.Location = new System.Drawing.Point(27, 167);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(88, 18);
            this.labelControl20.TabIndex = 83;
            this.labelControl20.Text = "Coidgo Postal:";
            // 
            // txtColonia
            // 
            this.txtColonia.Location = new System.Drawing.Point(120, 104);
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColonia.Properties.Appearance.Options.UseFont = true;
            this.txtColonia.Size = new System.Drawing.Size(282, 24);
            this.txtColonia.TabIndex = 11;
            // 
            // labelControl32
            // 
            this.labelControl32.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl32.Location = new System.Drawing.Point(27, 107);
            this.labelControl32.Name = "labelControl32";
            this.labelControl32.Size = new System.Drawing.Size(51, 18);
            this.labelControl32.TabIndex = 81;
            this.labelControl32.Text = "Colonia:";
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.txtTipoSangre);
            this.groupControl4.Controls.Add(this.labelControl36);
            this.groupControl4.Controls.Add(this.txtPeso);
            this.groupControl4.Controls.Add(this.labelControl37);
            this.groupControl4.Controls.Add(this.txtEstatura);
            this.groupControl4.Controls.Add(this.labelControl41);
            this.groupControl4.Location = new System.Drawing.Point(441, 265);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(414, 88);
            this.groupControl4.TabIndex = 81;
            this.groupControl4.Text = "Otros";
            // 
            // txtTipoSangre
            // 
            this.txtTipoSangre.Location = new System.Drawing.Point(20, 51);
            this.txtTipoSangre.Name = "txtTipoSangre";
            this.txtTipoSangre.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoSangre.Properties.Appearance.Options.UseFont = true;
            this.txtTipoSangre.Properties.Mask.EditMask = "(\\d?\\d?\\d?) \\d\\d\\d-\\d\\d\\d\\d";
            this.txtTipoSangre.Size = new System.Drawing.Size(78, 24);
            this.txtTipoSangre.TabIndex = 15;
            // 
            // labelControl36
            // 
            this.labelControl36.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl36.Location = new System.Drawing.Point(22, 27);
            this.labelControl36.Name = "labelControl36";
            this.labelControl36.Size = new System.Drawing.Size(76, 18);
            this.labelControl36.TabIndex = 74;
            this.labelControl36.Text = "Tipo Sangre:";
            // 
            // txtPeso
            // 
            this.txtPeso.EditValue = "0";
            this.txtPeso.Location = new System.Drawing.Point(120, 51);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.Properties.Appearance.Options.UseFont = true;
            this.txtPeso.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPeso.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtPeso.Properties.Mask.EditMask = "d";
            this.txtPeso.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPeso.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtPeso.Size = new System.Drawing.Size(83, 24);
            this.txtPeso.TabIndex = 16;
            // 
            // labelControl37
            // 
            this.labelControl37.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl37.Location = new System.Drawing.Point(120, 27);
            this.labelControl37.Name = "labelControl37";
            this.labelControl37.Size = new System.Drawing.Size(72, 18);
            this.labelControl37.TabIndex = 72;
            this.labelControl37.Text = "Peso aprox:";
            // 
            // txtEstatura
            // 
            this.txtEstatura.EditValue = "0";
            this.txtEstatura.Location = new System.Drawing.Point(222, 51);
            this.txtEstatura.Name = "txtEstatura";
            this.txtEstatura.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstatura.Properties.Appearance.Options.UseFont = true;
            this.txtEstatura.Properties.Appearance.Options.UseTextOptions = true;
            this.txtEstatura.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtEstatura.Properties.Mask.EditMask = "d";
            this.txtEstatura.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtEstatura.Size = new System.Drawing.Size(92, 24);
            this.txtEstatura.TabIndex = 17;
            // 
            // labelControl41
            // 
            this.labelControl41.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl41.Location = new System.Drawing.Point(222, 27);
            this.labelControl41.Name = "labelControl41";
            this.labelControl41.Size = new System.Drawing.Size(92, 18);
            this.labelControl41.TabIndex = 68;
            this.labelControl41.Text = "Estatura aprox:";
            // 
            // FrmRegEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 642);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.labelControl26);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.picPhoto);
            this.Controls.Add(this.btnCargarFoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmRegEmpleado";
            this.Text = "Empleado";
            this.Load += new System.EventHandler(this.FrmREG_Empleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApellidos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCiudad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCalle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFicha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkAdministrador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDepartamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTerminacion.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTerminacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateContratacion.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateContratacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContrasenaConfirm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxPuesto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContrasena.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInfonavit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImss.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRFC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkF.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNacimiento.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNacimiento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReferencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtColonia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoSangre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstatura.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SimpleButton btnDelete;
        private GroupControl groupControl3;
        private TextEdit txtColonia;
        private LabelControl labelControl32;
        private TextEdit txtCP;
        private LabelControl labelControl20;
        private TextEdit txtCurp;
        private LabelControl labelControl31;
        private LabelControl labelControl33;
        private GroupControl groupControl4;
        private TextEdit txtTipoSangre;
        private LabelControl labelControl36;
        private TextEdit txtPeso;
        private LabelControl labelControl37;
        private TextEdit txtEstatura;
        private LabelControl labelControl41;
        private TextEdit txtInfonavit;
        private LabelControl labelControl24;
        private TextEdit txtImss;
        private LabelControl labelControl34;
        private TextEdit txtTelefono;
        private LabelControl lbl1;
    }
}