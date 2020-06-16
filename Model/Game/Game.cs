using System;
using System.Collections.Generic;

namespace ConsoleLoopSystem.Model
{
  class Game : Thing
  {
    public DateTime BirthDate { get; set; } // Data de criação
    public ICollection<User> Users { get; set; }
    public World World { get; set; }
  }
}
