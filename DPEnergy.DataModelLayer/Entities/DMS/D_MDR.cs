using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.Entities.DMS
{
    public class D_MDR
    {
        [Key]
        public string Id { get; set; }
        public string ProjectCode { get; set; }
        public string ClientNumber { get; set; }
        public string DocumentTitle { get; set; }
        public string DaryapalaNumber { get; set; }
        public float? WF { get; set; }
        public string DpDicipline { get; set; }
        public string Unit { get; set; }
        public string Phase { get; set; }
        public string DocumentType { get; set; }
        public string Bidover { get; set; }
        public string ClientDicipline { get; set; }
        public string Classification { get; set; }
        public string AdditionalWork { get; set; }
        public DateTime? FirstIssueDate { get; set; }
        public DateTime? SecondIssueDate { get; set; }
        public DateTime? FinalIssueDate { get; set; }
        public string CustomField1 { get; set; }
        public string CustomField2 { get; set; }
        public DateTime? CustomField3 { get; set; }
        public DateTime? CustomField4 { get; set; }
        public string CustomField5 { get; set; }
        public string Active { get; set; }
        public string Remarks { get; set; }
        public string User { get; set; }
        public string Area { get; set; }
        public string Section { get; set; }
        public float? MHR { get; set; }
        public string Creator { get; set; }
        public DateTime? CreationDate { get; set; }
        public string Modifier { get; set; }
        public DateTime? ModificationDate { get; set; }


    }
}
