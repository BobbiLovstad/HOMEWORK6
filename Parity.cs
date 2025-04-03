using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// written by Bobbi Lovstad
// 4/3/25

namespace Homework6
{
    public int[] SortArrayByParity(int[] nums)
    {
        int[] arr = new int[nums.Length];

        int evens = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 2 == 0) { evens++;)
        }
    int k = 0;
    for (int i = 0, i<nums.Length; i ++)
    {
        if(nums[i] % 2 ==0}{ arr[k++ = nums[int]; }
        else (arr[evens++] = nums[i];} 
        }
        return arr;

}
