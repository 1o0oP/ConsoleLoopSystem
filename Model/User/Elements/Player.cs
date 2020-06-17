namespace ConsoleLoopSystem.Model
{
  class Player : User
  {
    public Player(string name, string definition, string nickname, string email, string password, string permission) :
      base(name, definition, nickname, email, password, permission)
    {
      Type = "Player";
    }
  }
}
