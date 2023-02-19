using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.Sales
{
    public class Operations_DetailSales
    {
        public static void Add_DetailSale(CONTEXTO.TeraflopSystem Teraflop, MODELO.DetailSale DetailSale)
        {
            Teraflop.DetailsSales.Add(DetailSale);
        }
        public static void Delete_DetailSale(CONTEXTO.TeraflopSystem Teraflop, MODELO.DetailSale DetailSale)
        {
            var local = Teraflop.Set<MODELO.DetailSale>()
                   .Local
                   .FirstOrDefault(x => x.Cod_DetailSale == DetailSale.Cod_DetailSale);
            if (local != null)
            {
                Teraflop.DetailsSales.Attach(local);
                Teraflop.Entry(local).State = System.Data.Entity.EntityState.Deleted;
            }
            else
            {
                Teraflop.DetailsSales.Remove(DetailSale);
            }
        }
        public static void Modify_DetailSale(CONTEXTO.TeraflopSystem Teraflop, MODELO.DetailSale DetailSale)
        {
            var local = Teraflop.Set<MODELO.DetailSale>()
                    .Local
                    .FirstOrDefault(x => x.Cod_DetailSale == DetailSale.Cod_DetailSale);
            if (local != null)
                Teraflop.Entry(local).State = System.Data.Entity.EntityState.Detached;

            Teraflop.Entry(DetailSale).State = System.Data.Entity.EntityState.Modified;

        }
    }
}
