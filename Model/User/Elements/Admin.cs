namespace ConsoleLoopSystem.Model
{
  class Admin : User
  {
    public Admin(string name, string definition, string nickname, string email, string password, string permission = "A") :
      base(name, definition, nickname, email, password, permission)
    {
      Type = "Admin";
    }
  }
}
