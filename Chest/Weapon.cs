namespace Wolcen_Editor.Chest
{
    public class Weapon
    {
        public string Name { get; internal set; }
        public int DamageMin { get; internal set; }
        public int DamageMax { get; internal set; }
        public int ResourceGeneration { get; internal set; }
        public int ShieldResistance { get; internal set; }
        public int ShieldBlockChance { get; internal set; }
        public int ShieldBlockEfficiency { get; internal set; }
    }
}