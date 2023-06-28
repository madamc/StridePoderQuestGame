using Stride.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopDownRPG3.UI;

namespace TopDownRPG3.Services
{
    public class ScreenWriterService
    {
        private OnScreenText m_onScreenText;
        public OnScreenText OnScreenText
        {
            get { return m_onScreenText; }
            set
            {
                if (m_onScreenText == null)
                {
                    m_onScreenText = value;
                }
            }
        }
    }
}
