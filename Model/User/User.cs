using System.Collections.Generic;

namespace ConsoleLoopSystem.Model
{
  class User : Thing
  {
    public string Nickname { get; set; }
    public string Email { get; set; }
    public string Password { private get; set; }
    public string Permission { get; private set; } = "P"; // Player (P), GM (G), Admin (A)
    public ICollection<Game> Games { get; set; }

    public User(string name, string definition, string nickname, string email, string password, string permission = "P") : 
      base(name, definition)
    {
      Type = "User";
      Nickname = nickname;
      Email = email;
      Password = password;
      Permission = permission;
    }
  }
}
