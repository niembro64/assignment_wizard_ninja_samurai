using System;

namespace assignment_wizard_ninja_samurai
{
  class Program
  {
    static void Main(string[] args)
    {
      Wizard wiz = new Wizard("Wiz");
      Ninja nin = new Ninja("Nin");
      Samurai sam = new Samurai("Sam");

      wiz.Stats();
      nin.Stats();
      sam.Stats();

      nin.Attack(wiz);

      wiz.Stats();
      nin.Stats();
      sam.Stats();

      wiz.Attack(nin);

      wiz.Stats();
      nin.Stats();
      sam.Stats();

      sam.Attack(nin);

      wiz.Stats();
      nin.Stats();
      sam.Stats();

      wiz.Heal(nin);
      sam.Meditate();
      nin.Steal(sam);
      
      wiz.Stats();
      nin.Stats();
      sam.Stats();

    }
  }
}
