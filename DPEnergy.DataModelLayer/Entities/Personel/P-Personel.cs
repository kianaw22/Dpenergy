using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.Entities
{
    public class P_Personel
    {
        [Key]
        public string PersonelCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string HesabDariCode { get; set; }
        public string Father { get; set; }
        public string Gender { get; set; }
        public string ShenasnameNumber { get; set; }
        public string ShenasnameSerial { get; set; }
        public string SodurPlace { get; set; }
        public string Mellicode { get; set; }
        public string BirthPlace { get; set; }
        public DateTime? BirthDate { get; set; }
        public string PBirthDate { get; set; }
        public string MaritalStatus { get; set; }
        public string Department { get; set; }
        public DateTime? StartWorkDate { get; set; }
        public string PStartWorkDate { get; set; }
        public string ContractType { get; set; }
        public string Company { get; set; }
        public string WorkPlace { get; set; }

        public string VaziatEshteqal { get; set; }
        public string JobCategory { get; set; }
        public DateTime? TasfieDate { get; set; }
        public string PTasfieDate { get; set; }
        public string ElatTarkKar { get; set; }
        public string Cover { get; set; }
        public string Moaref { get; set; }
        public string PhoneNumber { get; set; }
        public string Post { get; set; }
        public string MahalKhedmat { get; set; }
        public string Address { get; set; }
        public string Introduction { get; set; }
        public string BloodType { get; set; }
        public string SpecialDrug { get; set; }
        public string Sickness { get; set; }
        public string SaqfKarkard { get; set; }
        public string Overtime { get; set; }
        public string ShenasnameScanPath { get; set; }
        public string MelliScanPath { get; set; }
        public string PersonalImagePath { get; set; }
        public string SignaturePath { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }
        public string Creator { get; set; }
        public string Modifier { get; set; }
         public string Note { get; set; }
    }
}
