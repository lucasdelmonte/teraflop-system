using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.Features.Categories
{
    public class Manage_Categories
    {
        public static MODELO.Category Get_Category(int Cod_Category, CONTEXTO.TeraflopSystem Teraflop)
        {
            return Teraflop.Categories.FirstOrDefault(_ => _.Cod_Category == Cod_Category);
        }
        public static List<MODELO.Category> Get_Category(CONTEXTO.TeraflopSystem Teraflop)
        {
            return Teraflop.Categories.ToList();
        }
    }
}
