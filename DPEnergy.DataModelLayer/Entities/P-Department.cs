using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace DPEnergy.DataModelLayer.Entities
{
    public class P_Department
    {
        [Key]
        public String Id { get; set; }
        public string DepartmentCode { get; set; }
        public String DepartmentName { get; set; }
        public String DepartmentMokhafaf{ get; set; }
        public String DepaertmentPersianName { get; set; }
    }
}
