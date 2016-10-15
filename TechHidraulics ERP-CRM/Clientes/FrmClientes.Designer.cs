
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace TechHidraulics_ERP_CRM.Clientes
{
    partial class FrmClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private SimpleButton btnNuevoCliente;

        private LabelControl labelControl1;

        private GridControl gridCliente;

        private GridView viewCliente;

        private GridColumn gridColumn2;

        private GridColumn gridColumn4;

        private GridView gridView3;

        private DefaultLookAndFeel defaultLookAndFeel1;

        private SimpleButton btnBorrarCliente;

        private SimpleButton frmEditarArticulo;
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
            this.btnNuevoCliente = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridCliente = new DevExpress.XtraGrid.GridControl();
            this.viewCliente = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.btnBorrarCliente = new DevExpress.XtraEditors.SimpleButton();
            this.frmEditarArticulo = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoCliente.Appearance.Options.UseFont = true;
            this.btnNuevoCliente.Appearance.Options.UseTextOptions = true;
            this.btnNuevoCliente.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnNuevoCliente.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnNuevoCliente.Location = new System.Drawing.Point(30, 88);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(77, 24);
            this.btnNuevoCliente.TabIndex = 45;
            this.btnNuevoCliente.Text = "Nuevo";
            this.btnNuevoCliente.ToolTip = "Le permite al usuario añadir un nuevo articulo al Inventario.";
            this.btnNuevoCliente.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btnNuevoCliente.ToolTipTitle = "Nuevo";
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(30, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(105, 45);
            this.labelControl1.TabIndex = 44;
            this.labelControl1.Text = "Clientes";
            // 
            // gridCliente
            // 
            this.gridCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridCliente.Location = new System.Drawing.Point(30, 118);
            this.gridCliente.MainView = this.viewCliente;
            this.gridCliente.Name = "gridCliente";
            this.gridCliente.Size = new System.Drawing.Size(1213, 544);
            this.gridCliente.TabIndex = 43;
            this.gridCliente.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewCliente,
            this.gridView3});
            this.gridCliente.DoubleClick += new System.EventHandler(this.gridCliente_DoubleClick);
            // 
            // viewCliente
            // 
            this.viewCliente.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCliente.Appearance.HeaderPanel.Options.UseFont = true;
            this.viewCliente.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCliente.Appearance.Row.Options.UseFont = true;
            this.viewCliente.ColumnPanelRowHeight = 30;
            this.viewCliente.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn4,
            this.gridColumn1,
            this.gridColumn3,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.viewCliente.GridControl = this.gridCliente;
            this.viewCliente.Name = "viewCliente";
            this.viewCliente.OptionsBehavior.Editable = false;
            this.viewCliente.OptionsFind.AlwaysVisible = true;
            this.viewCliente.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.viewCliente.RowHeight = 30;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "ID";
            this.gridColumn2.FieldName = "id_cliente";
            this.gridColumn2.MaxWidth = 300;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn2.Width = 45;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Nombre";
            this.gridColumn4.FieldName = "nombre";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            this.gridColumn4.Width = 320;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Sector";
            this.gridColumn1.FieldName = "sector";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 139;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Razon Social";
            this.gridColumn3.FieldName = "razon_social";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 153;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Telefono";
            this.gridColumn5.FieldName = "telefono";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 158;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Codigo";
            this.gridColumn6.FieldName = "codigo";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 0;
            this.gridColumn6.Width = 116;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Descripcion";
            this.gridColumn7.FieldName = "descripcion";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 5;
            this.gridColumn7.Width = 309;
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.gridCliente;
            this.gridView3.Name = "gridView3";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "DevExpress Dark Style";
            // 
            // btnBorrarCliente
            // 
            this.btnBorrarCliente.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarCliente.Appearance.Options.UseFont = true;
            this.btnBorrarCliente.Appearance.Options.UseTextOptions = true;
            this.btnBorrarCliente.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnBorrarCliente.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnBorrarCliente.Location = new System.Drawing.Point(196, 88);
            this.btnBorrarCliente.Name = "btnBorrarCliente";
            this.btnBorrarCliente.Size = new System.Drawing.Size(77, 24);
            this.btnBorrarCliente.TabIndex = 50;
            this.btnBorrarCliente.Text = "Borrar";
            this.btnBorrarCliente.ToolTip = "Le permite al usuario añadir un nuevo articulo al Inventario.";
            this.btnBorrarCliente.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btnBorrarCliente.ToolTipTitle = "Nuevo";
            // 
            // frmEditarArticulo
            // 
            this.frmEditarArticulo.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmEditarArticulo.Appearance.Options.UseFont = true;
            this.frmEditarArticulo.Appearance.Options.UseTextOptions = true;
            this.frmEditarArticulo.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.frmEditarArticulo.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.frmEditarArticulo.Location = new System.Drawing.Point(113, 88);
            this.frmEditarArticulo.Name = "frmEditarArticulo";
            this.frmEditarArticulo.Size = new System.Drawing.Size(77, 24);
            this.frmEditarArticulo.TabIndex = 49;
            this.frmEditarArticulo.Text = "Editar";
            this.frmEditarArticulo.ToolTip = "Le permite al usuario añadir un nuevo articulo al Inventario.";
            this.frmEditarArticulo.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.frmEditarArticulo.ToolTipTitle = "Agregar";
            this.frmEditarArticulo.Click += new System.EventHandler(this.frmEditarArticulo_Click);
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 691);
            this.Controls.Add(this.btnBorrarCliente);
            this.Controls.Add(this.frmEditarArticulo);
            this.Controls.Add(this.btnNuevoCliente);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridCliente);
            this.Name = "FrmClientes";
            this.Text = "Catalogo de Clientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GridColumn gridColumn1;
        private GridColumn gridColumn3;
        private GridColumn gridColumn5;
        private GridColumn gridColumn6;
        private GridColumn gridColumn7;
    }
}