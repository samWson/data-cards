using System;
using System.Collections.Generic;

namespace DataCards.Models
{
    public class DataCard
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Points { get; set; }
        // FIXME: This model can't be saved as the table hasn't been made yet.
        // I don't know if I need to define the talbe in the context with the 
        // Fluent API, use annotations on the model, or if I need to make the
        // table through migrations.

        /* TODO: Uncomment properties from this list as they are implemented.
        public Dictionary<string, int> Attributes { get; set; }
        public List<Dictionary<string, string>> Equipment { get; set; }
        public List<string> Abilities { get; set; }
        public List<string> Specialism { get; set; }
        public List<string> Demeanour { get; set; }
        public int Experience { get; set; }
        public int FleshWounds { get; set; }
        public bool Convalecense { get; set; }
        public bool NewRecruit { get; set; }
        */

    }
}
