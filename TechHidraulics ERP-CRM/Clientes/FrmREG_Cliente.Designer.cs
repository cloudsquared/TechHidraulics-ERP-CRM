using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;

namespace TechHidraulics_ERP_CRM.Clientes
{
    partial class FrmRegCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private LabelControl labelControl1;

        private SimpleButton btnCancelar;

        private SimpleButton btnAceptar;

        private GroupControl groupControl1;

        private LabelControl labelControl4;

        private TextEdit txtRazonSocial;

        private LabelControl labelControl2;

        private TextEdit txtNombre;

        private LabelControl labelControl16;

        private TextEdit txtDescuento;

        private LabelControl labelControl12;

        private LabelControl labelControl13;

        private TextEdit txtTelefono_Contacto;

        private LabelControl labelControl14;

        private TextEdit txtDireccion_Contacto;

        private LabelControl labelControl15;

        private TextEdit txtNombre_Contacto;

        private LabelControl labelControl6;

        private TextEdit txtCredito;

        private LabelControl labelControl11;

        private TextEdit txtPagina;

        private LabelControl labelControl10;

        private ComboBoxEdit cbxSector;

        private LabelControl labelControl9;

        private TextEdit txtDescripcion;

        private LabelControl labelControl8;

        private TextEdit txtCodigo;

        private LabelControl labelControl7;

        private TextEdit txtCorreo;

        private TextEdit txtTelefono;

        private CheckEdit chkEstatus;

        private TextEdit txtMovil_Contacto;

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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescuento = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtCredito = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.cbxSector = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtRazonSocial = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.txtMovil_Contacto = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.txtTelefono_Contacto = new DevExpress.XtraEditors.TextEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.txtDireccion_Contacto = new DevExpress.XtraEditors.TextEdit();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.txtNombre_Contacto = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtPagina = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtCorreo = new DevExpress.XtraEditors.TextEdit();
            this.txtTelefono = new DevExpress.XtraEditors.TextEdit();
            this.chkEstatus = new DevExpress.XtraEditors.CheckEdit();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.lbl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCP = new DevExpress.XtraEditors.TextEdit();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.txtColonia = new DevExpress.XtraEditors.TextEdit();
            this.labelControl32 = new DevExpress.XtraEditors.LabelControl();
            this.txtCalle = new DevExpress.XtraEditors.TextEdit();
            this.labelControl29 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.txtCiudad = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtContacto_Mail = new DevExpress.XtraEditors.TextEdit();
            this.chkSsyasa = new DevExpress.XtraEditors.CheckEdit();
            this.chkLubano = new DevExpress.XtraEditors.CheckEdit();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.chkDiego = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescuento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCredito.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxSector.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRazonSocial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMovil_Contacto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono_Contacto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion_Contacto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre_Contacto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPagina.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCorreo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEstatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtColonia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCalle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCiudad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtContacto_Mail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSsyasa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkLubano.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkDiego.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(31, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(93, 45);
            this.labelControl1.TabIndex = 40;
            this.labelControl1.Text = "Cliente";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Appearance.Options.UseFont = true;
            this.btnCancelar.Appearance.Options.UseTextOptions = true;
            this.btnCancelar.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnCancelar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(837, 591);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 30);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.ToolTip = "Le permite al usuario añadir un nuevo articulo al Inventario.";
            this.btnCancelar.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btnCancelar.ToolTipTitle = "Agregar";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Appearance.Options.UseFont = true;
            this.btnAceptar.Appearance.Options.UseTextOptions = true;
            this.btnAceptar.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnAceptar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnAceptar.Location = new System.Drawing.Point(944, 591);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(101, 30);
            this.btnAceptar.TabIndex = 19;
            this.btnAceptar.Text = "Guardar";
            this.btnAceptar.ToolTip = "Le permite al usuario añadir un nuevo articulo al Inventario.";
            this.btnAceptar.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btnAceptar.ToolTipTitle = "Agregar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl17);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl16);
            this.groupControl1.Controls.Add(this.txtDescuento);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.txtCredito);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.cbxSector);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.txtDescripcion);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.txtCodigo);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtRazonSocial);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtNombre);
            this.groupControl1.Location = new System.Drawing.Point(32, 84);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(581, 265);
            this.groupControl1.TabIndex = 39;
            this.groupControl1.Text = "Informacion general";
            // 
            // labelControl17
            // 
            this.labelControl17.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl17.Location = new System.Drawing.Point(26, 74);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(7, 18);
            this.labelControl17.TabIndex = 80;
            this.labelControl17.Text = "*";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(24, 44);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(7, 18);
            this.labelControl5.TabIndex = 79;
            this.labelControl5.Text = "*";
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl16.Location = new System.Drawing.Point(352, 194);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(70, 18);
            this.labelControl16.TabIndex = 78;
            this.labelControl16.Text = "Descuento:";
            // 
            // txtDescuento
            // 
            this.txtDescuento.EditValue = "0";
            this.txtDescuento.Location = new System.Drawing.Point(428, 191);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescuento.Properties.Appearance.Options.UseFont = true;
            this.txtDescuento.Properties.Appearance.Options.UseTextOptions = true;
            this.txtDescuento.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtDescuento.Properties.Mask.EditMask = "f";
            this.txtDescuento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDescuento.Properties.MaxLength = 10;
            this.txtDescuento.Size = new System.Drawing.Size(112, 24);
            this.txtDescuento.TabIndex = 6;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(37, 194);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(96, 18);
            this.labelControl6.TabIndex = 68;
            this.labelControl6.Text = "Dias de credito:";
            // 
            // txtCredito
            // 
            this.txtCredito.EditValue = "30";
            this.txtCredito.Location = new System.Drawing.Point(200, 191);
            this.txtCredito.Name = "txtCredito";
            this.txtCredito.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCredito.Properties.Appearance.Options.UseFont = true;
            this.txtCredito.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCredito.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtCredito.Properties.Mask.EditMask = "d";
            this.txtCredito.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCredito.Properties.MaxLength = 10;
            this.txtCredito.Size = new System.Drawing.Size(129, 24);
            this.txtCredito.TabIndex = 5;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Location = new System.Drawing.Point(37, 134);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(43, 18);
            this.labelControl10.TabIndex = 64;
            this.labelControl10.Text = "Sector:";
            // 
            // cbxSector
            // 
            this.cbxSector.Location = new System.Drawing.Point(200, 131);
            this.cbxSector.Name = "cbxSector";
            this.cbxSector.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.cbxSector.Properties.Appearance.Options.UseFont = true;
            this.cbxSector.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxSector.Size = new System.Drawing.Size(191, 24);
            this.cbxSector.TabIndex = 3;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Location = new System.Drawing.Point(37, 164);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(83, 18);
            this.labelControl9.TabIndex = 62;
            this.labelControl9.Text = "Comentarios:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(200, 161);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Properties.Appearance.Options.UseFont = true;
            this.txtDescripcion.Size = new System.Drawing.Size(340, 24);
            this.txtDescripcion.TabIndex = 4;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Location = new System.Drawing.Point(37, 44);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(47, 18);
            this.labelControl8.TabIndex = 60;
            this.labelControl8.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(200, 41);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Properties.Appearance.Options.UseFont = true;
            this.txtCodigo.Properties.MaxLength = 10;
            this.txtCodigo.Size = new System.Drawing.Size(129, 24);
            this.txtCodigo.TabIndex = 0;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(37, 101);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(80, 18);
            this.labelControl4.TabIndex = 51;
            this.labelControl4.Text = "Razon Social:";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(200, 101);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazonSocial.Properties.Appearance.Options.UseFont = true;
            this.txtRazonSocial.Size = new System.Drawing.Size(340, 24);
            this.txtRazonSocial.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(37, 74);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(124, 18);
            this.labelControl2.TabIndex = 50;
            this.labelControl2.Text = "Nombre del cliente:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(200, 71);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Properties.Appearance.Options.UseFont = true;
            this.txtNombre.Size = new System.Drawing.Size(239, 24);
            this.txtNombre.TabIndex = 1;
            // 
            // txtMovil_Contacto
            // 
            this.txtMovil_Contacto.EditValue = "(__) ___-____";
            this.txtMovil_Contacto.Location = new System.Drawing.Point(200, 130);
            this.txtMovil_Contacto.Name = "txtMovil_Contacto";
            this.txtMovil_Contacto.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovil_Contacto.Properties.Appearance.Options.UseFont = true;
            this.txtMovil_Contacto.Properties.Mask.EditMask = "(\\d?\\d?\\d?) \\d\\d\\d-\\d\\d\\d\\d";
            this.txtMovil_Contacto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.txtMovil_Contacto.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtMovil_Contacto.Size = new System.Drawing.Size(129, 24);
            this.txtMovil_Contacto.TabIndex = 17;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Location = new System.Drawing.Point(26, 133);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(98, 18);
            this.labelControl12.TabIndex = 76;
            this.labelControl12.Text = "Telefono movil:";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Location = new System.Drawing.Point(26, 103);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(60, 18);
            this.labelControl13.TabIndex = 74;
            this.labelControl13.Text = "Telefono:";
            // 
            // txtTelefono_Contacto
            // 
            this.txtTelefono_Contacto.EditValue = "(__) ___-____";
            this.txtTelefono_Contacto.Location = new System.Drawing.Point(200, 100);
            this.txtTelefono_Contacto.Name = "txtTelefono_Contacto";
            this.txtTelefono_Contacto.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono_Contacto.Properties.Appearance.Options.UseFont = true;
            this.txtTelefono_Contacto.Properties.Mask.EditMask = "(\\d?\\d?\\d?) \\d\\d\\d-\\d\\d\\d\\d";
            this.txtTelefono_Contacto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.txtTelefono_Contacto.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtTelefono_Contacto.Size = new System.Drawing.Size(129, 24);
            this.txtTelefono_Contacto.TabIndex = 16;
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl14.Location = new System.Drawing.Point(26, 73);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(62, 18);
            this.labelControl14.TabIndex = 72;
            this.labelControl14.Text = "Direccion:";
            // 
            // txtDireccion_Contacto
            // 
            this.txtDireccion_Contacto.Location = new System.Drawing.Point(200, 70);
            this.txtDireccion_Contacto.Name = "txtDireccion_Contacto";
            this.txtDireccion_Contacto.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion_Contacto.Properties.Appearance.Options.UseFont = true;
            this.txtDireccion_Contacto.Size = new System.Drawing.Size(351, 24);
            this.txtDireccion_Contacto.TabIndex = 15;
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl15.Location = new System.Drawing.Point(26, 43);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(55, 18);
            this.labelControl15.TabIndex = 71;
            this.labelControl15.Text = "Nombre:";
            // 
            // txtNombre_Contacto
            // 
            this.txtNombre_Contacto.Location = new System.Drawing.Point(200, 40);
            this.txtNombre_Contacto.Name = "txtNombre_Contacto";
            this.txtNombre_Contacto.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre_Contacto.Properties.Appearance.Options.UseFont = true;
            this.txtNombre_Contacto.Size = new System.Drawing.Size(239, 24);
            this.txtNombre_Contacto.TabIndex = 14;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Location = new System.Drawing.Point(25, 227);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(75, 18);
            this.labelControl11.TabIndex = 66;
            this.labelControl11.Text = "Pagina web:";
            // 
            // txtPagina
            // 
            this.txtPagina.Location = new System.Drawing.Point(118, 224);
            this.txtPagina.Name = "txtPagina";
            this.txtPagina.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagina.Properties.Appearance.Options.UseFont = true;
            this.txtPagina.Size = new System.Drawing.Size(230, 24);
            this.txtPagina.TabIndex = 13;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(25, 197);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(43, 18);
            this.labelControl7.TabIndex = 58;
            this.labelControl7.Text = "E-Mail:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(118, 194);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Properties.Appearance.Options.UseFont = true;
            this.txtCorreo.Size = new System.Drawing.Size(230, 24);
            this.txtCorreo.TabIndex = 12;
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
            this.txtTelefono.TabIndex = 7;
            // 
            // chkEstatus
            // 
            this.chkEstatus.EditValue = true;
            this.chkEstatus.Location = new System.Drawing.Point(935, 45);
            this.chkEstatus.Name = "chkEstatus";
            this.chkEstatus.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.chkEstatus.Properties.Appearance.Options.UseFont = true;
            this.chkEstatus.Properties.Caption = "Cliente activo";
            this.chkEstatus.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.chkEstatus.Size = new System.Drawing.Size(110, 22);
            this.chkEstatus.TabIndex = 100;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.lbl1);
            this.groupControl3.Controls.Add(this.txtCP);
            this.groupControl3.Controls.Add(this.labelControl20);
            this.groupControl3.Controls.Add(this.txtColonia);
            this.groupControl3.Controls.Add(this.labelControl32);
            this.groupControl3.Controls.Add(this.txtCalle);
            this.groupControl3.Controls.Add(this.labelControl29);
            this.groupControl3.Controls.Add(this.labelControl18);
            this.groupControl3.Controls.Add(this.txtCiudad);
            this.groupControl3.Controls.Add(this.txtTelefono);
            this.groupControl3.Controls.Add(this.txtCorreo);
            this.groupControl3.Controls.Add(this.labelControl7);
            this.groupControl3.Controls.Add(this.txtPagina);
            this.groupControl3.Controls.Add(this.labelControl11);
            this.groupControl3.Location = new System.Drawing.Point(631, 84);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(414, 265);
            this.groupControl3.TabIndex = 59;
            this.groupControl3.Text = "Informacion contacto";
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
            // labelControl20
            // 
            this.labelControl20.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl20.Location = new System.Drawing.Point(25, 167);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(88, 18);
            this.labelControl20.TabIndex = 83;
            this.labelControl20.Text = "Coidgo Postal:";
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
            // labelControl18
            // 
            this.labelControl18.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl18.Location = new System.Drawing.Point(25, 77);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(35, 18);
            this.labelControl18.TabIndex = 39;
            this.labelControl18.Text = "Calle:";
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
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.txtContacto_Mail);
            this.groupControl2.Controls.Add(this.txtMovil_Contacto);
            this.groupControl2.Controls.Add(this.labelControl15);
            this.groupControl2.Controls.Add(this.txtDireccion_Contacto);
            this.groupControl2.Controls.Add(this.txtNombre_Contacto);
            this.groupControl2.Controls.Add(this.labelControl14);
            this.groupControl2.Controls.Add(this.txtTelefono_Contacto);
            this.groupControl2.Controls.Add(this.labelControl12);
            this.groupControl2.Controls.Add(this.labelControl13);
            this.groupControl2.Location = new System.Drawing.Point(32, 366);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(581, 202);
            this.groupControl2.TabIndex = 81;
            this.groupControl2.Text = "Contacto";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(26, 163);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(43, 18);
            this.labelControl3.TabIndex = 82;
            this.labelControl3.Text = "E-mail:";
            // 
            // txtContacto_Mail
            // 
            this.txtContacto_Mail.Location = new System.Drawing.Point(200, 160);
            this.txtContacto_Mail.Name = "txtContacto_Mail";
            this.txtContacto_Mail.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContacto_Mail.Properties.Appearance.Options.UseFont = true;
            this.txtContacto_Mail.Size = new System.Drawing.Size(239, 24);
            this.txtContacto_Mail.TabIndex = 18;
            // 
            // chkSsyasa
            // 
            this.chkSsyasa.Location = new System.Drawing.Point(25, 41);
            this.chkSsyasa.Name = "chkSsyasa";
            this.chkSsyasa.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.chkSsyasa.Properties.Appearance.Options.UseFont = true;
            this.chkSsyasa.Properties.Caption = "SSyASA";
            this.chkSsyasa.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.chkSsyasa.Size = new System.Drawing.Size(110, 22);
            this.chkSsyasa.TabIndex = 101;
            // 
            // chkLubano
            // 
            this.chkLubano.Location = new System.Drawing.Point(25, 69);
            this.chkLubano.Name = "chkLubano";
            this.chkLubano.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.chkLubano.Properties.Appearance.Options.UseFont = true;
            this.chkLubano.Properties.Caption = "Jose Lubano Saucedo de la Cruz";
            this.chkLubano.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.chkLubano.Size = new System.Drawing.Size(224, 22);
            this.chkLubano.TabIndex = 102;
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.chkDiego);
            this.groupControl4.Controls.Add(this.chkSsyasa);
            this.groupControl4.Controls.Add(this.chkLubano);
            this.groupControl4.Location = new System.Drawing.Point(631, 366);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(414, 138);
            this.groupControl4.TabIndex = 103;
            this.groupControl4.Text = "Empresas";
            // 
            // chkDiego
            // 
            this.chkDiego.Location = new System.Drawing.Point(25, 97);
            this.chkDiego.Name = "chkDiego";
            this.chkDiego.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.chkDiego.Properties.Appearance.Options.UseFont = true;
            this.chkDiego.Properties.Caption = "Diego Fernando Carmona Collins";
            this.chkDiego.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.chkDiego.Size = new System.Drawing.Size(224, 22);
            this.chkDiego.TabIndex = 103;
            // 
            // FrmRegCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 647);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.chkEstatus);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmRegCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescuento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCredito.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxSector.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRazonSocial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMovil_Contacto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono_Contacto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion_Contacto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre_Contacto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPagina.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCorreo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEstatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtColonia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCalle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCiudad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtContacto_Mail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSsyasa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkLubano.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkDiego.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupControl groupControl3;
        private LabelControl lbl1;
        private TextEdit txtCP;
        private LabelControl labelControl20;
        private TextEdit txtColonia;
        private LabelControl labelControl32;
        private TextEdit txtCalle;
        private LabelControl labelControl29;
        private LabelControl labelControl18;
        private TextEdit txtCiudad;
        private GroupControl groupControl2;
        private LabelControl labelControl3;
        private TextEdit txtContacto_Mail;
        private LabelControl labelControl17;
        private LabelControl labelControl5;
        private CheckEdit chkSsyasa;
        private CheckEdit chkLubano;
        private GroupControl groupControl4;
        private CheckEdit chkDiego;
    }
}