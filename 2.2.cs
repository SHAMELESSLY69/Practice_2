/******************************************************************************

                              Online C++ Compiler.
               Code, Compile, Run and Debug C++ program online.
Write your code in this editor and press "Run" button to compile and execute it.

*******************************************************************************/
/*
//1
using System;

using System.Collections.Generic;

public class Program
{
    public class Student
    {
        private string secondName;
        private DateTime dateOfBirth;
        private int group;
        private List<int> marks = new List<int>();


        public void PrintInfo()
        {
            Console.Write($"Фамилия: {secondName} \nГруппа: {group} \nДата рождения: {dateOfBirth} \nОценки: ");
            foreach (int a in marks)
            {
                System.Console.Write($"{a} ");
            }
        }
        
        public void Changeinfo(string secondName)
        {
            this.secondName = secondName;
        }
        public void Changeinfo(string secondName, DateTime dateOfBirth)
        {
            this.secondName = secondName;
            this.dateOfBirth = dateOfBirth;
        }
        public void Changeinfo(string secondName, DateTime dateOfBirth, int group)
        {
            this.secondName = secondName;
            this.dateOfBirth = dateOfBirth;
            this.group = group;
        }

        public Student(string secondName, DateTime dateOfBirth, int group, List<int> marks)
        {
            this.secondName = secondName;
            this.dateOfBirth = dateOfBirth;
            this.group = group;
            this.marks = marks;
        }
    }

    static void Main()
    {
        Student yana = new Student("Baranova", new DateTime(2006, 11, 12), 721, new List<int> {4, 3, 4, 5, 3});
        yana.Changeinfo(secondName: "Kotova", dateOfBirth: new DateTime(2004,06,27), group: 621);
        yana.PrintInfo();
    }
}
*/
/*
//2
using System;

using System.Collections.Generic;

public class Task2
{
    public class Train
    {
        private string stantion;
        public int num
	{
	    get;
	    private set;
        }
        private DateTime depatureTime;
        public void PrintInfo()
        {
            Console.WriteLine($"Станция: {this.stantion} \n№ поезда: {this.num} \nВремя отправления: {this.depatureTime}");
        }
        public Train(string stantion, int num, DateTime depatureTime)
        {
            this.stantion = stantion;
            this.num = num;
            this.depatureTime = depatureTime;
        }
    }

    static void Main()
    {
        List<Train> trains = new List<Train>()
        {
            new Train("Москва", 11, new DateTime(year : 2023, month : 03, day : 08, hour: 11, minute : 00, second : 00)),
            new Train("Казань", 9, new DateTime(year : 2023, month : 04, day : 13, hour: 14, minute : 30, second : 00)),
            new Train("Томск", 3, new DateTime(year : 2023, month : 05, day : 17, hour: 10, minute : 45, second : 00))
        };
        Console.Write($"Введите номер поезда: ");
        int itemNum = int.Parse(Console.ReadLine());
        foreach(Train train in trains)
        {
            if (train.num == itemNum)
                train.PrintInfo();
        }
    }
}
*/
/*
//3
using System;

public class Task2_3
{
    public class WorkWithNums
    {
        private int num1;
        private int num2;

        public void Print()
        {
            Console.WriteLine($"Первое число - {num1} второе число - {num2}");
        }

        public void Change(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public int Sum()
        {
            return num1 + num2;
        }

        public int FindMore()
        {
            if (num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }
        
        public WorkWithNums(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
    }

    static void Main()
    {
        WorkWithNums nums = new WorkWithNums(1000, 144);
        Console.Write($"Нужно ли вывести текущие числа? (Y/N): ");
        string questInput = Console.ReadLine();
        while ((questInput != "Y") || (questInput != "N"))
        {
            if (questInput == "Y")
            {
                nums.Print();
                break;
            }
        }
        Console.Write($"Нужно ли изменить эти числа? (Y/N): ");
        string questInput2 = Console.ReadLine();
        while ((questInput != "Y") || (questInput != "N"))
        {
            if (questInput2 == "Y")
            {
                Console.Write($"\nВведите значение для первого числа: ");
                int changeNum1 = int.Parse(Console.ReadLine());
                Console.Write($"\nВведите значение для второго числа: ");
                int changeNum2 = int.Parse(Console.ReadLine());
                nums.Change(changeNum1, changeNum2);
                break;
            }
        }

        Console.WriteLine($"Сумма чисел равна: {nums.Sum()}");
        Console.WriteLine($"Большее из двух чисел является число: {nums.FindMore()}");
        nums.Print();
    }
}
*/
/*
//5
using System;

public class Program
{
    public class Test
    {
        private int a;
        private string name;
        private bool isLearn;

        public Test()
        {
            a = 621;
            name = "Yana";
            isLearn = true;
        }
        public Test(int a, string name, bool isLearn)
        {
            this.a = a;
            this.name = name;
            this.isLearn = isLearn;
        }
        
        ~Test()
        {
            Console.WriteLine("Обьект удален");
        }
    }

    static void Main()
    {
        Test test1 = new Test();
        Test test2 = new Test(621, "jen9", isLearn:false);
    }
}
*/
/*
//4
using System;

public class Program
{
    public class meter
    {
        private int calculator;

        public void Show()
        {
            Console.WriteLine(calculator);
        }
        
        public void Increment()
        {
            calculator++;
        }
        public void Decrement()
        {
            calculator--;
        }

        public meter()
        {
            calculator = 12;
        }

        public meter(int num)
        {
            calculator = num;
        }
    }

    static void Main()
    {
        meter c1 = new meter();
        c1.Show();
        c1.Increment();
        c1.Show();

        meter c2 = new meter(188);
        c2.Show();
        for (int i = 0; i < 1; i++)
        {
            c2.Decrement();
        }
        c2.Show();
    }
}
*/
