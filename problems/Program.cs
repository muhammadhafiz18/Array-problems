// 1.

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


        //<--5-->
        int[] arr1 = {1, 3, 5};
        int[] arr2 = {2, 4, 6};

        for(int i = 0; i < 3; i++)
        {
            Console.Write(arr1[i] + ", " + arr2[i] + ", ");
        }
    }
}