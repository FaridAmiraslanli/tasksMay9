using System;

#region eleven tasks
// --------------------------------task1---------------------------------------

// 1.İstifadəçidən ikirəqəmli ədəd daxil etməsini xahiş edin.
// 2.Bu rəqəmi üçrəqəmli olana qədər 7 - ədədi qədər artırın.
// 3.Son dəyəri konsola çıxarın 

// Console.WriteLine($"Enter integer number with two digits:");
// int number1 = int.Parse(Console.ReadLine() ?? "");
// while (number1 < 100)
// {
//     number1 += 7;
// }

// Console.WriteLine($"{number1}");

// --------------------------------task2---------------------------------------

//  Konsola N dəfə «I know how to use cycles» mesajı çıxaran proqram yazın. Proqram N ədədini istifadəçidən soruşur.

// Console.WriteLine($"Enter integer number:");
// int number2 = int.Parse(Console.ReadLine() ?? "");

// for (int i = 0; i < number2; i++)
// {
//     Console.WriteLine($"I know how to use cycles");
// }

// --------------------------------task3---------------------------------------

// Sonu 0 ilə bitən bütün üçrəqəmli ədədləri konsola çıxaran proqram yazın.

// for (int i = 100; i < 1000; i++)
// {
//     if (i % 10 == 0)
//     {
//         Console.WriteLine($"{i}");
//     }
// }
// --------------------------------task4---------------------------------------

// Bütün ikirəqəmli tək ədədlərin cəmini konsola çıxaran proqram yazın.
// int result4 = 0;
// for (int i = 11; i < 100; i += 2)
// {
//     result4 += i;
// }
// Console.WriteLine($"{result4}");

// --------------------------------task5---------------------------------------

// İstifadəçinin daxil etdiyi ədədin bölünəni olan bütün üçrəqəmli ədədlərin cəmini hesablayan proqram yazın.
// Proqram istifadəçidən ədəd daxil etməyi xahiş edir. Bundan sonra proqram konsolda bu rəqəmin bölünəni olan bütün üçrəqəmli ədədlərin cəmini çıxarır.

// Console.WriteLine($"Enter number:");
// int number5 = int.Parse(Console.ReadLine() ?? "");

// int result5 = 0;
// for (int i = 100; i < 1000; i++)
// {
//     if (i % number5 == 0)
//     {
//         result5 += i;
//     }
// }
// Console.WriteLine($"{result5}");

// --------------------------------task6---------------------------------------

// Sadə ədədləri çıxaran proqram yazın.
// İstifadəçidən n ədədini soruşan və n-dən 0-a kimi bütün sadə ədədləri azalan ardıcıllıqla çıxaran proqram yazın.

// Console.WriteLine($"Enter number:");
// int number6 = int.Parse(Console.ReadLine() ?? "");

// for (int i = number6; i >= 2; i--)
// {
//     if (i == 2)
//     {
//         Console.WriteLine($"{i}");

//     }
//     else
//     {
//         int k = i - 1;

// while (i % k != 0 && k >= 2)
//         {
//             k--;

//             if (k == 1)
//             {
//                 Console.WriteLine($"{i}");
//             }
//         }
//     }
// }



// --------------------------------task7---------------------------------------

// 10-a qədər bütün ədədlərin hasilin tapan proqram tərtib edin
// Sayğaclı dövrün köməyi ilə 10-a qədər bütün ədədlərin hasilin tapan proqram tərtib edin. 
// Alınan dəyəri konsola çıxarın.

// int result7 = 1;

// for (int i = 1; i <= 10; i++)
// {
//     result7 *= i;
// }

// Console.WriteLine($"{result7}");


// --------------------------------task8---------------------------------------

// İstifadəçidən mətn daxil etməsini tələb edən və mətn elementlərini əks qaydada düzən proqram tərtib edin.

// Console.WriteLine($"Enter text:");
// string textInput8 = Console.ReadLine() ?? "";
// char[] text8 = textInput8.ToCharArray();

// for (int i = text8.Length - 1; 0 <= i; i--)
// {
//     Console.Write($"{text8[i]}");
// }


// --------------------------------task9---------------------------------------

// Mətndə "." hərfinin ilk dəfə hansı indeksdə yerləşdiyini tapan proqram tərtib edin.

// Console.WriteLine($"Enter text:");
// string textInput9 = Console.ReadLine() ?? "";

// char[] text9 = textInput9.ToCharArray();
// bool containsDot = true;

// for (int i = 0; i < text9.Length; i++)
// {
//     if (text9[i] == '.')
//     {
//         Console.WriteLine($"First dot located at index:{i}");
//         containsDot = false;
//         break;
//     }
// }
// if (containsDot)
// {
//     Console.WriteLine($"The text does not contain dot.");
// }



// --------------------------------task10---------------------------------------

// Mətndə rəqəmlərin olub olmadığını yoxlayan proqram yazın.
// İstifadəçidən mətn daxil etməsini tələb edən və mətndə rəqəmlərin olub-olmaması barədə konsola mesaj çıxaran proqram tərtib edin.

// Console.WriteLine($"Enter text:");
// string textInput10 = Console.ReadLine() ?? "";

// char[] text10 = textInput10.ToCharArray();

// bool message10 = true;
// for (int i = 0; i < text10.Length; i++)
// {
//     if (char.IsDigit(text10[i]))
//     {
//         Console.WriteLine($"This text contains number.");
//         message10 = false;
//         break;
//     }
// }
// if (message10)
// {
//     Console.WriteLine($"This text doesn't cointain any number.");
// }


// --------------------------------task11---------------------------------------

// Fibonaçi ədədini çıxarmaq üçün proqram yazın.
// İstifadəçidən n ədədini daxil etməsini xahiş edin. Fibonaççi ardıcıllığının n-ci üzvünü konsola çıxarın.

// Console.WriteLine($"Enter a number:");
// int givenNumber = int.Parse(Console.ReadLine() ?? "");

// int[] array11 = new int[givenNumber];

// array11[0] = 0;
// if (givenNumber >= 2)
// {
//     array11[1] = 1;
// }
// if (givenNumber > 2)
// {
//     for (int i = 0; i < givenNumber - 2; i++)
//     {
//         array11[i + 2] = (array11[i] + array11[i + 1]);
//     }
// }

// Console.WriteLine($"{array11[givenNumber - 1]}");


#endregion



#region array

//task1

// Massiv elementinin dəyərini dəyişin.
// Üç addan ibarət massiv yaradın. Massivin ikinci elementinin dəyərini “Classified” ilə əvəz edin. Massivi konsola çıxarın.

// string[] names = { "Ali", "Ahmad", "Sharif" };
// names[1] = "Classified";
// foreach (string name in names)
// {
//     Console.WriteLine($"{name}");

// }

//task2

// Ardıcıllıqda olan ən kiçik ədədi tapan proqram yazın.
// İstifadəçidən beş ədəd elementi daxil etməyi tələb edən, onları massilə yazan və ən kiçik ədədi konsola çıxaran proqram yazın.

// int[] numbers = new int[5];

// Console.WriteLine($"Enter 5 integer number:");
// for (int i = 0; i < numbers.Length; i++)
// {
//     int number = int.Parse(Console.ReadLine() ?? "");
//     numbers[i] = number;
// }
// for (int k = 0; k < numbers.Length - 1; k++)
// {
//     if (numbers[k] < numbers[k + 1])
//     {
//         int keeper = numbers[k];
//         numbers[k] = numbers[k + 1];
//         numbers[k + 1] = keeper;
//     }
// }
// Console.WriteLine($"{numbers[numbers.Length - 1]}");



#endregion