using MicroMEMSVer3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroMEMSVer3.Services
{
    internal class Tbyt_Service
    {
        private readonly TBYTDbContext _db;
        public Tbyt_Service()
        {
            _db = new TBYTDbContext();
        }

        bool disposed;



        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _db.Dispose();

                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public List<Tbyt> GetAll()
        {
            //return _db.TBYTs.ToList();

            try
            {
                return _db.Tbyts.OrderBy(x => x.TenTb).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public Tbyt GetOne(int id)
        {
            return _db.Tbyts.Find(id);
        }

        public List<Tbyt> Search(string tenTB)
        {
            try
            {
                //return _db.TBYTs.Where(x => x.TenTB.Contains(tenTB)).ToList();
                return _db.Tbyts.Where(x => x.TenTb.Contains(tenTB)).OrderBy(y => y.TenTb).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public bool AddNew(Tbyt tbyt)
        {
            try
            {
                _db.Tbyts.Add(tbyt);
                _db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool Update(Tbyt obj)
        {
            bool lreturn = false;
            Tbyt tbyt = _db.Tbyts.Find(obj.Id);
            if (tbyt == null)
            {

                lreturn = this.AddNew(obj);
            }
            else
            {
                tbyt.NhomTb = obj.NhomTb;
                tbyt.LoaiTb = obj.LoaiTb;
                tbyt.MaTb = obj.MaTb;
                tbyt.TenTb = obj.TenTb;
                tbyt.Dvt = obj.Dvt;

                tbyt.HangSx = obj.HangSx;
                tbyt.NuocSx = obj.NuocSx;
                tbyt.NamSx = obj.NamSx;
                tbyt.GiaTri = obj.GiaTri;
                tbyt.SoLanBaoTriMotNam = obj.SoLanBaoTriMotNam;

                _db.SaveChanges();
                lreturn = true;
            }
            return lreturn;
        }

        public bool Delete(int Id)
        {
            Tbyt tbyt = _db.Tbyts.Find(Id);
            if (tbyt != null)
            {
                _db.Tbyts.Remove(tbyt);
                _db.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(Tbyt obj)
        {
            Tbyt tbyt = _db.Tbyts.Find(obj.Id);
            if (tbyt != null)
            {
                _db.Tbyts.Remove(tbyt);
                _db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
