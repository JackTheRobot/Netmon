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

            Console.WriteLine("Building new netmon through breeding");

            var json = File.ReadAllText(propertiesPath);

            properties = JsonSerializer.Deserialize<NetmonProperties>(json)!;

            string skinColour = "";
            string hairColour = "";
            string hairLocation = "";
            string movementType = "";
            string numEyes = "";

            skinColour = RandomInheritString(parentOne.SkinColour, parentTwo.SkinColour);
            if (string.IsNullOrEmpty(skinColour))
            {
                skinColour = properties.RandomSkinColour();
            }

            hairColour = RandomInheritString(parentOne.HairColour, parentTwo.HairColour);
            if (string.IsNullOrEmpty(hairColour))
            {
                hairColour = properties.RandomHairColour();
            }

            hairLocation = RandomInheritString(parentOne.HairLocation, parentTwo.HairLocation);
            if (string.IsNullOrEmpty(hairLocation))
            {
                hairLocation = properties.RandomHairLocation();
            }

            movementType = RandomInheritString(parentOne.MovementType, parentTwo.MovementType);
            if (string.IsNullOrEmpty(movementType))
            {
                movementType = properties.RandomMovementType();
            }

            numEyes = RandomInheritString(parentOne.NumEyes, parentTwo.NumEyes);
            if (string.IsNullOrEmpty(numEyes))
            {
                numEyes = properties.RandomNumEyes();
            }

            Console.WriteLine("Deciding HP");
            int startingHP = RandomInheritInt(parentOne.MaxHP, parentTwo.MaxHP);
            Console.WriteLine("Deciding Attack Stat");
            int startingAttack = RandomInheritInt(parentOne.AttackStat, parentTwo.AttackStat);
            Console.WriteLine("Deciding Defence Stat");
            int startingDefence = RandomInheritInt(parentOne.DefenceStat, parentTwo.DefenceStat);
            Console.WriteLine("Deciding Speed Stat");
            int startingSpeed = RandomInheritInt(parentOne.SpeedStat, parentTwo.SpeedStat);

            return new Netmon(skinColour,
                hairColour,
                hairLocation,
                movementType,
                numEyes,
                startingHP,
                startingAttack,
                startingDefence,
                startingSpeed
                );
        }

        string RandomInheritString(string parentOneAttribute, string parentTwoAttribute)
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

        int RandomInheritInt(int parentOneAttribute, int parentTwoAttribute)
        {
            float randFloat = rand.NextSingle();

            float holdingFloat = 0;
            int returnInt = 0;

            if (randFloat < parentInheritChance)
            {
                Console.WriteLine("Inherited from Parent One");

                holdingFloat = parentOneAttribute + ((float)parentOneAttribute / 100 * 5);

                returnInt = (int)holdingFloat;

                return returnInt;
            }

            else if (randFloat < parentInheritChance * 2)
            {
                Console.WriteLine("Inherited from Parent Two");

                holdingFloat = parentTwoAttribute + ((float)parentTwoAttribute / 100 * 5);

                returnInt = (int)holdingFloat;

                return returnInt;
            }

            else
            {
                Console.WriteLine("Decided at random");
                return properties.RandomStartingHP();
            }
        }
    }
}
