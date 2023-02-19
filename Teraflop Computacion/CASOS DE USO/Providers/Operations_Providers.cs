using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.Providers
{
    public class Operations_Providers
    {
        public static void Add_Provider(CONTEXTO.TeraflopSystem Teraflop, MODELO.Provider Provider)
        {
            Teraflop.Providers.Add(Provider);
        }
        public static void Delete_Provider(CONTEXTO.TeraflopSystem Teraflop, MODELO.Provider Provider)
        {
            var local = Teraflop.Set<MODELO.Provider>()
                   .Local
                   .FirstOrDefault(x => x.Cod_Provider == Provider.Cod_Provider);
            if (local != null)
            {
                Teraflop.Providers.Attach(local);
                Teraflop.Entry(local).State = System.Data.Entity.EntityState.Deleted;
            }
            else
            {
                Teraflop.Providers.Remove(Provider);
            }
        }
        public static void Modify_Provider(CONTEXTO.TeraflopSystem Teraflop, MODELO.Provider Provider)
        {
            var local = Teraflop.Set<MODELO.Provider>()
                    .Local
                    .FirstOrDefault(x => x.Cod_Provider == Provider.Cod_Provider);
            if (local != null)
                Teraflop.Entry(local).State = System.Data.Entity.EntityState.Detached;

            Teraflop.Entry(Provider).State = System.Data.Entity.EntityState.Modified;

        }
    }
}
