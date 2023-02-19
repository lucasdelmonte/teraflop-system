using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class Marks
    {
        #region instance
        private static Marks instance;
        public static Marks Get_Instance()
        {
            if (instance == null)
                instance = new Marks();
            return instance;
        }
        #endregion

        #region variables
        CONTEXTO.TeraflopSystem oContexto;
        #endregion

        private Marks()
        {
            oContexto = CONTEXTO.TeraflopSystem.Get_Instance();
        }

        public void Add_Mark(MODELO.Mark Mark)
        {
            try
            {
                CASOS_DE_USO.Features.Marks.Operations_Marks.Add_Mark(oContexto, Mark);
                oContexto.SaveChanges();
            }
            catch
            {
                // Error
            }
        }
        public void Modify_Mark(MODELO.Mark Mark)
        {
            try
            {
                CASOS_DE_USO.Features.Marks.Operations_Marks.Modify_Mark(oContexto, Mark);
                oContexto.SaveChanges();
            }
            catch
            {
                // Error
            }
        }
        public void Delete_Mark(MODELO.Mark Mark)
        {
            try
            {
                CASOS_DE_USO.Features.Marks.Operations_Marks.Delete_Mark(oContexto, Mark);
                oContexto.SaveChanges();
            }
            catch
            {
                // Error
            }
        }

        public MODELO.Mark Get_Mark(int Cod_Mark)
        {
            return CASOS_DE_USO.Features.Marks.Manage_Marks.Get_Mark(Cod_Mark, oContexto);
        }
        public List<MODELO.Mark> Get_Mark()
        {
            return CASOS_DE_USO.Features.Marks.Manage_Marks.Get_Mark(oContexto);
        }
    }
}
