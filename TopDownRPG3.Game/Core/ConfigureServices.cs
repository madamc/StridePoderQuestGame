using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stride.Core.Mathematics;
using Stride.Input;
using Stride.Engine;

namespace TopDownRPG3.Core
{
    public class ConfigureServices : StartupScript
    {
        // Declared public member fields and properties will show in the game studio

        public override void Start()
        {
            SceneSystem.Services.AddService(new PoderQuestCommandService());
            // Initialization of the script.
        }
    }
}
