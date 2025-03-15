using System;
using TPMod5_103022300023;

class Program
{
    static void Main()
    {
        HaloGeneric welcome = new HaloGeneric();
        welcome.SapaUser("Muhammad Azwa Radya Razadisya");

        DataGeneric<string> data = new DataGeneric<string>("103022300023");
        data.PrintData();

        Console.ReadLine();
    }
}
