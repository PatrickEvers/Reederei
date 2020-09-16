using System;

namespace Reederei
{
    class Program
    {
        static void Main(string[] args)
        {
            Reederei reederei = new Reederei();

            reederei.NAME = "HADAG Seetouristk und Fährdienst AG";
            reederei.SITZ = "Hamburg";
            reederei.schiffe = new Schiff[3];

            Passagierschiff schiff = createShip(
                "HAMBURGENSIE",
                29.92,
                1.7,
                12,
                "Deutschland",
                "Bremen"
                );

            Passagierschiff schiff2 = createShip(
                "ST. PAULI",
                29.97,
                1.7,
                12,
                "Deutschland",
                "Bremen"
                );

            shipBesatzung(schiff, 5);

            schiff.passagier = new Passagier[5];

            for (int i = 0; i < schiff.passagier.Length; i++)
            {
                schiff.passagier[i] = new Passagier();
                schiff.passagier[i].Name = "Passagier" + i;
                schiff.passagier[i].Kabine = new Kabine();
                schiff.passagier[i].Kabine.Nummer = i + 1;
                schiff.passagier[i].Kabine.Innenkabine = true;
            }

            
            reederei.schiffe[0] = schiff;
            
            for (int i = 0; i < schiff.besatzung.Length; i++)
            {
                Console.WriteLine(schiff.besatzung[i] + "\t" + schiff.besatzung[i].getName());
            }

            for (int i = 0; i < schiff.passagier.Length; i++)
            {
                Console.WriteLine(schiff.passagier[i].Name + "\t Kabine Nr.: " + schiff.passagier[i].Kabine.Nummer + "\t Innenkabine: " + schiff.passagier[i].Kabine.Innenkabine);
            }


            Position p = new Position();
            p.OW = "3";
            p.NS = "4";

            schiff.Bewegen(p);

        }

        public static Passagierschiff createShip(string shipName, double shipLength, double shipTiefgang, int shipSpeed, string shipCountry, string shipTarget)
        {
            Passagierschiff schiff = new Passagierschiff();
         
            schiff.Name = shipName;
            schiff.Länge = shipLength;
            schiff.Tiefgang = shipTiefgang;
            schiff.Geschwindigkeit = shipSpeed;
            schiff.Land = shipCountry;
            schiff.Bestimmungshafen = shipTarget;


            schiff.Position = new Position();
            schiff.Position.OW = "1";
            schiff.Position.NS = "2";

            return schiff;
        }

        public static void shipBesatzung(Passagierschiff p, int mitglieder)
        {
            p.besatzung = new Besatzungsmitglied[mitglieder];

            p.besatzung[0] = new Kapitän();
            p.besatzung[0].setName("Kap. Sora");

            p.besatzung[1] = new Besatzungsmitglied();
            p.besatzung[1].setName("Shiro");
            p.besatzung[2] = new Besatzungsmitglied();
            p.besatzung[2].setName("Jibril");
            p.besatzung[3] = new Besatzungsmitglied();
            p.besatzung[3].setName("Steph");
            p.besatzung[4] = new Besatzungsmitglied();
            p.besatzung[4].setName("Izuna");
        }
    }
}
