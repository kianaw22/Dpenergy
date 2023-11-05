using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.ViewModels.DMS.BasicInformation
{
    public class D_ProjectBudgetViewModel
    {
        public string Id { get; set; }
        [Required]
        [Display(Name = "Project Code")]
        public string ProjectCode { get; set; }

        [Display(Name = "Project Title")]
        public string ProjectTitle { get; set; }

        [Required]
        [Display(Name = "Department")]
        public string Department { get; set; }

        [Required]
        [Display(Name = "Departmental Budget")]
        public string DepartmentalBudget { get; set; }

        [Display(Name = "Total Budget")]
        public string TotalBudget { get; set; }

        [Display(Name = "OverTime/Deduction")]
        public string OverTimeOrDeduction { get; set; }

        [Display(Name = "Creator")]
        public string Creator { get; set; }

        [Display(Name = "Creation Date")]
        public DateTime CreationDate { get; set; }

        [Display(Name = "Modifier")]
        public string Modifier { get; set; }

        [Display(Name = "ModificationDate")]
        public DateTime ModificationDate { get; set; }
    }
}
