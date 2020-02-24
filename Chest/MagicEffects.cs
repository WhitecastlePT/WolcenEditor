using System.Collections.Generic;

namespace Wolcen_Editor.Chest
{
    public class MagicEffects
    {
        public List<Default> Default { get; internal set; }
        public List<RolledAffixes> rolledAffixes { get; internal set; }
        public List<FromGems> FromGems { get; internal set; }
        
    }
}