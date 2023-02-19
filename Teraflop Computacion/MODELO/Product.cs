using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class Product
    {
        #region attribute
        public int Cod_Product { get; set; }
        public string Barcode { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public Model oModel { get; set; }
        public Mark oMark { get; set; }
        public Category oCategory { get; set; }
        public decimal Purchase_Price { get; set; }
        public decimal Price_Cash
        {
            get { return Calculate_Cash_Price(); }
        }
        public decimal Price_Card
        {
            get { return Calculate_Card_Price(); }
        }
        #endregion 

        #region method
        public decimal Calculate_Cash_Price()
        {
            decimal Price_Cash = (Purchase_Price * Convert.ToDecimal(1.60));
            return Price_Cash;
        }

        public decimal Calculate_Card_Price()
        {
            decimal Price_Cash = (Purchase_Price * Convert.ToDecimal(1.60));
            decimal Price_Card = (Price_Cash * Convert.ToDecimal(1.10));
            return Price_Card;
        }

        public override string ToString()
        {
            return Name;
        }
        #endregion
    }
}
