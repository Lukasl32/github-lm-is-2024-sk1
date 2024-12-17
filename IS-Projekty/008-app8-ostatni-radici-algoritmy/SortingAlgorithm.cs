using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _008_app8_ostatni_radici_algoritmy;
internal class SortingAlgorithm
{
    static void BubbleSort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                if (array[j + 1] < array[j])
                {
                    int tmp = array[j + 1];
                    array[j + 1] = array[j];
                    array[j] = tmp;
                }
            }
        }
    }
    public static void SelectionSort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int maxIndex = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] > array[maxIndex]) maxIndex = j;
            }
            int tmp = array[i];
            array[i] = array[maxIndex];
            array[maxIndex] = tmp;
        }
    }
    public static void InsertionSort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int j = i + 1;
            int tmp = array[j];
            while (j > 0 && tmp > array[j - 1])
            {
                array[j] = array[j - 1];
                j--;
            }
            array[j] = tmp;
        }
    }
    public static void ShakerSort(int[] array)
    {
        for (int i = 0; i < array.Length / 2; i++)
        {
            bool swapped = false;
            for (int j = i; j < array.Length - i - 1; j++)
            {
                if (array[j] < array[j + 1])
                {
                    int tmp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = tmp;
                    swapped = true;
                }
            }
            for (int j = array.Length - 2 - i; j > i; j--)
            {
                if (array[j] > array[j - 1])
                {
                    int tmp = array[j];
                    array[j] = array[j - 1];
                    array[j - 1] = tmp;
                    swapped = true;
                }
            }
            if (!swapped) break;
        }
    }
    static void CombSort(int[] array)
    {
        int n = array.Length;
        int gap = n;
        bool swapped = true;

        // Initial gap value
        while (gap > 1)
        {
            gap = (int)(gap / 1.3); // Reduce gap

            // Compare and swap elements at the current gap
            for (int i = 0; i + gap < n; i++)
            {
                if (array[i] > array[i + gap])
                {
                    // Swap the elements
                    int temp = array[i];
                    array[i] = array[i + gap];
                    array[i + gap] = temp;
                    swapped = true;
                }
            }
        }

        // Final pass to ensure the array is sorted with a bubble sort approach
        if (swapped)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        // Swap the elements
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
    }
    public static int[] ShellSort(int[] array)
    {
        int gap = array.Length / 2;
        while (gap > 0) //dokud mame co porovnavat
        {
            for (int i = 0; i < array.Length - gap; i++) //upraveny insertion sort
            {
                int j = i + gap;
                int tmp = array[j];
                while (j >= gap && tmp > array[j - gap])
                {
                    array[j] = array[j - gap];
                    j -= gap;
                }
                array[j] = tmp;
            }
            if (gap == 2) //zmena velikosti mezery
            {
                gap = 1;
            }
            else
            {
                gap = (int)(gap / 2.2);
            }
        }
        return array;
    }

    static List<int> FindMaxPositions(int[] arr)
    {
        List<int> positions = new List<int>();
        if (arr.Length == 0)
        {
            return positions; // Return empty list if the array is empty
        }

        int max = arr[0];

        // Find the maximum value in the array
        foreach (int num in arr)
        {
            if (num > max)
            {
                max = num;
            }
        }

        // Find all positions of the maximum value
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == max)
            {
                positions.Add(i); // Add index to the positions list
            }
        }

        return positions;
    }
}

