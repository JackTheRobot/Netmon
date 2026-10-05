namespace Netmon.Classes
{
    public class NetmonProperties
    {
        public NetmonProperties(string[] hairColours,
            string[] hairLocations,
            string[] movementTypes,
            string[] numEyesArray)
        {
            HairColours = hairColours;
            HairLocations = hairLocations;
            MovementTypes = movementTypes;
            NumEyesArray = numEyesArray;
        }

        public string[] HairColours { get; private set; } = [];
        public string[] HairLocations { get; private set; } = [];
        public string[] MovementTypes { get; private set; } = [];
        public string[] NumEyesArray { get; private set; } = [];

    }
}
