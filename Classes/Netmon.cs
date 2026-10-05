namespace Netmon.Classes
{
    public class Netmon
    {
        public Netmon(string hairColour,
            string hairLocation,
            string movementType,
            string numEyes)
        {
            HairColour = hairColour;
            HairLocation = hairLocation;
            MovementType = movementType;
            NumEyes = numEyes;
        }

        public string HairColour { get; private set; } = "";
        public string HairLocation { get; private set; } = "";
        public string MovementType { get; private set; } = "";
        public string NumEyes { get; private set; } = "";
    }
}
