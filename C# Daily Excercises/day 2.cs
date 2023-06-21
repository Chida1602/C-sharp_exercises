

/*  //14th

int a = 10; 
int b = 0; 
try 
{ 
    int c = a / b; 
}
catch (Exception e) 
{ 
    Console.WriteLine("Number cant divided with zero!!"); 
}

*/


/*   //15th

int a = 10; 
int b = 0;
try
{
    int c = a / b;
}
catch (Exception e)
{
    Console.WriteLine("Number cant divided with zero!!");
}
finally
{
    Console.WriteLine("I always run!!");
}

*/


/* //16th
 
int[] numbers = { 1, 2, 3, 4, 5 };
int GetNumber(int index)
{ 
    if (index < 0 || index >= numbers.Length) 
    { 
        throw new IndexOutOfRangeException(); 
    } 
    return numbers[index]; 
}
Console.WriteLine(GetNumber(10));

 */

/*  //13th
 
 //File.Delete("C:\\Users\\m.chidanand\\OneDrive - Dedalus S.p.A\\Documents\\Visual Studio 2022\\temp1.txt");
//File.Create("C:\\Users\\m.chidanand\\OneDrive - Dedalus S.p.A\\Documents\\Visual Studio 2022\\temp1.txt");
//Console.WriteLine(File.Exists("C:\\Users\\m.chidanand\\OneDrive - Dedalus S.p.A\\Documents\\Visual Studio 2022\\temp1.txt"));

 */


/*   //12
 
StreamWriter chidanand = new StreamWriter("C:\\Users\\m.chidanand\\OneDrive - Dedalus S.p.A\\Documents\\Visual Studio 2022\\temp.txt");
string[] chida = { "Monday", "tuesday", "wednesday", "thursday" ,"friday"};
foreach(string i in chida)
{
    chidanand.WriteLine(i);
}
chidanand.Close();

*/



/*   //10th
 
class Function
{
    enum a
    {
        Jan,
        Feb,
        Mar=3,
        Apr,
        May,
        Jun,
        Jul
    }
    static void Main(string[] args)
    {
        int month = (int)a.May;
        Console.WriteLine(month);
    }
}
*/

/*   //9th
int rowSize = 3;
int colSize = 3;
int[,] arr = new int[rowSize, colSize];
for (int i = 0; i < rowSize; i++)
{
    for (int j = 0; j < colSize; j++)
    {
        arr[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}
Console.Write("element at position arr[1,2] is: "+ arr[1, 2] );

 */



/*  //7th

class Program
{
    static void Main(string[] args)
    {
        string[] arr = { "My","Name","is","chidanand" };
        foreach (string i in arr)
        {
            Console.WriteLine(i);
        }
    }
}

 */



/*    //5th

class Program
{
    static void Main(string[] args)
    {
        string a=Console.ReadLine();
        String b =Console.ReadLine();
        int Count = 0;
        for (int i = 0; i <= (a.Length - b.Length); i++)
        {
            String result = a.Substring(i, b.Length);
            if (result.Equals(b))
            {
                Count += 1;
            }
        }
        Console.WriteLine("repetative is "+Count);
    }
}

 */

/*   // 6th

//initialise a string  
string[] a = { "zero","one", "two", "three", "four", "five", "six", "seven", "eight", "nine","ten" };
for (int i = 0; i < a.Length; i++)
{
    //condtion given is print only even numbers
    if (i % 2 == 0)
        Console.WriteLine(a[i]);

 */


//Console.WriteLine("Hi \"Chidanand\""); //4th

/* //3rd

string fname = "M"; 
string lname = "Chidanand";
int id = 19001218;
Console.WriteLine($"Hello This is {fname} {lname} & my intern Id  {id}");

 */


/*  // 2nd

//copy method
string a = "string copy";
string b = string.Copy(a);
Console.WriteLine(a);
Console.WriteLine(b);
//Remove method
string s1 = "Removed";
string s2 = s1.Remove(3, 4);
Console.WriteLine(s2);
//replace method
string c = "Hello F#";
string d = c.Replace('F', 'C');
Console.WriteLine(d);
//join string
string[] s3 = { "Chidanand", "19001218" };
string s4 = string.Join("-", s3);
Console.WriteLine(s4);
//upper
string x= "chidanand";
string y = x.ToUpper();
Console.WriteLine(y);

 */


/*  //1st 

string a = "Hi ";
string b = "This is";
string c = " Chidanand";
Console.WriteLine(string.Concat(a,b,c));

 */
