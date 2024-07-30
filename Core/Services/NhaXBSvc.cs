using PRO131_Duan1_FA23.Core.Context;
using PRO131_Duan1_FA23.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XAct;

namespace PRO131_Duan1_FA23.Core.Services
{
    public class NhaXBSvc : INhaXBSvc
    {
        public bool CapNhapNhaXB(NhaXB xb)
        {
            using (var entity = new QLThuVienDBContext())
            {
                try
                {
                    var nhaxb = entity.nhaXBs.Where(x => x.MaXB == xb.MaXB).FirstOrDefault();
                    nhaxb.TenNhaXB = xb.TenNhaXB;
                    nhaxb.GhiChu = xb.GhiChu;
                    nhaxb.DiaChi = xb.DiaChi;
                    nhaxb.MaNV = xb.MaNV;
                    nhaxb.SoDT = xb.SoDT;
                    entity.SaveChanges();
                    return true;
                } catch { return false; }
            }
        }

        public List<NhaXB> FindNhaXB(string tennhaxb)
        {
            using (var entity = new QLThuVienDBContext())
            {
                 return entity.nhaXBs.Where(x => x.TenNhaXB.Contains(tennhaxb)).ToList();
            }
        }

        public List<NhaXB> GetNhaXB(int numpage, int numrecord)
        {
            using (var entity = new QLThuVienDBContext())
            {
                return entity.nhaXBs.Skip((numpage-1) * numrecord).Take(numrecord).ToList();
            }
        }

        public string NewMaXB()
        {
            using (var entity = new QLThuVienDBContext())
            {
                try
                {
                    List<string> stringlist = entity.nhaXBs.Select(x => x.MaXB).ToList();
                    List<int> intlist = stringlist.Select(x => int.Parse(x.Substring(4))).ToList();
                    int max = intlist.Max() + 1;
                    if(max < 10)
                    {
                        return "XB000" + max;
                    } else if(max < 100)
                    {
                        return "XB00" + max;
                    } else
                    {
                        return "XB0" + max;
                    }
                } catch 
                { 
                    return "XB0001";
                } 
            }
        }

        public bool ThemNhaXB(NhaXB xb)
        {
            using (var entity = new QLThuVienDBContext())
            {
                try
                {
                    entity.nhaXBs.Add(xb);
                    entity.SaveChanges();
                    return true;
                }
                catch { return false; }
            }
        }

        public bool XoaNhaXB(string maxb)
        {
            using (var entity = new QLThuVienDBContext())
            {
                try
                {
                    var xb = entity.nhaXBs.Where(x => x.MaXB == maxb).FirstOrDefault();
                    entity.nhaXBs.Remove(xb);
                    entity.SaveChanges();
                    return true;
                } catch { return false; }
            }
        }
    }
}
