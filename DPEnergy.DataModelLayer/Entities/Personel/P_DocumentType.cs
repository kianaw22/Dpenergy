using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.Entities.Personel
{
    public class P_DocumentType
    {
        [Key]
        public string Id { get; set; }

        public string DocumentType { get; set; }

    }
}
