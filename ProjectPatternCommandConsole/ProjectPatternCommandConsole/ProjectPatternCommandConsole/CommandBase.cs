using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPatternCommandConsole
{
    /// <summary>
    /// 1) базовая команда
    /// </summary>
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
