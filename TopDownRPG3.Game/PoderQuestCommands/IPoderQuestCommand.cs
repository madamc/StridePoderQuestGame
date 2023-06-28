using Stride.Engine;
using Stride.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopDownRPG3.PoderQuestCommands
{
    public interface IPoderQuestCommand
    {
        Entity Entity { get; set; }
        bool execute(float delta);

        InputManager getInputManager() {
            return PoderQuestCommandCenter.Game.Input;
        }
    }
}
