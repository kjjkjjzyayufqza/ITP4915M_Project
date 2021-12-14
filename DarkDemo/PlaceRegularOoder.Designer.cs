
namespace DarkDemo
{
    partial class PlaceRegularOoder
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
            this.lsvItem = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Weight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Length = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Width = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Height = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cboRegularOrder = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtRecordName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCreateRecord = new Guna.UI2.WinForms.Guna2Button();
            this.btnUploadShipment = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnPlaceOrder = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDTDdate = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lstBoxReceiver = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboCountry = new System.Windows.Forms.ComboBox();
            this.cboShipmentType = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtPostCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCompany = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCompany = new System.Windows.Forms.Label();
            this.txtPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
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
            this.lsvItem.FullRowSelect = true;
            this.lsvItem.HideSelection = false;
            this.lsvItem.Location = new System.Drawing.Point(18, 8);
            this.lsvItem.Name = "lsvItem";
            this.lsvItem.Size = new System.Drawing.Size(460, 180);
            this.lsvItem.TabIndex = 67;
            this.lsvItem.UseCompatibleStateImageBehavior = false;
            this.lsvItem.View = System.Windows.Forms.View.Details;
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
            // cboRegularOrder
            // 
            this.cboRegularOrder.BackColor = System.Drawing.Color.Transparent;
            this.cboRegularOrder.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboRegularOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRegularOrder.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboRegularOrder.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboRegularOrder.FocusedState.Parent = this.cboRegularOrder;
            this.cboRegularOrder.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboRegularOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboRegularOrder.HoverState.Parent = this.cboRegularOrder;
            this.cboRegularOrder.ItemHeight = 30;
            this.cboRegularOrder.ItemsAppearance.Parent = this.cboRegularOrder;
            this.cboRegularOrder.Location = new System.Drawing.Point(309, 92);
            this.cboRegularOrder.Name = "cboRegularOrder";
            this.cboRegularOrder.ShadowDecoration.Parent = this.cboRegularOrder;
            this.cboRegularOrder.Size = new System.Drawing.Size(150, 36);
            this.cboRegularOrder.TabIndex = 72;
            this.cboRegularOrder.SelectedIndexChanged += new System.EventHandler(this.cboRegularOrder_SelectedIndexChanged);
            // 
            // txtRecordName
            // 
            this.txtRecordName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRecordName.DefaultText = "";
            this.txtRecordName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRecordName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRecordName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRecordName.DisabledState.Parent = this.txtRecordName;
            this.txtRecordName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRecordName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRecordName.FocusedState.Parent = this.txtRecordName;
            this.txtRecordName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRecordName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRecordName.HoverState.Parent = this.txtRecordName;
            this.txtRecordName.Location = new System.Drawing.Point(717, 92);
            this.txtRecordName.Name = "txtRecordName";
            this.txtRecordName.PasswordChar = '\0';
            this.txtRecordName.PlaceholderText = "Name the record";
            this.txtRecordName.SelectedText = "";
            this.txtRecordName.ShadowDecoration.Parent = this.txtRecordName;
            this.txtRecordName.Size = new System.Drawing.Size(157, 33);
            this.txtRecordName.TabIndex = 74;
            this.txtRecordName.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(505, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 27);
            this.label3.TabIndex = 75;
            this.label3.Text = "OR";
            // 
            // btnCreateRecord
            // 
            this.btnCreateRecord.Animated = true;
            this.btnCreateRecord.BorderThickness = 2;
            this.btnCreateRecord.CheckedState.Parent = this.btnCreateRecord;
            this.btnCreateRecord.CustomImages.Parent = this.btnCreateRecord;
            this.btnCreateRecord.DisabledState.Parent = this.btnCreateRecord;
            this.btnCreateRecord.FillColor = System.Drawing.Color.Transparent;
            this.btnCreateRecord.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnCreateRecord.ForeColor = System.Drawing.Color.Black;
            this.btnCreateRecord.HoverState.Parent = this.btnCreateRecord;
            this.btnCreateRecord.Location = new System.Drawing.Point(577, 92);
            this.btnCreateRecord.Name = "btnCreateRecord";
            this.btnCreateRecord.ShadowDecoration.Parent = this.btnCreateRecord;
            this.btnCreateRecord.Size = new System.Drawing.Size(130, 33);
            this.btnCreateRecord.TabIndex = 78;
            this.btnCreateRecord.Click += new System.EventHandler(this.btnCreateRecord_Click);
            // 
            // btnUploadShipment
            // 
            this.btnUploadShipment.CheckedState.Parent = this.btnUploadShipment;
            this.btnUploadShipment.CustomImages.Parent = this.btnUploadShipment;
            this.btnUploadShipment.DisabledState.Parent = this.btnUploadShipment;
            this.btnUploadShipment.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUploadShipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnUploadShipment.ForeColor = System.Drawing.Color.White;
            this.btnUploadShipment.HoverState.Parent = this.btnUploadShipment;
            this.btnUploadShipment.Location = new System.Drawing.Point(868, 92);
            this.btnUploadShipment.Name = "btnUploadShipment";
            this.btnUploadShipment.ShadowDecoration.Parent = this.btnUploadShipment;
            this.btnUploadShipment.Size = new System.Drawing.Size(165, 33);
            this.btnUploadShipment.TabIndex = 80;
            this.btnUploadShipment.Text = "Upload Records(.csv)";
            this.btnUploadShipment.Visible = false;
            this.btnUploadShipment.Click += new System.EventHandler(this.btnUploadShipment_Click);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1142, 11);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 81;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.CheckedState.Parent = this.btnPlaceOrder;
            this.btnPlaceOrder.CustomImages.Parent = this.btnPlaceOrder;
            this.btnPlaceOrder.DisabledState.Parent = this.btnPlaceOrder;
            this.btnPlaceOrder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPlaceOrder.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnPlaceOrder.ForeColor = System.Drawing.Color.White;
            this.btnPlaceOrder.HoverState.Parent = this.btnPlaceOrder;
            this.btnPlaceOrder.Location = new System.Drawing.Point(947, 677);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.ShadowDecoration.Parent = this.btnPlaceOrder;
            this.btnPlaceOrder.Size = new System.Drawing.Size(215, 33);
            this.btnPlaceOrder.TabIndex = 82;
            this.btnPlaceOrder.Text = "Store and Place Order";
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(48, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 27);
            this.label1.TabIndex = 84;
            this.label1.Text = "Place Order With";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(153, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 27);
            this.label2.TabIndex = 73;
            this.label2.Text = "Stored Record";
            // 
            // btnCancel
            // 
            this.btnCancel.Animated = true;
            this.btnCancel.BorderThickness = 2;
            this.btnCancel.CheckedState.Parent = this.btnCancel;
            this.btnCancel.CustomImages.Parent = this.btnCancel;
            this.btnCancel.DisabledState.Parent = this.btnCancel;
            this.btnCancel.FillColor = System.Drawing.Color.Transparent;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.HoverState.Parent = this.btnCancel;
            this.btnCancel.Location = new System.Drawing.Point(793, 677);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(135, 33);
            this.btnCancel.TabIndex = 85;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "YYYY-MM-DD";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(240, 86);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(166, 21);
            this.dtpDate.TabIndex = 88;
            this.dtpDate.Value = new System.DateTime(2021, 6, 4, 0, 0, 0, 0);
            // 
            // dtpTime
            // 
            this.dtpTime.CustomFormat = "HH:mm";
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(240, 148);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(166, 21);
            this.dtpTime.TabIndex = 89;
            this.dtpTime.Value = new System.DateTime(2021, 6, 30, 9, 0, 0, 0);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTime.ForeColor = System.Drawing.Color.Black;
            this.lblTime.Location = new System.Drawing.Point(124, 146);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(69, 27);
            this.lblTime.TabIndex = 87;
            this.lblTime.Text = "Time: ";
            // 
            // lblDTDdate
            // 
            this.lblDTDdate.AutoSize = true;
            this.lblDTDdate.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDTDdate.ForeColor = System.Drawing.Color.Black;
            this.lblDTDdate.Location = new System.Drawing.Point(124, 86);
            this.lblDTDdate.Name = "lblDTDdate";
            this.lblDTDdate.Size = new System.Drawing.Size(67, 27);
            this.lblDTDdate.TabIndex = 86;
            this.lblDTDdate.Text = "Date: ";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.lblPrice.Location = new System.Drawing.Point(324, 200);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(75, 27);
            this.lblPrice.TabIndex = 90;
            this.lblPrice.Text = "Price : ";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCancelEdit);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblDTDdate);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.dtpTime);
            this.panel1.Controls.Add(this.dtpDate);
            this.panel1.Location = new System.Drawing.Point(663, 439);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 232);
            this.panel1.TabIndex = 92;
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.Animated = true;
            this.btnCancelEdit.BorderThickness = 2;
            this.btnCancelEdit.CheckedState.Parent = this.btnCancelEdit;
            this.btnCancelEdit.CustomImages.Parent = this.btnCancelEdit;
            this.btnCancelEdit.DisabledState.Parent = this.btnCancelEdit;
            this.btnCancelEdit.FillColor = System.Drawing.Color.Transparent;
            this.btnCancelEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancelEdit.ForeColor = System.Drawing.Color.Black;
            this.btnCancelEdit.HoverState.Parent = this.btnCancelEdit;
            this.btnCancelEdit.Location = new System.Drawing.Point(331, 184);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.ShadowDecoration.Parent = this.btnCancelEdit;
            this.btnCancelEdit.Size = new System.Drawing.Size(75, 33);
            this.btnCancelEdit.TabIndex = 94;
            this.btnCancelEdit.Text = "Cancel";
            this.btnCancelEdit.Visible = false;
            this.btnCancelEdit.Click += new System.EventHandler(this.btnCancelEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.DisabledState.Parent = this.btnSave;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Location = new System.Drawing.Point(412, 184);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(72, 33);
            this.btnSave.TabIndex = 94;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(21, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 27);
            this.label5.TabIndex = 93;
            this.label5.Text = "Select Pickup Date";
            // 
            // lstBoxReceiver
            // 
            this.lstBoxReceiver.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lstBoxReceiver.FormattingEnabled = true;
            this.lstBoxReceiver.HorizontalScrollbar = true;
            this.lstBoxReceiver.ItemHeight = 26;
            this.lstBoxReceiver.Location = new System.Drawing.Point(45, 194);
            this.lstBoxReceiver.Name = "lstBoxReceiver";
            this.lstBoxReceiver.Size = new System.Drawing.Size(612, 186);
            this.lstBoxReceiver.TabIndex = 70;
            this.lstBoxReceiver.SelectedIndexChanged += new System.EventHandler(this.lstBoxReceiver_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(50, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 27);
            this.label4.TabIndex = 91;
            this.label4.Text = "Order Info";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtDescription);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.cboCountry);
            this.panel2.Controls.Add(this.cboShipmentType);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.lblCountry);
            this.panel2.Controls.Add(this.txtPostCode);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtCompany);
            this.panel2.Controls.Add(this.lblCompany);
            this.panel2.Controls.Add(this.txtPhone);
            this.panel2.Controls.Add(this.txtAddress);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.lblAddress);
            this.panel2.Controls.Add(this.lblPhone);
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Location = new System.Drawing.Point(45, 395);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(612, 276);
            this.panel2.TabIndex = 93;
            // 
            // txtEmail
            // 
            this.txtEmail.AutoRoundedCorners = true;
            this.txtEmail.BorderRadius = 14;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.Parent = this.txtEmail;
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.FocusedState.Parent = this.txtEmail;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.HoverState.Parent = this.txtEmail;
            this.txtEmail.Location = new System.Drawing.Point(109, 51);
            this.txtEmail.MaxLength = 20;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.SelectedText = "";
            this.txtEmail.ShadowDecoration.Parent = this.txtEmail;
            this.txtEmail.Size = new System.Drawing.Size(150, 30);
            this.txtEmail.TabIndex = 96;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(2, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 27);
            this.label7.TabIndex = 112;
            this.label7.Text = "Email:";
            // 
            // txtDescription
            // 
            this.txtDescription.AutoRoundedCorners = true;
            this.txtDescription.BorderRadius = 20;
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
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
            this.txtDescription.Location = new System.Drawing.Point(431, 177);
            this.txtDescription.MaxLength = 100;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.PlaceholderText = "";
            this.txtDescription.SelectedText = "";
            this.txtDescription.ShadowDecoration.Parent = this.txtDescription;
            this.txtDescription.Size = new System.Drawing.Size(163, 74);
            this.txtDescription.TabIndex = 103;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(311, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 27);
            this.label8.TabIndex = 111;
            this.label8.Text = "Description:";
            // 
            // cboCountry
            // 
            this.cboCountry.AutoCompleteCustomSource.AddRange(new string[] {
            "DOCUMENT",
            "PACKAGE EXPRESS",
            "EXPRESS DOCUMENT",
            "DOMESTIC",
            "WORLDMAIL"});
            this.cboCountry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboCountry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCountry.Enabled = false;
            this.cboCountry.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cboCountry.FormattingEnabled = true;
            this.cboCountry.Items.AddRange(new object[] {
            "Hong Kong",
            "Shang Hai-China",
            "Australia",
            "Japan"});
            this.cboCountry.Location = new System.Drawing.Point(431, 70);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(120, 25);
            this.cboCountry.TabIndex = 101;
            // 
            // cboShipmentType
            // 
            this.cboShipmentType.AutoCompleteCustomSource.AddRange(new string[] {
            "DOCUMENT",
            "PACKAGE EXPRESS",
            "EXPRESS DOCUMENT",
            "DOMESTIC",
            "WORLDMAIL"});
            this.cboShipmentType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboShipmentType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboShipmentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboShipmentType.Enabled = false;
            this.cboShipmentType.FormattingEnabled = true;
            this.cboShipmentType.Items.AddRange(new object[] {
            "DOCUMENT",
            "PACKAGE"});
            this.cboShipmentType.Location = new System.Drawing.Point(431, 127);
            this.cboShipmentType.Name = "cboShipmentType";
            this.cboShipmentType.Size = new System.Drawing.Size(149, 20);
            this.cboShipmentType.TabIndex = 102;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(311, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 54);
            this.label9.TabIndex = 110;
            this.label9.Text = "Shipment\r\nType:";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCountry.ForeColor = System.Drawing.Color.Black;
            this.lblCountry.Location = new System.Drawing.Point(311, 68);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(53, 27);
            this.lblCountry.TabIndex = 109;
            this.lblCountry.Text = "City:";
            // 
            // txtPostCode
            // 
            this.txtPostCode.AutoRoundedCorners = true;
            this.txtPostCode.BorderRadius = 14;
            this.txtPostCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPostCode.DefaultText = "";
            this.txtPostCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPostCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPostCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPostCode.DisabledState.Parent = this.txtPostCode;
            this.txtPostCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPostCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPostCode.FocusedState.Parent = this.txtPostCode;
            this.txtPostCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPostCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPostCode.HoverState.Parent = this.txtPostCode;
            this.txtPostCode.Location = new System.Drawing.Point(431, 15);
            this.txtPostCode.MaxLength = 10;
            this.txtPostCode.Name = "txtPostCode";
            this.txtPostCode.PasswordChar = '\0';
            this.txtPostCode.PlaceholderText = "";
            this.txtPostCode.SelectedText = "";
            this.txtPostCode.ShadowDecoration.Parent = this.txtPostCode;
            this.txtPostCode.Size = new System.Drawing.Size(135, 30);
            this.txtPostCode.TabIndex = 100;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(311, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 27);
            this.label10.TabIndex = 108;
            this.label10.Text = "Post Code:";
            // 
            // txtCompany
            // 
            this.txtCompany.AutoRoundedCorners = true;
            this.txtCompany.BorderRadius = 14;
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
            this.txtCompany.Location = new System.Drawing.Point(109, 231);
            this.txtCompany.MaxLength = 100;
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.PasswordChar = '\0';
            this.txtCompany.PlaceholderText = "";
            this.txtCompany.SelectedText = "";
            this.txtCompany.ShadowDecoration.Parent = this.txtCompany;
            this.txtCompany.Size = new System.Drawing.Size(150, 30);
            this.txtCompany.TabIndex = 99;
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCompany.ForeColor = System.Drawing.Color.Black;
            this.lblCompany.Location = new System.Drawing.Point(2, 220);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(104, 54);
            this.lblCompany.TabIndex = 107;
            this.lblCompany.Text = "Company\r\nName:";
            // 
            // txtPhone
            // 
            this.txtPhone.AutoRoundedCorners = true;
            this.txtPhone.BorderRadius = 14;
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
            this.txtPhone.Location = new System.Drawing.Point(109, 86);
            this.txtPhone.MaxLength = 20;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.PlaceholderText = "";
            this.txtPhone.SelectedText = "";
            this.txtPhone.ShadowDecoration.Parent = this.txtPhone;
            this.txtPhone.Size = new System.Drawing.Size(150, 30);
            this.txtPhone.TabIndex = 97;
            // 
            // txtAddress
            // 
            this.txtAddress.AutoRoundedCorners = true;
            this.txtAddress.BorderRadius = 20;
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
            this.txtAddress.Location = new System.Drawing.Point(109, 133);
            this.txtAddress.MaxLength = 100;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PlaceholderText = "";
            this.txtAddress.SelectedText = "";
            this.txtAddress.ShadowDecoration.Parent = this.txtAddress;
            this.txtAddress.Size = new System.Drawing.Size(170, 80);
            this.txtAddress.TabIndex = 98;
            // 
            // txtName
            // 
            this.txtName.AutoRoundedCorners = true;
            this.txtName.BorderRadius = 14;
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
            this.txtName.Location = new System.Drawing.Point(109, 15);
            this.txtName.MaxLength = 30;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "";
            this.txtName.SelectedText = "";
            this.txtName.ShadowDecoration.Parent = this.txtName;
            this.txtName.Size = new System.Drawing.Size(150, 30);
            this.txtName.TabIndex = 95;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAddress.ForeColor = System.Drawing.Color.Black;
            this.lblAddress.Location = new System.Drawing.Point(4, 130);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(94, 27);
            this.lblAddress.TabIndex = 106;
            this.lblAddress.Text = "Address:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPhone.ForeColor = System.Drawing.Color.Black;
            this.lblPhone.Location = new System.Drawing.Point(2, 89);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(77, 27);
            this.lblPhone.TabIndex = 105;
            this.lblPhone.Text = "Phone:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(4, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(80, 27);
            this.lblName.TabIndex = 104;
            this.lblName.Text = "Name: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(658, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 30);
            this.label6.TabIndex = 94;
            this.label6.Text = "Item Info";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblPrice);
            this.panel3.Controls.Add(this.lsvItem);
            this.panel3.Location = new System.Drawing.Point(663, 194);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(499, 240);
            this.panel3.TabIndex = 94;
            // 
            // PlaceRegularOoder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 748);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstBoxReceiver);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.btnUploadShipment);
            this.Controls.Add(this.btnCreateRecord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRecordName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboRegularOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlaceRegularOoder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PlaceRegularOoder";
            this.Load += new System.EventHandler(this.PlaceRegularOoder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lsvItem;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader Weight;
        private System.Windows.Forms.ColumnHeader Length;
        private System.Windows.Forms.ColumnHeader Width;
        private System.Windows.Forms.ColumnHeader Height;
        private System.Windows.Forms.ColumnHeader Value;
        private Guna.UI2.WinForms.Guna2ComboBox cboRegularOrder;
        private Guna.UI2.WinForms.Guna2TextBox txtRecordName;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnCreateRecord;
        private Guna.UI2.WinForms.Guna2Button btnUploadShipment;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Button btnPlaceOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDTDdate;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstBoxReceiver;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtDescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboCountry;
        private System.Windows.Forms.ComboBox cboShipmentType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCountry;
        private Guna.UI2.WinForms.Guna2TextBox txtPostCode;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox txtCompany;
        private System.Windows.Forms.Label lblCompany;
        private Guna.UI2.WinForms.Guna2TextBox txtPhone;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnCancelEdit;
        private System.Windows.Forms.Panel panel3;
    }
}