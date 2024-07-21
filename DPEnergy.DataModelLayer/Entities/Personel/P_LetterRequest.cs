using System;
using System.Collections.Generic;
using System.Text;

namespace DPEnergy.DataModelLayer.Entities.Personel
{
    public class P_LetterRequest
    {
        [key]
        public string Id { get; set; }
        public string PersonelCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }
        public string Reciever { get; set; }
        public DateTime? IssueDate { get; set; }
        public string Attachment { get; set; }
        public int Counter { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }
        public string Creator { get; set; }
        public string Modifier { get; set; }
    }
}
