
namespace DarkDemo
{
    partial class UpdateShipments
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
            Guna.UI2.AnimatorNS.Animation animation2 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateShipments));
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.txtShipmentID = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateStatus = new Guna.UI2.WinForms.Guna2Button();
            this.cboStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lsvDelivery = new System.Windows.Forms.ListView();
            this.ShipmentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.From = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.To = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label15 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Panel_Dargcontrl_big = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.Panel_Dargcontrl = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2DragControl3 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Panel_Dargcontrl_big.SuspendLayout();
            this.SuspendLayout();
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
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Transition1.SetDecoration(this.guna2ControlBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1124, 21);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 15;
            // 
            // txtShipmentID
            // 
            this.txtShipmentID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.txtShipmentID, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtShipmentID.DefaultText = "";
            this.txtShipmentID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtShipmentID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtShipmentID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtShipmentID.DisabledState.Parent = this.txtShipmentID;
            this.txtShipmentID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtShipmentID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtShipmentID.FocusedState.Parent = this.txtShipmentID;
            this.txtShipmentID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtShipmentID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtShipmentID.HoverState.Parent = this.txtShipmentID;
            this.txtShipmentID.Location = new System.Drawing.Point(680, 73);
            this.txtShipmentID.Name = "txtShipmentID";
            this.txtShipmentID.PasswordChar = '\0';
            this.txtShipmentID.PlaceholderText = "Shipment ID";
            this.txtShipmentID.SelectedText = "";
            this.txtShipmentID.ShadowDecoration.Parent = this.txtShipmentID;
            this.txtShipmentID.Size = new System.Drawing.Size(210, 45);
            this.txtShipmentID.TabIndex = 16;
            this.txtShipmentID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtShipmentID_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.CustomImages.Parent = this.btnSearch;
            this.guna2Transition1.SetDecoration(this.btnSearch, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnSearch.DisabledState.Parent = this.btnSearch;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Location = new System.Drawing.Point(916, 73);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(151, 45);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdateStatus
            // 
            this.btnUpdateStatus.CheckedState.Parent = this.btnUpdateStatus;
            this.btnUpdateStatus.CustomImages.Parent = this.btnUpdateStatus;
            this.guna2Transition1.SetDecoration(this.btnUpdateStatus, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnUpdateStatus.DisabledState.Parent = this.btnUpdateStatus;
            this.btnUpdateStatus.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnUpdateStatus.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnUpdateStatus.ForeColor = System.Drawing.Color.White;
            this.btnUpdateStatus.HoverState.Parent = this.btnUpdateStatus;
            this.btnUpdateStatus.Location = new System.Drawing.Point(916, 125);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.ShadowDecoration.Parent = this.btnUpdateStatus;
            this.btnUpdateStatus.Size = new System.Drawing.Size(151, 46);
            this.btnUpdateStatus.TabIndex = 19;
            this.btnUpdateStatus.Text = "Update Status";
            this.btnUpdateStatus.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // cboStatus
            // 
            this.cboStatus.AccessibleDescription = "";
            this.cboStatus.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.cboStatus, Guna.UI2.AnimatorNS.DecorationType.None);
            this.cboStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboStatus.FocusedState.Parent = this.cboStatus;
            this.cboStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboStatus.HoverState.Parent = this.cboStatus;
            this.cboStatus.ItemHeight = 35;
            this.cboStatus.Items.AddRange(new object[] {
            "Collecting package",
            "Collected",
            "Delivering",
            "Arrived at Destination",
            "Out for Delivery",
            "Delivered"});
            this.cboStatus.ItemsAppearance.Parent = this.cboStatus;
            this.cboStatus.Location = new System.Drawing.Point(47, 125);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.ShadowDecoration.Parent = this.cboStatus;
            this.cboStatus.Size = new System.Drawing.Size(341, 41);
            this.cboStatus.TabIndex = 20;
            this.cboStatus.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label1.Location = new System.Drawing.Point(42, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Status";
            // 
            // lsvDelivery
            // 
            this.lsvDelivery.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ShipmentID,
            this.From,
            this.To,
            this.Status});
            this.guna2Transition1.SetDecoration(this.lsvDelivery, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lsvDelivery.FullRowSelect = true;
            this.lsvDelivery.HideSelection = false;
            this.lsvDelivery.Location = new System.Drawing.Point(47, 192);
            this.lsvDelivery.Name = "lsvDelivery";
            this.lsvDelivery.Size = new System.Drawing.Size(1110, 529);
            this.lsvDelivery.TabIndex = 24;
            this.lsvDelivery.UseCompatibleStateImageBehavior = false;
            this.lsvDelivery.View = System.Windows.Forms.View.Details;
            this.lsvDelivery.SelectedIndexChanged += new System.EventHandler(this.lsvDelivery_SelectedIndexChanged);
            // 
            // ShipmentID
            // 
            this.ShipmentID.Text = "ShipmentID";
            this.ShipmentID.Width = 230;
            // 
            // From
            // 
            this.From.Text = "From";
            this.From.Width = 230;
            // 
            // To
            // 
            this.To.Text = "To";
            this.To.Width = 230;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.Width = 280;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label15, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label15.Location = new System.Drawing.Point(41, 37);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(337, 36);
            this.label15.TabIndex = 97;
            this.label15.Text = "Update Shipping Status";
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
            this.guna2DragControl2.TargetControl = this.Panel_Dargcontrl_big;
            this.guna2DragControl2.TransparentWhileDrag = true;
            this.guna2DragControl2.UseTransparentDrag = true;
            // 
            // Panel_Dargcontrl_big
            // 
            this.Panel_Dargcontrl_big.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Dargcontrl_big.Controls.Add(this.Panel_Dargcontrl);
            this.guna2Transition1.SetDecoration(this.Panel_Dargcontrl_big, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Panel_Dargcontrl_big.Location = new System.Drawing.Point(345, 0);
            this.Panel_Dargcontrl_big.Name = "Panel_Dargcontrl_big";
            this.Panel_Dargcontrl_big.ShadowDecoration.Parent = this.Panel_Dargcontrl_big;
            this.Panel_Dargcontrl_big.Size = new System.Drawing.Size(450, 40);
            this.Panel_Dargcontrl_big.TabIndex = 98;
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
            this.guna2DragControl3.TargetControl = this.Panel_Dargcontrl;
            this.guna2DragControl3.TransparentWhileDrag = true;
            this.guna2DragControl3.UseTransparentDrag = true;
            // 
            // UpdateShipments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Controls.Add(this.Panel_Dargcontrl_big);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lsvDelivery);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.btnUpdateStatus);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtShipmentID);
            this.Controls.Add(this.guna2ControlBox1);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateShipments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UpdateShipments";
            this.Load += new System.EventHandler(this.UpdateShipments_Load);
            this.Panel_Dargcontrl_big.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtShipmentID;
        private Guna.UI2.WinForms.Guna2Button btnUpdateStatus;
        private Guna.UI2.WinForms.Guna2ComboBox cboStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lsvDelivery;
        private System.Windows.Forms.ColumnHeader ShipmentID;
        private System.Windows.Forms.ColumnHeader From;
        private System.Windows.Forms.ColumnHeader To;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.Label label15;
        private Guna.UI2.WinForms.Guna2GradientPanel Panel_Dargcontrl_big;
        private Guna.UI2.WinForms.Guna2GradientPanel Panel_Dargcontrl;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl3;
    }
}