using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class Category
    {
        #region attribute
        public int Cod_Category { get; set; }
        public string NameCategory { get; set; }
        #endregion

        #region method
        public override string ToString()
        {
            return NameCategory;
        }
        #endregion
    }
}
