using SharpFont;
using Stride.Core;
using Stride.Games;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TopDownRPG3.Core.PoderQuestCommandService;

namespace TopDownRPG3.Core
{
    internal class PoderQuestCommandSystem: GameSystemBase
    {
        PoderQuestCommandService _poderQuestCommandService;
        public PoderQuestCommandSystem(IServiceRegistry registry) : base(registry)
        {
            Enabled = true;
            //PoderQuestCommandEnumerators = new List<IEnumerator<IPoderQuestCommand>>();
            //for (int i = 0; i < _poderQuestCommandLimit; i++) 
            //{
            //    PoderQuestCommandEnumerators.Add(new List<IPoderQuestCommand>().GetEnumerator());
            //}
            DrawOrder = 0xffffff;
            _poderQuestCommandService = Services.GetService<PoderQuestCommandService>();
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            _poderQuestCommandService.processPoderQuestCommands((float)gameTime.Elapsed.TotalSeconds);
        }
    }
}
