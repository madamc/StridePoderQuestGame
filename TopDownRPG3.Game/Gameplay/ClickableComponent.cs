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
    public class ClickableComponent : SyncScript
    {
        // Declared public member fields and properties will show in the game studio
        List<IPoderQuestCommand> m_poderQuestCommandsOnUse;
        List<IPoderQuestCommand> m_poderQuestCommandsOnLook;
        List<IPoderQuestCommand> m_poderQuestCommandsOnInv;

        public override void Start()
        {
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

        private void onInv()
        {
            throw new NotImplementedException();
        }

        private void onLook()
        {
            throw new NotImplementedException();
        }

        private void onUse()
        {
            throw new NotImplementedException();
        }
    }
}
