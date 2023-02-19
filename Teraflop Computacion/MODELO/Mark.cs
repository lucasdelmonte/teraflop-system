using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class Mark
    {
        #region attribute
        public int Cod_Mark { get; set; }
        public string NameMark { get; set; }
        #endregion

        #region method
        public override string ToString()
        {
            return NameMark;
        }
        #endregion
    }
}
