using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.Deliveries
{
    public class Operations_Deliveries
    {
        public static void Add_Delivery(CONTEXTO.TeraflopSystem Teraflop, MODELO.Delivery Delivery)
        {
            Teraflop.Deliveries.Add(Delivery);
        }
        public static void Delete_Delivery(CONTEXTO.TeraflopSystem Teraflop, MODELO.Delivery Delivery)
        {
            var local = Teraflop.Set<MODELO.Delivery>()
                   .Local
                   .FirstOrDefault(x => x.Cod_Delivery == Delivery.Cod_Delivery);
            if (local != null)
            {
                Teraflop.Deliveries.Attach(local);
                Teraflop.Entry(local).State = System.Data.Entity.EntityState.Deleted;
            }
            else
            {
                Teraflop.Deliveries.Remove(Delivery);
            }
        }
        public static void Modify_Delivery(CONTEXTO.TeraflopSystem Teraflop, MODELO.Delivery Delivery)
        {
            var local = Teraflop.Set<MODELO.Delivery>()
                    .Local
                    .FirstOrDefault(x => x.Cod_Delivery == Delivery.Cod_Delivery);
            if (local != null)
                Teraflop.Entry(local).State = System.Data.Entity.EntityState.Detached;

            Teraflop.Entry(Delivery).State = System.Data.Entity.EntityState.Modified;

        }
    }
}
