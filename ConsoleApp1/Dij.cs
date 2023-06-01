using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Dij
    {
        int evPriv;
        string tipusPriv, keresztnevPriv, vezeteknevPriv;
        public Dij(string bevitel)
        {
            string[] bontott = bevitel.Split(';');
            this.evPriv = int.Parse(bontott[0]);
            this.tipusPriv = bontott[1];
            this.keresztnevPriv = bontott[2];
            this.vezeteknevPriv = bontott[3];
        }

        public int Ev { get => evPriv; }
        public string Tipus { get => tipusPriv; }
        public string Keresztnev { get => keresztnevPriv; }
        public string Vezeteknev { get => vezeteknevPriv; }
    }
}
