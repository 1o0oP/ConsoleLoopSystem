using System.Collections.Generic;

namespace ConsoleLoopSystem.Model
{
  class Dungeon : Place
  {
    public string Purpose { get; set; } // Para que este lugar está servindo? E para quem? Daqui vem o problema!
    public ICollection<Character> Peaple { get; set; } // Personagens com vínculo com este lugar

    public Dungeon(string name, string definition, string temperature,
      string luminosity, string tactility, string environment, string aspect, string history, string population) :
      base(name, definition, temperature, luminosity, tactility, environment, aspect, history, population)
    {
    }
  }
}
