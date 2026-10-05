using System.Text.Json;

namespace Netmon.Classes
{
    public class NetmonBuilder
    {
        NetmonProperties properties = null!;

        string propertiesPath = "wwwroot/netmonProperties.json";

        public Netmon NewNetmon()
        {
            Console.WriteLine("Building new netmon");

            var json = File.ReadAllText(propertiesPath);

            properties = JsonSerializer.Deserialize<NetmonProperties>(json)!;

            string hairColour = "";
            string hairLocation = "";
            string movementType = "";
            string numEyes = "";

            Random rand = new();

            int randInt = rand.Next(properties.HairColours.Length);

            hairColour = properties.HairColours[randInt];

            randInt = rand.Next(properties.HairLocations.Length);

            hairLocation = properties.HairLocations[randInt];

            randInt = rand.Next(properties.MovementTypes.Length);

            movementType = properties.MovementTypes[randInt];

            randInt = rand.Next(properties.NumEyesArray.Length);

            numEyes = properties.NumEyesArray[randInt];

            Netmon newNetmon = new(hairColour,
                hairLocation,
                movementType,
                numEyes);


            return newNetmon;
        }
    }
}
