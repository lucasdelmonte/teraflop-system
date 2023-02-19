using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace CASOS_DE_USO.Products
{
    public class Manage_Products
    { 
        public static MODELO.Product Get_Product(int Cod_Product, CONTEXTO.TeraflopSystem Teraflop)
        {

            return Teraflop.Products.Include("oModel").Include("oMark").Include("oCategory").FirstOrDefault(_ => _.Cod_Product == Cod_Product);
            /*
            using (CONTEXTO.TeraflopSystem context = new CONTEXTO.TeraflopSystem())
            {
                var products = context.Products
                    .Include("oMark")
                    .Include("oModel")
                    .Include("oCategory")
                    .ToList();
            }
            return products;
            */
        }
        public static List<MODELO.Product> Get_Product(CONTEXTO.TeraflopSystem Teraflop)
        {
            return Teraflop.Products.Include("oModel").Include("oMark").Include("oCategory").ToList();
        }
    }
}
