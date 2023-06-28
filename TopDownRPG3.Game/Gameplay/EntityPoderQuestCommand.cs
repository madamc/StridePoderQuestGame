using Stride.Engine;
using TopDownRPG3.PoderQuestCommands;

namespace TopDownRPG3.Gameplay
{
    internal struct EntityPoderQuestCommand
    {
        public Entity Entity { get; set; }
        public IPoderQuestCommand PoderQuestCommand { get; set; }
    }
}