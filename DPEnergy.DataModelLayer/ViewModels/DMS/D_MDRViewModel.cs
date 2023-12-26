using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.ViewModels.DMS
{
    public class D_MDRViewModel
    {
        public string Id { get; set; }
        public string ProjectTitle { get; set; }


        [Display(Name = "ProjectCode")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Enter {0} ")]
        public string ProjectCode { get; set; }

        [Display(Name = "ClientNumber")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Enter {0} ")]
        public string ClientNumber { get; set; }

        [Display(Name = "DocumentTitle")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Enter {0} ")]
        public string DocumentTitle { get; set; }

        [Display(Name = "DaryapalaNumber")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Enter {0} ")]
        public string DaryapalaNumber { get; set; }

        [Display(Name = "WF")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Enter {0} ")]
        public float WF { get; set; }

        [Display(Name = "DpDicipline")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Enter {0} ")]
        public string DpDicipline { get; set; }

        [Display(Name = "Unit")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Enter {0} ")]
        public string Unit { get; set; }

        [Display(Name = "Phase")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Enter {0} ")]
        public string Phase { get; set; }

        [Display(Name = "ClientDicipline")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Enter {0} ")]
        public string ClientDicipline { get; set; }

        [Display(Name = "DocumentType")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Enter {0} ")]
        public string DocumentType { get; set; }

        [Display(Name = "Bidover")]
        public string Bidover { get; set; }

        [Display(Name = "Classification")]
        public string Classification { get; set; }

        [Display(Name = "AdditionalWork")]
        public string AdditionalWork { get; set; }

        [Display(Name = "FirstIssueDate")]
        public DateTime? FirstIssueDate { get; set; }

        [Display(Name = "SecondIssueDate")]
        public DateTime? SecondIssueDate { get; set; }

        [Display(Name = "FinalIssueDate")]
        public DateTime? FinalIssueDate { get; set; }

        [Display(Name = "CustomField1")]
        public string CustomField1 { get; set; }

        [Display(Name = "CustomField2")]
        public string CustomField2 { get; set; }

        [Display(Name = "CustomField3")]
        public DateTime? CustomField3 { get; set; }

        [Display(Name = "CustomField4")]
        public DateTime? CustomField4 { get; set; }
        [Display(Name = "CustomField5")]
        public string CustomField5{ get; set; }

        [Display(Name = "Active")]
        public string Active { get; set; }

        [Display(Name = "Remarks")]
        public string Remarks { get; set; }

        [Display(Name = "User")]
        public string User { get; set; }

        [Display(Name = "Area")]
        public string Area { get; set; }

        [Display(Name = "Section")]
        public string Section { get; set; }
        [Display(Name = "MHR")]
        public float MHR { get; set; }

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
