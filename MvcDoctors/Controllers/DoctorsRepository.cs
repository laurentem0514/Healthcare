using MvcDoctors.Models.Doctors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace MvcDoctors.Controllers
{
    public class DoctorsRepository
    {
        private static List<Doctor> _doctors = GetDoctorsInternal(); // We declared a Field to store a single instance of the list and re-use the same instance

        //public DoctorsRepository()  // This is called a constructor and it is called only one time when object DoctorsRepository is created. We can initialize field values here
        //{
        //    _doctors = GetDoctorsInternal();
        //}

        public List<Doctor> GetDoctors()
        {
            return _doctors;
        }

        public void Save(Doctor doctor)   //We added public method that accepts one 'doctor' item (new or existing) which will be saved to the repository
        {
            if (doctor.Id == 0)
            {
                doctor.Id = _doctors.Count + 1;    //this assigns value to doctor ID from list _doctors
                _doctors.Add(doctor);         //this action adds new doctor to internal storage (this case is to list) 
            }
            else
            {
                //TODO this will allow you to edit exisiting doc info
            }
             
        }

        private static List<Doctor> GetDoctorsInternal()
        {
            // Procedure a = new Procedure();            
            // use "a"  , docA: new List<Procedure> { a };
            // use "a"  , docA: new List<Procedure> { a,b };
            Procedure diagnostic = new Procedure() { Name = "Diagnostics", Price = 50.00m };
            Procedure indivTherapy = new Procedure() { Name = "Individual Therapy", Price = 100.00m };
            Procedure groupTherapy = new Procedure() { Name = "Group Therapy", Price = 75.00m };
            Procedure detox = new Procedure() { Name = "Detox", Price = 150.00m };
            Procedure massage = new Procedure() { Name = "Massage 45 min", Price = 150.00m };
            Procedure exercise = new Procedure() { Name = "Therapeutic Exercises", Price = 85.00m };

            PracticeLocation happyCommunity = new PracticeLocation() { Name = "Happy Community", OfficeType = OfficeType.Clinic };
            PracticeLocation riversideBehavioral = new PracticeLocation() { Name = "Riverside Behavioral", OfficeType = OfficeType.Clinic };
            PracticeLocation hollowHills = new PracticeLocation() { Name = "Hollow Hills", OfficeType = OfficeType.Hospital };
            PracticeLocation heatherwoodHospital = new PracticeLocation() { Name = "Heatherwood", OfficeType = OfficeType.Hospital };
            PracticeLocation naturalMedicine = new PracticeLocation() { Name = "Natural Medicine", OfficeType = OfficeType.PrivatePractice };
            PracticeLocation sunnySkies = new PracticeLocation() { Name = "Sunny Skies", OfficeType = OfficeType.PrivatePractice };

            Specialty general = new Specialty() { Name = "General", Type = "Psychiatry" };
            Specialty substance = new Specialty() { Name = "Substance Abuse", Type = "Psychiatry" };
            Specialty adult = new Specialty() { Name = "Adult", Type = "Psychiatry" };
            Specialty physical = new Specialty() { Name = "Physical Therapy", Type = "Medical" };
            Specialty adolescent = new Specialty() { Name = "Adolescent", Type = "Psychiatry" };
            Specialty abnormal = new Specialty() { Name = "Abnormal", Type = "Psychiatry" };

            var imagesFolder = "/images/doctors/";

            var doctors = new List<Doctor> {
                new Doctor
                {
                    DoctorName = "Dr Jones",
                    Specialty = general,
                    ProceduresProvided = new List<Procedure> {diagnostic, indivTherapy, groupTherapy},
                    Location = new List<PracticeLocation> {happyCommunity, sunnySkies},
                    ImageUrl = imagesFolder + "drjones.PNG"
                },
                new Doctor
                {
                    DoctorName = "Dr Spock",
                    Specialty = substance,
                    ProceduresProvided = new List<Procedure> {diagnostic, indivTherapy, detox},
                    Location = new List<PracticeLocation> {heatherwoodHospital},
                    ImageUrl = imagesFolder + "drspock.PNG"
                },
                new Doctor
                {
                    DoctorName = "Dr Happy",
                    Specialty = adult,
                    ProceduresProvided = new List<Procedure> {diagnostic, indivTherapy, groupTherapy},
                    Location = new List<PracticeLocation> {heatherwoodHospital, naturalMedicine},
                    ImageUrl = imagesFolder + "drhappy.PNG"
                },
                new Doctor
                {
                    DoctorName = "Dr Kay",
                    Specialty = physical,
                    ProceduresProvided = new List<Procedure> {diagnostic, massage, exercise},
                    Location = new List<PracticeLocation> {hollowHills},
                    ImageUrl = imagesFolder + "drkay.PNG"
                },
                new Doctor
                {
                    DoctorName = "Dr Crazee",
                    Specialty = adolescent,
                    ProceduresProvided = new List<Procedure> {diagnostic, indivTherapy},
                    Location = new List<PracticeLocation> {riversideBehavioral, hollowHills},
                    ImageUrl = imagesFolder + "drcrazee.PNG"
                },
                new Doctor
                {
                    DoctorName = "Dr Blue",
                    Specialty = abnormal,
                    ProceduresProvided = new List<Procedure> {diagnostic, indivTherapy, groupTherapy, detox},
                    Location = new List<PracticeLocation> {happyCommunity, hollowHills},
                    ImageUrl = imagesFolder + "drblue.PNG"
                },
            };



            return doctors;

            //return new List<Doctor>();
        }
    }
}