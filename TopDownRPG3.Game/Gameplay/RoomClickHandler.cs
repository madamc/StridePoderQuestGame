using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stride.Core.Mathematics;
using Stride.Input;
using Stride.Engine;
using TopDownRPG3.Core;
using TopDownRPG3.Services;
using TopDownRPG3.PoderQuestCommands;
using Stride.Graphics;
//using System.Drawing;
using Stride.Rendering.Fonts;
using Stride.UI.Controls;
using Stride.UI;
using Stride.UI.Panels;

namespace TopDownRPG3.Gameplay
{
    public class RoomClickHandler : SyncScript
    {
        // Declared public member fields and properties will show in the game studio
        PoderQuestCommandService m_poderQuestCommandService;
        List<IPoderQuestCommand> m_poderQuestCommands;
        public override void Start()
        {
            m_poderQuestCommands = new List<IPoderQuestCommand>();
            m_poderQuestCommandService = SceneSystem.Services.GetService<PoderQuestCommandService>();
        }

        public override void Update()
        {
        }

        public bool handleClick(ClickResult clickedResult)
        {
            var roomPoderQuestCommands = m_poderQuestCommands.FindAll(e => e.Entity == clickedResult.ClickedEntity);
            if (roomPoderQuestCommands.Count > 0)
            {
                m_poderQuestCommandService.addPoderQuestCommandList(roomPoderQuestCommands);
            } else
            {
                var clickable = clickedResult.ClickedEntity.Get<ClickableComponent>();
                if (clickable != null)
                {
                    m_poderQuestCommandService.addPoderQuestCommandList(clickable.getPoderQuestCommandList(clickedResult.Verb));
                }
                
            }
            
            var handled = false;
            return handled;
        }
    }
}
