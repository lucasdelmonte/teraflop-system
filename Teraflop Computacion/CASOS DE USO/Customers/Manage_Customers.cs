using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.Customers
{
    public class Manage_Customers
    {
        public static MODELO.Customer Get_Customer(int Cod_Customer, CONTEXTO.TeraflopSystem Teraflop)
        {
            return Teraflop.Customers.FirstOrDefault(_ => _.Cod_Customer == Cod_Customer);
        }
        public static List<MODELO.Customer> Get_Customer(CONTEXTO.TeraflopSystem Teraflop)
        {
            return Teraflop.Customers.ToList();
        }
    }
}
