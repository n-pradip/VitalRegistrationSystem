namespace VitalRegistrationSystem.Models
{
    public class DeathModel
    {
        public string ApplicantName { get; set; }
        public string ApplicantCitizenshipNumber { get; set; }
        public string DeceasedName { get; set; }
        public int Age { get; set; }
        public string FatherName { get; set; }
        public string GrandfatherName { get; set; }
        public string Spouse { get; set; }
        public string CitizenshipNumber { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DeathDate { get; set; }
        public DateTime DeathRegistrationDate { get; set; }
    }
}
