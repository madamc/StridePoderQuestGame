// Copyright (c) .NET Foundation and Contributors (https://dotnetfoundation.org/ & https://stride3d.net) and Silicon Studio Corp. (https://www.siliconstudio.co.jp)
// Distributed under the MIT license. See the LICENSE.md file in the project root for more information.
using Stride.Core.Mathematics;
using Stride.Engine;
using Stride.Physics;

namespace TopDownRPG3.Core
{
    public enum ClickType
    {
        /// <summary>
        /// The result didn't hit anything
        /// </summary>
        Empty,

        /// <summary>
        /// The result hit a ground object
        /// </summary>
        Ground,
        Wall,
        /// <summary>
        /// The result hit a treasure chest object
        /// </summary>
        LootCrate,

        Interaction,
        
    }
    
    public enum PoderClickType
    {
        Clickable,

        NonClickable,
    
    }

    public enum PoderVerb
    {
        Use,
        Look,
        Inv,
    }
    //public class PowerClickable
    //{
    //    public PowerClickable() { }
    //}

    /// <summary>
    /// Result of the user clicking/tapping on the world
    /// </summary>
    public struct ClickResult
    {
        /// <summary>
        /// The world-space position of the click, where the raycast hits the collision body
        /// </summary>
        public Vector3      WorldPosition;

        /// <summary>
        /// The Entity containing the collision body which was hit
        /// </summary>
        public Entity       ClickedEntity;

        /// <summary>
        /// What kind of object did we hit
        /// </summary>
        public ClickType    Type;

        /// <summary>
        /// The HitResult received from the physics simulation
        /// </summary>
        public HitResult    HitResult;

        public PoderVerb Verb;
    }

}
