using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class DetailBuys
    {
        #region instance
        private static DetailBuys instance;
        public static DetailBuys Get_Instance()
        {
            if (instance == null)
                instance = new DetailBuys();
            return instance;
        }
        #endregion

        #region variables
        CONTEXTO.TeraflopSystem oContexto;
        #endregion

        private DetailBuys()
        {
            oContexto = CONTEXTO.TeraflopSystem.Get_Instance();
        }

        public void Add_DetailBuy(MODELO.DetailBuy DetailBuy)
        {
            try
            {
                CASOS_DE_USO.Buys.Operations_DetailBuys.Add_DetailBuy(oContexto, DetailBuy);
                oContexto.SaveChanges();
            }
            catch
            {
                // Error
            }
        }
        public void Modify_DetailBuy(MODELO.DetailBuy DetailBuy)
        {
            try
            {
                CASOS_DE_USO.Buys.Operations_DetailBuys.Modify_DetailBuy(oContexto, DetailBuy);
                oContexto.SaveChanges();
            }
            catch
            {
                // Error
            }
        }
        public void Delete_DetailBuy(MODELO.DetailBuy DetailBuy)
        {
            try
            {
                CASOS_DE_USO.Buys.Operations_DetailBuys.Delete_DetailBuy(oContexto, DetailBuy);
                oContexto.SaveChanges();
            }
            catch
            {
                // Error
            }
        }

        public MODELO.DetailBuy Get_DetailBuy(int Cod_DetailBuy)
        {
            return CASOS_DE_USO.Buys.Manage_DetailBuys.Get_DetailBuy(Cod_DetailBuy, oContexto);
        }
        public List<MODELO.DetailBuy> Get_DetailBuy()
        {
            return CASOS_DE_USO.Buys.Manage_DetailBuys.Get_DetailBuy(oContexto);
        }

        public void Add_DetailBuy(List<DetailBuys> detailBuy)
        {
            throw new NotImplementedException();
        }
    }
}
