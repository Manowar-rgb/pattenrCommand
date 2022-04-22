using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPatternCommandConsole
{
    public class CommandProduct : ICommand
    {
        private readonly Receiver _receiver;

        public CommandProduct(Receiver receiver)
        {
            _receiver = receiver;
        }

        public void Execute()
        {
            _receiver.AssignProduct();
        }

        public void Undo()
        {
            _receiver.CancelProduct();
        }
    }
}
