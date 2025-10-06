using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingAlgorithms
{
    public class Algorithms
    {
        // Searching Algorithms

        // linear search (naive search)
        public static int LinearSearch<T>(T[] arr, T searchTerm) where T : IComparable<T>
        {
            // Search from the front of the array to the end, return the index if found.
            for (int i = 0; i < arr.Length; i++)
            {
                // is this the search term
                if (arr[i].Equals(searchTerm))
                {
                    return i;
                }
            }

            // if not found
            return -1;
        }

        // data must be sorted prior to searching
        // Function: Takes a sorted array, splits it in two and searches both halves recursively for a matching search term
        public static int BinarySearch<T>(T[] arr, int low, int high, T searchTerm) where T : IComparable<T>
        {
            // index of our position? mid? low and high?
            int mid = low + ((high - low) / 2);

            // base case (did we find it? Equal to)
            if (arr[mid].Equals(searchTerm))
            {
                // we hit base case, return mid
                return mid;
            }

            // recursive case (we didnt find it, search recursively)
            // is it in the left
            if (arr[mid].CompareTo(searchTerm) > 0)
            {
                BinarySearch(arr, low, mid - 1, searchTerm);
            }

            // is it in the right
            if (arr[mid].CompareTo(searchTerm) < 0)
            {
                BinarySearch(arr, mid + 1, high, searchTerm);
            }

            // worst case scenario
            return -1;
        }

        // Sorting Algorithms
    }
}
