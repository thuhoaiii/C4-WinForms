namespace BTC4_WinForms
{
    partial class Form2
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
            this.txtN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDayso = new System.Windows.Forms.Label();
            this.lbTong = new System.Windows.Forms.Label();
            this.lbSapxep = new System.Windows.Forms.Label();
            this.btnNhap = new System.Windows.Forms.Button();
            this.btnTong = new System.Windows.Forms.Button();
            this.btnSapxep = new System.Windows.Forms.Button();
            this.btnLamlai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(271, 77);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 31);
            this.txtN.TabIndex = 0;
            this.txtN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtN_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập n =";
            // 
            // lbDayso
            // 
            this.lbDayso.AutoSize = true;
            this.lbDayso.Location = new System.Drawing.Point(149, 163);
            this.lbDayso.Name = "lbDayso";
            this.lbDayso.Size = new System.Drawing.Size(91, 25);
            this.lbDayso.TabIndex = 2;
            this.lbDayso.Text = "Dãy số: ";
            // 
            // lbTong
            // 
            this.lbTong.AutoSize = true;
            this.lbTong.Location = new System.Drawing.Point(149, 209);
            this.lbTong.Name = "lbTong";
            this.lbTong.Size = new System.Drawing.Size(143, 25);
            this.lbTong.TabIndex = 3;
            this.lbTong.Text = "Tổng dãy số: ";
            // 
            // lbSapxep
            // 
            this.lbSapxep.AutoSize = true;
            this.lbSapxep.Location = new System.Drawing.Point(149, 252);
            this.lbSapxep.Name = "lbSapxep";
            this.lbSapxep.Size = new System.Drawing.Size(103, 25);
            this.lbSapxep.TabIndex = 4;
            this.lbSapxep.Text = "Sắp xếp: ";
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(40, 358);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(85, 45);
            this.btnNhap.TabIndex = 5;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(136, 358);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(142, 45);
            this.btnTong.TabIndex = 6;
            this.btnTong.Text = "Tính tổng";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // btnSapxep
            // 
            this.btnSapxep.Location = new System.Drawing.Point(296, 358);
            this.btnSapxep.Name = "btnSapxep";
            this.btnSapxep.Size = new System.Drawing.Size(129, 45);
            this.btnSapxep.TabIndex = 7;
            this.btnSapxep.Text = "Sắp xếp";
            this.btnSapxep.UseVisualStyleBackColor = true;
            this.btnSapxep.Click += new System.EventHandler(this.btnSapxep_Click);
            // 
            // btnLamlai
            // 
            this.btnLamlai.Location = new System.Drawing.Point(454, 358);
            this.btnLamlai.Name = "btnLamlai";
            this.btnLamlai.Size = new System.Drawing.Size(141, 45);
            this.btnLamlai.TabIndex = 8;
            this.btnLamlai.Text = "Làm lại";
            this.btnLamlai.UseVisualStyleBackColor = true;
            this.btnLamlai.Click += new System.EventHandler(this.btnLamlai_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(622, 358);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(110, 45);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLamlai);
            this.Controls.Add(this.btnSapxep);
            this.Controls.Add(this.btnTong);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.lbSapxep);
            this.Controls.Add(this.lbTong);
            this.Controls.Add(this.lbDayso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtN);
            this.Name = "Form2";
            this.Text = "Day so";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDayso;
        private System.Windows.Forms.Label lbTong;
        private System.Windows.Forms.Label lbSapxep;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.Button btnSapxep;
        private System.Windows.Forms.Button btnLamlai;
        private System.Windows.Forms.Button btnThoat;
    }
}