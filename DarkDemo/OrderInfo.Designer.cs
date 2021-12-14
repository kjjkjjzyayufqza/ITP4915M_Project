
namespace DarkDemo
{
    partial class OrderInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderInfo));
            this.lblDetail = new System.Windows.Forms.Label();
            this.lblShipmentID = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lsvItem = new System.Windows.Forms.ListView();
            this.itemID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.weight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCompany = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnConfirm = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.panelEdit = new Guna.UI2.WinForms.Guna2Panel();
            this.lblStatusEdit = new System.Windows.Forms.Label();
            this.lblPriceEdit = new System.Windows.Forms.Label();
            this.lblDateEdit = new System.Windows.Forms.Label();
            this.lblPhoneEdit = new System.Windows.Forms.Label();
            this.lblNameEdit = new System.Windows.Forms.Label();
            this.lblCompanyEdit = new System.Windows.Forms.Label();
            this.lblAddressEdit = new System.Windows.Forms.Label();
            this.lblShipmentIDEdit = new System.Windows.Forms.Label();
            this.panelCheck = new Guna.UI2.WinForms.Guna2Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Panel_Dargcontrl = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.Panel_Dargcontrl_big = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panelEdit.SuspendLayout();
            this.panelCheck.SuspendLayout();
            this.Panel_Dargcontrl_big.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDetail
            // 
            this.lblDetail.AutoSize = true;
            this.lblDetail.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.lblDetail.Location = new System.Drawing.Point(99, 20);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(107, 46);
            this.lblDetail.TabIndex = 0;
            this.lblDetail.Text = "Detail";
            // 
            // lblShipmentID
            // 
            this.lblShipmentID.AutoSize = true;
            this.lblShipmentID.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblShipmentID.Location = new System.Drawing.Point(20, 20);
            this.lblShipmentID.Name = "lblShipmentID";
            this.lblShipmentID.Size = new System.Drawing.Size(124, 25);
            this.lblShipmentID.TabIndex = 1;
            this.lblShipmentID.Text = "ShipmentID : ";
            this.lblShipmentID.Click += new System.EventHandler(this.lblShipmentID_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblAddress.Location = new System.Drawing.Point(20, 80);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(122, 25);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Destination : ";
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblCompany.Location = new System.Drawing.Point(20, 140);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(161, 25);
            this.lblCompany.TabIndex = 3;
            this.lblCompany.Text = "Company Name : ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblName.Location = new System.Drawing.Point(20, 200);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(76, 25);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name : ";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblPhone.Location = new System.Drawing.Point(20, 260);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(80, 25);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "Phone : ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblDate.Location = new System.Drawing.Point(20, 320);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(125, 25);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Create Date : ";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblPrice.Location = new System.Drawing.Point(20, 380);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(68, 25);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "Price : ";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblStatus.Location = new System.Drawing.Point(20, 440);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(76, 25);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Status : ";
            // 
            // lsvItem
            // 
            this.lsvItem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.itemID,
            this.size,
            this.weight,
            this.description});
            this.lsvItem.Enabled = false;
            this.lsvItem.FullRowSelect = true;
            this.lsvItem.HideSelection = false;
            this.lsvItem.Location = new System.Drawing.Point(587, 78);
            this.lsvItem.Name = "lsvItem";
            this.lsvItem.Size = new System.Drawing.Size(578, 614);
            this.lsvItem.TabIndex = 9;
            this.lsvItem.UseCompatibleStateImageBehavior = false;
            this.lsvItem.View = System.Windows.Forms.View.Details;
            // 
            // itemID
            // 
            this.itemID.Text = "Item ID";
            this.itemID.Width = 100;
            // 
            // size
            // 
            this.size.Text = "Size (L x W x H)";
            this.size.Width = 130;
            // 
            // weight
            // 
            this.weight.Text = "Weight";
            this.weight.Width = 130;
            // 
            // description
            // 
            this.description.Text = "Description";
            this.description.Width = 250;
            // 
            // btnEdit
            // 
            this.btnEdit.CheckedState.Parent = this.btnEdit;
            this.btnEdit.CustomImages.Parent = this.btnEdit;
            this.btnEdit.DisabledState.Parent = this.btnEdit;
            this.btnEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.HoverState.Parent = this.btnEdit;
            this.btnEdit.Location = new System.Drawing.Point(306, 529);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ShadowDecoration.Parent = this.btnEdit;
            this.btnEdit.Size = new System.Drawing.Size(103, 38);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.Parent = this.txtName;
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.FocusedState.Parent = this.txtName;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.HoverState.Parent = this.txtName;
            this.txtName.Location = new System.Drawing.Point(187, 200);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "";
            this.txtName.SelectedText = "";
            this.txtName.ShadowDecoration.Parent = this.txtName;
            this.txtName.Size = new System.Drawing.Size(200, 36);
            this.txtName.TabIndex = 12;
            // 
            // txtPhone
            // 
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.DefaultText = "";
            this.txtPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.DisabledState.Parent = this.txtPhone;
            this.txtPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.FocusedState.Parent = this.txtPhone;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.HoverState.Parent = this.txtPhone;
            this.txtPhone.Location = new System.Drawing.Point(187, 260);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.PlaceholderText = "";
            this.txtPhone.SelectedText = "";
            this.txtPhone.ShadowDecoration.Parent = this.txtPhone;
            this.txtPhone.Size = new System.Drawing.Size(200, 36);
            this.txtPhone.TabIndex = 13;
            // 
            // txtCompany
            // 
            this.txtCompany.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCompany.DefaultText = "";
            this.txtCompany.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCompany.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCompany.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCompany.DisabledState.Parent = this.txtCompany;
            this.txtCompany.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCompany.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCompany.FocusedState.Parent = this.txtCompany;
            this.txtCompany.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCompany.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCompany.HoverState.Parent = this.txtCompany;
            this.txtCompany.Location = new System.Drawing.Point(187, 140);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.PasswordChar = '\0';
            this.txtCompany.PlaceholderText = "";
            this.txtCompany.SelectedText = "";
            this.txtCompany.ShadowDecoration.Parent = this.txtCompany;
            this.txtCompany.Size = new System.Drawing.Size(200, 36);
            this.txtCompany.TabIndex = 14;
            // 
            // txtAddress
            // 
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.DefaultText = "";
            this.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.DisabledState.Parent = this.txtAddress;
            this.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.FocusedState.Parent = this.txtAddress;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.HoverState.Parent = this.txtAddress;
            this.txtAddress.Location = new System.Drawing.Point(187, 80);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PlaceholderText = "";
            this.txtAddress.SelectedText = "";
            this.txtAddress.ShadowDecoration.Parent = this.txtAddress;
            this.txtAddress.Size = new System.Drawing.Size(200, 36);
            this.txtAddress.TabIndex = 15;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // btnConfirm
            // 
            this.btnConfirm.CheckedState.Parent = this.btnConfirm;
            this.btnConfirm.CustomImages.Parent = this.btnConfirm;
            this.btnConfirm.DisabledState.Parent = this.btnConfirm;
            this.btnConfirm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.HoverState.Parent = this.btnConfirm;
            this.btnConfirm.Location = new System.Drawing.Point(217, 529);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.ShadowDecoration.Parent = this.btnConfirm;
            this.btnConfirm.Size = new System.Drawing.Size(103, 38);
            this.btnConfirm.TabIndex = 16;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.CheckedState.Parent = this.btnCancel;
            this.btnCancel.CustomImages.Parent = this.btnCancel;
            this.btnCancel.DisabledState.Parent = this.btnCancel;
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.HoverState.Parent = this.btnCancel;
            this.btnCancel.Location = new System.Drawing.Point(326, 529);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(103, 38);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // panelEdit
            // 
            this.panelEdit.Controls.Add(this.lblStatusEdit);
            this.panelEdit.Controls.Add(this.lblPriceEdit);
            this.panelEdit.Controls.Add(this.lblDateEdit);
            this.panelEdit.Controls.Add(this.btnConfirm);
            this.panelEdit.Controls.Add(this.btnCancel);
            this.panelEdit.Controls.Add(this.lblPhoneEdit);
            this.panelEdit.Controls.Add(this.lblNameEdit);
            this.panelEdit.Controls.Add(this.lblCompanyEdit);
            this.panelEdit.Controls.Add(this.lblAddressEdit);
            this.panelEdit.Controls.Add(this.txtAddress);
            this.panelEdit.Controls.Add(this.lblShipmentIDEdit);
            this.panelEdit.Controls.Add(this.txtPhone);
            this.panelEdit.Controls.Add(this.txtCompany);
            this.panelEdit.Controls.Add(this.txtName);
            this.panelEdit.Location = new System.Drawing.Point(107, 78);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.ShadowDecoration.Parent = this.panelEdit;
            this.panelEdit.Size = new System.Drawing.Size(452, 614);
            this.panelEdit.TabIndex = 69;
            this.panelEdit.Visible = false;
            this.panelEdit.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // lblStatusEdit
            // 
            this.lblStatusEdit.AutoSize = true;
            this.lblStatusEdit.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblStatusEdit.Location = new System.Drawing.Point(20, 440);
            this.lblStatusEdit.Name = "lblStatusEdit";
            this.lblStatusEdit.Size = new System.Drawing.Size(76, 25);
            this.lblStatusEdit.TabIndex = 25;
            this.lblStatusEdit.Text = "Status : ";
            // 
            // lblPriceEdit
            // 
            this.lblPriceEdit.AutoSize = true;
            this.lblPriceEdit.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblPriceEdit.Location = new System.Drawing.Point(20, 380);
            this.lblPriceEdit.Name = "lblPriceEdit";
            this.lblPriceEdit.Size = new System.Drawing.Size(68, 25);
            this.lblPriceEdit.TabIndex = 24;
            this.lblPriceEdit.Text = "Price : ";
            // 
            // lblDateEdit
            // 
            this.lblDateEdit.AutoSize = true;
            this.lblDateEdit.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblDateEdit.Location = new System.Drawing.Point(20, 320);
            this.lblDateEdit.Name = "lblDateEdit";
            this.lblDateEdit.Size = new System.Drawing.Size(125, 25);
            this.lblDateEdit.TabIndex = 23;
            this.lblDateEdit.Text = "Create Date : ";
            // 
            // lblPhoneEdit
            // 
            this.lblPhoneEdit.AutoSize = true;
            this.lblPhoneEdit.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblPhoneEdit.Location = new System.Drawing.Point(20, 260);
            this.lblPhoneEdit.Name = "lblPhoneEdit";
            this.lblPhoneEdit.Size = new System.Drawing.Size(80, 25);
            this.lblPhoneEdit.TabIndex = 22;
            this.lblPhoneEdit.Text = "Phone : ";
            // 
            // lblNameEdit
            // 
            this.lblNameEdit.AutoSize = true;
            this.lblNameEdit.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblNameEdit.Location = new System.Drawing.Point(20, 200);
            this.lblNameEdit.Name = "lblNameEdit";
            this.lblNameEdit.Size = new System.Drawing.Size(76, 25);
            this.lblNameEdit.TabIndex = 21;
            this.lblNameEdit.Text = "Name : ";
            // 
            // lblCompanyEdit
            // 
            this.lblCompanyEdit.AutoSize = true;
            this.lblCompanyEdit.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblCompanyEdit.Location = new System.Drawing.Point(20, 140);
            this.lblCompanyEdit.Name = "lblCompanyEdit";
            this.lblCompanyEdit.Size = new System.Drawing.Size(161, 25);
            this.lblCompanyEdit.TabIndex = 20;
            this.lblCompanyEdit.Text = "Company Name : ";
            // 
            // lblAddressEdit
            // 
            this.lblAddressEdit.AutoSize = true;
            this.lblAddressEdit.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblAddressEdit.Location = new System.Drawing.Point(20, 80);
            this.lblAddressEdit.Name = "lblAddressEdit";
            this.lblAddressEdit.Size = new System.Drawing.Size(112, 25);
            this.lblAddressEdit.TabIndex = 19;
            this.lblAddressEdit.Text = "Destination:";
            this.lblAddressEdit.Click += new System.EventHandler(this.lblAddressEdit_Click);
            // 
            // lblShipmentIDEdit
            // 
            this.lblShipmentIDEdit.AutoSize = true;
            this.lblShipmentIDEdit.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblShipmentIDEdit.Location = new System.Drawing.Point(20, 20);
            this.lblShipmentIDEdit.Name = "lblShipmentIDEdit";
            this.lblShipmentIDEdit.Size = new System.Drawing.Size(124, 25);
            this.lblShipmentIDEdit.TabIndex = 18;
            this.lblShipmentIDEdit.Text = "ShipmentID : ";
            // 
            // panelCheck
            // 
            this.panelCheck.Controls.Add(this.lblShipmentID);
            this.panelCheck.Controls.Add(this.lblAddress);
            this.panelCheck.Controls.Add(this.lblCompany);
            this.panelCheck.Controls.Add(this.lblName);
            this.panelCheck.Controls.Add(this.lblPhone);
            this.panelCheck.Controls.Add(this.lblDate);
            this.panelCheck.Controls.Add(this.lblPrice);
            this.panelCheck.Controls.Add(this.btnEdit);
            this.panelCheck.Controls.Add(this.lblStatus);
            this.panelCheck.Location = new System.Drawing.Point(107, 78);
            this.panelCheck.Name = "panelCheck";
            this.panelCheck.ShadowDecoration.Parent = this.panelCheck;
            this.panelCheck.Size = new System.Drawing.Size(452, 614);
            this.panelCheck.TabIndex = 70;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1120, 20);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 71;
            // 
            // Panel_Dargcontrl
            // 
            this.Panel_Dargcontrl.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Dargcontrl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Panel_Dargcontrl.BorderRadius = 5;
            this.Panel_Dargcontrl.BorderThickness = 1;
            this.Panel_Dargcontrl.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Panel_Dargcontrl.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Panel_Dargcontrl.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Panel_Dargcontrl.Location = new System.Drawing.Point(0, 28);
            this.Panel_Dargcontrl.Name = "Panel_Dargcontrl";
            this.Panel_Dargcontrl.ShadowDecoration.Parent = this.Panel_Dargcontrl;
            this.Panel_Dargcontrl.Size = new System.Drawing.Size(599, 9);
            this.Panel_Dargcontrl.TabIndex = 18;
            // 
            // Panel_Dargcontrl_big
            // 
            this.Panel_Dargcontrl_big.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Dargcontrl_big.Controls.Add(this.Panel_Dargcontrl);
            this.Panel_Dargcontrl_big.Location = new System.Drawing.Point(290, 0);
            this.Panel_Dargcontrl_big.Name = "Panel_Dargcontrl_big";
            this.Panel_Dargcontrl_big.ShadowDecoration.Parent = this.Panel_Dargcontrl_big;
            this.Panel_Dargcontrl_big.Size = new System.Drawing.Size(599, 40);
            this.Panel_Dargcontrl_big.TabIndex = 72;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.TargetControl = this.Panel_Dargcontrl_big;
            this.guna2DragControl2.TransparentWhileDrag = true;
            this.guna2DragControl2.UseTransparentDrag = true;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.Panel_Dargcontrl;
            this.guna2DragControl1.TransparentWhileDrag = true;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // OrderInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 748);
            this.Controls.Add(this.Panel_Dargcontrl_big);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.panelCheck);
            this.Controls.Add(this.panelEdit);
            this.Controls.Add(this.lblDetail);
            this.Controls.Add(this.lsvItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrderInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OrderInfo";
            this.Load += new System.EventHandler(this.OrderInfo_Load);
            this.panelEdit.ResumeLayout(false);
            this.panelEdit.PerformLayout();
            this.panelCheck.ResumeLayout(false);
            this.panelCheck.PerformLayout();
            this.Panel_Dargcontrl_big.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDetail;
        private System.Windows.Forms.Label lblShipmentID;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ListView lsvItem;
        private System.Windows.Forms.ColumnHeader itemID;
        private System.Windows.Forms.ColumnHeader size;
        private System.Windows.Forms.ColumnHeader description;
        private System.Windows.Forms.ColumnHeader weight;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2TextBox txtPhone;
        private Guna.UI2.WinForms.Guna2TextBox txtCompany;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private Guna.UI2.WinForms.Guna2Button btnConfirm;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Panel panelEdit;
        private System.Windows.Forms.Label lblStatusEdit;
        private System.Windows.Forms.Label lblPriceEdit;
        private System.Windows.Forms.Label lblDateEdit;
        private System.Windows.Forms.Label lblPhoneEdit;
        private System.Windows.Forms.Label lblNameEdit;
        private System.Windows.Forms.Label lblCompanyEdit;
        private System.Windows.Forms.Label lblAddressEdit;
        private System.Windows.Forms.Label lblShipmentIDEdit;
        private Guna.UI2.WinForms.Guna2Panel panelCheck;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2GradientPanel Panel_Dargcontrl;
        private Guna.UI2.WinForms.Guna2GradientPanel Panel_Dargcontrl_big;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}