using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class Provider
    {
        #region attribute
        public int Cod_Provider { get; set; }
        public string Name { get; set; }
        public string Direction { get; set; }
        public string Telephone { get; set; }
        public string Website { get; set; }
        public List<Category> Category { get; set; }
        #endregion

        #region methods
        public override string ToString()
        {
            return Name;
        }
        #endregion
    }
}
