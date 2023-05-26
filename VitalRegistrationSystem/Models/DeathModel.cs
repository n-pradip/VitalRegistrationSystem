namespace VitalRegistrationSystem.Models
{
    public class DeathModel
    {
        public string ApplicantName { get; set; }
        public string ApplicantCitizenshipNumber { get; set; }
        public string DeadPersonName { get; set; }
        public int DeadPersonAge { get; set; }
        public string DeadPersonFatherName { get; set; }
        public string DeadPersonGrandFatherName { get; set; }
        public string DeadPersonSpouse { get; set; }
        public string DeadPersonCitizenshipNumber { get; set; }
        public string DeadPersonAddress { get; set; }
        public DateTime DeathDate { get; set; }
        public DateTime DeathRegistrationDate { get; set; }
    }
}
