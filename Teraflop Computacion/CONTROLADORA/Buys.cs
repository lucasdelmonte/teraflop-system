using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class Buys
    {
        #region instance
        private static Buys instance;
        public static Buys Get_Instance()
        {
            if (instance == null)
                instance = new Buys();
            return instance;
        }
        #endregion

        #region variables
        CONTEXTO.TeraflopSystem oContexto;
        #endregion

        private Buys()
        {
            oContexto = CONTEXTO.TeraflopSystem.Get_Instance();
        }

        public void Add_Buy(MODELO.Buy Buy)
        {
            try
            {
                CASOS_DE_USO.Buys.Operations_Buys.Add_Buy(oContexto, Buy);
                oContexto.SaveChanges();
            }
            catch
            {
                // Error
            }
        }
        public void Modify_Buy(MODELO.Buy Buy)
        {
            try
            {
                CASOS_DE_USO.Buys.Operations_Buys.Modify_Buy(oContexto, Buy);
                oContexto.SaveChanges();
            }
            catch
            {
                // Error
            }
        }
        public void Delete_Buy(MODELO.Buy Buy)
        {
            try
            {
                CASOS_DE_USO.Buys.Operations_Buys.Delete_Buy(oContexto, Buy);
                oContexto.SaveChanges();
            }
            catch
            {
                // Error
            }
        }

        public MODELO.Buy Get_Buy(int Cod_Buy)
        {
            return CASOS_DE_USO.Buys.Manage_Buys.Get_Buy(Cod_Buy, oContexto);
        }
        public List<MODELO.Buy> Get_Buy()
        {
            return CASOS_DE_USO.Buys.Manage_Buys.Get_Buy(oContexto);
        }
    }
}
