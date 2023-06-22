using Stride.Engine;

namespace TopDownRPG3
{
    class TopDownRPG3App
    {
        static void Main(string[] args)
        {
            using (var game = new Game())
            {
                game.Run();
            }
        }
    }
}
