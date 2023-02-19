using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class Deliveries
    {
        #region instance
        private static Deliveries instance;
        public static Deliveries Get_Instance()
        {
            if (instance == null)
                instance = new Deliveries();
            return instance;
        }
        #endregion

        #region variables
        CONTEXTO.TeraflopSystem oContexto;
        #endregion

        private Deliveries()
        {
            oContexto = CONTEXTO.TeraflopSystem.Get_Instance();
        }

        public void Add_Delivery(MODELO.Delivery Delivery)
        {
            try
            {
                CASOS_DE_USO.Deliveries.Operations_Deliveries.Add_Delivery(oContexto, Delivery);
                oContexto.SaveChanges();
            }
            catch
            {
                // Error
            }
        }
        public void Modify_Delivery(MODELO.Delivery Delivery)
        {
            try
            {
                CASOS_DE_USO.Deliveries.Operations_Deliveries.Modify_Delivery(oContexto, Delivery);
                oContexto.SaveChanges();
            }
            catch
            {
                // Error
            }
        }
        public void Delete_Delivery(MODELO.Delivery Delivery)
        {
            try
            {
                CASOS_DE_USO.Deliveries.Operations_Deliveries.Delete_Delivery(oContexto, Delivery);
                oContexto.SaveChanges();
            }
            catch
            {
                // Error
            }
        }
        public MODELO.Delivery Get_Delivery(int Cod_Delivery)
        {
            return CASOS_DE_USO.Deliveries.Manage_Deliveries.Get_Delivery(Cod_Delivery, oContexto);
        }
        public List<MODELO.Delivery> Get_Delivery()
        {
            return CASOS_DE_USO.Deliveries.Manage_Deliveries.Get_Delivery(oContexto);
        }

        public void Add_Delivery(List<Deliveries> Delivery)
        {
            throw new NotImplementedException();
        }
    }
}
