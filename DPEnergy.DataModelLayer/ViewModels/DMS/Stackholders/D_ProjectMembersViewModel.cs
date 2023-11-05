using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.ViewModels.DMS.Stackholders
{
    public class D_ProjectMembersViewModel
    {
        public string Id { get; set; }

        [Required(ErrorMessage = "{0} is Required")]
        [Display(Name = "Project")]
        public string Project { get; set; }

        [Display(Name = "Company")]
        [Required(ErrorMessage = "{0} is Required")]
        public string Company{ get; set; }

        [Display(Name = "Position")]
        [Required(ErrorMessage = "{0} is Required")]
        public string Position { get; set; }

        [Display(Name = "Person")]
        [Required(ErrorMessage = "{0} is Required")]
        public string Person { get; set; }

        [Display(Name = "Creator")]
        public string Creator { get; set; }

        [Display(Name = "CreationDate")]
        public DateTime? CreationDate { get; set; }

        [Display(Name = "Modifier")]
        public string Modifier { get; set; }

        [Display(Name = "ModificationDate")]
        public DateTime? ModificationDate { get; set; }
    }
}
