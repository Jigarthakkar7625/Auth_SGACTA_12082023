using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace Auth_SGACTA.Controllers
{
    public class CheckUserRoleController : Controller
    {
        // GET: CheckUserRole

        [Authorize(Roles = "Admin,User")]
        public ActionResult Index()
        {

            var identity = (ClaimsIdentity)User.Identity;
            var roles = identity.Claims
                        .FirstOrDefault(c => c.Type == "Gender").Value;
            //var LogTime = identity.Claims
            //            .FirstOrDefault(c => c.Type == "LoggedOn").Value;

            return View();
        }

        // GET: CheckUserRole/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        [Authorize(Roles = "User")]
        // GET: CheckUserRole/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CheckUserRole/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CheckUserRole/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CheckUserRole/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CheckUserRole/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CheckUserRole/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
