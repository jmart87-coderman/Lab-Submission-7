#include "TestDLLSort.h"
#include <algorithm>

extern "C" {
	TESTDLLSORT_API void TestSort(int a[], int length)
	{
		std::sort(a, a + length);
	}
}

 
