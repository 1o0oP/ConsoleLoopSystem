namespace ConsoleLoopSystem.Model
{
  class Power : Thing
  {
    public string Description { get; set; } // O que o poder faz

    public Power(string name, string definition, string description) : base(name, definition)
    {
      Type = "Power";
      Description = description;
    }

    public void Effect() // Modifie some Move
    {
    }
  }
}
