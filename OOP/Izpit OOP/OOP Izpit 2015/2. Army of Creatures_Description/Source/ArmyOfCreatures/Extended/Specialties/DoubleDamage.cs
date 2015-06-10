namespace ArmyOfCreatures.Extended.Specialties
{
    using System;

    using ArmyOfCreatures.Logic.Specialties;
    public class DoubleDamage : Specialty
    {
        private int rounds;

        public DoubleDamage(int rounds)
        {
            this.Rounds = rounds;
        }
        //	The number of rounds in the constructor should be greater than 0
        //The number of rounds in the constructor should be less than or equal to 10


        public int Rounds
        {
            get
            {
                return this.rounds;
            }
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentException("Rounds must be between 0 and 10!");
                }
                this.rounds = value;
            }
        }




    }
}
