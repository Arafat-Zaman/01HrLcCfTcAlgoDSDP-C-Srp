

using System;
using System.Collections.Generic;
using System.IO;

class _4ClassVsInstance
{
    public int age = 0;
    public _4ClassVsInstance(int initialAge)
    {
        if (initialAge >= 0)
        {
            age = initialAge;
        }
        else
        {
            Console.WriteLine("Age is not valid, setting age to 0.");
            age = 0;
        }
    }
    public void amIOld()
    {
        if (age < 13)
        {
            Console.WriteLine("You are young.");
        }
        else if (age >= 13 && age < 18)
        {
            Console.WriteLine("You are a teenager.");
        }
        else
        {
            Console.WriteLine("You are old.");
        }
    }

    public void yearPasses()
    {
        age += 1;
    }


    static void Main(String[] args)
    {
        int T = int.Parse(Console.In.ReadLine());
        for (int i = 0; i < T; i++)
        {
            int age = int.Parse(Console.In.ReadLine());
            _4ClassVsInstance p = new _4ClassVsInstance(age);
            p.amIOld();
            for (int j = 0; j < 3; j++)
            {
                p.yearPasses();
            }
            p.amIOld();
            Console.WriteLine();
        }
    }
}
