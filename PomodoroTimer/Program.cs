using System;
using System.Threading;
using System.Diagnostics;
namespace PomodoroTimer
{
  
  class Timer{
    public  void WorkCount(int work_time,int work_duration=0)
    { 
        for(int i =work_time; i>=0; i--)
        {
        Console.WriteLine("Work countdown... " + i  + " Second(s)");
       
         Thread.Sleep(1000);
         Console.Clear();
        }
       Console.WriteLine("Work  completed in : " + work_time  + " Second(s)");
    }

     public void RestCount(int rest_time,int rest_duration=0)
    {
      for(int i =rest_time; i>=0; i--)
       {
           Console.WriteLine("rest : " + i  + " Second(s)");
           Thread.Sleep(1000);
           Console.Clear();
       }
           Console.WriteLine("rest  completed in : " + rest_time  + "Second(s)");
     }
  }
  class Program{
    static void Main(string[] args)
    {
        int rest_time; int work_time; 
      Console.WriteLine("please enter an activity");
      var one = (Console.ReadLine());
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();
      Console.WriteLine("Enter a time in minutes for your activity");
      int work_duration =Convert.ToInt32(Console.ReadLine());;
      work_time = Convert.ToInt32(work_duration) * 60;
      Thread.Sleep(work_time);
      Console.WriteLine("please enter another activity");
      var two = (Console.ReadLine());
      Console.WriteLine("Enter a time in minutes for your activity");
      int rest_duration =Convert.ToInt32(Console.ReadLine());;
      rest_time = Convert.ToInt32(rest_duration) * 60;
      Timer work  = new Timer();
      work.WorkCount(work_time);
      Timer rest  = new Timer();
      rest.RestCount(rest_time);
      stopwatch.Stop();
      TimeSpan totalTime = stopwatch.Elapsed;
      string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",totalTime.Hours, totalTime.Minutes, totalTime.Seconds,totalTime.Milliseconds/10);
      Console.WriteLine($"Total time for the session is {elapsedTime}");
      Console.ReadKey();
    }
  }
}
