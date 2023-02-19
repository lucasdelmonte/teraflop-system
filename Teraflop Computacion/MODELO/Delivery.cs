using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class Delivery
    {
        #region attribute
        public int Cod_Delivery { get; set; }
        public List<DetailDelivery> DetailDelivery { get; set; }
        public string Date { get; set; }
        #endregion
    }
}
