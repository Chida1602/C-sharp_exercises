/*
 //4th
string s;
int num = 99;
s=num.ToString();
Console.WriteLine("string = " + s);
Console.ReadLine();
*/

/*   5TH

 *  // BITWISE OPERATORS
 class Program {
      static void Main(string[] args) {
         int a = 60;            
int b = 13;            
int c = 0;

c = a & b;             
Console.WriteLine("Line 1 - Value of c is {0}", c);

c = a | b;            
Console.WriteLine("Line 2 - Value of c is {0}", c);

c = a ^ b;             
Console.WriteLine("Line 3 - Value of c is {0}", c);

c = ~a;                
Console.WriteLine("Line 4 - Value of c is {0}", c);

c = a << 2;      
Console.WriteLine("Line 5 - Value of c is {0}", c);

c = a >> 2;      
Console.WriteLine("Line 6 - Value of c is {0}", c);
Console.ReadLine();
      }
   }
}


    // LOGICAL OPERATORS
namespace OperatorsAppl
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            bool b = true;

            if (a && b)
            {
                Console.WriteLine("Line 1 - Condition is true");
            }

            if (a || b)
            {
                Console.WriteLine("Line 2 - Condition is true");
            }

            // lets change the value of  a and b 
            a = false;
            b = true;

            if (a && b)
            {
                Console.WriteLine("Line 3 - Condition is true");
            }
            else
            {
                Console.WriteLine("Line 3 - Condition is not true");
            }

            if (!(a && b))
            {
                Console.WriteLine("Line 4 - Condition is true");
            }
            Console.ReadLine();
        }
    }
}

  
  // REALATIONAL OPERATORS

 class Program
{
    static void Main(string[] args)
    {
        int a = 21;
        int b = 10;

        if (a == b)
        {
            Console.WriteLine("Line 1 - a is equal to b");
        }
        else
        {
            Console.WriteLine("Line 1 - a is not equal to b");
        }

        if (a < b)
        {
            Console.WriteLine("Line 2 - a is less than b");
        }
        else
        {
            Console.WriteLine("Line 2 - a is not less than b");
        }

        if (a > b)
        {
            Console.WriteLine("Line 3 - a is greater than b");
        }
        else
        {
            Console.WriteLine("Line 3 - a is not greater than b");
        }

       // Lets change value of a and b
        a = 5;
        b = 20;

        if (a <= b)
        {
            Console.WriteLine("Line 4 - a is either less than or equal to  b");
        }

        if (b >= a)
        {
            Console.WriteLine("Line 5-b is either greater than or equal to b");
        }
    }
}
*/




/*    //6th
string n=Console.ReadLine();    
int n1=Convert.ToInt32(n);
int i;
int fact = 1;
for (i = 0; i < n1; i++)
{
    fact*=i;
}
Console.WriteLine(fact);
*/



/*       //7TH

int i = 1, Count = 0, sum = 0;
do
{
    if (Count >= 20)
    {
        break;
    }
    if (i % 2 == 0)
    {
        sum += i;
        Count += 1;
    }
    i++;
} while (i <= 100);
Console.WriteLine(sum);

*/

/*       //8TH

string c= Console.ReadLine();
int day=Convert.ToInt32(c); switch (day)
{
    case 1: {
            Console.WriteLine("Monday");
            break;  
        }     case 2: { 
            Console.WriteLine("Tuesday");
            break;         }     case 3: { 
            Console.WriteLine("Wednesday");
            break;
        }     case 4: { Console.WriteLine("Thursday");
            break;         }     case 5: { Console.WriteLine("Friday");
            break;
                }
    case 6: {
            Console.WriteLine("Saturday");
                break;
        }
    case 7: {
            Console.WriteLine("Sunday");
            break;
        }
    //default:{
    //Console.WriteLine("None");
    //}
}
*/

/*    //9TH
int a = 10 ;
int b = 20;
int c = 40;
if (a > b && a > c)
{
    Console.WriteLine("A is largest");
}
else if (b > a && b > c)
{
    Console.WriteLine("B is largest");
}
else
{
    Console.WriteLine("c is largest");
}
*/



/*     //10TH
 

// break 
class BreakExample
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 10; i++)
        {
            if (i == 5)
            {
                break;
            }
            Console.WriteLine(i);
        }
    }
}

//continue
 class ContinueExample  
    {  
      public static void Main(string[] args)  
      {  
         for(int i=1;i<=10;i++){    
            if(i==5){    
                continue;    
            }    
            Console.WriteLine(i);    
        }    
      }  
   }  

//GOTO STATEMENT
class GotoExample
{
    public static void Main(string[] args)
    {
    ineligible:
        Console.WriteLine("You are not eligible to vote!");
        Console.WriteLine("Enter your age:\n");
        int age = Convert.ToInt32(Console.ReadLine());
        if (age < 18)
        {
            goto ineligible;
        }
        else
        {
            Console.WriteLine("You are eligible to vote!");
        }
    }
}
*/


/*        //11th

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Enter the first Integer :");
        int ninput1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second Integer :");
        int ninput2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("1 - Addition.\n2 - Substraction.\n3 - Multiplication.\n4 - Division.\n5 - Exit.");
        Console.WriteLine("Enter your choice");
        int choice = Convert.ToInt32(Console.ReadLine());
        int result = 0; switch (choice)
        {
            case 1:
                result = ninput1 + ninput2;
                Console.WriteLine("The Addition of " + ninput1 + " and " + ninput2 + " is " + result);
                break;
            case 2:
                result = ninput1 - ninput2;
                Console.WriteLine("The Subtraction of " + ninput1 + " and " + ninput2 + " is " + result);
                break;
            case 3:
                result = ninput1 * ninput2;
                Console.WriteLine("The Multiplication of " + ninput1 + " and " + ninput2 + " is " + result);
                break;
            case 4:
                result = ninput1 / ninput2;
                Console.WriteLine("The division of " + ninput1 + " and " + ninput2 + " is " + result);
                break;
            case 5:
                Console.WriteLine("Exit");
                break;
            default:
                Console.WriteLine("Enter valid input");
                break;
        }
    }
}

*/


/*       //12th

 class Program
{
    public void Display(int a)
    {
        a += a;
        Console.WriteLine("Value inside the function: " + a);
    }
    static void Main(string[] args)
    {
        int a = 100;
        Program xyz = new Program();
        Console.WriteLine("Value before calling: " + a);
        xyz.Display(a);
        Console.WriteLine("Value after calling: " + a);
    }
}

*/


/*        //13th

using System;
namespace callByReference
{
    class Program
    {
        public void Show(ref int val)
        {
            val += val;
            Console.WriteLine("Value inside the function: " + val);
        }
        static void Main(string[] args)
        {
            int val = 100;
            Program program = new Program();
            Console.WriteLine("Value before calling: " + val);
            program.Show(ref val);
            Console.WriteLine("Value after calling: " + val);
        }
    }
}

*/

/*     //14th

using System;
namespace OutParameter
{
    class Program
    {
        // User defined function  
        public void Show(out int val) // Out parameter  
        {
            int square = 5;
            val = square;
            val *= val;
        }
        // Main function
        static void Main(string[] args)
        {
            int val = 50;
            Program program = new Program(); // Creating Object  
            Console.WriteLine("Value before passing out variable " + val);
            program.Show(out val);
            Console.WriteLine("Value after recieving the out variable " + val);
        }
    }
}

*/




/*    //15th

static int StringLength(string s)
{
    int l = 0;
    l = s.Length; return l;
}
string name = Console.ReadLine();
Console.WriteLine(StringLength(name));

*/


/*      //16th

public class NamedArgumentsExample
{
    static string GetFullName(string firstName, string lastName)
    {
        return firstName + " " + lastName;
    }
    public static void Main(string[] args)
    {
        string fullName1 = GetFullName("Rahul", "Kumar");
        string fullName2 = GetFullName(firstName: "Rahul", lastName: "Kumar");
        string fullName3 = GetFullName(lastName: "Rahul", firstName: "Kumar");
        Console.WriteLine(fullName1);
        Console.WriteLine(fullName2);
        Console.WriteLine(fullName3);
    }
}

*/



/*    //17th

//To declare more than one variable of the same type, use a comma-separated list.
int x = 45, y = 25, z = 50;
Console.WriteLine(x + y + z);
//You can also assign the same value to multiple variables in one line
int a, b, c;
a = b = c = 50;
Console.WriteLine(a + b + c);

*/




/*   //18th

//implicit casting

class Program
{
    static void Main(string[] args)
    {
        int myInt = 9;
        double myDouble = myInt;
        Console.WriteLine(myDouble);
    }
}

//explicit casting 

class Program
{
    static void Main(string[] args)
    {
        double myDouble = 9.78;
        int myInt = (int)myDouble;
        Console.WriteLine(myInt);

    }
}

*/