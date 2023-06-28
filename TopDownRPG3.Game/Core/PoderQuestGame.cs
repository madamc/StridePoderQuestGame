using Stride.Engine;
using Stride.Games;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopDownRPG3.PoderQuestCommands;
using TopDownRPG3.Services;

namespace TopDownRPG3.Core
{
    public class PoderQuestGame: Game
    {
        public PoderQuestGame() : base() 
        {
            Services.AddService(new PoderQuestCommandService());
            Services.AddService(new PlayerInfoService());
            Services.AddService(new ScreenWriterService());
            //PoderQuestCommandCenter.setSceneSystem(Services);
            PoderQuestCommandCenter.setGame(this);
            GameSystems.Add(new PoderQuestCommandSystem(Services));
        }
    }
}
