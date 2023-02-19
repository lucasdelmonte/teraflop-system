using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.Features.Models
{
    public class Operations_Models
    {
        public static void Add_Model(CONTEXTO.TeraflopSystem Teraflop, MODELO.Model Model)
        {
            Teraflop.Models.Add(Model);
        }
        public static void Delete_Model(CONTEXTO.TeraflopSystem Teraflop, MODELO.Model Model)
        {
            var local = Teraflop.Set<MODELO.Model>()
                   .Local
                   .FirstOrDefault(x => x.Cod_Model == Model.Cod_Model);
            if (local != null)
            {
                Teraflop.Models.Attach(local);
                Teraflop.Entry(local).State = System.Data.Entity.EntityState.Deleted;
            }
            else
            {
                Teraflop.Models.Remove(Model);
            }
        }
        public static void Modify_Model(CONTEXTO.TeraflopSystem Teraflop, MODELO.Model Model)
        {
            var local = Teraflop.Set<MODELO.Model>()
                    .Local
                    .FirstOrDefault(x => x.Cod_Model == Model.Cod_Model);
            if (local != null)
                Teraflop.Entry(local).State = System.Data.Entity.EntityState.Detached;

            Teraflop.Entry(Model).State = System.Data.Entity.EntityState.Modified;

        }
    }
}
