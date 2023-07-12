using System;
using System.Collections.Generic;
using System.Linq;

namespace Ploomtopia.Models
{
    public class Ploomie
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Traits { get; set; }
        public int? HungerLevel { get; set; }
        public int? HappinessLevel { get; set; }

        public List<string>? GetTraitsList()
        {
            if (Traits == null)
                return null;

            return Traits.Split(',').ToList();
        }

        public void SetTraitsList(List<string>? traitsList)
        {
            if (traitsList == null)
                Traits = null;
            else
                Traits = string.Join(",", traitsList);
        }
    }
}
