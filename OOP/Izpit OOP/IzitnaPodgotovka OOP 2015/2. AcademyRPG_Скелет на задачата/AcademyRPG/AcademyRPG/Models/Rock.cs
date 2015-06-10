﻿

namespace AcademyRPG.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Rock : StaticObject, IResource
    {
        public Rock(int hitPoints,Point position)
            : base(position,0)
        {
            base.HitPoints = hitPoints;
            this.Type = ResourceType.Stone;
            
        }
        public int Quantity { get { return base.HitPoints / 2; } }

        public ResourceType Type { get; private set; }
    }
}
