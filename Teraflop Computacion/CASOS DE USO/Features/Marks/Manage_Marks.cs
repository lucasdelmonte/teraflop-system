using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.Features.Marks
{
    public class Manage_Marks
    {
        public static MODELO.Mark Get_Mark(int Cod_Mark, CONTEXTO.TeraflopSystem Teraflop)
        {
            return Teraflop.Marks.FirstOrDefault(_ => _.Cod_Mark == Cod_Mark);
        }
        public static List<MODELO.Mark> Get_Mark(CONTEXTO.TeraflopSystem Teraflop)
        {
            return Teraflop.Marks.ToList();
        }
    }
}
