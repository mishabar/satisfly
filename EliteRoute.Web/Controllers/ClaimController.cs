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
    //    [Authorize]
    public class ClaimController : Controller
    {
        private IDataService _dataService = null;

        public ClaimController(IDataService dataService)
        {
            _dataService = dataService;
        }

        // GET: Claim
        public ActionResult Index()
        {
            return View();
        }

        // GET: Claim/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Claim/Create
        public ActionResult Create()
        {
            CreateClaimModel model = new CreateClaimModel();
            model.Airlines = _dataService.GetAirlines().ToSelectList();
            model.Issues = _dataService.GetIssues();

            return View(model);
        }

        // POST: Claim/Create
        [HttpPost]
        public ActionResult Create(CreateClaimModel model)
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

        // GET: Claim/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Claim/Edit/5
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

        // GET: Claim/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Claim/Delete/5
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
