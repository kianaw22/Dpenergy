using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.Entities.Personel
{
    public class P_VaziatKhedmat
    {
        [Key]
        public string Id { get; set; }
        public string PersonelCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string VaziatNezamVazife { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string OrganName { get; set; }
        public string Attachment { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }
        public string Creator { get; set; }
        public string Modifier { get; set; }

    }
}
