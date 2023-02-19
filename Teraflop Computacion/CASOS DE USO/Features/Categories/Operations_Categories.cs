using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.Features.Categories
{
    public class Operations_Categories
    {
        public static void Add_Category(CONTEXTO.TeraflopSystem Teraflop, MODELO.Category Category)
        {
            Teraflop.Categories.Add(Category);
        }
        public static void Delete_Category(CONTEXTO.TeraflopSystem Teraflop, MODELO.Category Category)
        {
            var local = Teraflop.Set<MODELO.Category>()
                   .Local
                   .FirstOrDefault(x => x.Cod_Category == Category.Cod_Category);
            if (local != null)
            {
                Teraflop.Categories.Attach(local);
                Teraflop.Entry(local).State = System.Data.Entity.EntityState.Deleted;
            }
            else
            {
                Teraflop.Categories.Remove(Category);
            }
        }
        public static void Modify_Category(CONTEXTO.TeraflopSystem Teraflop, MODELO.Category Category)
        {
            var local = Teraflop.Set<MODELO.Category>()
                    .Local
                    .FirstOrDefault(x => x.Cod_Category == Category.Cod_Category);
            if (local != null)
                Teraflop.Entry(local).State = System.Data.Entity.EntityState.Detached;

            Teraflop.Entry(Category).State = System.Data.Entity.EntityState.Modified;

        }
    }
}
