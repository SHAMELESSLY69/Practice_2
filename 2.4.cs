/******************************************************************************

                              Online C++ Compiler.
               Code, Compile, Run and Debug C++ program online.
Write your code in this editor and press "Run" button to compile and execute it.

*******************************************************************************/
/*
//1
using System;

public class HelloWorld
{
    static void Main()
    {
        String numStringVersion = "MCXLIX";
        char[] numCharVersion = numStringVersion.ToCharArray();
        int count = 0;
        
        for (int i = 0; i < numCharVersion.Length; i++)
        {
            if (numCharVersion[i] == 'I') 
            {
                if ((i < numCharVersion.Length - 1) && 
                    (numCharVersion[i + 1] == 'V'))
                {
                    count += 4;
                    i++;
                }
                else if ((i < numCharVersion.Length - 1) &&
                         (numCharVersion[i + 1] == 'X'))
                {
                    count += 9;
                    i++;
                }
                else
                {
                    count += 1;
                }
            }
            else if (numCharVersion[i] == 'V') 
            {
                count += 5;
            }
            else if (numCharVersion[i] == 'X') 
            {
                if ((i < numCharVersion.Length - 1) && 
                    (numCharVersion[i + 1] == 'L'))
                {
                    count += 40;
                    i++;
                }
                else if ((i < numCharVersion.Length - 1) && 
                         (numCharVersion[i + 1] == 'C'))
                {
                    count += 90;
                    i++;
                }
                else
                {
                    count += 10;
                }
            }
            else if (numCharVersion[i] == 'L') 
            {
                count += 50;
            }
            else if (numCharVersion[i] == 'C') 
            {
                if ((i < numCharVersion.Length - 1) && 
                    (numCharVersion[i + 1] == 'D'))
                {
                    count += 400;
                    i++;
                }
                else if ((i < numCharVersion.Length) && 
                         (numCharVersion[i + 1] == 'M'))
                {
                    count += 900;
                    i++;
                }
                else
                {
                    count += 100;
                }
            }
            else if (numCharVersion[i] == 'D') 
            {
                count += 500;
            }
            else if (numCharVersion[i] == 'M') 
            {
                count += 1000;
            }
        }
        Console.Write(count);
    }
}
*/

