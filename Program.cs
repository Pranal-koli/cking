using System;

namespace Delegate_C_Sharp
{
    class Program
    {
        //Step 1 Declare a deligate
        delegate void mydelegate(string a, string b);
        delegate void arithmaticdelegate(int c, int d);
        delegate void SCM(int x,int y);
        static void Main(string[] args)
        {
            //Step 2 create object of delegate and passs name of method which you want to execute
            mydelegate mydel = new mydelegate(Fullname);
            arithmaticdelegate ar = new arithmaticdelegate(Addition);
            ar += new arithmaticdelegate(Subtraction);
            ar += new arithmaticdelegate(Multiplication);
            ar += new arithmaticdelegate(Division);
            mydel += new mydelegate(FullnameAllCap);
            SCM s= new SCM(Multiply);
            s += new SCM(Square);
            s += new SCM(Cube);
            //Step 3 invoke method via delegate object
            mydel("Chinmay", "Kulkarni");
            Console.WriteLine("Enter 1st Number");
            if (int.TryParse((Console.ReadLine()), out int a))
            {
                Console.WriteLine("Enter another Number");
                if (int.TryParse((Console.ReadLine()), out int b))
                    s(a,b);
                else
                    Console.WriteLine("Please Enter Number only");
            }
            else
                Console.WriteLine("Please Enter Number only");

           
        }

        public static void Fullname(string fname,string lname)
        {
            Console.WriteLine("Full name is {0} {1}",fname,lname);
        }
        public static void FullnameAllCap(string fname, string lname)
        {
            Console.WriteLine("Full name is {0} {1}", fname.ToUpper(), lname.ToUpper());
        }
        public static void Addition(int a , int b)
        {
            Console.WriteLine("Addition of {0} and {1} is {2}",a,b,a+b);
        }
        public static void Subtraction(int a, int b)
        {
            Console.WriteLine("Subtraction of {0} and {1} is {2}", a, b, a - b);
        }
        public static void Multiplication(int a, int b)
        {
            Console.WriteLine("Multiplication of {0} and {1} is {2}", a, b, a * b);
        }
        public static void Division(int a, int b)
        {
            Console.WriteLine("Addition of {0} and {1} is {2}", a, b, a / b);
        }
        public static void Square(int a,int b)
        {
            Console.WriteLine("Square of {0} is {1}", a,a*a);
        }
        public static void Cube(int a,int b)
        {
            Console.WriteLine("Cube of {0} is {1}", a, a * a*a);
        }
        public static void Multiply(int a,int b)
        {
            Console.WriteLine("Multiplication  of {0} and {1} is {2}", a,b,b* a);
        }
    }
}
