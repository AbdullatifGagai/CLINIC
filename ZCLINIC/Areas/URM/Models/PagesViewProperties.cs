using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZCLINIC.Areas.URM.Models
{
    public class PagesViewProperties
    {

        public string IsCreate { get; set; }
        public string IsUpdate { get; set; }
        public string IsRead { get; set; }

        public string IsDelete { get; set; }

        public string IsModal { get; set; }

        public string MenuName { get; set; }

        public string IsView { get; set; }




        public int CreateId { get; set; }
        public int UpdateId { get; set; }
        public int ReadId { get; set; }

        public int DeleteId { get; set; }

        public int ModalId { get; set; }

        public string ViewId { get; set; }
     
    }
}
