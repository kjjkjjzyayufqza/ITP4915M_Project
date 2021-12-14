
namespace DarkDemo
{
    partial class GenerateInvoice
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
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateInvoice));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Guna.UI2.AnimatorNS.Animation animation2 = new Guna.UI2.AnimatorNS.Animation();
            this.DataTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new DarkDemo.InvoiceUI.DataSet1();
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.guna2GradientButton6 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtInvoiceID = new Guna.UI2.WinForms.Guna2TextBox();
            this.lsvShipment = new System.Windows.Forms.ListView();
            this.InvoiceID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AccountID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.paidStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.paymentMethod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Payment_btn_se = new Guna.UI2.WinForms.Guna2Button();
            this.btnInvoice = new Guna.UI2.WinForms.Guna2Button();
            this.btnReturn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label15 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dataTable1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1BindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl3 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Transition_menu = new Guna.UI2.WinForms.Guna2Transition();
            this.timer_menu = new System.Windows.Forms.Timer(this.components);
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1TableAdapter = new DarkDemo.InvoiceUI.DataSet1TableAdapters.DataTable1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable2BindingSource
            // 
            this.DataTable2BindingSource.DataMember = "DataTable2";
            this.DataTable2BindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            this.guna2Transition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation1;
            this.guna2Transition1.TimeStep = 0.017F;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition_menu.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(236, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 21);
            this.label1.TabIndex = 70;
            this.label1.Text = "Monthly Invoice ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // reportViewer1
            // 
            this.guna2Transition_menu.SetDecoration(this.reportViewer1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.reportViewer1, Guna.UI2.AnimatorNS.DecorationType.None);
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTable2BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DarkDemo.InvoiceUI.MonthlyInvoice.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(240, 122);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(860, 528);
            this.reportViewer1.TabIndex = 73;
            this.reportViewer1.Visible = false;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // guna2GradientButton6
            // 
            this.guna2GradientButton6.Animated = true;
            this.guna2GradientButton6.AutoRoundedCorners = true;
            this.guna2GradientButton6.BorderRadius = 23;
            this.guna2GradientButton6.BorderThickness = 2;
            this.guna2GradientButton6.CheckedState.Parent = this.guna2GradientButton6;
            this.guna2GradientButton6.CustomImages.Parent = this.guna2GradientButton6;
            this.guna2Transition_menu.SetDecoration(this.guna2GradientButton6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2GradientButton6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2GradientButton6.DisabledState.Parent = this.guna2GradientButton6;
            this.guna2GradientButton6.FillColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton6.FillColor2 = System.Drawing.Color.Transparent;
            this.guna2GradientButton6.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F);
            this.guna2GradientButton6.ForeColor = System.Drawing.Color.Black;
            this.guna2GradientButton6.HoverState.Parent = this.guna2GradientButton6;
            this.guna2GradientButton6.Location = new System.Drawing.Point(619, 69);
            this.guna2GradientButton6.Name = "guna2GradientButton6";
            this.guna2GradientButton6.ShadowDecoration.Parent = this.guna2GradientButton6;
            this.guna2GradientButton6.Size = new System.Drawing.Size(117, 49);
            this.guna2GradientButton6.TabIndex = 2;
            this.guna2GradientButton6.Text = "Search";
            this.guna2GradientButton6.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtInvoiceID
            // 
            this.txtInvoiceID.Animated = true;
            this.txtInvoiceID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition_menu.SetDecoration(this.txtInvoiceID, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.txtInvoiceID, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtInvoiceID.DefaultText = "";
            this.txtInvoiceID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInvoiceID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtInvoiceID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInvoiceID.DisabledState.Parent = this.txtInvoiceID;
            this.txtInvoiceID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInvoiceID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInvoiceID.FocusedState.Parent = this.txtInvoiceID;
            this.txtInvoiceID.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.txtInvoiceID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInvoiceID.HoverState.Parent = this.txtInvoiceID;
            this.txtInvoiceID.IconRight = ((System.Drawing.Image)(resources.GetObject("txtInvoiceID.IconRight")));
            this.txtInvoiceID.Location = new System.Drawing.Point(401, 70);
            this.txtInvoiceID.Name = "txtInvoiceID";
            this.txtInvoiceID.PasswordChar = '\0';
            this.txtInvoiceID.PlaceholderText = "";
            this.txtInvoiceID.SelectedText = "";
            this.txtInvoiceID.ShadowDecoration.Parent = this.txtInvoiceID;
            this.txtInvoiceID.Size = new System.Drawing.Size(200, 44);
            this.txtInvoiceID.TabIndex = 1;
            // 
            // lsvShipment
            // 
            this.lsvShipment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.InvoiceID,
            this.AccountID,
            this.paidStatus,
            this.paymentMethod,
            this.dateTime});
            this.guna2Transition_menu.SetDecoration(this.lsvShipment, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.lsvShipment, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lsvShipment.FullRowSelect = true;
            this.lsvShipment.HideSelection = false;
            this.lsvShipment.Location = new System.Drawing.Point(240, 122);
            this.lsvShipment.Name = "lsvShipment";
            this.lsvShipment.Size = new System.Drawing.Size(860, 528);
            this.lsvShipment.TabIndex = 89;
            this.lsvShipment.UseCompatibleStateImageBehavior = false;
            this.lsvShipment.View = System.Windows.Forms.View.Details;
            this.lsvShipment.SelectedIndexChanged += new System.EventHandler(this.lsvShipment_SelectedIndexChanged);
            // 
            // InvoiceID
            // 
            this.InvoiceID.Text = "Invoice ID";
            this.InvoiceID.Width = 172;
            // 
            // AccountID
            // 
            this.AccountID.Text = "Account ID";
            this.AccountID.Width = 172;
            // 
            // paidStatus
            // 
            this.paidStatus.Text = "Paid Status";
            this.paidStatus.Width = 172;
            // 
            // paymentMethod
            // 
            this.paymentMethod.Text = "Payment Method";
            this.paymentMethod.Width = 172;
            // 
            // dateTime
            // 
            this.dateTime.Text = "Date Time";
            this.dateTime.Width = 172;
            // 
            // Payment_btn_se
            // 
            this.Payment_btn_se.Animated = true;
            this.Payment_btn_se.BorderThickness = 2;
            this.Payment_btn_se.CheckedState.Parent = this.Payment_btn_se;
            this.Payment_btn_se.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Payment_btn_se.CustomImages.Parent = this.Payment_btn_se;
            this.guna2Transition_menu.SetDecoration(this.Payment_btn_se, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.Payment_btn_se, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Payment_btn_se.DisabledState.Parent = this.Payment_btn_se;
            this.Payment_btn_se.FillColor = System.Drawing.Color.White;
            this.Payment_btn_se.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Payment_btn_se.ForeColor = System.Drawing.Color.Black;
            this.Payment_btn_se.HoverState.Parent = this.Payment_btn_se;
            this.Payment_btn_se.Location = new System.Drawing.Point(619, 675);
            this.Payment_btn_se.Name = "Payment_btn_se";
            this.Payment_btn_se.ShadowDecoration.Parent = this.Payment_btn_se;
            this.Payment_btn_se.Size = new System.Drawing.Size(227, 40);
            this.Payment_btn_se.TabIndex = 3;
            this.Payment_btn_se.Text = "Payment select";
            this.Payment_btn_se.Click += new System.EventHandler(this.Payment_btn_se_Click);
            // 
            // btnInvoice
            // 
            this.btnInvoice.Animated = true;
            this.btnInvoice.BorderThickness = 2;
            this.btnInvoice.CheckedState.Parent = this.btnInvoice;
            this.btnInvoice.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnInvoice.CustomImages.Parent = this.btnInvoice;
            this.guna2Transition_menu.SetDecoration(this.btnInvoice, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.btnInvoice, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnInvoice.DisabledState.Parent = this.btnInvoice;
            this.btnInvoice.FillColor = System.Drawing.Color.White;
            this.btnInvoice.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoice.ForeColor = System.Drawing.Color.Black;
            this.btnInvoice.HoverState.Parent = this.btnInvoice;
            this.btnInvoice.Location = new System.Drawing.Point(873, 675);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.ShadowDecoration.Parent = this.btnInvoice;
            this.btnInvoice.Size = new System.Drawing.Size(227, 40);
            this.btnInvoice.TabIndex = 4;
            this.btnInvoice.Text = "Generate Invoice";
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Animated = true;
            this.btnReturn.AutoRoundedCorners = true;
            this.btnReturn.BorderColor = System.Drawing.Color.White;
            this.btnReturn.BorderRadius = 20;
            this.btnReturn.BorderThickness = 2;
            this.btnReturn.CheckedState.Parent = this.btnReturn;
            this.btnReturn.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
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
            this.btnReturn.Location = new System.Drawing.Point(1054, 72);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.ShadowDecoration.Parent = this.btnReturn;
            this.btnReturn.Size = new System.Drawing.Size(46, 42);
            this.btnReturn.TabIndex = 93;
            this.btnReturn.Visible = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label15, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition_menu.SetDecoration(this.label15, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.OrangeRed;
            this.label15.Location = new System.Drawing.Point(234, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(327, 36);
            this.label15.TabIndex = 97;
            this.label15.Text = "Check Monthly Invoice";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // dataTable1BindingSource1
            // 
            this.dataTable1BindingSource1.DataMember = "DataTable1";
            this.dataTable1BindingSource1.DataSource = this.dataSet1BindingSource;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // dataTable1BindingSource2
            // 
            this.dataTable1BindingSource2.DataMember = "DataTable1";
            this.dataTable1BindingSource2.DataSource = this.dataSet1BindingSource;
            // 
            // dataTable1BindingSource3
            // 
            this.dataTable1BindingSource3.DataMember = "DataTable1";
            this.dataTable1BindingSource3.DataSource = this.dataSet1BindingSource;
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
            // guna2Transition_menu
            // 
            this.guna2Transition_menu.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            this.guna2Transition_menu.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.guna2Transition_menu.DefaultAnimation = animation2;
            this.guna2Transition_menu.MaxAnimationTime = 1600;
            this.guna2Transition_menu.TimeStep = 1F;
            // 
            // timer_menu
            // 
            this.timer_menu.Tick += new System.EventHandler(this.timer_menu_Tick);
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.dataSet1;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // GenerateInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 740);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnInvoice);
            this.Controls.Add(this.Payment_btn_se);
            this.Controls.Add(this.txtInvoiceID);
            this.Controls.Add(this.guna2GradientButton6);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsvShipment);
            this.guna2Transition_menu.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GenerateInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GenerateInvoice";
            this.Load += new System.EventHandler(this.GenerateInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private InvoiceUI.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private System.Windows.Forms.BindingSource dataTable1BindingSource1;
        private InvoiceUI.DataSet1TableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.BindingSource dataTable1BindingSource2;
        private System.Windows.Forms.BindingSource dataTable1BindingSource3;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton6;
        private Guna.UI2.WinForms.Guna2TextBox txtInvoiceID;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition_menu;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl3;
        private System.Windows.Forms.Timer timer_menu;
        private System.Windows.Forms.ListView lsvShipment;
        private System.Windows.Forms.ColumnHeader InvoiceID;
        private System.Windows.Forms.ColumnHeader AccountID;
        private System.Windows.Forms.ColumnHeader dateTime;
        private Guna.UI2.WinForms.Guna2Button Payment_btn_se;
        private Guna.UI2.WinForms.Guna2Button btnInvoice;
        private System.Windows.Forms.BindingSource DataTable2BindingSource;
        private Guna.UI2.WinForms.Guna2GradientButton btnReturn;
        private System.Windows.Forms.ColumnHeader paidStatus;
        private System.Windows.Forms.ColumnHeader paymentMethod;
        private System.Windows.Forms.Label label15;
    }
}