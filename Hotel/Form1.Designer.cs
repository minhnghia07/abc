namespace Hotel
{
    partial class Form1
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.MaPhong = new System.Windows.Forms.Label();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.TenPhong = new System.Windows.Forms.Label();
            this.Gia = new System.Windows.Forms.Label();
            this.MaKhachHang = new System.Windows.Forms.Label();
            this.cbxTinhTrang = new System.Windows.Forms.ComboBox();
            this.cbxLoaiPhong = new System.Windows.Forms.ComboBox();
            this.tblHotel = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.dtCheckIn = new System.Windows.Forms.DateTimePicker();
            this.dtCheckOut = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblHotel)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(188, 29);
            this.txtMaPhong.Multiline = true;
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(374, 30);
            this.txtMaPhong.TabIndex = 1;
            // 
            // MaPhong
            // 
            this.MaPhong.AutoSize = true;
            this.MaPhong.Location = new System.Drawing.Point(55, 42);
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.Size = new System.Drawing.Size(72, 17);
            this.MaPhong.TabIndex = 6;
            this.MaPhong.Text = "Ma Phong";
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.Location = new System.Drawing.Point(188, 86);
            this.txtMaKhachHang.Multiline = true;
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(374, 30);
            this.txtMaKhachHang.TabIndex = 8;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(188, 190);
            this.txtGia.Multiline = true;
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(374, 30);
            this.txtGia.TabIndex = 9;
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Location = new System.Drawing.Point(188, 137);
            this.txtTenPhong.Multiline = true;
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(374, 30);
            this.txtTenPhong.TabIndex = 10;
            // 
            // TenPhong
            // 
            this.TenPhong.AutoSize = true;
            this.TenPhong.Location = new System.Drawing.Point(55, 140);
            this.TenPhong.Name = "TenPhong";
            this.TenPhong.Size = new System.Drawing.Size(78, 17);
            this.TenPhong.TabIndex = 11;
            this.TenPhong.Text = "Ten Phong";
            // 
            // Gia
            // 
            this.Gia.AutoSize = true;
            this.Gia.Location = new System.Drawing.Point(65, 190);
            this.Gia.Name = "Gia";
            this.Gia.Size = new System.Drawing.Size(30, 17);
            this.Gia.TabIndex = 12;
            this.Gia.Text = "Gia";
            // 
            // MaKhachHang
            // 
            this.MaKhachHang.AutoSize = true;
            this.MaKhachHang.Location = new System.Drawing.Point(55, 86);
            this.MaKhachHang.Name = "MaKhachHang";
            this.MaKhachHang.Size = new System.Drawing.Size(107, 17);
            this.MaKhachHang.TabIndex = 13;
            this.MaKhachHang.Text = "Ma Khach hang";
            // 
            // cbxTinhTrang
            // 
            this.cbxTinhTrang.FormattingEnabled = true;
            this.cbxTinhTrang.Items.AddRange(new object[] {
            "Con ",
            "Het"});
            this.cbxTinhTrang.Location = new System.Drawing.Point(739, 143);
            this.cbxTinhTrang.Name = "cbxTinhTrang";
            this.cbxTinhTrang.Size = new System.Drawing.Size(121, 24);
            this.cbxTinhTrang.TabIndex = 14;
            this.cbxTinhTrang.Text = "Tinh Trang";
            // 
            // cbxLoaiPhong
            // 
            this.cbxLoaiPhong.FormattingEnabled = true;
            this.cbxLoaiPhong.Items.AddRange(new object[] {
            "VIP",
            "Thuong"});
            this.cbxLoaiPhong.Location = new System.Drawing.Point(739, 196);
            this.cbxLoaiPhong.Name = "cbxLoaiPhong";
            this.cbxLoaiPhong.Size = new System.Drawing.Size(121, 24);
            this.cbxLoaiPhong.TabIndex = 15;
            this.cbxLoaiPhong.Text = "LoaiPhong";
            // 
            // tblHotel
            // 
            this.tblHotel.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tblHotel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblHotel.Location = new System.Drawing.Point(188, 339);
            this.tblHotel.Name = "tblHotel";
            this.tblHotel.RowHeadersWidth = 51;
            this.tblHotel.RowTemplate.Height = 24;
            this.tblHotel.Size = new System.Drawing.Size(751, 210);
            this.tblHotel.TabIndex = 16;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(188, 279);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Them";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(315, 279);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.Text = "Sua";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(441, 279);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Xoa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(739, 279);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 20;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(574, 279);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 21;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // dtCheckIn
            // 
            this.dtCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCheckIn.Location = new System.Drawing.Point(739, 27);
            this.dtCheckIn.Name = "dtCheckIn";
            this.dtCheckIn.Size = new System.Drawing.Size(200, 22);
            this.dtCheckIn.TabIndex = 22;
            // 
            // dtCheckOut
            // 
            this.dtCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCheckOut.Location = new System.Drawing.Point(739, 86);
            this.dtCheckOut.Name = "dtCheckOut";
            this.dtCheckOut.Size = new System.Drawing.Size(200, 22);
            this.dtCheckOut.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(632, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "CheckIn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(632, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "CheckOut";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 704);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtCheckOut);
            this.Controls.Add(this.dtCheckIn);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tblHotel);
            this.Controls.Add(this.cbxLoaiPhong);
            this.Controls.Add(this.cbxTinhTrang);
            this.Controls.Add(this.MaKhachHang);
            this.Controls.Add(this.Gia);
            this.Controls.Add(this.TenPhong);
            this.Controls.Add(this.txtTenPhong);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtMaKhachHang);
            this.Controls.Add(this.MaPhong);
            this.Controls.Add(this.txtMaPhong);
            this.Name = "Form1";
            this.Text = "HotelManager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblHotel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.Label MaPhong;
        private System.Windows.Forms.TextBox txtMaKhachHang;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.Label TenPhong;
        private System.Windows.Forms.Label Gia;
        private System.Windows.Forms.Label MaKhachHang;
        private System.Windows.Forms.ComboBox cbxTinhTrang;
        private System.Windows.Forms.ComboBox cbxLoaiPhong;
        private System.Windows.Forms.DataGridView tblHotel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.DateTimePicker dtCheckIn;
        private System.Windows.Forms.DateTimePicker dtCheckOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

