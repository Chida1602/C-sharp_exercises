/*              //3rd


using System;
namespace DbCommandPolymorphism
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }
        public abstract void Open();
        public abstract void Close();
    }
    public class SqlConnection : DbConnection
    {
        public override void Open()
        {
            Console.WriteLine("Opening SQL connection...");
        }
        public override void Close()
        {
            Console.WriteLine("Closing SQL connection...");
        }
    }
    public class OracleConnection : DbConnection

    {

        public override void Open()

        {
            Console.WriteLine("Opening Oracle connection...");
        }
        public override void Close()
        {
            Console.WriteLine("Closing Oracle connection...");
        }
    }
    public class DbCommand
    {
        public string Instruction { get; set; }
        public DbConnection Connection { get; set; }
        public DbCommand(string instruction, DbConnection connection)
        {
            if (String.IsNullOrWhiteSpace(instruction))
                throw new ArgumentException("Instruction cannot be null or empty.");
            if (connection == null)
                throw new ArgumentNullException("connection", "Connection cannot be null.");
            Instruction = instruction;

            Connection = connection;

        }

        public void Execute()

        {

            Connection.Open();

            Console.WriteLine("Executing instruction: " + Instruction);

            Connection.Close();

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            DbConnection sqlConnection = new SqlConnection();
            DbCommand sqlCommand = new DbCommand("SELECT * FROM Customers", sqlConnection);
            sqlCommand.Execute();
            Console.WriteLine();
            DbConnection oracleConnection = new OracleConnection();
            DbCommand oracleCommand = new DbCommand("SELECT * FROM Customers", oracleConnection);
            oracleCommand.Execute();
            Console.ReadLine();
        }
    }
}
*/  




/*              //2nd


using System;
namespace program
{

    public abstract class DBConnection

    {
        public abstract void open();
        public abstract void close();
    }
    class SQLConnection : DBConnection
    {
        public string ConnectionString { get; set; }
        public SQLConnection(string Connectionstring)
        {
            try
            {
                if (Connectionstring == null)
                {
                    throw new ArgumentNullException("--> Null Instruction");
                }
                else
                {
                    ConnectionString = Connectionstring;
                    Console.WriteLine("Connection string: " + ConnectionString);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public override void open()
        {
            Console.WriteLine("SQL connection opened");
        }
        public override void close()
        {
            Console.WriteLine("SQL connection closed");
        }
    }
    class OracleConnection : DBConnection
    {
        public string ConnectionString { get; set; }
        public OracleConnection(string Connectionstring)
        {
            try
            {
                if (Connectionstring == null)
                {
                    throw new ArgumentNullException("--> Null Instruction");
                }
                else
                {
                    ConnectionString = Connectionstring;
                    Console.WriteLine("Connection string: " + ConnectionString);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public override void open()
        {
            Console.WriteLine("Oracle connection opened");
        }
        public override void close()
        {
            Console.WriteLine("Oracle connection closed");
        }
    }
    class MainClass
    {
        public static void Main(String[] args)
        {
            //BaseClassname objectName = new DerivedClassName();     

            Console.WriteLine("Enter the Connection string:");
            string connString = Console.ReadLine();
            Console.WriteLine("Enter 1 to connect to SQL database\nEnter 2 to connect to Oracle database\n");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                DBConnection connection1 = new SQLConnection(connString);
                connection1.open();
                connection1.close();
            }
            else if (choice == 2)
            {
                DBConnection connection2 = new OracleConnection(connString);
                connection2.open();
                connection2.close();
            }
            else

            {
                Console.WriteLine("-Exits-");
            }
        }
    }
}

*/


/*    // 1st


using System.Collections;
using System.Runtime.CompilerServices;

class StackByChida
{
    private Object[] st = new Object[1];
    private int top = 0;
    public void push(Object element)
    {
        if (element == null)
        {
            throw new InvalidOperationException("Null cant be passed here.");
        }
        if (top == this.st.Length)
        {
            Object[] st2 = new Object[this.st.Length * 2];
            for (int i = 0; i < this.st.Length; i++)
            {
                st2[i] = this.st[i];
            }
            this.st = st2;
        }
        this.st[top] = element;
        this.top++;
    }
    public Object pop()
    {
        if (top == 0)
        {
            throw new InvalidOperationException("Stack is empty!!!");
        }
        Object element = st[this.top - 1];
        this.st = this.RemoveElement(this.st, this.top - 1);
        this.top--;
        return element;
    }
    private Object[] RemoveElement(Object[] arr, int RemoveAt)
    {
        Object[] arr2 = new Object[arr.Length - 1];

        int i = 0;
        int j = 0;
        while (i < arr.Length)
        {
            if (i != RemoveAt)
            {
                arr2[j] = arr[i];
                j++;
            }

            i++;
        }

        return arr2;
    }
    public void clear()
    {
        this.st = new Object[1];
        this.top = 0;
    }
    public void display()
    {
        if (this.top == 0)
        {
            Console.WriteLine("Stack is Empty!!!");
        }
        else
        {
            for (int i = 0; i < this.top; i++)
            {
                Console.WriteLine(st[i]);
            }
        }
    }
}
class Program
{
    public static void Main(String[] args)
    {
        var s2 = new StackByChida();
        StackByChida s1 = new StackByChida();
        s1.push("Chida");
        s1.push(true);
        s1.push(2);
        s1.push(4.5);
        s1.push('c');

        //s1.push(null);
        
        s1.display();
        Console.WriteLine(s1.pop());
        Console.WriteLine(s1.pop());
        Console.WriteLine(s1.pop());
        Console.WriteLine(s1.pop());
        Console.WriteLine(s1.pop());

        //Console.WriteLine(s1.pop());
       
        s1.display();
        s1.push("Chida");
        s1.push(true);
        s1.push(2);
        s1.display();
        s1.clear();
        s1.display();
    }
}

*/
