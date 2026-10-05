using System.Text.Json;

namespace Netmon.Classes
{
    public class NetmonBreeder
    {
        NetmonProperties properties = null!;

        float parentInheritChance = 0.45f;

        Random rand = new();

        public Netmon BreedNetmon(Netmon parentOne, Netmon parentTwo)
        {
            Random rand = new();

            string propertiesPath = "wwwroot/netmonProperties.json";

            Console.WriteLine("Building new netmon");

            var json = File.ReadAllText(propertiesPath);

            properties = JsonSerializer.Deserialize<NetmonProperties>(json)!;

            string skinColour = "";
            string hairColour = "";
            string hairLocation = "";
            string movementType = "";
            string numEyes = "";

            skinColour = RandomInherit(parentOne.SkinColour, parentTwo.SkinColour);
            if (string.IsNullOrEmpty(skinColour))
            {
                skinColour = properties.RandomSkinColour();
            }

            hairColour = RandomInherit(parentOne.HairColour, parentTwo.HairColour);
            if (string.IsNullOrEmpty(hairColour))
            {
                hairColour = properties.RandomHairColour();
            }

            hairLocation = RandomInherit(parentOne.HairLocation, parentTwo.HairLocation);
            if (string.IsNullOrEmpty(hairLocation))
            {
                hairLocation = properties.RandomHairLocation();
            }

            movementType = RandomInherit(parentOne.MovementType, parentTwo.MovementType);
            if (string.IsNullOrEmpty(movementType))
            {
                movementType = properties.RandomMovementType();
            }

            numEyes = RandomInherit(parentOne.NumEyes, parentTwo.NumEyes);
            if (string.IsNullOrEmpty(numEyes))
            {
                numEyes = properties.RandomNumEyes();
            }

            return new Netmon(skinColour,
                hairColour,
                hairLocation,
                movementType,
                numEyes
                );
        }

        string RandomInherit(string parentOneAttribute, string parentTwoAttribute)
        {
            float randFloat = rand.NextSingle();

            if (randFloat < parentInheritChance)
            {
                return parentOneAttribute;
            }

            else if (randFloat < parentInheritChance * 2)
            {
                return parentTwoAttribute;
            }

            else return "";
        }
    }
}
