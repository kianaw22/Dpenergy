﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.ViewModels.DMS.BasicInformation
{
    public class D_ProjectViewModel
    {
       
        public string Id { get; set; }


        [Display(Name = "Project Code")]
        [StringLength(maximumLength: 10, MinimumLength = 4, ErrorMessage = "{0} باید حداقل 4 و حداکثر 10 کاراکتر باشد.")]
        public string ProjectCode { get; set; }

        [Display(Name = "Title")]
        [StringLength(maximumLength: 100, ErrorMessage = "{0} باید  حداکثر 100 کاراکتر باشد.")]
        public string Title { get; set; }


        [Display(Name = "Persian Title")]
        public string PersianTitle { get; set; }

        [StringLength(maximumLength:100, ErrorMessage = "{0} باید  حداکثر 20 کاراکتر باشد.")]
        [Display(Name = "Project Manager")]
        public string ProjectManager { get; set; }

        [Display(Name = "Project Type")]
    
        public string ProjectType { get; set; }

        [Display(Name = "Contarctor Company")]
        [StringLength(maximumLength: 100, ErrorMessage = "{0} باید  حداکثر 20 کاراکتر باشد.")]
        public string Contractor { get; set; }

        [Display(Name = "Contractor's Name ")]
        public string ContractorName { get; set; }
        [StringLength(maximumLength: 100, ErrorMessage = "{0} باید  حداکثر 20 کاراکتر باشد.")]

        [Display(Name = "Company")]
        public string Company { get; set; }

        [Display(Name = "Project Cost")]
        [StringLength(maximumLength: 100, ErrorMessage = "{0} باید  حداکثر 20 کاراکتر باشد.")]
        public string ProjectCost { get; set; }

        [Display(Name = "Contract Date")]
        public DateTime? ContractDate { get; set; }

        [Display(Name = "Start Date")]
        public DateTime? StartDate { get; set; }

        [Display(Name = "Completion Date")]
        public DateTime? CompletionDate { get; set; }

        [Display(Name = "Users")]
        public string Users { get; set; }

        [Display(Name = "Activation")]
        public string Activation { get; set; }

        [Display(Name = "Status")]
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
        //

        [Display(Name = "StartUp Request")]
        public string StartUpRequest { get; set; }

        [Display(Name = "Order")]
        public int? Order { get; set; }

        [Display(Name = "Creator")]
        public string Creator { get; set; }

        [Display(Name = "Creation Date")]
        public DateTime? CreationDate { get; set; }

        [Display(Name = "Modifier")]
        public string Modifier { get; set; }

        [Display(Name = "Modification Date")]
        public DateTime? ModificationDate { get; set; }
    }
}
