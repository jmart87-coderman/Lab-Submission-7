using UnityEngine;
using System.Runtime.InteropServices;

public class TestDLLC : MonoBehaviour
{
    // The imported C++  function

    [DllImport("TestDLL", EntryPoint = "TestSort")]
    public static extern void TestSort(int[] a, int length);

    public int[] a ; // Default values for testing

    public void RunSort()
    {
        TestSort(a, a.Length);
    }
}
