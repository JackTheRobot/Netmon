namespace Netmon.Classes
{
    public class Netmon
    {
        public Netmon(string skinColour,
            string hairColour,
            string hairLocation,
            string movementType,
            string numEyes)
        {
            SkinColour = skinColour;
            HairColour = hairColour;
            HairLocation = hairLocation;
            MovementType = movementType;
            NumEyes = numEyes;
        }

        public string Name { get; private set; } = "";
        public string SkinColour { get; private set; } = "";
        public string HairColour { get; private set; } = "";
        public string HairLocation { get; private set; } = "";
        public string MovementType { get; private set; } = "";
        public string NumEyes { get; private set; } = "";

        public void SetName(string name)
        {
            Name = name;
        }
    }
}
