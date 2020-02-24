using System.Collections.Generic;

namespace Wolcen_Editor.Chest
{
    public class FromGems
    {
        public string EffectId { get; internal set; }
        public string EffectName { get; internal set; }
        public int MaxStack { get; internal set; }
        public List<Parameters> parameters { get; internal set; }
    }
}