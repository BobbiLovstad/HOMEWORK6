using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// written by Bobbi Lovstad
// 4/3/25
namespace Homework6
{
    void merge( int nums[], int m, int nums2[], int n)
    {
        // pointers for nums 1, nums 2, and merged array position

        int i = m - 1;
        int j = n - 1;
        int k = m + n - 1;

        // merge in reverse order: Avoid overwriting elements to nums1

        while(i >= 0 && j>= 0)
        {
            if nums[i] > nums2[j])
            {
                nums[k] = nums[i]; // place larger element at the end 

                i ==;
            }
            else
            {
                nums[k] = nums2[j]; // place the larger element at the end 

                j--;
            }

            k--; //move to the previous position
            
        }

        // for remianing elements in nums2, copy 

        while (j > = 0)
        {
            nums[k] = nums2[j];

            j--;
            k--;
        }
    }
    
    // example usage 

    int main ()
    {
        int nums[6] = { 1, 2, 3, 0, 0, 0 }; // extra space for nums2
        int nums2[3] = { 2, 5, 6 };

        int m = 3, n = 3;

        merge(nums.m, nums2, n);

        // Priting mergeed array

        for (int i = 0; i < m + n; i++)
        {
            cout << nums[i] << '';

        }
        return 0;
}
