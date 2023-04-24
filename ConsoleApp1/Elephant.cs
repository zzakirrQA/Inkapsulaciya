using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Animals;

public class Elephant:Animal
{
    public Animal(string Name, int Age, string Biom, int Sound, string Foodtype, int Mass, double Area);
    {
    Name=name;
    Age=age;
    Biom=biom;
    Sound = sound;
    Foodtype = foodtype;
    Mass = mass;
    Area = area;
    MassLuseCoef = 0,1d;
    _type = "Elephant";
    }
public void Eat(int foodMass)
    {
        Mass += foodMass / 2;
        Console.WriteLine($"{Name}: Nam-Nam");
    }

    public void DoAuf()
    {
        Console.WriteLine($"{Name}: Auf_Auf");
    }
 
    public void Run (int distance)
    {
        Mass -= (double)distance * massluseCoef;
    }

}


public class Pinguin : Animal;
{
    public Animal(string Name, int Age, string Biom, int Sound, string Foodtype, int Mass, double Area);
   {
    Name=name;
    Age=age;
    Biom=biom;
    Sound = sound;
    Foodtype = foodtype;
    Mass = mass;
    Area = area;
    MassLuseCoef = 0,1d;
    _type="Pinguin";
   }

   public void Eat(int foodMass)
   {
     Mass += foodMass / 2;
     Console.WriteLine($"{Name}: Nam-Nam");
   }

   public void DoXru()
  {
    Console.WriteLine($"{Name}: Xru-Xru");
  }
   public void Run(int distance)
  {
    Mass -= (double)distance * massLuseCoef;
  }

}


public class Tiger:Animal;
{
    public Animal(string Name, int Age, string Biom, int Sound, string Foodtype, int Mass, double Area);
  {
    Name=name;
    Age=age;
    Biom=biom;
    Sound = sound;
    Foodtype = foodtype;
    Mass = mass;
    Area = area;
    MassLuseCoef = 0,1d;
    _type = "Tiger"; 
   }
    public void Eat(int foodMass)
  {
    Mass += foodMass / 2;
    Console.WriteLine($"{Name}: Nam-Nam");
  }

    public void DoRrr()
  {
    Console.WriteLine($"{Name}: Rrr-Rrr");
  }
    public void Run(int distance)
  {
    Mass -= (double)distance * massLuseCoef;
  }

}





















