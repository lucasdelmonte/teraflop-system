using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.Buys
{
    public class Operations_Buys
    {
        public static void Add_Buy(CONTEXTO.TeraflopSystem Teraflop, MODELO.Buy Buy)
        {
            Teraflop.Buys.Add(Buy);
        }
        public static void Delete_Buy(CONTEXTO.TeraflopSystem Teraflop, MODELO.Buy Buy)
        {
            var local = Teraflop.Set<MODELO.Buy>()
                   .Local
                   .FirstOrDefault(x => x.Cod_Buy == Buy.Cod_Buy);
            if (local != null)
            {
                Teraflop.Buys.Attach(local);
                Teraflop.Entry(local).State = System.Data.Entity.EntityState.Deleted;
            }
            else
            {
                Teraflop.Buys.Remove(Buy);
            }
        }
        public static void Modify_Buy(CONTEXTO.TeraflopSystem Teraflop, MODELO.Buy Buy)
        {
            var local = Teraflop.Set<MODELO.Buy>()
                    .Local
                    .FirstOrDefault(x => x.Cod_Buy == Buy.Cod_Buy);
            if (local != null)
                Teraflop.Entry(local).State = System.Data.Entity.EntityState.Detached;

            Teraflop.Entry(Buy).State = System.Data.Entity.EntityState.Modified;

        }
    }
}
