using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CRUD.Models.EF;
namespace CRUD.Models.DB
{
    public class DBSP
    {
        public bool add_new(sanpham sp)
        {
            try
            {
                QLContext db = new QLContext();
                db.sanphams.Add(sp);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Edit
        public bool edit(sanpham sp)
        {
            try
            {
                QLContext db = new QLContext();
                db.Entry(sp).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return true;

            }
            catch
            {
                return false;
            }
        }

        //Delete
        public bool delete(int id)
        {
            try
            {
                QLContext db = new QLContext();
                var old_data = db.sanphams.Find(id);
                db.sanphams.Remove(old_data);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }

        //Detail
        public sanpham detail(int id)
        {
            try
            {
                QLContext db = new QLContext();
                return db.sanphams.Find(id);
            }
            catch
            {
                return null;
            }
        }

        //Get list
        public IEnumerable<sanpham> get_list()
        {
            try
            {
                QLContext db = new QLContext();
                return db.sanphams;
            }
            catch
            {
                return null;
            }
        }
    }
}