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

// class Program P1
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

// class Program P2
// {
//     static void Main()
//     {
//         int[] number = { 4, 5, 6, 4, 4 ,7, 5, 6, 6, 6};

//         int num = number[0];
//         int count = 1;

//         for (int i = 0; i < number.Length; i++)
//         {
//             for (int j = 1; j < number.Length; j++)
//             {
//                 if (number[i] == number[j])
//                 {
//                     count++;
//                 }
//             }
//         }

//         Console.WriteLine($"Eng ko‘p uchragan sonlar: {num} ({count} marta)");
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