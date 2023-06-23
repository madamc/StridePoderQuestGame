using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopDownRPG3.Core
{
    internal interface IPoderQuestCommand
    {
        bool execute(float delta);
    }
}
