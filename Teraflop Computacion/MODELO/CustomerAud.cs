using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class CustomerAud
    {
        #region attribute
        public int Cod_CustomerAud { get; set; }
        public int Cod_Customer { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Direction { get; set; }
        public string Telephone { get; set; }
        public string AudUsuario { get; set; }
        public DateTime AudFandH { get; set; }
        public string AudAction { get; set; }
        #endregion
    }
}
