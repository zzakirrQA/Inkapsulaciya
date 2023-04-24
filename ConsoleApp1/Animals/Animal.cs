using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Animals
{
    public class Animal
    {
        public string Name { get; protected set; }
        public int Age { get; protected set; }

        public string Biom { get; protected set; }

        public int Sounnd { get; protected set; }

        public string Foodtype { get; protected set; }

        public int Mass { get; protected set; }

        public double Area { get; protected set; }

        private double _masslusecoef { get; set; }

        protected string _type;
    }
    public  Animal (string Name, int Age, string Biom, int Sound, string Foodtype, int Mass, double Area);
    {
    Name=name;
    Age=age;
    Biom=biom;
    Sound = sound;
    Foodtype = foodtype;
    Mass = mass;
    Area = area;
    MassLuseCoef = 0,1d
    }
}
