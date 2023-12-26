using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.ViewModels.DMS.BasicInformation
{
    public class D_UserProjectViewModel
    {
        public string Id { get; set; }

        [Display(Name = "User")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Enter {0} ")]
        public string UserId { get; set; }

        public string ProjectTitle { get; set; }
        [Display(Name = "Project")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Enter {0} ")]
        public string ProjectId { get; set; }
        public string UserName { get; set; }

     
        public string ProjectCode { get; set; }
        public string Creator { get; set; }
        public DateTime? CreationDate { get; set; }
        public string Modifier { get; set; }
        public DateTime? ModificationDate { get; set; }
    }
}
