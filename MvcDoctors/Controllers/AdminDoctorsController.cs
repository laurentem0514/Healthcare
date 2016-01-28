using MvcDoctors.Models.AdminDoctors;
using MvcDoctors.Models.Doctors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDoctors.Controllers
{
    // /admin/doctors
    [RoutePrefix("admin/doctors")]
    public class AdminDoctorsController : Controller
    {
        private DoctorsRepository Repository { get { return new DoctorsRepository(); } }
        // GET: /admin/doctors
        [Route("")]
        public ActionResult Index()
        {
            List<Doctor> doctors = Repository.GetDoctors();
            return View(doctors);               //this means show the view with this '(xyz)' data.
        }

        //GET /admin/doctors/add    this is currently just a placeholder
        [Route("add"), HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        // POST /admin/doctors/add
        [Route("add"), HttpPost]
        public ActionResult Save(AddDoctorForm form)
        {
            // Create new Doctor object
            Doctor doctor = new Doctor();

            // Populate Doctor’s Name from form.Name(new doc is empty but need to set values regardless)
            doctor.DoctorName = form.Name;

            // Save new Doctor object to repository  (call the Save method)
            Repository.Save(doctor);

            // After submission staying on the add page does not make sense, so instead lets show the listing of doctors (which should include the new one)

            
            return RedirectToAction("Index");    // this redirects to the listing page - Index
        }
    }


}