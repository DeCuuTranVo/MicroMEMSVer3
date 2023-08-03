namespace MicroMEMSVer3.Forms
{
    partial class frmTBYT
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
            grd = new DataGridView();
            lblTitle = new Label();
            lblTenTB = new Label();
            lblMaTB = new Label();
            lblNhomTB = new Label();
            lblLoaiTB = new Label();
            lblDvt = new Label();
            lblHangSX = new Label();
            lblNuocSX = new Label();
            lblNamSX = new Label();
            lblGiaTri = new Label();
            lblSoLanBaoTriMotNam = new Label();
            tbxNhomTB = new TextBox();
            tbxLoaiTB = new TextBox();
            tbxMaTB = new TextBox();
            tbxTenTB = new TextBox();
            tbxDvt = new TextBox();
            tbxHangSX = new TextBox();
            tbxNuocSX = new TextBox();
            tbxNamSX = new TextBox();
            tbxGiaTri = new TextBox();
            tbxSoLanBaoTriMotNam = new TextBox();
            btnCreate = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnClear = new Button();
            tbxSearch = new TextBox();
            btnSearch = new Button();
            btnClearSearch = new Button();
            btnManageTbytLk = new Button();
            ((System.ComponentModel.ISupportInitialize)grd).BeginInit();
            SuspendLayout();
            // 
            // grd
            // 
            grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd.Location = new Point(19, 178);
            grd.Margin = new Padding(4, 3, 4, 3);
            grd.Name = "grd";
            grd.Size = new Size(1539, 447);
            grd.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(15, 15);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(0, 15);
            lblTitle.TabIndex = 1;
            // 
            // lblTenTB
            // 
            lblTenTB.AutoSize = true;
            lblTenTB.Location = new Point(716, 107);
            lblTenTB.Margin = new Padding(4, 0, 4, 0);
            lblTenTB.Name = "lblTenTB";
            lblTenTB.Size = new Size(67, 15);
            lblTenTB.TabIndex = 2;
            lblTenTB.Text = "Ten Thiet Bi";
            // 
            // lblMaTB
            // 
            lblMaTB.AutoSize = true;
            lblMaTB.Location = new Point(507, 107);
            lblMaTB.Margin = new Padding(4, 0, 4, 0);
            lblMaTB.Name = "lblMaTB";
            lblMaTB.Size = new Size(66, 15);
            lblMaTB.TabIndex = 2;
            lblMaTB.Text = "Ma Thiet Bi";
            // 
            // lblNhomTB
            // 
            lblNhomTB.AutoSize = true;
            lblNhomTB.Location = new Point(15, 110);
            lblNhomTB.Margin = new Padding(4, 0, 4, 0);
            lblNhomTB.Name = "lblNhomTB";
            lblNhomTB.Size = new Size(83, 15);
            lblNhomTB.TabIndex = 2;
            lblNhomTB.Text = "Nhom Thiet Bi";
            // 
            // lblLoaiTB
            // 
            lblLoaiTB.AutoSize = true;
            lblLoaiTB.Location = new Point(275, 110);
            lblLoaiTB.Margin = new Padding(4, 0, 4, 0);
            lblLoaiTB.Name = "lblLoaiTB";
            lblLoaiTB.Size = new Size(71, 15);
            lblLoaiTB.TabIndex = 2;
            lblLoaiTB.Text = "Loai Thiet Bi";
            // 
            // lblDvt
            // 
            lblDvt.AutoSize = true;
            lblDvt.Location = new Point(984, 107);
            lblDvt.Margin = new Padding(4, 0, 4, 0);
            lblDvt.Name = "lblDvt";
            lblDvt.Size = new Size(65, 15);
            lblDvt.TabIndex = 2;
            lblDvt.Text = "Don vi tinh";
            // 
            // lblHangSX
            // 
            lblHangSX.AutoSize = true;
            lblHangSX.Location = new Point(15, 137);
            lblHangSX.Margin = new Padding(4, 0, 4, 0);
            lblHangSX.Name = "lblHangSX";
            lblHangSX.Size = new Size(85, 15);
            lblHangSX.TabIndex = 2;
            lblHangSX.Text = "Hang San Xuat";
            // 
            // lblNuocSX
            // 
            lblNuocSX.AutoSize = true;
            lblNuocSX.Location = new Point(275, 137);
            lblNuocSX.Margin = new Padding(4, 0, 4, 0);
            lblNuocSX.Name = "lblNuocSX";
            lblNuocSX.Size = new Size(85, 15);
            lblNuocSX.TabIndex = 2;
            lblNuocSX.Text = "Nuoc San Xuat";
            // 
            // lblNamSX
            // 
            lblNamSX.AutoSize = true;
            lblNamSX.Location = new Point(507, 137);
            lblNamSX.Margin = new Padding(4, 0, 4, 0);
            lblNamSX.Name = "lblNamSX";
            lblNamSX.Size = new Size(82, 15);
            lblNamSX.TabIndex = 2;
            lblNamSX.Text = "Nam San Xuat";
            // 
            // lblGiaTri
            // 
            lblGiaTri.AutoSize = true;
            lblGiaTri.Location = new Point(716, 137);
            lblGiaTri.Margin = new Padding(4, 0, 4, 0);
            lblGiaTri.Name = "lblGiaTri";
            lblGiaTri.Size = new Size(39, 15);
            lblGiaTri.TabIndex = 2;
            lblGiaTri.Text = "Gia Tri";
            // 
            // lblSoLanBaoTriMotNam
            // 
            lblSoLanBaoTriMotNam.AutoSize = true;
            lblSoLanBaoTriMotNam.Location = new Point(984, 137);
            lblSoLanBaoTriMotNam.Margin = new Padding(4, 0, 4, 0);
            lblSoLanBaoTriMotNam.Name = "lblSoLanBaoTriMotNam";
            lblSoLanBaoTriMotNam.Size = new Size(134, 15);
            lblSoLanBaoTriMotNam.TabIndex = 2;
            lblSoLanBaoTriMotNam.Text = "So Lan Bao Tri Mot Nam";
            // 
            // tbxNhomTB
            // 
            tbxNhomTB.Location = new Point(107, 104);
            tbxNhomTB.Margin = new Padding(4, 3, 4, 3);
            tbxNhomTB.Name = "tbxNhomTB";
            tbxNhomTB.Size = new Size(160, 23);
            tbxNhomTB.TabIndex = 3;
            // 
            // tbxLoaiTB
            // 
            tbxLoaiTB.Location = new Point(368, 104);
            tbxLoaiTB.Margin = new Padding(4, 3, 4, 3);
            tbxLoaiTB.Name = "tbxLoaiTB";
            tbxLoaiTB.Size = new Size(131, 23);
            tbxLoaiTB.TabIndex = 3;
            // 
            // tbxMaTB
            // 
            tbxMaTB.Location = new Point(593, 102);
            tbxMaTB.Margin = new Padding(4, 3, 4, 3);
            tbxMaTB.Name = "tbxMaTB";
            tbxMaTB.Size = new Size(115, 23);
            tbxMaTB.TabIndex = 3;
            // 
            // tbxTenTB
            // 
            tbxTenTB.Location = new Point(791, 102);
            tbxTenTB.Margin = new Padding(4, 3, 4, 3);
            tbxTenTB.Name = "tbxTenTB";
            tbxTenTB.Size = new Size(185, 23);
            tbxTenTB.TabIndex = 3;
            // 
            // tbxDvt
            // 
            tbxDvt.Location = new Point(1124, 99);
            tbxDvt.Margin = new Padding(4, 3, 4, 3);
            tbxDvt.Name = "tbxDvt";
            tbxDvt.Size = new Size(112, 23);
            tbxDvt.TabIndex = 3;
            // 
            // tbxHangSX
            // 
            tbxHangSX.Location = new Point(107, 134);
            tbxHangSX.Margin = new Padding(4, 3, 4, 3);
            tbxHangSX.Name = "tbxHangSX";
            tbxHangSX.Size = new Size(160, 23);
            tbxHangSX.TabIndex = 3;
            // 
            // tbxNuocSX
            // 
            tbxNuocSX.Location = new Point(368, 134);
            tbxNuocSX.Margin = new Padding(4, 3, 4, 3);
            tbxNuocSX.Name = "tbxNuocSX";
            tbxNuocSX.Size = new Size(131, 23);
            tbxNuocSX.TabIndex = 3;
            // 
            // tbxNamSX
            // 
            tbxNamSX.Location = new Point(593, 134);
            tbxNamSX.Margin = new Padding(4, 3, 4, 3);
            tbxNamSX.Name = "tbxNamSX";
            tbxNamSX.Size = new Size(115, 23);
            tbxNamSX.TabIndex = 3;
            // 
            // tbxGiaTri
            // 
            tbxGiaTri.Location = new Point(791, 134);
            tbxGiaTri.Margin = new Padding(4, 3, 4, 3);
            tbxGiaTri.Name = "tbxGiaTri";
            tbxGiaTri.Size = new Size(185, 23);
            tbxGiaTri.TabIndex = 3;
            // 
            // tbxSoLanBaoTriMotNam
            // 
            tbxSoLanBaoTriMotNam.Location = new Point(1124, 134);
            tbxSoLanBaoTriMotNam.Margin = new Padding(4, 3, 4, 3);
            tbxSoLanBaoTriMotNam.Name = "tbxSoLanBaoTriMotNam";
            tbxSoLanBaoTriMotNam.Size = new Size(112, 23);
            tbxSoLanBaoTriMotNam.TabIndex = 3;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(1259, 71);
            btnCreate.Margin = new Padding(4, 3, 4, 3);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(98, 27);
            btnCreate.TabIndex = 4;
            btnCreate.Text = "Them";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1259, 137);
            btnDelete.Margin = new Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(98, 29);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Xoa";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(1259, 104);
            btnUpdate.Margin = new Padding(4, 3, 4, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(98, 27);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Sua";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(1259, 37);
            btnClear.Margin = new Padding(4, 3, 4, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(98, 27);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // tbxSearch
            // 
            tbxSearch.Location = new Point(19, 73);
            tbxSearch.Margin = new Padding(4, 3, 4, 3);
            tbxSearch.Name = "tbxSearch";
            tbxSearch.Size = new Size(249, 23);
            tbxSearch.TabIndex = 7;
            tbxSearch.Text = "Nhap Ten Thiet Bi ...";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(295, 69);
            btnSearch.Margin = new Padding(4, 3, 4, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(88, 27);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Tim kiem";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnClearSearch
            // 
            btnClearSearch.Location = new Point(411, 70);
            btnClearSearch.Margin = new Padding(4, 3, 4, 3);
            btnClearSearch.Name = "btnClearSearch";
            btnClearSearch.Size = new Size(112, 27);
            btnClearSearch.TabIndex = 8;
            btnClearSearch.Text = "Clear Tim Kiem";
            btnClearSearch.UseVisualStyleBackColor = true;
            // 
            // btnManageTbytLk
            // 
            btnManageTbytLk.Location = new Point(1064, 69);
            btnManageTbytLk.Name = "btnManageTbytLk";
            btnManageTbytLk.Size = new Size(158, 23);
            btnManageTbytLk.TabIndex = 9;
            btnManageTbytLk.Text = "Xem Linh Kiện";
            btnManageTbytLk.UseVisualStyleBackColor = true;
            // 
            // frmTBYT
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 683);
            Controls.Add(btnManageTbytLk);
            Controls.Add(btnClearSearch);
            Controls.Add(btnSearch);
            Controls.Add(tbxSearch);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(tbxDvt);
            Controls.Add(tbxTenTB);
            Controls.Add(tbxMaTB);
            Controls.Add(tbxLoaiTB);
            Controls.Add(tbxSoLanBaoTriMotNam);
            Controls.Add(tbxGiaTri);
            Controls.Add(tbxNamSX);
            Controls.Add(tbxNuocSX);
            Controls.Add(tbxHangSX);
            Controls.Add(tbxNhomTB);
            Controls.Add(lblSoLanBaoTriMotNam);
            Controls.Add(lblGiaTri);
            Controls.Add(lblNamSX);
            Controls.Add(lblNuocSX);
            Controls.Add(lblHangSX);
            Controls.Add(lblDvt);
            Controls.Add(lblLoaiTB);
            Controls.Add(lblNhomTB);
            Controls.Add(lblMaTB);
            Controls.Add(lblTenTB);
            Controls.Add(lblTitle);
            Controls.Add(grd);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmTBYT";
            Text = "frmTBYT";
            ((System.ComponentModel.ISupportInitialize)grd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grd;
        private Label lblTitle;
        private Label lblTenTB;
        private Label lblMaTB;
        private Label lblNhomTB;
        private Label lblLoaiTB;
        private Label lblDvt;
        private Label lblHangSX;
        private Label lblNuocSX;
        private Label lblNamSX;
        private Label lblGiaTri;
        private Label lblSoLanBaoTriMotNam;
        private TextBox tbxNhomTB;
        private TextBox tbxLoaiTB;
        private TextBox tbxMaTB;
        private TextBox tbxTenTB;
        private TextBox tbxDvt;
        private TextBox tbxHangSX;
        private TextBox tbxNuocSX;
        private TextBox tbxNamSX;
        private TextBox tbxGiaTri;
        private TextBox tbxSoLanBaoTriMotNam;
        private Button btnCreate;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnClear;
        private TextBox tbxSearch;
        private Button btnSearch;
        private Button btnClearSearch;
        private Button btnManageTbytLk;
    }
}