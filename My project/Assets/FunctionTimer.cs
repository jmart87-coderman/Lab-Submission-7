using System.Diagnostics;
using UnityEngine;

public class FunctionTimer : MonoBehaviour
{
    public TestDLLC testDLL;
    public sharpDll CSharpDLL; // references so that the script can measure the time of the functions

    public int[] a; // reference for this script to use.
    
    void Start()
    {
        MeasureFunctionExecutionTime();
    }

    void MeasureFunctionExecutionTime()
    {
        Stopwatch stopwatch = new Stopwatch(); // first sort the C++ DLL 

        stopwatch.Start(); // Start timing
        testDLL.RunSort(); // Call the function you want to measure
        stopwatch.Stop();  // Stop timing

        // Get the elapsed time
        long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;
        UnityEngine.Debug.Log($"Native took {elapsedMilliseconds} ms to execute.");

        Stopwatch enginewatch = new Stopwatch(); //Engine Script 
        
        enginewatch.Start();
        TestDLLEng.TestSort(a, a.Length); 
        enginewatch.Stop();

        long engineMilliseconds = enginewatch.ElapsedMilliseconds;
        UnityEngine.Debug.Log($"Unity Script took {engineMilliseconds} ms to execute.");

        Stopwatch sharpWatch = new Stopwatch();

        sharpWatch.Start();
        CSharpDLL.RunSort();
        sharpWatch.Stop();

        long sharpMilliseconds = sharpWatch.ElapsedMilliseconds;
        UnityEngine.Debug.Log($"Managed DLL took {engineMilliseconds} ms to execute.");
    }

}
