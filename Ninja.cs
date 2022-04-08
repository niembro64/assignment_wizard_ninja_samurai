using System;

namespace assignment_wizard_ninja_samurai
{

  class Ninja : Human
  {
    public Ninja(string n) : base(n, 3, 3, 175, 100)
    {

    }

    public override int Attack(Human target)
    {
      Random rand = new Random();

      int dmg = Dexterity * 5;
      int extra = (rand.Next(0, 5) == 0 ? 10 : 0);
      target.ChangeHealth(-dmg - extra);
      Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
      return target.Health;
    }

    public Ninja Steal(Human target)
    {

      this.ChangeHealth(5);
      target.ChangeHealth(-5);
      return this;
    }

  }

}

