using System.ComponentModel.DataAnnotations;

namespace VitalRegistrationSystem.Models
{
    public class DivorceModel
    {
        [Key]
        public Guid Id { get; set; }
        public string HusbandName { get; set; }
        public int HusbandAge { get; set; }
        public string HusbandFather { get; set; }
        public string HusbandGrandFather { get; set; }
        public string HusbandAddress { get; set; }
        public string HusbandCitizenshipNumber { get; set; }
        public string WifeName { get; set; }
        public int WifeAge { get; set; }
        public string WifeFather { get; set; }
        public string WifeGrandFather { get; set; }
        public string WifeAddress { get; set; }
        public string WifeCitizenshipNumber { get; set; }
        public DateTime MarriageDate { get; set; }
        public DateTime DivorceRegistrationDate { get; set; }

    }
}
