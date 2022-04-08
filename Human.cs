using System;

namespace assignment_wizard_ninja_samurai
{

  class Human
  {
    public string Name;
    public int Strength;
    public int Intelligence;
    public int Dexterity;
    private int health;

    public int Health
    {
      get { return health; }
    }

    public Human(string name)
    {
      Name = name;
      Strength = 3;
      Intelligence = 3;
      Dexterity = 3;
      health = 100;
    }

    public Human(string name, int str, int intel, int dex, int hp)
    {
      Name = name;
      Strength = str;
      Intelligence = intel;
      Dexterity = dex;
      health = hp;
    }

    // Build Attack method
    public virtual int Attack(Human target)
    {
      int dmg = Strength * 3;
      target.health -= dmg;
      Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
      return target.health;
    }

    public void ChangeHealth(int amount)
    {
      this.health += amount;
    }

    public Human Stats()
    {
      a.sss();
      a.ss($"         Name: {this.Name}");
      a.ss($"     Strength: {this.Strength}");
      a.ss($" Intelligence: {this.Intelligence}");
      a.ss($"    Dexterity: {this.Dexterity}");
      a.ss($"       Health: {this.Health}");
      a.sss();
      return this;
    }
  }

}

// Name = name;
// Strength = str;
// Intelligence = intel;
// Dexterity = dex;
// health = hp;