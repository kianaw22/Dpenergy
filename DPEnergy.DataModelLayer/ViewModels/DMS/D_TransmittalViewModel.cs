using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.ViewModels.DMS
{
   public  class D_TransmittalViewModel
    {
        public string Id { get; set; }

        [Display(Name = "ProjectCode")]
        public string ProjectCode { get; set; }

        [Display(Name = "Client Number")]
        public string ClientNumber { get; set; }

        [Display(Name = "Revision")]
        public string Revision { get; set; }

        [Display(Name = "Stage")]
        public string Stage { get; set; }

        [Display(Name = "Dp Dicipline")]
        public string DpDicipline { get; set; }

        [Display(Name = "Client Dicipline")]
        public string ClientDicipline { get; set; }

        [Display(Name = "Transmittal NO.")]
        public string TransmittalNO { get; set; }

        [Display(Name = "Transmittal Date")]
        public DateTime TransmittalDate { get; set; }

        [Display(Name = "Consultant")]
        public string Consultant { get; set; }

        [Display(Name = "Client")]
        public string Client { get; set; }

        [Display(Name = "IssuedBy")]
        public string IssuedBy { get; set; }

        [Display(Name = "Reciever")]
        public string Reciever { get; set; }

        [Display(Name = "Number of Copies")]
        public string NumberofCopies { get; set; }

        [Display(Name = "Sent Type")]
        public string SentType { get; set; }

        [Display(Name = "Remark")]
        public string Remark { get; set; }
    }
}
