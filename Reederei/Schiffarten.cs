using System;
using System.Collections.Generic;
using System.Text;

namespace Reederei
{
    class Containerschiff : Schiff
    {
        public int Kapazität;
        public Container[] Container;
        public override void Beladen()
        {
            Ladung ++;
        }
    }

    class Container
    {
        public int ID;
        public string Bestimmungsort;
        public string Inhaltsbeschreibung;
    }

    class Tanker : Schiff
    {
        public new int Ladung;

        public override void Beladen()
        {
            Ladung++;
        }
    }

    class Passagierschiff : Schiff
    {
        public int Plätze;
        public Passagier[] passagier;

        public override void Beladen()
        {
            Ladung++;
        }
    }

    class Passagier
    {
        public string Name;
        public Kabine Kabine;
    }

    class Kabine
    {
        public int Nummer;
        public bool Innenkabine;
    }
}
