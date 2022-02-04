﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvApiServices.Controllers
{
    public class SalesMasterController : Controller
    {
        // GET: SalesMasterController
        public ActionResult Index()
        {
            return View();
        }

        // GET: SalesMasterController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SalesMasterController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SalesMasterController/Create
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

        // GET: SalesMasterController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SalesMasterController/Edit/5
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

        // GET: SalesMasterController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SalesMasterController/Delete/5
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
