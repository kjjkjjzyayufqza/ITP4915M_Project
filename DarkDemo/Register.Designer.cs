
namespace DarkDemo
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.txtBoxRegisterUserEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.Lab_Register = new System.Windows.Forms.Label();
            this.txtBoxRegisterUserPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBoxRegisterUserPassword_c = new Guna.UI2.WinForms.Guna2TextBox();
            this.CircleProgressBar_Register = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.lblMessage = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Code_c = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnSendcode = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btRegister = new Guna.UI2.WinForms.Guna2GradientButton();
            this.timer_register = new System.Windows.Forms.Timer(this.components);
            this.CircleProgressBar_Register.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(797, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 0;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.ContainerControl = this;
            this.guna2DragControl1.DragStartTransparencyValue = 0.8D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.TransparentWhileDrag = true;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // txtBoxRegisterUserEmail
            // 
            this.txtBoxRegisterUserEmail.Animated = true;
            this.txtBoxRegisterUserEmail.AutoRoundedCorners = true;
            this.txtBoxRegisterUserEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBoxRegisterUserEmail.BorderRadius = 23;
            this.txtBoxRegisterUserEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxRegisterUserEmail.DefaultText = "";
            this.txtBoxRegisterUserEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxRegisterUserEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxRegisterUserEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxRegisterUserEmail.DisabledState.Parent = this.txtBoxRegisterUserEmail;
            this.txtBoxRegisterUserEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxRegisterUserEmail.FillColor = System.Drawing.SystemColors.ControlLight;
            this.txtBoxRegisterUserEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxRegisterUserEmail.FocusedState.Parent = this.txtBoxRegisterUserEmail;
            this.txtBoxRegisterUserEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxRegisterUserEmail.ForeColor = System.Drawing.Color.Black;
            this.txtBoxRegisterUserEmail.HoverState.BorderColor = System.Drawing.Color.Black;
            this.txtBoxRegisterUserEmail.HoverState.Parent = this.txtBoxRegisterUserEmail;
            this.txtBoxRegisterUserEmail.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtBoxRegisterUserEmail.IconLeft")));
            this.txtBoxRegisterUserEmail.Location = new System.Drawing.Point(102, 112);
            this.txtBoxRegisterUserEmail.MaxLength = 150;
            this.txtBoxRegisterUserEmail.Name = "txtBoxRegisterUserEmail";
            this.txtBoxRegisterUserEmail.PasswordChar = '\0';
            this.txtBoxRegisterUserEmail.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtBoxRegisterUserEmail.PlaceholderText = "sample@mail.com";
            this.txtBoxRegisterUserEmail.SelectedText = "";
            this.txtBoxRegisterUserEmail.ShadowDecoration.Parent = this.txtBoxRegisterUserEmail;
            this.txtBoxRegisterUserEmail.Size = new System.Drawing.Size(267, 48);
            this.txtBoxRegisterUserEmail.TabIndex = 29;
            this.txtBoxRegisterUserEmail.TextChanged += new System.EventHandler(this.txtBoxRegisterUserEmail_TextChanged);
            // 
            // Lab_Register
            // 
            this.Lab_Register.AutoSize = true;
            this.Lab_Register.Font = new System.Drawing.Font("Segoe UI", 27.75F);
            this.Lab_Register.ForeColor = System.Drawing.Color.Black;
            this.Lab_Register.Location = new System.Drawing.Point(151, 48);
            this.Lab_Register.Name = "Lab_Register";
            this.Lab_Register.Size = new System.Drawing.Size(154, 50);
            this.Lab_Register.TabIndex = 28;
            this.Lab_Register.Text = "Register";
            this.Lab_Register.Click += new System.EventHandler(this.Lab_Register_Click);
            // 
            // txtBoxRegisterUserPassword
            // 
            this.txtBoxRegisterUserPassword.Animated = true;
            this.txtBoxRegisterUserPassword.AutoRoundedCorners = true;
            this.txtBoxRegisterUserPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBoxRegisterUserPassword.BorderRadius = 23;
            this.txtBoxRegisterUserPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxRegisterUserPassword.DefaultText = "";
            this.txtBoxRegisterUserPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxRegisterUserPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxRegisterUserPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxRegisterUserPassword.DisabledState.Parent = this.txtBoxRegisterUserPassword;
            this.txtBoxRegisterUserPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxRegisterUserPassword.FillColor = System.Drawing.SystemColors.ControlLight;
            this.txtBoxRegisterUserPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxRegisterUserPassword.FocusedState.Parent = this.txtBoxRegisterUserPassword;
            this.txtBoxRegisterUserPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxRegisterUserPassword.ForeColor = System.Drawing.Color.Black;
            this.txtBoxRegisterUserPassword.HoverState.BorderColor = System.Drawing.Color.Black;
            this.txtBoxRegisterUserPassword.HoverState.Parent = this.txtBoxRegisterUserPassword;
            this.txtBoxRegisterUserPassword.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtBoxRegisterUserPassword.IconLeft")));
            this.txtBoxRegisterUserPassword.Location = new System.Drawing.Point(102, 166);
            this.txtBoxRegisterUserPassword.MaxLength = 20;
            this.txtBoxRegisterUserPassword.Name = "txtBoxRegisterUserPassword";
            this.txtBoxRegisterUserPassword.PasswordChar = '\0';
            this.txtBoxRegisterUserPassword.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtBoxRegisterUserPassword.PlaceholderText = "password(6 digits)";
            this.txtBoxRegisterUserPassword.SelectedText = "";
            this.txtBoxRegisterUserPassword.ShadowDecoration.Parent = this.txtBoxRegisterUserPassword;
            this.txtBoxRegisterUserPassword.Size = new System.Drawing.Size(267, 48);
            this.txtBoxRegisterUserPassword.TabIndex = 30;
            this.txtBoxRegisterUserPassword.UseSystemPasswordChar = true;
            this.txtBoxRegisterUserPassword.TextChanged += new System.EventHandler(this.txtBoxRegisterUserPassword_TextChanged);
            // 
            // txtBoxRegisterUserPassword_c
            // 
            this.txtBoxRegisterUserPassword_c.Animated = true;
            this.txtBoxRegisterUserPassword_c.AutoRoundedCorners = true;
            this.txtBoxRegisterUserPassword_c.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBoxRegisterUserPassword_c.BorderRadius = 23;
            this.txtBoxRegisterUserPassword_c.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxRegisterUserPassword_c.DefaultText = "";
            this.txtBoxRegisterUserPassword_c.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxRegisterUserPassword_c.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxRegisterUserPassword_c.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxRegisterUserPassword_c.DisabledState.Parent = this.txtBoxRegisterUserPassword_c;
            this.txtBoxRegisterUserPassword_c.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxRegisterUserPassword_c.FillColor = System.Drawing.SystemColors.ControlLight;
            this.txtBoxRegisterUserPassword_c.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxRegisterUserPassword_c.FocusedState.Parent = this.txtBoxRegisterUserPassword_c;
            this.txtBoxRegisterUserPassword_c.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxRegisterUserPassword_c.ForeColor = System.Drawing.Color.Black;
            this.txtBoxRegisterUserPassword_c.HoverState.BorderColor = System.Drawing.Color.Black;
            this.txtBoxRegisterUserPassword_c.HoverState.Parent = this.txtBoxRegisterUserPassword_c;
            this.txtBoxRegisterUserPassword_c.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtBoxRegisterUserPassword_c.IconLeft")));
            this.txtBoxRegisterUserPassword_c.Location = new System.Drawing.Point(102, 220);
            this.txtBoxRegisterUserPassword_c.MaxLength = 20;
            this.txtBoxRegisterUserPassword_c.Name = "txtBoxRegisterUserPassword_c";
            this.txtBoxRegisterUserPassword_c.PasswordChar = '\0';
            this.txtBoxRegisterUserPassword_c.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtBoxRegisterUserPassword_c.PlaceholderText = "confirm password(6 digits)";
            this.txtBoxRegisterUserPassword_c.SelectedText = "";
            this.txtBoxRegisterUserPassword_c.ShadowDecoration.Parent = this.txtBoxRegisterUserPassword_c;
            this.txtBoxRegisterUserPassword_c.Size = new System.Drawing.Size(267, 48);
            this.txtBoxRegisterUserPassword_c.TabIndex = 31;
            this.txtBoxRegisterUserPassword_c.UseSystemPasswordChar = true;
            this.txtBoxRegisterUserPassword_c.TextChanged += new System.EventHandler(this.txtBoxRegisterUserPassword_c_TextChanged);
            // 
            // CircleProgressBar_Register
            // 
            this.CircleProgressBar_Register.BackColor = System.Drawing.Color.Transparent;
            this.CircleProgressBar_Register.Controls.Add(this.lblMessage);
            this.CircleProgressBar_Register.Controls.Add(this.Code_c);
            this.CircleProgressBar_Register.Controls.Add(this.BtnSendcode);
            this.CircleProgressBar_Register.Controls.Add(this.btRegister);
            this.CircleProgressBar_Register.Controls.Add(this.txtBoxRegisterUserPassword_c);
            this.CircleProgressBar_Register.Controls.Add(this.txtBoxRegisterUserPassword);
            this.CircleProgressBar_Register.Controls.Add(this.Lab_Register);
            this.CircleProgressBar_Register.Controls.Add(this.txtBoxRegisterUserEmail);
            this.CircleProgressBar_Register.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CircleProgressBar_Register.ForeColor = System.Drawing.Color.White;
            this.CircleProgressBar_Register.InnerColor = System.Drawing.Color.White;
            this.CircleProgressBar_Register.Location = new System.Drawing.Point(189, 37);
            this.CircleProgressBar_Register.Minimum = 0;
            this.CircleProgressBar_Register.Name = "CircleProgressBar_Register";
            this.CircleProgressBar_Register.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.CircleProgressBar_Register.ShadowDecoration.Parent = this.CircleProgressBar_Register;
            this.CircleProgressBar_Register.Size = new System.Drawing.Size(476, 476);
            this.CircleProgressBar_Register.TabIndex = 31;
            this.CircleProgressBar_Register.ValueChanged += new System.EventHandler(this.CircleProgressBar_Register_ValueChanged);
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Black;
            this.lblMessage.Location = new System.Drawing.Point(100, 328);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(3, 2);
            this.lblMessage.TabIndex = 37;
            this.lblMessage.Text = null;
            this.lblMessage.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.lblMessage.Click += new System.EventHandler(this.lblMessage_Click);
            // 
            // Code_c
            // 
            this.Code_c.Animated = true;
            this.Code_c.AutoRoundedCorners = true;
            this.Code_c.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Code_c.BorderRadius = 23;
            this.Code_c.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Code_c.DefaultText = "";
            this.Code_c.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Code_c.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Code_c.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Code_c.DisabledState.Parent = this.Code_c;
            this.Code_c.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Code_c.FillColor = System.Drawing.SystemColors.ControlLight;
            this.Code_c.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Code_c.FocusedState.Parent = this.Code_c;
            this.Code_c.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Code_c.ForeColor = System.Drawing.Color.Black;
            this.Code_c.HoverState.BorderColor = System.Drawing.Color.Black;
            this.Code_c.HoverState.Parent = this.Code_c;
            this.Code_c.IconLeft = ((System.Drawing.Image)(resources.GetObject("Code_c.IconLeft")));
            this.Code_c.Location = new System.Drawing.Point(102, 274);
            this.Code_c.MaxLength = 6;
            this.Code_c.Name = "Code_c";
            this.Code_c.PasswordChar = '\0';
            this.Code_c.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.Code_c.PlaceholderText = "code(6 digits)";
            this.Code_c.SelectedText = "";
            this.Code_c.ShadowDecoration.Parent = this.Code_c;
            this.Code_c.Size = new System.Drawing.Size(157, 48);
            this.Code_c.TabIndex = 32;
            this.Code_c.TextChanged += new System.EventHandler(this.Code_c_TextChanged);
            // 
            // BtnSendcode
            // 
            this.BtnSendcode.Animated = true;
            this.BtnSendcode.BackColor = System.Drawing.Color.Transparent;
            this.BtnSendcode.BorderColor = System.Drawing.Color.DimGray;
            this.BtnSendcode.BorderRadius = 15;
            this.BtnSendcode.BorderThickness = 1;
            this.BtnSendcode.CheckedState.Parent = this.BtnSendcode;
            this.BtnSendcode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSendcode.CustomImages.CheckedImage = ((System.Drawing.Image)(resources.GetObject("resource.CheckedImage")));
            this.BtnSendcode.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnSendcode.CustomImages.Parent = this.BtnSendcode;
            this.BtnSendcode.DisabledState.Parent = this.BtnSendcode;
            this.BtnSendcode.FillColor = System.Drawing.Color.WhiteSmoke;
            this.BtnSendcode.FillColor2 = System.Drawing.Color.WhiteSmoke;
            this.BtnSendcode.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8F);
            this.BtnSendcode.ForeColor = System.Drawing.Color.Black;
            this.BtnSendcode.HoverState.Parent = this.BtnSendcode;
            this.BtnSendcode.Location = new System.Drawing.Point(265, 278);
            this.BtnSendcode.Name = "BtnSendcode";
            this.BtnSendcode.ShadowDecoration.Parent = this.BtnSendcode;
            this.BtnSendcode.Size = new System.Drawing.Size(91, 42);
            this.BtnSendcode.TabIndex = 35;
            this.BtnSendcode.Text = "Send Code";
            this.BtnSendcode.UseTransparentBackground = true;
            this.BtnSendcode.Click += new System.EventHandler(this.BtnSendcode_Click);
            // 
            // btRegister
            // 
            this.btRegister.Animated = true;
            this.btRegister.BackColor = System.Drawing.Color.Transparent;
            this.btRegister.BorderRadius = 10;
            this.btRegister.CheckedState.Parent = this.btRegister;
            this.btRegister.CustomImages.CheckedImage = ((System.Drawing.Image)(resources.GetObject("resource.CheckedImage1")));
            this.btRegister.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btRegister.CustomImages.Parent = this.btRegister;
            this.btRegister.DisabledState.Parent = this.btRegister;
            this.btRegister.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btRegister.FillColor2 = System.Drawing.Color.Firebrick;
            this.btRegister.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btRegister.ForeColor = System.Drawing.Color.White;
            this.btRegister.HoverState.Parent = this.btRegister;
            this.btRegister.Location = new System.Drawing.Point(175, 369);
            this.btRegister.Name = "btRegister";
            this.btRegister.ShadowDecoration.Parent = this.btRegister;
            this.btRegister.Size = new System.Drawing.Size(126, 54);
            this.btRegister.TabIndex = 34;
            this.btRegister.Text = "Register";
            this.btRegister.UseTransparentBackground = true;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // timer_register
            // 
            this.timer_register.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(854, 550);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.CircleProgressBar_Register);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.CircleProgressBar_Register.ResumeLayout(false);
            this.CircleProgressBar_Register.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar CircleProgressBar_Register;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxRegisterUserPassword_c;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxRegisterUserPassword;
        private System.Windows.Forms.Label Lab_Register;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxRegisterUserEmail;
        private Guna.UI2.WinForms.Guna2GradientButton btRegister;
        private Guna.UI2.WinForms.Guna2TextBox Code_c;
        private Guna.UI2.WinForms.Guna2GradientButton BtnSendcode;
        private System.Windows.Forms.Timer timer_register;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMessage;
    }
}