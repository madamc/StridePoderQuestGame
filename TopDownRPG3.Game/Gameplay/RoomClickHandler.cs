using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stride.Core.Mathematics;
using Stride.Input;
using Stride.Engine;
using TopDownRPG3.Core;

namespace TopDownRPG3.Gameplay
{
    public class RoomClickHandler : SyncScript
    {
        // Declared public member fields and properties will show in the game studio
        PoderQuestCommandService m_pqcs;
        List<EntityPoderQuestCommand> m_entityPoderQuestCommands;
        public override void Start()
        {
            m_entityPoderQuestCommands = new List<EntityPoderQuestCommand>();
            m_pqcs = SceneSystem.Services.GetService<PoderQuestCommandService>();
            // Initialization of the script.
        }

        public override void Update()
        {
            m_pqcs.processPoderQuestCommands((float)Game.UpdateTime.Elapsed.TotalSeconds);
            // Do stuff every new frame
        }

        public bool handleClick(PoderVerb verb, Entity clickedEntity)
        {
            if (findEntityPoderQuestCommand(clickedEntity))
            {

            } else
            {
                var clickable = clickedEntity.Get<ClickableComponent>();
                m_pqcs.addPoderQuestCommandList(clickable.getPoderQuestCommandList(verb));
            }
            
            var handled = false;
            return handled;
        }

        bool findEntityPoderQuestCommand(Entity entity)
        {
            return m_entityPoderQuestCommands.Any(e => e.Entity == entity);
        }
    }
}
