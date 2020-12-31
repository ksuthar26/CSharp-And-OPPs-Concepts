using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace Opps_Concepts
{

    //Creating our own Exception Class by inheriting Exception class
    public class OddNumberException : Exception
    {
        //Overriding the Message property
        public override string Message
        {
            get
            {
                return "divisor cannot be odd number";
            }
        }
    }

    [Serializable]
    public class UserAlreadyLoggedInException : Exception
    {
        public UserAlreadyLoggedInException(string message)
            : base(message)
        {
        }
        public UserAlreadyLoggedInException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
        public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
    public class ExceptionHandling
    {
        int a = 20;
        int b = 0;
        int c;

        public ExceptionHandling(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public void Add()
        {
            Console.WriteLine("A VALUE = " + a);
            Console.WriteLine("B VALUE = " + b);
            c = a / b;
            Console.WriteLine("C VALUE = " + c);
            Console.ReadKey();
        }

        //There are three methods to handle the exception in .NET


        // 1.Logical implementation - the first and foremost importance always given to logical implementation only. 
        // If it is not possible to handle an exception using logical implementation then we use try-catch implementation.
        public void AddLogical()
        {
            Console.WriteLine("A VALUE = " + a);
            Console.WriteLine("B VALUE = " + b);
            if (b == 0)
            {
                Console.WriteLine("second number should not be zero");
            }
            else
            {
                c = a / b;
                Console.WriteLine("C VALUE = " + c);
            }
            Console.ReadKey();
        }


        //2.Try-Catch
        public void AddTryCatch()
        {
            Console.WriteLine("A VALUE = " + a);
            Console.WriteLine("B VALUE = " + b);
            //try
            //{
            //    a = int.Parse(Console.ReadLine());
            //    b = int.Parse(Console.ReadLine());
            //    int c = a / b;
            //    Console.WriteLine("C VALUE = " + c);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine(ex.Source);
            //    Console.WriteLine(ex.HelpLink);
            //}

            //try
            //{
            //    a = int.Parse(Console.ReadLine());
            //    b = int.Parse(Console.ReadLine());
            //    int c = a / b;
            //    Console.WriteLine("C VALUE = " + c);
            //}
            //catch 
            //{
            //    Console.WriteLine("error occured....");
            //}

            try
            {
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                c = a / b;
                Console.WriteLine("C VALUE = " + c);
            }
            //catch (Exception ex)                  -- Stetment Throw Errors
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine(ex.Source);
            //    Console.WriteLine(ex.HelpLink);
            //}
            catch (DivideByZeroException dbze)
            {
                Console.WriteLine("second number should not be zero");
            }
            catch (FormatException fe)
            {
                Console.WriteLine("enter only integer numbers");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Source);
                Console.WriteLine(ex.HelpLink);
            }
            finally //definitely executes statements placed in it irrespective of whether the exception has occurred or not, irrespective of whether the exception is handled or not in the catch block
            {
                Console.WriteLine("hello this is finally block");
            }

            try
            {
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                c = a / b;
                Console.WriteLine("C VALUE = " + c);
            }
            finally //definitely executes statements placed in it irrespective of whether the exception has occurred or not, irrespective of whether the exception is handled or not in the catch block
            {
                Console.WriteLine("hello this is finally block");
            }

            Console.ReadKey();
        }
        public void AddCustomException()
        {
            Console.WriteLine("A VALUE = " + a);
            Console.WriteLine("B VALUE = " + b);


            try
            {
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                if (a % 2 > 0)
                {
                    OddNumberException ONE = new OddNumberException();
                    throw ONE;
                    //throw new OddNumberException();
                }
                if (b == 0)
                {
                    throw new DivideByZeroException("Not Allowed ZERo");
                }
                c = a / b;
                Console.WriteLine("C VALUE = " + c);
            }
            catch (OddNumberException one)  // Custom Exception
            {
                Console.WriteLine(one.Message);
            }
            catch (DivideByZeroException dbze)
            {
                Console.WriteLine("second number should not be zero");
            }
            catch (FormatException fe)
            {
                Console.WriteLine("enter only integer numbers");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Source);
                Console.WriteLine(ex.HelpLink);
            }
            finally //definitely executes statements placed in it irrespective of whether the exception has occurred or not, irrespective of whether the exception is handled or not in the catch block
            {
                Console.WriteLine("hello this is finally block");
            }


            Console.ReadKey();
        }
        public void CustomException()
        {
            try
            {
                throw new UserAlreadyLoggedInException("User Already logged in");
            }
            catch (UserAlreadyLoggedInException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("End of the program");
            Console.ReadKey();
        }

        public void AddInnerException()
        {
            Console.WriteLine("A VALUE = " + a);
            Console.WriteLine("B VALUE = " + b);

            try
            {
                try
                {
                    a = int.Parse(Console.ReadLine());
                    b = int.Parse(Console.ReadLine());
                    c = a / b;
                    Console.WriteLine("C VALUE = " + c);
                }
                catch (Exception ex)
                {
                    //make sure this path does not exist
                    string filePath = @"C:\LogFile\Log.txt";

                    if (File.Exists(filePath))
                    {
                        StreamWriter sw = new StreamWriter(filePath);
                        sw.Write(ex.GetType().Name + ex.Message + ex.StackTrace);
                        sw.Close();
                        Console.WriteLine("There is a problem! Plese try later");
                    }
                    else
                    {
                        //To retain the original exception pass it as a parameter
                        //to the constructor, of the current exception
                        throw new FileNotFoundException(filePath + " Does not Exist", ex);

                        /*
                         * we can say "throw" maintains the full hierarchy in the stack trace and gives complete information about the exception occurred in the code.
                         * Whereas "throw ex" pretends that exceptions occurred on the line 
                         * where "throw ex" was written and removes all the hierarchy above the method containing the "throw ex" expression.
                         */

                        //throw ex; //resets the stack trace (so your errors would appear to originate from HandleException)
                        // throw; //doesn't - the original offender would be preserved.
                    }
                }
            }
            catch (Exception e)
            {
                //e.Message will give the current exception message
                Console.WriteLine("Current or Outer Exception = " + e.Message);
                //Check if inner exception is not null before accessing Message property
                //else, you may get Null Reference Excception
                if (e.InnerException != null)
                {
                    Console.Write("Inner Exception : ");
                    Console.WriteLine(String.Concat(e.InnerException.StackTrace, e.InnerException.Message));
                }
            }

            Console.ReadKey();
        }

        public void ExceptionHandlinAbuse()
        {
            try
            {
                //Convert.ToInt32() can throw FormatException, if the entered value
                //cannot be converted to integer. So use int.TryParse() instead
                Console.WriteLine("Please enter First Number");
                int FNO = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter Second Number");
                int SNO = Convert.ToInt32(Console.ReadLine());
                int Result = FNO / SNO;
                Console.WriteLine("Result = {0}", Result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Only numbers are allowed!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Only numbers between {0} & {1} are allowed",
                Int32.MinValue, Int32.MaxValue);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Secoond Number cannot be zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void ExceptionHandlinAbuseImproveVersion()
        {
            try
            {
                Console.WriteLine("Please enter First Number");
                int FNO;
                //int.TryParse() will not throw an exception, instead returns false
                //if the entered value cannot be converted to integer
                bool isValidFNO = int.TryParse(Console.ReadLine(), out FNO);
                if (isValidFNO)
                {
                    Console.WriteLine("Please enter Second Number");
                    int SNO;
                    bool isValidSNO = int.TryParse(Console.ReadLine(), out SNO);

                    if (isValidSNO && SNO != 0)
                    {
                        int Result = FNO / SNO;
                        Console.WriteLine("Result = {0}", Result);
                    }
                    else
                    {
                        //Check if the second number is zero and print a friendly error
                        //message instead of allowing DivideByZeroException exception 
                        //to be thrown and then printing error message to the user.
                        if (isValidSNO && SNO == 0)
                        {
                            Console.WriteLine("Second Number cannot be zero");
                        }
                        else
                        {
                            Console.WriteLine("Only numbers between {0} && {1} are allowed",
                                Int32.MinValue, Int32.MaxValue);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Only numbers between {0} && {1} are allowed",
                          Int32.MinValue, Int32.MaxValue);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
