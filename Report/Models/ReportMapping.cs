using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Report.Models
{
    public class ReportMapping
    {
        public int ReportId { get; set; }
        public string ReportName { get; set; }
        public string ReportPath { get; set; }


    }
    public class ReportStoredProcedure
    {
        public int StoreProcedureId { get; set; }
        public int ReportId { get; set; }
        public string StoreProcedureName { get; set; }
        public string Datasetname { get; set; }

    }
    public class ReportParameter
    {
        public int ReportMappingId { get; set; }
        public int ReportId { get; set; }
        public string ParameterName { get; set; }
        public string ColumnName { get; set; }
        public string StoreProcedureId { get; set; }
    }
}