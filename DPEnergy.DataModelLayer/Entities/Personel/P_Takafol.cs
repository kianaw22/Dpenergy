using System;
using System.Collections.Generic;
using System.Text;

namespace DPEnergy.DataModelLayer.Entities.Personel
{
    public class P_Takafol
    {
        public string Id { get; set; }
        public string PersonelCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public  DateTime? Birthdate { get; set; }
        public string Relation { get; set; }
        public string Active { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }
        public string Creator { get; set; }
        public string Modifier { get; set; }
    }
}
