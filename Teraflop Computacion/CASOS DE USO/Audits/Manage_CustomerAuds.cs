using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.Audits
{
    public class Manage_CustomerAuds
    {
        public static MODELO.CustomerAud Get_CustomerAud(int Cod_CustomerAud, CONTEXTO.TeraflopSystem Teraflop)
        {
            return Teraflop.CustomersAud.FirstOrDefault(_ => _.Cod_CustomerAud == Cod_CustomerAud);
        }
        public static List<MODELO.CustomerAud> Get_CustomerAud(CONTEXTO.TeraflopSystem Teraflop)
        {
            return Teraflop.CustomersAud.ToList();
        }
    }
}
