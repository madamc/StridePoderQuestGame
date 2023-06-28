using Stride.Engine;
using Stride.Rendering.Fonts;
using TopDownRPG3.Core;
using TopDownRPG3.PoderQuestCommands;
using TopDownRPG3.Services;

namespace TopDownRPG3
{
    class TopDownRPG3App
    {
        static void Main(string[] args)
        {
            using (var game = new PoderQuestGame())
            {
                game.Run();
            }
        }
    }
}
