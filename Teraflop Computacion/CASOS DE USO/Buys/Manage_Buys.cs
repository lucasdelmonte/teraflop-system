using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.Buys
{
    public class Manage_Buys
    {
        public static MODELO.Buy Get_Buy(int Cod_Buy, CONTEXTO.TeraflopSystem Teraflop)
        {
            return Teraflop.Buys.Include("DetailBuy").Include("oCustomer").FirstOrDefault(_ => _.Cod_Buy == Cod_Buy);
        }
        public static List<MODELO.Buy> Get_Buy(CONTEXTO.TeraflopSystem Teraflop)
        {
            return Teraflop.Buys.ToList();
        }
    }
}
