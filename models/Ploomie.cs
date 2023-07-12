using System;
using System.Collections.Generic;
using System.Linq;

namespace Ploomtopia.Models
{
    public class Ploomie
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<string>? Traits { get; set; }
        public int? HungerLevel { get; set; }
        public int? HappinessLevel { get; set; }
    }
}
