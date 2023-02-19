using MODELO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class DetailSales
    {
        #region instance
        private static DetailSales instance;
        public static DetailSales Get_Instance()
        {
            if (instance == null)
                instance = new DetailSales();
            return instance;
        }
        #endregion

        #region variables
        CONTEXTO.TeraflopSystem oContexto;
        #endregion

        private DetailSales()
        {
            oContexto = CONTEXTO.TeraflopSystem.Get_Instance();
        }

        public void Add_DetailSale(MODELO.DetailSale DetailSale)
        {
            try
            {
                CASOS_DE_USO.Sales.Operations_DetailSales.Add_DetailSale(oContexto, DetailSale);
                oContexto.SaveChanges();
            }
            catch
            {
                // Error
            }
        }
        public void Modify_DetailSale(MODELO.DetailSale DetailSale)
        {
            try
            {
                CASOS_DE_USO.Sales.Operations_DetailSales.Modify_DetailSale(oContexto, DetailSale);
                oContexto.SaveChanges();
            }
            catch
            {
                // Error
            }
        }
        public void Delete_DetailSale(MODELO.DetailSale DetailSale)
        {
            try
            {
                CASOS_DE_USO.Sales.Operations_DetailSales.Delete_DetailSale(oContexto, DetailSale);
                oContexto.SaveChanges();
            }
            catch
            {
                // Error
            }
        }

        public MODELO.DetailSale Get_DetailSale(int Cod_DetailSale)
        {
            return CASOS_DE_USO.Sales.Manage_DetailSales.Get_DetailSale(Cod_DetailSale, oContexto);
        }
        public List<MODELO.DetailSale> Get_DetailSale()
        {
            return CASOS_DE_USO.Sales.Manage_DetailSales.Get_DetailSale(oContexto);
        }

        public void Add_DetailSale(List<DetailSale> detailSale)
        {
            throw new NotImplementedException();
        }
    }
}
