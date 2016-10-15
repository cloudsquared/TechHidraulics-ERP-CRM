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
using DevExpress.XtraGrid.Views.Base;

namespace TechHidraulics_ERP_CRM.Empleados
{
    partial class FrmEmpleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private GridControl gridEmpleado;

        private GridView viewEmpleado;

        private GridColumn gridColumn1;

        private GridColumn gridColumn2;

        private GridColumn gridColumn3;

        private GridColumn gridColumn4;

        private GridColumn gridColumn5;

        private LabelControl labelControl5;

        private SimpleButton btnNuevoEmpleado;

        private GridColumn columtelefono;

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

        private void InitializeComponent()
        {
            this.gridEmpleado = new DevExpress.XtraGrid.GridControl();
            this.viewEmpleado = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columtelefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnNuevoEmpleado = new DevExpress.XtraEditors.SimpleButton();
            this.btnBorrarEmpleado = new DevExpress.XtraEditors.SimpleButton();
            this.frmEditarEmpleado = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // gridEmpleado
            // 
            this.gridEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridEmpleado.Location = new System.Drawing.Point(18, 127);
            this.gridEmpleado.MainView = this.viewEmpleado;
            this.gridEmpleado.Name = "gridEmpleado";
            this.gridEmpleado.Size = new System.Drawing.Size(937, 541);
            this.gridEmpleado.TabIndex = 1;
            this.gridEmpleado.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewEmpleado});
            this.gridEmpleado.DoubleClick += new System.EventHandler(this.gridEmpleado_DoubleClick);
            // 
            // viewEmpleado
            // 
            this.viewEmpleado.ColumnPanelRowHeight = 30;
            this.viewEmpleado.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.columtelefono});
            this.viewEmpleado.GridControl = this.gridEmpleado;
            this.viewEmpleado.Name = "viewEmpleado";
            this.viewEmpleado.OptionsBehavior.Editable = false;
            this.viewEmpleado.OptionsFind.AlwaysVisible = true;
            this.viewEmpleado.RowHeight = 26;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "id_empleado";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 58;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Nombre";
            this.gridColumn2.FieldName = "nombre";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 120;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Apellido";
            this.gridColumn3.FieldName = "apellido";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 159;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Direccion";
            this.gridColumn4.FieldName = "direccion";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 168;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "RFC";
            this.gridColumn5.FieldName = "rfc";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 140;
            // 
            // columtelefono
            // 
            this.columtelefono.Caption = "Telefono";
            this.columtelefono.FieldName = "telefono";
            this.columtelefono.Name = "columtelefono";
            this.columtelefono.Visible = true;
            this.columtelefono.VisibleIndex = 5;
            this.columtelefono.Width = 251;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(18, 28);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(147, 45);
            this.labelControl5.TabIndex = 40;
            this.labelControl5.Text = "Empleados";
            // 
            // btnNuevoEmpleado
            // 
            this.btnNuevoEmpleado.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoEmpleado.Appearance.Options.UseFont = true;
            this.btnNuevoEmpleado.Appearance.Options.UseTextOptions = true;
            this.btnNuevoEmpleado.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnNuevoEmpleado.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnNuevoEmpleado.Location = new System.Drawing.Point(18, 97);
            this.btnNuevoEmpleado.Name = "btnNuevoEmpleado";
            this.btnNuevoEmpleado.Size = new System.Drawing.Size(77, 24);
            this.btnNuevoEmpleado.TabIndex = 50;
            this.btnNuevoEmpleado.Text = "Nuevo";
            this.btnNuevoEmpleado.ToolTip = "Le permite al usuario añadir un nuevo empleado a la base de datos.";
            this.btnNuevoEmpleado.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btnNuevoEmpleado.ToolTipTitle = "Nuevo";
            this.btnNuevoEmpleado.Click += new System.EventHandler(this.btnNuevoEmpleado_Click);
            // 
            // btnBorrarEmpleado
            // 
            this.btnBorrarEmpleado.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarEmpleado.Appearance.Options.UseFont = true;
            this.btnBorrarEmpleado.Appearance.Options.UseTextOptions = true;
            this.btnBorrarEmpleado.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnBorrarEmpleado.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnBorrarEmpleado.Location = new System.Drawing.Point(184, 97);
            this.btnBorrarEmpleado.Name = "btnBorrarEmpleado";
            this.btnBorrarEmpleado.Size = new System.Drawing.Size(77, 24);
            this.btnBorrarEmpleado.TabIndex = 52;
            this.btnBorrarEmpleado.Text = "Borrar";
            this.btnBorrarEmpleado.ToolTip = "Le permite al usuario añadir un nuevo articulo al Inventario.";
            this.btnBorrarEmpleado.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btnBorrarEmpleado.ToolTipTitle = "Nuevo";
            // 
            // frmEditarEmpleado
            // 
            this.frmEditarEmpleado.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmEditarEmpleado.Appearance.Options.UseFont = true;
            this.frmEditarEmpleado.Appearance.Options.UseTextOptions = true;
            this.frmEditarEmpleado.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.frmEditarEmpleado.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.frmEditarEmpleado.Location = new System.Drawing.Point(101, 97);
            this.frmEditarEmpleado.Name = "frmEditarEmpleado";
            this.frmEditarEmpleado.Size = new System.Drawing.Size(77, 24);
            this.frmEditarEmpleado.TabIndex = 51;
            this.frmEditarEmpleado.Text = "Editar";
            this.frmEditarEmpleado.ToolTip = "Le permite al usuario añadir un nuevo articulo al Inventario.";
            this.frmEditarEmpleado.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.frmEditarEmpleado.ToolTipTitle = "Agregar";
            this.frmEditarEmpleado.Click += new System.EventHandler(this.frmEditarEmpleado_Click);
            // 
            // FrmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 680);
            this.Controls.Add(this.btnBorrarEmpleado);
            this.Controls.Add(this.frmEditarEmpleado);
            this.Controls.Add(this.btnNuevoEmpleado);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.gridEmpleado);
            this.Name = "FrmEmpleados";
            this.Text = "Catalogo Empleados";
            this.Load += new System.EventHandler(this.FrmEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private SimpleButton btnBorrarEmpleado;
        private SimpleButton frmEditarEmpleado;
    }
}