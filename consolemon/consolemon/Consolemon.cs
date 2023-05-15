namespace consolemon
{
    internal class ConsoleMon
    {
        public int health;
        public int Energy;
        public string Name;
        internal Element weakness;


        internal void TakeDamage(int damage)
        {
            health -= damage;
        }

        internal void DepleteEnergy(int energy)
        {
            Energy -= energy;
        }
    }
}
