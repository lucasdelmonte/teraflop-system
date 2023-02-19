using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.Sales
{
    public class Manage_Sales
    {
        public static MODELO.Sale Get_Sale(int Cod_Sale, CONTEXTO.TeraflopSystem Teraflop)
        {
            return Teraflop.Sales.Include("DetailSale").Include("oCustomer").FirstOrDefault(_ => _.Cod_Sale == Cod_Sale);
        }
        public static List<MODELO.Sale> Get_Sale(CONTEXTO.TeraflopSystem Teraflop)
        {
            return Teraflop.Sales.ToList();
        }
    }
}
