using AFKArena.Enums;

namespace AFKArena.Models
{
    public class Hero
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public Tier Tier { get; set; } 
        public Type Type { get; set; } 
        public Faction Faction { get; set; }
        public long Health { get; set; }
        public long Attack { get; set; }
        public long Defense { get; set; }
        public double CritRating { get; set; }
        public long Accuracy { get; set; }
        public long Dodge { get; set; }
        public long Haste { get; set; }
        public long Recovery { get; set; }
        public double MagicResist { get; set; }
        public double PhysicalResist { get; set; }
        public long LifeLeech { get; set; }
    }
}