using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPatternCommandConsole
{
    /// <summary>
    /// 2) Класс-заказчик действия (UI)
    /// </summary>
    public class Invoker
    {  
        private readonly ICommand _command;

        // применяем паттерн "Инъекция зависимости"
        public Invoker(ICommand command)
        {
            // _command = new CommandConcrete(); // усиление
            _command = command;
        }

        public void Click()
        {
            _command.Execute();
        }

        public void Unclick()
        {
            _command.Undo();
        }
    }
}
