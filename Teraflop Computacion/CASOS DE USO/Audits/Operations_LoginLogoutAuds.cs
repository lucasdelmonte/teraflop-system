using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.Audits
{
    public class Operations_LoginLogoutAuds
    {
        public static void Add_LoginLogoutAud(CONTEXTO.TeraflopSystem Teraflop, MODELO.LoginLogoutAud LoginLogoutAud)
        {
            Teraflop.LoginLogoutAud.Add(LoginLogoutAud);
        }
    }
}
