using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class Sale
    {
        #region attribute
        public int Cod_Sale { get; set; }
        public string Date { get; set; }
        public List<DetailSale> DetailSale { get; set; }
        public double Total { get; set; }
        public Customer oCustomer { get; set; }
        public string State { get; set; }
        #endregion
    }
}
