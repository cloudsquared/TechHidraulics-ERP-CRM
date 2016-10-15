using DevExpress.Utils;
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
    partial class FrmAsignarArticulo
    {

        private IContainer components = null;

        private LabelControl labelControl9;

        private ComboBoxEdit cbxArticulo;

        private TextEdit txtPrecio;

        private LabelControl labelControl1;

        private LabelControl labelControl2;

        private TextEdit txtTotal;

        private LabelControl labelControl4;

        public SimpleButton btnCancelar;

        public SimpleButton btnAnadir;

        private SimpleButton frmBuscarArticulo;

        private SpinEdit spinCantidad;

        private SimpleButton btnAgregar;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        /// 

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
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.cbxArticulo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtPrecio = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTotal = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAnadir = new DevExpress.XtraEditors.SimpleButton();
            this.spinCantidad = new DevExpress.XtraEditors.SpinEdit();
            this.frmBuscarArticulo = new DevExpress.XtraEditors.SimpleButton();
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.cbxArticulo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinCantidad.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Location = new System.Drawing.Point(25, 27);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(49, 18);
            this.labelControl9.TabIndex = 32;
            this.labelControl9.Text = "Articulo";
            // 
            // cbxArticulo
            // 
            this.cbxArticulo.EditValue = "";
            this.cbxArticulo.Location = new System.Drawing.Point(92, 24);
            this.cbxArticulo.Name = "cbxArticulo";
            this.cbxArticulo.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxArticulo.Properties.Appearance.Options.UseFont = true;
            this.cbxArticulo.Properties.Appearance.Options.UseTextOptions = true;
            this.cbxArticulo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cbxArticulo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxArticulo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbxArticulo.Size = new System.Drawing.Size(197, 24);
            this.cbxArticulo.TabIndex = 31;
            this.cbxArticulo.SelectedIndexChanged += new System.EventHandler(this.cbxArticulo_SelectedIndexChanged);
            // 
            // txtPrecio
            // 
            this.txtPrecio.EditValue = "0";
            this.txtPrecio.Location = new System.Drawing.Point(92, 63);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Properties.Appearance.Options.UseFont = true;
            this.txtPrecio.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPrecio.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtPrecio.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPrecio.Properties.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(84, 24);
            this.txtPrecio.TabIndex = 36;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(25, 66);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(39, 18);
            this.labelControl1.TabIndex = 35;
            this.labelControl1.Text = "Precio";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(25, 93);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(55, 18);
            this.labelControl2.TabIndex = 37;
            this.labelControl2.Text = "Cantidad";
            // 
            // txtTotal
            // 
            this.txtTotal.EditValue = "0";
            this.txtTotal.Location = new System.Drawing.Point(92, 123);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Properties.Appearance.Options.UseFont = true;
            this.txtTotal.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTotal.Properties.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(84, 24);
            this.txtTotal.TabIndex = 40;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(25, 126);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(31, 18);
            this.labelControl4.TabIndex = 39;
            this.labelControl4.Text = "Total";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Appearance.Options.UseFont = true;
            this.btnCancelar.Appearance.Options.UseTextOptions = true;
            this.btnCancelar.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnCancelar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(168, 170);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 26);
            this.btnCancelar.TabIndex = 44;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.ToolTip = "Le permite al usuario añadir un nuevo articulo al Inventario.";
            this.btnCancelar.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btnCancelar.ToolTipTitle = "Agregar";
            // 
            // btnAnadir
            // 
            this.btnAnadir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnadir.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadir.Appearance.Options.UseFont = true;
            this.btnAnadir.Appearance.Options.UseTextOptions = true;
            this.btnAnadir.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnAnadir.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnAnadir.Location = new System.Drawing.Point(266, 170);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(92, 26);
            this.btnAnadir.TabIndex = 43;
            this.btnAnadir.Text = "Aceptar";
            this.btnAnadir.ToolTip = "Le permite al usuario añadir un nuevo articulo al Inventario.";
            this.btnAnadir.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btnAnadir.ToolTipTitle = "Agregar";
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // spinCantidad
            // 
            this.spinCantidad.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinCantidad.Location = new System.Drawing.Point(92, 93);
            this.spinCantidad.Name = "spinCantidad";
            this.spinCantidad.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.spinCantidad.Properties.Appearance.Options.UseFont = true;
            this.spinCantidad.Properties.Appearance.Options.UseTextOptions = true;
            this.spinCantidad.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.spinCantidad.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinCantidad.Size = new System.Drawing.Size(100, 24);
            this.spinCantidad.TabIndex = 46;
            this.spinCantidad.EditValueChanged += new System.EventHandler(this.spinCantidad_EditValueChanged);
            // 
            // frmBuscarArticulo
            // 
            this.frmBuscarArticulo.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.frmBuscarArticulo.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.frmBuscarArticulo.Location = new System.Drawing.Point(295, 25);
            this.frmBuscarArticulo.Name = "frmBuscarArticulo";
            this.frmBuscarArticulo.Size = new System.Drawing.Size(29, 23);
            this.frmBuscarArticulo.TabIndex = 45;
            // 
            // btnAgregar
            // 
            this.btnAgregar.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnAgregar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAgregar.Location = new System.Drawing.Point(330, 25);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(29, 23);
            this.btnAgregar.TabIndex = 47;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // FrmAsignarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 211);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.spinCantidad);
            this.Controls.Add(this.frmBuscarArticulo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAnadir);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.cbxArticulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAsignarArticulo";
            this.Text = "Agregar Articulo";
            this.Load += new System.EventHandler(this.frmAsignarArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbxArticulo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinCantidad.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}