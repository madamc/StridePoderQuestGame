using Stride.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopDownRPG3.Services;

namespace TopDownRPG3.PoderQuestCommands
{
    public class DialogOneLiner : IPoderQuestCommand
    {
        ScreenWriterService screenWriterService;
        private float elapsedTime = 0f;
        public Entity Entity { get; set; }

        public bool execute(float delta)
        {
            elapsedTime += delta;
            var service = PoderQuestCommandCenter.Game.Services.GetService<ScreenWriterService>();
            service.OnScreenText.toggleBgPanel(true);
            service.OnScreenText.setText("Hullo there. Don't you look abit shiny?");
            var pos = Entity.Get<TransformComponent>().Position;
            service.OnScreenText.setTextPosition(new Stride.Core.Mathematics.Vector2(200f, 100f));
            if (PoderQuestCommandCenter.Game.Input.IsKeyDown(Stride.Input.Keys.Space) || elapsedTime > 20f)
            {
                service.OnScreenText.setText("");
                service.OnScreenText.toggleBgPanel(false);
                elapsedTime = 0f;
                return true;   
            }

            return false;
        }
    }
}
