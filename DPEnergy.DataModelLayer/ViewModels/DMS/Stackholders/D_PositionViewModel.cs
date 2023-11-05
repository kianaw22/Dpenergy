using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.ViewModels.DMS.Stackholders
{
    public class D_PositionViewModel
    {
        public string Id { get; set; }

        [Display(Name = "Position")]
        public string Position { get; set; }

        [Display(Name = "Creator")]
        public string Creator { get; set; }

        [Display(Name = "CreationDate")]
        public DateTime? CreationDate { get; set; }

        [Display(Name = "Modifier")]
        public string Modifier { get; set; }

        [Display(Name = "ModificationDate")]
        public DateTime? ModificationDate { get; set; }
    }
}
