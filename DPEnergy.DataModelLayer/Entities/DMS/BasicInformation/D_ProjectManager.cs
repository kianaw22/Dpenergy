using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.Entities.DMS.BasicInformation
{
    public class D_ProjectManager
    {
        [Key]
        public string Id { get; set; }
        public string ProjectManager { get; set; }
    }
}
