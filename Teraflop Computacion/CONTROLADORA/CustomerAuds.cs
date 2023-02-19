using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class CustomerAuds
    {
        #region instance
        private static CustomerAuds instance;
        public static CustomerAuds Get_Instance()
        {
            if (instance == null)
                instance = new CustomerAuds();
            return instance;
        }
        #endregion

        #region variables
        CONTEXTO.TeraflopSystem oContexto;
        #endregion

        private CustomerAuds()
        {
            oContexto = CONTEXTO.TeraflopSystem.Get_Instance();
        }

        public void Add_CustomerAud(MODELO.CustomerAud CustomerAud)
        {
            try
            {
                CASOS_DE_USO.Audits.Operations_CustomerAuds.Add_CustomerAud(oContexto, CustomerAud);
                oContexto.SaveChanges();
            }
            catch
            {
                // Error
            }
        }
        public MODELO.CustomerAud Get_CustomerAud(int Cod_CustomerAud)
        {
            return CASOS_DE_USO.Audits.Manage_CustomerAuds.Get_CustomerAud(Cod_CustomerAud, oContexto);
        }
        public List<MODELO.CustomerAud> Get_CustomerAud()
        {
            return CASOS_DE_USO.Audits.Manage_CustomerAuds.Get_CustomerAud(oContexto);
        }
    }
}
