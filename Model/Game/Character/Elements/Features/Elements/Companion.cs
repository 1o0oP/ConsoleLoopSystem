using System.Collections.Generic;

namespace ConsoleLoopSystem.Model
{
  class Companion : Choice
  {
    public int Health { get; set; } = 5; // Um companion tem seu HP
    public int Spirit { get; set; } = 5; // Um companion tem seu Spirit
    public string Role { get; set; } // Papel no mundo
    public ICollection<string> Descriptors { get; set; } // Ao menos três adjetivos
    public Companion(string name, string definition, int health, int spirit, string role) : 
      base(name, definition)
    {
      Health = health;
      Spirit = spirit;
      Role = role;
    }
  }
}
