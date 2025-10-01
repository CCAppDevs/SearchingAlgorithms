using SearchingAlgorithms;
using System.Diagnostics;

Stopwatch stopwatch = Stopwatch.StartNew();


// usage 100 thousand values
stopwatch.Start();
int[] largeRandomArr = GenerateRandomArray(1000000000, 1, 1000000000);
stopwatch.Stop();
DisplayRuntime(stopwatch);

stopwatch.Start();
int[] largeSortedArr = GenerateArray(1000000000, 1);
stopwatch.Stop();
DisplayRuntime(stopwatch);

Console.WriteLine();

// search for a number
stopwatch.Start();
Console.WriteLine("3 was found at index: " + Algorithms.LinearSearch(largeRandomArr, 3));
stopwatch.Stop();
DisplayRuntime(stopwatch);

// search for a number
stopwatch.Start();
Console.WriteLine("3 was found at index: " + Algorithms.LinearSearch(largeSortedArr, 3));
stopwatch.Stop();
DisplayRuntime(stopwatch);

// generate random array function
static int[] GenerateArray(int numElements, int start)
{
    int[] arr = new int[numElements];

    for (int i = 0; i < numElements; i++)
    {
        arr[i] = start + i;
    }

    return arr;
}

// generate random array function
static int[] GenerateRandomArray(int numElements, int min, int max)
{
    Random rnd = new Random();
    int[] arr = new int[numElements];

    // process?
    for (int i = 0; i < numElements; i++)
    {
        arr[i] = rnd.Next(min, max);
    }

    return arr;
}

static void DisplayRuntime(Stopwatch stopwatch)
{
    TimeSpan ts = stopwatch.Elapsed;

    // Format and display the TimeSpan value.
    string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
        ts.Hours, ts.Minutes, ts.Seconds,
        ts.Milliseconds / 10);
    Console.WriteLine("Time Taken: " + elapsedTime);
    stopwatch.Reset();
}