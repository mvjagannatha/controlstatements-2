using System;
class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter first numbe: ");
        int firstnumber = int.Parse(Console.ReadLine());
        Console.WriteLine("enter second number:");
        int secondnumber = int.Parse(Console.ReadLine());

        bool isinunits = (firstnumber) % 10 == secondnumber;
        bool isintens = (firstnumber / 10) % 10 == secondnumber;
        bool isinhundreds = (firstnumber / 100) % 10 == secondnumber;
        bool isinthousands = (firstnumber / 1000) % 10 == secondnumber;
        Console.WriteLine($"{secondnumber} is {(isinunits?" ":" not")} present in units place of {firstnumber }");
        Console.WriteLine($"{secondnumber} is {(isintens?" " :" not")} present in tens place of {firstnumber }");
        Console.WriteLine($"{secondnumber} is {(isinhundreds?"" :"not")} present in hundreds place of {firstnumber }");
        Console.WriteLine($"{secondnumber} is {(isinthousands?"" :"not")} present in thousands place of {firstnumber }");
    }
    }
