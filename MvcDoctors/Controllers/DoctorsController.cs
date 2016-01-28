using MvcDoctors.Models.Doctors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDoctors.Controllers
{
    // /doctors/{action}
    [RoutePrefix("doctors")]
    public class DoctorsController : Controller
    {
        // This is a link between this controller and a repository (something that contains data)
        //private DoctorsRepository Repository { get {return new DoctorsRepository();} }    // This is a Property

        // This does the same thing as above but it is a Field 
        // and it is better because value is set only once and it is reused
        private DoctorsRepository _repository = new DoctorsRepository();  

        // GET /doctors
        [Route("")]
        public ActionResult Index()
        {
            List<Doctor> doctors = _repository.GetDoctors();
            return View(doctors);
        }

        // GET /doctors/{id}
        [Route("{id}")]
        public ActionResult DoctorDetails(int id)
        {
            return View();
        }

        public ActionResult OurTeam()
        {
            List<Doctor> doctors = _repository.GetDoctors();

            return PartialView(doctors);
        }   

    }
}