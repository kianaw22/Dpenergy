using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.Entities
{
    public class P_City
    {
        [Key]
        public string Id { get; set; }

        public String CityName { get; set; }
    }   

}
