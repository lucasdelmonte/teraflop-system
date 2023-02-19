using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public abstract class OperationState
    {
        public abstract void Response(MODELO.Sale oSale);
        public abstract void Response(MODELO.Buy oBuy);
    }
}
