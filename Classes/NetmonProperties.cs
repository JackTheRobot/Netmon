namespace Netmon.Classes
{
    public class NetmonProperties
    {
        Random rand = new();

        public NetmonProperties(string[] skinColours,
            string[] hairColours,
            string[] hairLocations,
            string[] movementTypes,
            string[] numEyesArray)
        {
            SkinColours = skinColours;
            HairColours = hairColours;
            HairLocations = hairLocations;
            MovementTypes = movementTypes;
            NumEyesArray = numEyesArray;
        }

        public string[] SkinColours { get; private set; } = [];
        public string[] HairColours { get; private set; } = [];
        public string[] HairLocations { get; private set; } = [];
        public string[] MovementTypes { get; private set; } = [];
        public string[] NumEyesArray { get; private set; } = [];

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
    }
}
