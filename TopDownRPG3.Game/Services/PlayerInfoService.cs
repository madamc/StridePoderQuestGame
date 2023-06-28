using Stride.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopDownRPG3.Services
{
    public class PlayerInfoService
    {
        private Entity m_player;
        public Entity Player 
        { 
            get { return m_player; } 
            set
            {
                if (m_player == null) 
                {
                    m_player = value;
                }
            }
        }
        //public PlayerInfoService(Entity player) 
        //{ 
        //    Player = player;
        //}
        

    }
}
