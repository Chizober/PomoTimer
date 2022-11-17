using System;
using System.Threading;
using System.Diagnostics;
namespace PomodoroTimer
{
  
  class Timer{
    public  void WorkCount()
    { 
        int work_duration = 25;
        for(int i =work_duration; i>=0; i--)
        {
        Console.WriteLine("Work countdown : " + i  + " minutes");
       
         Thread.Sleep(1000);
         Console.Clear();
        }
       Console.WriteLine("Work  completed in : " + work_duration  + " minutes");
    }

     public void RestCount()
    {
         int rest_duration = 5;
      for(int i =rest_duration; i>=0; i--)
       {
           Console.WriteLine("rest : " + i  + " minutes");
           Thread.Sleep(1000);
           Console.Clear();
       }
           Console.WriteLine("rest  completed in : " + rest_duration  + "minutes");
     }
  }
  class Program{
    static void Main(string[] args)
    {
         Thread mainThread = Thread.CurrentThread;
         Stopwatch stopwatch = new Stopwatch();
         stopwatch.Stop();
         TimeSpan totalTime = stopwatch.Elapsed;
         stopwatch.Start();
        Timer work  = new Timer();
        Console.WriteLine("Please enter an activity");
        mainThread.Name = Console.ReadLine();
        work.WorkCount();
        Console.WriteLine("Please enter another activity");
        mainThread.Name = Console.ReadLine();
        Timer rest  = new Timer();
        rest.RestCount();
        Console.WriteLine($"Total time for the session is {0:00}:{1:00}:{2:00} ", totalTime.Hours,totalTime.Minutes, totalTime.Seconds);
        Console.ReadKey();
    }
  }
}
