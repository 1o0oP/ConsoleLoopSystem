namespace ConsoleLoopSystem.Model
{
  class Bond : Thing
  {
    public bool Result { get; set; } // Positivo? (Atração) ou Negativo? (Repulsão)
    public Problem Problem { get; set; } // Problema com o qual você estava lidando
    public Character From { get; set; } // Vínculo de quem?
    public Thing With { get; set; } // Character | Place

    public Bond(string name, string definition, bool result) : base(name, definition)
    {
      Type = "Bond";
      Result = result;
    }
  }
}
