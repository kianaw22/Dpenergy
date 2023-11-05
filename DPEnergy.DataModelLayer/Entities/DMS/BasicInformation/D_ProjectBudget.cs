using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.Entities.DMS.BasicInformation
{
    public class D_ProjectBudget
    {
        [Key]
        public string Id { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectTitle { get; set; }
        public string Department { get; set; }
        public string DepartmentalBudget { get; set; }
        public string TotalBudget { get; set; }
        public string OverTimeOrDeduction {get;set;}
        public string Creator { get; set; }
        public DateTime CreationDate { get; set; }
        public string Modifier { get; set; }
        public DateTime ModificationDate { get; set; }

    }
}
