using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CRUD.Models.EF;

namespace CRUD.Models.DB
{
    public class DBNhom
    {
        //Add new
        public bool add_new(nhomsp nhom)
        {
            try
            {
                QLContext db = new QLContext();
                db.nhomsps.Add(nhom);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Edit
        public bool edit(nhomsp nhom)
        {
            try
            {
                QLContext db = new QLContext();
                db.Entry(nhom).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return true;

            }catch
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
                var old_data = db.nhomsps.Find(id);
                db.nhomsps.Remove(old_data);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }

        //Detail
        public nhomsp detail(int id)
        {
            try
            {
                QLContext db = new QLContext();
                return db.nhomsps.Find(id);
            }
            catch
            {
                return null;
            }
        }

        //Get list
        public IEnumerable<nhomsp> get_list()
        {
            try
            {
                QLContext db = new QLContext();
                return db.nhomsps;
            }catch
            {
                return null;
            }
        }


    }
}