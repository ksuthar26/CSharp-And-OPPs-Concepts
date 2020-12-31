using AssemblyOne;
using Opps_Concepts.Basics;
using System;
using System.Collections.Generic;
using static Opps_Concepts.Delegates;
using static Opps_Concepts.GenericDelegates;

namespace Opps_Concepts
{
    class Program
    {
        static bool Promote(EmployeeDelegate employee)
        {
            if (employee.Salary > 10000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {

            #region Baisc c# Functaions            

            //Console.WriteLine("----------------Basic C# Operations-----------");


            //BasicOperation.BasicOperation1();

            //BasicOperation.BasicOperation2();


            //Console.WriteLine("----------------Basic C# Operations END-----------");

            //Console.WriteLine("----------------Static And Non-Static Operations-----------");


            ////Accessing the static variable using class name
            ////Before object creation
            //Console.WriteLine("Static Variable Y = " + BasicOperation.y);
            ////Creating object1
            //BasicOperation obj1 = new BasicOperation(50);
            ////Creating object2
            //BasicOperation obj2 = new BasicOperation(100);
            //Console.WriteLine($"object1 x = {obj1.x}  object2 x = {obj2.x}");
            //Console.WriteLine("Press any key to exit.");
            //Console.ReadLine();

            //// Main method is a static method
            //// ADD() method is a static method
            //// Statid to Static 
            //// we can call the add method directly or through class name
            //BasicOperation.Add();

            //// Mul() method is a non-static method
            //// we can call the non-static method using object only from a static method
            //// Static to non-static
            //BasicOperation obj = new BasicOperation();
            //obj.Mul();
            //Console.WriteLine("Press any key to exit.");
            //Console.ReadLine();

            //Console.WriteLine("Please select the convertor direction");
            //Console.WriteLine("1. From Celsius to Fahrenheit.");
            //Console.WriteLine("2. From Fahrenheit to Celsius.");
            //Console.Write(":");
            //string selection = Console.ReadLine();
            //double F, C = 0;
            //switch (selection)
            //{
            //    case "1":
            //        Console.Write("Please enter the Celsius temperature: ");
            //        F = TemperatureConverter.CelsiusToFahrenheit(Console.ReadLine());
            //        Console.WriteLine("Temperature in Fahrenheit: {0:F2}", F);
            //        break;
            //    case "2":
            //        Console.Write("Please enter the Fahrenheit temperature: ");
            //        C = TemperatureConverter.FahrenheitToCelsius(Console.ReadLine());
            //        Console.WriteLine("Temperature in Celsius: {0:F2}", C);
            //        break;
            //    default:
            //        Console.WriteLine("Please select a convertor.");
            //        break;
            //}
            //// Keep the console window open in debug mode.
            //Console.WriteLine("Press any key to exit.");
            //Console.ReadKey();


            //Console.WriteLine("----------------Static And Non-Static Operations END-----------");

            //Console.WriteLine("----------------Const And Read-Only Operations-----------");

            ////Const variables are static in nature
            ////so we can access them by using class name 
            //Console.WriteLine(BasicOperation.c);

            ////We can also declare constant variable within a function
            //const int no = 10;
            //Console.WriteLine(no);

            ////Once after declaration we cannot change the value 
            ////of a constant variable. so the below live gives error
            ////no = 20;
            //Console.WriteLine("Press any key to exist.");
            //Console.ReadLine();

            //BasicOperation readOnlyInstance = new BasicOperation();

            //// You cannot change the value of a readonly variable once it is initialized
            ////readOnlyInstance.number = 45; // Throw Error

            //Console.WriteLine(readOnlyInstance.number);
            //readOnlyInstance = new BasicOperation(13);
            //Console.WriteLine(readOnlyInstance.number);

            //Console.WriteLine("Press any key to exist.");
            //Console.ReadLine();

            //Console.WriteLine(ReadOnlyConst.y);
            //Console.WriteLine(ReadOnlyConst.PI);

            //ReadOnlyConst readOnlyConst1 = new ReadOnlyConst(50, true);
            //ReadOnlyConst readOnlyConst2 = new ReadOnlyConst(100, false);

            //Console.WriteLine(readOnlyConst1.x + " " + readOnlyConst1.x);
            //Console.WriteLine(readOnlyConst2.flag + " " + readOnlyConst2.flag);

            //Console.WriteLine("Press any key to exist.");
            //Console.ReadLine();


            //Console.WriteLine("----------------Const And Read-Only Operations END-----------");

            //Console.WriteLine("----------------Property Operations-----------");

            //propertyClsBase propertyClsBase = new propertyClsBase();

            ////int id = propertyClsBase.Id2; // throw Error

            //int ff = propertyClsBase.EmpId + propertyClsBase.Id + propertyClsBase.Id1; // propertyClsBase.Id3  + propertyClsBase.Id4;

            //propertyClsDerived propertyClsDerived = new propertyClsDerived();

            ////int id11 = propertyClsDerived.Id2; // throw Error

            //int ff11 = propertyClsDerived.EmpId + propertyClsDerived.Id + propertyClsBase.Id1; // propertyClsBase.Id3  + propertyClsBase.Id4;

            //Student S = new Student();
            //S.ID = 101;
            //S.Name = "Kirtesh";
            //Console.WriteLine("Student ID = {0}", S.ID);
            //Console.WriteLine("Student Name = {0}", S.Name);
            //Console.WriteLine(S.ToString());
            //Console.WriteLine("Studenr Pass Mark = {0}", S.PassMark);
            //Console.ReadKey();

            //Customer C1 = null;
            ////C1.ToString(); // Throw Error
            //Console.WriteLine(Convert.ToString(C1));
            //Console.ReadLine();

            //String Name = null;
            ////Name.ToString(); // thoow Error
            //Console.WriteLine(Convert.ToString(Name));
            //Console.ReadLine();


            //Console.WriteLine("----------------Property Operations END-----------");

            #endregion Baisc c# Functaions

            #region OOPS Concept

            // RetailSalesPerson retailSalesPerson = new RetailSalesPerson("Bruce", "Wayne");
            // retailSalesPerson.Sell();

            // Employee e1 = new Employee();
            //Employee e2 = new Employee();

            //Employee e1 = new Employee(101, 30, "Pranaya", "Mumbai");
            //Employee e2 = new Employee(101, 28, "Rout", "BBSR");

            //Employee e3 = new Employee(e1);

            //e1.Display();
            //e2.Display();
            //e3.Display();
            //Console.ReadKey();

            // Access Specofiers

            // Customer CustomerInstance = new Customer();

            //CustomerInstance.Id = 101; // You can not acess protercted meember through base class object

            //CustomerInstance.FirstName = "";

            // Compiler Error: 'Customer._id' is inaccessible due to its protection level
            // CustomerInstance._id = 101;

            //CorporateCustomer corporateCustomerInstance = new CorporateCustomer();

            // corporateCustomerInstance.Id // You can not acess protercted meember through derived class object

            //AssemblyOneClassI instance = new AssemblyOneClassI();

            //Console.WriteLine(instance.ID);

            //AssemblyTwoClassI assemblyTwoClassI = new AssemblyTwoClassI();

            // assemblyTwoClassI.Test();

            // Encapsulation...


            //Bank SBI = new Bank();
            //SBI.setBalance(500);
            //Console.WriteLine(SBI.getBalance());
            //Console.WriteLine("Press any key to exist.");
            //Console.ReadKey();

            //Bank1 SBI1 = new Bank1();
            //SBI1.Balance = 100;
            //Console.WriteLine(SBI1.Balance);
            //SBI1.Balance = -50;
            //Console.WriteLine(SBI1.Balance);
            //Console.WriteLine("Press any key to exist.");
            //Console.ReadKey();

            // Inheritance

            //  Branch branch = new Branch();

            //Branch branch = new Employee1();

            // branch.GetBranchData();

            //Employee1 employee1 = (Employee1)new Branch();

            //employee1.GetBranchData();
            //employee1.GetEmployeeData();
            //employee1.DisplayEmployeeData();

            //Employee1 obj1 = new Employee1();

            //obj1.GetBranchData();
            //obj1.GetEmployeeData();
            //obj1.DisplayEmployeeData();

            //Console.WriteLine("Press any key to exist.");
            //Console.ReadKey();


            // Interfaces

            //MyClass obj = new MyClass();

            //obj.method1();
            //obj.method2();
            //obj.method3();
            //Console.WriteLine("Press any key to exist.");
            //Console.ReadKey();

            //Area a = new Rectangle();
            //a.area(5, 6);
            //a = new Circle();
            //a.area(7, 0);
            //Console.WriteLine("Press any key to exist.");
            //Console.ReadKey();


            //ImplementInterafce obj = new ImplementInterafce();
            //obj.Test();
            //obj.Show();
            //Interface1 obj1 = new ImplementInterafce();
            //obj1.Test();
            //obj1.Show();
            //Interface2 obj2 = new ImplementInterafce();
            //obj2.Test();
            //obj2.Show();
            //Console.WriteLine("Press any key to exist.");
            //Console.ReadKey();


            //ImplementInterafce objo = new ImplementInterafce();
            //objo.Test();  //not possible
            //objo.Show();  //not possible
            //((Interface1)obj).Test();
            //((Interface1)obj).Show();
            //Interface1 obj11 = new ImplementInterafce();
            //obj11.Test();
            //obj11.Show();
            //Interface2 obj22 = new ImplementInterafce();
            //obj22.Test();
            //obj22.Show();
            //Console.WriteLine("Press any key to exist.");
            //Console.ReadKey();


            //Abstraction

            //Cannot create an instance of the abstract class or interface 'Example'

            //Example e = new Example();


            // Example111.m1();
            //CE: cannot be instantiated class Example
            // Example111 e = new Example111();
            //not possible
            //e.m2();

            //Plan p;
            //Console.WriteLine("COMMERCIAL CONNECTION");
            //p = new CommercialPlan();
            //p.getRate();
            //p.calculation(250);
            //Console.WriteLine("DOMESTIC CONNECTION");
            //p = new DomesticlPlan();
            //p.getRate();
            //p.calculation(150);
            //Console.ReadKey();

            //Poly obj = new Poly();
            //obj.add(10, 20);
            //obj.add(10.5f, 20.5f);
            //obj.add("pranaya", "kumar");

            //Console.WriteLine("Press any key to exist.");
            //Console.ReadKey();

            #endregion OOPS Concept

            #region Enums


            // This following line will not compile. 
            // Cannot implicitly convert type 'Season' to 'Gender'. 
            // An explicit conversion is required.
            // Gender gender = Season.Winter;
            // The following line comiples as we have an explicit cast

            // int i = Gender.Male; //throw error

            //Gender female =  2; //Throw Error

            Gender gender = (Gender)Season.Winter;

            Console.WriteLine(gender);

            int[] Values = (int[])Enum.GetValues(typeof(Gender));
            Console.WriteLine("Gender Enum Values");
            foreach (int value in Values)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine();

            string[] Names = Enum.GetNames(typeof(Gender));
            Console.WriteLine("Gender Enum Names");
            foreach (string Name in Names)
            {
                Console.WriteLine(Name);
            }
            Console.ReadKey();

            #endregion

            #region Exception Handling

            ExceptionHandling exceptionHandling = new ExceptionHandling(12, 12);
            // exceptionHandling.Add();
            //exceptionHandling.AddLogical();
            //exceptionHandling = new ExceptionHandling(12, 0);
            //exceptionHandling.Add();
            //exceptionHandling.AddLogical();
            //exceptionHandling.AddTryCatch();
            //exceptionHandling.AddCustomException();
            //exceptionHandling.CustomException();
            //exceptionHandling.AddInnerException();
            //exceptionHandling.ExceptionHandlinAbuse();
            //exceptionHandling.ExceptionHandlinAbuseImproveVersion();

            #endregion Exception Handling

            #region Delegates And Events

            //Delegates delegates = new Delegates();

            ////Instantiating delegate by passing the target function Name
            ////The Add method is non static so here we are calling method using object
            //AddDelegate ad = new AddDelegate(delegates.AddDelegates);

            ////Greetings method is static so here we are callling the method by using the class name
            //GreetingsDelegate gd = new GreetingsDelegate(Delegates.Greetings);

            ////Invoking The Delegates
            //ad(100, 50);
            //string GreetingsMessage = gd("Pranaya");

            ////We can also use Invoke method to execute delegates
            //ad.Invoke(100, 50);
            //GreetingsMessage = gd.Invoke("Pranaya");

            //Console.WriteLine(GreetingsMessage);
            //Console.ReadKey();

            //Delegates rect = new Delegates();

            //RectangleDelete rectDelegate = new RectangleDelete(rect.GetArea);

            ////RectangleDelete rectDelegate = rect.GetArea;
            ////binding a method with delegate object
            //// In this example rectDelegate is a multicast delegate. You use += operator 
            //// to chain delegates together and -= operator to remove.

            //rectDelegate += rect.GetPerimeter;
            //rectDelegate(23.45, 67.89);
            //Console.WriteLine();
            //rectDelegate.Invoke(13.45, 76.89);
            //Console.WriteLine();
            ////Removing a method from delegate object
            //rectDelegate -= rect.GetPerimeter;
            //rectDelegate.Invoke(13.45, 76.89);
            //Console.ReadKey();

            //Delegates del = new Delegates();

            //MathDelegate del1 = new MathDelegate(Delegates.Add);
            //MathDelegate del2 = new MathDelegate(Delegates.Sub);
            //MathDelegate del3 = del.Mul;
            //MathDelegate del4 = new MathDelegate(del.Div);

            ////In this example del5 is a multicast delegate. We can use +(plus) 
            //// operator to chain delegates together and -(minus) operator to remove.
            //MathDelegate del5 = del1 + del2 + del3 + del4;
            //del5.Invoke(20, 5);
            //Console.WriteLine();
            //del5 -= del2;
            //del5(22, 7);

            //Console.ReadKey();

            //SampleDelegate del11 = new SampleDelegate(Delegates.MethodOne);
            //del11 += Delegates.MethodTwo;

            //// The ValueReturnedByDelegate will be 2, returned by the MethodTwo(),
            //// as it is the last method in the invocation list.
            //int ValueReturnedByDelegate = del11();
            //Console.WriteLine("Returned Value = {0}", ValueReturnedByDelegate);
            //Console.ReadKey();

            //SampleDelegateWithOUt del22 = new SampleDelegateWithOUt(Delegates.MethodOne);
            //del22 += Delegates.MethodTwo;

            //// The ValueFromOutPutParameter will be 2, initialized by MethodTwo(),
            //// as it is the last method in the invocation list.
            //int ValueFromOutPutParameter = -1;
            //del22(ref ValueFromOutPutParameter);
            //Console.WriteLine("Returned Value = {0}", ValueFromOutPutParameter);
            //Console.ReadKey();

            //EmployeeDelegate emp1 = new EmployeeDelegate()
            //{
            //    ID = 101,
            //    Name = "Pranaya",
            //    Gender = "Male",
            //    Experience = 5,
            //    Salary = 10000
            //};
            //EmployeeDelegate emp2 = new EmployeeDelegate()
            //{
            //    ID = 102,
            //    Name = "Priyanka",
            //    Gender = "Female",
            //    Experience = 10,
            //    Salary = 20000
            //};
            //EmployeeDelegate emp3 = new EmployeeDelegate()
            //{
            //    ID = 103,
            //    Name = "Anurag",
            //    Experience = 15,
            //    Salary = 30000
            //};

            //List<EmployeeDelegate> lstEmployess = new List<EmployeeDelegate>();
            //lstEmployess.Add(emp1);
            //lstEmployess.Add(emp2);
            //lstEmployess.Add(emp3);
            //EligibleToPromotion eligibleTopromote = new EligibleToPromotion(Program.Promote);

            //EmployeeDelegate.PromoteEmployee(lstEmployess, eligibleTopromote);

            //EmployeeDelegate.PromoteEmployee(lstEmployess, x => x.Experience > 5);


            //string Message = "Welcome to Dotnet Tutorials";

            //GreetingsDelegate gd = delegate (string name)  // --------------  Anonymous Methods ----------------- //
            //{
            //    return "Hello @" + name + " " + Message; // Access Outer Variable
            //};

            //gd = (name) =>  // --------------  Lambda Expression ----------------- //
            //{
            //    return "Hello @" + name + " " + Message; // Access Outer Variable
            //};

            //string GreetingsMessage = gd.Invoke("Pranaya");
            //Console.WriteLine(GreetingsMessage);
            //Console.ReadKey();

            //EmployeeDelegate.PromoteEmployee(lstEmployess, delegate (EmployeeDelegate emp)
            //{
            //    return emp.Gender == "Female";
            //});

            //AddNumber1Delegate obj1 = new AddNumber1Delegate(AddNumber1);
            //double Result = obj1.Invoke(100, 125.45f, 456.789);
            //Console.WriteLine(Result);

            //AddNumber2Delegate obj2 = new AddNumber2Delegate(AddNumber2);
            //obj2.Invoke(50, 255.45f, 123.456);

            //CheckLengthDelegate obj3 = new CheckLengthDelegate(CheckLength);
            //bool Status = obj3.Invoke("Pranaya");

            //Console.WriteLine(Status);

            //Func<int, float, double, double> obj11 = new Func<int, float, double, double>(AddNumber1);
            //double Result1 = obj11.Invoke(100, 125.45f, 456.789);
            //Console.WriteLine(Result1);

            //Action<int, float, double> obj22 = new Action<int, float, double>(AddNumber2);
            //obj22.Invoke(50, 255.45f, 123.456);

            //Predicate<string> obj32 = new Predicate<string>(CheckLength);
            //bool Status1 = obj32.Invoke("Pranaya");
            //Console.WriteLine(Status1);

            //Console.ReadKey();

            // ---------------  END ------------------------------- //

            #endregion

            #region Indexers

            //Indexers company = new Indexers();
            //Console.WriteLine("Name of Employee with Id = 101: " + company[101]);
            //Console.WriteLine();
            //Console.WriteLine("Name of Employee with Id = 105: " + company[105]);
            //Console.WriteLine();
            //Console.WriteLine("Name of Employee with Id = 107: " + company[107]);
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("Changing the names of employees with Id = 101,105,107");
            //Console.WriteLine();
            //company[101] = "Employee 101 Name Changed";
            //company[105] = "Employee 105 Name Changed";
            //company[107] = "Employee 107 Name Changed";
            //Console.WriteLine("Name of Employee with Id = 101: " + company[101]);
            //Console.WriteLine();
            //Console.WriteLine("Name of Employee with Id = 105: " + company[105]);
            //Console.WriteLine();
            //Console.WriteLine("Name of Employee with Id = 107: " + company[107]);

            //Console.WriteLine("Before changing the Gender of all the male employees to Female");
            //Console.WriteLine();

            //// Get accessor of string indexer is invoked to return the total count of male employees
            //Console.WriteLine("Total Number Employees with Gender = Male:" + company["Male"]);
            //Console.WriteLine();
            //Console.WriteLine("Total Number Employees with Gender = Female:" + company["Female"]);
            //Console.WriteLine();

            //// Set accessor of string indexer is invoked to change the gender all "Male" employees to "Female"
            //company["Male"] = "Female";
            //Console.WriteLine("After changing the Gender of all male employees to Female");
            //Console.WriteLine();
            //Console.WriteLine("Total Employees with Gender = Male:" + company["Male"]);
            //Console.WriteLine();
            //Console.WriteLine("Total Employees with Gender = Female:" + company["Female"]);

            //Console.ReadLine();

            #endregion

            #region Collections



            #endregion
        }

        // Class , Object and Constructores..
        class Employee
        {
            int eid, eage;
            string eaddress, ename;

            static int Cno;

            static Employee()
            {
                Cno = 201;
            }

            public Employee()
            {
                this.eid = 100;
                eage = 30;
                this.ename = "Pranaya";
                eaddress = "MUMBAI";
            }

            public Employee(int id, int age, string name, string address)
            {
                this.eid = id;
                this.eage = age;
                this.ename = name;
                this.eaddress = address;
            }

            public Employee(Employee tempobj)
            {
                this.eid = tempobj.eid;
                this.eage = tempobj.eage;
                this.ename = tempobj.ename;
                this.eaddress = tempobj.eaddress;
            }

            public void Display()
            {
                Console.WriteLine("employee id is:  " + eid);
                Console.WriteLine("employee name is:  " + this.ename);
                Console.WriteLine("employee age is:  " + this.eage);
                Console.WriteLine("employee address is:  " + eaddress);

                Console.WriteLine("value of Cno : " + Cno);
                Cno++;
            }
        }


        // Access Specofiers
        public class Customer
        {
            #region Private Fields
            private int _id;
            private string _firstName;
            private string _lastName;
            #endregion

            #region Properties
            protected int Id
            {
                get { return _id; }
                set { _id = value; }
            }
            public string FirstName
            {
                get { return _firstName; }
                set { _firstName = value; }
            }
            public string LastName
            {
                get { return _lastName; }
                set { _lastName = value; }
            }
            #endregion

            #region Methods
            public string GetFullName()
            {
                return this._firstName + " " + this._lastName + " " + this.Id;
            }
            #endregion
        }
        public class CorporateCustomer : Customer
        {
            public void PrintCustomerID()
            {
                CorporateCustomer corporateCustomerInstance = new CorporateCustomer();
                // Can access the base class protected instance member using the derived class object
                Console.WriteLine(corporateCustomerInstance.Id);
                // Can access the base class protected instance member using this or base keyword
                Console.WriteLine(this.Id);
                Console.WriteLine(base.Id);
            }
        }
        public class RetailCustomer
        {
            public void PrintCustomerID()
            {
                RetailCustomer retailCustomerInstance = new RetailCustomer();
                //RetailCustomer class is not deriving from Customer class, hence it is an error
                //to access Customer class protected ID member, using the retailCustomerInstance
                //Console.WriteLine(retailCustomerInstance.ID); //Error
                //Both these below lines also produce the same Error
                //Console.WriteLine(this.ID); // Error
                //Console.WriteLine(base.ID); // Error
            }
        }

        public class AssemblyTwoClassI : AssemblyOneClassI
        {
            public void Test()
            {
                AssemblyOneClassI instance = new AssemblyOneClassI();
                // Access the base class member using the base keyword            
                Console.WriteLine(base.ID1);
            }
        }
        private class MainClass
        {
            public static void sample()
            {
                Console.WriteLine("This code will not compile");
            }
        }

        // Encapsulation...

        public class Bank
        {
            //hiding class data by declaring the variable as private
            private double balance;
            //creating public setter and getter methods
            public double getBalance()
            {
                //add validation logic if needed
                return balance;
            }
            public void setBalance(double balance)
            {
                // add validation logic to check whether data is correct or not
                this.balance = balance;
            }
        }

        // Implementing Encapsulation in C# using Properties:

        public class Bank1
        {
            private double balance;
            public double Balance
            {
                get
                {
                    return balance;
                }
                set
                {
                    // validate the value
                    if (value < 0)
                    {
                        Console.WriteLine("value cannot be negative");
                    }
                    balance = value;
                }
            }
        }

        // Inheritance

        class Branch
        {
            int BranchCode;
            string BranchName, BranchAddress;

            public Branch()
            {
                Console.WriteLine("Parent Class Constructor");
            }

            public void GetBranchData()
            {
                Console.WriteLine("Parent Class Public Method");
            }
            protected void DisplayBranchData()
            {
                Console.WriteLine("Parent Class Public Method");
            }

        }

        class Employee1 : Branch
        {
            int EmployeeId, EmployeeAge;
            string EmployeeName, EmployeeAddress;

            public Employee1()
            {
                Console.WriteLine("Child Class Constructor");
            }
            public void GetEmployeeData()
            {
                Console.WriteLine("Child Class Public Method");
            }
            public void DisplayEmployeeData()
            {
                base.DisplayBranchData();
                Console.WriteLine("Parent Class Public Method");
            }


        }

        // InterFace

        public interface A
        {
            void method1();
            void method2();
        }

        interface B : A
        {
            void method3();
            //void method4();
        }

        class MyClass : B
        {
            public void method1()
            {

                Console.WriteLine("implement method1");
            }
            public void method2()
            {
                Console.WriteLine("implement method2");
            }
            public void method3()
            {
                Console.WriteLine("implement method3");
            }
        }

        public interface Area
        {
            void area(double a, double b);
        }
        class Rectangle : Area
        {
            public void area(double a, double b)
            {
                double areaRectangle;
                areaRectangle = a * b;
                Console.WriteLine("the area of rectangle is :" + areaRectangle);
            }
        }
        class Circle : Area
        {
            static double PI = 3.14;
            public void area(double a, double b)
            {
                double areaCircle;
                areaCircle = PI * a * a;
                Console.WriteLine("the area of Circle is :" + areaCircle);
            }
        }

        public interface Interface1
        {
            void Test();
            void Show();
        }
        public interface Interface2
        {
            void Test();
            void Show();
        }
        class ImplementInterafce : Interface1, Interface2
        {
            public void Test()
            {
                Console.WriteLine("Test method is implemented");
            }
            public void Show()
            {
                Console.WriteLine("Show mwthod is implemented");
            }

            //public modifier is not allowed
            void Interface1.Test()
            {
                Console.WriteLine("Test mthod of interafce1 is implemented");
            }
            void Interface1.Show()
            {
                Console.WriteLine("Show mwthod of interafce1 is implemented");
            }
            void Interface2.Test()
            {
                Console.WriteLine("Test mthod of interface2 is implemented");
            }
            void Interface2.Show()
            {
                Console.WriteLine("Show mwthod of interafce2 is implemented");
            }
        }

        // Abstraction

        public abstract class Example
        {
            static int a = 1;

            public static int MyProperty { get; set; }

            public Example()
            {

            }
            public Example(int w)
            {

            }

            public static void mmm()
            {
                Console.WriteLine("Static Method frm abstartc class");
            }

            //A static member 'Example.m1()' cannot be marked as override, virtual, or abstract
            //public static abstract void m11();


            // public sealed abstract void m1();
            public abstract void m1();
            public abstract void m2();
        }
        //'Sample' does not implement inherited abstract member 'Example.m2()'
        public class Sample : Example
        {
            public override void m1()
            {
                Console.WriteLine("m1 method");
            }

            public override void m2()
            {
                Console.WriteLine("m2 method");
            }
        }

        public abstract class Sample1 : Example
        {
            public override sealed void m1()
            {
                Console.WriteLine("m1 method");
            }
        }

        public abstract class Example111
        {
            public static void m1()
            {
                Console.WriteLine("Example m1 method");
            }
            public void m2()
            {
                Console.WriteLine("Example m2 method");
            }
        }

        public abstract class Plan
        {
            protected double rate;
            public abstract void getRate();
            public void calculation(int units)
            {
                Console.Write("BILL AMOUNT FOR " + units + " UNITS is: Rs.");
                Console.WriteLine(rate * units);
            }
        }
        class CommercialPlan : Plan
        {
            public override void getRate()
            {
                rate = 5.00;
            }
        }
        class DomesticlPlan : Plan
        {
            public override void getRate()
            {
                rate = 2.50;
            }
        }

        // Polymorphism

        public class Poly
        {
            public void add(int a, int b)
            {
                Console.WriteLine(a + b);
            }

            public void add(int a, in int b)
            {
                Console.WriteLine(a + b);
            }

            public void add(string a, in int b)
            {
                Console.WriteLine(a + b);
            }

            public void add(int a, string b)
            {
                Console.WriteLine(a + b);
            }

            public void add(float x, float y)
            {
                Console.WriteLine(x + y);
            }
            public void add(string s1, string s2)
            {
                Console.WriteLine(s1 + s2);
            }
        }

        public class PolyDerived : Poly
        {
            public new void add(int a, int b)
            {
                Console.WriteLine(a + b);
            }

            public new void add(int a, in int b)
            {
                Console.WriteLine(a + b);
            }

            public new void add(string s1, string s2)
            {
                Console.WriteLine(s1 + s2);
            }
        }

        class ADD1
        {
            public void add(int a, int b)
            {
                Console.WriteLine(a + b);
            }
            public void add(float x, float y)
            {
                Console.WriteLine(x + y);
            }
        }
        class ADD2 : ADD1
        {
            public void add(string s1, string s2)
            {
                Console.WriteLine(s1 + s2);
            }
        }

        class Class1
        {
            public virtual void show()
            {
                Console.WriteLine("Super class show method");
            }

            public virtual void show1()
            {
                Console.WriteLine("Super class show method");
            }

            public virtual void show2()
            {
                Console.WriteLine("Super class show method");
            }

            public virtual void show3()
            {
                Console.WriteLine("Super class show method");
            }

            public virtual void show4()
            {
                Console.WriteLine("Super class show method");
            }
        }
        class Class2 : Class1
        {
            public override void show()
            {
                base.show();
                Console.WriteLine("Sub class override show method");
            }

            public sealed override void show4()
            {
                Console.WriteLine("Super class show method");
            }

            public new void show1()
            {
                Console.WriteLine("Super class show method");
            }

            public new virtual void show2()
            {
                base.show();
                Console.WriteLine("Super class show method");
            }

            public override void show3()
            {
                Console.WriteLine("Super class show method");
            }
        }

        sealed class Class3 : Class2
        {
            //public override void show4()
            //{
            //    Console.WriteLine("Super class show method");
            //}

            public override void show2()
            {
                base.show();
                Console.WriteLine("Super class show method");
            }
        }

        //class Class4:Class3
        //{

        //}
    }
}
