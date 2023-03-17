/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
/*
//1-ое
using System;

class HelloWorld 
{ 
    static void Main() 
    {
        string j = Console.ReadLine();
        string s = Console.ReadLine();
            
        int result = 0;
        foreach (char ch in s) 
        {
            if (j.IndexOf(ch) >= 0) 
            {
                ++result;
            }
        }
            
        Console.WriteLine(result);

    }
}
*/

/*
//2-ое
using System;

using System.Collections.Generic; 

class HelloWorld
{
    static void Main()
    {
        List<int> candidates = new List<int>() 
        {2, 5, 2, 1, 2};
        List<int> sum = new List<int>();
        int target = 5;
        for (int i = 0; i < candidates.Count; i++)
        {
            int result = 0;
            sum.Clear();
            for (int j = 0; j < candidates.Count; j++)
            {
                if (i != j)
                {
                   result += candidates[j];
                    sum.Add(candidates[j]);
                }
                if (result > target)
                {
                    break;
                }
                else if (result == target)
                {
                    for (int n = 0; n < sum.Count; n++)
                    {
                        Console.Write($"{sum[n]}");
                        
                    }
                    Console.WriteLine();
                    
                }
            }
        }
    }
}
*/

/*
//3-ье
using System;

class HelloWorld
{
    static void Main() 
    {
        const int N = 4;
        int[] nums = new int[N] {1, 2, 3, 4};
        int count = 0;
        
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if ((i != j) && (nums[i] == nums[j]))
                {
                    count++;
                }
            }
        }
        if (count > 0)
        {
            Console.WriteLine($"True");
        }
        else
        {
            Console.WriteLine($"False");
        }
        
    }
}
*/