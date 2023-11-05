using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.Entities.DMS.Stackholders
{
    public class D_Position
    {
        [Key]
        public string Id { get; set; }
        public string Position { get; set; }
        public string Creator { get; set; }
        public DateTime? CreationDate { get; set; }
        public string Modifier { get; set; }
        public DateTime? ModificationDate { get; set; }
       
    }
}
