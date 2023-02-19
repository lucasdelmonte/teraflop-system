using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class DetailDeliveries
    {
        #region instance
        private static DetailDeliveries instance;
        public static DetailDeliveries Get_Instance()
        {
            if (instance == null)
                instance = new DetailDeliveries();
            return instance;
        }
        #endregion

        #region variables
        CONTEXTO.TeraflopSystem oContexto;
        #endregion

        private DetailDeliveries()
        {
            oContexto = CONTEXTO.TeraflopSystem.Get_Instance();
        }

        public void Add_DetailDelivery(MODELO.DetailDelivery DetailDelivery)
        {
            try
            {
                CASOS_DE_USO.Buys.Operations_DetailDelivery.Add_DetailDelivery(oContexto, DetailDelivery);
                oContexto.SaveChanges();
            }
            catch
            {
                // Error
            }
        }
        public void Modify_DetailDelivery(MODELO.DetailDelivery DetailDelivery)
        {
            try
            {
                CASOS_DE_USO.Buys.Operations_DetailDelivery.Modify_DetailDelivery(oContexto, DetailDelivery);
                oContexto.SaveChanges();
            }
            catch
            {
                // Error
            }
        }
        public void Delete_DetailDelivery(MODELO.DetailDelivery DetailDelivery)
        {
            try
            {
                CASOS_DE_USO.Buys.Operations_DetailDelivery.Delete_DetailDelivery(oContexto, DetailDelivery);
                oContexto.SaveChanges();
            }
            catch
            {
                // Error
            }
        }

        public MODELO.DetailDelivery Get_DetailDelivery(int Cod_DetailDelivery)
        {
            return CASOS_DE_USO.Buys.Manage_DetailDelivery.Get_DetailDelivery(Cod_DetailDelivery, oContexto);
        }
        public List<MODELO.DetailDelivery> Get_DetailDelivery()
        {
            return CASOS_DE_USO.Buys.Manage_DetailDelivery.Get_DetailDelivery(oContexto);
        }

        public void Add_DetailDelivery(List<DetailDeliveries> detailDelivery)
        {
            throw new NotImplementedException();
        }
    }
}
