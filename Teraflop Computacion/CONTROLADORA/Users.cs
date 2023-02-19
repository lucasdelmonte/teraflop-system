using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class Users
    {
        #region Instancia
        private static Users instancia;
        public static Users Get_Instance()
        {
            if (instancia == null)
                instancia = new Users();
            return instancia;
        }
        #endregion

        #region Variables
        CONTEXTO.TeraflopSystem oContexto;
        #endregion

        private Users()
        {
            oContexto = CONTEXTO.TeraflopSystem.Get_Instance();
        }

        public void Add_User(MODELO.User User)
        {
            try
            {
                CASOS_DE_USO.Users.Operations_Users.Add_User(oContexto, User);
                oContexto.SaveChanges();
            }
            catch {
                // Error
            }
        }
        public void Modify_User(MODELO.User User)
        {
            try
            {
                CASOS_DE_USO.Users.Operations_Users.Modify_User(oContexto, User);
                oContexto.SaveChanges();
            }
            catch  {
                // Error
            }
        }
        public void Delete_User(MODELO.User User)
        {
            try
            {
                CASOS_DE_USO.Users.Operations_Users.Delete_User(oContexto, User);
                oContexto.SaveChanges();
            }
            catch { 
                // Error
            }
        }

        public MODELO.User Get_User(int Cod_User)
        {
            return CASOS_DE_USO.Users.Manage_Users.Get_User(Cod_User, oContexto);
        }
        public List<MODELO.User> Get_User()
        {
            return CASOS_DE_USO.Users.Manage_Users.Get_User(oContexto);
        }
    }
}
