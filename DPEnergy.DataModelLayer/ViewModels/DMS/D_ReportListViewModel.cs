using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DPEnergy.DataModelLayer.ViewModels.DMS
{
    public class D_ReportListViewModel
    {
        public string Id { get; set; }
        public string ReportName { get; set; }
       
        public string Description { get; set; }

        public string ProjectCode { get; set; }
        public string ReportPath { get; set; }
        public string FileName { get; set; }
    }
}
