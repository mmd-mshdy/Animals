using Animals;
using static Animals.Mammals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Mammals Horse = new Mammals();
        Horse.legs = 4;
        Horse.Name = "Mustang";

        Aves Eagle = new Aves();
        Eagle.legs = 2;
        Eagle.Name = "My eagle";

        Reptiles Snake = new Reptiles();
        Snake.legs = 0;
        Snake.Name = "Cobra";

        Console.WriteLine("my"+Horse.Name+"has"+ Horse.legs+"legs and it lives on : ");
        Horse.Habitant();
        Console.WriteLine("my" + Eagle.Name + "has" + Eagle.legs + "legs and it lives in : ") ;
        Eagle.Habitant();
        Console.WriteLine("my" + Snake.Name + "has" + Snake.legs + "legs and it lives in : ");
        Snake.Habitant();



    }
     
}
