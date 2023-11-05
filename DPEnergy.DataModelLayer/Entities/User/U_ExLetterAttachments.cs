using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DPEnergy.DataModelLayer.Entities.User
{
    public class U_ExLetterAttachments
    {
        [Key]
        public int ID { get; set; }
        public int LetterID { get; set; }
        public string Attachment { get; set; }


        [ForeignKey("LetterID")]
        public virtual U_ExternalLetters Letter { get; set; }
    }
}
