using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.Entities.Personel
{
    public class P_BankAccountDetails
    {
        [Key]
        public string Id { get; set; }
        public string PersonelCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BankAccountNumber { get; set; }
        public string BankName { get; set; }
        public string Accounttype { get; set; }
        public string CardNumber { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }
        public string Creator { get; set; }
        public string Modifier { get; set; }

    }
}
