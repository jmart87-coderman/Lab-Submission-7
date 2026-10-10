using System.Diagnostics;
using UnityEngine;

public class FunctionTimer : MonoBehaviour
{
    public TestDLLC testDLL;
    
    void Start()
    {
        MeasureFunctionExecutionTime();
    }

    void MeasureFunctionExecutionTime()
    {
        Stopwatch stopwatch = new Stopwatch();

        stopwatch.Start(); // Start timing
        testDLL.RunSort(); // Call the function you want to measure
        stopwatch.Stop();  // Stop timing

        // Get the elapsed time
        long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;
        UnityEngine.Debug.Log($"MyFunctionToTest took {elapsedMilliseconds} ms to execute.");
    }

}
