using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraLayout.Converter;

namespace TechHidraulics_ERP_CRM.Proveedores
{
    partial class FrmRegProveedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private LabelControl labelControl1;

        private SimpleButton btnCancelar;

        private SimpleButton btnAceptar;

        private TextEdit txtAtencion;

        private LabelControl labelControl3;

        private LabelControl labelControl2;

        private TextEdit txtNombre;

        private GroupControl groupControl2;

        private TextEdit txtNombre_Contacto;

        private LabelControl labelControl15;

        private TextEdit txtDireccion_Contacto;

        private LabelControl labelControl14;

        private LabelControl labelControl13;

        private TextEdit txtTelefono_Contacto;

        private TextEdit txtTelefono;

        private GroupControl groupControl3;

        private TextEdit txtNombre_Contacto2;

        private LabelControl labelControl7;

        private TextEdit txtDireccion_Contacto2;

        private LabelControl labelControl9;

        private LabelControl labelControl10;

        private TextEdit txtTelefono_Contacto2;

        private LabelControl labelControl16;

        private TextEdit txtCodigo;

        private LabelControl labelControl17;

        private ComboBoxEdit cbxSector;

        private LabelControl labelControl5;

        private TextEdit txtDescripcion;

        private LabelControl labelControl19;

        private LayoutConverter layoutConverter1;

        private TextEdit txtPagina;

        private TextEdit txtCorreo;
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAceptar = new DevExpress.XtraEditors.SimpleButton();
            this.txtPagina = new DevExpress.XtraEditors.TextEdit();
            this.txtCorreo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.cbxSector = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.txtTelefono = new DevExpress.XtraEditors.TextEdit();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.txtContactoMail2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtNombre_Contacto2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtDireccion_Contacto2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtTelefono_Contacto2 = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtContactoMail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtNombre_Contacto = new DevExpress.XtraEditors.TextEdit();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.txtDireccion_Contacto = new DevExpress.XtraEditors.TextEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.txtTelefono_Contacto = new DevExpress.XtraEditors.TextEdit();
            this.txtAtencion = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.lbl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCP = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txtColonia = new DevExpress.XtraEditors.TextEdit();
            this.labelControl32 = new DevExpress.XtraEditors.LabelControl();
            this.txtCalle = new DevExpress.XtraEditors.TextEdit();
            this.labelControl29 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl22 = new DevExpress.XtraEditors.LabelControl();
            this.txtCiudad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl23 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl24 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtPagina.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCorreo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxSector.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtContactoMail2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre_Contacto2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion_Contacto2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono_Contacto2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtContactoMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre_Contacto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion_Contacto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono_Contacto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAtencion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtColonia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCalle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCiudad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(26, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(140, 45);
            this.labelControl1.TabIndex = 44;
            this.labelControl1.Text = "Proveedor";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Appearance.Options.UseFont = true;
            this.btnCancelar.Appearance.Options.UseTextOptions = true;
            this.btnCancelar.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(817, 563);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 30);
            this.btnCancelar.TabIndex = 42;
            this.btnCancelar.Text = "Cancelar";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Appearance.Options.UseFont = true;
            this.btnAceptar.Appearance.Options.UseTextOptions = true;
            this.btnAceptar.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnAceptar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnAceptar.Location = new System.Drawing.Point(924, 563);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(101, 30);
            this.btnAceptar.TabIndex = 41;
            this.btnAceptar.Text = "Guardar";
            this.btnAceptar.ToolTip = "Le permite al usuario añadir un nuevo articulo al Inventario.";
            this.btnAceptar.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btnAceptar.ToolTipTitle = "Agregar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtPagina
            // 
            this.txtPagina.Location = new System.Drawing.Point(118, 224);
            this.txtPagina.Name = "txtPagina";
            this.txtPagina.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagina.Properties.Appearance.Options.UseFont = true;
            this.txtPagina.Size = new System.Drawing.Size(151, 24);
            this.txtPagina.TabIndex = 106;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(118, 194);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Properties.Appearance.Options.UseFont = true;
            this.txtCorreo.Size = new System.Drawing.Size(144, 24);
            this.txtCorreo.TabIndex = 104;
            // 
            // labelControl19
            // 
            this.labelControl19.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl19.Location = new System.Drawing.Point(23, 65);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(7, 18);
            this.labelControl19.TabIndex = 103;
            this.labelControl19.Text = "*";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(37, 96);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(76, 18);
            this.labelControl5.TabIndex = 100;
            this.labelControl5.Text = "Descripcion:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(226, 93);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Properties.Appearance.Options.UseFont = true;
            this.txtDescripcion.Size = new System.Drawing.Size(303, 24);
            this.txtDescripcion.TabIndex = 99;
            // 
            // labelControl17
            // 
            this.labelControl17.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl17.Location = new System.Drawing.Point(37, 156);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(43, 18);
            this.labelControl17.TabIndex = 98;
            this.labelControl17.Text = "Sector:";
            // 
            // cbxSector
            // 
            this.cbxSector.Location = new System.Drawing.Point(226, 153);
            this.cbxSector.Name = "cbxSector";
            this.cbxSector.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.cbxSector.Properties.Appearance.Options.UseFont = true;
            this.cbxSector.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxSector.Size = new System.Drawing.Size(191, 24);
            this.cbxSector.TabIndex = 97;
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl16.Location = new System.Drawing.Point(37, 35);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(47, 18);
            this.labelControl16.TabIndex = 95;
            this.labelControl16.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(226, 32);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Properties.Appearance.Options.UseFont = true;
            this.txtCodigo.Size = new System.Drawing.Size(123, 24);
            this.txtCodigo.TabIndex = 94;
            // 
            // txtTelefono
            // 
            this.txtTelefono.EditValue = "(__) ___-____";
            this.txtTelefono.Location = new System.Drawing.Point(118, 41);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Properties.Appearance.Options.UseFont = true;
            this.txtTelefono.Properties.Mask.EditMask = "(\\d?\\d?\\d?) \\d\\d\\d-\\d\\d\\d\\d";
            this.txtTelefono.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.txtTelefono.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtTelefono.Size = new System.Drawing.Size(129, 24);
            this.txtTelefono.TabIndex = 92;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.txtContactoMail2);
            this.groupControl3.Controls.Add(this.labelControl8);
            this.groupControl3.Controls.Add(this.txtNombre_Contacto2);
            this.groupControl3.Controls.Add(this.labelControl7);
            this.groupControl3.Controls.Add(this.txtDireccion_Contacto2);
            this.groupControl3.Controls.Add(this.labelControl9);
            this.groupControl3.Controls.Add(this.labelControl10);
            this.groupControl3.Controls.Add(this.txtTelefono_Contacto2);
            this.groupControl3.Location = new System.Drawing.Point(413, 365);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(346, 164);
            this.groupControl3.TabIndex = 91;
            this.groupControl3.Text = "Contacto";
            // 
            // txtContactoMail2
            // 
            this.txtContactoMail2.Location = new System.Drawing.Point(96, 122);
            this.txtContactoMail2.Name = "txtContactoMail2";
            this.txtContactoMail2.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactoMail2.Properties.Appearance.Options.UseFont = true;
            this.txtContactoMail2.Size = new System.Drawing.Size(162, 24);
            this.txtContactoMail2.TabIndex = 108;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Location = new System.Drawing.Point(15, 125);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(43, 18);
            this.labelControl8.TabIndex = 107;
            this.labelControl8.Text = "E-Mail:";
            // 
            // txtNombre_Contacto2
            // 
            this.txtNombre_Contacto2.Location = new System.Drawing.Point(96, 32);
            this.txtNombre_Contacto2.Name = "txtNombre_Contacto2";
            this.txtNombre_Contacto2.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre_Contacto2.Properties.Appearance.Options.UseFont = true;
            this.txtNombre_Contacto2.Size = new System.Drawing.Size(231, 24);
            this.txtNombre_Contacto2.TabIndex = 81;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(15, 35);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(55, 18);
            this.labelControl7.TabIndex = 83;
            this.labelControl7.Text = "Nombre:";
            // 
            // txtDireccion_Contacto2
            // 
            this.txtDireccion_Contacto2.Location = new System.Drawing.Point(96, 62);
            this.txtDireccion_Contacto2.Name = "txtDireccion_Contacto2";
            this.txtDireccion_Contacto2.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion_Contacto2.Properties.Appearance.Options.UseFont = true;
            this.txtDireccion_Contacto2.Size = new System.Drawing.Size(231, 24);
            this.txtDireccion_Contacto2.TabIndex = 82;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Location = new System.Drawing.Point(15, 65);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(62, 18);
            this.labelControl9.TabIndex = 84;
            this.labelControl9.Text = "Direccion:";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Location = new System.Drawing.Point(15, 95);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(60, 18);
            this.labelControl10.TabIndex = 86;
            this.labelControl10.Text = "Telefono:";
            // 
            // txtTelefono_Contacto2
            // 
            this.txtTelefono_Contacto2.EditValue = "(__) ___-____";
            this.txtTelefono_Contacto2.Location = new System.Drawing.Point(96, 92);
            this.txtTelefono_Contacto2.Name = "txtTelefono_Contacto2";
            this.txtTelefono_Contacto2.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono_Contacto2.Properties.Appearance.Options.UseFont = true;
            this.txtTelefono_Contacto2.Properties.Mask.EditMask = "(\\d?\\d?\\d?) \\d\\d\\d-\\d\\d\\d\\d";
            this.txtTelefono_Contacto2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.txtTelefono_Contacto2.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtTelefono_Contacto2.Size = new System.Drawing.Size(129, 24);
            this.txtTelefono_Contacto2.TabIndex = 85;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.txtContactoMail);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.txtNombre_Contacto);
            this.groupControl2.Controls.Add(this.labelControl15);
            this.groupControl2.Controls.Add(this.txtDireccion_Contacto);
            this.groupControl2.Controls.Add(this.labelControl14);
            this.groupControl2.Controls.Add(this.labelControl13);
            this.groupControl2.Controls.Add(this.txtTelefono_Contacto);
            this.groupControl2.Location = new System.Drawing.Point(35, 365);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(358, 164);
            this.groupControl2.TabIndex = 90;
            this.groupControl2.Text = "Contacto";
            // 
            // txtContactoMail
            // 
            this.txtContactoMail.Location = new System.Drawing.Point(97, 122);
            this.txtContactoMail.Name = "txtContactoMail";
            this.txtContactoMail.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactoMail.Properties.Appearance.Options.UseFont = true;
            this.txtContactoMail.Size = new System.Drawing.Size(162, 24);
            this.txtContactoMail.TabIndex = 106;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(16, 125);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(43, 18);
            this.labelControl4.TabIndex = 105;
            this.labelControl4.Text = "E-Mail:";
            // 
            // txtNombre_Contacto
            // 
            this.txtNombre_Contacto.Location = new System.Drawing.Point(97, 32);
            this.txtNombre_Contacto.Name = "txtNombre_Contacto";
            this.txtNombre_Contacto.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre_Contacto.Properties.Appearance.Options.UseFont = true;
            this.txtNombre_Contacto.Size = new System.Drawing.Size(236, 24);
            this.txtNombre_Contacto.TabIndex = 81;
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl15.Location = new System.Drawing.Point(16, 35);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(55, 18);
            this.labelControl15.TabIndex = 83;
            this.labelControl15.Text = "Nombre:";
            // 
            // txtDireccion_Contacto
            // 
            this.txtDireccion_Contacto.Location = new System.Drawing.Point(97, 62);
            this.txtDireccion_Contacto.Name = "txtDireccion_Contacto";
            this.txtDireccion_Contacto.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion_Contacto.Properties.Appearance.Options.UseFont = true;
            this.txtDireccion_Contacto.Size = new System.Drawing.Size(236, 24);
            this.txtDireccion_Contacto.TabIndex = 82;
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl14.Location = new System.Drawing.Point(16, 65);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(62, 18);
            this.labelControl14.TabIndex = 84;
            this.labelControl14.Text = "Direccion:";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Location = new System.Drawing.Point(16, 95);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(60, 18);
            this.labelControl13.TabIndex = 86;
            this.labelControl13.Text = "Telefono:";
            // 
            // txtTelefono_Contacto
            // 
            this.txtTelefono_Contacto.EditValue = "(__) ___-____";
            this.txtTelefono_Contacto.Location = new System.Drawing.Point(97, 92);
            this.txtTelefono_Contacto.Name = "txtTelefono_Contacto";
            this.txtTelefono_Contacto.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono_Contacto.Properties.Appearance.Options.UseFont = true;
            this.txtTelefono_Contacto.Properties.Mask.EditMask = "(\\d?\\d?\\d?) \\d\\d\\d-\\d\\d\\d\\d";
            this.txtTelefono_Contacto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.txtTelefono_Contacto.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtTelefono_Contacto.Size = new System.Drawing.Size(129, 24);
            this.txtTelefono_Contacto.TabIndex = 85;
            // 
            // txtAtencion
            // 
            this.txtAtencion.Location = new System.Drawing.Point(226, 123);
            this.txtAtencion.Name = "txtAtencion";
            this.txtAtencion.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAtencion.Properties.Appearance.Options.UseFont = true;
            this.txtAtencion.Size = new System.Drawing.Size(245, 24);
            this.txtAtencion.TabIndex = 54;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(37, 126);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(63, 18);
            this.labelControl3.TabIndex = 53;
            this.labelControl3.Text = "Atencion :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(37, 65);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(146, 18);
            this.labelControl2.TabIndex = 50;
            this.labelControl2.Text = "Nombre del proveedor:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(226, 62);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Properties.Appearance.Options.UseFont = true;
            this.txtNombre.Size = new System.Drawing.Size(304, 24);
            this.txtNombre.TabIndex = 47;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Location = new System.Drawing.Point(24, 35);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(7, 18);
            this.labelControl11.TabIndex = 109;
            this.labelControl11.Text = "*";
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.lbl1);
            this.groupControl4.Controls.Add(this.txtCP);
            this.groupControl4.Controls.Add(this.labelControl12);
            this.groupControl4.Controls.Add(this.txtPagina);
            this.groupControl4.Controls.Add(this.txtColonia);
            this.groupControl4.Controls.Add(this.labelControl32);
            this.groupControl4.Controls.Add(this.txtCorreo);
            this.groupControl4.Controls.Add(this.txtCalle);
            this.groupControl4.Controls.Add(this.labelControl29);
            this.groupControl4.Controls.Add(this.labelControl22);
            this.groupControl4.Controls.Add(this.txtCiudad);
            this.groupControl4.Controls.Add(this.labelControl23);
            this.groupControl4.Controls.Add(this.labelControl24);
            this.groupControl4.Controls.Add(this.txtTelefono);
            this.groupControl4.Location = new System.Drawing.Point(611, 84);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(414, 265);
            this.groupControl4.TabIndex = 60;
            this.groupControl4.Text = "Informacion contacto";
            // 
            // lbl1
            // 
            this.lbl1.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(25, 44);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(60, 18);
            this.lbl1.TabIndex = 85;
            this.lbl1.Text = "Telefono:";
            // 
            // txtCP
            // 
            this.txtCP.EditValue = "0";
            this.txtCP.Location = new System.Drawing.Point(118, 164);
            this.txtCP.Name = "txtCP";
            this.txtCP.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCP.Properties.Appearance.Options.UseFont = true;
            this.txtCP.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCP.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtCP.Properties.Mask.EditMask = "d";
            this.txtCP.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCP.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtCP.Size = new System.Drawing.Size(92, 24);
            this.txtCP.TabIndex = 11;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Location = new System.Drawing.Point(25, 167);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(88, 18);
            this.labelControl12.TabIndex = 83;
            this.labelControl12.Text = "Coidgo Postal:";
            // 
            // txtColonia
            // 
            this.txtColonia.Location = new System.Drawing.Point(118, 104);
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColonia.Properties.Appearance.Options.UseFont = true;
            this.txtColonia.Size = new System.Drawing.Size(282, 24);
            this.txtColonia.TabIndex = 9;
            // 
            // labelControl32
            // 
            this.labelControl32.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl32.Location = new System.Drawing.Point(25, 107);
            this.labelControl32.Name = "labelControl32";
            this.labelControl32.Size = new System.Drawing.Size(51, 18);
            this.labelControl32.TabIndex = 81;
            this.labelControl32.Text = "Colonia:";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(118, 74);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalle.Properties.Appearance.Options.UseFont = true;
            this.txtCalle.Size = new System.Drawing.Size(282, 24);
            this.txtCalle.TabIndex = 8;
            // 
            // labelControl29
            // 
            this.labelControl29.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl29.Location = new System.Drawing.Point(25, 137);
            this.labelControl29.Name = "labelControl29";
            this.labelControl29.Size = new System.Drawing.Size(47, 18);
            this.labelControl29.TabIndex = 75;
            this.labelControl29.Text = "Ciudad:";
            // 
            // labelControl22
            // 
            this.labelControl22.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl22.Location = new System.Drawing.Point(25, 77);
            this.labelControl22.Name = "labelControl22";
            this.labelControl22.Size = new System.Drawing.Size(35, 18);
            this.labelControl22.TabIndex = 39;
            this.labelControl22.Text = "Calle:";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(118, 134);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCiudad.Properties.Appearance.Options.UseFont = true;
            this.txtCiudad.Properties.Mask.EditMask = "(\\d?\\d?\\d?) \\d\\d\\d-\\d\\d\\d\\d";
            this.txtCiudad.Size = new System.Drawing.Size(282, 24);
            this.txtCiudad.TabIndex = 10;
            // 
            // labelControl23
            // 
            this.labelControl23.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl23.Location = new System.Drawing.Point(25, 197);
            this.labelControl23.Name = "labelControl23";
            this.labelControl23.Size = new System.Drawing.Size(43, 18);
            this.labelControl23.TabIndex = 58;
            this.labelControl23.Text = "E-Mail:";
            // 
            // labelControl24
            // 
            this.labelControl24.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl24.Location = new System.Drawing.Point(25, 227);
            this.labelControl24.Name = "labelControl24";
            this.labelControl24.Size = new System.Drawing.Size(75, 18);
            this.labelControl24.TabIndex = 66;
            this.labelControl24.Text = "Pagina web:";
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.labelControl11);
            this.groupControl5.Controls.Add(this.labelControl16);
            this.groupControl5.Controls.Add(this.labelControl17);
            this.groupControl5.Controls.Add(this.labelControl5);
            this.groupControl5.Controls.Add(this.cbxSector);
            this.groupControl5.Controls.Add(this.txtNombre);
            this.groupControl5.Controls.Add(this.txtDescripcion);
            this.groupControl5.Controls.Add(this.labelControl2);
            this.groupControl5.Controls.Add(this.txtCodigo);
            this.groupControl5.Controls.Add(this.txtAtencion);
            this.groupControl5.Controls.Add(this.labelControl3);
            this.groupControl5.Controls.Add(this.labelControl19);
            this.groupControl5.Location = new System.Drawing.Point(35, 84);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(558, 265);
            this.groupControl5.TabIndex = 61;
            this.groupControl5.Text = "Informacion general";
            // 
            // FrmRegProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 618);
            this.Controls.Add(this.groupControl5);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.btnAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmRegProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedor";
            ((System.ComponentModel.ISupportInitialize)(this.txtPagina.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCorreo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxSector.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtContactoMail2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre_Contacto2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion_Contacto2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono_Contacto2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtContactoMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre_Contacto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion_Contacto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono_Contacto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAtencion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtColonia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCalle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCiudad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            this.groupControl5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LabelControl labelControl11;
        private GroupControl groupControl4;
        private LabelControl lbl1;
        private TextEdit txtCP;
        private LabelControl labelControl12;
        private TextEdit txtColonia;
        private LabelControl labelControl32;
        private TextEdit txtCalle;
        private LabelControl labelControl29;
        private LabelControl labelControl22;
        private TextEdit txtCiudad;
        private LabelControl labelControl23;
        private LabelControl labelControl24;
        private GroupControl groupControl5;
        private TextEdit txtContactoMail;
        private LabelControl labelControl4;
        private TextEdit txtContactoMail2;
        private LabelControl labelControl8;
    }
}