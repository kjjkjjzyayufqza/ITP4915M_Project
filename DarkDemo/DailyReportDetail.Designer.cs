
namespace DarkDemo
{
    partial class DailyReportDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailyReportDetail));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            Guna.UI2.AnimatorNS.Animation animation2 = new Guna.UI2.AnimatorNS.Animation();
            this.timer_menu = new System.Windows.Forms.Timer(this.components);
            this.timer_welcome = new System.Windows.Forms.Timer(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Transition_menu = new Guna.UI2.WinForms.Guna2Transition();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblReportID = new System.Windows.Forms.Label();
            this.lblReportDate = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblIncome = new System.Windows.Forms.Label();
            this.lblNoOfOrder = new System.Windows.Forms.Label();
            this.chartTo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartFrom = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btnPrint = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFrom)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.TransparentWhileDrag = true;
            this.guna2DragControl2.UseTransparentDrag = true;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TransparentWhileDrag = true;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2Transition_menu
            // 
            this.guna2Transition_menu.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            this.guna2Transition_menu.Cursor = null;
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
            this.guna2Transition_menu.DefaultAnimation = animation1;
            this.guna2Transition_menu.MaxAnimationTime = 1600;
            this.guna2Transition_menu.TimeStep = 3F;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Transition1.SetDecoration(this.guna2ControlBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition_menu.SetDecoration(this.guna2ControlBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(752, 13);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 31);
            this.guna2ControlBox1.TabIndex = 34;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.guna2Transition_menu.SetDecoration(this.lblTitle, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.lblTitle, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(240, 51);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(306, 35);
            this.lblTitle.TabIndex = 43;
            this.lblTitle.Text = "Daily Shipment Report";
            // 
            // lblReportID
            // 
            this.lblReportID.AutoSize = true;
            this.guna2Transition_menu.SetDecoration(this.lblReportID, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.lblReportID, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblReportID.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblReportID.ForeColor = System.Drawing.Color.Black;
            this.lblReportID.Location = new System.Drawing.Point(513, 151);
            this.lblReportID.Name = "lblReportID";
            this.lblReportID.Size = new System.Drawing.Size(104, 25);
            this.lblReportID.TabIndex = 44;
            this.lblReportID.Text = "Report ID:";
            // 
            // lblReportDate
            // 
            this.lblReportDate.AutoSize = true;
            this.guna2Transition_menu.SetDecoration(this.lblReportDate, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.lblReportDate, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblReportDate.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblReportDate.ForeColor = System.Drawing.Color.Black;
            this.lblReportDate.Location = new System.Drawing.Point(513, 189);
            this.lblReportDate.Name = "lblReportDate";
            this.lblReportDate.Size = new System.Drawing.Size(127, 25);
            this.lblReportDate.TabIndex = 45;
            this.lblReportDate.Text = "Report Date:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblIncome);
            this.groupBox1.Controls.Add(this.lblNoOfOrder);
            this.guna2Transition1.SetDecoration(this.groupBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition_menu.SetDecoration(this.groupBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.groupBox1.Location = new System.Drawing.Point(42, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 106);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            // 
            // lblIncome
            // 
            this.lblIncome.AutoSize = true;
            this.guna2Transition_menu.SetDecoration(this.lblIncome, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.lblIncome, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblIncome.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblIncome.ForeColor = System.Drawing.Color.Black;
            this.lblIncome.Location = new System.Drawing.Point(18, 56);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(138, 25);
            this.lblIncome.TabIndex = 46;
            this.lblIncome.Text = "Total Income:";
            // 
            // lblNoOfOrder
            // 
            this.lblNoOfOrder.AutoSize = true;
            this.guna2Transition_menu.SetDecoration(this.lblNoOfOrder, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.lblNoOfOrder, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblNoOfOrder.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNoOfOrder.ForeColor = System.Drawing.Color.Black;
            this.lblNoOfOrder.Location = new System.Drawing.Point(18, 18);
            this.lblNoOfOrder.Name = "lblNoOfOrder";
            this.lblNoOfOrder.Size = new System.Drawing.Size(224, 25);
            this.lblNoOfOrder.TabIndex = 45;
            this.lblNoOfOrder.Text = "Total Number of order:";
            // 
            // chartTo
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTo.ChartAreas.Add(chartArea1);
            this.guna2Transition1.SetDecoration(this.chartTo, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition_menu.SetDecoration(this.chartTo, Guna.UI2.AnimatorNS.DecorationType.None);
            legend1.Name = "Legend1";
            this.chartTo.Legends.Add(legend1);
            this.chartTo.Location = new System.Drawing.Point(451, 387);
            this.chartTo.Name = "chartTo";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "s1";
            this.chartTo.Series.Add(series1);
            this.chartTo.Size = new System.Drawing.Size(300, 325);
            this.chartTo.TabIndex = 65;
            this.chartTo.Text = "chart2";
            // 
            // chartFrom
            // 
            chartArea2.Name = "ChartArea1";
            this.chartFrom.ChartAreas.Add(chartArea2);
            this.guna2Transition1.SetDecoration(this.chartFrom, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition_menu.SetDecoration(this.chartFrom, Guna.UI2.AnimatorNS.DecorationType.None);
            legend2.Name = "Legend1";
            this.chartFrom.Legends.Add(legend2);
            this.chartFrom.Location = new System.Drawing.Point(65, 387);
            this.chartFrom.Name = "chartFrom";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "s1";
            this.chartFrom.Series.Add(series2);
            this.chartFrom.Size = new System.Drawing.Size(300, 325);
            this.chartFrom.TabIndex = 64;
            this.chartFrom.Text = "chart1";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.guna2Transition1.SetDecoration(this.printPreviewDialog1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition_menu.SetDecoration(this.printPreviewDialog1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // btnPrint
            // 
            this.btnPrint.Animated = true;
            this.btnPrint.BorderThickness = 2;
            this.btnPrint.CheckedState.Parent = this.btnPrint;
            this.btnPrint.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnPrint.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPrint.CustomImages.Parent = this.btnPrint;
            this.guna2Transition1.SetDecoration(this.btnPrint, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition_menu.SetDecoration(this.btnPrint, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnPrint.DisabledState.Parent = this.btnPrint;
            this.btnPrint.FillColor = System.Drawing.Color.White;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.Black;
            this.btnPrint.HoverState.Parent = this.btnPrint;
            this.btnPrint.Location = new System.Drawing.Point(591, 754);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.ShadowDecoration.Parent = this.btnPrint;
            this.btnPrint.Size = new System.Drawing.Size(150, 43);
            this.btnPrint.TabIndex = 66;
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            this.guna2Transition1.Cursor = null;
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
            this.guna2Transition1.DefaultAnimation = animation2;
            this.guna2Transition1.MaxAnimationTime = 10000;
            this.guna2Transition1.TimeStep = 0.017F;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // DailyReportDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 823);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblReportDate);
            this.Controls.Add(this.lblReportID);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chartTo);
            this.Controls.Add(this.chartFrom);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition_menu.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DailyReportDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFrom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer_menu;
        private System.Windows.Forms.Timer timer_welcome;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition_menu;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblReportID;
        private System.Windows.Forms.Label lblReportDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblIncome;
        private System.Windows.Forms.Label lblNoOfOrder;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFrom;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private Guna.UI2.WinForms.Guna2Button btnPrint;
    }
}