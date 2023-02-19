using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.Buys
{
    public class Operations_DetailBuys
    {
        public static void Add_DetailBuy(CONTEXTO.TeraflopSystem Teraflop, MODELO.DetailBuy DetailBuy)
        {
            Teraflop.DetailsBuys.Add(DetailBuy);
        }
        public static void Delete_DetailBuy(CONTEXTO.TeraflopSystem Teraflop, MODELO.DetailBuy DetailBuy)
        {
            var local = Teraflop.Set<MODELO.DetailBuy>()
                   .Local
                   .FirstOrDefault(x => x.Cod_DetailBuy == DetailBuy.Cod_DetailBuy);
            if (local != null)
            {
                Teraflop.DetailsBuys.Attach(local);
                Teraflop.Entry(local).State = System.Data.Entity.EntityState.Deleted;
            }
            else
            {
                Teraflop.DetailsBuys.Remove(DetailBuy);
            }
        }
        public static void Modify_DetailBuy(CONTEXTO.TeraflopSystem Teraflop, MODELO.DetailBuy DetailBuy)
        {
            var local = Teraflop.Set<MODELO.DetailBuy>()
                    .Local
                    .FirstOrDefault(x => x.Cod_DetailBuy == DetailBuy.Cod_DetailBuy);
            if (local != null)
                Teraflop.Entry(local).State = System.Data.Entity.EntityState.Detached;

            Teraflop.Entry(DetailBuy).State = System.Data.Entity.EntityState.Modified;

        }
    }
}
