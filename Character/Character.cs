using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wolcen_Editor.Character
{
    public class Character
    {
        public string Name { get; internal set; }
        public string PlayerId { get; internal set; }
        public string CharacterId { get; internal set; }
        public int DifficultyMode { get; internal set; }
        public int League { get; internal set; }
        public DateTime UpdatedAt { get; internal set; }
    }
}
