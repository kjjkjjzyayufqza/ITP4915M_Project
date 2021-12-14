
namespace DarkDemo
{
    partial class Login
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
            System.Windows.Forms.Label lblVersion;
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Guna.UI2.AnimatorNS.Animation animation2 = new Guna.UI2.AnimatorNS.Animation();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Panel_Dargcontrl_big = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.Panel_Dargcontrl = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.txtBoxPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBoxUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.PanelLogin = new Guna.UI2.WinForms.Guna2Panel();
            this.lblAlert = new System.Windows.Forms.Label();
            this.lblShowPWD = new System.Windows.Forms.Label();
            this.togswitShowPWD = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.PanelCal = new Guna.UI2.WinForms.Guna2Panel();
            this.lblReminder = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.cboType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnReset = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSubmit = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtWeight = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboDestination = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.btnBack = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnLogin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblRegister = new System.Windows.Forms.Label();
            this.btnQuestion = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.TransitionCal = new Guna.UI2.WinForms.Guna2Transition();
            this.lblHelp = new System.Windows.Forms.Label();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.picMain = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblFindme = new System.Windows.Forms.Label();
            this.Iconbox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.cal_btn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tableAdapterManager1 = new DarkDemo.AirwayBillUI.DataSet_AirwayBillTableAdapters.TableAdapterManager();
            this.TransitionCal1 = new Guna.UI2.WinForms.Guna2Transition();
            lblVersion = new System.Windows.Forms.Label();
            this.Panel_Dargcontrl_big.SuspendLayout();
            this.PanelLogin.SuspendLayout();
            this.PanelCal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Iconbox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVersion
            // 
            this.TransitionCal.SetDecoration(lblVersion, Guna.UI2.AnimatorNS.DecorationType.None);
            this.TransitionCal1.SetDecoration(lblVersion, Guna.UI2.AnimatorNS.DecorationType.None);
            lblVersion.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            lblVersion.ForeColor = System.Drawing.Color.Gray;
            lblVersion.Location = new System.Drawing.Point(12, 716);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new System.Drawing.Size(100, 25);
            lblVersion.TabIndex = 30;
            lblVersion.Text = "v0.1.0.0";
            lblVersion.Click += new System.EventHandler(this.lblVersion_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.ContainerControl = this;
            this.guna2DragControl1.TargetControl = this.Panel_Dargcontrl_big;
            // 
            // Panel_Dargcontrl_big
            // 
            this.Panel_Dargcontrl_big.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Dargcontrl_big.Controls.Add(this.Panel_Dargcontrl);
            this.TransitionCal1.SetDecoration(this.Panel_Dargcontrl_big, Guna.UI2.AnimatorNS.DecorationType.None);
            this.TransitionCal.SetDecoration(this.Panel_Dargcontrl_big, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Panel_Dargcontrl_big.Location = new System.Drawing.Point(127, -3);
            this.Panel_Dargcontrl_big.Name = "Panel_Dargcontrl_big";
            this.Panel_Dargcontrl_big.ShadowDecoration.Parent = this.Panel_Dargcontrl_big;
            this.Panel_Dargcontrl_big.Size = new System.Drawing.Size(105, 43);
            this.Panel_Dargcontrl_big.TabIndex = 33;
            // 
            // Panel_Dargcontrl
            // 
            this.Panel_Dargcontrl.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Dargcontrl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Panel_Dargcontrl.BorderRadius = 5;
            this.Panel_Dargcontrl.BorderThickness = 1;
            this.Panel_Dargcontrl.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TransitionCal1.SetDecoration(this.Panel_Dargcontrl, Guna.UI2.AnimatorNS.DecorationType.None);
            this.TransitionCal.SetDecoration(this.Panel_Dargcontrl, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Panel_Dargcontrl.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Panel_Dargcontrl.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Panel_Dargcontrl.Location = new System.Drawing.Point(0, 29);
            this.Panel_Dargcontrl.Name = "Panel_Dargcontrl";
            this.Panel_Dargcontrl.ShadowDecoration.Parent = this.Panel_Dargcontrl;
            this.Panel_Dargcontrl.Size = new System.Drawing.Size(102, 11);
            this.Panel_Dargcontrl.TabIndex = 18;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderColor = System.Drawing.Color.Transparent;
            this.TransitionCal1.SetDecoration(this.btnClose, Guna.UI2.AnimatorNS.DecorationType.None);
            this.TransitionCal.SetDecoration(this.btnClose, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.IconColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(1143, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(45, 31);
            this.btnClose.TabIndex = 16;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Animated = true;
            this.txtBoxPassword.AutoRoundedCorners = true;
            this.txtBoxPassword.BorderRadius = 25;
            this.txtBoxPassword.BorderThickness = 0;
            this.txtBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TransitionCal1.SetDecoration(this.txtBoxPassword, Guna.UI2.AnimatorNS.DecorationType.None);
            this.TransitionCal.SetDecoration(this.txtBoxPassword, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtBoxPassword.DefaultText = "";
            this.txtBoxPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxPassword.DisabledState.Parent = this.txtBoxPassword;
            this.txtBoxPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxPassword.FillColor = System.Drawing.SystemColors.ControlLight;
            this.txtBoxPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxPassword.FocusedState.Parent = this.txtBoxPassword;
            this.txtBoxPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxPassword.ForeColor = System.Drawing.Color.Black;
            this.txtBoxPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxPassword.HoverState.Parent = this.txtBoxPassword;
            this.txtBoxPassword.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtBoxPassword.IconLeft")));
            this.txtBoxPassword.Location = new System.Drawing.Point(26, 78);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.PasswordChar = '\0';
            this.txtBoxPassword.PlaceholderText = "Password";
            this.txtBoxPassword.SelectedText = "";
            this.txtBoxPassword.ShadowDecoration.Parent = this.txtBoxPassword;
            this.txtBoxPassword.Size = new System.Drawing.Size(267, 52);
            this.txtBoxPassword.TabIndex = 2;
            this.txtBoxPassword.UseSystemPasswordChar = true;
            this.txtBoxPassword.Enter += new System.EventHandler(this.txtBoxPassword_Enter_1);
            this.txtBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxPassword_KeyDown);
            // 
            // txtBoxUserName
            // 
            this.txtBoxUserName.Animated = true;
            this.txtBoxUserName.AutoRoundedCorners = true;
            this.txtBoxUserName.BorderRadius = 25;
            this.txtBoxUserName.BorderThickness = 0;
            this.txtBoxUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TransitionCal1.SetDecoration(this.txtBoxUserName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.TransitionCal.SetDecoration(this.txtBoxUserName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtBoxUserName.DefaultText = "";
            this.txtBoxUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxUserName.DisabledState.Parent = this.txtBoxUserName;
            this.txtBoxUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxUserName.FillColor = System.Drawing.SystemColors.ControlLight;
            this.txtBoxUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxUserName.FocusedState.Parent = this.txtBoxUserName;
            this.txtBoxUserName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxUserName.ForeColor = System.Drawing.Color.Black;
            this.txtBoxUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxUserName.HoverState.Parent = this.txtBoxUserName;
            this.txtBoxUserName.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtBoxUserName.IconLeft")));
            this.txtBoxUserName.Location = new System.Drawing.Point(26, 10);
            this.txtBoxUserName.Name = "txtBoxUserName";
            this.txtBoxUserName.PasswordChar = '\0';
            this.txtBoxUserName.PlaceholderText = "email@example.com";
            this.txtBoxUserName.SelectedText = "";
            this.txtBoxUserName.ShadowDecoration.Parent = this.txtBoxUserName;
            this.txtBoxUserName.Size = new System.Drawing.Size(267, 52);
            this.txtBoxUserName.TabIndex = 0;
            this.txtBoxUserName.TextChanged += new System.EventHandler(this.txtBoxUserName_TextChanged);
            this.txtBoxUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxUserName_KeyDown);
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.ContainerControl = this;
            this.guna2DragControl2.TargetControl = this.Panel_Dargcontrl;
            // 
            // PanelLogin
            // 
            this.PanelLogin.Controls.Add(this.lblAlert);
            this.PanelLogin.Controls.Add(this.lblShowPWD);
            this.PanelLogin.Controls.Add(this.togswitShowPWD);
            this.PanelLogin.Controls.Add(this.txtBoxPassword);
            this.PanelLogin.Controls.Add(this.txtBoxUserName);
            this.TransitionCal1.SetDecoration(this.PanelLogin, Guna.UI2.AnimatorNS.DecorationType.None);
            this.TransitionCal.SetDecoration(this.PanelLogin, Guna.UI2.AnimatorNS.DecorationType.None);
            this.PanelLogin.Location = new System.Drawing.Point(44, 189);
            this.PanelLogin.Name = "PanelLogin";
            this.PanelLogin.ShadowDecoration.Parent = this.PanelLogin;
            this.PanelLogin.Size = new System.Drawing.Size(311, 257);
            this.PanelLogin.TabIndex = 26;
            // 
            // lblAlert
            // 
            this.lblAlert.AutoSize = true;
            this.TransitionCal.SetDecoration(this.lblAlert, Guna.UI2.AnimatorNS.DecorationType.None);
            this.TransitionCal1.SetDecoration(this.lblAlert, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblAlert.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlert.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblAlert.Location = new System.Drawing.Point(33, 184);
            this.lblAlert.Name = "lblAlert";
            this.lblAlert.Size = new System.Drawing.Size(0, 22);
            this.lblAlert.TabIndex = 8;
            // 
            // lblShowPWD
            // 
            this.lblShowPWD.AutoSize = true;
            this.TransitionCal.SetDecoration(this.lblShowPWD, Guna.UI2.AnimatorNS.DecorationType.None);
            this.TransitionCal1.SetDecoration(this.lblShowPWD, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblShowPWD.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblShowPWD.ForeColor = System.Drawing.Color.Black;
            this.lblShowPWD.Location = new System.Drawing.Point(68, 148);
            this.lblShowPWD.Name = "lblShowPWD";
            this.lblShowPWD.Size = new System.Drawing.Size(119, 21);
            this.lblShowPWD.TabIndex = 7;
            this.lblShowPWD.Text = "Show Password";
            // 
            // togswitShowPWD
            // 
            this.togswitShowPWD.Animated = true;
            this.togswitShowPWD.BackColor = System.Drawing.Color.Transparent;
            this.togswitShowPWD.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.togswitShowPWD.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.togswitShowPWD.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.togswitShowPWD.CheckedState.InnerColor = System.Drawing.Color.White;
            this.togswitShowPWD.CheckedState.Parent = this.togswitShowPWD;
            this.togswitShowPWD.Cursor = System.Windows.Forms.Cursors.Default;
            this.TransitionCal1.SetDecoration(this.togswitShowPWD, Guna.UI2.AnimatorNS.DecorationType.None);
            this.TransitionCal.SetDecoration(this.togswitShowPWD, Guna.UI2.AnimatorNS.DecorationType.None);
            this.togswitShowPWD.Location = new System.Drawing.Point(33, 146);
            this.togswitShowPWD.Name = "togswitShowPWD";
            this.togswitShowPWD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.togswitShowPWD.ShadowDecoration.Parent = this.togswitShowPWD;
            this.togswitShowPWD.Size = new System.Drawing.Size(35, 22);
            this.togswitShowPWD.TabIndex = 7;
            this.togswitShowPWD.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.togswitShowPWD.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.togswitShowPWD.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.togswitShowPWD.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.togswitShowPWD.UncheckedState.Parent = this.togswitShowPWD;
            this.togswitShowPWD.CheckedChanged += new System.EventHandler(this.togswitShowPWD_CheckedChanged);
            // 
            // PanelCal
            // 
            this.PanelCal.BackColor = System.Drawing.Color.Transparent;
            this.PanelCal.Controls.Add(this.lblReminder);
            this.PanelCal.Controls.Add(this.lblType);
            this.PanelCal.Controls.Add(this.cboType);
            this.PanelCal.Controls.Add(this.guna2GradientPanel1);
            this.PanelCal.Controls.Add(this.btnReset);
            this.PanelCal.Controls.Add(this.btnSubmit);
            this.PanelCal.Controls.Add(this.txtWeight);
            this.PanelCal.Controls.Add(this.cboDestination);
            this.PanelCal.Controls.Add(this.label1);
            this.PanelCal.Controls.Add(this.lblWeight);
            this.PanelCal.Controls.Add(this.lblDestination);
            this.PanelCal.Controls.Add(this.btnBack);
            this.TransitionCal1.SetDecoration(this.PanelCal, Guna.UI2.AnimatorNS.DecorationType.None);
            this.TransitionCal.SetDecoration(this.PanelCal, Guna.UI2.AnimatorNS.DecorationType.None);
            this.PanelCal.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.PanelCal.ForeColor = System.Drawing.Color.Black;
            this.PanelCal.Location = new System.Drawing.Point(31, 189);
            this.PanelCal.Name = "PanelCal";
            this.PanelCal.ShadowDecoration.Parent = this.PanelCal;
            this.PanelCal.Size = new System.Drawing.Size(324, 470);
            this.PanelCal.TabIndex = 27;
            this.PanelCal.Visible = false;
            this.PanelCal.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelCal_Paint);
            // 
            // lblReminder
            // 
            this.lblReminder.AutoSize = true;
            this.TransitionCal.SetDecoration(this.lblReminder, Guna.UI2.AnimatorNS.DecorationType.None);
            this.TransitionCal1.SetDecoration(this.lblReminder, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblReminder.Font = new System.Drawing.Font("Segoe UI", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReminder.Location = new System.Drawing.Point(8, 327);
            this.lblReminder.Name = "lblReminder";
            this.lblReminder.Size = new System.Drawing.Size(0, 10);
            this.lblReminder.TabIndex = 44;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.TransitionCal.SetDecoration(this.lblType, Guna.UI2.AnimatorNS.DecorationType.None);
            this.TransitionCal1.SetDecoration(this.lblType, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblType.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.lblType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.lblType.Location = new System.Drawing.Point(33, 25);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(50, 21);
            this.lblType.TabIndex = 45;
            this.lblType.Text = "Type:";
            // 
            // cboType
            // 
            this.cboType.AutoRoundedCorners = true;
            this.cboType.BackColor = System.Drawing.Color.Transparent;
            this.cboType.BorderRadius = 17;
            this.TransitionCal1.SetDecoration(this.cboType, Guna.UI2.AnimatorNS.DecorationType.None);
            this.TransitionCal.SetDecoration(this.cboType, Guna.UI2.AnimatorNS.DecorationType.None);
            this.cboType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboType.FocusedState.Parent = this.cboType;
            this.cboType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboType.HoverState.Parent = this.cboType;
            this.cboType.ItemHeight = 30;
            this.cboType.Items.AddRange(new object[] {
            "Document",
            "Freight"});
            this.cboType.ItemsAppearance.Parent = this.cboType;
            this.cboType.Location = new System.Drawing.Point(124, 17);
            this.cboType.Name = "cboType";
            this.cboType.ShadowDecoration.Parent = this.cboType;
            this.cboType.Size = new System.Drawing.Size(115, 36);
            this.cboType.TabIndex = 44;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2GradientPanel1.BorderRadius = 5;
            this.guna2GradientPanel1.BorderThickness = 1;
            this.guna2GradientPanel1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TransitionCal1.SetDecoration(this.guna2GradientPanel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.TransitionCal.SetDecoration(this.guna2GradientPanel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(10, 424);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(300, 2);
            this.guna2GradientPanel1.TabIndex = 19;
            // 
            // btnReset
            // 
            this.btnReset.Animated = true;
            this.btnReset.AutoRoundedCorners = true;
            this.btnReset.BorderRadius = 18;
            this.btnReset.BorderThickness = 2;
            this.btnReset.CheckedState.Parent = this.btnReset;
            this.btnReset.CustomImages.Parent = this.btnReset;
            this.TransitionCal1.SetDecoration(this.btnReset, Guna.UI2.AnimatorNS.DecorationType.None);
            this.TransitionCal.SetDecoration(this.btnReset, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnReset.DisabledState.Parent = this.btnReset;
            this.btnReset.FillColor = System.Drawing.Color.White;
            this.btnReset.FillColor2 = System.Drawing.Color.White;
            this.btnReset.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.HoverState.Parent = this.btnReset;
            this.btnReset.Location = new System.Drawing.Point(38, 288);
            this.btnReset.Name = "btnReset";
            this.btnReset.ShadowDecoration.Parent = this.btnReset;
            this.btnReset.Size = new System.Drawing.Size(80, 38);
            this.btnReset.TabIndex = 43;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Animated = true;
            this.btnSubmit.AutoRoundedCorners = true;
            this.btnSubmit.BorderRadius = 18;
            this.btnSubmit.BorderThickness = 2;
            this.btnSubmit.CheckedState.Parent = this.btnSubmit;
            this.btnSubmit.CustomImages.Parent = this.btnSubmit;
            this.TransitionCal1.SetDecoration(this.btnSubmit, Guna.UI2.AnimatorNS.DecorationType.None);
            this.TransitionCal.SetDecoration(this.btnSubmit, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnSubmit.DisabledState.Parent = this.btnSubmit;
            this.btnSubmit.FillColor = System.Drawing.Color.White;
            this.btnSubmit.FillColor2 = System.Drawing.Color.White;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.Black;
            this.btnSubmit.HoverState.Parent = this.btnSubmit;
            this.btnSubmit.Location = new System.Drawing.Point(176, 288);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.ShadowDecoration.Parent = this.btnSubmit;
            this.btnSubmit.Size = new System.Drawing.Size(80, 38);
            this.btnSubmit.TabIndex = 42;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtWeight
            // 
            this.txtWeight.Animated = true;
            this.txtWeight.BorderRadius = 17;
            this.txtWeight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TransitionCal1.SetDecoration(this.txtWeight, Guna.UI2.AnimatorNS.DecorationType.None);
            this.TransitionCal.SetDecoration(this.txtWeight, Guna.UI2.AnimatorNS.DecorationType.None);
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
            this.txtWeight.Location = new System.Drawing.Point(40, 215);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.PasswordChar = '\0';
            this.txtWeight.PlaceholderText = "Input a number please.";
            this.txtWeight.SelectedText = "";
            this.txtWeight.ShadowDecoration.Parent = this.txtWeight;
            this.txtWeight.Size = new System.Drawing.Size(200, 39);
            this.txtWeight.TabIndex = 41;
            this.txtWeight.TextChanged += new System.EventHandler(this.txtWeight_TextChanged);
            // 
            // cboDestination
            // 
            this.cboDestination.AutoRoundedCorners = true;
            this.cboDestination.BackColor = System.Drawing.Color.Transparent;
            this.cboDestination.BorderRadius = 17;
            this.TransitionCal1.SetDecoration(this.cboDestination, Guna.UI2.AnimatorNS.DecorationType.None);
            this.TransitionCal.SetDecoration(this.cboDestination, Guna.UI2.AnimatorNS.DecorationType.None);
            this.cboDestination.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboDestination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDestination.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboDestination.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboDestination.FocusedState.Parent = this.cboDestination;
            this.cboDestination.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboDestination.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboDestination.HoverState.Parent = this.cboDestination;
            this.cboDestination.ItemHeight = 30;
            this.cboDestination.Items.AddRange(new object[] {
            "Australia",
            "Shanghai-China",
            "Japan"});
            this.cboDestination.ItemsAppearance.Parent = this.cboDestination;
            this.cboDestination.Location = new System.Drawing.Point(38, 106);
            this.cboDestination.Name = "cboDestination";
            this.cboDestination.ShadowDecoration.Parent = this.cboDestination;
            this.cboDestination.Size = new System.Drawing.Size(202, 36);
            this.cboDestination.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.TransitionCal.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.TransitionCal1.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 6.25F);
            this.label1.Location = new System.Drawing.Point(10, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 56);
            this.label1.TabIndex = 39;
            this.label1.Text = "Remarks: (FREIGHT)\r\n1. EDE is not responsible for any duties or taxes imposed by " +
    "\r\nthe destination country.\r\n2. All payments must be settled in Hong Kong";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.TransitionCal.SetDecoration(this.lblWeight, Guna.UI2.AnimatorNS.DecorationType.None);
            this.TransitionCal1.SetDecoration(this.lblWeight, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblWeight.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.lblWeight.Location = new System.Drawing.Point(36, 171);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(103, 21);
            this.lblWeight.TabIndex = 35;
            this.lblWeight.Text = "Weight: (kg)";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.TransitionCal.SetDecoration(this.lblDestination, Guna.UI2.AnimatorNS.DecorationType.None);
            this.TransitionCal1.SetDecoration(this.lblDestination, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblDestination.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestination.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.lblDestination.Location = new System.Drawing.Point(34, 67);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(101, 21);
            this.lblDestination.TabIndex = 32;
            this.lblDestination.Text = "Destination:";
            // 
            // btnBack
            // 
            this.btnBack.Animated = true;
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BorderRadius = 10;
            this.btnBack.CheckedState.Parent = this.btnBack;
            this.btnBack.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnBack.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBack.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.btnBack.CustomImages.Parent = this.btnBack;
            this.TransitionCal1.SetDecoration(this.btnBack, Guna.UI2.AnimatorNS.DecorationType.None);
            this.TransitionCal.SetDecoration(this.btnBack, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnBack.DisabledState.Parent = this.btnBack;
            this.btnBack.FillColor = System.Drawing.Color.Transparent;
            this.btnBack.FillColor2 = System.Drawing.Color.Transparent;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.HoverState.Parent = this.btnBack;
            this.btnBack.Location = new System.Drawing.Point(274, 137);
            this.btnBack.Name = "btnBack";
            this.btnBack.ShadowDecoration.Parent = this.btnBack;
            this.btnBack.Size = new System.Drawing.Size(50, 108);
            this.btnBack.TabIndex = 31;
            this.btnBack.UseTransparentBackground = true;
            this.btnBack.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.TransitionCal.SetDecoration(this.lblLogin, Guna.UI2.AnimatorNS.DecorationType.None);
            this.TransitionCal1.SetDecoration(this.lblLogin, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI", 27.75F);
            this.lblLogin.ForeColor = System.Drawing.Color.Black;
            this.lblLogin.Location = new System.Drawing.Point(118, 129);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(113, 50);
            this.lblLogin.TabIndex = 27;
            this.lblLogin.Text = "Login";
            // 
            // btnLogin
            // 
            this.btnLogin.Animated = true;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BorderRadius = 10;
            this.btnLogin.CheckedState.Parent = this.btnLogin;
            this.btnLogin.CustomImages.CheckedImage = ((System.Drawing.Image)(resources.GetObject("resource.CheckedImage")));
            this.btnLogin.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.btnLogin.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLogin.CustomImages.Parent = this.btnLogin;
            this.TransitionCal1.SetDecoration(this.btnLogin, Guna.UI2.AnimatorNS.DecorationType.None);
            this.TransitionCal.SetDecoration(this.btnLogin, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnLogin.DisabledState.Parent = this.btnLogin;
            this.btnLogin.FillColor = System.Drawing.Color.OrangeRed;
            this.btnLogin.FillColor2 = System.Drawing.Color.Crimson;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.Parent = this.btnLogin;
            this.btnLogin.Location = new System.Drawing.Point(141, 499);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ShadowDecoration.Parent = this.btnLogin;
            this.btnLogin.Size = new System.Drawing.Size(66, 65);
            this.btnLogin.TabIndex = 28;
            this.btnLogin.UseTransparentBackground = true;
            this.btnLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.BackColor = System.Drawing.Color.Transparent;
            this.lblRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransitionCal.SetDecoration(this.lblRegister, Guna.UI2.AnimatorNS.DecorationType.None);
            this.TransitionCal1.SetDecoration(this.lblRegister, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblRegister.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.ForeColor = System.Drawing.Color.DarkGray;
            this.lblRegister.Location = new System.Drawing.Point(249, 684);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(124, 50);
            this.lblRegister.TabIndex = 6;
            this.lblRegister.Text = "Don\'t have \r\nan account?";
            this.lblRegister.Click += new System.EventHandler(this.lblRegister_Click);
            // 
            // btnQuestion
            // 
            this.btnQuestion.Animated = true;
            this.btnQuestion.BackColor = System.Drawing.Color.Transparent;
            this.btnQuestion.BorderColor = System.Drawing.Color.White;
            this.btnQuestion.CheckedState.Parent = this.btnQuestion;
            this.btnQuestion.CustomBorderColor = System.Drawing.Color.White;
            this.btnQuestion.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btnQuestion.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnQuestion.CustomImages.Parent = this.btnQuestion;
            this.TransitionCal1.SetDecoration(this.btnQuestion, Guna.UI2.AnimatorNS.DecorationType.None);
            this.TransitionCal.SetDecoration(this.btnQuestion, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnQuestion.DisabledState.Parent = this.btnQuestion;
            this.btnQuestion.FillColor = System.Drawing.Color.White;
            this.btnQuestion.FillColor2 = System.Drawing.Color.White;
            this.btnQuestion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnQuestion.ForeColor = System.Drawing.Color.White;
            this.btnQuestion.HoverState.Parent = this.btnQuestion;
            this.btnQuestion.Location = new System.Drawing.Point(330, 36);
            this.btnQuestion.Name = "btnQuestion";
            this.btnQuestion.PressedColor = System.Drawing.Color.White;
            this.btnQuestion.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnQuestion.ShadowDecoration.Parent = this.btnQuestion;
            this.btnQuestion.Size = new System.Drawing.Size(25, 27);
            this.btnQuestion.TabIndex = 29;
            this.btnQuestion.UseTransparentBackground = true;
            // 
            // TransitionCal
            // 
            this.TransitionCal.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            this.TransitionCal.Cursor = null;
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
            this.TransitionCal.DefaultAnimation = animation1;
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.BackColor = System.Drawing.Color.Transparent;
            this.lblHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransitionCal.SetDecoration(this.lblHelp, Guna.UI2.AnimatorNS.DecorationType.None);
            this.TransitionCal1.SetDecoration(this.lblHelp, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblHelp.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblHelp.ForeColor = System.Drawing.Color.DarkGray;
            this.lblHelp.Location = new System.Drawing.Point(112, 576);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(133, 21);
            this.lblHelp.TabIndex = 31;
            this.lblHelp.Text = "Forget password?";
            this.lblHelp.Click += new System.EventHandler(this.lblForgetPWD_Click);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.TransitionCal1.SetDecoration(this.guna2ControlBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.TransitionCal.SetDecoration(this.guna2ControlBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1092, 9);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 31);
            this.guna2ControlBox1.TabIndex = 32;
            // 
            // picMain
            // 
            this.TransitionCal.SetDecoration(this.picMain, Guna.UI2.AnimatorNS.DecorationType.None);
            this.TransitionCal1.SetDecoration(this.picMain, Guna.UI2.AnimatorNS.DecorationType.None);
            this.picMain.Image = ((System.Drawing.Image)(resources.GetObject("picMain.Image")));
            this.picMain.ImageRotate = 0F;
            this.picMain.Location = new System.Drawing.Point(399, 64);
            this.picMain.Name = "picMain";
            this.picMain.ShadowDecoration.Parent = this.picMain;
            this.picMain.Size = new System.Drawing.Size(800, 600);
            this.picMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picMain.TabIndex = 24;
            this.picMain.TabStop = false;
            this.picMain.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // lblFindme
            // 
            this.lblFindme.AutoSize = true;
            this.TransitionCal.SetDecoration(this.lblFindme, Guna.UI2.AnimatorNS.DecorationType.None);
            this.TransitionCal1.SetDecoration(this.lblFindme, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblFindme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFindme.Location = new System.Drawing.Point(762, 704);
            this.lblFindme.Name = "lblFindme";
            this.lblFindme.Size = new System.Drawing.Size(426, 30);
            this.lblFindme.TabIndex = 34;
            this.lblFindme.Text = "If your encounter any tenical issue, please feel free to contact us! \r\nContact: e" +
    "deexpress2021@gmail.com / +852 65867246.";
            // 
            // Iconbox
            // 
            this.TransitionCal.SetDecoration(this.Iconbox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.TransitionCal1.SetDecoration(this.Iconbox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Iconbox.Image = ((System.Drawing.Image)(resources.GetObject("Iconbox.Image")));
            this.Iconbox.ImageRotate = 0F;
            this.Iconbox.Location = new System.Drawing.Point(15, 64);
            this.Iconbox.Name = "Iconbox";
            this.Iconbox.ShadowDecoration.Parent = this.Iconbox;
            this.Iconbox.Size = new System.Drawing.Size(140, 76);
            this.Iconbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Iconbox.TabIndex = 35;
            this.Iconbox.TabStop = false;
            // 
            // cal_btn
            // 
            this.cal_btn.CheckedState.Parent = this.cal_btn;
            this.cal_btn.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.cal_btn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cal_btn.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.cal_btn.CustomImages.Parent = this.cal_btn;
            this.TransitionCal1.SetDecoration(this.cal_btn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.TransitionCal.SetDecoration(this.cal_btn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.cal_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cal_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cal_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cal_btn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cal_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cal_btn.DisabledState.Parent = this.cal_btn;
            this.cal_btn.FillColor = System.Drawing.Color.Transparent;
            this.cal_btn.FillColor2 = System.Drawing.Color.Transparent;
            this.cal_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cal_btn.ForeColor = System.Drawing.Color.White;
            this.cal_btn.HoverState.Parent = this.cal_btn;
            this.cal_btn.Location = new System.Drawing.Point(-13, 319);
            this.cal_btn.Name = "cal_btn";
            this.cal_btn.ShadowDecoration.Parent = this.cal_btn;
            this.cal_btn.Size = new System.Drawing.Size(61, 115);
            this.cal_btn.TabIndex = 36;
            this.cal_btn.Click += new System.EventHandler(this.buttonCal_Click);
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = DarkDemo.AirwayBillUI.DataSet_AirwayBillTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // TransitionCal1
            // 
            this.TransitionCal1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            this.TransitionCal1.Cursor = null;
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
            this.TransitionCal1.DefaultAnimation = animation2;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Controls.Add(this.cal_btn);
            this.Controls.Add(this.Iconbox);
            this.Controls.Add(this.lblFindme);
            this.Controls.Add(this.Panel_Dargcontrl_big);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.PanelCal);
            this.Controls.Add(lblVersion);
            this.Controls.Add(this.btnQuestion);
            this.Controls.Add(this.lblRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.PanelLogin);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.picMain);
            this.Controls.Add(this.lblHelp);
            this.TransitionCal1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.TransitionCal.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "a";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Enter += new System.EventHandler(this.Login_Enter);
            this.Panel_Dargcontrl_big.ResumeLayout(false);
            this.PanelLogin.ResumeLayout(false);
            this.PanelLogin.PerformLayout();
            this.PanelCal.ResumeLayout(false);
            this.PanelCal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Iconbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxUserName;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxPassword;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2Panel PanelLogin;
        private System.Windows.Forms.Label lblLogin;
        private Guna.UI2.WinForms.Guna2ToggleSwitch togswitShowPWD;
        private System.Windows.Forms.Label lblShowPWD;
        private Guna.UI2.WinForms.Guna2GradientButton btnLogin;
        private System.Windows.Forms.Label lblRegister;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btnQuestion;
        private Guna.UI2.WinForms.Guna2Panel PanelCal;
        private Guna.UI2.WinForms.Guna2Transition TransitionCal;
        private Guna.UI2.WinForms.Guna2GradientButton btnBack;
        private System.Windows.Forms.Label lblHelp;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientPanel Panel_Dargcontrl_big;
        private Guna.UI2.WinForms.Guna2GradientPanel Panel_Dargcontrl;
        private Guna.UI2.WinForms.Guna2PictureBox picMain;
        private System.Windows.Forms.Label lblAlert;
        private Guna.UI2.WinForms.Guna2ComboBox cboDestination;
        private Guna.UI2.WinForms.Guna2TextBox txtWeight;
        private Guna.UI2.WinForms.Guna2GradientButton btnReset;
        private Guna.UI2.WinForms.Guna2GradientButton btnSubmit;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label lblReminder;
        private Guna.UI2.WinForms.Guna2ComboBox cboType;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private AirwayBillUI.DataSet_AirwayBillTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblFindme;
        private Guna.UI2.WinForms.Guna2PictureBox Iconbox;
        private Guna.UI2.WinForms.Guna2GradientButton cal_btn;
        private Guna.UI2.WinForms.Guna2Transition TransitionCal1;
    }
}