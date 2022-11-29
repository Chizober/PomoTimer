using System;
using System.Threading;
using System.Diagnostics;
namespace PomodoroTimer
{
   class Timer
  {
    string input;
    int taskTwoDuration;
    int taskOneDuration;
    string response;
    bool isTrue = true;
    bool check;

    public Timer(int taskTwoDuration, int taskOneDuration,string input)
    {
      this.taskOneDuration = taskOneDuration;
      this.taskTwoDuration = taskTwoDuration;
      this.input = input;
    }
        public void  TaskTimer()
     { 
         while(isTrue)
       {
        response= ""; 
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();


      do{
        Console.WriteLine("please enter an activity, only letters allowed");
        input = Console.ReadLine();
      }
      while(input.Any(x=>!char.IsLetter(x)));
      
        do{
        Console.WriteLine("Enter a time in seconds for your activity");
        check = int.TryParse(Console.ReadLine(), out taskOneDuration);
        }
        while(!check);

      do{
        Console.WriteLine("please enter an activity, only letters allowed");
        input = Console.ReadLine();
      }
      while(input.Any(x=>!char.IsLetter(x)));

        do{
        Console.WriteLine("Enter a time in seconds for your activity");
        check = int.TryParse(Console.ReadLine(), out taskTwoDuration);
        }
        while(!check);
        for(int i =taskOneDuration; i>=0; i--)
        {
         Console.WriteLine( input + " countdown...  " + i  + " Second(s)");
         Thread.Sleep(1000);
         Console.Clear();
        }
       Console.WriteLine( input + " completed in : " + taskOneDuration  + "Second(s)");

          for(int i =taskTwoDuration; i>=0; i--)
       {
           Console.WriteLine( input + " countdown... " + i  + " Second(s)");
           Thread.Sleep(1000);
           Console.Clear();
       }
            Console.WriteLine( input + " completed in : " + taskTwoDuration  + "Second(s)");
            stopwatch.Stop();

            TimeSpan totalTime = stopwatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",totalTime.Hours, totalTime.Minutes, totalTime.Seconds,totalTime.Milliseconds/10);
            Console.WriteLine($"Total time for the session is {elapsedTime}");

            while(response!="Y" && response!="N")
            {
              Console.WriteLine(" would you like to play again(Y/N):");
              response = Console.ReadLine();
              response = response.ToUpper();
            }
        if(response =="Y")
        {
          isTrue = true;
        }
        
        else{
           isTrue = false;
        }
      }
       Console.WriteLine("This brings you to the end of your session");
       }
     }
     
  class Program
  {
    static void Main(string[] args)
     {
      int taskOneDuration = 0; int taskTwoDuration = 0;  string input="";
      Timer timer1  = new Timer(taskOneDuration, taskTwoDuration, input);
      timer1.TaskTimer();
      Console.ReadKey();
    }
  }
}


