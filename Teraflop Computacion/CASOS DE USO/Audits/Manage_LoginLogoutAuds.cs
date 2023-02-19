using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.Audits
{
    public class Manage_LoginLogoutAuds
    {
        public static MODELO.LoginLogoutAud Get_LoginLogoutAud(int Cod_LoginLogoutAud, CONTEXTO.TeraflopSystem Teraflop)
        {
            return Teraflop.LoginLogoutAud.FirstOrDefault(_ => _.Cod_LoginLogoutAud == Cod_LoginLogoutAud);
        }
        public static List<MODELO.LoginLogoutAud> Get_LoginLogoutAud(CONTEXTO.TeraflopSystem Teraflop)
        {
            return Teraflop.LoginLogoutAud.ToList();
        }
    }
}
