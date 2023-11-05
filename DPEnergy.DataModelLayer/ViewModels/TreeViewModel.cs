using System;
using System.Collections.Generic;
using System.Text;

namespace DPEnergy.DataModelLayer.ViewModels
{
   public class TreeViewModel
    {
        public string id { get; set; }
        public string parent { get; set; }
        public string text { get; set; }
    }
}