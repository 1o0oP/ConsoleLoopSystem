using System;
using System.Collections.Generic;

namespace ConsoleLoopSystem.Model
{
  class Game : Thing
  {
    public ICollection<User> Users { get; set; }
    public World World { get; set; }

    public Game(string name, string definition, World world) : base(name, definition)
    {
      Type = "Game";
      World = world;
    }
  }
}
