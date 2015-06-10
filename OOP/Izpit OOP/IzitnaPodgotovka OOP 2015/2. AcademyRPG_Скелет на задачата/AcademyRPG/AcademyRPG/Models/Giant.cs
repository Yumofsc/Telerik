namespace AcademyRPG.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public class Giant : Fighter, IFighter, IControllable, IWorldObject, IGatherer
    {
        public Giant(string name, Point position)
            : base(name, position, 0, 150, 80, 200)
        {
        }
        public override int GetTargetIndex(List<WorldObject> availableTargets)
        {
            var target = availableTargets.FirstOrDefault(t => t.Owner != 0);

            return availableTargets.IndexOf(target);
        }

        public bool TryGather(IResource resource)
        {
            bool canGather = false;
            if (resource.Type == ResourceType.Stone)
            {
                canGather = true;
                if (base.AttackPoints == 150)
                {
                    base.AttackPoints += 100;
                }
            }

            return canGather;
        }
    }
}
