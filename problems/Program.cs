public class Program
{
    public static void Main()
    {
        //<--1-->
        // int[] num1 = { 10, 25, 30, 15, 40, 50 };
        // int a = 0;
        // int result = 0;

        // int max = num1.Max();
        
        // for(int i = 0; i < num1.Length; i++)
        // {
        //     if(a < num1[i])
        //     {
        //         result = a;
        //         a = num1[i];
        //     }
        // }

        // Console.WriteLine("Eng katta son: " + max);
        // Console.WriteLine("Ikkinchi eng katta son: " + result);


        //<--2-->
        // int[] numbers = { 4, 5, 6, 4, 7, 4, 5, 6 };

        // int c = numbers[0];
        // int maxCount = 0;

        // foreach (int num in numbers)
        // {
        //     int count = 0;

        //     foreach (int check in numbers)
        //     {
        //         if (num == check)
        //             count++;
        //     }

        //     if (count > maxCount)
        //     {
        //         maxCount = count;
        //         c = num;
        //     }
        // }

        // Console.WriteLine($"Eng kop uchragan element: {c} ({maxCount} martta)");


        //<--3-->
        // int[] numbers = { 1, 2, 3, 4, 5 };

        // int element = numbers[numbers.Length - 1];

        // for (int i = numbers.Length - 1; i > 0; i--)
        // {
        //     numbers[i] = numbers[i - 1];
        // }

        // numbers[0] = element;

        // for(int i = 0; i < 5; i++)
        // {
        //     Console.Write(numbers[i] + ", ");
        // }


        //<--4-->
        // List<int> numbers = new List<int> {10, 20, 30, 40, 50};
        // int N = 2;
        
        // N %= numbers.Count;
        // numbers.AddRange(numbers.GetRange(0, N));
        // numbers.RemoveRange(0, N);

        // Console.WriteLine(string.Join(", ", numbers));

        //<--5-->
        // int[] arr1 = {1, 3, 5};
        // int[] arr2 = {2, 4, 6};

        // for(int i = 0; i < 3; i++)
        // {
        //     Console.Write(arr1[i] + ", " + arr2[i] + ", ");
        // }


        //<--6-->
        List<int> numbers = new List<int> {1, 2, 3, 4, 5, 6, 7, 8};
        int N = 2;
        int M = 6;
        
        var reversedNumbers = numbers.GetRange(N, M - N);
        numbers.RemoveRange(N, M - N);
        reversedNumbers.Reverse();
        numbers.InsertRange(N, reversedNumbers);

        Console.WriteLine(string.Join(", ", numbers));

        //<--7-->
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



        //<--9-->

        // int[] arr = [10, 15, 20, 25, 30, 35];

        // for(int i = 0; i < 6; i++)
        // {
        //     if(arr[i] % 2 == 0)
        //     {
        //         Console.WriteLine($"Juft sonlar: " + arr[i]);
        //     }
        //     else if(arr[i] % 2 != 0)
        //     {
        //         Console.WriteLine($"Toq sonlar: " + arr[i]);
        //     }
        // }


        //<--10-->

        // string[] arr = {"apple", "banana", "cherry", "apricot", "blueberry"};
    }
}