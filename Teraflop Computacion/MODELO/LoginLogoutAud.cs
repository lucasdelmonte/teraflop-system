using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class LoginLogoutAud
    {
        #region attribute
        public int Cod_LoginLogoutAud { get; set; }
        public int Cod_User { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public string AudUsuario { get; set; }
        public string AudFandH { get; set; }
        public string AudAction { get; set; }
        #endregion
    }
}
