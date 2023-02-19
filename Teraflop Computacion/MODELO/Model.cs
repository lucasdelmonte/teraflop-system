using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class Model
    {
        #region attribute
        public int Cod_Model { get; set; }
        public string NameModel { get; set; }
        #endregion

        #region method
        public override string ToString()
        {
            return NameModel;
        }
        #endregion
    }
}
