using Stride.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopDownRPG3.Gameplay;

namespace TopDownRPG3.Core
{
    internal class PoderQuestCommandService
    {
        List<List<IPoderQuestCommand>> QuestCommands;

        //Game game;
        public PoderQuestCommandService() { QuestCommands = new List<List<IPoderQuestCommand>>(); }

        public void addPoderQuestCommandList(List<IPoderQuestCommand> list) {  QuestCommands.Append(list); }
        public void processPoderQuestCommands(float delta)
        {
            //foreach (var list in QuestCommands)
            for (int i = QuestCommands.Count - 1; i >= 0; i--)
            {
                var poderCommandList = QuestCommands[i].GetEnumerator();

                if (poderCommandList.Current != null) { }
                else if (poderCommandList.Current.execute(delta))
                {
                    if (!poderCommandList.MoveNext())
                    {
                        QuestCommands.RemoveAt(i);
                    }
                }
            }
        }
    }
}
