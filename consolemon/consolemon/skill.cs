using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace consolemon
{
    internal class Skill
    {
        int Damage;
        int Energycost;
        string Name;
        public Skill(int damage, int engerycost, string name)
        {
            this.Damage = damage;
            this.Energycost = engerycost;
            this.Name = name;
        }
        internal void Useon(string target, string caster)
        {
            //mon.DepleteEnergy();
        }

    }
}
