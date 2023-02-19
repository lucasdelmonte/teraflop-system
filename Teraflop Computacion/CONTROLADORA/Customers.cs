using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class Customers
    {
        #region instance
        private static Customers instance;
        public static Customers Get_Instance()
        {
            if (instance == null)
                instance = new Customers();
            return instance;
        }
        #endregion

        #region variables
        CONTEXTO.TeraflopSystem oContexto;
        #endregion

        private Customers()
        {
            oContexto = CONTEXTO.TeraflopSystem.Get_Instance();
        }

        public void Add_Customer(MODELO.Customer Customer)
        {
            try
            {
                CASOS_DE_USO.Customers.Operations_Customers.Add_Customer(oContexto, Customer);
                oContexto.SaveChanges();
            }
            catch
            {
                // Error
            }
        }
        public void Modify_Customer(MODELO.Customer Customer)
        {
            try
            {
                CASOS_DE_USO.Customers.Operations_Customers.Modify_Customer(oContexto, Customer);
                oContexto.SaveChanges();
            }
            catch
            {
                // Error
            }
        }
        public void Delete_Customer(MODELO.Customer Customer)
        {
            try
            {
                CASOS_DE_USO.Customers.Operations_Customers.Delete_Customer(oContexto, Customer);
                oContexto.SaveChanges();
            }
            catch
            {
                // Error
            }
        }

        public MODELO.Customer Get_Customer(int Cod_Customer)
        {
            return CASOS_DE_USO.Customers.Manage_Customers.Get_Customer(Cod_Customer, oContexto);
        }
        public List<MODELO.Customer> Get_Customer()
        {
            return CASOS_DE_USO.Customers.Manage_Customers.Get_Customer(oContexto);
        }
    }
}
