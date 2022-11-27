using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YTeAspMVC.Daos;

namespace YTeAspMVC.Controllers
{
    public class DoctorController : Controller
    {
        DoctorDao doctorDao = new DoctorDao();
        // GET: Doctor
        public ActionResult Index(FormCollection form)
        {
            DateTime aDateTime = DateTime.Now;
            ViewBag.CurrentDate = aDateTime.Year + "-" + aDateTime.Month + "-" + aDateTime.Day;
            var keyword = form["namedoctor"];
            ViewBag.List = String.IsNullOrEmpty(keyword) ? doctorDao.GetAll() : doctorDao.Search2(keyword);

            var keyword2 = form["Adoctor"];
            ViewBag.List = String.IsNullOrEmpty(keyword2) ? doctorDao.GetAll() : doctorDao.Search2(keyword2);
            return View();
        }
    }
}