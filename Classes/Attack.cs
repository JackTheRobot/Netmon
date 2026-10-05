namespace Netmon.Classes
{
    public class Attack
    {
        public Attack(string name,
            string description,
            int power)
        {
            Name = name;
            Description = description;
            Power = power;
        }

        public string Name { get; } = "";
        public string Description { get; } = "";
        public int Power { get; }
    }
}
