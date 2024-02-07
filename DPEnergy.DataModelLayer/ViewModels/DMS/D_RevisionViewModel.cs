using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.ViewModels.DMS
{
   public class D_RevisionViewModel
   {

        public string Id { get; set; }

        [Display(Name = "ProjectCode")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Enter {0} ")]
        public string ProjectCode { get; set; }

        [Display(Name = "ProjectTitle")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Enter {0} ")]
        public string ProjectTitle { get; set; }

        
        [Display(Name = "DP Number")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Enter {0} ")]
        public string DpNumber { get; set; }
       
        [Display(Name = "Document Title")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Enter {0} ")]
        public string DocumentTitle { get; set; }
        [Display(Name = "Transmittal Number")]
       
        public string TransmittalNumber { get; set; }
        [Display(Name = "Client Number")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Enter {0} ")]
        public string ClientNumber { get; set; }
        [Display(Name = "Company")]
        public string Company { get; set; }

        [Display(Name = "Revision")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Enter {0} ")]

        public string Revision { get; set; }
        [Display(Name = "Stage")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Enter {0} ")]
        public string StageName { get; set; }
        [Display(Name = "Size")]
        public string Size { get; set; }
        [Display(Name = "Transmittal Date")]
        public DateTime? TransmittalDate { get; set; }

        [Display(Name = "Transmittal Created By")]
        public string TransmittalCreatedBy { get; set; }

        [Display(Name = "Page")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Enter {0} ")]
        public string Page{ get; set; }

        [Display(Name = "IssuedBy")]
        public string IssuedBy { get; set; }
        [Display(Name = "Reciever")]
        public string Reciever { get; set; }

        [Display(Name = "Remarks Transmittal")]
        public string RemarksTransmittal { get; set; }
        [Display(Name = "Number of Copies")]
        public string NumberofCopies { get; set; }

        [Display(Name = "Consultant")]
        public string Consultant { get; set; }

        [Display(Name = "Client")]
        public string Client { get; set; }

        [Display(Name = "Sent Type")]
        public string SentType { get; set; }

        [Display(Name = "Progress")]
       
     
        public float? Progress { get; set; }
        [Display(Name = "Classification")]
   
        public string Classification { get; set; }
        [Display(Name = "CheckList")]
      
        public bool CheckList { get; set; }
        [Display(Name = "Incoming Transmittal Check")]
        
        public bool IncomingTransmittalCheck { get; set; }
        [Display(Name = "Dp Dicipline")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Enter {0} ")]

        public string DpDicipline { get; set; }
        [Display(Name = "Client Dicipline")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Enter {0} ")]

        public string ClientDicipline { get; set; }
        [Display(Name = "Prepared By")]
       
        public string PreparedBy { get; set; }
        [Display(Name = "Comm Sheet No.")]
        public string CommentsheetNo { get; set; }
        [Display(Name = "Comm Sheet Date")]
        public DateTime? Commentsheetdate { get; set; }
        [Display(Name = "Comm Sheet Status")]
        public string CommentsheetStatus { get; set; }
        [Display(Name = "Reply Sheet No.")]
        public string RepltysheetNo { get; set; }
        [Display(Name = "Reply Sheet Date")]
        public DateTime? ReplysheetDate { get; set; }
        [Display(Name = "Reply Sheet Status")]
        public string ReplysheetStatus { get; set; }
        [Display(Name = "Ret Rep Sheet No.")]
        public string ReturnedRepltysheetNo { get; set; }
        [Display(Name = "Ret Rep Sheet Date")]
        public DateTime? ReturnedReplysheetDate { get; set; }
        [Display(Name = "Ret Rep Sheet Status")]
        public string ReturnedReplysheetStatus { get; set; }
        [Display(Name = "Related MOM No.")]
        public string RelatedMOMNo { get; set; }
        [Display(Name = "Related MOM Date")]
        public DateTime? RelatedMOMDate { get; set; }
        [Display(Name = "Meeting Held in")]
        public string MeetingHeld { get; set; }
        [Display(Name = "Remark")]
        public string Remark { get; set; }
        [Display(Name = "Custom Field 1")]
        public string CustomField1 { get; set; }
        [Display(Name = "Custom Field 2")]
        public string CustomField2 { get; set; }
        [Display(Name = "Custom Field 3")]
        public string CustomField3 { get; set; }
        [Display(Name = "CustomField 4")]
        public DateTime? CustomField4 { get; set; }
        public string Creator { get; set; }
        public DateTime? CreationDate { get; set; }
        public string Modifier { get; set; }
        public DateTime? ModificationDate { get; set; }

        public bool CD { get; set; }
        public bool Print { get; set; }
        public bool Email { get; set; }
        public bool Other { get; set; }
        public bool Original { get; set; }
        public bool File { get; set; }
      
        public bool Consideration { get; set; }
        [Display(Name = "Attachment")]
        public string Attachment { get; set; }

    }
}
