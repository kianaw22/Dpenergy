using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.ViewModels.Reports
{
   public  class ReportsViewModel
    {
        public string Id { get; set; }

        [Display(Name = "Name")]
        [Required]
        public string ReportName { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Project Code")]
       
        public string ProjectCode { get; set; }

        [Display(Name = "Area")]
        public string Area { get; set; }

        [Display(Name = "Path")]
        [Required]
        public string ReportPath { get; set; }
        [Display(Name = "Creator")]
        public string? Creator { get; set; }

        [Display(Name = "CreationDate")]
        public DateTime? CreationDate { get; set; }

        [Display(Name = "Modifier")]
        public string? Modifier { get; set; }

        [Display(Name = "ModificationDate")]
        public DateTime? ModificationDate { get; set; }
    }
}
