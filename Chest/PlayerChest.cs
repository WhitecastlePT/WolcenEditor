using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wolcen_Editor.Chest
{
    public class PlayerChest
    {
        public string Version { get; internal set; }
        public string InventoryVersion { get; internal set; }
        public string ItemsVersion { get; internal set; }
        public Panels Panels { get; internal set; }
    }
}
