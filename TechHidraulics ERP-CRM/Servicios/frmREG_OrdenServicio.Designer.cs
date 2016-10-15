using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using DevExpress.XtraTab;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace TechHidraulics_ERP_CRM.Servicios
{
    partial class FrmRegOrdenServicio
    {


        private LabelControl labelControl19;

        private LabelControl labelControl6;

        private DateEdit dateCompromiso;

        private LabelControl labelControl15;

        private LabelControl labelControl14;

        private ComboBoxEdit cbxAutor;

        private ComboBoxEdit cbxResponsable;

        private LabelControl labelControl16;

        private DateEdit dateElaboracion;

        private LabelControl labelControl3;

        private TextEdit txtNumeroOrden;

        private MemoEdit memoConcepto;

        private LabelControl labelControl1;

        private SimpleButton btnVehiculo;

        private LabelControl labelControl17;

        private SimpleButton btnAgregarServicio;

        private XtraTabControl xtraTabControl1;

        private XtraTabPage xtraTabPage1;

        private XtraTabPage xtraTabPage2;

        private GroupControl groupControl1;

        private TextEdit txtNumeroEconomico;

        private LabelControl labelControl11;

        private TextEdit txtKilometraje;

        private LabelControl labelControl2;

        private LabelControl labelControl10;

        private TextEdit txtMarca;

        private TextEdit txtModelo;

        private LabelControl labelControl4;

        private LabelControl labelControl9;

        private TextEdit txtTipo;

        private TextEdit txtNumero_aviso;

        private LabelControl labelControl5;

        private LabelControl labelControl8;

        private TextEdit txtPlacas;

        private TextEdit txtSubmarca;

        private LabelControl labelControl7;

        private SimpleButton btnCancelar;

        private SimpleButton btnAceptar;

        private GridControl gridServiciosBasicos;

        private GridView viewServicios;

        private GridColumn gridColumn1;

        private GridColumn gridColumn2;

        private GridColumn gridColumn4;

        private GridColumn gridColumn5;

        private GridColumn gridColumn6;

        private TextEdit txtTotal;

        private LabelControl labelControl24;

        private LabelControl labelControl21;

        private TextEdit txtServicios;

        private LabelControl labelControl22;

        private TextEdit txtUtilidad;

        private LabelControl labelControl23;

        private BarManager barManager1;

        private Bar bar2;

        private BarSubItem barSubItem1;

        private BarButtonItem btnImprimir;

        private BarButtonItem barButtonItem2;

        private BarDockControl barDockControlTop;

        private BarDockControl barDockControlBottom;

        private BarDockControl barDockControlLeft;

        private BarDockControl barDockControlRight;

        private LabelControl labelControl25;

        private DateEdit dateComienzo;

        private LabelControl labelControl26;

        private TextEdit txtDias;

        private LabelControl labelControl27;

        private SimpleButton btnPrevizualizar;

        private MemoEdit txtDireccion;

        private TextEdit txtTelefono;

        private LabelControl labelControl12;

        private LabelControl labelControl13;

        private LabelControl labelControl28;

        private SimpleButton btnBuscarCliente;

        private ComboBoxEdit cbxCliente;

        private TextEdit txtTotalAcumulado;

        private LabelControl labelControl29;

        private TextEdit txtImpuesto;

        private LabelControl labelControl18;

        private LabelControl lblIDVehiculo;
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
            this.components = new System.ComponentModel.Container();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.dateCompromiso = new DevExpress.XtraEditors.DateEdit();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.cbxAutor = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbxResponsable = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.dateElaboracion = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtNumeroOrden = new DevExpress.XtraEditors.TextEdit();
            this.memoConcepto = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.btnVehiculo = new DevExpress.XtraEditors.SimpleButton();
            this.btnAgregarServicio = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.memNotas = new DevExpress.XtraEditors.MemoEdit();
            this.cbxCliente = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnBuscarCliente = new DevExpress.XtraEditors.SimpleButton();
            this.txtDireccion = new DevExpress.XtraEditors.MemoEdit();
            this.txtTelefono = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl28 = new DevExpress.XtraEditors.LabelControl();
            this.txtDias = new DevExpress.XtraEditors.TextEdit();
            this.labelControl27 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl26 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lblIDVehiculo = new DevExpress.XtraEditors.LabelControl();
            this.txtNumeroEconomico = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtKilometraje = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtMarca = new DevExpress.XtraEditors.TextEdit();
            this.txtModelo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtTipo = new DevExpress.XtraEditors.TextEdit();
            this.txtNumero_aviso = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtPlacas = new DevExpress.XtraEditors.TextEdit();
            this.txtSubmarca = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.txtTotalAcumulado = new DevExpress.XtraEditors.TextEdit();
            this.labelControl29 = new DevExpress.XtraEditors.LabelControl();
            this.txtImpuesto = new DevExpress.XtraEditors.TextEdit();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.txtTotal = new DevExpress.XtraEditors.TextEdit();
            this.labelControl24 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl21 = new DevExpress.XtraEditors.LabelControl();
            this.txtServicios = new DevExpress.XtraEditors.TextEdit();
            this.labelControl22 = new DevExpress.XtraEditors.LabelControl();
            this.txtUtilidad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl23 = new DevExpress.XtraEditors.LabelControl();
            this.gridServiciosBasicos = new DevExpress.XtraGrid.GridControl();
            this.viewServicios = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAceptar = new DevExpress.XtraEditors.SimpleButton();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.btnImprimir = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.labelControl25 = new DevExpress.XtraEditors.LabelControl();
            this.dateComienzo = new DevExpress.XtraEditors.DateEdit();
            this.btnPrevizualizar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dateCompromiso.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCompromiso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxAutor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxResponsable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateElaboracion.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateElaboracion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroOrden.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoConcepto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memNotas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDias.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroEconomico.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKilometraje.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarca.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModelo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero_aviso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlacas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubmarca.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalAcumulado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImpuesto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServicios.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUtilidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridServiciosBasicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewServicios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateComienzo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateComienzo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl19
            // 
            this.labelControl19.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl19.Location = new System.Drawing.Point(37, 28);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(45, 18);
            this.labelControl19.TabIndex = 70;
            this.labelControl19.Text = "Cliente";
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(778, 62);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(126, 18);
            this.labelControl6.TabIndex = 68;
            this.labelControl6.Text = "Fecha de aprovacion";
            // 
            // dateCompromiso
            // 
            this.dateCompromiso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateCompromiso.EditValue = null;
            this.dateCompromiso.Location = new System.Drawing.Point(912, 89);
            this.dateCompromiso.Name = "dateCompromiso";
            this.dateCompromiso.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCompromiso.Properties.Appearance.Options.UseFont = true;
            this.dateCompromiso.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateCompromiso.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateCompromiso.Size = new System.Drawing.Size(199, 24);
            this.dateCompromiso.TabIndex = 67;
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl15.Location = new System.Drawing.Point(475, 28);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(108, 18);
            this.labelControl15.TabIndex = 66;
            this.labelControl15.Text = "Autor de la orden";
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl14.Location = new System.Drawing.Point(475, 58);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(79, 18);
            this.labelControl14.TabIndex = 63;
            this.labelControl14.Text = "Responsable";
            // 
            // cbxAutor
            // 
            this.cbxAutor.Location = new System.Drawing.Point(598, 25);
            this.cbxAutor.Name = "cbxAutor";
            this.cbxAutor.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAutor.Properties.Appearance.Options.UseFont = true;
            this.cbxAutor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxAutor.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbxAutor.Size = new System.Drawing.Size(192, 24);
            this.cbxAutor.TabIndex = 65;
            // 
            // cbxResponsable
            // 
            this.cbxResponsable.Location = new System.Drawing.Point(598, 55);
            this.cbxResponsable.Name = "cbxResponsable";
            this.cbxResponsable.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxResponsable.Properties.Appearance.Options.UseFont = true;
            this.cbxResponsable.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxResponsable.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbxResponsable.Size = new System.Drawing.Size(192, 24);
            this.cbxResponsable.TabIndex = 64;
            // 
            // labelControl16
            // 
            this.labelControl16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl16.Location = new System.Drawing.Point(773, 32);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(131, 18);
            this.labelControl16.TabIndex = 62;
            this.labelControl16.Text = "Fecha de elaboracion";
            // 
            // dateElaboracion
            // 
            this.dateElaboracion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateElaboracion.EditValue = null;
            this.dateElaboracion.Location = new System.Drawing.Point(912, 29);
            this.dateElaboracion.Name = "dateElaboracion";
            this.dateElaboracion.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateElaboracion.Properties.Appearance.Options.UseFont = true;
            this.dateElaboracion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateElaboracion.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateElaboracion.Size = new System.Drawing.Size(199, 24);
            this.dateElaboracion.TabIndex = 61;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(37, 62);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(112, 18);
            this.labelControl3.TabIndex = 60;
            this.labelControl3.Text = "Numero de Orden";
            // 
            // txtNumeroOrden
            // 
            this.txtNumeroOrden.Location = new System.Drawing.Point(177, 59);
            this.txtNumeroOrden.Name = "txtNumeroOrden";
            this.txtNumeroOrden.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroOrden.Properties.Appearance.Options.UseFont = true;
            this.txtNumeroOrden.Properties.Mask.BeepOnError = true;
            this.txtNumeroOrden.Properties.Mask.EditMask = "f0";
            this.txtNumeroOrden.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtNumeroOrden.Size = new System.Drawing.Size(176, 24);
            this.txtNumeroOrden.TabIndex = 59;
            // 
            // memoConcepto
            // 
            this.memoConcepto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.memoConcepto.Location = new System.Drawing.Point(598, 89);
            this.memoConcepto.Name = "memoConcepto";
            this.memoConcepto.Size = new System.Drawing.Size(454, 52);
            this.memoConcepto.TabIndex = 58;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(475, 90);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 18);
            this.labelControl1.TabIndex = 57;
            this.labelControl1.Text = "Concepto";
            // 
            // labelControl17
            // 
            this.labelControl17.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl17.Location = new System.Drawing.Point(111, 83);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(0, 18);
            this.labelControl17.TabIndex = 72;
            // 
            // btnVehiculo
            // 
            this.btnVehiculo.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnVehiculo.Location = new System.Drawing.Point(37, 265);
            this.btnVehiculo.Name = "btnVehiculo";
            this.btnVehiculo.Size = new System.Drawing.Size(115, 24);
            this.btnVehiculo.TabIndex = 71;
            this.btnVehiculo.Text = "Buscar Vehiculo";
            // 
            // btnAgregarServicio
            // 
            this.btnAgregarServicio.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnAgregarServicio.Location = new System.Drawing.Point(18, 20);
            this.btnAgregarServicio.Name = "btnAgregarServicio";
            this.btnAgregarServicio.Size = new System.Drawing.Size(103, 29);
            this.btnAgregarServicio.TabIndex = 77;
            this.btnAgregarServicio.Text = " Añadir servicio";
            this.btnAgregarServicio.Click += new System.EventHandler(this.btnAgregarServicio_Click);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(28, 119);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1088, 527);
            this.xtraTabControl1.TabIndex = 82;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.labelControl20);
            this.xtraTabPage1.Controls.Add(this.memNotas);
            this.xtraTabPage1.Controls.Add(this.cbxCliente);
            this.xtraTabPage1.Controls.Add(this.btnBuscarCliente);
            this.xtraTabPage1.Controls.Add(this.txtDireccion);
            this.xtraTabPage1.Controls.Add(this.txtTelefono);
            this.xtraTabPage1.Controls.Add(this.labelControl12);
            this.xtraTabPage1.Controls.Add(this.labelControl13);
            this.xtraTabPage1.Controls.Add(this.labelControl28);
            this.xtraTabPage1.Controls.Add(this.txtDias);
            this.xtraTabPage1.Controls.Add(this.labelControl27);
            this.xtraTabPage1.Controls.Add(this.labelControl26);
            this.xtraTabPage1.Controls.Add(this.groupControl1);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.memoConcepto);
            this.xtraTabPage1.Controls.Add(this.btnVehiculo);
            this.xtraTabPage1.Controls.Add(this.cbxResponsable);
            this.xtraTabPage1.Controls.Add(this.cbxAutor);
            this.xtraTabPage1.Controls.Add(this.labelControl14);
            this.xtraTabPage1.Controls.Add(this.labelControl15);
            this.xtraTabPage1.Controls.Add(this.labelControl19);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1082, 499);
            this.xtraTabPage1.Text = "Informacion de la Orden";
            // 
            // labelControl20
            // 
            this.labelControl20.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl20.Location = new System.Drawing.Point(475, 148);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(36, 18);
            this.labelControl20.TabIndex = 112;
            this.labelControl20.Text = "Notas";
            // 
            // memNotas
            // 
            this.memNotas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.memNotas.Location = new System.Drawing.Point(598, 147);
            this.memNotas.Name = "memNotas";
            this.memNotas.Size = new System.Drawing.Size(454, 52);
            this.memNotas.TabIndex = 113;
            // 
            // cbxCliente
            // 
            this.cbxCliente.Location = new System.Drawing.Point(148, 24);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCliente.Properties.Appearance.Options.UseFont = true;
            this.cbxCliente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxCliente.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbxCliente.Size = new System.Drawing.Size(248, 24);
            this.cbxCliente.TabIndex = 111;
            this.cbxCliente.SelectedIndexChanged += new System.EventHandler(this.cbxCliente_SelectedIndexChanged);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.Appearance.Options.UseFont = true;
            this.btnBuscarCliente.Enabled = false;
            this.btnBuscarCliente.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnBuscarCliente.Location = new System.Drawing.Point(402, 24);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(24, 24);
            this.btnBuscarCliente.TabIndex = 110;
            this.btnBuscarCliente.Text = "+";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(148, 89);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(311, 52);
            this.txtDireccion.TabIndex = 109;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(148, 55);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Properties.Appearance.Options.UseFont = true;
            this.txtTelefono.Size = new System.Drawing.Size(278, 24);
            this.txtTelefono.TabIndex = 103;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Location = new System.Drawing.Point(131, 98);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(0, 18);
            this.labelControl12.TabIndex = 102;
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Location = new System.Drawing.Point(37, 58);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(56, 18);
            this.labelControl13.TabIndex = 106;
            this.labelControl13.Text = "Telefono";
            // 
            // labelControl28
            // 
            this.labelControl28.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl28.Location = new System.Drawing.Point(37, 88);
            this.labelControl28.Name = "labelControl28";
            this.labelControl28.Size = new System.Drawing.Size(58, 18);
            this.labelControl28.TabIndex = 108;
            this.labelControl28.Text = "Direccion";
            // 
            // txtDias
            // 
            this.txtDias.EditValue = "0";
            this.txtDias.Location = new System.Drawing.Point(148, 147);
            this.txtDias.Name = "txtDias";
            this.txtDias.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDias.Properties.Appearance.Options.UseFont = true;
            this.txtDias.Properties.Appearance.Options.UseTextOptions = true;
            this.txtDias.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtDias.Properties.Mask.EditMask = "d";
            this.txtDias.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDias.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtDias.Size = new System.Drawing.Size(55, 24);
            this.txtDias.TabIndex = 100;
            this.txtDias.ToolTip = "Dias de credito del cliente";
            // 
            // labelControl27
            // 
            this.labelControl27.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl27.Location = new System.Drawing.Point(37, 150);
            this.labelControl27.Name = "labelControl27";
            this.labelControl27.Size = new System.Drawing.Size(92, 18);
            this.labelControl27.TabIndex = 101;
            this.labelControl27.Text = "Dias de credito";
            // 
            // labelControl26
            // 
            this.labelControl26.Appearance.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl26.Location = new System.Drawing.Point(37, 245);
            this.labelControl26.Name = "labelControl26";
            this.labelControl26.Size = new System.Drawing.Size(450, 14);
            this.labelControl26.TabIndex = 99;
            this.labelControl26.Text = "En caso de que la solicitud de servicio es para un vehiculo registrado, favor de " +
    "seleccionarlo.";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.lblIDVehiculo);
            this.groupControl1.Controls.Add(this.txtNumeroEconomico);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.labelControl17);
            this.groupControl1.Controls.Add(this.txtKilometraje);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.txtMarca);
            this.groupControl1.Controls.Add(this.txtModelo);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.txtTipo);
            this.groupControl1.Controls.Add(this.txtNumero_aviso);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.txtPlacas);
            this.groupControl1.Controls.Add(this.txtSubmarca);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Location = new System.Drawing.Point(37, 295);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1020, 170);
            this.groupControl1.TabIndex = 98;
            this.groupControl1.Text = "Vehiculo seleccionado (Esta informacion no se puede editar)";
            // 
            // lblIDVehiculo
            // 
            this.lblIDVehiculo.Appearance.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDVehiculo.Location = new System.Drawing.Point(695, 43);
            this.lblIDVehiculo.Name = "lblIDVehiculo";
            this.lblIDVehiculo.Size = new System.Drawing.Size(0, 14);
            this.lblIDVehiculo.TabIndex = 100;
            this.lblIDVehiculo.Visible = false;
            // 
            // txtNumeroEconomico
            // 
            this.txtNumeroEconomico.Location = new System.Drawing.Point(156, 40);
            this.txtNumeroEconomico.Name = "txtNumeroEconomico";
            this.txtNumeroEconomico.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroEconomico.Properties.Appearance.Options.UseFont = true;
            this.txtNumeroEconomico.Properties.ReadOnly = true;
            this.txtNumeroEconomico.Size = new System.Drawing.Size(181, 24);
            this.txtNumeroEconomico.TabIndex = 82;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Location = new System.Drawing.Point(358, 73);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(77, 18);
            this.labelControl11.TabIndex = 97;
            this.labelControl11.Text = "Kilometraje:";
            // 
            // txtKilometraje
            // 
            this.txtKilometraje.Location = new System.Drawing.Point(479, 70);
            this.txtKilometraje.Name = "txtKilometraje";
            this.txtKilometraje.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKilometraje.Properties.Appearance.Options.UseFont = true;
            this.txtKilometraje.Properties.ReadOnly = true;
            this.txtKilometraje.Size = new System.Drawing.Size(188, 24);
            this.txtKilometraje.TabIndex = 89;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(22, 43);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(126, 18);
            this.labelControl2.TabIndex = 90;
            this.labelControl2.Text = "Numero economico:";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Location = new System.Drawing.Point(22, 103);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(52, 18);
            this.labelControl10.TabIndex = 96;
            this.labelControl10.Text = "Modelo:";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(156, 130);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Properties.Appearance.Options.UseFont = true;
            this.txtMarca.Properties.ReadOnly = true;
            this.txtMarca.Size = new System.Drawing.Size(181, 24);
            this.txtMarca.TabIndex = 85;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(156, 100);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.Properties.Appearance.Options.UseFont = true;
            this.txtModelo.Properties.ReadOnly = true;
            this.txtModelo.Size = new System.Drawing.Size(181, 24);
            this.txtModelo.TabIndex = 84;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(22, 133);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(41, 18);
            this.labelControl4.TabIndex = 91;
            this.labelControl4.Text = "Marca:";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Location = new System.Drawing.Point(358, 133);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(109, 18);
            this.labelControl9.TabIndex = 95;
            this.labelControl9.Text = "Numero de aviso:";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(479, 100);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo.Properties.Appearance.Options.UseFont = true;
            this.txtTipo.Properties.ReadOnly = true;
            this.txtTipo.Size = new System.Drawing.Size(188, 24);
            this.txtTipo.TabIndex = 87;
            // 
            // txtNumero_aviso
            // 
            this.txtNumero_aviso.Location = new System.Drawing.Point(479, 130);
            this.txtNumero_aviso.Name = "txtNumero_aviso";
            this.txtNumero_aviso.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero_aviso.Properties.Appearance.Options.UseFont = true;
            this.txtNumero_aviso.Properties.ReadOnly = true;
            this.txtNumero_aviso.Size = new System.Drawing.Size(188, 24);
            this.txtNumero_aviso.TabIndex = 88;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(358, 100);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(31, 18);
            this.labelControl5.TabIndex = 92;
            this.labelControl5.Text = "Tipo:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Location = new System.Drawing.Point(358, 43);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(64, 18);
            this.labelControl8.TabIndex = 94;
            this.labelControl8.Text = "Submarca:";
            // 
            // txtPlacas
            // 
            this.txtPlacas.Location = new System.Drawing.Point(156, 70);
            this.txtPlacas.Name = "txtPlacas";
            this.txtPlacas.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlacas.Properties.Appearance.Options.UseFont = true;
            this.txtPlacas.Properties.ReadOnly = true;
            this.txtPlacas.Size = new System.Drawing.Size(181, 24);
            this.txtPlacas.TabIndex = 83;
            // 
            // txtSubmarca
            // 
            this.txtSubmarca.Location = new System.Drawing.Point(479, 40);
            this.txtSubmarca.Name = "txtSubmarca";
            this.txtSubmarca.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubmarca.Properties.Appearance.Options.UseFont = true;
            this.txtSubmarca.Properties.ReadOnly = true;
            this.txtSubmarca.Size = new System.Drawing.Size(188, 24);
            this.txtSubmarca.TabIndex = 86;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(22, 73);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(42, 18);
            this.labelControl7.TabIndex = 93;
            this.labelControl7.Text = "Placas:";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.txtTotalAcumulado);
            this.xtraTabPage2.Controls.Add(this.labelControl29);
            this.xtraTabPage2.Controls.Add(this.txtImpuesto);
            this.xtraTabPage2.Controls.Add(this.labelControl18);
            this.xtraTabPage2.Controls.Add(this.txtTotal);
            this.xtraTabPage2.Controls.Add(this.labelControl24);
            this.xtraTabPage2.Controls.Add(this.labelControl21);
            this.xtraTabPage2.Controls.Add(this.txtServicios);
            this.xtraTabPage2.Controls.Add(this.labelControl22);
            this.xtraTabPage2.Controls.Add(this.txtUtilidad);
            this.xtraTabPage2.Controls.Add(this.labelControl23);
            this.xtraTabPage2.Controls.Add(this.gridServiciosBasicos);
            this.xtraTabPage2.Controls.Add(this.btnAgregarServicio);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1082, 499);
            this.xtraTabPage2.Text = "Servicios";
            // 
            // txtTotalAcumulado
            // 
            this.txtTotalAcumulado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotalAcumulado.EditValue = "0";
            this.txtTotalAcumulado.Location = new System.Drawing.Point(888, 425);
            this.txtTotalAcumulado.Name = "txtTotalAcumulado";
            this.txtTotalAcumulado.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAcumulado.Properties.Appearance.Options.UseFont = true;
            this.txtTotalAcumulado.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTotalAcumulado.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtTotalAcumulado.Properties.Mask.EditMask = "c";
            this.txtTotalAcumulado.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTotalAcumulado.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtTotalAcumulado.Properties.ReadOnly = true;
            this.txtTotalAcumulado.Size = new System.Drawing.Size(155, 26);
            this.txtTotalAcumulado.TabIndex = 100;
            // 
            // labelControl29
            // 
            this.labelControl29.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl29.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl29.Location = new System.Drawing.Point(945, 403);
            this.labelControl29.Name = "labelControl29";
            this.labelControl29.Size = new System.Drawing.Size(40, 18);
            this.labelControl29.TabIndex = 101;
            this.labelControl29.Text = "TOTAL";
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtImpuesto.EditValue = "0";
            this.txtImpuesto.Location = new System.Drawing.Point(525, 427);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImpuesto.Properties.Appearance.Options.UseFont = true;
            this.txtImpuesto.Properties.Appearance.Options.UseTextOptions = true;
            this.txtImpuesto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtImpuesto.Properties.Mask.EditMask = "c";
            this.txtImpuesto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtImpuesto.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtImpuesto.Properties.ReadOnly = true;
            this.txtImpuesto.Size = new System.Drawing.Size(155, 24);
            this.txtImpuesto.TabIndex = 98;
            // 
            // labelControl18
            // 
            this.labelControl18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl18.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl18.Location = new System.Drawing.Point(560, 403);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(87, 18);
            this.labelControl18.TabIndex = 99;
            this.labelControl18.Text = "Impuesto 16%";
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotal.EditValue = "0";
            this.txtTotal.Location = new System.Drawing.Point(354, 427);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Properties.Appearance.Options.UseFont = true;
            this.txtTotal.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtTotal.Properties.Mask.EditMask = "c";
            this.txtTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTotal.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtTotal.Properties.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(155, 24);
            this.txtTotal.TabIndex = 96;
            // 
            // labelControl24
            // 
            this.labelControl24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl24.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl24.Location = new System.Drawing.Point(401, 403);
            this.labelControl24.Name = "labelControl24";
            this.labelControl24.Size = new System.Drawing.Size(52, 18);
            this.labelControl24.TabIndex = 97;
            this.labelControl24.Text = "Subtotal";
            // 
            // labelControl21
            // 
            this.labelControl21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl21.Appearance.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl21.Location = new System.Drawing.Point(222, 454);
            this.labelControl21.Name = "labelControl21";
            this.labelControl21.Size = new System.Drawing.Size(67, 13);
            this.labelControl21.TabIndex = 95;
            this.labelControl21.Text = "Costo sugerido";
            // 
            // txtServicios
            // 
            this.txtServicios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtServicios.EditValue = "0";
            this.txtServicios.Location = new System.Drawing.Point(180, 427);
            this.txtServicios.Name = "txtServicios";
            this.txtServicios.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServicios.Properties.Appearance.Options.UseFont = true;
            this.txtServicios.Properties.Appearance.Options.UseTextOptions = true;
            this.txtServicios.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtServicios.Properties.Mask.EditMask = "c";
            this.txtServicios.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtServicios.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtServicios.Properties.ReadOnly = true;
            this.txtServicios.Size = new System.Drawing.Size(155, 24);
            this.txtServicios.TabIndex = 93;
            // 
            // labelControl22
            // 
            this.labelControl22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl22.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl22.Location = new System.Drawing.Point(192, 403);
            this.labelControl22.Name = "labelControl22";
            this.labelControl22.Size = new System.Drawing.Size(138, 18);
            this.labelControl22.TabIndex = 94;
            this.labelControl22.Text = "Costo total * servicios:";
            // 
            // txtUtilidad
            // 
            this.txtUtilidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtUtilidad.EditValue = "0";
            this.txtUtilidad.Location = new System.Drawing.Point(19, 427);
            this.txtUtilidad.Name = "txtUtilidad";
            this.txtUtilidad.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUtilidad.Properties.Appearance.Options.UseFont = true;
            this.txtUtilidad.Properties.Appearance.Options.UseTextOptions = true;
            this.txtUtilidad.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtUtilidad.Properties.Mask.EditMask = "c";
            this.txtUtilidad.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtUtilidad.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtUtilidad.Size = new System.Drawing.Size(137, 24);
            this.txtUtilidad.TabIndex = 91;
            this.txtUtilidad.EditValueChanged += new System.EventHandler(this.txtUtilidad_EditValueChanged);
            // 
            // labelControl23
            // 
            this.labelControl23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl23.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl23.Location = new System.Drawing.Point(29, 403);
            this.labelControl23.Name = "labelControl23";
            this.labelControl23.Size = new System.Drawing.Size(115, 18);
            this.labelControl23.TabIndex = 92;
            this.labelControl23.Text = "Utilidad solicitada:";
            // 
            // gridServiciosBasicos
            // 
            this.gridServiciosBasicos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridServiciosBasicos.Location = new System.Drawing.Point(18, 57);
            this.gridServiciosBasicos.MainView = this.viewServicios;
            this.gridServiciosBasicos.Name = "gridServiciosBasicos";
            this.gridServiciosBasicos.Size = new System.Drawing.Size(1025, 337);
            this.gridServiciosBasicos.TabIndex = 78;
            this.gridServiciosBasicos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewServicios});
            this.gridServiciosBasicos.ProcessGridKey += new System.Windows.Forms.KeyEventHandler(this.gridServiciosBasicos_ProcessGridKey);
            // 
            // viewServicios
            // 
            this.viewServicios.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewServicios.Appearance.HeaderPanel.Options.UseFont = true;
            this.viewServicios.ColumnPanelRowHeight = 30;
            this.viewServicios.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.viewServicios.CustomizationFormBounds = new System.Drawing.Rectangle(709, 569, 216, 253);
            this.viewServicios.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.viewServicios.GridControl = this.gridServiciosBasicos;
            this.viewServicios.Name = "viewServicios";
            this.viewServicios.OptionsBehavior.Editable = false;
            this.viewServicios.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.viewServicios.OptionsView.ShowGroupPanel = false;
            this.viewServicios.RowHeight = 30;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn1.AppearanceCell.Options.UseFont = true;
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "id_servicio";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 61;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn2.AppearanceCell.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "Servicio";
            this.gridColumn2.FieldName = "nombre";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 510;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn4.AppearanceCell.Options.UseFont = true;
            this.gridColumn4.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.Caption = "Costo MO";
            this.gridColumn4.DisplayFormat.FormatString = "c";
            this.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn4.FieldName = "costo_mo";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 116;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn5.AppearanceCell.Options.UseFont = true;
            this.gridColumn5.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.Caption = "Costo Articulos";
            this.gridColumn5.DisplayFormat.FormatString = "c";
            this.gridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn5.FieldName = "costo_articulo";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            this.gridColumn5.Width = 116;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn6.AppearanceCell.Options.UseFont = true;
            this.gridColumn6.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn6.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn6.Caption = "Costo Total";
            this.gridColumn6.DisplayFormat.FormatString = "c";
            this.gridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn6.FieldName = "costo_total";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            this.gridColumn6.Width = 126;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Appearance.Options.UseFont = true;
            this.btnCancelar.Appearance.Options.UseTextOptions = true;
            this.btnCancelar.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(903, 658);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 30);
            this.btnCancelar.TabIndex = 83;
            this.btnCancelar.Text = "Cancelar";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Appearance.Options.UseFont = true;
            this.btnAceptar.Appearance.Options.UseTextOptions = true;
            this.btnAceptar.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnAceptar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnAceptar.Location = new System.Drawing.Point(1010, 658);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(101, 30);
            this.btnAceptar.TabIndex = 84;
            this.btnAceptar.Text = "Guardar";
            this.btnAceptar.ToolTip = "Guardar orden de servicio";
            this.btnAceptar.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btnAceptar.ToolTipTitle = "Agregar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubItem1,
            this.btnImprimir,
            this.barButtonItem2});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
            // 
            // bar2
            // 
            this.bar2.BarName = "Menú principal";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Menú principal";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Archivo";
            this.barSubItem1.Id = 1;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnImprimir),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Caption = "Imprimir cotizacion";
            this.btnImprimir.Id = 4;
            this.btnImprimir.Name = "btnImprimir";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Salir";
            this.barButtonItem2.Id = 5;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1133, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 710);
            this.barDockControlBottom.Size = new System.Drawing.Size(1133, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 686);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1133, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 686);
            // 
            // labelControl25
            // 
            this.labelControl25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl25.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl25.Location = new System.Drawing.Point(798, 92);
            this.labelControl25.Name = "labelControl25";
            this.labelControl25.Size = new System.Drawing.Size(106, 18);
            this.labelControl25.TabIndex = 90;
            this.labelControl25.Text = "Fecha de entrega";
            // 
            // dateComienzo
            // 
            this.dateComienzo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateComienzo.EditValue = null;
            this.dateComienzo.Location = new System.Drawing.Point(912, 59);
            this.dateComienzo.Name = "dateComienzo";
            this.dateComienzo.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateComienzo.Properties.Appearance.Options.UseFont = true;
            this.dateComienzo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateComienzo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateComienzo.Size = new System.Drawing.Size(199, 24);
            this.dateComienzo.TabIndex = 89;
            // 
            // btnPrevizualizar
            // 
            this.btnPrevizualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrevizualizar.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevizualizar.Appearance.Options.UseFont = true;
            this.btnPrevizualizar.Appearance.Options.UseTextOptions = true;
            this.btnPrevizualizar.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnPrevizualizar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnPrevizualizar.Location = new System.Drawing.Point(729, 658);
            this.btnPrevizualizar.Name = "btnPrevizualizar";
            this.btnPrevizualizar.Size = new System.Drawing.Size(143, 30);
            this.btnPrevizualizar.TabIndex = 91;
            this.btnPrevizualizar.Text = "Imprimir cotizacion";
            this.btnPrevizualizar.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btnPrevizualizar.ToolTipTitle = "Agregar";
            this.btnPrevizualizar.Click += new System.EventHandler(this.btnPrevizualizar_Click);
            // 
            // FrmRegOrdenServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 710);
            this.Controls.Add(this.btnPrevizualizar);
            this.Controls.Add(this.labelControl25);
            this.Controls.Add(this.dateComienzo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.dateCompromiso);
            this.Controls.Add(this.labelControl16);
            this.Controls.Add(this.dateElaboracion);
            this.Controls.Add(this.txtNumeroOrden);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmRegOrdenServicio";
            this.Text = "Orden de Servicio";
            this.Load += new System.EventHandler(this.frmREG_OrdenServicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dateCompromiso.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCompromiso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxAutor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxResponsable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateElaboracion.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateElaboracion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroOrden.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoConcepto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memNotas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDias.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroEconomico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKilometraje.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarca.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModelo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero_aviso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlacas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubmarca.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalAcumulado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImpuesto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServicios.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUtilidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridServiciosBasicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewServicios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateComienzo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateComienzo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LabelControl labelControl20;
        private MemoEdit memNotas;
    }
}