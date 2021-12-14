
namespace DarkDemo
{
    partial class checkOrder
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
            Guna.UI2.AnimatorNS.Animation animation5 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(checkOrder));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Guna.UI2.AnimatorNS.Animation animation6 = new Guna.UI2.AnimatorNS.Animation();
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.lsvShipment = new System.Windows.Forms.ListView();
            this.ShipmentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CreateDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblShipmentID = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.btnAirway = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.label15 = new System.Windows.Forms.Label();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnReturn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.timer_menu = new System.Windows.Forms.Timer(this.components);
            this.guna2Transition_menu = new Guna.UI2.WinForms.Guna2Transition();
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl3 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.SuspendLayout();
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            this.guna2Transition1.Cursor = null;
            animation5.AnimateOnlyDifferences = true;
            animation5.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.BlindCoeff")));
            animation5.LeafCoeff = 0F;
            animation5.MaxTime = 1F;
            animation5.MinTime = 0F;
            animation5.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicCoeff")));
            animation5.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicShift")));
            animation5.MosaicSize = 0;
            animation5.Padding = new System.Windows.Forms.Padding(0);
            animation5.RotateCoeff = 0F;
            animation5.RotateLimit = 0F;
            animation5.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.ScaleCoeff")));
            animation5.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.SlideCoeff")));
            animation5.TimeCoeff = 0F;
            animation5.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation5;
            this.guna2Transition1.TimeStep = 0.017F;
            // 
            // lsvShipment
            // 
            this.lsvShipment.BackColor = System.Drawing.SystemColors.Control;
            this.lsvShipment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ShipmentID,
            this.Price,
            this.CreateDate,
            this.Status});
            this.guna2Transition_menu.SetDecoration(this.lsvShipment, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.lsvShipment, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lsvShipment.FullRowSelect = true;
            this.lsvShipment.HideSelection = false;
            this.lsvShipment.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lsvShipment.Location = new System.Drawing.Point(240, 124);
            this.lsvShipment.Name = "lsvShipment";
            this.lsvShipment.Size = new System.Drawing.Size(835, 477);
            this.lsvShipment.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lsvShipment.TabIndex = 16;
            this.lsvShipment.UseCompatibleStateImageBehavior = false;
            this.lsvShipment.View = System.Windows.Forms.View.Details;
            this.lsvShipment.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ShipmentID
            // 
            this.ShipmentID.Text = "Shipment ID";
            this.ShipmentID.Width = 200;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 200;
            // 
            // CreateDate
            // 
            this.CreateDate.Text = "Create Date";
            this.CreateDate.Width = 200;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.Width = 200;
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition_menu.SetDecoration(this.txtSearch, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.txtSearch, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.Parent = this.txtSearch;
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedState.Parent = this.txtSearch;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.HoverState.Parent = this.txtSearch;
            this.txtSearch.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtSearch.IconLeft")));
            this.txtSearch.Location = new System.Drawing.Point(374, 70);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(289, 32);
            this.txtSearch.TabIndex = 1;
            // 
            // lblShipmentID
            // 
            this.lblShipmentID.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.lblShipmentID, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition_menu.SetDecoration(this.lblShipmentID, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblShipmentID.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShipmentID.Location = new System.Drawing.Point(235, 79);
            this.lblShipmentID.Name = "lblShipmentID";
            this.lblShipmentID.Size = new System.Drawing.Size(131, 25);
            this.lblShipmentID.TabIndex = 18;
            this.lblShipmentID.Text = "Shipment ID:";
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 16;
            this.guna2Button1.BorderThickness = 2;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Transition_menu.SetDecoration(this.guna2Button1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2Button1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Button1.DisabledState.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(669, 67);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(166, 35);
            this.guna2Button1.TabIndex = 2;
            this.guna2Button1.Text = "Search";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.Animated = true;
            this.guna2Button2.BorderThickness = 2;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.guna2Button2.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Transition_menu.SetDecoration(this.guna2Button2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2Button2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Button2.DisabledState.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.White;
            this.guna2Button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.Black;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(981, 616);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(157, 40);
            this.guna2Button2.TabIndex = 5;
            this.guna2Button2.Text = "Detail";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.Animated = true;
            this.guna2Button3.BorderThickness = 2;
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.guna2Button3.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Transition_menu.SetDecoration(this.guna2Button3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2Button3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Button3.DisabledState.Parent = this.guna2Button3;
            this.guna2Button3.FillColor = System.Drawing.Color.White;
            this.guna2Button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.Black;
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Location = new System.Drawing.Point(240, 616);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(246, 40);
            this.guna2Button3.TabIndex = 3;
            this.guna2Button3.Text = "Check Signed Invoice";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // btnAirway
            // 
            this.btnAirway.Animated = true;
            this.btnAirway.BorderThickness = 2;
            this.btnAirway.CheckedState.Parent = this.btnAirway;
            this.btnAirway.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btnAirway.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAirway.CustomImages.Parent = this.btnAirway;
            this.guna2Transition_menu.SetDecoration(this.btnAirway, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.btnAirway, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnAirway.DisabledState.Parent = this.btnAirway;
            this.btnAirway.FillColor = System.Drawing.Color.White;
            this.btnAirway.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAirway.ForeColor = System.Drawing.Color.Black;
            this.btnAirway.HoverState.Parent = this.btnAirway;
            this.btnAirway.Location = new System.Drawing.Point(746, 616);
            this.btnAirway.Name = "btnAirway";
            this.btnAirway.ShadowDecoration.Parent = this.btnAirway;
            this.btnAirway.Size = new System.Drawing.Size(206, 40);
            this.btnAirway.TabIndex = 4;
            this.btnAirway.Text = "Check Airway Bill";
            this.btnAirway.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.guna2Transition_menu.SetDecoration(this.panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(397, 280);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(619, 311);
            this.panel1.TabIndex = 40;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // guna2Button4
            // 
            this.guna2Button4.Animated = true;
            this.guna2Button4.BorderThickness = 2;
            this.guna2Button4.CheckedState.Parent = this.guna2Button4;
            this.guna2Button4.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.guna2Button4.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button4.CustomImages.Parent = this.guna2Button4;
            this.guna2Transition_menu.SetDecoration(this.guna2Button4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2Button4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Button4.DisabledState.Parent = this.guna2Button4;
            this.guna2Button4.FillColor = System.Drawing.Color.White;
            this.guna2Button4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button4.ForeColor = System.Drawing.Color.Black;
            this.guna2Button4.HoverState.Parent = this.guna2Button4;
            this.guna2Button4.Location = new System.Drawing.Point(519, 616);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.ShadowDecoration.Parent = this.guna2Button4;
            this.guna2Button4.Size = new System.Drawing.Size(200, 40);
            this.guna2Button4.TabIndex = 94;
            this.guna2Button4.Text = "Check Invoice";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click_1);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label15, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition_menu.SetDecoration(this.label15, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.OrangeRed;
            this.label15.Location = new System.Drawing.Point(234, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(344, 36);
            this.label15.TabIndex = 96;
            this.label15.Text = "Check Order Infomation";
            // 
            // reportViewer2
            // 
            this.guna2Transition_menu.SetDecoration(this.reportViewer2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.reportViewer2, Guna.UI2.AnimatorNS.DecorationType.None);
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = null;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "DarkDemo.InvoiceUI.Report1.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(240, 114);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(898, 488);
            this.reportViewer2.TabIndex = 93;
            this.reportViewer2.Visible = false;
            // 
            // btnReturn
            // 
            this.btnReturn.Animated = true;
            this.btnReturn.AutoRoundedCorners = true;
            this.btnReturn.BorderColor = System.Drawing.Color.White;
            this.btnReturn.BorderRadius = 18;
            this.btnReturn.BorderThickness = 2;
            this.btnReturn.CheckedState.Parent = this.btnReturn;
            this.btnReturn.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            this.btnReturn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnReturn.CustomImages.Parent = this.btnReturn;
            this.guna2Transition_menu.SetDecoration(this.btnReturn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.btnReturn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnReturn.DisabledState.Parent = this.btnReturn;
            this.btnReturn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReturn.FillColor2 = System.Drawing.Color.DimGray;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F);
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.HoverState.Parent = this.btnReturn;
            this.btnReturn.Location = new System.Drawing.Point(1092, 63);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.ShadowDecoration.Parent = this.btnReturn;
            this.btnReturn.Size = new System.Drawing.Size(46, 39);
            this.btnReturn.TabIndex = 97;
            this.btnReturn.Visible = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Animated = true;
            this.btnUpdate.AutoRoundedCorners = true;
            this.btnUpdate.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btnUpdate.BorderRadius = 19;
            this.btnUpdate.BorderThickness = 2;
            this.btnUpdate.CheckedState.Parent = this.btnUpdate;
            this.btnUpdate.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnUpdate.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUpdate.CustomImages.Parent = this.btnUpdate;
            this.guna2Transition_menu.SetDecoration(this.btnUpdate, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.btnUpdate, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnUpdate.DisabledState.Parent = this.btnUpdate;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.HoverState.Parent = this.btnUpdate;
            this.btnUpdate.Location = new System.Drawing.Point(881, 63);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(154, 40);
            this.btnUpdate.TabIndex = 98;
            this.btnUpdate.Text = "Update Status";
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // guna2Transition_menu
            // 
            this.guna2Transition_menu.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            this.guna2Transition_menu.Cursor = null;
            animation6.AnimateOnlyDifferences = true;
            animation6.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.BlindCoeff")));
            animation6.LeafCoeff = 0F;
            animation6.MaxTime = 1F;
            animation6.MinTime = 0F;
            animation6.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicCoeff")));
            animation6.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicShift")));
            animation6.MosaicSize = 0;
            animation6.Padding = new System.Windows.Forms.Padding(0);
            animation6.RotateCoeff = 0F;
            animation6.RotateLimit = 0F;
            animation6.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.ScaleCoeff")));
            animation6.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.SlideCoeff")));
            animation6.TimeCoeff = 0F;
            animation6.TransparencyCoeff = 0F;
            this.guna2Transition_menu.DefaultAnimation = animation6;
            this.guna2Transition_menu.MaxAnimationTime = 1600;
            this.guna2Transition_menu.TimeStep = 1F;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.ContainerControl = this;
            this.guna2DragControl2.TransparentWhileDrag = true;
            this.guna2DragControl2.UseTransparentDrag = true;
            // 
            // guna2DragControl3
            // 
            this.guna2DragControl3.ContainerControl = this;
            this.guna2DragControl3.TransparentWhileDrag = true;
            this.guna2DragControl3.UseTransparentDrag = true;
            // 
            // checkOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 683);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.guna2Button4);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAirway);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.lblShipmentID);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lsvShipment);
            this.guna2Transition_menu.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "checkOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "checkOrder";
            this.Load += new System.EventHandler(this.checkOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label lblShipmentID;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.ListView lsvShipment;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.ColumnHeader ShipmentID;
        private System.Windows.Forms.ColumnHeader CreateDate;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Status;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition_menu;
        private System.Windows.Forms.Timer timer_menu;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl3;
        private Guna.UI2.WinForms.Guna2Button btnAirway;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.Label label15;
        private Guna.UI2.WinForms.Guna2GradientButton btnReturn;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
    }
}