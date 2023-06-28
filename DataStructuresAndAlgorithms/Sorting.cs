using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    public class Sorting
    {
        // O(n^2) but the benefit is that the number of swaps is O(n)
        // It's not stable sorting algorithm
        public static void SelectionSort(int[] A)
        {
            for(var i = 0; i < A.Length - 1; i++) {
                var position = i;
                for(var j=i+1; j<A.Length; j++)
                {
                    if (A[j] < A[position])
                    {
                        position = j;
                    }
                }
                var temp = A[i];
                A[i] = A[position];
                A[position] = temp;
            }
        }

        // Stable sorting algorithm
        public static void InsertionSort(int[] A)
        {
            for (var i = 1; i < A.Length; i++)
            {
                // In the while loop below we are shifting all elements to the right
                // We need to cache an element under index i because otherwise we would loose it 
                var cvalue = A[i];
                var position = i;
                while(position > 0 && A[position-1] > cvalue)
                {
                    A[position] = A[position-1];
                    position -= 1;
                }
                A[position] = cvalue;
            }
        }

        public static void QuickSort(int[] A)
        {
            QuickSort(A, 0, A.Length - 1);
        }

        public static void MergeSort(int[] A)
        {
            var helper = new int[A.Length];
            MergeSort(A, helper, 0, A.Length - 1);

        }

        private static void MergeSort(int[] A, int[] helper, int low, int high)
        {
            if(low < high)
            {
                int middle = (low + high) / 2;
                MergeSort(A, helper, low, middle);
                MergeSort(A, helper, middle + 1, high);
                Merge(A, helper, low, middle, high);
            }
        }

        private static void Merge(int[] A, int[] helper, int low, int middle, int high)
        {
            // Copy array to helper 
            for(var i=low; i<=high; i++)
            {
                helper[i] = A[i];
            }

            int helperLeft = low;
            int helperRight = middle+1;
            int current = low;
            while(helperLeft <= middle && helperRight <= high)
            {
                if (helper[helperLeft] <= helper[helperRight])
                {
                    A[current] = helper[helperLeft];
                    helperLeft++;
                }
                else
                {
                    A[current] = helper[helperRight];
                    helperRight++;
                }

                int remaining = middle - helperLeft;
                for(var i = 0; i<remaining; i++)
                {
                    A[current + i] = helper[helperLeft + i];
                }
            }

        }

        private static void QuickSort(int[] A, int left, int right)
        {
            var index = Partition(A, left, right);
            if (left < index - 1)
                QuickSort(A, left, index - 1);
            if(index < right)
            {
                QuickSort(A, index, right);
            }
        }

        private static int Partition(int[] A, int left, int right)
        {
            int pivot = A[(left + right) / 2];
            while(left <= right)
            {
                while (A[left] < pivot) 
                    left++;
                while (A[right] > pivot) 
                    right--;

                if(left <= right)
                {
                    Swap(A, left, right);
                    left++;
                    right--;
                }
            }
            return left;
        }

        private static void Swap(int[] A, int left, int right)
        {
            var temp = A[left];
            A[left] = A[right];
            A[right] = temp;
        }

    }
}
