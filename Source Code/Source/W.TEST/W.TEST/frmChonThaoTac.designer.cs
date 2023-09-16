namespace W.TEST
{
    partial class frmChonThaoTac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChonThaoTac));
            this.btnAdmin = new DevComponents.DotNetBar.ButtonX();
            this.btnLamBaiThi = new DevComponents.DotNetBar.ButtonX();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btnAdmin
            // 
            this.btnAdmin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdmin.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Image = global::W.TEST.Properties.Resources.Admin_min_icon;
            this.btnAdmin.Location = new System.Drawing.Point(200, 166);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(197, 49);
            this.btnAdmin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAdmin.TabIndex = 3;
            this.btnAdmin.Text = "Đăng nhập Admin";
            this.btnAdmin.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnLamBaiThi
            // 
            this.btnLamBaiThi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLamBaiThi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLamBaiThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamBaiThi.Image = global::W.TEST.Properties.Resources.DVD2_copy_icon;
            this.btnLamBaiThi.Location = new System.Drawing.Point(405, 165);
            this.btnLamBaiThi.Margin = new System.Windows.Forms.Padding(4);
            this.btnLamBaiThi.Name = "btnLamBaiThi";
            this.btnLamBaiThi.Size = new System.Drawing.Size(141, 50);
            this.btnLamBaiThi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLamBaiThi.TabIndex = 4;
            this.btnLamBaiThi.Text = "Làm bài thi";
            this.btnLamBaiThi.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            this.btnLamBaiThi.Click += new System.EventHandler(this.btnLamBaiThi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(56, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(662, 51);
            this.label1.TabIndex = 5;
            this.label1.Text = "HỆ THỐNG THI TRẮC NGHIỆM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(34, 6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // frmChonThaoTac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(792, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLamBaiThi);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.flowLayoutPanel1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmChonThaoTac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn Thao Tác Chương Trình";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmChonThaoTac_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnAdmin;
        private DevComponents.DotNetBar.ButtonX btnLamBaiThi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}