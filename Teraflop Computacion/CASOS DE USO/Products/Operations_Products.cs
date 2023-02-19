using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.Products
{
    public class Operations_Products
    {
        public static void Add_Product(CONTEXTO.TeraflopSystem Teraflop, MODELO.Product Product)
        {
            Teraflop.Products.Add(Product);
        }
        public static void Delete_Product(CONTEXTO.TeraflopSystem Teraflop, MODELO.Product Product)
        {
            var local = Teraflop.Set<MODELO.Product>()
                   .Local
                   .FirstOrDefault(x => x.Cod_Product == Product.Cod_Product);
            if (local != null)
            {
                Teraflop.Products.Attach(local);
                Teraflop.Entry(local).State = System.Data.Entity.EntityState.Deleted;
            }
            else
            {
                Teraflop.Products.Remove(Product);
            }
        }
        public static void Modify_Product(CONTEXTO.TeraflopSystem Teraflop, MODELO.Product Product)
        {
            /*
            var local = Teraflop.Set<MODELO.Product>()
                    .Local
                    .FirstOrDefault(x => x.Cod_Product == Product.Cod_Product);
            if (local != null)
                Teraflop.Entry(local).State = System.Data.Entity.EntityState.Detached;
            */
            Teraflop.Entry(Product).State = System.Data.Entity.EntityState.Modified;

        }
    }
}
