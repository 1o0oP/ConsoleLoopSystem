namespace ConsoleLoopSystem.Model
{
  class Thing
  {
    public int Id { get; set; } // Chave primária
    public string Name { get; set; } // Nome da coisa
    public string Definition { get; set; } // Frase curta que define a coisa

    public Thing(string name, string definition)
    {
      Name = name;
      Definition = definition;
    }
  }
}
