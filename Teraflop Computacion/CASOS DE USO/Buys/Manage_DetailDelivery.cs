using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.Buys
{
    public class Manage_DetailDelivery
    {
        public static MODELO.DetailDelivery Get_DetailDelivery(int Cod_DetailDelivery, CONTEXTO.TeraflopSystem Teraflop)
        {
            return Teraflop.DetailDeliveries.Include("oProduct").FirstOrDefault(_ => _.Cod_DetailDelivery == Cod_DetailDelivery);
        }
        public static List<MODELO.DetailDelivery> Get_DetailDelivery(CONTEXTO.TeraflopSystem Teraflop)
        {
            return Teraflop.DetailDeliveries.ToList();
        }
    }
}
