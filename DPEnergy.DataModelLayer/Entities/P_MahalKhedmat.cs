using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.Entities
{
    public class P_MahalKhedmat
    {
        [Key]
        public String Id { get; set; }
        public String MahalKhedmatName { get; set; }
    }
}
