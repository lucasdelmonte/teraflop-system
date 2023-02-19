using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class LoginLogoutAuds
    {
        #region instance
        private static LoginLogoutAuds instance;
        public static LoginLogoutAuds Get_Instance()
        {
            if (instance == null)
                instance = new LoginLogoutAuds();
            return instance;
        }
        #endregion

        #region variables
        CONTEXTO.TeraflopSystem oContexto;
        #endregion

        private LoginLogoutAuds()
        {
            oContexto = CONTEXTO.TeraflopSystem.Get_Instance();
        }
        public void Add_LoginLogoutAud(MODELO.LoginLogoutAud LoginLogoutAud)
        {
            try
            {
                CASOS_DE_USO.Audits.Operations_LoginLogoutAuds.Add_LoginLogoutAud(oContexto, LoginLogoutAud);
                oContexto.SaveChanges();
            }
            catch
            {
                // Error
            }
        }
        public MODELO.LoginLogoutAud Get_LoginLogoutAud(int Cod_LoginLogoutAud)
        {
            return CASOS_DE_USO.Audits.Manage_LoginLogoutAuds.Get_LoginLogoutAud(Cod_LoginLogoutAud, oContexto);
        }
        public List<MODELO.LoginLogoutAud> Get_LoginLogoutAud()
        {
            return CASOS_DE_USO.Audits.Manage_LoginLogoutAuds.Get_LoginLogoutAud(oContexto);
        }
    }
}
