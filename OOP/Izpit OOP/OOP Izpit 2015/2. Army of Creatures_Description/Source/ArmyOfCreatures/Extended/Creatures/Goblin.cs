namespace ArmyOfCreatures.Extended.Creatures
{
    using System;
    using System.Collections.Generic;

    using ArmyOfCreatures.Logic.Creatures;
    public class Goblin : Creature
    {
        //Goblin is a creature with attack 4, defence 2, health points 5 and damage 1.5 and has no specialties.
        public Goblin()
            :base (4, 2, 5 ,1.5m)
        {
        }
    }
}
