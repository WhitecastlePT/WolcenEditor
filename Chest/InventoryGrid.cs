using System.Collections.Generic;

namespace Wolcen_Editor.Chest
{
    public class InventoryGrid
    {
        public int InventoryX { get; internal set; }
        public int InventoryY { get; internal set; }
        public int Rarity { get; internal set; }
        public int Quality { get; internal set; }
        public int Type { get; internal set; }
        public string ItemType { get; internal set; }
        public string Value { get; internal set; }
        public int Level { get; internal set; }
        public Gem Gem { get; internal set; }
        public Armor Armor { get; internal set; }
        public List<Sockets> sockets { get; internal set; }
        public MagicEffects magicEffects { get; internal set; }
        public Weapon Weapon { get; internal set; }
    }
}
