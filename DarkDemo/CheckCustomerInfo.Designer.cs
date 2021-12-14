
namespace DarkDemo
{
    partial class CheckCustomerInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckCustomerInfo));
            Guna.UI2.AnimatorNS.Animation animation6 = new Guna.UI2.AnimatorNS.Animation();
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCountry = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtCompany = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCompany = new System.Windows.Forms.Label();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.btnNew = new Guna.UI2.WinForms.Guna2Button();
            this.txtAccountID = new Guna.UI2.WinForms.Guna2TextBox();
            this.lsvCustomer = new System.Windows.Forms.ListView();
            this.claccountID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clemail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clCompanyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clPostcode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clCountry = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clCreditLimit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clCreateDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label15 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl3 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Transition_menu = new Guna.UI2.WinForms.Guna2Transition();
            this.timer_menu = new System.Windows.Forms.Timer(this.components);
            this.customInstaller1 = new MySql.Data.MySqlClient.CustomInstaller();
            this.panel1.SuspendLayout();
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
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.lblName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition_menu.SetDecoration(this.lblName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblName.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.DimGray;
            this.lblName.Location = new System.Drawing.Point(78, 17);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 19);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "Name:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.lblEmail, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition_menu.SetDecoration(this.lblEmail, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblEmail.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.DimGray;
            this.lblEmail.Location = new System.Drawing.Point(82, 49);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 19);
            this.lblEmail.TabIndex = 17;
            this.lblEmail.Text = "Email:";
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition_menu.SetDecoration(this.txtName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.txtName, Guna.UI2.AnimatorNS.DecorationType.None);
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
            this.txtName.Location = new System.Drawing.Point(137, 14);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "";
            this.txtName.ReadOnly = true;
            this.txtName.SelectedText = "";
            this.txtName.ShadowDecoration.Parent = this.txtName;
            this.txtName.Size = new System.Drawing.Size(280, 22);
            this.txtName.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition_menu.SetDecoration(this.txtEmail, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.txtEmail, Guna.UI2.AnimatorNS.DecorationType.None);
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
            this.txtEmail.Location = new System.Drawing.Point(137, 44);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.SelectedText = "";
            this.txtEmail.ShadowDecoration.Parent = this.txtEmail;
            this.txtEmail.Size = new System.Drawing.Size(280, 22);
            this.txtEmail.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCountry);
            this.panel1.Controls.Add(this.lblCountry);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.lblPhone);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.lblAddress);
            this.panel1.Controls.Add(this.txtCompany);
            this.panel1.Controls.Add(this.lblCompany);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblEmail);
            this.guna2Transition_menu.SetDecoration(this.panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(240, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 109);
            this.panel1.TabIndex = 24;
            // 
            // txtCountry
            // 
            this.txtCountry.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition_menu.SetDecoration(this.txtCountry, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.txtCountry, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtCountry.DefaultText = "";
            this.txtCountry.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCountry.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCountry.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCountry.DisabledState.Parent = this.txtCountry;
            this.txtCountry.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCountry.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCountry.FocusedState.Parent = this.txtCountry;
            this.txtCountry.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCountry.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCountry.HoverState.Parent = this.txtCountry;
            this.txtCountry.Location = new System.Drawing.Point(508, 73);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.PasswordChar = '\0';
            this.txtCountry.PlaceholderText = "";
            this.txtCountry.ReadOnly = true;
            this.txtCountry.SelectedText = "";
            this.txtCountry.ShadowDecoration.Parent = this.txtCountry;
            this.txtCountry.Size = new System.Drawing.Size(280, 22);
            this.txtCountry.TabIndex = 11;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.lblCountry, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition_menu.SetDecoration(this.lblCountry, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblCountry.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblCountry.ForeColor = System.Drawing.Color.DimGray;
            this.lblCountry.Location = new System.Drawing.Point(437, 78);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(65, 19);
            this.lblCountry.TabIndex = 29;
            this.lblCountry.Text = "Country:";
            // 
            // txtPhone
            // 
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition_menu.SetDecoration(this.txtPhone, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.txtPhone, Guna.UI2.AnimatorNS.DecorationType.None);
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
            this.txtPhone.Location = new System.Drawing.Point(508, 44);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.PlaceholderText = "";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.SelectedText = "";
            this.txtPhone.ShadowDecoration.Parent = this.txtPhone;
            this.txtPhone.Size = new System.Drawing.Size(280, 22);
            this.txtPhone.TabIndex = 9;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.lblPhone, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition_menu.SetDecoration(this.lblPhone, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblPhone.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPhone.ForeColor = System.Drawing.Color.DimGray;
            this.lblPhone.Location = new System.Drawing.Point(447, 48);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(55, 19);
            this.lblPhone.TabIndex = 27;
            this.lblPhone.Text = "Phone:";
            // 
            // txtAddress
            // 
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition_menu.SetDecoration(this.txtAddress, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.txtAddress, Guna.UI2.AnimatorNS.DecorationType.None);
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
            this.txtAddress.Location = new System.Drawing.Point(508, 17);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PlaceholderText = "";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.SelectedText = "";
            this.txtAddress.ShadowDecoration.Parent = this.txtAddress;
            this.txtAddress.Size = new System.Drawing.Size(280, 22);
            this.txtAddress.TabIndex = 7;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.lblAddress, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition_menu.SetDecoration(this.lblAddress, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblAddress.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblAddress.ForeColor = System.Drawing.Color.DimGray;
            this.lblAddress.Location = new System.Drawing.Point(435, 19);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(67, 19);
            this.lblAddress.TabIndex = 25;
            this.lblAddress.Text = "Address:";
            // 
            // txtCompany
            // 
            this.txtCompany.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition_menu.SetDecoration(this.txtCompany, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.txtCompany, Guna.UI2.AnimatorNS.DecorationType.None);
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
            this.txtCompany.Location = new System.Drawing.Point(137, 75);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.PasswordChar = '\0';
            this.txtCompany.PlaceholderText = "";
            this.txtCompany.ReadOnly = true;
            this.txtCompany.SelectedText = "";
            this.txtCompany.ShadowDecoration.Parent = this.txtCompany;
            this.txtCompany.Size = new System.Drawing.Size(280, 22);
            this.txtCompany.TabIndex = 10;
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.lblCompany, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition_menu.SetDecoration(this.lblCompany, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblCompany.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblCompany.ForeColor = System.Drawing.Color.DimGray;
            this.lblCompany.Location = new System.Drawing.Point(11, 75);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(120, 19);
            this.lblCompany.TabIndex = 23;
            this.lblCompany.Text = "Company Name:";
            // 
            // btnSave
            // 
            this.btnSave.AutoRoundedCorners = true;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderRadius = 15;
            this.btnSave.BorderThickness = 2;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.guna2Transition_menu.SetDecoration(this.btnSave, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.btnSave, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnSave.DisabledState.Parent = this.btnSave;
            this.btnSave.FillColor = System.Drawing.Color.Transparent;
            this.btnSave.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(247)))), ((int)(((byte)(166)))));
            this.btnSave.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Location = new System.Drawing.Point(240, 173);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(126, 32);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.Client;
            this.btnUpdate.AutoRoundedCorners = true;
            this.btnUpdate.BorderRadius = 15;
            this.btnUpdate.BorderThickness = 2;
            this.btnUpdate.CheckedState.Parent = this.btnUpdate;
            this.btnUpdate.CustomImages.Parent = this.btnUpdate;
            this.guna2Transition_menu.SetDecoration(this.btnUpdate, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.btnUpdate, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnUpdate.DisabledState.Parent = this.btnUpdate;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FillColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.btnUpdate.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.HoverState.Parent = this.btnUpdate;
            this.btnUpdate.Location = new System.Drawing.Point(389, 173);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(180, 32);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update Customer Info";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.AutoRoundedCorners = true;
            this.btnSearch.BorderRadius = 15;
            this.btnSearch.BorderThickness = 2;
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.CustomImages.Parent = this.btnSearch;
            this.guna2Transition_menu.SetDecoration(this.btnSearch, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.btnSearch, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnSearch.DisabledState.Parent = this.btnSearch;
            this.btnSearch.FillColor = System.Drawing.Color.Transparent;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(24)))), ((int)(((byte)(69)))));
            this.btnSearch.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Location = new System.Drawing.Point(981, 173);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(126, 32);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search Customer";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnNew
            // 
            this.btnNew.AutoRoundedCorners = true;
            this.btnNew.BorderRadius = 15;
            this.btnNew.BorderThickness = 2;
            this.btnNew.CheckedState.Parent = this.btnNew;
            this.btnNew.CustomImages.Parent = this.btnNew;
            this.guna2Transition_menu.SetDecoration(this.btnNew, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.btnNew, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnNew.DisabledState.Parent = this.btnNew;
            this.btnNew.FillColor = System.Drawing.Color.Transparent;
            this.btnNew.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.btnNew.ForeColor = System.Drawing.Color.Black;
            this.btnNew.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(0)))), ((int)(((byte)(57)))));
            this.btnNew.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnNew.HoverState.Parent = this.btnNew;
            this.btnNew.Location = new System.Drawing.Point(587, 173);
            this.btnNew.Name = "btnNew";
            this.btnNew.ShadowDecoration.Parent = this.btnNew;
            this.btnNew.Size = new System.Drawing.Size(182, 32);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "Create Customer Account";
            this.btnNew.Click += new System.EventHandler(this.txtNew_Click);
            // 
            // txtAccountID
            // 
            this.txtAccountID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition_menu.SetDecoration(this.txtAccountID, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.txtAccountID, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtAccountID.DefaultText = "";
            this.txtAccountID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAccountID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAccountID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAccountID.DisabledState.Parent = this.txtAccountID;
            this.txtAccountID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAccountID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAccountID.FocusedState.Parent = this.txtAccountID;
            this.txtAccountID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAccountID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAccountID.HoverState.Parent = this.txtAccountID;
            this.txtAccountID.Location = new System.Drawing.Point(801, 174);
            this.txtAccountID.Name = "txtAccountID";
            this.txtAccountID.PasswordChar = '\0';
            this.txtAccountID.PlaceholderText = "Search Customer by ID";
            this.txtAccountID.SelectedText = "";
            this.txtAccountID.ShadowDecoration.Parent = this.txtAccountID;
            this.txtAccountID.Size = new System.Drawing.Size(162, 30);
            this.txtAccountID.TabIndex = 4;
            // 
            // lsvCustomer
            // 
            this.lsvCustomer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.claccountID,
            this.clemail,
            this.clName,
            this.clCompanyName,
            this.clAddress,
            this.clPostcode,
            this.clPhone,
            this.clCountry,
            this.clCreditLimit,
            this.clCreateDate});
            this.guna2Transition_menu.SetDecoration(this.lsvCustomer, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.lsvCustomer, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lsvCustomer.FullRowSelect = true;
            this.lsvCustomer.HideSelection = false;
            this.lsvCustomer.Location = new System.Drawing.Point(240, 222);
            this.lsvCustomer.Name = "lsvCustomer";
            this.lsvCustomer.Size = new System.Drawing.Size(867, 438);
            this.lsvCustomer.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lsvCustomer.TabIndex = 45;
            this.lsvCustomer.UseCompatibleStateImageBehavior = false;
            this.lsvCustomer.View = System.Windows.Forms.View.Details;
            this.lsvCustomer.SelectedIndexChanged += new System.EventHandler(this.lsvCustomer_SelectedIndexChanged);
            this.lsvCustomer.Click += new System.EventHandler(this.lsvCustomer_Click);
            // 
            // claccountID
            // 
            this.claccountID.Text = "Account ID";
            this.claccountID.Width = 136;
            // 
            // clemail
            // 
            this.clemail.Text = "Email";
            this.clemail.Width = 159;
            // 
            // clName
            // 
            this.clName.Text = "Name";
            this.clName.Width = 188;
            // 
            // clCompanyName
            // 
            this.clCompanyName.Text = "Company Name";
            this.clCompanyName.Width = 103;
            // 
            // clAddress
            // 
            this.clAddress.Text = "Address";
            this.clAddress.Width = 131;
            // 
            // clPostcode
            // 
            this.clPostcode.Text = "Postcode";
            this.clPostcode.Width = 67;
            // 
            // clPhone
            // 
            this.clPhone.Text = "Phone";
            this.clPhone.Width = 84;
            // 
            // clCountry
            // 
            this.clCountry.Text = "Country";
            this.clCountry.Width = 94;
            // 
            // clCreditLimit
            // 
            this.clCreditLimit.Text = "Credit Limit";
            this.clCreditLimit.Width = 158;
            // 
            // clCreateDate
            // 
            this.clCreateDate.Text = "Create At";
            this.clCreateDate.Width = 243;
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
            this.label15.Size = new System.Drawing.Size(409, 36);
            this.label15.TabIndex = 83;
            this.label15.Text = "Check Customer Information";
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
            this.guna2Transition_menu.TimeStep = 0.03F;
            // 
            // CheckCustomerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 683);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lsvCustomer);
            this.Controls.Add(this.txtAccountID);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel1);
            this.guna2Transition_menu.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CheckCustomerInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CheckCustomerInfo";
            this.Load += new System.EventHandler(this.CheckCustomerInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtCountry;
        private System.Windows.Forms.Label lblCountry;
        private Guna.UI2.WinForms.Guna2TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private Guna.UI2.WinForms.Guna2TextBox txtCompany;
        private System.Windows.Forms.Label lblCompany;
        private Guna.UI2.WinForms.Guna2Button btnNew;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition_menu;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl3;
        private System.Windows.Forms.Timer timer_menu;
        private Guna.UI2.WinForms.Guna2TextBox txtAccountID;
        private MySql.Data.MySqlClient.CustomInstaller customInstaller1;
        private System.Windows.Forms.ListView lsvCustomer;
        private System.Windows.Forms.ColumnHeader claccountID;
        private System.Windows.Forms.ColumnHeader clemail;
        private System.Windows.Forms.ColumnHeader clCreditLimit;
        private System.Windows.Forms.ColumnHeader clCreateDate;
        private System.Windows.Forms.ColumnHeader clName;
        private System.Windows.Forms.ColumnHeader clCompanyName;
        private System.Windows.Forms.ColumnHeader clAddress;
        private System.Windows.Forms.ColumnHeader clPostcode;
        private System.Windows.Forms.ColumnHeader clPhone;
        private System.Windows.Forms.ColumnHeader clCountry;
        private System.Windows.Forms.Label label15;
    }
}