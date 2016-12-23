using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUD.Models.DB;
using CRUD.Models.EF;

namespace CRUD.Controllers
{
    public class SPController : Controller
    {
        // GET: SP
        public ActionResult Index()
        {
            DBSP db = new DBSP();
            var data = db.get_list();
            return View(data);
        }

        // GET: SP/Details/5
        public ActionResult Details(int id)
        {
            DBSP db = new DBSP();
            var data = db.detail(id);
            return View(data);
        }

        // GET: SP/Create
        public ActionResult Create()
        {
            DBNhom db = new DBNhom();
            ViewBag.List_Nhom = db.get_list();
            return View();
        }

        // POST: SP/Create
        [HttpPost]
        public ActionResult Create(sanpham sp)
        {
            try
            {
                // TODO: Add insert logic here
                DBSP db = new DBSP();
                if (db.add_new(sp))
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

        // GET: SP/Edit/5
        public ActionResult Edit(int id)
        {
            DBSP db = new DBSP();
            var data = db.detail(id);


            DBNhom dbnhom = new DBNhom();
            ViewBag.List_Nhom = dbnhom.get_list();
            ViewBag.Selected_ID = db.detail(id).id_nhom;
            

            return View(data);
        }

        // POST: SP/Edit/5
        [HttpPost]
        public ActionResult Edit(sanpham sp)
        {
            try
            {
                // TODO: Add update logic here
                DBSP db = new DBSP();
                if(db.edit(sp))
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

        // GET: SP/Delete/5
        public ActionResult Delete(int id)
        {
            DBSP db = new DBSP();
            var data = db.detail(id);
            return View(data);
        }

        // POST: SP/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                DBSP db = new DBSP();
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
