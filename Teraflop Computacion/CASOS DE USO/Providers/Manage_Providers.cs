using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.Providers
{
    public class Manage_Providers
    {
        public static MODELO.Provider Get_Provider(int Cod_Provider, CONTEXTO.TeraflopSystem Teraflop)
        {
            return Teraflop.Providers.Include("Category").FirstOrDefault(_ => _.Cod_Provider == Cod_Provider);
        }
        public static List<MODELO.Provider> Get_Provider(CONTEXTO.TeraflopSystem Teraflop)
        {
            return Teraflop.Providers.ToList();
        }
    }
}
