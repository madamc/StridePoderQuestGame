using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stride.Core.Mathematics;
using Stride.Input;
using Stride.Engine;
using TopDownRPG3.Core;

namespace TopDownRPG3.Player
{
    public class ClickHandler : AsyncScript
    {
        // Declared public member fields and properties will show in the game studio

        public override async Task Execute()
        {
            while(Game.IsRunning)
            {
                if (Input.IsMouseButtonDown(MouseButton.Left))
                {
                
                }
            
                // Do stuff every new frame
                await Script.NextFrame();
            }
        }

        public bool handleClick(PoderVerb verb, Entity clickedEntity)
        {

            return true;
        }
        public void onLookAt()
        {

        }
    }
}
