using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DPEnergy.DataModelLayer.Entities.Admin
{
    public class A_AdministrativeForm
    {
        [Key]
        public int AdministrativeFormID { get; set; }
        public bool AdministrativeFormType { get; set; }
        public string AdministrativeFormTitle { get; set; }
        public string AdministrativeFormContent { get; set; }
        public string UserID { get; set; }

        [ForeignKey("UserID")]
        public virtual A_UserManager User { get; set; }
    }
}
