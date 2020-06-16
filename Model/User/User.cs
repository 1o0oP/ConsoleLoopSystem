using System.Collections.Generic;

namespace ConsoleLoopSystem.Model
{
  class User : Thing
  {
    public string Nickname { get; set; }
    public string Email { get; set; }
    public string Password { private get; set; }
    public ICollection<Game> Games { get; set; }

    public User(string name, string definition, string nickname, string email, string password) : 
      base(name, definition)
    {
      Nickname = nickname;
      Email = email;
      Password = password;
    }
  }
}
