// 1. Ikkinchi eng katta sonni topish

// Kirish (Input):

// 10, 25, 30, 15, 40, 50

// Chiqish (Output):

// Eng katta son: 50  
// Ikkinchi eng katta son: 40


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


// using System;

// class Program Pr1 
// {
//     static void Main()
//     {
//         int[] num = { 10, 25, 30, 15, 40, 50 };


//         int max = num[0];
//         int max2 = num[0];

//         for (int i = 1; i < num.Length; i++)
//         {
//             if (num[i] > max)
//             {
//                 max2 = max;
//                 max = num[i];
//             }
//             else if (num[i] > max2 && num[i] != max)
//             {
//                 max2 = num[i];
//             }
//         }

//         Console.WriteLine($"Eng katta son: {max}");
//         Console.WriteLine($"Ikkinchi eng katta son: {max2}");
//     }
// }


// using System; Pr2

// class Program
// {
//     static void Main()
//     {
//         int[] sonlar = { 4, 5, 6, 4, 7, 4, 5, 6 };

//         int sum = sonlar[0];
//         int sum1 = 0;

//         for (int i = 0; i < sonlar.Length; i++)
//         {
//             int count = 0;
//             for (int j = 0; j < sonlar.Length; j++)
//             {
//                 if (sonlar[i] == sonlar[j])
//                 {
//                     count++;
//                 }
//             }

//             if (count > sum1)
//             {
//                 sum1 = count;
//             }
//         }

//         Console.WriteLine($"Eng ko‘p uchragan element: {sum} ({sum1} marta)");
//     }
// }


// class Program P3
// {
//     static void Main()
//     {
//         int[] num = {1, 2, 3, 4, 5};
//         int last = num[num.Length - 1]; 

//         for(int i = num.Length - 1; i > 0; i--) 
//         {
//             num[i] = num[i - 1]; 
//         }

//         num[0] = last;

//         Console.WriteLine(string.Join(", " , num));

//     }
// }

// class Program P4
// {
//     static void Main()
//     {
//         int[] sonlar = { 10, 20, 30, 40, 50 };
//         int n = int.Parse(Console.ReadLine()!);
//         int uzunlik = sonlar.Length;

//         n %= uzunlik;

//         for (int i = 0; i < n; i++)
//         {
//             int oxirgi = sonlar[uzunlik - 1];

//             for (int j = uzunlik - 1; j > 0; j--)
//                 sonlar[j] = sonlar[j - 1];

//             sonlar[0] = oxirgi;
//         }

//         Console.WriteLine(string.Join(", ", sonlar));
//     }
// }

// class Program p5
// {
//     static void Main()
//     {
//         int[] royxat1 = { 1, 3, 5 };
//         int[] royxat2 = { 2, 4, 6 };
    

//         List<int> sonlar = new List<int>();
//         for(int i = 0; i < royxat1.Length; i++)
//         {
//             sonlar.Add(royxat1[i]);
//         }
//         for(int i = 0; i < royxat1.Length; i++)
//         {
//             sonlar.Add(royxat2[i]);
//         }

//         sonlar.Sort();

//         for(int i = 0; i < sonlar.Count; i++)
//         {
//             Console.WriteLine(sonlar[i]);
//         }

//     }
// }

// class Program Pr 6
// {
//     static void Main()
//     {
//         List<int> num = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
//         int n = 2, m = 6;

//         List<int> qism = num.GetRange(n, m - n);
//         qism.Reverse();

//         num.RemoveRange(n, m - n );
//         num.InsertRange(n, qism);

//         Console.WriteLine(string.Join(", ", num));

//     }
// }

// using System; Pr 7
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         int[] son = { 12, 25, 9, 38, 41 };
//         List<int> num = new List<int>();

//         for (int i = 0; i < son.Length; i++)
//         {
//             int num2 = 0, temp = son[i];

//             while (temp > 0)
//             {
//                 num2 += temp % 10; 
//                 temp /= 10;       
//             }
//             num.Add(num2); 
//         }
//         for (int i = 0; i < num.Count; i++)
//         {
//             if(son[i] / 10 % 10 > 0)
//             {
//                 Console.WriteLine($"{son[i]} ({son[i] / 10 % 10 }+{son[i] % 10}={num[i]})");
//             }
//             else
//             {
//                 Console.WriteLine($"{son[i]} ({num[i]})");
//             }
//         }
//     }
// }


// using System.Security.Principal; pr8

// class Program
// {
//     static void Main()
//     {
//         int[] sonlar = {1,2,3,5,6};
//         int num1 = sonlar.Length + 1;
//         int num2 = 0;
//         int num3 = 0;
        

//         for(int i = num1; i >= 0; i--)
//         {
//             num2 += i;
//         }

//         for(int i = 0; i < sonlar.Length; i++)
//         {
//             num3 += sonlar[i];
//         }

//         int num4 = num2 - num3;

//         Console.WriteLine($"Yo'qolgan son: {num4}");
    

        
//     }
// }



// class Program   P9
// {
//     static void Main()
//     {
//         int[] son1 = { 10, 15, 20, 25, 30, 35 };
//         List<int> juft = new List<int>();
//         List<int> toq = new List<int>();

//         foreach (int son in son1)
//         {
//             if (son % 2 == 0)
//             {
//                 juft.Add(son);
//             }
//             else
//             {
//                 toq.Add(son);
//             }
//         }

//         Console.WriteLine("Juft sonlar: " + string.Join(", ", juft));
//         Console.WriteLine("Toq sonlar: " + string.Join(", ", toq));

//     }
// }



// class Program PR10
// {
//     static void Main()
//     {
//         string[] sozlar = { "apple", "banana", "cherry", "apricot", "blueberry" };
//         List<char> strings = new List<char>();
//         List<string> strings1 = new List<string>();
//         for(int i = 0; i < sozlar.Length; i++)
//         {
//             string fruits = sozlar[i];
//             strings.Add(fruits[0]);
//             strings1.Add(sozlar[i]);
//         }

//         strings.Sort();
//         strings1.Sort();

//         // for(int i = 0; i < strings.Count - 1; i++)
//         // {
//         //     if(strings[i] == strings[i + 1])
//         //     {
//         //         strings.Remove(strings[i + 1]);
//         //     }
//         // }

//         strings = strings.Distinct().ToList();

//         for(int i = 0; i < strings.Count; i++)
//         {
//             string result = $"{strings[i]}: ";
//             foreach (var fruit in sozlar)
//             {
//                 if(fruit[0] == strings[i])
//                 {
//                     result += $"{fruit} ";
//                 }
//             }
//             Console.WriteLine(result);
//         }

// }
// }