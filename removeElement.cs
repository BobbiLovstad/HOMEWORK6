using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// written by bobbi lovstad
// 4/3/25

namespace Homework6
{
    int RemoveElement(int nums[], int size, int var)
    {
        int k = 0; // counter for elements that are equal to var


        // loop through whole array

        for( int i = 0; i < size; i++)
        {
            // if statment: values dont equal var, keep in array

            if (nums[i] != var)
            {
                nums[k] = nums[i]; // valid elements move to the front

                k++; // increment valid element count
            }
        }
    }

    return k; // return the number of values not equal to var
    
    
}

int main()
{
    int nums[] = (4.5, 5, 4, 2, 4); // random example array 

    int var = 4; // this value should be removed

    int size = sizeof(nums) / sizeof(nums[0]); // array size

    int k RemoveElement(nums, size, var); // call the function


    //outputof new array after elemeents were removed

    cout << "new array";
    for(int i = 0; i < k; i++)
    {
        cout << nums[i] << "";
    }

    cout << end1;

    // output for number of elements that still remain

    cout << "Number of elements not equal to" <<var << ':' k << end1;

    return 0;






}
