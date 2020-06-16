using System.Collections.Generic;

namespace ConsoleLoopSystem.Model
{
  class World : Thing
  {
    public ICollection<Truth> Truths { get; set; }
    public ICollection<Settlement> Settlements { get; set; }
    public ICollection<Dungeon> Dungeons { get; set; }

    public World(string name, string definition) : base(name, definition)
    {
    }
  }
}
