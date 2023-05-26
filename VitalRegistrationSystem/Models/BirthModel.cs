using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using VitalRegistrationSystem.Utilities;

namespace VitalRegistrationSystem.Models
{
    public class BirthModel
    {
        public Guid BirthId { get; set; }
        public string ApplicantName { get; set; }            //not null field
        public string ? ApplicantAddress { get; set; }
        public string ApplicantCitizenshipNum { get; set; }  //not null field
        public string GrandFathersName { get; set; }         //not null field
        public string FathersName { get; set; }              //not null field  
        public string MothersName { get; set; }              //not null field
        public DateTime DateOfBirth { get; set; }            //not null field
        public IFormFile ? HospitalVerification { get; set; }
        public string ChildName { get; set; }                //not null field
        public Gender Gender { get; set; }                   //not null field
        public string ChildAddress { get; set; }             //not null field
        public string ? FatherCitizenshipNumber { get; set; }
        public string ? MotherCitizenshipNumber { get; set; }   

    }
}
