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
            var words = new LinkedList<string>();

            // Запустим таймер
            var watchTwo = Stopwatch.StartNew();
            

            while ((line = file.ReadLine()) != null)
            {
                words.AddLast(line); // вставка в конец примерно такая же как и в простом листе
               // words.AddFirst(line); // тут время значительно больше
            }

            watchTwo.Stop();



            // Выведем результат
            //foreach (var word in words) //  просто проверял что все что нужно переносится
            //     Console.WriteLine(word);
            Console.WriteLine($"Вставка в  словарь: {watchTwo.Elapsed.TotalMilliseconds}  мс");
            file.Close();
        }
    }

}