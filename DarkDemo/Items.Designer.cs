
namespace DarkDemo
{
    partial class Items
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
            Guna.UI2.AnimatorNS.Animation animation17 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Items));
            Guna.UI2.AnimatorNS.Animation animation18 = new Guna.UI2.AnimatorNS.Animation();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.tbtnPickup = new Guna.UI2.WinForms.Guna2TileButton();
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.tbtnDTD = new Guna.UI2.WinForms.Guna2TileButton();
            this.PanelPickup = new Guna.UI2.WinForms.Guna2Panel();
            this.btnPickup = new Guna.UI2.WinForms.Guna2Button();
            this.txtShipID = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblShipmentID = new System.Windows.Forms.Label();
            this.dtpDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblBranch = new System.Windows.Forms.Label();
            this.cbBranch = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.panelDTD = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.btnRemoveItem = new Guna.UI2.WinForms.Guna2Button();
            this.lblReminder = new System.Windows.Forms.Label();
            this.lsvItem = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Weight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Length = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Width = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Height = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.lblx1 = new System.Windows.Forms.Label();
            this.txtWidth = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtHeight = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.txtDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtLength = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtWeight = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.btnDTD = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.timer_menu = new System.Windows.Forms.Timer(this.components);
            this.guna2Transition_menu = new Guna.UI2.WinForms.Guna2Transition();
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl3 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.PanelPickup.SuspendLayout();
            this.panelDTD.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbtnPickup
            // 
            this.tbtnPickup.CheckedState.Parent = this.tbtnPickup;
            this.tbtnPickup.CustomImages.Parent = this.tbtnPickup;
            this.guna2Transition_menu.SetDecoration(this.tbtnPickup, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.tbtnPickup, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tbtnPickup.DisabledState.Parent = this.tbtnPickup;
            this.tbtnPickup.FillColor = System.Drawing.SystemColors.Control;
            this.tbtnPickup.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.tbtnPickup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbtnPickup.HoverState.Parent = this.tbtnPickup;
            this.tbtnPickup.Location = new System.Drawing.Point(229, 52);
            this.tbtnPickup.Name = "tbtnPickup";
            this.tbtnPickup.ShadowDecoration.Parent = this.tbtnPickup;
            this.tbtnPickup.Size = new System.Drawing.Size(423, 43);
            this.tbtnPickup.TabIndex = 38;
            this.tbtnPickup.Text = "Book Pickup";
            this.tbtnPickup.Click += new System.EventHandler(this.tbtnPickup_Click);
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            this.guna2Transition1.Cursor = null;
            animation17.AnimateOnlyDifferences = true;
            animation17.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation17.BlindCoeff")));
            animation17.LeafCoeff = 0F;
            animation17.MaxTime = 1F;
            animation17.MinTime = 0F;
            animation17.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation17.MosaicCoeff")));
            animation17.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation17.MosaicShift")));
            animation17.MosaicSize = 0;
            animation17.Padding = new System.Windows.Forms.Padding(0);
            animation17.RotateCoeff = 0F;
            animation17.RotateLimit = 0F;
            animation17.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation17.ScaleCoeff")));
            animation17.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation17.SlideCoeff")));
            animation17.TimeCoeff = 0F;
            animation17.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation17;
            this.guna2Transition1.TimeStep = 0.017F;
            // 
            // tbtnDTD
            // 
            this.tbtnDTD.CheckedState.Parent = this.tbtnDTD;
            this.tbtnDTD.CustomImages.Parent = this.tbtnDTD;
            this.guna2Transition_menu.SetDecoration(this.tbtnDTD, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.tbtnDTD, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tbtnDTD.DisabledState.Parent = this.tbtnDTD;
            this.tbtnDTD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbtnDTD.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.tbtnDTD.ForeColor = System.Drawing.SystemColors.Control;
            this.tbtnDTD.HoverState.Parent = this.tbtnDTD;
            this.tbtnDTD.Location = new System.Drawing.Point(649, 52);
            this.tbtnDTD.Name = "tbtnDTD";
            this.tbtnDTD.ShadowDecoration.Parent = this.tbtnDTD;
            this.tbtnDTD.Size = new System.Drawing.Size(423, 43);
            this.tbtnDTD.TabIndex = 39;
            this.tbtnDTD.Text = "Book Door-To-Door Pickup";
            this.tbtnDTD.Click += new System.EventHandler(this.tbtnDTD_Click);
            // 
            // PanelPickup
            // 
            this.PanelPickup.Controls.Add(this.btnPickup);
            this.PanelPickup.Controls.Add(this.txtShipID);
            this.PanelPickup.Controls.Add(this.lblShipmentID);
            this.PanelPickup.Controls.Add(this.dtpDate);
            this.PanelPickup.Controls.Add(this.lblBranch);
            this.PanelPickup.Controls.Add(this.cbBranch);
            this.PanelPickup.Controls.Add(this.lblDate);
            this.guna2Transition_menu.SetDecoration(this.PanelPickup, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.PanelPickup, Guna.UI2.AnimatorNS.DecorationType.None);
            this.PanelPickup.Location = new System.Drawing.Point(221, 101);
            this.PanelPickup.Name = "PanelPickup";
            this.PanelPickup.ShadowDecoration.Parent = this.PanelPickup;
            this.PanelPickup.Size = new System.Drawing.Size(922, 579);
            this.PanelPickup.TabIndex = 37;
            this.PanelPickup.Visible = false;
            // 
            // btnPickup
            // 
            this.btnPickup.CheckedState.Parent = this.btnPickup;
            this.btnPickup.CustomImages.Parent = this.btnPickup;
            this.guna2Transition_menu.SetDecoration(this.btnPickup, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.btnPickup, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnPickup.DisabledState.Parent = this.btnPickup;
            this.btnPickup.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPickup.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnPickup.ForeColor = System.Drawing.Color.White;
            this.btnPickup.HoverState.Parent = this.btnPickup;
            this.btnPickup.Location = new System.Drawing.Point(729, 503);
            this.btnPickup.Name = "btnPickup";
            this.btnPickup.ShadowDecoration.Parent = this.btnPickup;
            this.btnPickup.Size = new System.Drawing.Size(162, 38);
            this.btnPickup.TabIndex = 32;
            this.btnPickup.Text = "Confirm";
            // 
            // txtShipID
            // 
            this.txtShipID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition_menu.SetDecoration(this.txtShipID, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.txtShipID, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtShipID.DefaultText = "";
            this.txtShipID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtShipID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtShipID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtShipID.DisabledState.Parent = this.txtShipID;
            this.txtShipID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtShipID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtShipID.FocusedState.Parent = this.txtShipID;
            this.txtShipID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtShipID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtShipID.HoverState.Parent = this.txtShipID;
            this.txtShipID.Location = new System.Drawing.Point(196, 45);
            this.txtShipID.Name = "txtShipID";
            this.txtShipID.PasswordChar = '\0';
            this.txtShipID.PlaceholderText = "";
            this.txtShipID.SelectedText = "";
            this.txtShipID.ShadowDecoration.Parent = this.txtShipID;
            this.txtShipID.Size = new System.Drawing.Size(200, 35);
            this.txtShipID.TabIndex = 23;
            // 
            // lblShipmentID
            // 
            this.lblShipmentID.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.lblShipmentID, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition_menu.SetDecoration(this.lblShipmentID, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblShipmentID.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblShipmentID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.lblShipmentID.Location = new System.Drawing.Point(43, 59);
            this.lblShipmentID.Name = "lblShipmentID";
            this.lblShipmentID.Size = new System.Drawing.Size(113, 21);
            this.lblShipmentID.TabIndex = 20;
            this.lblShipmentID.Text = "Shipment ID: ";
            // 
            // dtpDate
            // 
            this.dtpDate.CheckedState.Parent = this.dtpDate;
            this.guna2Transition_menu.SetDecoration(this.dtpDate, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.dtpDate, Guna.UI2.AnimatorNS.DecorationType.None);
            this.dtpDate.FillColor = System.Drawing.Color.White;
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDate.ForeColor = System.Drawing.Color.Black;
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.HoverState.Parent = this.dtpDate;
            this.dtpDate.Location = new System.Drawing.Point(196, 204);
            this.dtpDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.ShadowDecoration.Parent = this.dtpDate;
            this.dtpDate.Size = new System.Drawing.Size(200, 36);
            this.dtpDate.TabIndex = 25;
            this.dtpDate.Value = new System.DateTime(2021, 5, 7, 23, 34, 46, 35);
            // 
            // lblBranch
            // 
            this.lblBranch.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.lblBranch, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition_menu.SetDecoration(this.lblBranch, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblBranch.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblBranch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.lblBranch.Location = new System.Drawing.Point(43, 139);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(73, 21);
            this.lblBranch.TabIndex = 21;
            this.lblBranch.Text = "Branch: ";
            // 
            // cbBranch
            // 
            this.cbBranch.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition_menu.SetDecoration(this.cbBranch, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.cbBranch, Guna.UI2.AnimatorNS.DecorationType.None);
            this.cbBranch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBranch.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbBranch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbBranch.FocusedState.Parent = this.cbBranch;
            this.cbBranch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbBranch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbBranch.HoverState.Parent = this.cbBranch;
            this.cbBranch.ItemHeight = 30;
            this.cbBranch.ItemsAppearance.Parent = this.cbBranch;
            this.cbBranch.Location = new System.Drawing.Point(196, 124);
            this.cbBranch.Name = "cbBranch";
            this.cbBranch.ShadowDecoration.Parent = this.cbBranch;
            this.cbBranch.Size = new System.Drawing.Size(200, 36);
            this.cbBranch.TabIndex = 24;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.lblDate, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition_menu.SetDecoration(this.lblDate, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblDate.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.lblDate.Location = new System.Drawing.Point(43, 219);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(58, 21);
            this.lblDate.TabIndex = 22;
            this.lblDate.Text = "Date: ";
            // 
            // panelDTD
            // 
            this.panelDTD.Controls.Add(this.btnBack);
            this.panelDTD.Controls.Add(this.btnRemoveItem);
            this.panelDTD.Controls.Add(this.lblReminder);
            this.panelDTD.Controls.Add(this.lsvItem);
            this.panelDTD.Controls.Add(this.label1);
            this.panelDTD.Controls.Add(this.lblx1);
            this.panelDTD.Controls.Add(this.txtWidth);
            this.panelDTD.Controls.Add(this.txtHeight);
            this.panelDTD.Controls.Add(this.btnAdd);
            this.panelDTD.Controls.Add(this.txtDescription);
            this.panelDTD.Controls.Add(this.lblDescription);
            this.panelDTD.Controls.Add(this.txtLength);
            this.panelDTD.Controls.Add(this.txtValue);
            this.panelDTD.Controls.Add(this.txtWeight);
            this.panelDTD.Controls.Add(this.lblValue);
            this.panelDTD.Controls.Add(this.lblSize);
            this.panelDTD.Controls.Add(this.lblWeight);
            this.panelDTD.Controls.Add(this.lblItem);
            this.panelDTD.Controls.Add(this.btnDTD);
            this.guna2Transition_menu.SetDecoration(this.panelDTD, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.panelDTD, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panelDTD.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.panelDTD.Location = new System.Drawing.Point(221, 101);
            this.panelDTD.Name = "panelDTD";
            this.panelDTD.ShadowDecoration.Parent = this.panelDTD;
            this.panelDTD.Size = new System.Drawing.Size(922, 603);
            this.panelDTD.TabIndex = 33;
            this.panelDTD.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDTD_Paint);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.BorderColor = System.Drawing.Color.White;
            this.btnBack.CheckedState.Parent = this.btnBack;
            this.btnBack.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnBack.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBack.CustomImages.Parent = this.btnBack;
            this.guna2Transition_menu.SetDecoration(this.btnBack, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.btnBack, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnBack.DisabledState.Parent = this.btnBack;
            this.btnBack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBack.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.HoverState.Parent = this.btnBack;
            this.btnBack.Location = new System.Drawing.Point(543, 532);
            this.btnBack.Name = "btnBack";
            this.btnBack.ShadowDecoration.Parent = this.btnBack;
            this.btnBack.Size = new System.Drawing.Size(127, 38);
            this.btnBack.TabIndex = 53;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemoveItem.AutoRoundedCorners = true;
            this.btnRemoveItem.BorderRadius = 16;
            this.btnRemoveItem.CheckedState.Parent = this.btnRemoveItem;
            this.btnRemoveItem.CustomImages.Parent = this.btnRemoveItem;
            this.guna2Transition_menu.SetDecoration(this.btnRemoveItem, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.btnRemoveItem, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnRemoveItem.DisabledState.Parent = this.btnRemoveItem;
            this.btnRemoveItem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRemoveItem.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnRemoveItem.ForeColor = System.Drawing.Color.White;
            this.btnRemoveItem.HoverState.Parent = this.btnRemoveItem;
            this.btnRemoveItem.Location = new System.Drawing.Point(796, 197);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.ShadowDecoration.Parent = this.btnRemoveItem;
            this.btnRemoveItem.Size = new System.Drawing.Size(38, 35);
            this.btnRemoveItem.TabIndex = 52;
            this.btnRemoveItem.Text = "-";
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // lblReminder
            // 
            this.lblReminder.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.lblReminder, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition_menu.SetDecoration(this.lblReminder, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblReminder.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.lblReminder.Location = new System.Drawing.Point(571, 13);
            this.lblReminder.Name = "lblReminder";
            this.lblReminder.Size = new System.Drawing.Size(320, 48);
            this.lblReminder.TabIndex = 51;
            this.lblReminder.Text = "Maximum weight limit of EDE Express Document Envelope \r\nis less than 3 Kg. If doc" +
    "ument weightexceeds the limit, \r\nshipment will be delivered through Express Frei" +
    "ght.";
            // 
            // lsvItem
            // 
            this.lsvItem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.Description,
            this.Weight,
            this.Length,
            this.Width,
            this.Height,
            this.Value});
            this.guna2Transition_menu.SetDecoration(this.lsvItem, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.lsvItem, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lsvItem.FullRowSelect = true;
            this.lsvItem.HideSelection = false;
            this.lsvItem.Location = new System.Drawing.Point(38, 260);
            this.lsvItem.Name = "lsvItem";
            this.lsvItem.Size = new System.Drawing.Size(796, 237);
            this.lsvItem.TabIndex = 50;
            this.lsvItem.UseCompatibleStateImageBehavior = false;
            this.lsvItem.View = System.Windows.Forms.View.Details;
            this.lsvItem.SelectedIndexChanged += new System.EventHandler(this.lsvItem_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.Text = "Item ID";
            this.id.Width = 100;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 240;
            // 
            // Weight
            // 
            this.Weight.Text = "Weight";
            this.Weight.Width = 90;
            // 
            // Length
            // 
            this.Length.Text = "Length";
            this.Length.Width = 90;
            // 
            // Width
            // 
            this.Width.Text = "Width";
            this.Width.Width = 90;
            // 
            // Height
            // 
            this.Height.Text = "Height";
            this.Height.Width = 90;
            // 
            // Value
            // 
            this.Value.Text = "Value";
            this.Value.Width = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition_menu.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label1.Location = new System.Drawing.Point(366, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 21);
            this.label1.TabIndex = 49;
            this.label1.Text = "x";
            // 
            // lblx1
            // 
            this.lblx1.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.lblx1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition_menu.SetDecoration(this.lblx1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblx1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblx1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.lblx1.Location = new System.Drawing.Point(288, 144);
            this.lblx1.Name = "lblx1";
            this.lblx1.Size = new System.Drawing.Size(18, 21);
            this.lblx1.TabIndex = 48;
            this.lblx1.Text = "x";
            // 
            // txtWidth
            // 
            this.txtWidth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition_menu.SetDecoration(this.txtWidth, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.txtWidth, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtWidth.DefaultText = "";
            this.txtWidth.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtWidth.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtWidth.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtWidth.DisabledState.Parent = this.txtWidth;
            this.txtWidth.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtWidth.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtWidth.FocusedState.Parent = this.txtWidth;
            this.txtWidth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtWidth.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtWidth.HoverState.Parent = this.txtWidth;
            this.txtWidth.Location = new System.Drawing.Point(312, 137);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.PasswordChar = '\0';
            this.txtWidth.PlaceholderText = "Number";
            this.txtWidth.SelectedText = "";
            this.txtWidth.ShadowDecoration.Parent = this.txtWidth;
            this.txtWidth.Size = new System.Drawing.Size(50, 35);
            this.txtWidth.TabIndex = 47;
            this.txtWidth.TextChanged += new System.EventHandler(this.txtWidth_TextChanged);
            // 
            // txtHeight
            // 
            this.txtHeight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition_menu.SetDecoration(this.txtHeight, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.txtHeight, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtHeight.DefaultText = "";
            this.txtHeight.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHeight.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHeight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHeight.DisabledState.Parent = this.txtHeight;
            this.txtHeight.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHeight.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHeight.FocusedState.Parent = this.txtHeight;
            this.txtHeight.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHeight.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHeight.HoverState.Parent = this.txtHeight;
            this.txtHeight.Location = new System.Drawing.Point(387, 137);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.PasswordChar = '\0';
            this.txtHeight.PlaceholderText = "Number";
            this.txtHeight.SelectedText = "";
            this.txtHeight.ShadowDecoration.Parent = this.txtHeight;
            this.txtHeight.Size = new System.Drawing.Size(50, 35);
            this.txtHeight.TabIndex = 46;
            this.txtHeight.TextChanged += new System.EventHandler(this.txtHeight_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.AutoRoundedCorners = true;
            this.btnAdd.BorderRadius = 16;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.guna2Transition_menu.SetDecoration(this.btnAdd, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.btnAdd, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnAdd.DisabledState.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(796, 134);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(38, 35);
            this.btnAdd.TabIndex = 45;
            this.btnAdd.Text = "+";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition_menu.SetDecoration(this.txtDescription, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.txtDescription, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtDescription.DefaultText = "";
            this.txtDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescription.DisabledState.Parent = this.txtDescription;
            this.txtDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescription.FocusedState.Parent = this.txtDescription;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescription.HoverState.Parent = this.txtDescription;
            this.txtDescription.Location = new System.Drawing.Point(511, 107);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.PlaceholderText = "Briefly Descript Your Item";
            this.txtDescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDescription.SelectedText = "";
            this.txtDescription.ShadowDecoration.Parent = this.txtDescription;
            this.txtDescription.Size = new System.Drawing.Size(254, 133);
            this.txtDescription.TabIndex = 43;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.lblDescription, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition_menu.SetDecoration(this.lblDescription, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblDescription.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.lblDescription.Location = new System.Drawing.Point(507, 71);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(137, 21);
            this.lblDescription.TabIndex = 42;
            this.lblDescription.Text = "Brief Description:";
            // 
            // txtLength
            // 
            this.txtLength.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition_menu.SetDecoration(this.txtLength, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.txtLength, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtLength.DefaultText = "";
            this.txtLength.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLength.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLength.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLength.DisabledState.Parent = this.txtLength;
            this.txtLength.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLength.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLength.FocusedState.Parent = this.txtLength;
            this.txtLength.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLength.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLength.HoverState.Parent = this.txtLength;
            this.txtLength.Location = new System.Drawing.Point(232, 137);
            this.txtLength.Name = "txtLength";
            this.txtLength.PasswordChar = '\0';
            this.txtLength.PlaceholderText = "Number";
            this.txtLength.SelectedText = "";
            this.txtLength.ShadowDecoration.Parent = this.txtLength;
            this.txtLength.Size = new System.Drawing.Size(50, 35);
            this.txtLength.TabIndex = 41;
            this.txtLength.TextChanged += new System.EventHandler(this.txtLength_TextChanged);
            // 
            // txtValue
            // 
            this.txtValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition_menu.SetDecoration(this.txtValue, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.txtValue, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtValue.DefaultText = "";
            this.txtValue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtValue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtValue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtValue.DisabledState.Parent = this.txtValue;
            this.txtValue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtValue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtValue.FocusedState.Parent = this.txtValue;
            this.txtValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtValue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtValue.HoverState.Parent = this.txtValue;
            this.txtValue.Location = new System.Drawing.Point(232, 217);
            this.txtValue.Name = "txtValue";
            this.txtValue.PasswordChar = '\0';
            this.txtValue.PlaceholderText = "$HKD 120";
            this.txtValue.SelectedText = "";
            this.txtValue.ShadowDecoration.Parent = this.txtValue;
            this.txtValue.Size = new System.Drawing.Size(208, 35);
            this.txtValue.TabIndex = 40;
            // 
            // txtWeight
            // 
            this.txtWeight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition_menu.SetDecoration(this.txtWeight, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.txtWeight, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtWeight.DefaultText = "";
            this.txtWeight.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtWeight.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtWeight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtWeight.DisabledState.Parent = this.txtWeight;
            this.txtWeight.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtWeight.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtWeight.FocusedState.Parent = this.txtWeight;
            this.txtWeight.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtWeight.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtWeight.HoverState.Parent = this.txtWeight;
            this.txtWeight.Location = new System.Drawing.Point(232, 71);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.PasswordChar = '\0';
            this.txtWeight.PlaceholderText = "Please Iuput a Number";
            this.txtWeight.SelectedText = "";
            this.txtWeight.ShadowDecoration.Parent = this.txtWeight;
            this.txtWeight.Size = new System.Drawing.Size(208, 35);
            this.txtWeight.TabIndex = 39;
            this.txtWeight.TextChanged += new System.EventHandler(this.txtWeight_TextChanged);
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.lblValue, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition_menu.SetDecoration(this.lblValue, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblValue.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.lblValue.Location = new System.Drawing.Point(45, 221);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(167, 21);
            this.lblValue.TabIndex = 38;
            this.lblValue.Text = "Approximate Value:\r\n";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.lblSize, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition_menu.SetDecoration(this.lblSize, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblSize.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.lblSize.Location = new System.Drawing.Point(56, 144);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(156, 21);
            this.lblSize.TabIndex = 36;
            this.lblSize.Text = "Size(L x W x H)(cm):";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.lblWeight, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition_menu.SetDecoration(this.lblWeight, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblWeight.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblWeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.lblWeight.Location = new System.Drawing.Point(79, 71);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(102, 21);
            this.lblWeight.TabIndex = 35;
            this.lblWeight.Text = "Weight(Kg):";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.lblItem, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition_menu.SetDecoration(this.lblItem, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblItem.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.lblItem.Location = new System.Drawing.Point(20, 21);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(161, 22);
            this.lblItem.TabIndex = 33;
            this.lblItem.Text = "Item Information";
            // 
            // btnDTD
            // 
            this.btnDTD.CheckedState.Parent = this.btnDTD;
            this.btnDTD.CustomImages.Parent = this.btnDTD;
            this.guna2Transition_menu.SetDecoration(this.btnDTD, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.btnDTD, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnDTD.DisabledState.Parent = this.btnDTD;
            this.btnDTD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDTD.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F);
            this.btnDTD.ForeColor = System.Drawing.Color.White;
            this.btnDTD.HoverState.Parent = this.btnDTD;
            this.btnDTD.Location = new System.Drawing.Point(705, 532);
            this.btnDTD.Name = "btnDTD";
            this.btnDTD.ShadowDecoration.Parent = this.btnDTD;
            this.btnDTD.Size = new System.Drawing.Size(162, 38);
            this.btnDTD.TabIndex = 31;
            this.btnDTD.Text = "Confirm";
            this.btnDTD.Click += new System.EventHandler(this.btnDTD_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.ContainerControl = this;
            this.guna2DragControl1.TransparentWhileDrag = true;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // timer_menu
            // 
            this.timer_menu.Tick += new System.EventHandler(this.timer_menu_Tick);
            // 
            // guna2Transition_menu
            // 
            this.guna2Transition_menu.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            this.guna2Transition_menu.Cursor = null;
            animation18.AnimateOnlyDifferences = true;
            animation18.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation18.BlindCoeff")));
            animation18.LeafCoeff = 0F;
            animation18.MaxTime = 1F;
            animation18.MinTime = 0F;
            animation18.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation18.MosaicCoeff")));
            animation18.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation18.MosaicShift")));
            animation18.MosaicSize = 0;
            animation18.Padding = new System.Windows.Forms.Padding(0);
            animation18.RotateCoeff = 0F;
            animation18.RotateLimit = 0F;
            animation18.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation18.ScaleCoeff")));
            animation18.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation18.SlideCoeff")));
            animation18.TimeCoeff = 0F;
            animation18.TransparencyCoeff = 0F;
            this.guna2Transition_menu.DefaultAnimation = animation18;
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
            // Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 683);
            this.Controls.Add(this.panelDTD);
            this.Controls.Add(this.tbtnPickup);
            this.Controls.Add(this.tbtnDTD);
            this.Controls.Add(this.PanelPickup);
            this.guna2Transition_menu.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Items";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Items";
            this.Load += new System.EventHandler(this.Items_Load);
            this.PanelPickup.ResumeLayout(false);
            this.PanelPickup.PerformLayout();
            this.panelDTD.ResumeLayout(false);
            this.panelDTD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TileButton tbtnPickup;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2TileButton tbtnDTD;
        private Guna.UI2.WinForms.Guna2Panel PanelPickup;
        private Guna.UI2.WinForms.Guna2GradientPanel panelDTD;
        private Guna.UI2.WinForms.Guna2TextBox txtValue;
        private Guna.UI2.WinForms.Guna2TextBox txtWeight;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblItem;
        private Guna.UI2.WinForms.Guna2Button btnDTD;
        private Guna.UI2.WinForms.Guna2Button btnPickup;
        private Guna.UI2.WinForms.Guna2TextBox txtShipID;
        private System.Windows.Forms.Label lblShipmentID;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblBranch;
        private Guna.UI2.WinForms.Guna2ComboBox cbBranch;
        private System.Windows.Forms.Label lblDate;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2TextBox txtLength;
        private Guna.UI2.WinForms.Guna2TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2TextBox txtWidth;
        private Guna.UI2.WinForms.Guna2TextBox txtHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblx1;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition_menu;
        private System.Windows.Forms.Timer timer_menu;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl3;
        private System.Windows.Forms.ListView lsvItem;
        private System.Windows.Forms.Label lblReminder;
        private Guna.UI2.WinForms.Guna2Button btnRemoveItem;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader Weight;
        private System.Windows.Forms.ColumnHeader Height;
        private System.Windows.Forms.ColumnHeader Width;
        private System.Windows.Forms.ColumnHeader Length;
        private System.Windows.Forms.ColumnHeader Value;
        private Guna.UI2.WinForms.Guna2Button btnBack;
    }
}