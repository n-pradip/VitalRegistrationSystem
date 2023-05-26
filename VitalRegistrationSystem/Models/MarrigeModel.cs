﻿namespace VitalRegistrationSystem.Models
{
    public class MarrigeModel
    {
        public string BrideName { get; set; }
        public int BrideAge { get; set; }
        public string BrideFather { get; set; }
        public string BrideGrandFather { get; set; }
        public string BrideAddress { get; set; }
        public DateTime BrideCitizenshipIssuedDate { get; set; }
        public string BrideCitizenshipNumber { get; set; }
        public string BridegroomName { get; set; }
        public int BridegroomAge { get; set; }
        public string BridegroomFather { get; set; }
        public string BridegroomGrandFather { get; set; }
        public string BridegroomAddress { get; set; }
        public DateTime BridegroomCitizenshipIssuedDate { get; set; }
        public string BridegroomCitizenshipNumber { get; set; }
        public DateTime MarriageDate { get; set; }
        public DateTime MarriageRegistrationDate { get; set; }

    }
}
