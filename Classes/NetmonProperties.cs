namespace Netmon.Classes
{
    public class NetmonProperties
    {
        Random rand = new();
        int minStartingHP = 50;
        int maxStartingHP = 150;

        int minStartingAttackStat = 50;
        int maxStartingAttackStat = 100;
        int minStartingDefenceStat = 50;
        int maxStartingDefenceStat = 100;
        int minStartingSpeed = 50;
        int maxStartingSpeed = 100;

        public int RandomStartingHP()
        {
            return rand.Next(minStartingHP, maxStartingHP);
        }

        public int RandomStartingAttackStat()
        {
            return rand.Next(minStartingAttackStat, maxStartingAttackStat);
        }

        public int RandomStartingDefenceStat()
        {
            return rand.Next(minStartingDefenceStat, maxStartingDefenceStat);
        }

        public int RandomStartingSpeed()
        {
            return rand.Next(minStartingSpeed, maxStartingSpeed);
        }

        // COSMETICS

        public NetmonProperties(string[] skinColours,
            string[] hairColours,
            string[] hairLocations,
            string[] movementTypes,
            string[] numEyesArray,
            string[] sizes)
        {
            SkinColours = skinColours;
            HairColours = hairColours;
            HairLocations = hairLocations;
            MovementTypes = movementTypes;
            NumEyesArray = numEyesArray;
            Sizes = sizes;
        }
        
        public string[] SkinColours { get; private set; } = [];
        public string[] HairColours { get; private set; } = [];
        public string[] HairLocations { get; private set; } = [];
        public string[] MovementTypes { get; private set; } = [];
        public string[] NumEyesArray { get; private set; } = [];
        public string[] Sizes { get; private set; } = [];

        public string RandomSkinColour()
        {
            int randInt = rand.Next(SkinColours.Length);
            return SkinColours[randInt];
        }

        public string RandomHairColour()
        {
            int randInt = rand.Next(HairColours.Length);
            return HairColours[randInt];
        }

        public string RandomHairLocation()
        {
            int randInt = rand.Next(HairLocations.Length);
            return HairLocations[randInt];
        }

        public string RandomMovementType()
        {
            int randInt = rand.Next(MovementTypes.Length);
            return MovementTypes[randInt];
        }

        public string RandomNumEyes()
        {
            int randInt = rand.Next(NumEyesArray.Length);
            return NumEyesArray[randInt];
        }

        public string RandomSize()
        {
            int randInt = rand.Next(Sizes.Length);
            return Sizes[randInt];
        }
    }
}
