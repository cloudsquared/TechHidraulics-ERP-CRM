namespace TechHidraulics_ERP_CRM
{
    partial class FrmMdi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMdi));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnInventario = new DevExpress.XtraBars.BarButtonItem();
            this.btnEmpleados = new DevExpress.XtraBars.BarButtonItem();
            this.btnProveedores = new DevExpress.XtraBars.BarButtonItem();
            this.btnVehiculos = new DevExpress.XtraBars.BarButtonItem();
            this.btnNuevaOrden = new DevExpress.XtraBars.BarButtonItem();
            this.btnOrdenes = new DevExpress.XtraBars.BarButtonItem();
            this.btnNuevoArticulo = new DevExpress.XtraBars.BarButtonItem();
            this.btnClientes = new DevExpress.XtraBars.BarButtonItem();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.btnProductos = new DevExpress.XtraBars.BarButtonItem();
            this.btnServicios = new DevExpress.XtraBars.BarButtonItem();
            this.btnHome = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.SkinManager = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.MDIManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MDIManager)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnInventario,
            this.btnEmpleados,
            this.btnProveedores,
            this.btnVehiculos,
            this.btnNuevaOrden,
            this.btnOrdenes,
            this.btnNuevoArticulo,
            this.btnClientes,
            this.skinRibbonGalleryBarItem1,
            this.btnProductos,
            this.btnServicios,
            this.btnHome});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(2);
            this.ribbon.MaxItemId = 15;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbon.Size = new System.Drawing.Size(1164, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnInventario
            // 
            this.btnInventario.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnInventario.Caption = "Inventario";
            this.btnInventario.Id = 1;
            this.btnInventario.LargeGlyph = global::TechHidraulics_ERP_CRM.Properties.Resources.filled_box_32px;
            this.btnInventario.LargeWidth = 60;
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInventario_ItemClick);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnEmpleados.Caption = "Empleados";
            this.btnEmpleados.Id = 2;
            this.btnEmpleados.LargeGlyph = global::TechHidraulics_ERP_CRM.Properties.Resources.user_32px;
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEmpleados_ItemClick);
            // 
            // btnProveedores
            // 
            this.btnProveedores.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnProveedores.Caption = "Proveedores";
            this.btnProveedores.Id = 3;
            this.btnProveedores.LargeGlyph = global::TechHidraulics_ERP_CRM.Properties.Resources.move_by_trolley_32px;
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProveedores_ItemClick);
            // 
            // btnVehiculos
            // 
            this.btnVehiculos.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnVehiculos.Caption = "Vehiculos";
            this.btnVehiculos.Id = 4;
            this.btnVehiculos.LargeGlyph = global::TechHidraulics_ERP_CRM.Properties.Resources.car_32px;
            this.btnVehiculos.LargeWidth = 60;
            this.btnVehiculos.Name = "btnVehiculos";
            this.btnVehiculos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnVehiculos_ItemClick);
            // 
            // btnNuevaOrden
            // 
            this.btnNuevaOrden.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnNuevaOrden.Caption = "Crear Orden Servicio";
            this.btnNuevaOrden.Id = 5;
            this.btnNuevaOrden.LargeGlyph = global::TechHidraulics_ERP_CRM.Properties.Resources.purchase_order_32px;
            this.btnNuevaOrden.Name = "btnNuevaOrden";
            this.btnNuevaOrden.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNuevaOrden_ItemClick);
            // 
            // btnOrdenes
            // 
            this.btnOrdenes.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnOrdenes.Caption = "Ordenes";
            this.btnOrdenes.Id = 6;
            this.btnOrdenes.LargeGlyph = global::TechHidraulics_ERP_CRM.Properties.Resources.book_32px;
            this.btnOrdenes.LargeWidth = 60;
            this.btnOrdenes.Name = "btnOrdenes";
            this.btnOrdenes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnOrdenes_ItemClick);
            // 
            // btnNuevoArticulo
            // 
            this.btnNuevoArticulo.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnNuevoArticulo.Caption = "Nuevo Articulo";
            this.btnNuevoArticulo.Id = 8;
            this.btnNuevoArticulo.LargeGlyph = global::TechHidraulics_ERP_CRM.Properties.Resources.add_property_32px;
            this.btnNuevoArticulo.LargeWidth = 60;
            this.btnNuevoArticulo.Name = "btnNuevoArticulo";
            this.btnNuevoArticulo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNuevoArticulo_ItemClick);
            // 
            // btnClientes
            // 
            this.btnClientes.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnClientes.Caption = "Clientes";
            this.btnClientes.Id = 9;
            this.btnClientes.LargeGlyph = global::TechHidraulics_ERP_CRM.Properties.Resources.customer_support_32px;
            this.btnClientes.LargeWidth = 60;
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClientes_ItemClick);
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.Id = 10;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // btnProductos
            // 
            this.btnProductos.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnProductos.Caption = "Productos y Piezas";
            this.btnProductos.Id = 11;
            this.btnProductos.LargeGlyph = global::TechHidraulics_ERP_CRM.Properties.Resources.administrative_tools_32px;
            this.btnProductos.LargeWidth = 60;
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProductos_ItemClick);
            // 
            // btnServicios
            // 
            this.btnServicios.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnServicios.Caption = "Servicios";
            this.btnServicios.Id = 12;
            this.btnServicios.LargeGlyph = global::TechHidraulics_ERP_CRM.Properties.Resources.support_32px;
            this.btnServicios.LargeWidth = 60;
            this.btnServicios.Name = "btnServicios";
            this.btnServicios.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnServicios_ItemClick);
            // 
            // btnHome
            // 
            this.btnHome.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnHome.Caption = "Home";
            this.btnHome.Id = 14;
            this.btnHome.LargeGlyph = global::TechHidraulics_ERP_CRM.Properties.Resources.home_32px;
            this.btnHome.LargeWidth = 65;
            this.btnHome.Name = "btnHome";
            this.btnHome.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHome_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6,
            this.ribbonPageGroup1,
            this.ribbonPageGroup5,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Principal";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnHome);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNuevaOrden);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnOrdenes, true);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Ordenes";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnServicios);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnProductos);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Servicios";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnNuevoArticulo);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnInventario);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Inventarios";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnEmpleados);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnClientes);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnVehiculos);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnProveedores);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Catalogos";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 719);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(2);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1164, 31);
            // 
            // SkinManager
            // 
            this.SkinManager.LookAndFeel.SkinName = "DevExpress Dark Style";
            // 
            // MDIManager
            // 
            this.MDIManager.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.MDIManager.MdiParent = this;
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.skinRibbonGalleryBarItem1);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // FrmMdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 750);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMdi";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "TecHidraulics ERP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMdi_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MDIManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.LookAndFeel.DefaultLookAndFeel SkinManager;
        private DevExpress.XtraBars.BarButtonItem btnInventario;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnEmpleados;
        private DevExpress.XtraBars.BarButtonItem btnProveedores;
        private DevExpress.XtraBars.BarButtonItem btnVehiculos;
        private DevExpress.XtraBars.BarButtonItem btnNuevaOrden;
        private DevExpress.XtraBars.BarButtonItem btnOrdenes;
        private DevExpress.XtraBars.BarButtonItem btnNuevoArticulo;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager MDIManager;
        private DevExpress.XtraBars.BarButtonItem btnClientes;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.BarButtonItem btnProductos;
        private DevExpress.XtraBars.BarButtonItem btnServicios;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnHome;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
    }
}