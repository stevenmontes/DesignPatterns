using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Console.StatePattern
{
    public class NotDeptorState : IState
    {
        public void Action(CustomerContext customerContext, decimal amount)
        {
            if (amount <= customerContext.Residue)
            {
                customerContext.Discount(amount);

                if (customerContext.Residue <= 0)
                {
                    customerContext.SetState(new DeptorState());
                }
            }
        }
    }
}
