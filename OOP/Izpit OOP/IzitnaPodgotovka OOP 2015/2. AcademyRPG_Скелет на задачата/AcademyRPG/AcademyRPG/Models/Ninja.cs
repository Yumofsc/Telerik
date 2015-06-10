namespace AcademyRPG.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Ninja : Fighter, IFighter, IControllable, IWorldObject, IGatherer
    {
         public Ninja(string name, Point position, int owner)
            : base(name, position, owner, 150, int.MaxValue, 1)
        {
        }
        public override int GetTargetIndex(List<WorldObject> availableTargets)
        {
            var target = availableTargets
                .Where(t => t.Owner != 0 && t.Owner != this.Owner)
                .OrderByDescending(t => t.HitPoints)
                .FirstOrDefault();

            return availableTargets.IndexOf(target);
        }

        public bool TryGather(IResource resource)
        {
            bool canGather = false;
            if (resource.Type == ResourceType.Lumber)
            {
                base.AttackPoints += resource.Quantity;
                canGather = true;
            }
            else if (resource.Type == ResourceType.Stone)
            {
                base.AttackPoints += resource.Quantity * 2;
                canGather = true;
            }

            return canGather;
        }
    }
}
