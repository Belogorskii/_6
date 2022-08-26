/*Ввести с клавиатуры предложение. Предложение 
представляет собой слова, разделенные пробелом. 
Знаки препинания не используются. Составить 
программу, определяющую является ли строка 
палиндромом без учёта пробелов и регистра (пример 
палиндрома – «А роза упала на лапу Азора»).*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string str2 = "";
            foreach (char c in str)
            {
                str2 = c + str2;
            }
            if (str == str2!)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
            Console.ReadKey();
        }
    }
}
