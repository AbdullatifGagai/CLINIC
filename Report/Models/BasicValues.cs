using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Report.Models
{
    public class BasicValues
    {
        public int UserId { get; set; }
        public int TenantId { get; set; }
        public string AppId { get; set; }
        public string CInfo { get; set; }
        public string IP { get; set; }
        public ReportValues reportValues { get; set; } 
    }
    public class ReportValues {
        public string Name { get; set; }
        public List<string> Value { get; set; }
    }
}