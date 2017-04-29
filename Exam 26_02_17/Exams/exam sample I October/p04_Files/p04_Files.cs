using System;
using System.Collections.Generic;
using System.Linq;

namespace p04_Files
{
    class p04_Files
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            var output = new Dictionary<string, SortedDictionary<string, long>>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                var filesAndSize = input.Split(new char[] { ' ', ';', '\\' }, StringSplitOptions.RemoveEmptyEntries).Reverse().ToArray();

                long size = long.Parse(filesAndSize[0]);
                string fileName = filesAndSize[1];
                string root = filesAndSize.Last();

                if (!output.ContainsKey(root))
                {
                    output[root] = new SortedDictionary<string, long>();
                    output[root][fileName] = 0;
                }
                output[root][fileName] = size;
            }

            var commandLine = Console.ReadLine().Split();

            string type = commandLine[0];
            string place = commandLine[2];

            bool areResult = false;

            foreach (var item in output)
            {
                if (item.Key == place)
                {                                       // сортиране по стойност(Г-м) ако са равни по ключ
                    foreach (var fileSize in item.Value.OrderByDescending(x => x.Value).ThenBy(i => i.Key))
                    {
                        if (fileSize.Key.Contains(type))//NB test.exe contains "exe"
                        {
                            areResult = true;
                            Console.WriteLine($"{fileSize.Key} - {fileSize.Value} KB");
                        }
                    }
                }
            }

            if (!areResult)
            {
                Console.WriteLine("No");
            }
        }

    }
}
