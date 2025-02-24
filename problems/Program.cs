using System.Globalization;
using System.Runtime.InteropServices;

class Program
{
    public static void Main()
    {
        //1
        // class Program
    // {
    //     public static void Main()
    //     {

    //         int[] arr = [10 , 25, 30, 15, 40, 50];

    //         int temp = 0;

    //         int next = 0;

    //         for(int i = 0; i < arr.Length; i++)
    //         {
    //             if(temp < arr[i])
    //             {
    //                 next = temp;

    //                 temp = arr[i];
    //             }
    //         }

    //         Console.WriteLine(next);
    //     }
    // }

    

    //2;

    // int[] arr = [4, 5, 6, 4, 7, 4, 5, 6];
    // int c = arr[0];
    // int max = 0;
    
    // foreach (int num in arr)
    // {
    //     int temp = 0;

    //     foreach(int tem in arr)
    //     {
    //         if(tem == num)
    //         {
    //             temp++;
    //         }
    //     }

    //     if(temp > max)
    //     {
    //         max = temp;

    //         c = num;

    //     }
    // }
    // Console.WriteLine(c);

    //3
    // int[] arr = [1, 2, 3, 4, 5];

    // int temp = 5;

    // for(int i = 4; i > 0; )
    // {
    //     arr[i] = arr[i-1];

    //     i--;
    // }
    
    // arr[0] = temp;

    // for(int i = 0; i < 5; i++)
    // {
    //     Console.WriteLine(arr[i]);
    // }

    //5

    // int[] arr1 = [1, 3, 5];

    // int[] arr2 = [2, 4, 6];

    // for(int i = 0; i <= 3; i++)
    // {
    //     Console.Write(arr1[i] + ", " + arr2[i] + ", ");
    // }
    // Console.WriteLine();

    // }

    //7

    // List<int> arr = [12, 25, 9, 38, 41];

    // arr.Sort();

    // for(int i = 0; i <= arr.Count; i++)
    // {
    //     if(arr[i] > 9)
    //     {
    //         Console.WriteLine($"{arr[i]}-({arr[i] / 10}+{arr[i] % 10}={arr[i] / 10 + arr[i] % 10})");
    //     }
    //     else 
    //     {
    //         Console.WriteLine(arr[i] + $"({arr[i]})");
    //     }
    // }

//     //6

    List<int> numbers = new List<int> {1, 2, 3, 4, 5, 6, 7, 8};
        int N = 2;
        int M = 6;
        
        var reversedNumbers = numbers.GetRange(N, M - N);
        numbers.RemoveRange(N, M - N);
        reversedNumbers.Reverse();
        numbers.InsertRange(N, reversedNumbers);

        Console.WriteLine(string.Join(", ", numbers));

    }
}     