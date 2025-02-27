namespace QLKD_Project.GUI
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMahd = new System.Windows.Forms.TextBox();
            this.txtMakhach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMahang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa_Click = new System.Windows.Forms.Button();
            this.brnLoad = new System.Windows.Forms.Button();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.txtNgaymua = new System.Windows.Forms.DateTimePicker();
            this.btnfill = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "txtMahd";
            // 
            // txtMahd
            // 
            this.txtMahd.Location = new System.Drawing.Point(244, 42);
            this.txtMahd.Name = "txtMahd";
            this.txtMahd.Size = new System.Drawing.Size(568, 22);
            this.txtMahd.TabIndex = 1;
            // 
            // txtMakhach
            // 
            this.txtMakhach.Location = new System.Drawing.Point(244, 70);
            this.txtMakhach.Name = "txtMakhach";
            this.txtMakhach.Size = new System.Drawing.Size(568, 22);
            this.txtMakhach.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "txtMakhach";
            // 
            // txtMahang
            // 
            this.txtMahang.Location = new System.Drawing.Point(244, 98);
            this.txtMahang.Name = "txtMahang";
            this.txtMahang.Size = new System.Drawing.Size(568, 22);
            this.txtMahang.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "txtMahang";
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(244, 154);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(568, 22);
            this.txtSoluong.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "txtSoluong";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(244, 183);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(325, 183);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa_Click
            // 
            this.btnXoa_Click.Location = new System.Drawing.Point(406, 183);
            this.btnXoa_Click.Name = "btnXoa_Click";
            this.btnXoa_Click.Size = new System.Drawing.Size(75, 23);
            this.btnXoa_Click.TabIndex = 12;
            this.btnXoa_Click.Text = "Xóa";
            this.btnXoa_Click.UseVisualStyleBackColor = true;
            this.btnXoa_Click.Click += new System.EventHandler(this.btnXoa_Click_Click);
            // 
            // brnLoad
            // 
            this.brnLoad.Location = new System.Drawing.Point(487, 183);
            this.brnLoad.Name = "brnLoad";
            this.brnLoad.Size = new System.Drawing.Size(75, 23);
            this.brnLoad.TabIndex = 13;
            this.brnLoad.Text = "Load";
            this.brnLoad.UseVisualStyleBackColor = true;
            this.brnLoad.Click += new System.EventHandler(this.brnLoad_Click);
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvHoaDon.Location = new System.Drawing.Point(0, 308);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.RowTemplate.Height = 24;
            this.dgvHoaDon.Size = new System.Drawing.Size(881, 243);
            this.dgvHoaDon.TabIndex = 14;
            // 
            // txtNgaymua
            // 
            this.txtNgaymua.Location = new System.Drawing.Point(244, 126);
            this.txtNgaymua.Name = "txtNgaymua";
            this.txtNgaymua.Size = new System.Drawing.Size(568, 22);
            this.txtNgaymua.TabIndex = 16;
            // 
            // btnfill
            // 
            this.btnfill.Location = new System.Drawing.Point(568, 183);
            this.btnfill.Name = "btnfill";
            this.btnfill.Size = new System.Drawing.Size(75, 23);
            this.btnfill.TabIndex = 17;
            this.btnfill.Text = "fill";
            this.btnfill.UseVisualStyleBackColor = true;
            this.btnfill.Click += new System.EventHandler(this.btnfill_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 551);
            this.Controls.Add(this.btnfill);
            this.Controls.Add(this.txtNgaymua);
            this.Controls.Add(this.dgvHoaDon);
            this.Controls.Add(this.brnLoad);
            this.Controls.Add(this.btnXoa_Click);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtSoluong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMahang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMakhach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMahd);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMahd;
        private System.Windows.Forms.TextBox txtMakhach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMahang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa_Click;
        private System.Windows.Forms.Button brnLoad;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.DateTimePicker txtNgaymua;
        private System.Windows.Forms.Button btnfill;
    }
}