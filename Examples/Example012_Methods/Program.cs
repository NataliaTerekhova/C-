﻿// Вид 1

void Method1 ()
{
    System.Console.WriteLine("Автор...");
}
//Method1();

//Вид 2

void Method2 (string msg)
{
    System.Console.WriteLine(msg);
}
// Method2 (msg: "Текст сообщения");


//Вид 3

int Method3 ()
{
    return DateTime.Now.Year;
}
int year = Method3();
// System.Console.WriteLine(year);\


// Вид 4

// string Method4(int count, string text)
// {
// int i=0;
// string result =String.Empty;

// while (i<count)
// {
//     result=result+text;
//     i++;
// }
// return result;
// }
// string res = Method4 (10, "asdf");
// System.Console.WriteLine(res);

string Method4(int count, string text)
{
string result =String.Empty;

for (int i=0; i<count; i++)
{
    result=result+text; 
}
return result;
}
string res = Method4 (10, "asdf");
// System.Console.WriteLine(res);


//Вывести на экран таблицу умножения

for (int i=2; i<=10; i++)
{
    for (int j=2; j<=10; j++)
    {
  //      System.Console.WriteLine( $"{i}x{j}={i*j}");
    }
   // System.Console.WriteLine();
}

