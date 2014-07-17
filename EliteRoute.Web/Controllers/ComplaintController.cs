using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EliteRoute.Services;
using EliteRoute.Services.Tokens;
using EliteRoute.Web.Models;

namespace EliteRoute.Web.Controllers
{
    [Authorize]
    public class ComplaintController : Controller
    {
        private IDataService _dataService = null;

        public ComplaintController(IDataService dataService)
        {
            _dataService = dataService;
        }

        // GET: Complaint
        public ActionResult Index()
        {
            return View();
        }

        // GET: Complaint/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Complaint/Create
        public ActionResult Create()
        {
            CreateComplaintModel model = new CreateComplaintModel();
            model.Airlines = _dataService.GetAirlines().ToSelectList();
            model.Issues = _dataService.GetIssues();

            return View(model);
        }

        // POST: Complaint/Create
        [HttpPost]
        public ActionResult Create(CreateComplaintModel model)
        {
            try
            {

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Complaint/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Complaint/Edit/5
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

        // GET: Complaint/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Complaint/Delete/5
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
