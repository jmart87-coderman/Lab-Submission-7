using UnityEngine;
using System;

public class TestDLLEng : MonoBehaviour
{
    
    
    // the one that tests all of this in Unity Script
    public static void TestSort(int[] a, int length)
    {
        Array.Sort(a, 0, length);
    }
}
