//1

// int[] sonlar = {10, 25, 30, 15, 40, 50};

//         int max = sonlar[0];
//         int Max = sonlar[0];

//         for(int i = 1; i < sonlar.Length; i++)
//         {
//             if(sonlar[i] > max)
//             {
//                 Max = max;
//                 max = sonlar[i];
//             }
//             else if(sonlar[i] > Max && sonlar[i] != Max)
//             {
//                 Max = sonlar[i];
//             }
//         }

//     Console.WriteLine("Eng katta son: " + max);
//     Console.WriteLine("Ikkinchi eng katta son: " + Max);

//2

// int[] sonlar = {4, 5, 6, 4, 7, 4, 5, 6};

// int son = sonlar[0];
// int nechamarta = 1;

// for(int i = 0;i < sonlar.Length;i++)
// {
//     for(int m = 0;m < sonlar.Length;m++)
//     {
//         if(sonlar[i] == sonlar[m])
//         {
//             nechamarta++;
//         }
//     }
// }
// Console.WriteLine($"Eng ko'p uchragan son: {son} ({nechamarta})");


//3

//  int[] sonlar = {1, 2, 3, 4, 5};
//  int uzunlik = sonlar.Length;
//  int Oxirgi = sonlar[uzunlik - 1]; 

//  for(int i = uzunlik -1; i > 0; i--)  
//  {
//      sonlar[i] = sonlar[i - 1]; 
//  }

//  sonlar[0] = Oxirgi;

//  System.Console.WriteLine(string.Join(", ",sonlar));


//5

// int[] list1 = { 1, 3, 5 };
// int[] list2 = { 2, 4, 6 };
// int[] natija = new int[list1.Length + list2.Length];

// int index = 0;
// for (int i = 0; i < list1.Length; i++)
// {
//     natija[index++] = list1[i];
//     natija[index++] = list2[i];
// }

// Console.WriteLine(string.Join(", ", natija));

//8

// int[] sonlar = {1,2,3,5,6};
// int num1 = sonlar.Length + 1; //
// int num2 = 0;
// int num3 = 0;
        
// for(int i = num1; i >= 0; i--)//
// {
//     num2 += i; //num2 = 21
// }
// for(int i = 0; i < sonlar.Length; i++) //
// {
//     num3 += sonlar[i]; //
// }

// int num4 = num2 - num3;

// Console.WriteLine($"Yo'qolgan son: {num4}");

//9

// int[] numbers = {10, 15, 20, 25, 30, 35};

// List<int> juft = new List<int>(); 
// List<int> toq = new List<int>();

// foreach (int num in numbers) 
// {
//     if(num % 2 == 0)
//     {
//         juft.Add(num);
//     }
//     else
//     {
//         toq.Add(num);
//     }
// }

// Console.WriteLine("Juft sonlar: " + string.Join(", ", juft));
// Console.WriteLine("Toq sonlar: " + string.Join(", ", toq));

