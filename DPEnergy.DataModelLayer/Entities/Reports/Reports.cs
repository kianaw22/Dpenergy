using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.Entities.Reporrts
{
    public class Reports
    {
        [Key]
        public string Id { get; set; }
        public string ReportName { get; set; }
        public string Description { get; set; }
        public string ProjectCode { get; set; }
        public string Area { get; set; }
        public string ReportPath { get; set; }
        public string Creator { get; set; }
        public DateTime? CreationDate { get; set; }
        public string Modifier { get; set; }
        public DateTime? ModificationDate { get; set; }
    }
}
