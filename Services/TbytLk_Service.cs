using MicroMEMSVer3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroMEMSVer3.Services
{

    internal class TbytLk_Service
    {
        private readonly TBYTDbContext _db;

        public TbytLk_Service()
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

        public List<TbytLk> GetAll()
        {
            //return _db.TBYT_LKs.ToList();

            try
            {
                var result = _db.TbytLks.OrderBy(x => x.TenLk).ToList();
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public IEnumerable<object> GetAllWithTbyt()
        {
            try
            {
                var result = (from tbytLk in _db.TbytLks
                             join tbyt in _db.Tbyts on tbytLk.Tbytid equals tbyt.Id
                             select new {
                                 Id = tbytLk.Id,
                                 MaLK = tbytLk.MaLk,
                                 TenLK = tbytLk.TenLk,
                                 Dvt = tbytLk.Dvt,
                                 SoLuong = tbytLk.SoLuong,
                                 IdTbyt = tbytLk.Tbytid,
                                 TenTB = tbyt.TenTb + " - " + tbyt.MaTb
                             }).ToList();
                return result;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public List<TbytLk> GetByTbytId(int tbytId)
        {
            try
            {
                var result = _db.TbytLks
                    .Where(x => x.Tbytid == tbytId)
                    .OrderBy(x => x.TenLk)
                    .ToList();
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        // Case 1: Tbyt is not null => lktbyt only need to query lktbyt with that tbytId
        // Additional Condition: TenLk contains searchKey
        public List<TbytLk> SearchWithTbytId(string tenLk,int tbytId)
        {
            try
            {
                var result = _db.TbytLks
                    .Where(x => x.Tbytid == tbytId)
                    .Where(x => x.TenLk.Contains(tenLk))
                    .OrderBy(x => x.TenLk)
                    .ToList();
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        // Case 2: Tbyt is null => lktbyt need to query lktbyt with all tbytId and join Table tbyt
        // Additional Condition: TenLk contains searchKey
        public IEnumerable<object> Search(string tenLk)
        {
            try
            {
                var result = (from tbytLk in _db.TbytLks
                              join tbyt in _db.Tbyts on tbytLk.Tbytid equals tbyt.Id
                              where tbytLk.TenLk.Contains(tenLk)
                              orderby tbytLk.TenLk ascending
                              select new
                              {
                                  Id = tbytLk.Id,
                                  MaLK = tbytLk.MaLk,
                                  TenLK = tbytLk.TenLk,
                                  Dvt = tbytLk.Dvt,
                                  SoLuong = tbytLk.SoLuong,
                                  IdTbyt = tbytLk.Tbytid,
                                  TenTB = tbyt.TenTb + " - " + tbyt.MaTb
                              }).ToList();
                return result;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public TbytLk GetOne(int id)
        {
            return _db.TbytLks.Find(id);
        }

        /*
        public List<TbytLk> Search(string tenLK)
        {
            try
            {
                //return _db.TBYTs.Where(x => x.TenTB.Contains(tenTB)).ToList();
                return _db.TbytLks.Where(x => x.TenLk.Contains(tenLK)).OrderBy(y => y.TenLk).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        */

        public bool AddNew(TbytLk tbyt_lk)
        {
            
            try
            {
                _db.TbytLks.Add(tbyt_lk);
                _db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool Update(TbytLk obj)
        {
            bool lreturn = false;
            TbytLk tbyt_lk = _db.TbytLks.Find(obj.Id);
            if (tbyt_lk == null)
            {
                lreturn = this.AddNew(obj);
            }
            else
            {
                // MaLK, TenLK, Dvt, SoLuong, IdTBYT
                tbyt_lk.MaLk = obj.MaLk;
                tbyt_lk.TenLk = obj.TenLk;
                tbyt_lk.Dvt = obj.Dvt;
                tbyt_lk.SoLuong = obj.SoLuong;

                _db.SaveChanges();
                lreturn = true;
            }
            return lreturn;
        }

        public bool Delete(int Id)
        {
            TbytLk tbyt_lk = _db.TbytLks.Find(Id);
            if (tbyt_lk != null)
            {
                _db.TbytLks.Remove(tbyt_lk);
                _db.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(TbytLk obj)
        {
            TbytLk tbyt_lk = _db.TbytLks.Find(obj.Id);
            if (tbyt_lk != null)
            {
                _db.TbytLks.Remove(tbyt_lk);
                _db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
