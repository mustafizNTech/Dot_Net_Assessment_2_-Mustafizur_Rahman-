using System;

public interface Activity{
  void Execute();
}

public class WorkflowEngine{
  public void Run(List<Activity> workflow){
    foreach(var activity in workflow){
      activity.Execute();
    }
  }
}

public class Activity1: Activity{
  public void Execute(){
    Console.WriteLine("Activity 1 executed.");
  }
}

public class Activity2: Activity{
  public void Execute(){
    Console.WriteLine("Activity 2 executed.");
  }
}

public class Activity3: Activity{
  public void Execute(){
    Console.WriteLine("Activity 3 executed.");
  }
}

class Program{
  static void Main(string[] args){
    var workflow = new List<Activity>
    {
      new Activity1(),
      new Activity2(),
      new Activity3()
    };

    WorkflowEngine workflowEngine = new WorkflowEngine();
    workflowEngine.Run(workflow);
  }
}