using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DPEnergy.DataModelLayer.Entities.User
{
    public class U_LetterRecipents
    {
        [Key]
        public int ID { get; set; }
        public int  LetterID { get; set; }
        public string Company { get; set; }
        public string Person { get; set; }
        public string Position { get; set; }
        
        
        [ForeignKey("LetterID")]
        public virtual U_ExternalLetters Letter { get; set; }
    }
}
