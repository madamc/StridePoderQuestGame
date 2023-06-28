using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stride.Core.Mathematics;
using Stride.Input;
using Stride.Engine;
using TopDownRPG3.Services;
using TopDownRPG3.Player;
using TopDownRPG3.PoderQuestCommands;
using Stride.Graphics;
using TopDownRPG3.UI;

namespace TopDownRPG3.Core
{
    public class ConfigureServices : StartupScript
    {
        // Declared public member fields and properties will show in the game studio
        public override void Start()
        {
            var playerService = SceneSystem.Services.GetService<PlayerInfoService>();
            var screenWriterService = SceneSystem.Services.GetService<ScreenWriterService>();
            var player = SceneSystem.SceneInstance.RootScene.Entities.First(e => e.Components.Get<PlayerInput>() != null);
            var onScreenText = SceneSystem.SceneInstance.RootScene.Entities.First(e => e.Name == "MainSceneEntity").GetChildren()
                .First(e => e.Components.Get<OnScreenText>() != null).Get<OnScreenText>();
            playerService.Player = player;
            screenWriterService.OnScreenText = onScreenText;
            Log.Debug("set Player");
            //SceneSystem.Services.AddService(new PoderQuestCommandService());
            //SceneSystem.Services.AddService(new PlayerInfoService(SceneSystem.SceneInstance.RootScene.Entities.First(e => e.Components.Get<PlayerInput>() != null)));
            //PoderQuestCommandCenter.setSceneSystem(SceneSystem.Services);
            // Initialization of the script.
        }
    }
}
