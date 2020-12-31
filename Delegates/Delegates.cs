using System;
using System.Collections.Generic;
using System.Text;

namespace Opps_Concepts
{
    //Defining Delegates
    //Note: The access specifeis, return type and the number, order and type of parameters of delegate
    //should be same as the function it refers to.
    delegate void AddDelegate(int a, int b);
    public delegate string GreetingsDelegate(string name);
    // Deletegate's return type is int
    public delegate int SampleDelegate();
    // Deletegate has an int output parameter
    public delegate void SampleDelegateWithOUt(ref int Integer);

    public class Delegates
    {
        //Defining Delegates
        //Note: The access specifeis, return type and the number, order and type of parameters of delegate
        //should be same as the function it refers to.

        //delegate void AddDelegate(int a, int b);
        //public delegate string GreetingsDelegate(string name);

        public delegate void RectangleDelete(double Width, double Height);
        public delegate void MathDelegate(int No1, int No2);

        //Defining Methods
        //NonStatic method
        public void AddDelegates(int x, int y)
        {
            Console.WriteLine(@"The Sum of {0} and {1}, is {2} ", x, y, (x + y));
        }
        //Static Method
        public static string Greetings(string name)
        {
            return "Hello @" + name;
        }

        public void GetArea(double Width, double Height)
        {
            Console.WriteLine(@"Area is {0}", (Width * Height));
        }
        public void GetPerimeter(double Width, double Height)
        {
            Console.WriteLine(@"Perimeter is {0}", (2 * (Width + Height)));
        }

        public static void Add(int x, int y)
        {
            Console.WriteLine("THE SUM IS : " + (x + y));
        }
        public static void Sub(int x, int y)
        {
            Console.WriteLine("THE SUB IS : " + (x - y));
        }
        public void Mul(int x, int y)
        {
            Console.WriteLine("THE MUL IS : " + (x * y));
        }
        public void Div(int x, int y)
        {
            Console.WriteLine("THE DIV IS : " + (x / y));
        }

        // This method returns one
        public static int MethodOne()
        {
            return 1;
        }
        // This method returns two
        public static int MethodTwo()
        {
            return 2;
        }

        // This method sets ouput parameter Number to 1
        public static void MethodOne(ref int Number)
        {
            Number = 1;
        }
        // This method sets ouput parameter Number to 2
        public static void MethodTwo(ref int Number)
        {
            Number = 2;
        }

    }


    /*
     * Real Example Of Delegate
     */
    public delegate bool EligibleToPromotion(EmployeeDelegate EmployeeToPromotion);
    public class EmployeeDelegate
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Experience { get; set; }
        public int Salary { get; set; }
        public static void PromoteEmployee(List<EmployeeDelegate> lstEmployees, EligibleToPromotion IsEmployeeEligible)
        {
            foreach (EmployeeDelegate employee in lstEmployees)
            {
                if (IsEmployeeEligible(employee))
                {
                    Console.WriteLine("Employee {0} Promoted", employee.Name);
                }
            }
        }
    }

    public class GenericDelegates
    {
        public delegate double AddNumber1Delegate(int no1, float no2, double no3);
        public delegate void AddNumber2Delegate(int no1, float no2, double no3);
        public delegate bool CheckLengthDelegate(string name);
        public static double AddNumber1(int no1, float no2, double no3)
        {
            return no1 + no2 + no3;
        }
        public static void AddNumber2(int no1, float no2, double no3)
        {
            Console.WriteLine(no1 + no2 + no3);
        }
        public static bool CheckLength(string name)
        {
            if (name.Length > 5)
                return true;
            return false;
        }
    }
}


