using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.Buys
{
    public class Operations_DetailDelivery
    {
        public static void Add_DetailDelivery(CONTEXTO.TeraflopSystem Teraflop, MODELO.DetailDelivery DetailDelivery)
        {
            Teraflop.DetailDeliveries.Add(DetailDelivery);
        }
        public static void Delete_DetailDelivery(CONTEXTO.TeraflopSystem Teraflop, MODELO.DetailDelivery DetailDelivery)
        {
            var local = Teraflop.Set<MODELO.DetailDelivery>()
                   .Local
                   .FirstOrDefault(x => x.Cod_DetailDelivery == DetailDelivery.Cod_DetailDelivery);
            if (local != null)
            {
                Teraflop.DetailDeliveries.Attach(local);
                Teraflop.Entry(local).State = System.Data.Entity.EntityState.Deleted;
            }
            else
            {
                Teraflop.DetailDeliveries.Remove(DetailDelivery);
            }
        }
        public static void Modify_DetailDelivery(CONTEXTO.TeraflopSystem Teraflop, MODELO.DetailDelivery DetailDelivery)
        {
            var local = Teraflop.Set<MODELO.DetailDelivery>()
                    .Local
                    .FirstOrDefault(x => x.Cod_DetailDelivery == DetailDelivery.Cod_DetailDelivery);
            if (local != null)
                Teraflop.Entry(local).State = System.Data.Entity.EntityState.Detached;

            Teraflop.Entry(DetailDelivery).State = System.Data.Entity.EntityState.Modified;

        }
    }
}
