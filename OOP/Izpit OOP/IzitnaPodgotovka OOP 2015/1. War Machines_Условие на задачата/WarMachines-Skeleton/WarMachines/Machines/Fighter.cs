

namespace WarMachines.Machines
{
    using System.Text;
    using WarMachines.Interfaces;

    public class Fighter : Machine, IMachine, IFighter
    {   
        private const int health = 200;
       
        public Fighter(string name, double attackPoints, bool stealthMode, double defencePoints)
            : base(name,attackPoints,health,defencePoints)
        {
            this.StealthMode = stealthMode;
        }
        public bool StealthMode { get; private set; }

        public void ToggleStealthMode()
        {
            this.StealthMode = !this.StealthMode;
        }
        public override string ToString()
        {
            var result = new StringBuilder(base.ToString());

            string stealthModeAsString = this.StealthMode ? On : Off;
            result.AppendLine(string.Format(" *Stealth: {0}", stealthModeAsString));

            return result.ToString().Trim(); 
        }
    }
}
