/*       ///stackoverflow

namespace StackOverflowPostExercise
{ 
    public class Post
    {
        private int _voteCount = 0; public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreationTime { get; }
        public Post(string title, string description)
        {
            Title = title;
            Description = description;
            CreationTime = DateTime.Now;
        }
        public void UpVote()
        {
            _voteCount++;
        }
        public void DownVote()
        {
            _voteCount--;
        }
        public int GetVoteCount()
        {
            return _voteCount;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post("First post", "This is my first post on Stack Overflow.");
            Console.WriteLine("Post created on " + post.CreationTime); post.UpVote();
            post.UpVote();
            post.DownVote();
            Console.WriteLine("Current vote count: " + post.GetVoteCount());
        }
    }
}

*/


/*       

using System;
namespace chidanand
{
    class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime TimeDateCreated { get; private set; }
        public int VoteCount { get; private set; }
        private bool HasVotedUp;
        private bool HasVotedDown; public Post(string title, string description)
        {
            Title = title;
            Description = description;
            TimeDateCreated = DateTime.Now;
            VoteCount = 0;
        }
        public void VoteUp()
        {
            if (HasVotedUp)
            {
                throw new Exception("You have already up-voted.");
            }
            else
            {
                VoteCount++;
                HasVotedUp = true;
                HasVotedDown = false;
            }
        }
        public void VoteDown()
        {
            if (HasVotedDown)
            {
                throw new Exception("You have already down-voted.");
            }
            else
            {
                VoteCount--;
                HasVotedDown = true;
                HasVotedUp = false;
            }
        }
    }
}
namespace chidanand
{
    class Program
    {
        static void Main()
        {
            Post post = new Post("Does my post work?", "Test to see if my post works.");
            System.Console.WriteLine($"Title: {post.Title}");
            System.Console.WriteLine($"Description: {post.Description}");
            System.Console.WriteLine($"Date Created: {post.TimeDateCreated}");
            System.Console.WriteLine($"Post Count: {post.VoteCount}");
            post.VoteDown();
            System.Console.WriteLine($"Post Count: {post.VoteCount}");
            post.VoteUp();
            System.Console.WriteLine($"Post Count: {post.VoteCount}");
        }
    }
}

*/


/*             //stopWatch 

using System;
class StopWatchchida
{
    public static bool isStarted = false;
    public static bool isStopped = true;
    public static string Stime = "";
    public static string Etime = "";



    public static void start()
    {
        if (isStarted)
        {
            throw new InvalidOperationException("Already Watch started!!..Stop it and start again");
        }
        isStarted = true;
        isStopped = false;
        Stime = (DateTime.Now.ToString("HH:mm:ss"));
        Console.WriteLine("watch started on " + DateTime.Now.ToString("HH:mm:ss"));
    }
    public static void stop()
    {

        if (Stime.Equals(""))
        {
            throw new InvalidOperationException("Not yet watch started, Start it first!!");
        }
        else if (isStopped)
        {
            throw new InvalidOperationException("Already watch is stopped!!...Start it first!!");
        }
        isStopped = true;
        isStarted = false;
        Etime = (DateTime.Now.ToString("HH:mm:ss"));
        Console.WriteLine("watch ended on " + DateTime.Now.ToString("HH:mm:ss"));



    }
    public static string duration()
    {
        if (Stime.Equals(""))
        {
            throw new InvalidOperationException("Not yet watch started, Start it first!!");
        }
        if (!isStopped)
        {
            throw new InvalidOperationException("Already Watch is running!!..Stop it to check the time span");
        }
        string d = "";
        TimeSpan duration = DateTime.Parse(Etime).Subtract(DateTime.Parse(Stime));
        d = duration.ToString();
        return d;
    }
}



class Program
{
    public static void Main(string[] args)
    {
    b: Console.WriteLine("Enter a option: \n1.start. \n2.stop \n3.duration \n4.exit");
        int option = Convert.ToInt32(Console.ReadLine());
        switch (option)
        {
            case 1:
                {
                    try
                    {
                        StopWatchchida.start();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    goto b;
                }
            case 2:
                {
                    try
                    {
                        StopWatchchida.stop();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    goto b;
                }
            case 3:
                {
                    try
                    {
                        Console.WriteLine(StopWatchchida.duration());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    goto b;
                }
            case 4:
                {
                    Console.WriteLine("See you later!!");
                    break;
                }
            default:
                {
                    Console.WriteLine("Enter valid option");
                    goto b;
                }
        }



    }
}
*/





/*

class Human 
{
   public int a = 10;
}
class program
{
    static void Main(string[] args)
    {
        Human obj = new Human();
        obj.a++;
        Console.WriteLine(obj.a);
    }
}

*/





/*
 class Car
{
    //fields
    protected string sColor = "";
public static string sBrand = "";
private string sSpeed = "";


//property
public string SSpeed
{
    get { return sSpeed; }
    set { sSpeed = value; }
}

public Car()
{
    Console.WriteLine("constructor");
}


//Methods
public void Accelerate()
{
    Console.WriteLine("Accelerator is pressed");
}
public void Brake()
{
    Console.WriteLine("Brake is applied");
}

public void sSetSpeed(string sSpeed)
{
    this.sSpeed = sSpeed;
}

public string sGetSpeed()
{
    return sSpeed;
}

}

class Program : Car
{
    private static void Main(string[] args)
    {
        Car obj = new Car();
        obj.sSetSpeed("40");
        obj.sGetSpeed();
        obj.Accelerate();
        obj.Brake();
        obj.SSpeed = "40";
        string s = obj.SSpeed;
        Car.sBrand = "";

    }
}
*/