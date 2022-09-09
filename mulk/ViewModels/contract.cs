using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mulk.ViewModels
{
    public class contract
    {

        public int Id { get; set; }
        public int tenantId { get; set; }
        public string rentName { get; set; }
        public string rentfunction { get; set; }
        public bool rentstatus { get; set; }
        public int rentprice { get; set; }
        public string rentadress { get; set; }
        public string tenantName { get; set; }
        public string tenantSurname { get; set; }
        public string tenantPhone { get; set; }
        public string tenantmail { get; set; }

    }
}
