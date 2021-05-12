using AutoMapper;
using FaleConoscoBizapp.Domain;
using FaleConoscoBizapp.Models.Interfaces;
using FaleConoscoBizapp.Services;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Tooling.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FaleConoscoBizapp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contact(FaleConoscoModel model)
        {

            FaleConoscoServices _repository = new FaleConoscoServices();

            try
            {

                if (ModelState.IsValid)
                {
                    _repository.Insert(model);

                    return RedirectToAction(nameof(Index));
                }
                return View(model);
            }
            catch (Exception ex)
            {
                return View(model);
            }

        }
    }
}