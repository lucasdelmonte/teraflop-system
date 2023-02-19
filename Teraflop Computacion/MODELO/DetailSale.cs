using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class DetailSale
    {
        #region attribute
        public int Cod_DetailSale { get; set; }
        public Product oProduct { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
        public decimal Total { get; set; }
        #endregion

        #region method
        public override string ToString()
        {
            return oProduct.Name;
        }
        #endregion
    }
}
