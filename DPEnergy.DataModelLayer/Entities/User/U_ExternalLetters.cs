using DPEnergy.DataModelLayer.Entities.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DPEnergy.DataModelLayer.Entities.User
{
    public class U_ExternalLetters
    {
        [Key]
        public int LetterID { get; set; }
        
        public string LetterSubject { get; set; }
        public string LetterContent { get; set; }
        public string UserID { get; set; }
        public DateTime LetterCreateDate { get; set; }

        [ForeignKey("UserID")]
        public virtual A_UserManager Users { get; set; }




    }
}
