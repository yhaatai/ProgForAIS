using System;
using Core;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Logic logic = new Logic();
            logic.AddSims("Майдар", 20, "М");
            logic.AddSims("Коля", 20, "М");
            logic.AddSims("Надя", 15, "Д");
            logic.AddSims("Люда", 55, "Д");


            foreach (var sim in logic.GetSims())
            {
                Console.WriteLine(sim);
            }

            foreach (var sim in logic.GetSex("М"))
            {
                Console.WriteLine(sim);
            }

            foreach (var sim in logic.GetAdult())
            {
                Console.WriteLine(sim);
            }
        }
    }
}
    