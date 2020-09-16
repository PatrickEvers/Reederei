using System;
using System.Collections.Generic;
using System.Text;

namespace Reederei
{
    abstract class Schiff
    {
        private string m_Name;
        private int m_Ladekapazität;
        private double a_Geschwindigkeit;
        public double Länge;
        public double Tiefgang;
        public string Land;
        public string Bestimmungshafen;
        public string Status;
        public int Geschwindigkeit;
        public int Ladung;
        public Besatzungsmitglied[] besatzung;
        public Position Position;

        public void setName(string name)
        {
            if(name.Length == 0)
            {
                throw new Exception("Ungültiger Schiffsname");
            }

            m_Name = name;
        }

        public string getName()
        {
            return m_Name;
        }

        public void setLadekapazität(int Kap)
        {
            if(Kap <= 0)
            {
                throw new Exception("Ungültiger Ladekapazitätswert");
            }

            m_Ladekapazität = Kap;
        }

        public int getLadekapazität()
        {
            return m_Ladekapazität;
        }

        public void SetGeschindigkeitKN(double kn)
        {
            if(kn > 15 || kn < -5)
            {
                throw new Exception("Ungültiger Geschindigkeitswert");
            }

            a_Geschwindigkeit = kn;
        }

        public double GetGeschindigkeitKN()
        {
            return a_Geschwindigkeit;
        }

        public double GetGeschwindigkeitKMH()
        {
            return a_Geschwindigkeit * 1.85;
        }

        public abstract void Beladen();

        public int Beladen(int Tonnen)
        {
            if(Tonnen <= 0)
            {
                throw new Exception("Ungültiger Ladungswert");
            }

            if(Ladung + Tonnen > m_Ladekapazität)
            {
                Ladung = Ladekapazität;
                return Ladung + Tonnen - m_Ladekapazität - m_Ladekapazität;
            }
            else
            {
                Ladung += Tonnen;

                return 0;
            }
        }

        public int Entladen(int Tonnen)
        {
            if (Tonnen <= 0)
            {
                throw new Exception("Ungültiger Ladungswert");
            }

            if (Ladung - Tonnen <= 0)
            {
                Ladung = 0;
                return Tonnen - Ladung;
            }
            else
            {
                Ladung -= Tonnen;

                return Tonnen;
            }

        }

        public void Bewegen(Position _Position)
        {
            Position p_alt = new Position();
            p_alt.OW = Position.OW;
            p_alt.NS = Position.NS;

            Position.OW = _Position.OW;
            Position.NS = _Position.NS;

            Console.WriteLine("Das Schiff hat sich von OW: {0} NS : {1} nach OW: {2} NS: {3} bewegt!", p_alt.OW, p_alt.NS, Position.OW, Position.NS);
        }


        public int Ladekapazität
        {
            get
            {
                return m_Ladekapazität;
            }
            set
            {
                setLadekapazität(value);
            }
        }

        public string Name
        {
            get
            {
                return m_Name;
            }
            set
            {
                setName(value);
            }
        }


    }

    class Position
    {
        public string OW;
        public string NS;
    }
}
