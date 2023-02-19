using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class Buy
    {
        #region attribute
        public int Cod_Buy { get; set; }
        public string Date { get; set; }
        public List<DetailBuy> DetailBuy { get; set; }
        public List<Delivery> Delivery { get; set; }
        public Provider oProvider { get; set; }
        public string State { get; set; }
        #endregion
    }
}
