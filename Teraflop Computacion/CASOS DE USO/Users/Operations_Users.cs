using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.Users
{
    public class Operations_Users
    {
        public static void Add_User(CONTEXTO.TeraflopSystem Teraflop, MODELO.User User)
        {
            Teraflop.Users.Add(User);
        }
        public static void Delete_User(CONTEXTO.TeraflopSystem Teraflop, MODELO.User User)
        {
            Teraflop.Users.Remove(User);
        }
        public static void Modify_User(CONTEXTO.TeraflopSystem Teraflop, MODELO.User User)
        {
            Teraflop.Entry(User).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
