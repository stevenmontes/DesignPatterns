using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Console.StatePattern
{
    public class DeptorState : IState
    {
        public void Action(CustomerContext customerContext, decimal amount)
        {
            System.Console.WriteLine("No tiene plata");
        }
    }
}
