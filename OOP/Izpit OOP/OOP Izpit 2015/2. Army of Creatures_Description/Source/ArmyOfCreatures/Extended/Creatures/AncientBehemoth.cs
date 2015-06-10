namespace ArmyOfCreatures.Logic.Creatures
{
    using System;

    using ArmyOfCreatures.Logic.Creatures;
    using ArmyOfCreatures.Logic.Specialties;

    //AncientBehemoth is a creature with attack 19, defense 19, damage 40, health points 300 
    public class AncientBehemoth : Creature
    {
        public AncientBehemoth()
            :base(19,19,40,300)
        {
            this.AddSpecialty(new ReduceEnemyDefenseByPercentage(80));
            this.AddSpecialty(new DoubleDefenseWhenDefending(5));

        }

    }
}
