using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.Features.Marks
{
    public class Operations_Marks
    {
        public static void Add_Mark(CONTEXTO.TeraflopSystem Teraflop, MODELO.Mark Mark)
        {
            Teraflop.Marks.Add(Mark);
        }
        public static void Delete_Mark(CONTEXTO.TeraflopSystem Teraflop, MODELO.Mark Mark)
        {
            var local = Teraflop.Set<MODELO.Mark>()
                   .Local
                   .FirstOrDefault(x => x.Cod_Mark == Mark.Cod_Mark);
            if (local != null)
            {
                Teraflop.Marks.Attach(local);
                Teraflop.Entry(local).State = System.Data.Entity.EntityState.Deleted;
            }
            else
            {
                Teraflop.Marks.Remove(Mark);
            }
        }
        public static void Modify_Mark(CONTEXTO.TeraflopSystem Teraflop, MODELO.Mark Mark)
        {
            var local = Teraflop.Set<MODELO.Mark>()
                    .Local
                    .FirstOrDefault(x => x.Cod_Mark == Mark.Cod_Mark);
            if (local != null)
                Teraflop.Entry(local).State = System.Data.Entity.EntityState.Detached;

            Teraflop.Entry(Mark).State = System.Data.Entity.EntityState.Modified;

        }
    }
}
