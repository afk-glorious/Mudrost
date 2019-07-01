using System;
using System.ComponentModel.DataAnnotations;

namespace AFKWebApp.Models
{
    public class Hero
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public int Faction { get; set; }
        public int Class { get; set; }
        public int Rarity { get; set; }
        public int Range { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

    }
}