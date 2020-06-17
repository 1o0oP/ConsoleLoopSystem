using System.Collections.Generic;
using System.Linq;

namespace ConsoleLoopSystem.Model
{
  class Character : Thing
  { // Distribuir 0, 1, 2, 3
    public int Strength { get; set; } = 0; // Força física, Brutalidade
    public int Dexterity { get; set; } = 0; // Agilidade, cuidado, delicadeza
    public int Intelligence { get; set; } = 0; // Esperteza, Percepção, Intuição
    public int Sociability { get; set; } = 0; // Empatia, Sedução, Persuasão
    public string Role { get; set; } // Todo mundo tem um papel no mundo (Info IN-GAME)
    public ICollection<string> Descriptors { get; set; } // Ao menos três adjetivos que descrevem o personagem
    public ICollection<Virtue> Virtues { get; set; } // Todos temos nossas virtudes
    public ICollection<Choice> Choices { get; set; } // Nossas Escolhas acertadas!
    public ICollection<Bond> Bonds { get; set; } // Todos já fizemos alguma coisa que não esquecemos
    public ICollection<Vow> Vows { get; set; } // Todos temos nossos sonhos e ambições

    public Character(string name, string definition, int strength, int dexterity, int intelligence, int sociability,
      string role) :
      base(name, definition)
    {
      Type = "Character";
      Strength = strength;
      Dexterity = dexterity;
      Intelligence = intelligence;
      Sociability = sociability;
      Role = role;
    }

    public int Level()
    { // Level = 2*(# de Powers) + (# de Features) - 9
      return 2*(Virtues.Sum(virtue => virtue.Powers.Count) + Choices.Sum(choice => choice.Powers.Count)) +
        (Virtues.Count + Choices.Count) - 9;
    }
    public bool ExistsFeatureById(int id)
    { // Verifica se existe um certo Feature dentre os Features do personagem
      if (Virtues.Any(virtue => virtue.Id == id) || Choices.Any(virtue => virtue.Id == id))
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    public void AddVirtue(Virtue virtue)
    {
      Virtues.Add(virtue);
    }

    public void RemoveVirtue(Virtue virtue)
    {
      Virtues.Remove(virtue);
    }

    public void AddChoice(Choice choice)
    {
      Choices.Add(choice);
    }

    public void RemoveChoice(Choice choice)
    {
      Choices.Remove(choice);
    }
  }
}
