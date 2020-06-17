namespace ConsoleLoopSystem.Model
{
  class Problem : Thing
  {
    public string Description { get; set; } // Ex: Somebody is missing

    public Problem(string name, string definition, string description) : base(name, definition)
    {
      Type = "Problem";
      Description = description;
    }
  }
}
