using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUD.Models.DB;
using CRUD.Models.EF;

namespace CRUD.Controllers
{
    public class NhomController : Controller
    {
        // GET: Nhom
        public ActionResult Index()
        {
            DBNhom db = new DBNhom();
            var data = db.get_list();
            return View(data);
        }

        // GET: Nhom/Details/5
        public ActionResult Details(int id)
        {
            DBNhom db = new DBNhom();
            var data = db.detail(id);
            return View(data);
        }

        // GET: Nhom/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Nhom/Create
        [HttpPost]
        public ActionResult Create(nhomsp nhom)
        {
            try
            {
                // TODO: Add insert logic here
                DBNhom db = new DBNhom();

                HttpPostedFileBase file = Request.Files["anh"];
                string file_path = Server.MapPath("~/Images/" + file.FileName);
                string img_src = "Images/" + file.FileName;
                file.SaveAs(file_path);

                nhom.anh = img_src;


                if (db.add_new(nhom))
                {
                    return RedirectToAction("Index");
                }else
                {
                    return View();
                }
                
            }
            catch
            {
                return View();
            }
        }

        // GET: Nhom/Edit/5
        public ActionResult Edit(int id)
        {
            DBNhom db = new DBNhom();
            var data = db.detail(id);
            return View(data);
        }

        // POST: Nhom/Edit/5
        [HttpPost]
        public ActionResult Edit(nhomsp nhom)
        {
            try
            {
                // TODO: Add update logic here
                DBNhom db = new DBNhom();

                HttpPostedFileBase file = Request.Files["anh"];
                string file_path = Server.MapPath("~/Images/" + file.FileName);
                string img_src = "Images/" + file.FileName;
                file.SaveAs(file_path);

                nhom.anh = img_src;


                if (db.edit(nhom))
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
                
            }
            catch
            {
                return View();
            }
        }

        // GET: Nhom/Delete/5
        public ActionResult Delete(int id)
        {
            DBNhom db = new DBNhom();
            var data = db.detail(id);

            return View(data);
        }

        // POST: Nhom/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                DBNhom db = new DBNhom();
                if(db.delete(id))
                {
                    return RedirectToAction("Index");
                }else
                {
                    return View();
                }


                
            }
            catch
            {
                return View();
            }
        }
    }
}
