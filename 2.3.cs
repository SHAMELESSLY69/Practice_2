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
    public class Worker
    {
        string name;
        public string Name
        {
            get
            {
                return name;
            }
        }
        string surname;
        public string Surname
        {
            get
            {
                return surname;
            }
        }
        int rate;
        public int Rate
        {
            get
            {
                return rate;
            }
        }
        int days;
        public int Days
        {
            get
            {
                return days;
            }
        }

        public int Salary()
        {
            return rate * days;
        }

        public string Fullname()
        {
            return name + " " + surname;
        }

        public Worker(string name, string surname, int rate, int days)
        {
            this.name = name;
            this.surname = surname;
            this.rate = rate;
            this.days = days;
        }
    }

    static void Main()
    {
        Worker worker = new Worker("Яна", "Котова", 60, 800);
        Console.WriteLine($"Зарплата работника {worker.Fullname()}: {worker.Salary()}.");
    }
}
*/
/*
//2
using System;

public class HelloWorld
{
    public class Worker
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
        }
        private string surname;
        public string Surname
        {
            get
            {
                return surname;
            }
        }
        private int rate;
        public int Rate
        {
            get
            {
                return rate;
            }
        }
        private int days;
        public int Days
        {
            get
            {
                return days;
            }
        }

        public int Salary()
        {
            return rate * days;
        }

        public string Fullname()
        {
            return name + " " + surname;
        }

        public Worker(string name, string surname, int rate, int days)
        {
            this.name = name;
            this.surname = surname;
            this.rate = rate;
            this.days = days;
        }
    }

    static void Main()
    {
        Worker worker = new Worker("Яна", "Котова", 60, 800);
        Console.WriteLine($"Зарплата работника {worker.Fullname()}: {worker.Salary()}.");
    }
}
*/
//3
/*
using System;

using System.Collections.Generic;

public class HelloWorld
{
    public class Calculation
    {
        private string calculationLine;
        public void SetCalculationLine(string line)
        {
            calculationLine = line;
        }
        
        public string GetCalculationLine()
        {
            return calculationLine;
        }

        public void SetLastSymbolCalculationLine(char words)
        {
            calculationLine = calculationLine + words;
        }
        
        public char GetLastSymbol()
        {
            return calculationLine[calculationLine.Length - 1];
        }

        public void DeleteLastSymbol()
        {
            calculationLine = calculationLine.Remove(calculationLine.Length - 1);
        }
    }

    static void Main()
    {
        Calculation calculation = new Calculation();
        calculation.SetCalculationLine("Котова");
        calculation.SetLastSymbolCalculationLine('D');
        Console.WriteLine(calculation.GetCalculationLine());
        Console.WriteLine(calculation.GetLastSymbol());
        calculation.DeleteLastSymbol();
        Console.WriteLine(calculation.GetCalculationLine());
    }
}
*/