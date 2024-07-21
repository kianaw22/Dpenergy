using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.Entities.Personel
{
    public class P_ContactInf
    {
        [Key]
        public string Id { get; set; }
        public string PersonelCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string HomePhone { get; set; }
        public string IntroducedName { get; set; }
        public string IntroducedPhone { get; set; }
        public string IntroducedAddress { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }
        public string Creator { get; set; }
        public string Modifier { get; set; }

    }
}
