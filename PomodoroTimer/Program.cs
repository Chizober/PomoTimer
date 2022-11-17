using System;
using System.Threading;
namespace PomodoroTimer
{
  
  class Timer{
    public  void WorkCount()
    { 
        int n = 25;
      for(int i =n; i>=0; i--)
      {
        Console.WriteLine("Work countdown : " + i  + " minutes");
       
        Thread.Sleep(1000);
        Console.Clear();
      }
       Console.WriteLine("Work  completed in : " + n  + " minutes");
    }

     public void RestCount()
    {
         int m = 5;
      for(int i =m; i>=0; i--)
      {
        Console.WriteLine("rest : " + i  + " minutes");
        Thread.Sleep(1000);
         Console.Clear();
         }
     Console.WriteLine("rest  completed in : " + m  + "minutes");
    }
     
    

  }
  class Program{
    static void Main(string[] args)
    {
        Thread mainThread = Thread.CurrentThread;
        Timer one  = new Timer();
        Console.WriteLine("Please enter an activity");
        mainThread.Name = Console.ReadLine();
        one.WorkCount();
        Console.WriteLine("Please enter another activity");
        mainThread.Name = Console.ReadLine();
        Timer two  = new Timer();
        two.RestCount();
        Console.WriteLine("Total time for the session is");
        Console.ReadKey();
    }
  }
}
}
