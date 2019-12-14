using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToDelegates
{
    class Program
    {
        /*
         a delegate is a reference to a method 
         to use delegates, you must:
         1 define a delegate type(similar to defining a class)
         2 create a delegate obj. this is when you select the delegate object to
         reference a method
         3 use the delegate object by either invoking it directly or eusing it as
         a parameter of some other method

            where do we define a delegate type
            +++++++++++++++++++++++++++++++++++++
            2 optiond 
            Within the class
            or within the name space (outside of all the classes).. Most common

            syntax:
            public delegate returnType DelegateTypeName(parameter list)

            example
         * */
        public delegate long LongTypeDelegate(int x, int y);

        //define a delegate type for methods that take 3 ints and return a  double
        public delegate double DoubleTypeDelegate(int a, int b, int c);
        
        // signature: return a lon and takes two parametes of type int
        // this delegate can reference any method with the given signature

        static void Main(string[] args)
        {
            Random rand = new Random();
            //create a delegate object
            LongTypeDelegate longTypeDelegate1 = new LongTypeDelegate(Add);
            // this delegate object (longTypeDel1) is referencing the Add method
            //use it: invoke it (is the same as calling a method)
            //when we invoke a delegate object, the delegate object will call the method(s)
            // it is referencing
            // the syntax for invoking is the same as the syntax for calling
            int x1 = rand.Next(1, 100);
            int y1 = rand.Next(1, 100);
            long result1 = longTypeDelegate1(x1, y1);
            Console.WriteLine("\nInvoking longTypeDel1:");
            Console.WriteLine($"x1:{x1} y1:{y1} result1:{result1}");
           // Console.ReadLine();//pause
            //++++++++++++++++++++++++++++++++++++++++++++++++++++++
            //example 2:
            //define a method that takes 2 in and returns the product6
            //create a delegate Object for the method
            //invoke
            //display
            LongTypeDelegate longTypeDelegate2 = Mul;
           
            long result2 = longTypeDelegate1(x1, y1);

            Console.WriteLine("\nInvoking longTypeDel2:");
            Console.WriteLine($"x1:{x1} y1:{y1} result1:{result2}");
            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++
            //define a method with same signature as DoubleTypeDelegate. This method is to return the average value as a double
            // Create a delegate object for this method
            //invoke the delegate object
            //display its result
            DoubleTypeDelegate doubleTypeDelegate1 = ComputeAvg;
            int z1 = rand.Next(1, 100);
            
            double result3 = doubleTypeDelegate1(x1, y1, z1);
            Console.WriteLine("\nInvoking DoubleTypeDel1: ");
            Console.WriteLine($"x1:{x1} y1:{y1} z1:{z1} result3:{result3:f}");


            Console.ReadLine();//pause
        }
        //define a method with the same signature as LOngTypeDelegate
        static long Add(int a, int b)
        {
            return a + b;
        }
        static long Mul(int a, int b)
        {
            return a * b;
        }
        static double ComputeAvg(int a, int b, int c)
        {
            return (a + b + c)/ 3D;
        }
    }
}
