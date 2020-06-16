using System.Collections.Generic;

namespace ConsoleLoopSystem.Model
{
  class Settlement : Place
  {
    public string Problem { get; set; } // Problema de assentamento
    public ICollection<Character> Peaple { get; set; } // Personagens com vínculo com este lugar

    public Settlement(string name, string definition, string temperature, string luminosity, 
      string tactility, string environment, string aspect, string population, string history, string problem) : 
      base(name, definition, temperature, luminosity, tactility, environment, aspect, history, population)
    {
      Problem = problem;
    }
  }
}
