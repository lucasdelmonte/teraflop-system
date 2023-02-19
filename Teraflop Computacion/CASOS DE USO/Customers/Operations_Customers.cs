using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_DE_USO.Customers
{
    public class Operations_Customers
    {
        public static void Add_Customer(CONTEXTO.TeraflopSystem Teraflop, MODELO.Customer Customer)
        {
            Teraflop.Customers.Add(Customer);
        }
        public static void Delete_Customer(CONTEXTO.TeraflopSystem Teraflop, MODELO.Customer Customer)
        {      
            var local = Teraflop.Set<MODELO.Customer>()
                   .Local
                   .FirstOrDefault(x => x.Cod_Customer == Customer.Cod_Customer);
            if (local != null)
            {
                Teraflop.Customers.Attach(local);
                Teraflop.Entry(local).State = System.Data.Entity.EntityState.Deleted;
            }
            else
            {
                Teraflop.Customers.Remove(Customer);
            } 
        }
        public static void Modify_Customer(CONTEXTO.TeraflopSystem Teraflop, MODELO.Customer Customer)
        {
            var local = Teraflop.Set<MODELO.Customer>()
                    .Local
                    .FirstOrDefault(x => x.Cod_Customer == Customer.Cod_Customer);
            if (local != null)
                Teraflop.Entry(local).State = System.Data.Entity.EntityState.Detached;

            Teraflop.Entry(Customer).State = System.Data.Entity.EntityState.Modified;
            
        }
    }
}
