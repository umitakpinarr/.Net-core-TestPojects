using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mulk.Models
{
    public class rents
    {


        public int Id { get; set; }
        public string Name { get; set; }
        public string function { get; set; }
        public bool status { get; set; }
        public int  price { get; set; }
        public string  adress { get; set; }
        public int tenantId { get; set; }
        

    }
}
