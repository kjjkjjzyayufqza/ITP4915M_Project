
namespace DarkDemo
{
    partial class GenerateAirwayBill
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateAirwayBill));
            this.dataSetAirwayBillBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_AirwayBill = new DarkDemo.AirwayBillUI.DataSet_AirwayBill();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Panel_Dargcontrl = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2DragControl3 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Panel_Dargcontrl_big = new Guna.UI2.WinForms.Guna2GradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAirwayBillBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_AirwayBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).BeginInit();
            this.Panel_Dargcontrl_big.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSetAirwayBillBindingSource
            // 
            this.dataSetAirwayBillBindingSource.DataSource = this.dataSet_AirwayBill;
            this.dataSetAirwayBillBindingSource.Position = 0;
            // 
            // dataSet_AirwayBill
            // 
            this.dataSet_AirwayBill.DataSetName = "DataSet_AirwayBill";
            this.dataSet_AirwayBill.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.guna2Transition1.SetDecoration(this.reportViewer1, Guna.UI2.AnimatorNS.DecorationType.None);
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dataSetAirwayBillBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DarkDemo.AirwayBillUI.Report_AirwayBill.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 65);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1200, 673);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.dataSetAirwayBillBindingSource;
            // 
            // dataTable1BindingSource1
            // 
            this.dataTable1BindingSource1.DataMember = "DataTable1";
            this.dataTable1BindingSource1.DataSource = this.dataSetAirwayBillBindingSource;
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
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Transition1.SetDecoration(this.guna2ControlBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1140, 30);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 15;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.ContainerControl = this;
            this.guna2DragControl1.TransparentWhileDrag = true;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.TargetControl = this.Panel_Dargcontrl;
            this.guna2DragControl2.TransparentWhileDrag = true;
            this.guna2DragControl2.UseTransparentDrag = true;
            // 
            // Panel_Dargcontrl
            // 
            this.Panel_Dargcontrl.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Dargcontrl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Panel_Dargcontrl.BorderRadius = 5;
            this.Panel_Dargcontrl.BorderThickness = 1;
            this.Panel_Dargcontrl.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Transition1.SetDecoration(this.Panel_Dargcontrl, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Panel_Dargcontrl.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Panel_Dargcontrl.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Panel_Dargcontrl.Location = new System.Drawing.Point(0, 27);
            this.Panel_Dargcontrl.Name = "Panel_Dargcontrl";
            this.Panel_Dargcontrl.ShadowDecoration.Parent = this.Panel_Dargcontrl;
            this.Panel_Dargcontrl.Size = new System.Drawing.Size(450, 10);
            this.Panel_Dargcontrl.TabIndex = 18;
            // 
            // guna2DragControl3
            // 
            this.guna2DragControl3.TargetControl = this.Panel_Dargcontrl_big;
            this.guna2DragControl3.TransparentWhileDrag = true;
            this.guna2DragControl3.UseTransparentDrag = true;
            // 
            // Panel_Dargcontrl_big
            // 
            this.Panel_Dargcontrl_big.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Dargcontrl_big.Controls.Add(this.Panel_Dargcontrl);
            this.guna2Transition1.SetDecoration(this.Panel_Dargcontrl_big, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Panel_Dargcontrl_big.Location = new System.Drawing.Point(335, 0);
            this.Panel_Dargcontrl_big.Name = "Panel_Dargcontrl_big";
            this.Panel_Dargcontrl_big.ShadowDecoration.Parent = this.Panel_Dargcontrl_big;
            this.Panel_Dargcontrl_big.Size = new System.Drawing.Size(450, 40);
            this.Panel_Dargcontrl_big.TabIndex = 20;
            // 
            // GenerateAirwayBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Controls.Add(this.Panel_Dargcontrl_big);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.reportViewer1);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GenerateAirwayBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GenerateAirwayBill";
            this.Load += new System.EventHandler(this.GenerateAirwayBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAirwayBillBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_AirwayBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).EndInit();
            this.Panel_Dargcontrl_big.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dataSetAirwayBillBindingSource;
        private AirwayBillUI.DataSet_AirwayBill dataSet_AirwayBill;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private System.Windows.Forms.BindingSource dataTable1BindingSource1;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2GradientPanel Panel_Dargcontrl_big;
        private Guna.UI2.WinForms.Guna2GradientPanel Panel_Dargcontrl;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl3;
    }
}