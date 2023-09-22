using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anystore.BLL
{
    internal class transactionBLL
    {
        public int id { get; set;}
        public string type { get; set; }
        public int dea_cust_id { get; set; }
        public decimal grandtotal { get; set; }
        public DateTime transaction_date { get; set; }
        public decimal tax { get; set; }
        public decimal discount { get; set; }   
        public int added_by { get; set; }
        public DataTable transactiondetails { get; set;  }
    }
}
