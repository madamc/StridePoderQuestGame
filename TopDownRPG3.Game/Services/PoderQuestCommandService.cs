using Microsoft.VisualBasic.Logging;
using Stride.Core;
using Stride.Engine;
using Stride.Games;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using TopDownRPG3.Gameplay;
using TopDownRPG3.PoderQuestCommands;

namespace TopDownRPG3.Core
{
    public class PoderQuestCommandService
    {
        private const int _poderQuestCommandLimit = 16; // prolly remove this
        List<PoderQuestCommandItem> QuestCommands;
        private List<IEnumerator<IPoderQuestCommand>> PoderQuestCommandEnumerators;
        //Game game;
        public PoderQuestCommandService()
        {
            QuestCommands = new List<PoderQuestCommandItem>();
            //PoderQuestCommandEnumerators = new List<IEnumerator<IPoderQuestCommand>>();
            //for (int i = 0; i < _poderQuestCommandLimit; i++) 
            //{
            //    PoderQuestCommandEnumerators.Add(new List<IPoderQuestCommand>().GetEnumerator());
            //}
        }

        public void addPoderQuestCommandList(List<IPoderQuestCommand> list) 
        {  
            /*if (list.Count > 0)*/
            var item = new PoderQuestCommandItem();
            item.PoderQuestCommandList = list;
            item.Enumerator = list.GetEnumerator();
            item.Enumerator.MoveNext();
            QuestCommands.Add(item);//(list); 
        }

        public void processPoderQuestCommands(float delta)
        {
            //foreach (var list in QuestCommands)
            for (int i = QuestCommands.Count - 1; i >= 0; i--)
            {
                // this is messing things up by getting pulled every time
                //var poderCommandList = QuestCommands[i].GetEnumerator();
                
                //if (poderCommandList.Current == null) { poderCommandList.MoveNext(); }
                if (QuestCommands[i].Enumerator.Current.execute(delta))
                {
                    if (!QuestCommands[i].Enumerator.MoveNext())
                    {
                        QuestCommands.RemoveAt(i);
                    }
                }
                Debug.Print("holdo");
            }
        }

        public bool isProcessingPoderQuestCommands() { return QuestCommands.Count > 0;}

        internal struct PoderQuestCommandItem
        {
            public List<IPoderQuestCommand> PoderQuestCommandList;
            public IEnumerator<IPoderQuestCommand> Enumerator;
        }
    }
}
