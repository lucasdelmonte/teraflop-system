using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.Deliveries
{
    public class Manage_Deliveries
    {
        public static MODELO.Delivery Get_Delivery(int Cod_Delivery, CONTEXTO.TeraflopSystem Teraflop)
        {
            return Teraflop.Deliveries.Include("oProduct").FirstOrDefault(_ => _.Cod_Delivery == Cod_Delivery);
        }
        public static List<MODELO.Delivery> Get_Delivery(CONTEXTO.TeraflopSystem Teraflop)
        {
            return Teraflop.Deliveries.ToList();
        }
    }
}
