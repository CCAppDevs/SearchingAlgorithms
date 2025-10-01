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


        // TODO: Refactor: Make linear search work with other data types

        // linear search (naive search)
        public static int LinearSearch(int[] arr, int searchTerm)
        {
            // Search from the front of the array to the end, return the index if found.
            for (int i = 0; i < arr.Length; i++)
            {
                // is this the search term
                if (arr[i] == searchTerm)
                {
                    return i;
                }
            }

            // if not found
            return -1;
        }

        // Sorting Algorithms
    }
}
