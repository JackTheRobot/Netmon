namespace Netmon.Classes
{
    public class Netmon
    {
        public string Name { get; private set; } = "";

        public void SetName(string name)
        {
            Name = name;
        }

        public int Age { get; private set; } = 0;
        public bool Dead { get; private set; } = false;

        public void IncreaseAge()
        {
            Age += 1;

            if (Age >= LifeExpectancy.Value)
            {
                Random rand = new();

                float deathChance = rand.NextSingle();

                if(deathChance > 0.5f) Dead = true;
            }
        }

        // Cosmetic

        public string SkinColour { get; private set; } = "";
        public string HairColour { get; private set; } = "";
        public string HairLocation { get; private set; } = "";
        public string MovementType { get; private set; } = "";
        public string NumEyes { get; private set; } = "";

        public Netmon(string skinColour,
            string hairColour,
            string hairLocation,
            string movementType,
            string numEyes,
            int maxHP,
            int attackStat,
            int defenceStat,
            int speedStat)
        {
            SkinColour = skinColour;
            HairColour = hairColour;
            HairLocation = hairLocation;
            MovementType = movementType;
            NumEyes = numEyes;
            MaxHP = maxHP;
            CurrentHP = maxHP;
            AttackStat = attackStat;
            DefenceStat = defenceStat;
            SpeedStat = speedStat;
        }

        // Battle Attributes

        public int MaxHP { get; private set; }
        public int CurrentHP { get; private set; }
        public bool Fainted { get; private set; } = false;

        public void ReduceHP(int amount)
        {
            CurrentHP -= amount;

            if (CurrentHP <= 0)
            {
                CurrentHP = 0;
                Fainted = true;
            }
        }

        public void RestoreHP(int amount)
        {
            CurrentHP += amount;

            if (CurrentHP > MaxHP) CurrentHP = MaxHP;

            if (Fainted) Fainted = false;
        }

        public int EXP { get; private set; } = 0;
        public int Level { get; private set; } = 0;

        public void AddEXP(int amount)
        {
            EXP += amount;

            int level = LevelDefinitions.GetLevelFromEXP(EXP);

            if (level > Level)
            {
                Level = level;
                LevelUp();
            }
        }

        void LevelUp()
        {
            Console.WriteLine(Name + " levelled up!");
        }

        public int AttackStat { get; private set; }
        public int DefenceStat { get; private set; }
        public int SpeedStat { get; private set; }
        public List<Attack> Attacks { get; private set; } = new();
    }
}
