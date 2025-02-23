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

    int[] arr = [12, 25, 9, 38, 41];

    for(int i = 0; i <= arr.Length; i++)
    {
        if(arr[i] > 9)
        {
            Console.WriteLine($"{arr[i]}-({arr[i] / 10}+{arr[i] % 10}={arr[i] / 10 + arr[i] % 10})");
        }
        else 
        {
            Console.WriteLine(arr[i] + $"({arr[i]})");
        }
    }


}
}