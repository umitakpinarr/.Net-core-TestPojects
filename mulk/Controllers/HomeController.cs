using Microsoft.AspNetCore.Mvc;
using mulk.Models;
using mulk.Models.Context;
using mulk.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mulk.Controllers
{
    public class HomeController : Controller
    {
        private readonly DatabaseContext _databaseContext;

        public HomeController(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public IActionResult Index()
        {

            return View();
        }


        public IActionResult Test()
        {
            List<tenants> DbTenants = _databaseContext.tenants.ToList();
            return View(DbTenants);
        }

        [HttpPost]
        public IActionResult Test(string cityId)
        {
            List<tenants> DbTenants2 = _databaseContext.tenants.Where(x => x.Name.Contains(cityId)).ToList();
            List<tenants> DbTenants = _databaseContext.tenants.Where(x => x.Name == cityId).ToList();
            var jsonWriters = JsonConvert.SerializeObject(DbTenants2);
            return Json(jsonWriters);
        }

        [HttpPost]
        public IActionResult Index(tenants tenants)
        {
            
            _databaseContext.tenants.Add(tenants);
            _databaseContext.SaveChanges();
            return View();
        }
        public IActionResult rent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult rent(rents rents)
        {

            _databaseContext.rents.Add(rents);
            _databaseContext.SaveChanges();
            return View();
        }


        public IActionResult Contract()
        {
            List<tenants> DbTenants = _databaseContext.tenants.ToList();
            List<rents> DbRents = _databaseContext.rents.ToList();
            return View(Tuple.Create<List<tenants>, List<rents>>(new List<tenants>(DbTenants), new List<rents>(DbRents)));
        }

        [HttpPost]
        public IActionResult Contract([Bind(Prefix = "Item1")] tenants Model1, [Bind(Prefix = "Item2")] rents Model2)
        {

            return View();
        }


        public IActionResult GetTenants(int cityId)
        {
            var model = _databaseContext.tenants.Where(x => x.Id == cityId).ToList();
            return Json(model);
        }

        public IActionResult GetRents(int cityId2)
        {
            var model = _databaseContext.rents.Where(x => x.Id == cityId2);
            return Json(model);
        }

        public IActionResult test2()
        {
            if (ViewBag.x == null)
            {
                ViewBag.x = 0;
            }
            List<rents> DbRents = _databaseContext.rents.ToList();
            return View(DbRents);
        }

        [HttpPost]
        public IActionResult test2(int piece, string name)
        {



            for (int i = 1; i <= piece; i++)
            {
                rents Dbrents = new rents();

                Dbrents.function = "Kiralık";
                Dbrents.adress = null;
                Dbrents.price = 0;
                Dbrents.status = false;
                Dbrents.tenantId = 1;
                Dbrents.Name = name + " => " + i;
                _databaseContext.rents.Add(Dbrents);
                _databaseContext.SaveChanges();
            }

            return Redirect("/Home/test2");
        }


        public IActionResult test2Edit(int? Id)
        {
            
            ViewBag.x = Id;
            return Redirect("/Home/test2");
        }


        public IActionResult test3()
        {
            if (TempData["Id"] == null)
            {
                TempData["Id"] = 0;
            }
            List<rents> DbRents = _databaseContext.rents.ToList();
            return View(DbRents);
        }

        public IActionResult test3edit(int cityId)
        {

            rents DbRents = _databaseContext.rents.Where(x => x.Id == cityId).FirstOrDefault();
            return Json(DbRents);
        }

    }
}
