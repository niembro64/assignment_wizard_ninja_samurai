using System;

namespace assignment_wizard_ninja_samurai
{

  class Wizard : Human
  {
    public Wizard(string n) : base(n, 3, 25, 3, 50)
    {

    }

    public override int Attack(Human target)
    {
      int dmg = Intelligence * 5;
      target.ChangeHealth(-dmg);
      Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
      return target.Health;
    }

    public int Heal(Human target){
      target.ChangeHealth(10);

      return target.Health;
    }

  }

}
