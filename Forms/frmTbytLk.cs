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

    public partial class frmTbytLk : Form
    {
        //private List<TBYT_LK> lst = new List<TBYT_LK>();

        private Tbyt_Service TBYT_service = new Tbyt_Service();
        private TbytLk_Service TBYT_LK_service = new TbytLk_Service();
        public int tbytParentId;
        public Tbyt tbytParent;
        public frmTbytLk(int tbytParentId)
        {
            InitializeComponent();
            this.tbytParentId = tbytParentId;
            this.tbytParent = TBYT_service.GetOne(tbytParentId);

            // Interface
            this.lblTitle.Text = $"Quản Lí Linh Kiện Thiết Bị Y Tế {tbytParent.TenTb} - {tbytParent.MaTb}";

            this.lblTB.Visible = false;
            this.cbxTB.Visible = false;
            this.cbxTB.Enabled = false;

            LoadWidgetsAndEvents();
        }

        public frmTbytLk()
        {
            InitializeComponent();
            this.tbytParentId = -1;
            this.tbytParent = null;

            // Interface
            this.lblTitle.Text = "Quản Lí Linh Kiện Thiết Bị Y Tế";

            this.lblTB.Visible = true;
            this.cbxTB.Visible = true;

            var lstTBYT = TBYT_service.GetAll();
            //var lst = TBYT_LK_service.GetAll();
            
            var displayListTBYT = lstTBYT.Select(
                x => new {
                    IdTbytCbx = x.Id,
                    NameTB = x.TenTb + " " + x.MaTb
                }).ToList();

            this.cbxTB.Enabled = true;
            this.cbxTB.DataSource = displayListTBYT;
            this.cbxTB.DisplayMember = "NameTB";
            this.cbxTB.ValueMember = "IdTbytCbx";
            this.cbxTB.SelectedIndex = -1;

            LoadWidgetsAndEvents();
        }

        private void LoadWidgetsAndEvents()
        {
            // Widgets
            this.Text = "Quản Lí Linh Kiện Thiết Bị Y Tế";
            this.lblTitle.Font = new Font("Arial", 12, FontStyle.Bold);
            this.WindowState = FormWindowState.Maximized;

            this.lblMaLK.Text = "Mã Linh Kiện";
            this.lblTenLK.Text = "Tên Linh Kiện";
            this.lblDvt.Text = "Đơn vị tính";
            this.lblSoLuong.Text = "Số Lượng";
            this.lblTB.Text = "Thiết Bị";

            // Events
            this.Load += FrmTBYT_LK_Load;
            this.btnRefresh.Click += BtnRefresh_Click;
            this.btnCreate.Click += BtnCreate_Click;
            this.btnUpdate.Click += BtnUpdate_Click;
            this.btnDelete.Click += BtnDelete_Click;
            this.btnSearch.Click += BtnSearch_Click;
            this.btnClearSearch.Click += BtnClearSearch_Click;
            this.grd.CellClick += Grd_CellClick;
        }

        private void BtnClearSearch_Click(object? sender, EventArgs e)
        {
            this.tbxSearch.Text = "";

            if (this.tbytParent != null)
            {
                PopulateGrid(this.tbytParentId);
            }
            else
            {
                PopulateGrid();
            }
        }

        private void BtnSearch_Click(object? sender, EventArgs e)
        {
            string tenLK = tbxSearch.Text;
            if (tbytParent != null)
            {
                List<TbytLk> searchList = TBYT_LK_service.SearchWithTbytId(tenLK, tbytParentId);
                PopulateGrid(searchList);
            }
            else
            {
                var searchList = TBYT_LK_service.Search(tenLK);
                PopulateGrid(searchList);
            }
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
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
                    TBYT_LK_service.Delete(id);
                }

                if (this.tbytParent != null)
                {
                    PopulateGrid(this.tbytParentId);
                }
                else
                {
                    PopulateGrid();
                }
                ClearTextBoxesAndComboBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void BtnUpdate_Click(object? sender, EventArgs e)
        {
            try
            {
                int index = grd.CurrentCell.RowIndex;
                var id = (int)grd.Rows[index].Cells["Id"].Value;

                TbytLk tbytLkToUpdate = new TbytLk();
                tbytLkToUpdate.Id = id;
                tbytLkToUpdate.MaLk = tbxMaLK.Text;
                tbytLkToUpdate.TenLk = tbxTenLK.Text;
                tbytLkToUpdate.Dvt = tbxDvt.Text;
                tbytLkToUpdate.SoLuong = Convert.ToInt32(tbxSoLuong.Text);

                if (this.tbytParent != null)
                {
                    tbytLkToUpdate.Tbytid = tbytParentId;
                }
                else
                {
                    tbytLkToUpdate.Tbytid = Convert.ToInt32(cbxTB.SelectedValue);
                }

                TBYT_LK_service.Update(tbytLkToUpdate);

                if (this.tbytParent != null)
                {
                    PopulateGrid(this.tbytParentId);
                } else
                {
                    PopulateGrid();
                }
                
                ClearTextBoxesAndComboBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void BtnCreate_Click(object? sender, EventArgs e)
        {            
            try
            {
                TbytLk newTbytLk = new TbytLk();
                newTbytLk.MaLk = tbxMaLK.Text;
                newTbytLk.TenLk = tbxTenLK.Text;
                newTbytLk.Dvt = tbxDvt.Text;
                newTbytLk.SoLuong = Convert.ToInt32(tbxSoLuong.Text);
                if (this.tbytParent != null)
                {                    
                    newTbytLk.Tbytid = tbytParentId;                    
                }
                else
                {
                    newTbytLk.Tbytid = Convert.ToInt32(cbxTB.SelectedValue);
                }

                TBYT_LK_service.AddNew(newTbytLk);

                if (this.tbytParent != null)
                {
                    PopulateGrid(this.tbytParentId);
                } else
                {
                    PopulateGrid();
                }
                    
                ClearTextBoxesAndComboBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }        
        }

        private void BtnRefresh_Click(object? sender, EventArgs e)
        {
            tbxMaLK.Text = "";
            tbxTenLK.Text = "";
            tbxDvt.Text = "";
            tbxSoLuong.Text = "";

            if (this.tbytParent == null)
            {
                cbxTB.SelectedValue = -1;
            }

            if (this.tbytParent != null)
            {
                PopulateGrid(this.tbytParentId);
            }
            else
            {
                PopulateGrid();
            }
        }

        private void Grd_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = grd.Rows[e.RowIndex];
            tbxMaLK.Text = row.Cells["MaLK"].Value.ToString();
            tbxTenLK.Text = row.Cells["TenLK"].Value.ToString();
            tbxDvt.Text = row.Cells["Dvt"].Value.ToString();
            tbxSoLuong.Text = row.Cells["SoLuong"].Value.ToString();

            if (this.tbytParent == null)
            {
                int tbytId = Convert.ToInt32(row.Cells["IdTbyt"].Value);
                cbxTB.SelectedValue = tbytId;                  
            } else
            {
                cbxTB.Enabled = false;
            }
        }

        public void PopulateGrid(int tbytParentId)
        {
            //TBYTDbContext _db = new TBYTDbContext();
            //var lstTBYT_LK = _db.TbytLks.ToList();
            //var lstTBYT_LK = _db.TBYT_LKs.OrderBy(x => x.TenLK).ToList();
            //var lstTBYT_LK = TBYT_LK_service.GetAll();
            var lstTBYT_LK = TBYT_LK_service.GetByTbytId(tbytParentId);
            var displayList = lstTBYT_LK.Select(
                x => new {
                    Id = x.Id,
                    MaLK = x.MaLk,
                    TenLK = x.TenLk,
                    Dvt = x.Dvt,
                    SoLuong = x.SoLuong//,
                    //TenTB = x.Tbyt.TenTb
                }).ToList();

            grd.AutoGenerateColumns = true;
            //grd.DataSource = lst;
            grd.DataSource = displayList;

            grd.Columns["Id"].HeaderText = "Id";
            grd.Columns["MaLK"].HeaderText = "Mã Linh Kiện";
            grd.Columns["TenLK"].HeaderText = "Tên Linh Kiện";
            grd.Columns["Dvt"].HeaderText = "Đơn vị tính";
            grd.Columns["SoLuong"].HeaderText = "Số Lượng";

            grd.Columns["Id"].Visible = false;
            grd.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            grd.DefaultCellStyle.Font = new Font("Arial", 8, FontStyle.Regular);
            grd.Columns["TenLK"].Width = 150;
        }

        public void PopulateGrid()
        {
            //TBYTDbContext _db = new TBYTDbContext();
            //var lstTBYT_LK = _db.TbytLks.ToList();
            //var lstTBYT_LK = _db.TBYT_LKs.OrderBy(x => x.TenLK).ToList();
            //var lstTBYT_LK = TBYT_LK_service.GetAll();

            /*
            var lstTBYT_LK = TBYT_LK_service.GetAll();
            var displayList = lstTBYT_LK.Select(
                x => new {
                    Id = x.Id,
                    MaLK = x.MaLk,
                    TenLK = x.TenLk,
                    Dvt = x.Dvt,
                    SoLuong = x.SoLuong//,
                    //TenTB = x.Tbyt.TenTb
                }).ToList();
            */

            var displayList = TBYT_LK_service.GetAllWithTbyt();

            grd.AutoGenerateColumns = true;
            //grd.DataSource = lst;
            grd.DataSource = displayList;

            grd.Columns["Id"].HeaderText = "Id";
            grd.Columns["MaLK"].HeaderText = "Mã Linh Kiện";
            grd.Columns["TenLK"].HeaderText = "Tên Linh Kiện";
            grd.Columns["Dvt"].HeaderText = "Đơn vị tính";
            grd.Columns["SoLuong"].HeaderText = "Số Lượng";
            grd.Columns["TenTB"].HeaderText = "Tên Thiết Bị";

            grd.Columns["Id"].Visible = false;
            grd.Columns["IdTbyt"].Visible = false;

            grd.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            grd.DefaultCellStyle.Font = new Font("Arial", 8, FontStyle.Regular);
            grd.Columns["TenLK"].Width = 150;
            grd.Columns["TenTB"].Width = 200;
        }

        public void PopulateGrid(List<TbytLk> lstTBYT_LK)
        {
            var displayList = lstTBYT_LK.Select(
                x => new {
                    x.Id,
                    x.MaLk,
                    x.TenLk,
                    x.Dvt,
                    x.SoLuong
                }).ToList();

            grd.AutoGenerateColumns = true;
            //grd.DataSource = lst;
            grd.DataSource = displayList;

            grd.Columns["Id"].HeaderText = "Id";
            grd.Columns["MaLK"].HeaderText = "Mã Linh Kiện";
            grd.Columns["TenLK"].HeaderText = "Tên Linh Kiện";
            grd.Columns["Dvt"].HeaderText = "Đơn vị tính";
            grd.Columns["SoLuong"].HeaderText = "Số Lượng";

            grd.Columns["Id"].Visible = false;
            grd.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            grd.DefaultCellStyle.Font = new Font("Arial", 8, FontStyle.Regular);

            grd.Columns["TenLK"].Width = 150;
        }

        public void PopulateGrid(IEnumerable<object> searchList)
        {

            grd.AutoGenerateColumns = true;
            grd.DataSource = searchList;

            grd.Columns["Id"].HeaderText = "Id";
            grd.Columns["MaLK"].HeaderText = "Mã Linh Kiện";
            grd.Columns["TenLK"].HeaderText = "Tên Linh Kiện";
            grd.Columns["Dvt"].HeaderText = "Đơn vị tính";
            grd.Columns["SoLuong"].HeaderText = "Số Lượng";
            grd.Columns["TenTB"].HeaderText = "Tên Thiết Bị";

            grd.Columns["Id"].Visible = false;
            grd.Columns["IdTbyt"].Visible = false;

            grd.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            grd.DefaultCellStyle.Font = new Font("Arial", 8, FontStyle.Regular);

            grd.Columns["TenLK"].Width = 150;
            grd.Columns["TenTB"].Width = 200;
        }

        public void ClearTextBoxesAndComboBoxes()
        {
            tbxMaLK.Text = "";
            tbxTenLK.Text = "";
            tbxDvt.Text = "";
            tbxSoLuong.Text = "";

            if (this.tbytParent ==  null)
            {
                //cbxTB.SelectedValue = null;
                cbxTB.SelectedIndex = -1;
            } else
            {
                cbxTB.Enabled = false;
            }
        }

        private void FrmTBYT_LK_Load(object sender, EventArgs e)
        {
            if (this.tbytParent != null)
            {      
                PopulateGrid(this.tbytParentId);
            } else
            {
                PopulateGrid();
            }
            
            ClearTextBoxesAndComboBoxes();
        }
    }
}
