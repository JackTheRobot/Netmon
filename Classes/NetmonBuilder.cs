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

            string skinColour = "";
            string hairColour = "";
            string hairLocation = "";
            string movementType = "";
            string numEyes = "";

            skinColour = properties.RandomSkinColour();

            hairColour = properties.RandomHairColour();

            hairLocation = properties.RandomHairLocation();

            movementType = properties.RandomMovementType();

            numEyes = properties.RandomNumEyes();

            int startingHP = properties.RandomStartingHP();
            int startingAttack = properties.RandomStartingAttackStat();
            int startingDefence = properties.RandomStartingDefenceStat();
            int startingSpeed = properties.RandomStartingSpeed();

            Netmon newNetmon = new(skinColour,
                hairColour,
                hairLocation,
                movementType,
                numEyes,
                startingHP,
                startingAttack,
                startingDefence,
                startingSpeed);


            return newNetmon;
        }
    }
}
