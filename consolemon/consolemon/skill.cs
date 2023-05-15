using System;

namespace consolemon
{
    internal class Skill
    {
        public int damage;
        public int energyCost;
        public string name;

        public Skill(int damage, int energyCost, string name)
        {
            this.damage = damage;
            this.energyCost = energyCost;
            this.name = name;
        }
        internal Element element;

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

        internal void UseOn(ConsoleMon targetMon, ConsoleMon casterMon, object element)
        {
            throw new NotImplementedException();
        }
    }
}

