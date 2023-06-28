using SharpDX.Direct3D;
using Stride.Core.Mathematics;
using Stride.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopDownRPG3.Services;

namespace TopDownRPG3.PoderQuestCommands
{
    public class MoveToLocBuilder
    {
        MoveToLoc moveToLocInstant() { return new MoveToLoc(); }
        //MoveToLoc moveToLocWithDuration() { return new MoveToLoc(); }
        //MoveToLoc moveToLocWithDurationNoX() { return new MoveToLoc(); }
        //MoveToLoc moveToLocWithDurationNoY() { return new MoveToLoc(); }
        //MoveToLoc moveToLocWithDurationNoZ() { return new MoveToLoc(); }
        //MoveToLoc moveToLocWithDurationAndInterpolation() { return new MoveToLoc(); }
    }
    class MoveToLoc : IPoderQuestCommand
    {
        Vector3 Location { get; set; }
        Vector3 Destination { get; set; }
        float Duration { get; set; }
        InterpolationMode interpolationMode { get; set; }
        float Interpolation { get; set; }

        float ElaspsedSeconds { get; set; }
        public Entity Entity { get; set; }

        //public MoveToLoc(Vector3 location, Vector3 destination, float duration, InterpolationMode interpolationMode, float interpolation, float elaspsedSeconds, Entity entity)
        public MoveToLoc()
        {
            //Location = location;
            //Destination = destination;
            //Duration = duration;
            //this.interpolationMode = interpolationMode;
            //Interpolation = interpolation;
            //ElaspsedSeconds = elaspsedSeconds;
            //Entity = entity;
        }

        public bool execute(float delta)
        {
            var vecker = Vector3.One;
            var service = PoderQuestCommandCenter.Game.Services.GetService<PlayerInfoService>();
            Destination = Entity.Get<TransformComponent>().Position;
            Location = service.Player.Get<TransformComponent>().Position;
            //Lerp(vecker, Vector3.Zero, delta);
            //Stride.Animations.Interpolator.Vector3.
            ElaspsedSeconds += delta;
            var vecDif = (Destination - Location);
            var absVecDif = new Vector3(Math.Abs(vecDif.X), Math.Abs(vecDif.Y), Math.Abs(vecDif.Z));
            if (absVecDif.X < 0.7 && absVecDif.Y < 0.7 && absVecDif.Z < 0.7)
            { return true; } else { return false; }
        }
    }
}
