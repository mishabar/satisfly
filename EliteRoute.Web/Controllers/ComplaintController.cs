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
        private IComplaintService _complaintService = null;

        public ComplaintController(IDataService dataService, IComplaintService complaintService)
        {
            _dataService = dataService;
            _complaintService = complaintService;
        }

        // GET: Complaint
        public ActionResult Index()
        {
            ComplaintListModel model = new ComplaintListModel 
            { 
                Complaints = _complaintService.GetAllByEmail(User.Identity.Name),
                Airlines = _dataService.GetAirlines(),
                Issues = _dataService.GetIssues()
            };
            return View(model);
        }

        // GET: Complaint/Details/5
        public ActionResult Details(long id)
        {
            ComplaintDetailsModel model = new ComplaintDetailsModel 
            {
                Complaint = _complaintService.GetByID(User.Identity.Name, id),
                Airlines = _dataService.GetAirlines(),
                Issues = _dataService.GetIssues()
            };
            return View(model);
        }

        // GET: Complaint/Create
        public ActionResult Create()
        {
            CreateComplaintModel model = new CreateComplaintModel();
            model.Airlines = _dataService.GetAirlines().ToSelectList();
            model.Issues = _dataService.GetIssues();

            return View(model);
        }

        // GET: Complaint/Create
        public ActionResult Created(long id)
        {
            return View(id);
        }

        // POST: Complaint/Create
        [HttpPost]
        public ActionResult Create(CreateComplaintModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ComplaintToken token = _complaintService.Create(new ComplaintToken 
                    { 
                        Email = User.Identity.Name,
                        Airline = model.Airline, 
                        FlightNumber = model.FlightNumber, 
                        ConfirmationNumber = model.ConfirmationNumber, 
                        Issues = model.Issue, 
                        Comments = model.Comments 
                    });
                    return RedirectToAction("Details", new { id = token.ID });
                }
            }
            catch
            {
                model.Error = "Unexpected error occured. Please try again.";
            }
            model.Airlines = _dataService.GetAirlines().ToSelectList();
            model.Issues = _dataService.GetIssues();
            return View(model);
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
