using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class Models
    {
        #region instance
        private static Models instance;
        public static Models Get_Instance()
        {
            if (instance == null)
                instance = new Models();
            return instance;
        }
        #endregion

        #region variables
        CONTEXTO.TeraflopSystem oContexto;
        #endregion

        private Models()
        {
            oContexto = CONTEXTO.TeraflopSystem.Get_Instance();
        }

        public void Add_Model(MODELO.Model Model)
        {
            try
            {
                CASOS_DE_USO.Features.Models.Operations_Models.Add_Model(oContexto, Model);
                oContexto.SaveChanges();
            }
            catch
            {
                // Error
            }
        }
        public void Modify_Model(MODELO.Model Model)
        {
            try
            {
                CASOS_DE_USO.Features.Models.Operations_Models.Modify_Model(oContexto, Model);
                oContexto.SaveChanges();
            }
            catch
            {
                // Error
            }
        }
        public void Delete_Model(MODELO.Model Model)
        {
            try
            {
                CASOS_DE_USO.Features.Models.Operations_Models.Delete_Model(oContexto, Model);
                oContexto.SaveChanges();
            }
            catch
            {
                // Error
            }
        }

        public MODELO.Model Get_Model(int Cod_Model)
        {
            return CASOS_DE_USO.Features.Models.Manage_Models.Get_Model(Cod_Model, oContexto);
        }
        public List<MODELO.Model> Get_Model()
        {
            return CASOS_DE_USO.Features.Models.Manage_Models.Get_Model(oContexto);
        }
    }
}
