using System;
using System.Collections.Generic;
using System.Text;

namespace DPEnergy.DataModelLayer.Entities.Personel
{
    public class P_Bime
    {
        [key]
        public string Id { get; set; }
        public string PersonelCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string VaziatBime { get; set; }
        public string BimeNumber { get; set; }
        public int? SabegheTaminEjtemaei { get; set; }
        public DateTime? TarikhSabtSabegheTamin { get; set; }
        public int? SabegheKhodEzhari { get; set; }
        public DateTime? TarikhSabtKhodEzhari {get;set;}
        public DateTime? CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }
        public string Creator { get; set; }
        public string Modifier { get; set; }
    }
}
