namespace consolemon
{
    internal class ConsoleMon
    {
        public int health;
        public int energy;
        public string Name;
        internal Element weakness;
        private List<Skill> skills;


        internal void TakeDamage(int damage)
        {
            health -= damage;
        }

        internal void DepleteEnergy(int energy)
        {
            energy -= energy;
        }
    }
}
