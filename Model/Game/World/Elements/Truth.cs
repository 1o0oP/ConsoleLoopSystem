namespace ConsoleLoopSystem.Model
{
  class Truth : Thing
  {
    public string Theme { get; set; }
    public string Description { get; set; }

    public Truth(string name, string definition, string theme, string description) :
      base(name, definition)
    {
      Theme = theme;
      Description = description;
    }
  }
}
