using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTab;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace TechHidraulics_ERP_CRM.Inventarios
{
    partial class FrmRegProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
  

        private IContainer components = null;

        private XtraTabControl xtraTabControl1;

        private XtraTabPage xtraTabPage2;

        private SimpleButton simpleButton2;

        private SimpleButton btnAgregarArticulo;

        private GridControl gridArticulos;

        private GridView viewArticulo;

        private GridColumn gridColumn2;

        private GridColumn gridColumn7;

        private GridColumn gridColumn1;

        private GridColumn gridColumn3;

        private GridColumn gridColumn4;

        private GridView gridView3;

        private TextEdit txtTotal;

        private LabelControl labelControl4;

        private SimpleButton btnCancelar;

        private TextEdit txtArticulos;

        private SimpleButton btnAnadir;

        private LabelControl labelControl5;

        private LabelControl labelControl12;

        private TextEdit txtCostoBase;

        private TextEdit txtNombre;

        private LabelControl labelControl13;

        private TextEdit txtUtilidad;

        private LabelControl lblUtilidad;

        private TextEdit txtUtilidadPorce;

        private LabelControl lblPrecio;

        private LabelControl lblPerc;

        private TextEdit txtPrecio;

        private LabelControl labelControl6;

        private TextEdit txtDescripcion;

        private LabelControl labelControl7;

        private TextEdit txtCodigo;

        private CheckEdit chkPieza;

        private CheckEdit chkProducto;

        private LabelControl labelControl8;

        private TextEdit txtPrecioReal;

        private LabelControl lblPrecioReal;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; oTechHidraulics_ERP_CRMerwise, false.</param>
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
        /// Required meTechHidraulics_ERP_CRMod for Designer support - do not modify
        /// TechHidraulics_ERP_CRMe contents of TechHidraulics_ERP_CRMis meTechHidraulics_ERP_CRMod wiTechHidraulics_ERP_CRM TechHidraulics_ERP_CRMe code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnAgregarArticulo = new DevExpress.XtraEditors.SimpleButton();
            this.gridArticulos = new DevExpress.XtraGrid.GridControl();
            this.viewArticulo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtTotal = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.txtArticulos = new DevExpress.XtraEditors.TextEdit();
            this.btnAnadir = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txtCostoBase = new DevExpress.XtraEditors.TextEdit();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.txtUtilidad = new DevExpress.XtraEditors.TextEdit();
            this.lblUtilidad = new DevExpress.XtraEditors.LabelControl();
            this.txtUtilidadPorce = new DevExpress.XtraEditors.TextEdit();
            this.lblPrecio = new DevExpress.XtraEditors.LabelControl();
            this.lblPerc = new DevExpress.XtraEditors.LabelControl();
            this.txtPrecio = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.chkPieza = new DevExpress.XtraEditors.CheckEdit();
            this.chkProducto = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtPrecioReal = new DevExpress.XtraEditors.TextEdit();
            this.lblPrecioReal = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArticulos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCostoBase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUtilidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUtilidadPorce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPieza.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkProducto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioReal.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(39, 225);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage2;
            this.xtraTabControl1.Size = new System.Drawing.Size(1064, 441);
            this.xtraTabControl1.TabIndex = 113;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage2});
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.simpleButton2);
            this.xtraTabPage2.Controls.Add(this.btnAgregarArticulo);
            this.xtraTabPage2.Controls.Add(this.gridArticulos);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1058, 413);
            this.xtraTabPage2.Text = "Articulos necesarios";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Appearance.Options.UseTextOptions = true;
            this.simpleButton2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.simpleButton2.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.simpleButton2.Location = new System.Drawing.Point(104, 18);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(77, 24);
            this.simpleButton2.TabIndex = 53;
            this.simpleButton2.Text = "Borrar";
            this.simpleButton2.ToolTip = "Le permite al usuario añadir un nuevo articulo al Inventario.";
            this.simpleButton2.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.simpleButton2.ToolTipTitle = "Nuevo";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarArticulo.Appearance.Options.UseFont = true;
            this.btnAgregarArticulo.Appearance.Options.UseTextOptions = true;
            this.btnAgregarArticulo.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnAgregarArticulo.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnAgregarArticulo.Location = new System.Drawing.Point(21, 18);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(77, 24);
            this.btnAgregarArticulo.TabIndex = 52;
            this.btnAgregarArticulo.Text = "Agregar";
            this.btnAgregarArticulo.ToolTip = "Le permite al usuario añadir un nuevo articulo al Inventario.";
            this.btnAgregarArticulo.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btnAgregarArticulo.ToolTipTitle = "Nuevo";
            this.btnAgregarArticulo.Click += new System.EventHandler(this.btnAgregarArticulo_Click);
            // 
            // gridArticulos
            // 
            this.gridArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridArticulos.Location = new System.Drawing.Point(21, 56);
            this.gridArticulos.MainView = this.viewArticulo;
            this.gridArticulos.Name = "gridArticulos";
            this.gridArticulos.Size = new System.Drawing.Size(1022, 342);
            this.gridArticulos.TabIndex = 44;
            this.gridArticulos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewArticulo,
            this.gridView3});
            // 
            // viewArticulo
            // 
            this.viewArticulo.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewArticulo.Appearance.HeaderPanel.Options.UseFont = true;
            this.viewArticulo.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewArticulo.Appearance.Row.Options.UseFont = true;
            this.viewArticulo.ColumnPanelRowHeight = 30;
            this.viewArticulo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn7,
            this.gridColumn1,
            this.gridColumn3,
            this.gridColumn4});
            this.viewArticulo.GridControl = this.gridArticulos;
            this.viewArticulo.Name = "viewArticulo";
            this.viewArticulo.OptionsBehavior.Editable = false;
            this.viewArticulo.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.viewArticulo.OptionsView.ShowGroupPanel = false;
            this.viewArticulo.RowHeight = 30;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "ID";
            this.gridColumn2.FieldName = "id_articulo";
            this.gridColumn2.MaxWidth = 300;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 52;
            // 
            // gridColumn7
            // 
            this.gridColumn7.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn7.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn7.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn7.Caption = "Cantidad";
            this.gridColumn7.FieldName = "cantidad";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 2;
            this.gridColumn7.Width = 69;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Nombre";
            this.gridColumn1.FieldName = "nombre";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 497;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.Caption = "Precio unitario";
            this.gridColumn3.FieldName = "precio_unitario";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 87;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.Caption = "Total";
            this.gridColumn4.FieldName = "total";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            this.gridColumn4.Width = 95;
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.gridArticulos;
            this.gridView3.Name = "gridView3";
            // 
            // txtTotal
            // 
            this.txtTotal.EditValue = "0";
            this.txtTotal.Location = new System.Drawing.Point(371, 173);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Properties.Appearance.Options.UseFont = true;
            this.txtTotal.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtTotal.Properties.Mask.EditMask = "c";
            this.txtTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTotal.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtTotal.Properties.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(137, 24);
            this.txtTotal.TabIndex = 111;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(374, 149);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(126, 18);
            this.labelControl4.TabIndex = 112;
            this.labelControl4.Text = "Costo de produccion";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Appearance.Options.UseFont = true;
            this.btnCancelar.Appearance.Options.UseTextOptions = true;
            this.btnCancelar.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(891, 683);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 30);
            this.btnCancelar.TabIndex = 104;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.ToolTip = "Le permite al usuario añadir un nuevo articulo al Inventario.";
            this.btnCancelar.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btnCancelar.ToolTipTitle = "Agregar";
            // 
            // txtArticulos
            // 
            this.txtArticulos.EditValue = "0";
            this.txtArticulos.Location = new System.Drawing.Point(201, 173);
            this.txtArticulos.Name = "txtArticulos";
            this.txtArticulos.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArticulos.Properties.Appearance.Options.UseFont = true;
            this.txtArticulos.Properties.Appearance.Options.UseTextOptions = true;
            this.txtArticulos.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtArticulos.Properties.Mask.EditMask = "c";
            this.txtArticulos.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtArticulos.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtArticulos.Properties.ReadOnly = true;
            this.txtArticulos.Size = new System.Drawing.Size(137, 24);
            this.txtArticulos.TabIndex = 109;
            // 
            // btnAnadir
            // 
            this.btnAnadir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnadir.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadir.Appearance.Options.UseFont = true;
            this.btnAnadir.Appearance.Options.UseTextOptions = true;
            this.btnAnadir.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnAnadir.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnAnadir.Location = new System.Drawing.Point(997, 683);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(101, 30);
            this.btnAnadir.TabIndex = 103;
            this.btnAnadir.Text = " Aceptar";
            this.btnAnadir.ToolTip = "Le permite al usuario añadir un nuevo articulo al Inventario.";
            this.btnAnadir.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btnAnadir.ToolTipTitle = "Agregar";
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(198, 149);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(157, 18);
            this.labelControl5.TabIndex = 110;
            this.labelControl5.Text = "Costo articulos y/o piezas";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Location = new System.Drawing.Point(39, 52);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(55, 18);
            this.labelControl12.TabIndex = 108;
            this.labelControl12.Text = "Nombre:";
            // 
            // txtCostoBase
            // 
            this.txtCostoBase.EditValue = "0";
            this.txtCostoBase.Location = new System.Drawing.Point(40, 173);
            this.txtCostoBase.Name = "txtCostoBase";
            this.txtCostoBase.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoBase.Properties.Appearance.Options.UseFont = true;
            this.txtCostoBase.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCostoBase.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtCostoBase.Properties.Mask.EditMask = "c";
            this.txtCostoBase.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCostoBase.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtCostoBase.Size = new System.Drawing.Size(137, 24);
            this.txtCostoBase.TabIndex = 105;
            this.txtCostoBase.EditValueChanged += new System.EventHandler(this.txtCostoBase_EditValueChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(134, 49);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Properties.Appearance.Options.UseFont = true;
            this.txtNombre.Size = new System.Drawing.Size(245, 24);
            this.txtNombre.TabIndex = 106;
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Location = new System.Drawing.Point(39, 149);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(104, 18);
            this.labelControl13.TabIndex = 107;
            this.labelControl13.Text = "Costo base (mo):";
            // 
            // txtUtilidad
            // 
            this.txtUtilidad.EditValue = "0";
            this.txtUtilidad.Location = new System.Drawing.Point(632, 173);
            this.txtUtilidad.Name = "txtUtilidad";
            this.txtUtilidad.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUtilidad.Properties.Appearance.Options.UseFont = true;
            this.txtUtilidad.Properties.Appearance.Options.UseTextOptions = true;
            this.txtUtilidad.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtUtilidad.Properties.Mask.EditMask = "c";
            this.txtUtilidad.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtUtilidad.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtUtilidad.Properties.ReadOnly = true;
            this.txtUtilidad.Size = new System.Drawing.Size(110, 24);
            this.txtUtilidad.TabIndex = 114;
            this.txtUtilidad.Visible = false;
            // 
            // lblUtilidad
            // 
            this.lblUtilidad.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUtilidad.Location = new System.Drawing.Point(584, 149);
            this.lblUtilidad.Name = "lblUtilidad";
            this.lblUtilidad.Size = new System.Drawing.Size(131, 18);
            this.lblUtilidad.TabIndex = 115;
            this.lblUtilidad.Text = "Utilidad del producto";
            this.lblUtilidad.Visible = false;
            // 
            // txtUtilidadPorce
            // 
            this.txtUtilidadPorce.EditValue = "35";
            this.txtUtilidadPorce.Location = new System.Drawing.Point(575, 173);
            this.txtUtilidadPorce.Name = "txtUtilidadPorce";
            this.txtUtilidadPorce.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUtilidadPorce.Properties.Appearance.Options.UseFont = true;
            this.txtUtilidadPorce.Properties.Appearance.Options.UseTextOptions = true;
            this.txtUtilidadPorce.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtUtilidadPorce.Properties.Mask.EditMask = "d";
            this.txtUtilidadPorce.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtUtilidadPorce.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtUtilidadPorce.Size = new System.Drawing.Size(51, 24);
            this.txtUtilidadPorce.TabIndex = 116;
            this.txtUtilidadPorce.Visible = false;
            this.txtUtilidadPorce.EditValueChanged += new System.EventHandler(this.txtUtilidadPorce_EditValueChanged);
            // 
            // lblPrecio
            // 
            this.lblPrecio.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(780, 152);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(96, 18);
            this.lblPrecio.TabIndex = 117;
            this.lblPrecio.Text = "Precio sugerido";
            this.lblPrecio.Visible = false;
            // 
            // lblPerc
            // 
            this.lblPerc.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerc.Location = new System.Drawing.Point(563, 176);
            this.lblPerc.Name = "lblPerc";
            this.lblPerc.Size = new System.Drawing.Size(11, 18);
            this.lblPerc.TabIndex = 118;
            this.lblPerc.Text = "%";
            this.lblPerc.Visible = false;
            // 
            // txtPrecio
            // 
            this.txtPrecio.EditValue = "0";
            this.txtPrecio.Location = new System.Drawing.Point(761, 173);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Properties.Appearance.Options.UseFont = true;
            this.txtPrecio.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPrecio.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtPrecio.Properties.Mask.EditMask = "c";
            this.txtPrecio.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPrecio.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtPrecio.Properties.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(141, 24);
            this.txtPrecio.TabIndex = 119;
            this.txtPrecio.ToolTip = "Para incrementar o reducir el precio de venta puede modificar la mano de obra o l" +
    "a utilidad esperada para este producto.";
            this.txtPrecio.Visible = false;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(39, 82);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(76, 18);
            this.labelControl6.TabIndex = 121;
            this.labelControl6.Text = "Descripcion:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(134, 79);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Properties.Appearance.Options.UseFont = true;
            this.txtDescripcion.Size = new System.Drawing.Size(425, 24);
            this.txtDescripcion.TabIndex = 120;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(39, 22);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(47, 18);
            this.labelControl7.TabIndex = 123;
            this.labelControl7.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(134, 19);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Properties.Appearance.Options.UseFont = true;
            this.txtCodigo.Size = new System.Drawing.Size(245, 24);
            this.txtCodigo.TabIndex = 122;
            // 
            // chkPieza
            // 
            this.chkPieza.EditValue = true;
            this.chkPieza.Location = new System.Drawing.Point(134, 109);
            this.chkPieza.Name = "chkPieza";
            this.chkPieza.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPieza.Properties.Appearance.Options.UseFont = true;
            this.chkPieza.Properties.Caption = "Pieza";
            this.chkPieza.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.chkPieza.Properties.RadioGroupIndex = 0;
            this.chkPieza.Size = new System.Drawing.Size(75, 19);
            this.chkPieza.TabIndex = 124;
            this.chkPieza.ToolTip = "Las piezas forman parte de un producto por tanto no tienen utilidad individualmen" +
    "te.";
            // 
            // chkProducto
            // 
            this.chkProducto.Location = new System.Drawing.Point(215, 109);
            this.chkProducto.Name = "chkProducto";
            this.chkProducto.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkProducto.Properties.Appearance.Options.UseFont = true;
            this.chkProducto.Properties.Caption = "Producto final";
            this.chkProducto.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.chkProducto.Properties.RadioGroupIndex = 0;
            this.chkProducto.Size = new System.Drawing.Size(101, 19);
            this.chkProducto.TabIndex = 125;
            this.chkProducto.TabStop = false;
            this.chkProducto.ToolTip = "Producto para venta comercial";
            this.chkProducto.CheckedChanged += new System.EventHandler(this.chkProducto_CheckedChanged);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Location = new System.Drawing.Point(40, 109);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(31, 18);
            this.labelControl8.TabIndex = 126;
            this.labelControl8.Text = "Tipo:";
            // 
            // txtPrecioReal
            // 
            this.txtPrecioReal.EditValue = "0";
            this.txtPrecioReal.Location = new System.Drawing.Point(936, 173);
            this.txtPrecioReal.Name = "txtPrecioReal";
            this.txtPrecioReal.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioReal.Properties.Appearance.Options.UseFont = true;
            this.txtPrecioReal.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPrecioReal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtPrecioReal.Properties.Mask.EditMask = "c";
            this.txtPrecioReal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPrecioReal.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtPrecioReal.Size = new System.Drawing.Size(162, 24);
            this.txtPrecioReal.TabIndex = 128;
            this.txtPrecioReal.Visible = false;
            // 
            // lblPrecioReal
            // 
            this.lblPrecioReal.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioReal.Location = new System.Drawing.Point(968, 152);
            this.lblPrecioReal.Name = "lblPrecioReal";
            this.lblPrecioReal.Size = new System.Drawing.Size(96, 18);
            this.lblPrecioReal.TabIndex = 127;
            this.lblPrecioReal.Text = "Precio de venta";
            this.lblPrecioReal.Visible = false;
            // 
            // FrmRegProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 734);
            this.Controls.Add(this.txtPrecioReal);
            this.Controls.Add(this.lblPrecioReal);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.chkProducto);
            this.Controls.Add(this.chkPieza);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPerc);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtUtilidadPorce);
            this.Controls.Add(this.txtUtilidad);
            this.Controls.Add(this.lblUtilidad);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtArticulos);
            this.Controls.Add(this.btnAnadir);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.txtCostoBase);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.labelControl13);
            this.Name = "FrmRegProducto";
            this.Text = "frmAE_Producto";
            this.Load += new System.EventHandler(this.frmAE_Producto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArticulos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCostoBase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUtilidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUtilidadPorce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPieza.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkProducto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioReal.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}