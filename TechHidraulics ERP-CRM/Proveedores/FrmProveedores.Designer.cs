using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using TechHidraulics_ERP_CRM.Properties;

namespace TechHidraulics_ERP_CRM.Proveedores
{
    partial class FrmProveedores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private SimpleButton btnBorrarArticulo;

        private SimpleButton frmEditarProveedor;

        private GridControl gridProveedor;

        private GridView viewProveedor;

        private GridColumn gridColumn2;

        private GridColumn gridColumn4;

        private GridColumn gridColumn3;

        private GridColumn gridColumn6;

        private GridColumn gridColumn5;

        private GridView gridView3;

        private LabelControl labelControl1;

        private SimpleButton btnNuevoProveedor;

        private GridColumn gridColumn7;

        private GridColumn gridColumn1;

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
            this.btnBorrarArticulo = new DevExpress.XtraEditors.SimpleButton();
            this.frmEditarProveedor = new DevExpress.XtraEditors.SimpleButton();
            this.gridProveedor = new DevExpress.XtraGrid.GridControl();
            this.viewProveedor = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnNuevoProveedor = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBorrarArticulo
            // 
            this.btnBorrarArticulo.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarArticulo.Appearance.Options.UseFont = true;
            this.btnBorrarArticulo.Appearance.Options.UseTextOptions = true;
            this.btnBorrarArticulo.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnBorrarArticulo.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnBorrarArticulo.Location = new System.Drawing.Point(190, 84);
            this.btnBorrarArticulo.Name = "btnBorrarArticulo";
            this.btnBorrarArticulo.Size = new System.Drawing.Size(77, 24);
            this.btnBorrarArticulo.TabIndex = 54;
            this.btnBorrarArticulo.Text = "Borrar";
            this.btnBorrarArticulo.ToolTip = "Le permite al usuario añadir un nuevo articulo al Inventario.";
            this.btnBorrarArticulo.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btnBorrarArticulo.ToolTipTitle = "Nuevo";
            this.btnBorrarArticulo.Click += new System.EventHandler(this.btnBorrarArticulo_Click);
            // 
            // frmEditarProveedor
            // 
            this.frmEditarProveedor.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmEditarProveedor.Appearance.Options.UseFont = true;
            this.frmEditarProveedor.Appearance.Options.UseTextOptions = true;
            this.frmEditarProveedor.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.frmEditarProveedor.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.frmEditarProveedor.Location = new System.Drawing.Point(107, 84);
            this.frmEditarProveedor.Name = "frmEditarProveedor";
            this.frmEditarProveedor.Size = new System.Drawing.Size(77, 24);
            this.frmEditarProveedor.TabIndex = 49;
            this.frmEditarProveedor.Text = "Editar";
            this.frmEditarProveedor.ToolTip = "Le permite al usuario añadir un nuevo articulo al Inventario.";
            this.frmEditarProveedor.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.frmEditarProveedor.ToolTipTitle = "Agregar";
            this.frmEditarProveedor.Click += new System.EventHandler(this.frmEditarProveedor_Click);
            // 
            // gridProveedor
            // 
            this.gridProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridProveedor.Location = new System.Drawing.Point(24, 114);
            this.gridProveedor.MainView = this.viewProveedor;
            this.gridProveedor.Name = "gridProveedor";
            this.gridProveedor.Size = new System.Drawing.Size(1069, 524);
            this.gridProveedor.TabIndex = 50;
            this.gridProveedor.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewProveedor,
            this.gridView3});
            // 
            // viewProveedor
            // 
            this.viewProveedor.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewProveedor.Appearance.HeaderPanel.Options.UseFont = true;
            this.viewProveedor.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewProveedor.Appearance.Row.Options.UseFont = true;
            this.viewProveedor.ColumnPanelRowHeight = 30;
            this.viewProveedor.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn4,
            this.gridColumn3,
            this.gridColumn6,
            this.gridColumn5,
            this.gridColumn7,
            this.gridColumn1});
            this.viewProveedor.GridControl = this.gridProveedor;
            this.viewProveedor.Name = "viewProveedor";
            this.viewProveedor.OptionsBehavior.Editable = false;
            this.viewProveedor.OptionsFind.AlwaysVisible = true;
            this.viewProveedor.OptionsFind.FindNullPrompt = "Buscar proveedor...";
            this.viewProveedor.OptionsFind.HighlightFindResults = false;
            this.viewProveedor.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.viewProveedor.OptionsView.ShowGroupPanel = false;
            this.viewProveedor.RowHeight = 30;
            this.viewProveedor.DoubleClick += new System.EventHandler(this.viewProveedor_DoubleClick);
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "ID";
            this.gridColumn2.FieldName = "id_proveedor";
            this.gridColumn2.MaxWidth = 300;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 47;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Telefono";
            this.gridColumn4.FieldName = "telefono";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            this.gridColumn4.Width = 105;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Nombre";
            this.gridColumn3.FieldName = "nombre";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 327;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Atencion";
            this.gridColumn6.FieldName = "atencion";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 157;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Direccion";
            this.gridColumn5.FieldName = "direccion";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 6;
            this.gridColumn5.Width = 221;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Codigo";
            this.gridColumn7.FieldName = "codigo_proveedor";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 1;
            this.gridColumn7.Width = 56;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Sector";
            this.gridColumn1.FieldName = "sector";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 142;
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.gridProveedor;
            this.gridView3.Name = "gridView3";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(24, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(168, 45);
            this.labelControl1.TabIndex = 52;
            this.labelControl1.Text = "Proveedores";
            // 
            // btnNuevoProveedor
            // 
            this.btnNuevoProveedor.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoProveedor.Appearance.Options.UseFont = true;
            this.btnNuevoProveedor.Appearance.Options.UseTextOptions = true;
            this.btnNuevoProveedor.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnNuevoProveedor.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnNuevoProveedor.Location = new System.Drawing.Point(24, 84);
            this.btnNuevoProveedor.Name = "btnNuevoProveedor";
            this.btnNuevoProveedor.Size = new System.Drawing.Size(77, 24);
            this.btnNuevoProveedor.TabIndex = 51;
            this.btnNuevoProveedor.Text = "Nuevo";
            this.btnNuevoProveedor.ToolTip = "Le permite al usuario añadir un nuevo articulo al Inventario.";
            this.btnNuevoProveedor.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btnNuevoProveedor.ToolTipTitle = "Nuevo";
            this.btnNuevoProveedor.Click += new System.EventHandler(this.btnNuevoProveedor_Click);
            // 
            // FrmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 662);
            this.Controls.Add(this.btnBorrarArticulo);
            this.Controls.Add(this.frmEditarProveedor);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnNuevoProveedor);
            this.Controls.Add(this.gridProveedor);
            this.Name = "FrmProveedores";
            this.Text = "Proveedores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}