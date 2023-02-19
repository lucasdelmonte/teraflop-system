using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.Features.Models
{
    public class Manage_Models
    {
        public static MODELO.Model Get_Model(int Cod_Model, CONTEXTO.TeraflopSystem Teraflop)
        {
            return Teraflop.Models.FirstOrDefault(_ => _.Cod_Model == Cod_Model);
        }
        public static List<MODELO.Model> Get_Model(CONTEXTO.TeraflopSystem Teraflop)
        {
            return Teraflop.Models.ToList();
        }
    }
}
