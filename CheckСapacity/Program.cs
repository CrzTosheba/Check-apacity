using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace PhoneBook
{
    class Program
    {
              
        static void Main(string[] args)
        {
            System.IO.StreamReader file = new StreamReader(@"C:\CFiles\Text2.txt");
            String line;
            var words = new List<string>();
            // Запустим таймер
            var watchTwo = Stopwatch.StartNew();

            while ((line = file.ReadLine()) != null)
            {
                words.Add(line);
                
            }

            watchTwo.Stop();




            // Выведем результат

            //foreach (var word in words)
            //     Console.WriteLine(word);
            Console.WriteLine($"Вставка в  словарь: {watchTwo.Elapsed.TotalMilliseconds}  мс");
            file.Close();
        }
    }
   
}