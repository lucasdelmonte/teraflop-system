using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.Buys
{
    public class Manage_DetailBuys
    {
        public static MODELO.DetailBuy Get_DetailBuy(int Cod_DetailBuy, CONTEXTO.TeraflopSystem Teraflop)
        {
            return Teraflop.DetailsBuys.Include("oProduct").FirstOrDefault(_ => _.Cod_DetailBuy == Cod_DetailBuy);
        }
        public static List<MODELO.DetailBuy> Get_DetailBuy(CONTEXTO.TeraflopSystem Teraflop)
        {
            return Teraflop.DetailsBuys.ToList();
        }
    }
}
