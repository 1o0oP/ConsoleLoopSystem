using System.Collections.Generic;

namespace ConsoleLoopSystem.Model
{
  class Feature : Thing
  {
    public ICollection<Power> Powers { get; set; }

    public Feature(string name, string definition) : base(name, definition)
    {
    }
  }
}
