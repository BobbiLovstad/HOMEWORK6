using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Written By Bobbi Lovstad
// 4/3/25
namespace Homework6
{
    int strsr(string haystack, string needle)
    {
        // if statement for if the needle is empty

        if (needle == "")
        {
            return 0;
        }

        int haystacklen = haystack.Length();
        int needlelen = needle.Length();


        // Loop through the haystack

        for (int i = 0; i <= haystacklen - needlelen; i++)
        {
            bool found = true;

            // compare substring of haystack with needle

            for (int j = 0; j < needlelen; j++)
            {
                if (haystack[i + j] != needle[j])
                {
                    found = false;
                    break;
                }
            }

            return -1;   // this value will be returned if the needle is not found within haystack
        }

        int main()
        {
            string haystack = "hello";
            string needle = "11";

            int index = strsr(haystack, needle);

            cout << "the first occurance/" << needle << "\" in" << haystack << '\' "is:' << index << end1;

            return 0;
        }
    }
