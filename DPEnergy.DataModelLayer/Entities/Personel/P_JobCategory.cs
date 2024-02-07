using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.Entities
{
   public class P_JobCategory
    {
        [Key]
        public String Id { get; set; }
        public String JobCategoryName { get; set; }
    }
}
