using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.Entities.DMS.BasicInformation
{
    public class D_DpDicipline
    {
        [Key]
        public string Id { get; set; }
        public string Dicipline { get; set; }
        public string Title { get; set; }
        public string Creator { get; set; }
        public int? Order { get; set; }
        public DateTime? CreationDate { get; set; }
        public string Modifier { get; set; }
        public DateTime? ModificationDate { get; set; }


    }
}
