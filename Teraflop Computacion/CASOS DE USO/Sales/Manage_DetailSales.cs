using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.Sales
{
    public class Manage_DetailSales
    {
        public static MODELO.DetailSale Get_DetailSale(int Cod_DetailSale, CONTEXTO.TeraflopSystem Teraflop)
        {
            return Teraflop.DetailsSales.Include("oProduct").FirstOrDefault(_ => _.Cod_DetailSale == Cod_DetailSale);
        }
        public static List<MODELO.DetailSale> Get_DetailSale(CONTEXTO.TeraflopSystem Teraflop)
        {
            return Teraflop.DetailsSales.ToList();
        }
    }
}
