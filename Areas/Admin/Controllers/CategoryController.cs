using NhaHangHaiSan.Models;
using NhaHangHaiSan.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NhaHangHaiSan.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        private ApplicationDbContext _db = new ApplicationDbContext();
        // GET: Admin/Category
        public ActionResult Index()
        {
            var items = _db.Categories.ToList();
            TempData["MaxPosition"] = items.Max(x=>x.Position)+1;
            return View(items);
        }

        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Category model)
        {
            if(ModelState.IsValid) 
            {
                model.CreateDate = DateTime.Now;
                model.ModifidedDate = DateTime.Now;
                model.Alias = NhaHangHaiSan.Models.Common.Filter.FilterChar(model.Title);
                _db.Categories.Add(model);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public ActionResult Edit(int id) 
        {
            var item = _db.Categories.Find(id);
            return View(item);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Category model)
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Attach(model);
                model.ModifidedDate = DateTime.Now;
                model.Alias = NhaHangHaiSan.Models.Common.Filter.FilterChar(model.Title);
                _db.Entry(model).Property(x => x.Title).IsModified = true;
                _db.Entry(model).Property(x => x.Description).IsModified = true;
                _db.Entry(model).Property(x => x.Alias).IsModified = true;
                _db.Entry(model).Property(x => x.SeoDescription).IsModified = true;
                _db.Entry(model).Property(x => x.Position).IsModified = true; 
                _db.Entry(model).Property(x => x.SeoTitle).IsModified = true;
                _db.Entry(model).Property(x => x.SeoKeyWords).IsModified = true;
                _db.Entry(model).Property(x => x.ModifidedBy).IsModified = true;

                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(int id)
        {
            var item = _db.Categories.Find(id);
            if (item !=null)
            {
                //var DeleteItem = _db.Categories.Attach(item);
                _db.Categories.Remove(item);
                _db.SaveChanges();
                return Json(new { success = true });
            }
            return Json(true);
        }
    }
}