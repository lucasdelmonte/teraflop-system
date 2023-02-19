using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class Products
    {
        #region instance
        private static Products instance;
        public static Products Get_Instance()
        {
            if (instance == null)
                instance = new Products();
            return instance;
        }
        #endregion

        #region variables
        CONTEXTO.TeraflopSystem oContexto;
        #endregion

        private Products()
        {
            oContexto = CONTEXTO.TeraflopSystem.Get_Instance();
        }

        public void Add_Product(MODELO.Product Product)
        {
            try
            {
                CASOS_DE_USO.Products.Operations_Products.Add_Product(oContexto, Product);
                oContexto.SaveChanges();
            }
            catch
            {
                // Error
            }
        }
        public void Modify_Product(MODELO.Product Product)
        {
            try
            {
                CASOS_DE_USO.Products.Operations_Products.Modify_Product(oContexto, Product);
                oContexto.SaveChanges();
            }
            catch
            {
                // Error
            }
        }
        public void Delete_Product(MODELO.Product Product)
        {
            try
            {
                CASOS_DE_USO.Products.Operations_Products.Delete_Product(oContexto, Product);
                oContexto.SaveChanges();
            }
            catch
            {
                // Error
            }
        }

        public MODELO.Product Get_Product(int Cod_Product)
        {
            return CASOS_DE_USO.Products.Manage_Products.Get_Product(Cod_Product, oContexto);
        }
        public List<MODELO.Product> Get_Product()
        {
            return CASOS_DE_USO.Products.Manage_Products.Get_Product(oContexto);
        }
    }
}
