using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.Sales
{
    public class Operations_Sales
    {
        public static void Add_Sale(CONTEXTO.TeraflopSystem Teraflop, MODELO.Sale Sale)
        {
            Teraflop.Sales.Add(Sale);
        }
        public static void Delete_Sale(CONTEXTO.TeraflopSystem Teraflop, MODELO.Sale Sale)
        {
            var local = Teraflop.Set<MODELO.Sale>()
                   .Local
                   .FirstOrDefault(x => x.Cod_Sale == Sale.Cod_Sale);
            if (local != null)
            {
                Teraflop.Sales.Attach(local);
                Teraflop.Entry(local).State = System.Data.Entity.EntityState.Deleted;
            }
            else
            {
                Teraflop.Sales.Remove(Sale);
            }
        }
        public static void Modify_Sale(CONTEXTO.TeraflopSystem Teraflop, MODELO.Sale Sale)
        {
            var local = Teraflop.Set<MODELO.Sale>()
                    .Local
                    .FirstOrDefault(x => x.Cod_Sale == Sale.Cod_Sale);
            if (local != null)
                Teraflop.Entry(local).State = System.Data.Entity.EntityState.Detached;

            Teraflop.Entry(Sale).State = System.Data.Entity.EntityState.Modified;

        }
    }
}
