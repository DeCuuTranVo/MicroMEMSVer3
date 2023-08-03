using MicroMEMSVer3.Entities;
using MicroMEMSVer3.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicroMEMSVer3.Forms
{
    public partial class frmTBYT : Form
    {
        private List<Tbyt> lst = new List<Tbyt>();
        private Tbyt_Service service = new Tbyt_Service();
        public frmTBYT()
        {
            InitializeComponent();

            // Interface
            this.Text = "Quan Li Thiet Bi Y Te";
            this.lblTitle.Text = "Quan Li Thiet Bi Y Te";
            this.lblTitle.Font = new Font("Arial", 20, FontStyle.Bold);
            this.WindowState = FormWindowState.Maximized;

            this.lblNhomTB.Text = "Nhom Thiet Bi";
            this.lblLoaiTB.Text = "Loai Thiet Bi";
            this.lblMaTB.Text = "Ma Thiet Bi";
            this.lblTenTB.Text = "Ten Thiet Bi";
            this.lblDvt.Text = "Don vi tinh";
            this.lblHangSX.Text = "Hang San Xuat";
            this.lblNuocSX.Text = "Nuoc San Xuat";
            this.lblNamSX.Text = "Nam San Xuat";
            this.lblGiaTri.Text = "Gia Tri";
            this.lblSoLanBaoTriMotNam.Text = "So Lan Bao Tri Mot Nam";

            // Events
            this.Load += FrmTBYT_Load;
            this.grd.CellClick += Grd_CellClick;
            this.btnClear.Click += BtnClear_Click;
            this.btnCreate.Click += BtnCreate_Click;
            this.btnUpdate.Click += BtnUpdate_Click;
            this.btnDelete.Click += BtnDelete_Click;
            this.btnSearch.Click += BtnSearch_Click;
            this.btnClearSearch.Click += BtnClearSearch_Click;
            this.btnManageTbytLk.Click += BtnManageTbytLk_Click;
        }

        private void BtnManageTbytLk_Click(object? sender, EventArgs e)
        {
            int index = grd.CurrentCell.RowIndex;
            var id = (int)grd.Rows[index].Cells["Id"].Value;

            frmTbytLk newFrmTBYT_LK = new frmTbytLk(id);
            newFrmTBYT_LK.MdiParent = this.MdiParent;
            newFrmTBYT_LK.Show();
        }

        private void BtnClearSearch_Click(object sender, EventArgs e)
        {
            this.tbxSearch.Text = "";
            PopulateGrid();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string tenTB = tbxSearch.Text;
            List<Tbyt> searchList = service.Search(tenTB);
            //MessageBox.Show(searchList.Count.ToString());
            PopulateGrid(searchList);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int index = grd.CurrentCell.RowIndex;
                var id = (int)grd.Rows[index].Cells["Id"].Value;

                Tbyt tbytToUpdate = new Tbyt();

                tbytToUpdate.Id = id;
                tbytToUpdate.NhomTb = tbxNhomTB.Text;
                tbytToUpdate.LoaiTb = tbxLoaiTB.Text;
                tbytToUpdate.MaTb = tbxMaTB.Text;
                tbytToUpdate.TenTb = tbxTenTB.Text;
                tbytToUpdate.Dvt = tbxDvt.Text;

                tbytToUpdate.HangSx = tbxHangSX.Text;
                tbytToUpdate.NuocSx = tbxNuocSX.Text;
                tbytToUpdate.NamSx = Convert.ToInt32(tbxNamSX.Text);
                tbytToUpdate.GiaTri = Convert.ToInt32(tbxGiaTri.Text);
                tbytToUpdate.SoLanBaoTriMotNam = Convert.ToInt32(tbxSoLanBaoTriMotNam.Text);

                service.Update(tbytToUpdate);

                PopulateGrid();
                ClearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int index = grd.CurrentCell.RowIndex;
                var id = (int)grd.Rows[index].Cells["Id"].Value;

                DialogResult dr = MessageBox.Show("Are you sure you want to delete this record?",
                        "Delete",
                        MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    service.Delete(id);
                }
                PopulateGrid();
                ClearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                Tbyt newTBYT = new Tbyt();
                newTBYT.NhomTb = tbxNhomTB.Text;
                newTBYT.LoaiTb = tbxLoaiTB.Text;
                newTBYT.MaTb = tbxMaTB.Text;
                newTBYT.TenTb = tbxTenTB.Text;
                newTBYT.Dvt = tbxDvt.Text;
                newTBYT.HangSx = tbxHangSX.Text;
                newTBYT.NuocSx = tbxNuocSX.Text;
                newTBYT.NamSx = Convert.ToInt32(tbxNamSX.Text);
                newTBYT.GiaTri = Convert.ToInt32(tbxGiaTri.Text);
                newTBYT.SoLanBaoTriMotNam = Convert.ToInt32(tbxSoLanBaoTriMotNam.Text);

                service.AddNew(newTBYT);
                PopulateGrid();
                ClearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        public void PopulateGrid()
        {
            var lst = service.GetAll();

            var displayList = lst.Select(
                x => new
                {
                    x.Id,
                    x.NhomTb,
                    x.LoaiTb,
                    x.MaTb,
                    x.TenTb,
                    x.Dvt,
                    x.HangSx,
                    x.NuocSx,
                    x.NamSx,
                    x.GiaTri,
                    x.SoLanBaoTriMotNam
                }).ToList();


            grd.AutoGenerateColumns = true;
            //grd.DataSource = lst;
            grd.DataSource = displayList;

            grd.Columns["NhomTB"].HeaderText = "Nhom Thiet Bi";
            grd.Columns["LoaiTB"].HeaderText = "Loai Thiet Bi";
            grd.Columns["MaTB"].HeaderText = "Ma Thiet Bi";
            grd.Columns["TenTB"].HeaderText = "Ten Thiet Bi";
            grd.Columns["Dvt"].HeaderText = "Đơn vị tính";
            grd.Columns["HangSX"].HeaderText = "Hãng Sản Xuất";
            grd.Columns["NuocSX"].HeaderText = "Nước Sản Xuất";
            grd.Columns["NamSX"].HeaderText = "Năm Sản Xuất";
            grd.Columns["GiaTri"].HeaderText = "Giá Trị";
            grd.Columns["SoLanBaoTriMotNam"].HeaderText = "Số Lần Bảo Trì Một Năm";

            grd.Columns["Id"].Visible = false;
            grd.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            grd.DefaultCellStyle.Font = new Font("Arial", 8, FontStyle.Regular);

            grd.Columns["SoLanBaoTriMotNam"].Width = 150;
        }

        public void PopulateGrid(List<Tbyt> tbytList)
        {
            var displayList = tbytList.Select(
                x => new
                {
                    x.Id,
                    x.NhomTb,
                    x.LoaiTb,
                    x.MaTb,
                    x.TenTb,
                    x.Dvt,
                    x.HangSx,
                    x.NuocSx,
                    x.NamSx,
                    x.GiaTri,
                    x.SoLanBaoTriMotNam
                }).ToList();


            grd.AutoGenerateColumns = true;
            //grd.DataSource = lst;
            grd.DataSource = displayList;

            grd.Columns["NhomTB"].HeaderText = "Nhom Thiet Bi";
            grd.Columns["LoaiTB"].HeaderText = "Loai Thiet Bi";
            grd.Columns["MaTB"].HeaderText = "Ma Thiet Bi";
            grd.Columns["TenTB"].HeaderText = "Ten Thiet Bi";
            grd.Columns["Dvt"].HeaderText = "Đơn vị tính";
            grd.Columns["HangSX"].HeaderText = "Hãng Sản Xuất";
            grd.Columns["NuocSX"].HeaderText = "Nước Sản Xuất";
            grd.Columns["NamSX"].HeaderText = "Năm Sản Xuất";
            grd.Columns["GiaTri"].HeaderText = "Giá Trị";
            grd.Columns["SoLanBaoTriMotNam"].HeaderText = "Số Lần Bảo Trì Một Năm";

            grd.Columns["Id"].Visible = false;
            grd.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            grd.DefaultCellStyle.Font = new Font("Arial", 8, FontStyle.Regular);

            grd.Columns["SoLanBaoTriMotNam"].Width = 150;
        }
        public void ClearTextBoxes()
        {
            tbxNhomTB.Text = "";
            tbxLoaiTB.Text = "";
            tbxMaTB.Text = "";
            tbxTenTB.Text = "";
            tbxDvt.Text = "";

            tbxHangSX.Text = "";
            tbxNuocSX.Text = "";
            tbxNamSX.Text = "";
            tbxGiaTri.Text = "";
            tbxSoLanBaoTriMotNam.Text = "";
        }



        private void Grd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int nId = (int)grd.Rows[e.RowIndex].Cells[0].Value;

            DataGridViewRow row = grd.Rows[e.RowIndex];
            tbxNhomTB.Text = row.Cells["NhomTB"].Value.ToString();
            tbxLoaiTB.Text = row.Cells["LoaiTB"].Value.ToString();
            tbxMaTB.Text = row.Cells["MaTB"].Value.ToString();
            tbxTenTB.Text = row.Cells["TenTB"].Value.ToString();
            tbxDvt.Text = row.Cells["Dvt"].Value.ToString();

            tbxHangSX.Text = row.Cells["HangSX"].Value.ToString();
            tbxNuocSX.Text = row.Cells["NuocSX"].Value.ToString();
            tbxNamSX.Text = row.Cells["NamSX"].Value.ToString();
            tbxGiaTri.Text = row.Cells["GiaTri"].Value.ToString();
            tbxSoLanBaoTriMotNam.Text = row.Cells["SoLanBaoTriMotNam"].Value.ToString();
        }

        private void FrmTBYT_Load(object sender, EventArgs e)
        {
            PopulateGrid();
            ClearTextBoxes();
        }
    }
}
