using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcDoctors.Models.Doctors
{
    public class Doctor
    {
        public int Id { get; set; }
        public string DoctorName { get; set; }
        public Specialty Specialty { get; set; }
        public List<Procedure> ProceduresProvided { get; set; }
        public List<PracticeLocation> Location { get; set; }
        public string ImageUrl { get; set; }     
    }
}