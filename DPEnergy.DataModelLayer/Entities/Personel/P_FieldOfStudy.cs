using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.Entities.Personel
{
    public class P_FieldOfStudy
    {
        [Key]
        public String Id { get; set; }
        public String FieldofStudy { get; set; }
    }
}
