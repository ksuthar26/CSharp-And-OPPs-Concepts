using System;
using System.Collections.Generic;
using System.Text;

namespace Opps_Concepts.Basics
{
    public class BasicOperation
    {

        public const int c = 10;
        public readonly int number = 5;

        public int x; // Non statuc variable
        public static int y = 200; //Static Variable

        static BasicOperation()
        {
            Console.WriteLine("static constructor is called");
        }

        public BasicOperation(int x)
        {
            number = 10;
            this.x = x;
        }

        public BasicOperation()
        {
            // c = 5; -- throw error
            number = 12;
            Console.WriteLine("non-static constructor is called");
        }

        public static void BasicOperation1()
        {
            // c = 5; -- thorw error            

            Console.WriteLine("-------Integral Types-------");

            Console.WriteLine("Size of sbyte: {0} - Default Values Of sbyte: {1}", sizeof(sbyte), default(sbyte));

            Console.WriteLine("Size of byte: {0} - Default Values Of byte: {1}", sizeof(byte), default(byte));
            Console.WriteLine("Size of short: {0} - Default Values Of short: {1}", sizeof(short), default(short));
            Console.WriteLine("Size of ushort: {0} - Default Values Of ushort: {1}", sizeof(ushort), default(ushort));
            Console.WriteLine("Size of int: {0} - Default Values Of int: {1}", sizeof(int), default(int));
            Console.WriteLine("Size of uint: {0} - Default Values Of uint: {1}", sizeof(uint), default(uint));
            Console.WriteLine("Size of long: {0} - Default Values Of long: {1}", sizeof(long), default(long));
            Console.WriteLine("Size of ulong: {0} - Default Values Of ulong: {1}", sizeof(ulong), default(ulong));
            Console.WriteLine("Size of char: {0} - Default Values Of char: {1}", sizeof(char), default(char));

            Console.WriteLine("-------Floating  Types-------");


            Console.WriteLine("Size of float: {0} - Default Values Of float: {1}", sizeof(float), default(float));
            Console.WriteLine("Size of double: {0} - Default Values Of double: {1}", sizeof(double), default(double));

            Console.WriteLine("-------Boolean  Types-------");

            Console.WriteLine("Size of Boolean: {0} - Default Values Of bool: {1}", sizeof(bool), default(bool));

            Console.WriteLine("-------Decimal  Types-------");

            Console.WriteLine("Size of decimal: {0}- Default Values Of decimal: {1}", sizeof(decimal), default(decimal));

            // Console.WriteLine("-------String  Types-------");

            // Console.WriteLine("Size of string: {0}", sizeof(string)); - we can not predit size of referenc type

            Console.ReadKey();
        }

        public static void BasicOperation2()
        {
            // Displaying double quotes in c#
            string Name = "\"Dotnettutorials\"";
            Console.WriteLine(Name);

            // Displaying new line character in c#
            Name = "One\nTwo\nThree";
            Console.WriteLine(Name);

            //Name = "c:\Pranaya\Dotnettutorials\Csharp"; -- throw error
            //Console.WriteLine(Name);

            // C# verbatim literal
            Name = @"c:\Pranaya\Dotnettutorials\Csharp";
            Console.WriteLine(Name);
            Console.ReadKey();
        }

        public static void Add()
        {
            //This is a static block
            //we can access non static members X with the help of Example object
            //We can access the static member directly or through class name
            BasicOperation obj = new BasicOperation();

            //Console.WriteLine(obj.x + Example.y);
            Console.WriteLine("Sum of 100 and 200 is :" + (obj.x + y));
        }
        public void Mul()
        {
            //This is a non-static method
            //we can access static members directly or through class name
            //we can access the non-static members directly or through this keyword
            Console.WriteLine("Multiplication of 100 and 200 is :" + (this.x * BasicOperation.y));
            Console.WriteLine("Multiplication of 100 and 200 is :" + (x * y));
        }


    }

    public static class TemperatureConverter
    {
        public static double CelsiusToFahrenheit(string temperatureCelsius)
        {
            // Convert argument to double for calculations.
            double celsius = Double.Parse(temperatureCelsius);
            // Convert Celsius to Fahrenheit.
            double fahrenheit = (celsius * 9 / 5) + 32;
            return fahrenheit;
        }
        public static double FahrenheitToCelsius(string temperatureFahrenheit)
        {
            // Convert argument to double for calculations.
            double fahrenheit = Double.Parse(temperatureFahrenheit);
            // Convert Fahrenheit to Celsius.
            double celsius = (fahrenheit - 32) * 5 / 9;
            return celsius;
        }
    }

    class ReadOnlyConst
    {
        public int x; //Non-static variable
        public static int y = 200; //Static Variable
        public const float PI = 3.14f; //Const Variable
        public readonly bool flag; //Readonly Variable
        public ReadOnlyConst(int x, bool flag)
        {
            this.x = x;
            this.flag = flag;
        }
    }

    public class propertyClsBase
    {
        int _empId = 0;
        public int EmpId
        {
            get
            {
                return _empId;
            }
            set
            {
                _empId = value;
            }
        }

        int _id = 0;
        public int Id
        {
            get
            {
                return _id;
            }
            protected set
            {
                _id = value;
            }
        }

        int _id1 = 0;
        public int Id1
        {
            get
            {
                return _id1;
            }
            private set
            {
                _id1 = value;
            }
        }

        int _id2 = 0;
        public int Id2
        {
            private get
            {
                return _id2;
            }
            set
            {
                _id2 = value;
            }
        }

        int _id3 = 0;
        private int Id3
        {
            //protected get    // Throw Error
            //{
            //    return _id3;
            //}
            set
            {
                _id3 = value;
            }
        }

        int _id4 = 0;
        protected int Id4
        {
            get
            {
                return _id3;
            }
            set
            {
                _id4 = value;
            }
        }

        //int _id5 = 0;
        //protected int Id5 // Throw Error
        //{
        //    private get
        //    {
        //        return _id5;
        //    }
        //    //public set -- Throw Error
        //    //{
        //    //    _id5 = value;
        //    //}
        //}

        int _id6 = 0;
        protected int _Id6
        {
            private get
            {
                return _id6;
            }
            set
            {
                _id6 = value;
            }
        }


    }

    public class propertyClsDerived : propertyClsBase
    {
        int _empId = 0;
        public new int EmpId
        {
            get
            {
                return _empId;
            }
            private set
            {
                _empId = value;
            }
        }
        public void add()
        {
            int c = this.EmpId + this.Id + this.Id1 + this.Id4; // this.Id2 + this._id6;
        }
    }

    public class Student
    {
        private int _id;
        private string _name;
        private int _passMark = 35;
        //public void SetID(int ID)
        //{
        //    if (ID < 0)
        //    {
        //        throw new Exception("ID value should be greater than zero");
        //    }
        //    this._id = ID;
        //}
        //public int GetID()
        //{
        //    return this._id;
        //}
        //public void SetName(string Name)
        //{
        //    if (string.IsNullOrEmpty(Name))
        //    {
        //        throw new Exception("Name should not be empty");
        //    }
        //    this._name = Name;
        //}
        //public string GetName()
        //{
        //    if (string.IsNullOrEmpty(_name))
        //    {
        //        return "No Name";
        //    }
        //    return this._name;
        //}
        //public int GetPassMark()
        //{
        //    return this._passMark;
        //}

        public int ID
        {
            set
            {
                if (value < 0)
                {
                    throw new Exception("ID value should be greater than zero");
                }
                this._id = value;
            }
            get
            {
                return this._id;
            }
        }
        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name should not be empty");
                }
                this._name = value;
            }
            get
            {
                return string.IsNullOrEmpty(this._name) ? "No Name" : this._name;
            }
        }
        public int PassMark
        {
            get
            {
                return this._passMark;
            }
        }

        public override string ToString()
        {
            return "Kirtesh" + ", " + "Suthar";
        }
    }
}
