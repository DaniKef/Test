using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Daniil";
            var age = 19;
            var isHuman = true;

            Type nameType = name.GetType();
            Type ageType = age.GetType();
            Type isHumanType = isHuman.GetType();

            Console.WriteLine("---------------");
            Console.WriteLine("Name type is " + nameType.ToString());
            Console.WriteLine("Age type is " + ageType.ToString());
            Console.WriteLine("IsHuman type is " + isHumanType.ToString());
            return;
        }
    }
}
