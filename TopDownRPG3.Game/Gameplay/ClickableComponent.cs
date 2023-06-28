using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stride.Core.Mathematics;
using Stride.Input;
using Stride.Engine;
using TopDownRPG3.Core;
using TopDownRPG3.PoderQuestCommands;

namespace TopDownRPG3.Gameplay
{
    public class ClickableComponent : SyncScript
    {
        // Declared public member fields and properties will show in the game studio
        List<IPoderQuestCommand> m_poderQuestCommandsOnUse;
        List<IPoderQuestCommand> m_poderQuestCommandsOnLook;
        List<IPoderQuestCommand> m_poderQuestCommandsOnInv;

        public override void Start()
        {
            m_poderQuestCommandsOnUse = new List<IPoderQuestCommand>();
            m_poderQuestCommandsOnLook = new List<IPoderQuestCommand>();
            m_poderQuestCommandsOnInv = new List<IPoderQuestCommand>();
            m_poderQuestCommandsOnUse.Add(new MoveToLoc());
            m_poderQuestCommandsOnUse.Add(new DialogOneLiner());
            setEntityForPoderQuestCommands();
            // Initialization of the script.
        }

        public override void Update()
        {
            // Do stuff every new frame
        }

        public List<IPoderQuestCommand> getPoderQuestCommandList(PoderVerb verb)
        {
            switch (verb)
            {
                case PoderVerb.Use:
                    return m_poderQuestCommandsOnUse;
                case PoderVerb.Look:
                    return m_poderQuestCommandsOnLook;
                case PoderVerb.Inv:
                    return m_poderQuestCommandsOnInv;
            }
            return m_poderQuestCommandsOnUse;
        }

        public bool handleClick(PoderVerb verb, Entity clickedEntity)
        {
            var handled = false;
            switch (verb)
            {
                case PoderVerb.Use:
                    onUse();
                    break;
                case PoderVerb.Look:
                    onLook();
                    break;
                case PoderVerb.Inv:
                    onInv();
                    break;
            }
            return handled;
        }

        private void setEntityForPoderQuestCommands()
        {
            foreach (var command in m_poderQuestCommandsOnUse)
            {
                command.Entity = Entity;
            }
            foreach (var command in m_poderQuestCommandsOnLook)
            {
                command.Entity = Entity;
            }
            foreach (var command in m_poderQuestCommandsOnInv)
            {
                command.Entity = Entity;
            }
        }

        private void onInv()
        {
            //throw new NotImplementedException();
        }

        private void onLook()
        {
            //throw new NotImplementedException();
        }

        private void onUse()
        {
            //throw new NotImplementedException();
        }
    }
}
