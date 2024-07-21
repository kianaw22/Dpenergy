using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.Entities.DMS.BasicInformation
{
    public class D_Project
    {
        [Key]
        public string Id { get; set; }

        public string ProjectCode { get; set; }
        public string Title { get; set; }
        public string PersianTitle { get; set; }
        public string ProjectManager { get; set; }
        public string ProjectType { get; set; }
        public string Contractor { get; set; }
        public string ContractorName { get; set; }
        public string Company { get; set; }
        public string ProjectCost { get; set; }
        public DateTime? ContractDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? CompletionDate { get; set; }
        public string Users { get; set; }
        public string  Activation { get; set; }
        public string Status { get; set; }
        // SERVICE TYPE
        public bool EmkanSanji { get; set; }
        public bool TarahiPaye { get; set; }
        public bool TarahiTafzili { get; set; }
        public bool Kharid { get; set; }
        public bool KhadamatKharid { get; set; }
        public bool TahieAsnadMonaqese { get; set; }
        public bool NezaratAlie { get; set; }
        public bool Karagahi { get; set; }

        public bool EPC { get; set; }
        public bool MTO { get; set; }
        public bool MC { get; set; }
        public bool Gheire { get; set; }

        public bool BaravardHazine { get; set; }
        public string StartUpRequest { get; set; }
        public int? Order { get; set; }
        public string Creator { get; set; }
        public DateTime? CreationDate { get; set;}
        public string Modifier { get; set; }
        public DateTime? ModificationDate { get; set; }
        
        public string Price { get; set; }


    }
}
