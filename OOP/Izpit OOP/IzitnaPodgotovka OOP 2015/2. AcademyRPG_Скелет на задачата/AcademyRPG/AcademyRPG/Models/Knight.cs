namespace AcademyRPG.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Knight : Fighter, IFighter
    {
        public Knight(string name, Point position, int owner)
            : base(name, position, owner, 100, 100, 100)
        {
        }
      
        public override int GetTargetIndex(List<WorldObject> availableTargets)
        {
            var target = availableTargets
                .FirstOrDefault(t => t.Owner != 0 && t.Owner != this.Owner);

            return availableTargets.IndexOf(target);
        }
    }
}
