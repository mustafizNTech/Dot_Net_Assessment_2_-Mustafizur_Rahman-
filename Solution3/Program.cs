using System;
class Stopwatch {
    private DateTime startingTime;
    private TimeSpan timeElapsed;
    private bool isStopwatchRunning;


    public void Start(){
        if(isStopwatchRunning){
            throw new InvalidOperationException("Already stop watch already started!");
        }

        startingTime = DateTime.Now;
        isStopwatchRunning = true;
    }

    public void Stop(){
        TimeSpan elapsed = DateTime.Now - startingTime;
        timeElapsed+=elapsed;
        isStopwatchRunning = false;
    }

    public TimeSpan GetElapsedTime(){
        return timeElapsed;
    }
}

class Program{
    static void Main(string[] args){
        Stopwatch stopwatch = new Stopwatch();

        stopwatch.Start();
        System.Threading.Thread.Sleep(2000);
        stopwatch.Stop();

        Console.WriteLine("Elapsed time: " + stopwatch.GetElapsedTime());

        stopwatch.Start();

        System.Threading.Thread.Sleep(1500);

        stopwatch.Stop();

        Console.WriteLine("Elapsed time: " + stopwatch.GetElapsedTime());
    }
}