using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatabaseTVP_Core;
using Logger_Core;

namespace ZCLINIC.Areas.Transaction.Models
{
    public class MonthlyProDetail
    {

        private const string MODULE = "Transaction";


        [TVP]

        public int ID { get; set; }
        [TVP]
        public int   UnitId { get; set; }

        [TVP]
        public decimal DisP { get; set; }
        [TVP]
        public decimal DisAmt { get; set; }
        [TVP]
        public decimal StaxP { get; set; }
        [TVP]
        public decimal StaxAmt { get; set; }
        [TVP]
        public decimal Amt { get; set; }



        [TVP]
        public int TenantId { get; set; }

        [TVP]
        public string AppId { get; set; }

        [TVP]
        public int CreatedBy { get; set; }

        [TVP]
        public int ModifiedBy { get; set; }



        public string UnitName { get; set; }
    }
}
