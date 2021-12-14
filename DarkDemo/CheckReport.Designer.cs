
namespace DarkDemo
{
    partial class CheckReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckReport));
            Guna.UI2.AnimatorNS.Animation animation2 = new Guna.UI2.AnimatorNS.Animation();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Transition_menu = new Guna.UI2.WinForms.Guna2Transition();
            this.btnDetail = new Guna.UI2.WinForms.Guna2Button();
            this.cboReportType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblReportType = new System.Windows.Forms.Label();
            this.lblSDate = new System.Windows.Forms.Label();
            this.dtpSDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpEDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblEDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer_menu = new System.Windows.Forms.Timer(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl3 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.SuspendLayout();
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.TransparentWhileDrag = true;
            this.guna2DragControl2.UseTransparentDrag = true;
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
            this.guna2Transition_menu.TimeStep = 1F;
            // 
            // btnDetail
            // 
            this.btnDetail.Animated = true;
            this.btnDetail.BorderThickness = 2;
            this.btnDetail.CheckedState.Parent = this.btnDetail;
            this.btnDetail.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnDetail.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDetail.CustomImages.Parent = this.btnDetail;
            this.guna2Transition1.SetDecoration(this.btnDetail, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition_menu.SetDecoration(this.btnDetail, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnDetail.DisabledState.Parent = this.btnDetail;
            this.btnDetail.FillColor = System.Drawing.Color.White;
            this.btnDetail.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetail.ForeColor = System.Drawing.Color.Black;
            this.btnDetail.HoverState.Parent = this.btnDetail;
            this.btnDetail.Location = new System.Drawing.Point(437, 336);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.ShadowDecoration.Parent = this.btnDetail;
            this.btnDetail.Size = new System.Drawing.Size(130, 43);
            this.btnDetail.TabIndex = 100;
            this.btnDetail.Text = "Detail";
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // cboReportType
            // 
            this.cboReportType.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.cboReportType, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition_menu.SetDecoration(this.cboReportType, Guna.UI2.AnimatorNS.DecorationType.None);
            this.cboReportType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReportType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboReportType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboReportType.FocusedState.Parent = this.cboReportType;
            this.cboReportType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboReportType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboReportType.HoverState.Parent = this.cboReportType;
            this.cboReportType.ItemHeight = 30;
            this.cboReportType.Items.AddRange(new object[] {
            "Daily",
            "Weekly"});
            this.cboReportType.ItemsAppearance.Parent = this.cboReportType;
            this.cboReportType.Location = new System.Drawing.Point(367, 93);
            this.cboReportType.Name = "cboReportType";
            this.cboReportType.ShadowDecoration.Parent = this.cboReportType;
            this.cboReportType.Size = new System.Drawing.Size(200, 36);
            this.cboReportType.TabIndex = 113;
            this.cboReportType.SelectedIndexChanged += new System.EventHandler(this.cboReportType_SelectedIndexChanged);
            // 
            // lblReportType
            // 
            this.lblReportType.AutoSize = true;
            this.guna2Transition_menu.SetDecoration(this.lblReportType, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.lblReportType, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblReportType.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportType.Location = new System.Drawing.Point(216, 101);
            this.lblReportType.Name = "lblReportType";
            this.lblReportType.Size = new System.Drawing.Size(128, 25);
            this.lblReportType.TabIndex = 114;
            this.lblReportType.Text = "Report Type:";
            // 
            // lblSDate
            // 
            this.lblSDate.AutoSize = true;
            this.guna2Transition_menu.SetDecoration(this.lblSDate, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.lblSDate, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblSDate.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDate.Location = new System.Drawing.Point(216, 173);
            this.lblSDate.Name = "lblSDate";
            this.lblSDate.Size = new System.Drawing.Size(109, 25);
            this.lblSDate.TabIndex = 115;
            this.lblSDate.Text = "Start Date:";
            // 
            // dtpSDate
            // 
            this.dtpSDate.CheckedState.Parent = this.dtpSDate;
            this.guna2Transition1.SetDecoration(this.dtpSDate, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition_menu.SetDecoration(this.dtpSDate, Guna.UI2.AnimatorNS.DecorationType.None);
            this.dtpSDate.FillColor = System.Drawing.Color.White;
            this.dtpSDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpSDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSDate.HoverState.Parent = this.dtpSDate;
            this.dtpSDate.Location = new System.Drawing.Point(367, 173);
            this.dtpSDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpSDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpSDate.Name = "dtpSDate";
            this.dtpSDate.ShadowDecoration.Parent = this.dtpSDate;
            this.dtpSDate.Size = new System.Drawing.Size(200, 39);
            this.dtpSDate.TabIndex = 116;
            this.dtpSDate.Value = new System.DateTime(2021, 6, 28, 0, 0, 0, 0);
            this.dtpSDate.ValueChanged += new System.EventHandler(this.guna2DateTimePicker1_ValueChanged);
            // 
            // dtpEDate
            // 
            this.dtpEDate.CheckedState.Parent = this.dtpEDate;
            this.guna2Transition1.SetDecoration(this.dtpEDate, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition_menu.SetDecoration(this.dtpEDate, Guna.UI2.AnimatorNS.DecorationType.None);
            this.dtpEDate.Enabled = false;
            this.dtpEDate.FillColor = System.Drawing.Color.White;
            this.dtpEDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpEDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEDate.HoverState.Parent = this.dtpEDate;
            this.dtpEDate.Location = new System.Drawing.Point(367, 248);
            this.dtpEDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpEDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpEDate.Name = "dtpEDate";
            this.dtpEDate.ShadowDecoration.Parent = this.dtpEDate;
            this.dtpEDate.Size = new System.Drawing.Size(200, 39);
            this.dtpEDate.TabIndex = 118;
            this.dtpEDate.Value = new System.DateTime(2021, 6, 28, 18, 58, 30, 948);
            // 
            // lblEDate
            // 
            this.lblEDate.AutoSize = true;
            this.guna2Transition_menu.SetDecoration(this.lblEDate, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.lblEDate, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblEDate.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEDate.Location = new System.Drawing.Point(216, 248);
            this.lblEDate.Name = "lblEDate";
            this.lblEDate.Size = new System.Drawing.Size(100, 25);
            this.lblEDate.TabIndex = 117;
            this.lblEDate.Text = "End Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.guna2Transition_menu.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(215, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 36);
            this.label1.TabIndex = 119;
            this.label1.Text = "Account Information";
            // 
            // guna2DragControl3
            // 
            this.guna2DragControl3.TransparentWhileDrag = true;
            this.guna2DragControl3.UseTransparentDrag = true;
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
            this.guna2Transition1.TimeStep = 0.017F;
            // 
            // CheckReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 740);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpEDate);
            this.Controls.Add(this.lblEDate);
            this.Controls.Add(this.dtpSDate);
            this.Controls.Add(this.lblSDate);
            this.Controls.Add(this.lblReportType);
            this.Controls.Add(this.cboReportType);
            this.Controls.Add(this.btnDetail);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition_menu.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CheckReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CheckReport";
            this.Load += new System.EventHandler(this.CheckReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition_menu;
        private Guna.UI2.WinForms.Guna2Button btnDetail;
        private System.Windows.Forms.Timer timer_menu;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl3;
        private Guna.UI2.WinForms.Guna2ComboBox cboReportType;
        private System.Windows.Forms.Label lblReportType;
        private System.Windows.Forms.Label lblSDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpSDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpEDate;
        private System.Windows.Forms.Label lblEDate;
        private System.Windows.Forms.Label label1;
    }
}