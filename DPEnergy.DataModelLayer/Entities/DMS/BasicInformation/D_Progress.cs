using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.Entities.DMS.BasicInformation
{
    public class D_Progress
    {
        [Key]
        public string Id { get; set; }
        public string ProjectCode { get; set; }
        public string Stage { get; set; }
        public string? StageName { get; set; }
        public string? StageDescription { get; set; }

        public string percent_test { get; set; }
        public string Percent { get; set; }
        public string Creator { get; set; }
        public DateTime? CreationDate { get; set; }
        public string Modifier { get; set; }
        public DateTime? ModificationDate { get; set; }
    }
}
