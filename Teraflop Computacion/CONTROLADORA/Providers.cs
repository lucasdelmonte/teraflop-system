using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class Providers
    {
        #region instance
        private static Providers instance;
        public static Providers Get_Instance()
        {
            if (instance == null)
                instance = new Providers();
            return instance;
        }
        #endregion

        #region variables
        CONTEXTO.TeraflopSystem oContexto;
        #endregion

        private Providers()
        {
            oContexto = CONTEXTO.TeraflopSystem.Get_Instance();
        }

        public void Add_Provider(MODELO.Provider Provider)
        {
            try
            {
                CASOS_DE_USO.Providers.Operations_Providers.Add_Provider(oContexto, Provider);
                oContexto.SaveChanges();
            }
            catch
            {

                // Error
            }
        }
        public void Modify_Provider(MODELO.Provider Provider)
        {
            try
            {
                CASOS_DE_USO.Providers.Operations_Providers.Modify_Provider(oContexto, Provider);
                oContexto.SaveChanges();
            }
            catch
            {
                // Error
            }
        }
        public void Delete_Provider(MODELO.Provider Provider)
        {
            try
            {
                CASOS_DE_USO.Providers.Operations_Providers.Delete_Provider(oContexto, Provider);
                oContexto.SaveChanges();
            }
            catch
            {
                // Error
            }
        }

        public MODELO.Provider Get_Provider(int Cod_Provider)
        {
            return CASOS_DE_USO.Providers.Manage_Providers.Get_Provider(Cod_Provider, oContexto);
        }
        public List<MODELO.Provider> Get_Provider()
        {
            return CASOS_DE_USO.Providers.Manage_Providers.Get_Provider(oContexto);
        }
    }
}
