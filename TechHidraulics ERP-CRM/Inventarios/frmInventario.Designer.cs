using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
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
    partial class FrmInventario
    {
        

        private SimpleButton btnNuevoArticulo;

        private GridControl gridInventario;

        private GridView viewArticulo;

        private GridColumn gridColumn1;

        private GridView gridView3;

        private SimpleButton frmEditarArticulo;

        private GridColumn gridColumn4;

        private GridColumn gridColumn3;

        private LabelControl labelControl1;

        private SimpleButton btnBorrarArticulo;

        private GridColumn gridColumn6;

        private GridColumn gridColumn5;

        private XtraTabControl xtabMain;

        private XtraTabPage tab1;

        private GridColumn gridColumn7;

        private GridColumn gridColumn8;

        private GridColumn gridColumn2;

        private RepositoryItemCheckEdit repchkWarning;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.gridInventario = new DevExpress.XtraGrid.GridControl();
            this.viewArticulo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repchkWarning = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnNuevoArticulo = new DevExpress.XtraEditors.SimpleButton();
            this.frmEditarArticulo = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnBorrarArticulo = new DevExpress.XtraEditors.SimpleButton();
            this.xtabMain = new DevExpress.XtraTab.XtraTabControl();
            this.tab1 = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.gridInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repchkWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtabMain)).BeginInit();
            this.xtabMain.SuspendLayout();
            this.tab1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridInventario
            // 
            this.gridInventario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridInventario.Location = new System.Drawing.Point(26, 59);
            this.gridInventario.MainView = this.viewArticulo;
            this.gridInventario.Name = "gridInventario";
            this.gridInventario.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repchkWarning});
            this.gridInventario.Size = new System.Drawing.Size(1182, 509);
            this.gridInventario.TabIndex = 43;
            this.gridInventario.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.gridColumn1,
            this.gridColumn4,
            this.gridColumn3,
            this.gridColumn6,
            this.gridColumn5,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn2});
            this.viewArticulo.GridControl = this.gridInventario;
            this.viewArticulo.Name = "viewArticulo";
            this.viewArticulo.OptionsBehavior.Editable = false;
            this.viewArticulo.OptionsFind.AlwaysVisible = true;
            this.viewArticulo.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.viewArticulo.RowHeight = 30;
            this.viewArticulo.DoubleClick += new System.EventHandler(this.viewInventario_DoubleClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "id_articulo";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Categoria";
            this.gridColumn4.FieldName = "nombre_categoria";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 227;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Nombre";
            this.gridColumn3.FieldName = "nombre";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 296;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn6.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn6.Caption = "Existencias";
            this.gridColumn6.FieldName = "cantidad_existencia";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            this.gridColumn6.Width = 107;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.Caption = "Precio";
            this.gridColumn5.DisplayFormat.FormatString = "c";
            this.gridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn5.FieldName = "precio";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            this.gridColumn5.Width = 98;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Codigo";
            this.gridColumn7.FieldName = "codigo";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 0;
            this.gridColumn7.Width = 162;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Marca";
            this.gridColumn8.FieldName = "marca";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 2;
            this.gridColumn8.Width = 274;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "Estatus";
            this.gridColumn2.ColumnEdit = this.repchkWarning;
            this.gridColumn2.FieldName = "estatus_existencias";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 6;
            // 
            // repchkWarning
            // 
            this.repchkWarning.AutoHeight = false;
            this.repchkWarning.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined;
            this.repchkWarning.Name = "repchkWarning";
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.gridInventario;
            this.gridView3.Name = "gridView3";
            // 
            // btnNuevoArticulo
            // 
            this.btnNuevoArticulo.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoArticulo.Appearance.Options.UseFont = true;
            this.btnNuevoArticulo.Appearance.Options.UseTextOptions = true;
            this.btnNuevoArticulo.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnNuevoArticulo.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnNuevoArticulo.Location = new System.Drawing.Point(26, 20);
            this.btnNuevoArticulo.Name = "btnNuevoArticulo";
            this.btnNuevoArticulo.Size = new System.Drawing.Size(77, 24);
            this.btnNuevoArticulo.TabIndex = 44;
            this.btnNuevoArticulo.Text = "Nuevo";
            this.btnNuevoArticulo.ToolTip = "Le permite al usuario añadir un nuevo articulo al Inventario.";
            this.btnNuevoArticulo.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btnNuevoArticulo.ToolTipTitle = "Nuevo";
            this.btnNuevoArticulo.Click += new System.EventHandler(this.btnNuevoArticulo_Click);
            // 
            // frmEditarArticulo
            // 
            this.frmEditarArticulo.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmEditarArticulo.Appearance.Options.UseFont = true;
            this.frmEditarArticulo.Appearance.Options.UseTextOptions = true;
            this.frmEditarArticulo.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.frmEditarArticulo.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.frmEditarArticulo.Location = new System.Drawing.Point(109, 20);
            this.frmEditarArticulo.Name = "frmEditarArticulo";
            this.frmEditarArticulo.Size = new System.Drawing.Size(77, 24);
            this.frmEditarArticulo.TabIndex = 40;
            this.frmEditarArticulo.Text = "Editar";
            this.frmEditarArticulo.ToolTip = "Le permite al usuario añadir un nuevo articulo al Inventario.";
            this.frmEditarArticulo.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.frmEditarArticulo.ToolTipTitle = "Agregar";
            this.frmEditarArticulo.Click += new System.EventHandler(this.frmEditarArticulo_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(27, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(134, 45);
            this.labelControl1.TabIndex = 45;
            this.labelControl1.Text = "Inventario";
            // 
            // btnBorrarArticulo
            // 
            this.btnBorrarArticulo.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarArticulo.Appearance.Options.UseFont = true;
            this.btnBorrarArticulo.Appearance.Options.UseTextOptions = true;
            this.btnBorrarArticulo.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnBorrarArticulo.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnBorrarArticulo.Location = new System.Drawing.Point(192, 20);
            this.btnBorrarArticulo.Name = "btnBorrarArticulo";
            this.btnBorrarArticulo.Size = new System.Drawing.Size(77, 24);
            this.btnBorrarArticulo.TabIndex = 48;
            this.btnBorrarArticulo.Text = "Borrar";
            this.btnBorrarArticulo.ToolTip = "Le permite al usuario añadir un nuevo articulo al Inventario.";
            this.btnBorrarArticulo.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btnBorrarArticulo.ToolTipTitle = "Nuevo";
            this.btnBorrarArticulo.Click += new System.EventHandler(this.btnBorrarArticulo_Click);
            // 
            // xtabMain
            // 
            this.xtabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtabMain.AppearancePage.Header.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtabMain.AppearancePage.Header.Options.UseFont = true;
            this.xtabMain.Location = new System.Drawing.Point(27, 74);
            this.xtabMain.Name = "xtabMain";
            this.xtabMain.SelectedTabPage = this.tab1;
            this.xtabMain.Size = new System.Drawing.Size(1230, 619);
            this.xtabMain.TabIndex = 49;
            this.xtabMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tab1});
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.gridInventario);
            this.tab1.Controls.Add(this.btnBorrarArticulo);
            this.tab1.Controls.Add(this.frmEditarArticulo);
            this.tab1.Controls.Add(this.btnNuevoArticulo);
            this.tab1.Name = "tab1";
            this.tab1.Size = new System.Drawing.Size(1224, 587);
            this.tab1.Text = "Inventario";
            // 
            // FrmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 705);
            this.Controls.Add(this.xtabMain);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmInventario";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.frmArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repchkWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtabMain)).EndInit();
            this.xtabMain.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}