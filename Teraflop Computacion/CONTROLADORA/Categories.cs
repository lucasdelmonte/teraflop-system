using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class Categories
    {
        #region instance
        private static Categories instance;
        public static Categories Get_Instance()
        {
            if (instance == null)
                instance = new Categories();
            return instance;
        }
        #endregion

        #region variables
        CONTEXTO.TeraflopSystem oContexto;
        #endregion

        private Categories()
        {
            oContexto = CONTEXTO.TeraflopSystem.Get_Instance();
        }

        public void Add_Category(MODELO.Category Category)
        {
            try
            {
                CASOS_DE_USO.Features.Categories.Operations_Categories.Add_Category(oContexto, Category);
                oContexto.SaveChanges();
            }
            catch
            {
                // Error
            }
        }
        public void Modify_Category(MODELO.Category Category)
        {
            try
            {
                CASOS_DE_USO.Features.Categories.Operations_Categories.Modify_Category(oContexto, Category);
                oContexto.SaveChanges();
            }
            catch
            {
                // Error
            }
        }
        public void Delete_Category(MODELO.Category Category)
        {
            try
            {
                CASOS_DE_USO.Features.Categories.Operations_Categories.Delete_Category(oContexto, Category);
                oContexto.SaveChanges();
            }
            catch
            {
                // Error
            }
        }

        public MODELO.Category Get_Category(int Cod_Category)
        {
            return CASOS_DE_USO.Features.Categories.Manage_Categories.Get_Category(Cod_Category, oContexto);
        }
        public List<MODELO.Category> Get_Category()
        {
            return CASOS_DE_USO.Features.Categories.Manage_Categories.Get_Category(oContexto);
        }
    }
}
