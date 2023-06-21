//using System;
//public static class MyMath
//{
//    public static float PI = 3.14f;
//    public static int cube(int n) 
//    { 
//        return n * n * n; 
//    }
//    public static void Main(string[] args)
//    {
//        Console.WriteLine("Value of PI is: " + MyMath.PI);
//        Console.WriteLine("Cube of 3 is: " + MyMath.cube(3));
//    }
//}

//public class fibonacci
//{
//    public static void Main(string[] args)
//    {
//        int a = 0;
//        int b = 1;
//        Console.WriteLine(a"")
//    }
//}



//public class Account
//{
//    int accno;
//    String name;
//    static float rateOfInterest = 9.433f;
//    public Account(int accno, String name)
//    {
//        this.accno = accno;
//        this.name = name;
//    }
//    public void display()
//    {
//        Console.WriteLine(accno + " " + name + " " + rateOfInterest);
//    }
//}
//class TestAccount
//{
//    public static void Main(string[] args)
//    {
//        Account a1 = new Account(101, "chida");
//        Account a2 = new Account(102, "Murari");
//        a1.display();
//        a2.display();

//    }
//}


//public interface IActivity
//{
//    void Execute();
//}
//public interface IWorkFlow
//{
//    void AddActivity(IActivity activity);
//    void RemoveActivity(IActivity activity);
//    IEnumerable<IActivity> GetActivities();
//}
//public class Upload : IActivity
//{
//    public void Execute()
//    {
//        Console.WriteLine("Uploading...");
//    }
//}
//public class Notify : IActivity
//{
//    public void Execute()
//    {
//        Console.WriteLine("User has been notified.");
//    }
//}
//public class ChangeStatus : IActivity
//{
//    public void Execute()
//    {
//        Console.WriteLine("Video status is now 'Processing'.");
//    }
//}
//public class WorkFlow : IWorkFlow
//{
//    internal IList<IActivity> _activities;
//    public WorkFlow()
//    {
//        _activities = new List<IActivity>();
//    }
//    public void AddActivity(IActivity activity)
//    {
//        _activities.Add(activity);
//    }
//    public void RemoveActivity(IActivity activity)
//    {
//        _activities.Remove(activity);
//    }
//    public IEnumerable<IActivity> GetActivities()
//    {
//        return _activities;
//    }
//}
//public class WorkFlowEngine
//{
//    public IWorkFlow _workFlow;
//    public WorkFlowEngine(IWorkFlow workflow)
//    {
//        _workFlow = workflow;
//    }
//    public void Run()
//    {
//        foreach (var activity in _workFlow.GetActivities())
//        {
//            activity.Execute();
//        }
//    }
//}
//public class Program
//{
//    public static void Main()
//    {
//        WorkFlow workflow = new WorkFlow();
//        workflow.AddActivity(new Upload());
//        workflow.AddActivity(new Notify());
//        workflow.AddActivity(new ChangeStatus());
//        WorkFlowEngine engine = new WorkFlowEngine(workflow);
//        engine.Run();
//    }
//}
//*/


using System.Diagnostics;
public interface IActivity { void Execute(); }
public interface IWorkflow
{
    void RegisterActivity(IActivity activityObj); List<IActivity> GetAllActivities(); //return all the activities registered using the above}public class uploadvideo : IActivity //this should be repeated for all the activites{public void Execute(){Console.WriteLine("Uploading video...");}}public class callingWebService : IActivity //this should be repeated for all the activites{public void Execute(){Console.WriteLine("callingWebService...");}}public class emailSending : IActivity //this should be repeated for all the activites{public void Execute(){Console.WriteLine("sending email....");}}public class changeStatus : IActivity //this should be repeated for all the activites{public void Execute(){Console.WriteLine("Changing status...Processing Video....");}}class workflow : IWorkflow{private List<IActivity> aList = new List<IActivity>();public void RegisterActivity(IActivity activityObj){aList.Add(activityObj);}public List<IActivity> GetAllActivities(){//retun all the activities registerd. Activity objectreturn aList;}}class WorkFLowEngine{public void Run(IWorkflow obj){List<IActivity> aList = obj.GetAllActivities();//iterate the workflow obj and call the corresponding activites Execute methodforeach (IActivity activity in aList){activity.Execute();}}//private List<IActivity> aList = obj.GetAllActivities();//foreach (var act in )} class Program{public static void Main(string[] args){//create object for workflowengineWorkFLowEngine wrk = new WorkFLowEngine();//create objcet for workflowworkflow wrkf = new workflow();//call the registeractivity method of workflow by passing the activity as a parameteruploadvideo act1 = new uploadvideo();callingWebService act2 = new callingWebService();emailSending act3 = new emailSending();changeStatus act4 = new changeStatus();wrkf.RegisterActivity(act1);wrkf.RegisterActivity(act2);wrkf.RegisterActivity(act3);wrkf.RegisterActivity(act4);//call register for all the activity List<IActivity> activities = wrkf.GetAllActivities();/*foreach (IActivity activity in activities){Console.WriteLine(activity);}*///call the workflowengine class run method by passing the workflow object created abovewrk.Run(wrkf);}}

