﻿using System;
public interface AdvancedArithmetic
{
    int divisorSum(int n);
}

public class Calculators : AdvancedArithmetic
{
    public int divisorSum(int n)
    {
        int halfN = n / 2;
        int sum = n;

        for (int i = 1; i <= halfN; i++)
        {
            if (n % i == 0)
                sum += i;
        }

        return sum;
    }
}

class Day19_Interfaces
{
    static void Main(string[] args)
    {
        int n = Int32.Parse(Console.ReadLine());
        AdvancedArithmetic myCalculator = new Calculators();
        int sum = myCalculator.divisorSum(n);
        Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum);
    }
}