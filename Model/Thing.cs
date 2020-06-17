using System;
using System.Globalization;

namespace ConsoleLoopSystem.Model
{
  class Thing
  {
    public int Id { get; set; } // Chave primária
    public string Name { get; set; } // Nome da coisa
    public string Definition { get; set; } // Frase curta que define a coisa
    public string Type { get; set; } = "Thing"; // Tipo registrado
    public DateTime BirthDate { get; set; } // Data da instanciação

    public Thing(string name, string definition)
    {
      BirthDate = DateTime.Now;
      Name = name;
      Definition = definition;
    }

    public string Age()
    {
      return (DateTime.Now - BirthDate).TotalDays.ToString("F2", CultureInfo.InvariantCulture);
    }

    public override string ToString()
    {
      return Name;
    }
  }
}
