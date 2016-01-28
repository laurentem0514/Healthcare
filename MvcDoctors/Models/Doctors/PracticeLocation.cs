using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcDoctors.Models.Doctors
{
    public class PracticeLocation
    {
        public string Name { get; set; }
        public OfficeType OfficeType { get; set; }
        public string FullName { get { return Name + " " + OfficeType; } }
    }
}