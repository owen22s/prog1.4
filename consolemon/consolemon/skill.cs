using System;

namespace consolemon
{
    internal class Skill
    {
        public int damage;
        public int energyCost;
        public string name;

        internal Element element;
        public Skill(int damage, int energyCost, string name)
        {
            this.damage = damage;
            this.energyCost = energyCost;
            this.name = name;
        }

        internal void UseOn(ConsoleMon target, ConsoleMon caster)
        {
            caster.DepleteEnergy(energyCost);

            if (target.weakness == element)
            {
                int reducedDamage = damage / 2;
                target.TakeDamage(reducedDamage);
            }
            
            target.TakeDamage(damage);
            
        }

    }
}

