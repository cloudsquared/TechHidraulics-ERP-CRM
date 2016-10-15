using DevExpress.Utils;
using DevExpress.XtraEditors;
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
using DevExpress.XtraBars.Alerter;
using DevExpress.XtraEditors.Mask;

namespace TechHidraulics_ERP_CRM.Servicios
{
    partial class FrmRegServicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private SimpleButton simpleButton1;

        private SimpleButton btnCancelar;

        private SimpleButton btnAnadir;

        private AlertControl alertControl1;

        private TextEdit txtTotal;

        private LabelControl labelControl4;

        private TextEdit txtArticulos;

        private LabelControl labelControl5;

        private LabelControl labelControl12;

        private TextEdit txtCostoBase;

        private TextEdit txtNombre;

        private LabelControl labelControl13;

        private XtraTabControl xtraTabControl1;

        private XtraTabPage xtraTabPage2;

        private GridControl gridArticulos;

        private GridView viewArticulo;

        private GridColumn gridColumn2;

        private GridColumn gridColumn7;

        private GridView gridView3;

        private SimpleButton btnBorrar;

        private SimpleButton btnAgregarArticulo;

        private GridColumn gridColumn1;

        private GridColumn gridColumn3;

        private GridColumn gridColumn4;

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


        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAnadir = new DevExpress.XtraEditors.SimpleButton();
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.txtTotal = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtArticulos = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txtCostoBase = new DevExpress.XtraEditors.TextEdit();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.btnBorrar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAgregarArticulo = new DevExpress.XtraEditors.SimpleButton();
            this.gridArticulos = new DevExpress.XtraGrid.GridControl();
            this.viewArticulo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArticulos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCostoBase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseTextOptions = true;
            this.simpleButton1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.simpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.simpleButton1.Location = new System.Drawing.Point(1194, 49);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(24, 24);
            this.simpleButton1.TabIndex = 26;
            this.simpleButton1.Text = "+";
            this.simpleButton1.ToolTip = "Crea una categoria para el articulo relacionado.";
            this.simpleButton1.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.simpleButton1.ToolTipTitle = "Nueva categoria";
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
            this.btnCancelar.Location = new System.Drawing.Point(829, 592);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 30);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.ToolTip = "Le permite al usuario añadir un nuevo articulo al Inventario.";
            this.btnCancelar.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btnCancelar.ToolTipTitle = "Agregar";
            // 
            // btnAnadir
            // 
            this.btnAnadir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnadir.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadir.Appearance.Options.UseFont = true;
            this.btnAnadir.Appearance.Options.UseTextOptions = true;
            this.btnAnadir.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnAnadir.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnAnadir.Location = new System.Drawing.Point(935, 592);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(101, 30);
            this.btnAnadir.TabIndex = 31;
            this.btnAnadir.Text = " Aceptar";
            this.btnAnadir.ToolTip = "Le permite al usuario añadir un nuevo articulo al Inventario.";
            this.btnAnadir.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btnAnadir.ToolTipTitle = "Agregar";
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.EditValue = "0";
            this.txtTotal.Location = new System.Drawing.Point(361, 116);
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
            this.txtTotal.TabIndex = 89;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(361, 92);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(71, 18);
            this.labelControl4.TabIndex = 90;
            this.labelControl4.Text = "Costo neto:";
            // 
            // txtArticulos
            // 
            this.txtArticulos.EditValue = "0";
            this.txtArticulos.Location = new System.Drawing.Point(199, 116);
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
            this.txtArticulos.TabIndex = 87;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(199, 92);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(95, 18);
            this.labelControl5.TabIndex = 88;
            this.labelControl5.Text = "Costo articulos:";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Location = new System.Drawing.Point(37, 35);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(129, 18);
            this.labelControl12.TabIndex = 85;
            this.labelControl12.Text = "Nombre del servicio:";
            // 
            // txtCostoBase
            // 
            this.txtCostoBase.EditValue = "0";
            this.txtCostoBase.Location = new System.Drawing.Point(38, 116);
            this.txtCostoBase.Name = "txtCostoBase";
            this.txtCostoBase.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoBase.Properties.Appearance.Options.UseFont = true;
            this.txtCostoBase.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCostoBase.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtCostoBase.Properties.Mask.EditMask = "c";
            this.txtCostoBase.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCostoBase.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtCostoBase.Size = new System.Drawing.Size(137, 24);
            this.txtCostoBase.TabIndex = 82;
            this.txtCostoBase.EditValueChanged += new System.EventHandler(this.txtCostoBase_EditValueChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(37, 59);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Properties.Appearance.Options.UseFont = true;
            this.txtNombre.Size = new System.Drawing.Size(305, 24);
            this.txtNombre.TabIndex = 83;
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Location = new System.Drawing.Point(38, 92);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(104, 18);
            this.labelControl13.TabIndex = 84;
            this.labelControl13.Text = "Costo base (mo):";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(37, 159);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage2;
            this.xtraTabControl1.Size = new System.Drawing.Size(999, 416);
            this.xtraTabControl1.TabIndex = 91;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage2});
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.btnBorrar);
            this.xtraTabPage2.Controls.Add(this.btnAgregarArticulo);
            this.xtraTabPage2.Controls.Add(this.gridArticulos);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(993, 388);
            this.xtraTabPage2.Text = "Articulos necesarios";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Appearance.Options.UseFont = true;
            this.btnBorrar.Appearance.Options.UseTextOptions = true;
            this.btnBorrar.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnBorrar.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnBorrar.Location = new System.Drawing.Point(104, 16);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(77, 24);
            this.btnBorrar.TabIndex = 53;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.ToolTip = "Le permite al usuario añadir un nuevo articulo al Inventario.";
            this.btnBorrar.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btnBorrar.ToolTipTitle = "Nuevo";
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarArticulo.Appearance.Options.UseFont = true;
            this.btnAgregarArticulo.Appearance.Options.UseTextOptions = true;
            this.btnAgregarArticulo.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnAgregarArticulo.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnAgregarArticulo.Location = new System.Drawing.Point(21, 16);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(77, 24);
            this.btnAgregarArticulo.TabIndex = 52;
            this.btnAgregarArticulo.Text = "Agregar";
            this.btnAgregarArticulo.ToolTip = "Le permite al usuario añadir un nuevo articulo al Inventario.";
            this.btnAgregarArticulo.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btnAgregarArticulo.ToolTipTitle = "Nuevo";
            this.btnAgregarArticulo.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // gridArticulos
            // 
            this.gridArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridArticulos.Location = new System.Drawing.Point(21, 46);
            this.gridArticulos.MainView = this.viewArticulo;
            this.gridArticulos.Name = "gridArticulos";
            this.gridArticulos.Size = new System.Drawing.Size(954, 327);
            this.gridArticulos.TabIndex = 44;
            this.gridArticulos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewArticulo,
            this.gridView3});
            this.gridArticulos.ProcessGridKey += new System.Windows.Forms.KeyEventHandler(this.gridArticulos_ProcessGridKey_1);
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
            this.gridColumn2.Width = 62;
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
            this.gridColumn7.Width = 74;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Nombre";
            this.gridColumn1.FieldName = "nombre";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 608;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.Caption = "Precio unitario";
            this.gridColumn3.DisplayFormat.FormatString = "c";
            this.gridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn3.FieldName = "precio_unitario";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 94;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.Caption = "Total";
            this.gridColumn4.DisplayFormat.FormatString = "c";
            this.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn4.FieldName = "total";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            this.gridColumn4.Width = 98;
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.gridArticulos;
            this.gridView3.Name = "gridView3";
            // 
            // FrmRegServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 647);
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
            this.Controls.Add(this.simpleButton1);
            this.Name = "FrmRegServicio";
            this.Text = "Servicio";
            this.Load += new System.EventHandler(this.frmNuevaActividad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArticulos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCostoBase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        
    }
}