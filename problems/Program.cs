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


//Javoblar:
//1.
        // int[] sonlar = {10, 25, 30, 15, 40, 50};
        // int max = sonlar[0];
        // int Max = sonlar[0];

        // for(int i = 1; i < sonlar.Length; i++)
        // {
        //     if(sonlar[i] > max)
        //     {
        //         Max = max;
        //         max = sonlar[i];
        //     }
        //     else if(sonlar[i] > Max && sonlar[i] != Max)
        //     {
        //         Max = sonlar[i];
        //     }
        // }

        // System.Console.WriteLine("Eng katta son: " + max);
        // System.Console.WriteLine("Ikkinchi eng katta son: " + Max);

//------------------------------------------------------------------------

//2.
        // int[] sonlar = { 4, 5, 6, 4, 7, 4, 5, 6 };

        // int sum = sonlar[0];
        // int sum1 = 0;

        // for (int i = 0; i < sonlar.Length; i++)
        // {
        //     int count = 0;
        //     for (int j = 0; j < sonlar.Length; j++)
        //     {
        //         if (sonlar[i] == sonlar[j])
        //         {
        //             count++;
        //         }
        //     }

        //     if (count > sum1)
        //     {
        //         sum1 = count;
        //     }
        // }

        // Console.WriteLine($"Eng ko'p uchragan element: {sum} ({sum1} marta)");

//-------------------------------------------------------------------------

//3.

// int[] sonlar = {1, 2, 3, 4, 5};
// int uzunlik = sonlar.Length;
// int Oxirgi = sonlar[uzunlik - 1]; // -->  oxirgi elementni olish uchun

// for(int i = uzunlik -1; i > 0; i--)  // --> massivni orqadan oldinga surish uchun
// {
//     sonlar[i] = sonlar[i - 1]; // -->  har bir elementni oldingi joyiga ko‘chirish uchun
// }

// sonlar[0] = Oxirgi;

// System.Console.WriteLine(string.Join(", ", sonlar));


//-------------------------------------------------------------------------

//4.
        // int[] sonlar = { 10, 20, 30, 40, 50 };
        // int n = int.Parse(Console.ReadLine());
        // int uzunlik = sonlar.Length;

        // n %= uzunlik;

        // for (int i = 0; i < n; i++)
        // {
        //     int oxirgi = sonlar[uzunlik - 1];

        //     for (int j = uzunlik - 1; j > 0; j--)
        //         sonlar[j] = sonlar[j - 1];

        //     sonlar[0] = oxirgi;
        // }

        // Console.WriteLine(string.Join(", ", sonlar));

//-------------------------------------------------------------------------

//5.

        // int[] royxat1 = { 1, 3, 5 };
        // int[] royxat2 = { 2, 4, 6 };
        // int[] natija = new int[royxat1.Length + royxat2.Length];

        // int indeks = 0;
        // for (int i = 0; i < royxat1.Length; i++)
        // {
        //     natija[indeks++] = royxat1[i];
        //     natija[indeks++] = royxat2[i];
        // }

        // Console.WriteLine(string.Join(", ", natija));

//-------------------------------------------------------------------------

//6.

        // List<int> sonlar = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
        // int n = 2, m = 6;

        // List<int> qism = sonlar.GetRange(n, m - n);
        // qism.Reverse();

        // sonlar.RemoveRange(n, m - n );
        // sonlar.InsertRange(n, qism);

        // Console.WriteLine(string.Join(", ", sonlar));

//-------------------------------------------------------------------------

//7.

        // int[] son = { 12, 25, 9, 38, 41 };
        // List<int> num = new List<int>();

        
        // for (int i = 0; i < son.Length; i++)
        // {
        //     int num2 = 0, temp = son[i];

        //     while (temp > 0)
        //     {
        //         num2 += temp % 10; 
        //         temp /= 10;       
        //     }
        //     num.Add(num2); 
        // }
        // for (int i = 0; i < num.Count; i++)
        // {
        //     if(son[i] / 10 % 10 > 0)
        //     {
        //         Console.WriteLine($"{son[i]} ({son[i] / 10 % 10 }+{son[i] % 10}={num[i]})");
        //     }
        //     else
        //     {
        //         Console.WriteLine($"{son[i]} ({num[i]})");
        //     }
        // }


//-------------------------------------------------------------------------

//8.
        // int[] sonlar = {1,2,3,5,6};
        // int num1 = sonlar.Length + 1;
        // int num2 = 0;
        // int num3 = 0;
        

        // for(int i = num1; i >= 0; i--)
        // {
        //     num2 += i;
        // }

        // for(int i = 0; i < sonlar.Length; i++)
        // {
        //     num3 += sonlar[i];
        // }

        // int num4 = num2 - num3;

        // Console.WriteLine($"Yo'qolgan son: {num4}");

//-------------------------------------------------------------------------
//9.

        // int[] sonlar = { 10, 15, 20, 25, 30, 35 };
        // List<int> juft = new List<int>();
        // List<int> toq = new List<int>();

        // foreach (int son in sonlar)
        // {
        //     if (son % 2 == 0)
        //         juft.Add(son);
        //     else
        //         toq.Add(son);
        // }

        // Console.WriteLine("Juft sonlar: " + string.Join(", ", juft));
        // Console.WriteLine("Toq sonlar: " + string.Join(", ", toq));

//-------------------------------------------------------------------------

//10.
        // string[] sozlar = { "apple", "banana", "cherry", "apricot", "blueberry" };

        // var guruhlar = sozlar.GroupBy(s => s[0]) // -->  so‘zlarni birinchi harfiga qarab guruhlaydi
        //                      .OrderBy(g => g.Key); // --> harflarni tartiblaydi

        // foreach (var guruh in guruhlar)
        //     Console.WriteLine($"{guruh.Key}: {string.Join(", ", guruh)}");



