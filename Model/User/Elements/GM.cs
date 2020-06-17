namespace ConsoleLoopSystem.Model
{
  class GM : User
  {
    public GM(string name, string definition, string nickname, string email, string password, string permission = "G") :
      base(name, definition, nickname, email, password, permission)
    {
      Type = "GM";
    }
  }
}
