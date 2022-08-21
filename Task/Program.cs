// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа.
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []
 
using System;
using static System.Console;
Clear();
 
string[] array = {"hello", "2", "world", ":-)"};

WriteLine($"1 вар: В исходном массиве [{String.Join(", ", array)}] количество строк, соответствующих условию = {GetCount(array)} это {FindStringsInArray1(array)}");
WriteLine();
var result = FindStringsInArray2(array);
WriteLine($"2 вар: В исходном массиве [{String.Join(", ", array)}] количество строк, соответствующих условию = {result.Length} - [{String.Join(", ", result)}]");
WriteLine();

int GetCount(string[] ar)
{
   int count = 0;
   for(int i = 0; i < ar.Length; i++)
   {
       if(ar[i].Length <= 3)
       {
           count++;
       }
   }
   return count;
}
string FindStringsInArray1(string[] arrStr)
{
   string result = String.Empty;
   for(int i = 0; i < arrStr.Length; i++)
   {
       if(arrStr[i].Length <= 3)
       {
           result += $"{arrStr[i]} ";
       }
   }
   return result;
}
string[] FindStringsInArray2(string[] arrStr)
{
    string[] result = new string[0];
    for(int i = 0; i < arrStr.Length; i++)
    {
        if(arrStr[i].Length <= 3)
        {
            Array.Resize(ref result, result.Length + 1);
            result[result.Length - 1] = arrStr[i];
        }
    }
    return result;
}
