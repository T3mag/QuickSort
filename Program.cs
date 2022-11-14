using Internal;
using System;

const int n = 5;
int[] array = new int[n];

ArrayGeneration(array, n);

ArrayPrinting(array, n);

QuickSort(array, 0, n - 1);

ArrayPrinting(array, n);

int[] ArrayGeneration(int[] array, int n)
{
    Random random = new Random();
    for (int i = 0; i < n; i++)
        array[i] = random.Next(0, 10);
    return array;
}

void ArrayPrinting(int[] array, int n)
{
    for (int i = 0; i < n; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}

void QuickSort(int[] array, int start, int end)
{
    int wall, first, last, swipe;
    if (start < end)
    {
        first = start;
        last = end;
        wall = first;

        while (first < last)
        {
            if (array[first] > array[last])
                first++;

            if (array[first] <= array[last])
            {
                swipe = array[wall];
                array[wall] = array[first];
                array[first] = swipe;
                wall++;
                first++;
            }
        }

        swipe = array[wall];
        array[wall] = array[last];
        array[last] = swipe;

        QuickSort(array, start, wall - 1);

        QuickSort(array, wall, end);
    }
    else
        return;
}

//double count = 25;
//int degree = 100;

//double FastPow(double count, int degree)
//{
//    if (degree == 0)
//        return 1;

//    if (degree % 2 != 0)
//        return count * FastPow(count, degree - 1);

//    return FastPow(count * count, degree / 2);
//}

//Console.WriteLine(degree >= 0 ? FastPow(count, degree): 1 / (FastPow(count, (-1) * degree)));

