using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class ContextState
    {
        private OperationState state;
        public OperationState State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }
        }
        public void changeStateSale(MODELO.Sale oSale)
        {
            state.Response(oSale);
        }
        public void changeStateBuy(MODELO.Buy oBuy)
        {
            state.Response(oBuy);
        }
    }
}
