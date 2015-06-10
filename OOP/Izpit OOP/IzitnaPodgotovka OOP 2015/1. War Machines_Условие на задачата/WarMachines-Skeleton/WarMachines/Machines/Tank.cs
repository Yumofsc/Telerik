namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using WarMachines.Interfaces;
    public class Tank : Machine, ITank, IMachine
    {
        private const int attackPointsModifier = 40;
        private const int defencePointsModifier = 30;
        private const int health = 100;
        
        public Tank(string name, double attackPoints , double defencePoints)
            : base(name,attackPoints -40,health,defencePoints + 30)
        {
            this.ToggleDefenseMode();
        }

        public bool DefenseMode{get; private set; }
        

        public void ToggleDefenseMode()
        {
            this.DefenseMode = !this.DefenseMode;
            if (this.DefenseMode)
            {
                this.AttackPoints -= attackPointsModifier;
                this.DefensePoints += defencePointsModifier;
            }
            else
            {
                this.AttackPoints += attackPointsModifier;
                this.DefensePoints -= defencePointsModifier;
            }
            
        }
        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendLine(base.ToString());
            string defenceModeAsString = this.DefenseMode ? On : Off;
            result.AppendLine(string.Format(" *Defense: {0}", defenceModeAsString));

            return result.ToString().Trim(); 
        }
    }
}
