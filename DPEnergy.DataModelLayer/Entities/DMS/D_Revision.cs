using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DPEnergy.DataModelLayer.Entities.DMS
{
    public class D_Revision
    {
      [Key]
       public string Id { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectTitle { get; set; }
        public string TransmittalNumber { get; set; }
        public string DpNumber { get; set; }
        public string DocumentTitle { get; set; }
        public string ClientNumber { get; set; }
        public string Revision { get; set; }
        public string StageName { get; set; }
        public string Company { get; set; }
        public string Classification { get; set; }
        public string CommentsheetNo { get; set; }
        public DateTime? Commentsheetdate { get; set; }
        public string CommentsheetStatus { get; set; }
        public string RepltysheetNo { get; set; }
        public DateTime? ReplysheetDate { get; set; }
        public string ReplysheetStatus { get; set; }
        public string ReturnedRepltysheetNo { get; set; }
        public DateTime? ReturnedReplysheetDate { get; set; }
        public string ReturnedReplysheetStatus { get; set; }
        public string RelatedMOMNo { get; set; }
        public DateTime? RelatedMOMDate { get; set; }
        public string Remark { get; set; }
        public float? Progress { get; set; }
        public string Size { get; set; }
        public DateTime? TransmittalDate { get; set; }
        public string TransmittalCreatedBy { get; set; }
        public string Page { get; set; }
        public string IssuedBy { get; set; }
        public string Reciever { get; set; }
        public string RemarksTransmittal { get; set; }
        public string NumberofCopies { get; set; }
        public string Consultant { get; set; }
        public string Client { get; set; }
        public string SentType { get; set; }
        public string CustomField1 { get; set; }
        public string CustomField2 { get; set; }
        public string CustomField3 { get; set; }
        public DateTime? CustomField4 { get; set; }
        public string PreparedBy { get; set; }
        public string MeetingHeld { get; set; }
        public string DpDicipline { get; set; }
        public string ClientDicipline { get; set; }
        public bool? CheckList { get; set; }
        public bool? IncomingTransmittalCheck { get; set; }
        public string Creator { get; set; }
        public DateTime? CreationDate { get; set; }
        public string Modifier { get; set; }
        public DateTime? ModificationDate { get; set; }
        public bool? CD { get; set; }
        public bool? Print { get; set; }
        public bool? Email { get; set; }
        public bool? Other { get; set; }
        public bool? Original { get; set; }
        public bool? File { get; set; }

        public bool? Consideration { get; set; }
        public string Attachment { get; set; }
        public string ProgressId { get; set; }



    }
}
