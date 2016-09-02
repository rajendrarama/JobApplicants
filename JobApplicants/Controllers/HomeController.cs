using JobApplicants.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace JobApplicants.Controllers
{
    public class HomeController : Controller
    {
        private IApplicantRepository _applicantRepository;
        public HomeController()
        {
            this._applicantRepository =  new ApplicantRepository();
        }

        public ActionResult Index()
        {
            return View(_applicantRepository.GetApplicants());
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var result = this._applicantRepository.GetApplicantById(id);

            if (result == null)
            {
                return HttpNotFound();
            }
            return View(result);
        }
    }
}
