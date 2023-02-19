using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class Sales
    {
        #region instance
        private static Sales instance;
        public static Sales Get_Instance()
        {
            if (instance == null)
                instance = new Sales();
            return instance;
        }
        #endregion

        #region variables
        CONTEXTO.TeraflopSystem oContexto;
        #endregion

        private Sales()
        {
            oContexto = CONTEXTO.TeraflopSystem.Get_Instance();
        }

        public void Add_Sale(MODELO.Sale Sale)
        {
            try
            {
                CASOS_DE_USO.Sales.Operations_Sales.Add_Sale(oContexto, Sale);
                oContexto.SaveChanges();
            }
            catch
            {
                // Error
            }
        }
        public void Modify_Sale(MODELO.Sale Sale)
        {
            try
            {
                CASOS_DE_USO.Sales.Operations_Sales.Modify_Sale(oContexto, Sale);
                oContexto.SaveChanges();
            }
            catch
            {
                // Error
            }
        }
        public void Delete_Sale(MODELO.Sale Sale)
        {
            try
            {
                CASOS_DE_USO.Sales.Operations_Sales.Delete_Sale(oContexto, Sale);
                oContexto.SaveChanges();
            }
            catch
            {
                // Error
            }
        }

        public MODELO.Sale Get_Sale(int Cod_Sale)
        {
            return CASOS_DE_USO.Sales.Manage_Sales.Get_Sale(Cod_Sale, oContexto);
        }
        public List<MODELO.Sale> Get_Sale()
        {
            return CASOS_DE_USO.Sales.Manage_Sales.Get_Sale(oContexto);
        }
    }
}
