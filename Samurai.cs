using System;

namespace assignment_wizard_ninja_samurai
{

  class Samurai : Human
  {
    public Samurai(string n) : base(n, 3, 3, 3, 200)
    {

    }

    public override int Attack(Human target)
    {

      base.Attack(target);

      int extraDamage = 0;
      if (target.Health < 50)
      {

        extraDamage = target.Health;
        a.ss(extraDamage);
        target.ChangeHealth(-extraDamage);
      }

      Console.WriteLine($"{Name} attacked {target.Name} for {extraDamage} extra damage!");
      return target.Health;
    }

  public Samurai Meditate(){
    this.ChangeHealth(-this.Health + 200); 

    return this;
  }

  }

}
