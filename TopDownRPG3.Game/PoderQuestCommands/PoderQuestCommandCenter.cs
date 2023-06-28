using Stride.Core;
using Stride.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopDownRPG3.Core;

namespace TopDownRPG3.PoderQuestCommands
{
    public class PoderQuestCommandCenter
    {
        public static IServiceRegistry Services {  get; private set; }
        public static PoderQuestGame Game { get; private set; }

        public static void setSceneSystem(IServiceRegistry sceneSystem)
        {
            if (Services == null)
            {
                Services = sceneSystem;
            }
        }
        public static void setGame(PoderQuestGame game)
        {
            if ( Game == null)
            {
                Game = game;
            }
        }
    }
}
