using System;
using System.Collections.Generic;
using System.Text;

namespace Reederei
{
    class Reederei
    {
        private string m_Name;
        private string m_Sitz;

        internal Schiff[] schiffe;

        public void setName(string name)
        {
            if (name.Length == 0)
                throw new Exception("Ungültiger Name");
            m_Name = name;
        }

        public void setSitz(string sitz)
        {
            if (sitz.Length == 0)
                throw new Exception("Ungültiger Name");
            m_Sitz = sitz;
        }


        public string SITZ
        {
            get { return m_Sitz; }
            set { setSitz(value); }
        }
        public string NAME
        {
            get { return m_Name; }
            set { setName(value); }
        }

    }
}
