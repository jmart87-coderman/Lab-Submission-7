using UnityEngine;
using System.Runtime.InteropServices;


public class sharpDll : MonoBehaviour
{
    
    // The imported C#  function

    public int[] a ; // Default values for testing

    public void RunSort() //runs the code from the C# script
    {
        TestDLLSort.TestSort(a, a.Length);
    }


}
