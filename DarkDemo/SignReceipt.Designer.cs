
namespace DarkDemo
{
    partial class SignReceipt
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignReceipt));
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnConfirm = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.btnSign = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer2
            // 
            this.reportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = null;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "DarkDemo.InvoiceUI.Report1.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(35, 37);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.ShowToolBar = false;
            this.reportViewer2.Size = new System.Drawing.Size(913, 685);
            this.reportViewer2.TabIndex = 94;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Animated = true;
            this.btnConfirm.BorderThickness = 2;
            this.btnConfirm.CheckedState.Parent = this.btnConfirm;
            this.btnConfirm.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnConfirm.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnConfirm.CustomImages.Parent = this.btnConfirm;
            this.btnConfirm.DisabledState.Parent = this.btnConfirm;
            this.btnConfirm.FillColor = System.Drawing.Color.White;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.Black;
            this.btnConfirm.HoverState.Parent = this.btnConfirm;
            this.btnConfirm.Location = new System.Drawing.Point(964, 678);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.ShadowDecoration.Parent = this.btnConfirm;
            this.btnConfirm.Size = new System.Drawing.Size(208, 43);
            this.btnConfirm.TabIndex = 95;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Location = new System.Drawing.Point(35, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(913, 684);
            this.panel1.TabIndex = 96;
            this.panel1.Visible = false;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // btnSubmit
            // 
            this.btnSubmit.CheckedState.Parent = this.btnSubmit;
            this.btnSubmit.CustomImages.Parent = this.btnSubmit;
            this.btnSubmit.DisabledState.Parent = this.btnSubmit;
            this.btnSubmit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSubmit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.HoverState.Parent = this.btnSubmit;
            this.btnSubmit.Location = new System.Drawing.Point(0, 639);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.ShadowDecoration.Parent = this.btnSubmit;
            this.btnSubmit.Size = new System.Drawing.Size(909, 41);
            this.btnSubmit.TabIndex = 97;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnDTD_Click);
            // 
            // btnSign
            // 
            this.btnSign.Animated = true;
            this.btnSign.BorderThickness = 2;
            this.btnSign.CheckedState.Parent = this.btnSign;
            this.btnSign.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnSign.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSign.CustomImages.Parent = this.btnSign;
            this.btnSign.DisabledState.Parent = this.btnSign;
            this.btnSign.FillColor = System.Drawing.Color.White;
            this.btnSign.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSign.ForeColor = System.Drawing.Color.Black;
            this.btnSign.HoverState.Parent = this.btnSign;
            this.btnSign.Location = new System.Drawing.Point(964, 605);
            this.btnSign.Name = "btnSign";
            this.btnSign.ShadowDecoration.Parent = this.btnSign;
            this.btnSign.Size = new System.Drawing.Size(208, 43);
            this.btnSign.TabIndex = 97;
            this.btnSign.Text = "Sign";
            this.btnSign.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1136, 22);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 31);
            this.guna2ControlBox1.TabIndex = 98;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // SignReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 810);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.reportViewer2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignReceipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SignReceipt";
            this.Load += new System.EventHandler(this.SignReceipt_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private Guna.UI2.WinForms.Guna2Button btnConfirm;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnSign;
        private Guna.UI2.WinForms.Guna2Button btnSubmit;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}