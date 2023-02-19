using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class DetailDelivery
    {
        #region attribute
        public int Cod_DetailDelivery { get; set; }
        public Product oProduct { get; set; }
        public int Amount { get; set; }
        #endregion

        #region method
        public override string ToString()
        {
            return oProduct.Name;
        }
        #endregion
    }
}
