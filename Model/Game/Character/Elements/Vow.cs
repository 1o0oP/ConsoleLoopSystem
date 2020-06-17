using System.Collections.Generic;
using System.Linq;

namespace ConsoleLoopSystem.Model
{
  class Vow : Thing
  { // Um juramento específico
    public string Rank { get; set; } // Troublesome, Dangerous, Formidable, Extreme, Epic
    public string Verb { get; set; } // Kill, Rescue, Clean, Hold, Prevent, Unleash, Release, Deliver, etc ...
    public string Description { get; set; } // Descrição do juramento em poucas palavras
    public ICollection<Character> Targets { get; set; }
    public ICollection<Place> Territories { get; set; }

    public Vow(string name, string definition, string rank, string verb, string description) : 
      base(name, definition)
    {
      Type = "Vow";
      Rank = rank;
      Verb = verb;
      Description = description;
    }

    public bool ExistsTargetOrTerritoryById(int id)
    {
      if (Targets.Any(target => target.Id == id) || Territories.Any(territory => territory.Id == id))
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    public void AddTarget(Character target)
    {
      Targets.Add(target);
    }

    public void RemoveTarget(Character target)
    {
      Targets.Remove(target);
    }

    public void AddTerritory(Place territory)
    {
      Territories.Add(territory);
    }

    public void RemoveTerritory(Place territory)
    {
      Territories.Remove(territory);
    }
  }
}
