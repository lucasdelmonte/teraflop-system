using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CONTROLADORA
{
    public class RequestedState : OperationState
    {
        public override void Response(MODELO.Sale oSale)
        {
            oSale.State = "REQUESTED";
        }
        public override void Response(MODELO.Buy oBuy)
        {
            oBuy.State = "REQUESTED";
        }
    }
}
