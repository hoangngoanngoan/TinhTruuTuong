namespace TinhTruuTuong
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtHoTen = new TextBox();
            txtDiemC = new TextBox();
            txtDiemSQL = new TextBox();
            txtDiemOOP = new TextBox();
            txtDiemTB = new TextBox();
            dgvSinhVienIT = new DataGridView();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVienIT).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(822, 69);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSua);
            panel2.Controls.Add(btnXoa);
            panel2.Controls.Add(btnThem);
            panel2.Controls.Add(dgvSinhVienIT);
            panel2.Controls.Add(txtDiemTB);
            panel2.Controls.Add(txtDiemOOP);
            panel2.Controls.Add(txtDiemSQL);
            panel2.Controls.Add(txtDiemC);
            panel2.Controls.Add(txtHoTen);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(0, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(408, 572);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Location = new Point(414, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(408, 374);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(414, 75);
            panel4.Name = "panel4";
            panel4.Size = new Size(408, 572);
            panel4.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Location = new Point(414, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(408, 374);
            panel5.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(201, 18);
            label1.Name = "label1";
            label1.Size = new Size(424, 37);
            label1.TabIndex = 2;
            label1.Text = "Chương trình quản lý sinh viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(120, 15);
            label2.Name = "label2";
            label2.Size = new Size(121, 25);
            label2.TabIndex = 2;
            label2.Text = "Sinh viên IT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(80, 60);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 2;
            label3.Text = "Họ tên:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(80, 15);
            label4.Name = "label4";
            label4.Size = new Size(273, 25);
            label4.TabIndex = 2;
            label4.Text = "Sinh viên sân khấu điện ảnh";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(70, 90);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 2;
            label5.Text = "Điểm C#:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(64, 120);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 2;
            label6.Text = "Điểm SQL:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(60, 150);
            label7.Name = "label7";
            label7.Size = new Size(66, 15);
            label7.TabIndex = 2;
            label7.Text = "Điểm OOP:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(29, 180);
            label8.Name = "label8";
            label8.Size = new Size(97, 15);
            label8.TabIndex = 2;
            label8.Text = "Điểm trung bình:";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(141, 50);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(139, 23);
            txtHoTen.TabIndex = 3;
            // 
            // txtDiemC
            // 
            txtDiemC.Location = new Point(141, 80);
            txtDiemC.Name = "txtDiemC";
            txtDiemC.Size = new Size(139, 23);
            txtDiemC.TabIndex = 3;
            // 
            // txtDiemSQL
            // 
            txtDiemSQL.Location = new Point(141, 110);
            txtDiemSQL.Name = "txtDiemSQL";
            txtDiemSQL.Size = new Size(139, 23);
            txtDiemSQL.TabIndex = 3;
            // 
            // txtDiemOOP
            // 
            txtDiemOOP.Location = new Point(141, 140);
            txtDiemOOP.Name = "txtDiemOOP";
            txtDiemOOP.Size = new Size(139, 23);
            txtDiemOOP.TabIndex = 3;
            // 
            // txtDiemTB
            // 
            txtDiemTB.Location = new Point(141, 170);
            txtDiemTB.Name = "txtDiemTB";
            txtDiemTB.Size = new Size(139, 23);
            txtDiemTB.TabIndex = 3;
            // 
            // dgvSinhVienIT
            // 
            dgvSinhVienIT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSinhVienIT.Location = new Point(0, 260);
            dgvSinhVienIT.Name = "dgvSinhVienIT";
            dgvSinhVienIT.Size = new Size(408, 315);
            dgvSinhVienIT.TabIndex = 4;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(64, 215);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 5;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(145, 215);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(226, 215);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 5;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 651);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVienIT).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Label label3;
        private Label label2;
        private Panel panel4;
        private Panel panel5;
        private Label label4;
        private DataGridView dgvSinhVienIT;
        private TextBox txtDiemTB;
        private TextBox txtDiemOOP;
        private TextBox txtDiemSQL;
        private TextBox txtDiemC;
        private TextBox txtHoTen;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
    }
}
