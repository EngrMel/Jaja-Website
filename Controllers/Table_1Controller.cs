using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Jaja_Website.Models;

namespace Jaja_Website.Controllers
{
    public class Table_1Controller : Controller
    {
        // GET: Table_1/index
        public ActionResult Index()
        {
            using(dbModel DbModel = new dbModel())
            {
                return View(DbModel.Table_1.ToList());
            }
           
        }

        // GET: Table_1/Details/5
        public ActionResult Details(int ID)
        {
            using(dbModel Dbmodel = new dbModel())
            {
                return View(Dbmodel.Table_1.Where(x => x.id == ID).FirstOrDefault());
            }
            
        }

        // GET: Table_1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Table_1/Create
        [HttpPost]
        public ActionResult Create(Table_1 table_1)
        {
            try
            {
                using(dbModel DbModel = new dbModel())
                {
                    DbModel.Table_1.Add(table_1);
                    DbModel.SaveChanges();
                }
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Table_1/Edit/5
        public ActionResult Edit(int ID)
        {
            using (dbModel Dbmodel = new dbModel())
            {
                return View(Dbmodel.Table_1.Where(x => x.id == ID).FirstOrDefault());
            }
            
        }

        // POST: Table_1/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Table_1 table_1)
        {
            try
            {
                using(dbModel Dbmodel = new dbModel())
                {
                    Dbmodel.Entry(table_1).State = EntityState.Modified;
                    Dbmodel.SaveChanges();
                }
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Table_1/Delete/5
        public ActionResult Delete(int ID)
        {
            using (dbModel Dbmodel = new dbModel())
            {
                return View(Dbmodel.Table_1.Where(x => x.id == ID).FirstOrDefault());
            }
            
        }

        // POST: Table_1/Delete/5
        [HttpPost]
        public ActionResult Delete(int ID, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                using(dbModel Dbmodel = new dbModel())
                {
                    Table_1 table_1 = Dbmodel.Table_1.Where(x => x.id==ID).FirstOrDefault();
                    Dbmodel.Table_1.Remove(table_1);
                    Dbmodel.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
