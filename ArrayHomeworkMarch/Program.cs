using System;

public class Program
{
    public static void Main()
    {
        //3. Обмен местами двух элементов массива с заданными номерами
        int[] arr = new int[] { 2, 6, 7, 3, 2 };
        int first = 6;
        int second = 3;
        int index1 = Array.IndexOf(arr, first);
        int index2 = Array.IndexOf(arr, second);
        arr[index1] = second;
        arr[index2] = first;
        foreach (int i in arr)
        {
            Console.WriteLine(i);
        }
    }
}
