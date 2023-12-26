using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.ViewModels.DMS.BasicInformation
{
    public class D_ProjectBudgetViewModel
    {
        public string Id { get; set; }
       
        [Display(Name = "Project Code")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Enter {0} ")]
        public string ProjectCode { get; set; }

        [Display(Name = "Project Title")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Enter {0} ")]
        public string ProjectTitle { get; set; }

      
        [Display(Name = "Department")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Enter {0} ")]
        public string Department { get; set; }

        
        [Display(Name = "Departmental Budget")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Enter {0} ")]
        public string DepartmentalBudget { get; set; }

        [Display(Name = "Total Budget")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Enter {0} ")]
        public string TotalBudget { get; set; }

        [Display(Name = "OverTime/Deduction")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Enter {0} ")]
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
