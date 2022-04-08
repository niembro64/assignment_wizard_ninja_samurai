
using System;
using System.Collections.Generic;

namespace assignment_wizard_ninja_samurai
{
  public static class a
  {

    public static double s(double a)
    {
      Console.Write(a);
      return a;
    }
    public static string s(string a)
    {
      Console.Write(a);
      return a;
    }
    public static int s(int a)
    {
      Console.Write(a);
      return a;
    }
    public static int[] s(int[] a)
    {
      for (int i = 0; i < a.Length; i++)
      {
        Console.Write($"{a[i]} ");
      }
      return a;
    }
    public static List<string> s(List<string> a)
    {
      for (int i = 0; i < a.Count; i++)
      {
        Console.Write($"{a[i]} ");
      }
      return a;
    }
    public static string[] s(string[] a)
    {
      for (int i = 0; i < a.Length; i++)
      {
        Console.Write($"{a[i]} ");
      }
      return a;
    }

    ////////////////////////////

    public static void ss()
    {
      Console.Write("\n");
    }
    public static double ss(double a)
    {
      Console.Write(a);
      return a;
    }
    public static string ss(string a)
    {
      Console.WriteLine(a);
      return a;
    }
    public static int ss(int a)
    {
      Console.WriteLine(a);
      return a;
    }
    public static int[] ss(int[] a)
    {
      for (int i = 0; i < a.Length; i++)
      {
        Console.WriteLine($"{a[i]} ");
      }
      return a;
    }
    public static List<string> ss(List<string> a)
    {
      for (int i = 0; i < a.Count; i++)
      {
        Console.WriteLine($"{a[i]} ");
      }
      return a;
    }
    public static string[] ss(string[] a)
    {
      for (int i = 0; i < a.Length; i++)
      {
        Console.WriteLine($"{a[i]} ");
      }
      return a;
    }

    //////////////////
    public static void sss()
    {
      Console.WriteLine("___________________________");
    }

  }
}
