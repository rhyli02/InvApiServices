using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvApiServices.Controllers
{
    public class ApprovalController : Controller
    {
        // GET: ApprovalController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ApprovalController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ApprovalController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ApprovalController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ApprovalController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ApprovalController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ApprovalController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ApprovalController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
