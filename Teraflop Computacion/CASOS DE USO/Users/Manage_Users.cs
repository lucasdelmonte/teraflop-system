using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.Users
{
    public class Manage_Users
    {
        public static MODELO.User Get_User(int Cod_User, CONTEXTO.TeraflopSystem Teraflop)
        {
            return Teraflop.Users.FirstOrDefault(_ => _.Cod_User == Cod_User);
        }
        public static List<MODELO.User> Get_User(CONTEXTO.TeraflopSystem Teraflop)
        {
            return Teraflop.Users.ToList();
        }
    }
}
