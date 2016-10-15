using DevExpress.Utils;
using DevExpress.XtraBars.Alerter;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace TechHidraulics_ERP_CRM.Inventarios
{
    partial class FrmRegArticulo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private BindingList<DataRow> list = new BindingList<DataRow>();

        private TextEdit txtNombre;
        private LabelControl labelControl1;
        private LabelControl labelControl2;
        private TextEdit txtCantidadExistencias;
        private LabelControl labelControl3;
        private LabelControl labelControl4;
        private TextEdit txtCantidadBaja;
        private ComboBoxEdit cbxMedida;

        private LabelControl labelControl5;

        private ComboBoxEdit cbxCategoria;

        private LabelControl labelControl9;

        private SimpleButton btnAnadir;

        private SimpleButton btnCancelar;

        private BackgroundWorker backgroundWorker1;

        private SimpleButton btnCategoria;

        private AlertControl alertControl1;

        private LabelControl labelControl8;

        private LabelControl labelControl10;

        private TextEdit txtCodigo;

        private ComboBoxEdit cbxSubCategoria;

        private LabelControl labelControl7;

        private GroupControl groupControl1;

        private TextEdit txtOrdenadas;

        private LabelControl labelControl11;

        private TextEdit memoDescripcion;

        private LabelControl labelControl12;

        private TextEdit txtMarca;

        private GroupControl groupControl2;

        private PictureEdit picArticulo;

        private TextEdit txtPrecio;

        private LabelControl labelControl6;

        private LabelControl labelControl13;

        private LabelControl labelControl21;

        private LabelControl labelControl15;

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
            this.components = new System.ComponentModel.Container();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtCantidadExistencias = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtCantidadBaja = new DevExpress.XtraEditors.TextEdit();
            this.cbxMedida = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cbxCategoria = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.btnAnadir = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnCategoria = new DevExpress.XtraEditors.SimpleButton();
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.cbxSubCategoria = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl21 = new DevExpress.XtraEditors.LabelControl();
            this.txtPrecio = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txtMarca = new DevExpress.XtraEditors.TextEdit();
            this.txtOrdenadas = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.memoDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.picArticulo = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadExistencias.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadBaja.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxMedida.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCategoria.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxSubCategoria.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarca.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrdenadas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArticulo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(305, 60);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Properties.Appearance.Options.UseFont = true;
            this.txtNombre.Size = new System.Drawing.Size(315, 24);
            this.txtNombre.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(245, 63);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 18);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Nombre";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(396, 101);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(68, 18);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Existencias";
            // 
            // txtCantidadExistencias
            // 
            this.txtCantidadExistencias.EditValue = "0";
            this.txtCantidadExistencias.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtCantidadExistencias.Location = new System.Drawing.Point(481, 98);
            this.txtCantidadExistencias.Name = "txtCantidadExistencias";
            this.txtCantidadExistencias.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.txtCantidadExistencias.Properties.Appearance.Options.UseFont = true;
            this.txtCantidadExistencias.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCantidadExistencias.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtCantidadExistencias.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Optimistic;
            this.txtCantidadExistencias.Properties.Mask.BeepOnError = true;
            this.txtCantidadExistencias.Properties.Mask.EditMask = "d";
            this.txtCantidadExistencias.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCantidadExistencias.Size = new System.Drawing.Size(97, 24);
            this.txtCantidadExistencias.TabIndex = 8;
            this.txtCantidadExistencias.EditValueChanged += new System.EventHandler(this.txtCantidadExistencias_EditValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(21, 41);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(72, 18);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Descripcion";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(396, 131);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 18);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Minimo";
            // 
            // txtCantidadBaja
            // 
            this.txtCantidadBaja.EditValue = "0";
            this.txtCantidadBaja.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtCantidadBaja.Location = new System.Drawing.Point(481, 128);
            this.txtCantidadBaja.Name = "txtCantidadBaja";
            this.txtCantidadBaja.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadBaja.Properties.Appearance.Options.UseFont = true;
            this.txtCantidadBaja.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCantidadBaja.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtCantidadBaja.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Optimistic;
            this.txtCantidadBaja.Properties.Mask.EditMask = "d";
            this.txtCantidadBaja.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCantidadBaja.Size = new System.Drawing.Size(97, 24);
            this.txtCantidadBaja.TabIndex = 9;
            // 
            // cbxMedida
            // 
            this.cbxMedida.EditValue = "";
            this.cbxMedida.Location = new System.Drawing.Point(149, 128);
            this.cbxMedida.Name = "cbxMedida";
            this.cbxMedida.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMedida.Properties.Appearance.Options.UseFont = true;
            this.cbxMedida.Properties.Appearance.Options.UseTextOptions = true;
            this.cbxMedida.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cbxMedida.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxMedida.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbxMedida.Size = new System.Drawing.Size(201, 24);
            this.cbxMedida.TabIndex = 5;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(21, 131);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(113, 18);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Unidad de medida";
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.EditValue = "";
            this.cbxCategoria.Location = new System.Drawing.Point(149, 68);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCategoria.Properties.Appearance.Options.UseFont = true;
            this.cbxCategoria.Properties.Appearance.Options.UseTextOptions = true;
            this.cbxCategoria.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cbxCategoria.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxCategoria.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbxCategoria.Size = new System.Drawing.Size(171, 24);
            this.cbxCategoria.TabIndex = 3;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Location = new System.Drawing.Point(21, 71);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(59, 18);
            this.labelControl9.TabIndex = 13;
            this.labelControl9.Text = "Categoria";
            // 
            // btnAnadir
            // 
            this.btnAnadir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAnadir.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadir.Appearance.Options.UseFont = true;
            this.btnAnadir.Appearance.Options.UseTextOptions = true;
            this.btnAnadir.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnAnadir.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnAnadir.Location = new System.Drawing.Point(801, 407);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(112, 38);
            this.btnAnadir.TabIndex = 8;
            this.btnAnadir.Text = "Aceptar";
            this.btnAnadir.ToolTip = "Le permite al usuario añadir un nuevo articulo al Inventario.";
            this.btnAnadir.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btnAnadir.ToolTipTitle = "Agregar";
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelar.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Appearance.Options.UseFont = true;
            this.btnCancelar.Appearance.Options.UseTextOptions = true;
            this.btnCancelar.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(683, 407);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 38);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            // 
            // btnCategoria
            // 
            this.btnCategoria.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoria.Appearance.Options.UseFont = true;
            this.btnCategoria.Appearance.Options.UseTextOptions = true;
            this.btnCategoria.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnCategoria.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnCategoria.Location = new System.Drawing.Point(326, 68);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(24, 24);
            this.btnCategoria.TabIndex = 21;
            this.btnCategoria.Text = "+";
            this.btnCategoria.ToolTip = "Crea una categoria para el articulo relacionado.";
            this.btnCategoria.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btnCategoria.ToolTipTitle = "Nueva categoria";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Location = new System.Drawing.Point(26, 12);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(104, 45);
            this.labelControl8.TabIndex = 37;
            this.labelControl8.Text = "Articulo";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Location = new System.Drawing.Point(38, 63);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(47, 18);
            this.labelControl10.TabIndex = 39;
            this.labelControl10.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(99, 60);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Properties.Appearance.Options.UseFont = true;
            this.txtCodigo.Size = new System.Drawing.Size(123, 24);
            this.txtCodigo.TabIndex = 0;
            // 
            // cbxSubCategoria
            // 
            this.cbxSubCategoria.EditValue = "";
            this.cbxSubCategoria.Location = new System.Drawing.Point(149, 98);
            this.cbxSubCategoria.Name = "cbxSubCategoria";
            this.cbxSubCategoria.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSubCategoria.Properties.Appearance.Options.UseFont = true;
            this.cbxSubCategoria.Properties.Appearance.Options.UseTextOptions = true;
            this.cbxSubCategoria.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cbxSubCategoria.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxSubCategoria.Size = new System.Drawing.Size(201, 24);
            this.cbxSubCategoria.TabIndex = 4;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(21, 101);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(87, 18);
            this.labelControl7.TabIndex = 42;
            this.labelControl7.Text = "Sub-Categoria";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl21);
            this.groupControl1.Controls.Add(this.txtPrecio);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl12);
            this.groupControl1.Controls.Add(this.txtMarca);
            this.groupControl1.Controls.Add(this.txtOrdenadas);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.memoDescripcion);
            this.groupControl1.Controls.Add(this.cbxCategoria);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtCantidadExistencias);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.cbxMedida);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtCantidadBaja);
            this.groupControl1.Controls.Add(this.cbxSubCategoria);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.btnCategoria);
            this.groupControl1.Location = new System.Drawing.Point(26, 97);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(594, 213);
            this.groupControl1.TabIndex = 44;
            this.groupControl1.Text = "Principal";
            // 
            // labelControl21
            // 
            this.labelControl21.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl21.Location = new System.Drawing.Point(8, 71);
            this.labelControl21.Name = "labelControl21";
            this.labelControl21.Size = new System.Drawing.Size(7, 18);
            this.labelControl21.TabIndex = 72;
            this.labelControl21.Text = "*";
            // 
            // txtPrecio
            // 
            this.txtPrecio.EditValue = "0";
            this.txtPrecio.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtPrecio.Location = new System.Drawing.Point(481, 38);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.txtPrecio.Properties.Appearance.Options.UseFont = true;
            this.txtPrecio.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPrecio.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtPrecio.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Optimistic;
            this.txtPrecio.Properties.Mask.BeepOnError = true;
            this.txtPrecio.Properties.Mask.EditMask = "c";
            this.txtPrecio.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPrecio.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtPrecio.Size = new System.Drawing.Size(97, 24);
            this.txtPrecio.TabIndex = 7;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(396, 41);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(39, 18);
            this.labelControl6.TabIndex = 49;
            this.labelControl6.Text = "Precio";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Location = new System.Drawing.Point(21, 161);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(37, 18);
            this.labelControl12.TabIndex = 48;
            this.labelControl12.Text = "Marca";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(149, 158);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Properties.Appearance.Options.UseFont = true;
            this.txtMarca.Size = new System.Drawing.Size(201, 24);
            this.txtMarca.TabIndex = 6;
            // 
            // txtOrdenadas
            // 
            this.txtOrdenadas.EditValue = "0";
            this.txtOrdenadas.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtOrdenadas.Location = new System.Drawing.Point(481, 158);
            this.txtOrdenadas.Name = "txtOrdenadas";
            this.txtOrdenadas.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.txtOrdenadas.Properties.Appearance.Options.UseFont = true;
            this.txtOrdenadas.Properties.Appearance.Options.UseTextOptions = true;
            this.txtOrdenadas.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtOrdenadas.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Optimistic;
            this.txtOrdenadas.Properties.Mask.BeepOnError = true;
            this.txtOrdenadas.Properties.Mask.EditMask = "d";
            this.txtOrdenadas.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtOrdenadas.Properties.ReadOnly = true;
            this.txtOrdenadas.Size = new System.Drawing.Size(97, 24);
            this.txtOrdenadas.TabIndex = 10;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Location = new System.Drawing.Point(396, 161);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(67, 18);
            this.labelControl11.TabIndex = 45;
            this.labelControl11.Text = "Ordenadas";
            // 
            // memoDescripcion
            // 
            this.memoDescripcion.Location = new System.Drawing.Point(100, 38);
            this.memoDescripcion.Name = "memoDescripcion";
            this.memoDescripcion.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoDescripcion.Properties.Appearance.Options.UseFont = true;
            this.memoDescripcion.Size = new System.Drawing.Size(250, 24);
            this.memoDescripcion.TabIndex = 2;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.picArticulo);
            this.groupControl2.Location = new System.Drawing.Point(648, 58);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(265, 252);
            this.groupControl2.TabIndex = 49;
            this.groupControl2.Text = "Imagen del articulo";
            // 
            // picArticulo
            // 
            this.picArticulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picArticulo.Location = new System.Drawing.Point(2, 20);
            this.picArticulo.Name = "picArticulo";
            this.picArticulo.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picArticulo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.picArticulo.Size = new System.Drawing.Size(261, 230);
            this.picArticulo.TabIndex = 29;
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Location = new System.Drawing.Point(25, 63);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(7, 18);
            this.labelControl13.TabIndex = 71;
            this.labelControl13.Text = "*";
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl15.Location = new System.Drawing.Point(232, 63);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(7, 18);
            this.labelControl15.TabIndex = 73;
            this.labelControl15.Text = "*";
            // 
            // FrmRegArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 469);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.labelControl15);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAnadir);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmRegArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulo de inventario";
            this.Load += new System.EventHandler(this.frmArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadExistencias.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadBaja.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxMedida.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCategoria.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxSubCategoria.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarca.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrdenadas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picArticulo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}