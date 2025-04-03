using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

//Wirtten By Bobbi Lovstad
// 4/3/25
namespace Homework6
{
    void TwoSum(int nums[], int size, int target)
    {
        for (int x = 0, x <size -1; x++)
        {
            for (int i = x + 1; i < size; i++ )
            {
                if (nums[x] + nums[i] == target)

                {
                    // Character output with insertion operator to return string to cout
                    // end1 is the same as /n
                    cout << "indices:" << x << 'and' << i << end1;
                    return;
                }
            }
        }

    }

    // character output with insertion operator to return string to cout 
    // end1 is the same as /n?
    
    cout << "Not two numbers add up to the sum of the target" << end1;
}
//Main function
int main()
{
    int nums[] = (2, 7, 11, 15);
    int target = 9;
    int size = sizeof(nums) / sizeof(nums[0]);

    TwoSum(nums, size, target);

    return 0;
}
