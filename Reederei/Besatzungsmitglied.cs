using System;
using System.Collections.Generic;
using System.Text;

namespace Reederei
{
    class Besatzungsmitglied
    {
        private string m_Name;
        public void setName(string name)
        {
            if (name.Length == 0)
                throw new Exception("Ungültiger Name");
            m_Name = name;
        }

        public string getName()
        {
            return m_Name;
        }
    }

    class Kapitän : Besatzungsmitglied
    {

    }
}
