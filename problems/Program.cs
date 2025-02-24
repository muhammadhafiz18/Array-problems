// 1. Ikkinchi eng katta sonni topish

// Kirish (Input):

// 10, 25, 30, 15, 40, 50

// Chiqish (Output):

// Eng katta son: 50  
//  eIkkinching katta son: 40


// ---

// 2. Eng ko‘p uchragan elementni topish

// Kirish (Input):

// 4, 5, 6, 4, 7, 4, 5, 6

// Chiqish (Output):

// Eng ko‘p uchragan element: 4 (3 marta)


// ---

// 3. Ro‘yxatni o‘ngga surish

// Kirish (Input):

// 1, 2, 3, 4, 5

// Chiqish (Output):

// 5, 1, 2, 3, 4


// ---

// 4. Ro‘yxatni N marta aylantirish

// Kirish (Input):

// Ro‘yxat: 10, 20, 30, 40, 50  
// N: 2

// Chiqish (Output):

// 30, 40, 50, 10, 20


// ---

// 5. Ikkita ro‘yxatni aralashtirib qo‘shish

// Kirish (Input):

// Ro‘yxat 1: 1, 3, 5  
// Ro‘yxat 2: 2, 4, 6

// Chiqish (Output):

// 1, 2, 3, 4, 5, 6


// ---

// 6. Ro‘yxatning bir qismini teskari qilish

// Kirish (Input):

// Ro‘yxat: 1, 2, 3, 4, 5, 6, 7, 8  
// Boshlang‘ich indeks: 2  
// Oxirgi indeks: 6

// Chiqish (Output):

// 1, 2, 6, 5, 4, 3, 7, 8


// ---

// 7. Raqamlarni raqamlar yig‘indisiga qarab saralash

// Kirish (Input):

// Ro‘yxat: 12, 25, 9, 38, 41

// Chiqish (Output):

// 9 (9)  
// 12 (1+2=3)  
// 41 (4+1=5)  
// 25 (2+5=7)  
// 38 (3+8=11)


// ---

// 8. Yo‘qolgan sonni topish

// Kirish (Input):

// 1, 2, 3, 5, 6

// Chiqish (Output):

// Yo‘qolgan son: 4


// ---

// 9. Ro‘yxatni toq va juft sonlarga ajratish

// Kirish (Input):

// 10, 15, 20, 25, 30, 35

// Chiqish (Output):

// Juft sonlar: 10, 20, 30  
// Toq sonlar: 15, 25, 35


// ---

// 10. So‘zlarni bosh harfiga qarab guruhlash

// Kirish (Input):

// "apple", "banana", "cherry", "apricot", "blueberry"

// Chiqish (Output):

// A: apple, apricot  
// B: banana, blueberry  
// C: cherry

using System.Security.Principal;

class Program 
{
    public static void Main()
    {
        //Problem1();
        //Problem2();
        //Problem3();
        //Problem5();

    }

    public static void Problem1()
    {
        int[] array = [10,50,40,15,25];
        int sum = 0; 

        for(int i = 0; i < array.Length; i++)
        {
            for(int a = 0; a < array.Length; a++)
            {
                if(array[i] < array[a])
                {
                    sum = array[i];
                    array[i] = array[a];
                    array[a] = sum;
                }
            }   
        }

        int kattaSon = 0;
        int kichikSon = 0;

        for(int i = 0; i < array.Length; i++)
        {
            if(array[i] > 0)
            {
                kattaSon = array[i];
            }
        }

        for(int i = 0; i < array.Length; i++)
        {
            if(array[i] > kichikSon && array[i] < kattaSon)
            {
                kichikSon = array[i];
            }
        }

        Console.WriteLine("Eng katta son:" + kattaSon);
        Console.WriteLine("Ikkinching katta son:" + kichikSon);
    }

    public static void Problem3()
    {
        int[] array = new int[5];
        
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine()!);
        }

        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] > array[j])
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }

        // Massivni aylantirish
        int[] arr = new int[array.Length];
        arr[0] = array[array.Length - 1];

        for (int i = 1; i < array.Length; i++)
        {
            arr[i] = array[i - 1];
        }

        // Natijani ekranga chiqarish
        Console.WriteLine(string.Join(" ", arr));
    }

    public static void Problem5()
    {
        int[] array1 = [1, 2, 3];
        int[] array2 = [4, 5, 6];
        
        for(int i = 0; i < 2; i++)
        {
            for(int a = 0; a < 3; a++)
            {
                if(i == 0)
                {
                    Console.Write(" ", array1[a]);
                }
                else
                {
                    Console.Write(" ", array2[a]);
                }
            }
        }
    }

    public static void Problem2()
    {
        int[] array = [4, 5, 6, 4, 7, 4, 5, 6];

        var son = array.GroupBy(x => x).OrderByDescending(g => g.Count()).Count();

        Console.WriteLine($"Eng ko'p uchragan son: {son}");
    }
}