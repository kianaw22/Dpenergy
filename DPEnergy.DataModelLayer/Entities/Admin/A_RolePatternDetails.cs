using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DPEnergy.DataModelLayer.Entities.Admin
{
    public class A_RolePatternDetails
    {
        [Key]
        public int RolePatternDetailsID { get; set; }
        public int RolePatternID { get; set; }
        public string RoleID { get; set; }

        [ForeignKey("RolePatternID")]
        public virtual A_RolePattern RP { get; set; }

        [ForeignKey("RoleID")]

        public virtual ApplicationRoles Roles { get; set; }
    }
}
