using System;
using System.Collections.Generic;

namespace DataCards.Models
{
    public class DataCard
    {
        public string Name { get; set; }
        public int Points { get; set; }
        public Dictionary<string, int> Attributes { get; set; }
        public List<Dictionary<string, string>> Equipment { get; set; }
        public List<string> Abilities { get; set; }
        public List<string> Specialism { get; set; }
        public List<string> Demeanour { get; set; }
        public int Experience { get; set; }
        public int FleshWounds { get; set; }
        public bool Convalecense { get; set; }
        public bool NewRecruit { get; set; }
    }
}
