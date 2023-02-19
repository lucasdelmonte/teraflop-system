using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.Audits
{
    public class Operations_CustomerAuds
    {
        public static void Add_CustomerAud(CONTEXTO.TeraflopSystem Teraflop, MODELO.CustomerAud CustomerAud)
        {
            Teraflop.CustomersAud.Add(CustomerAud);
        }
    }
}

