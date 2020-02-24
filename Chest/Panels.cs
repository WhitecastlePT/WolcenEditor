using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wolcen_Editor.Chest
{
    public class Panels
    {
        public string Id { get; internal set; }
        public Boolean Locked { get; internal set; }
        public List<InventoryGrid> InventoryGrid { get; internal set; }
    }
}
