using System;
using System.Collections.Generic;
using System.Linq;

namespace p04_filesNew
{
    class p04_filesNew
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var filesAndSize = new List<string>();
            var output = new Dictionary<SortedDictionary<string, string>, SortedDictionary<string, string>>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                filesAndSize = input.Split(new char[] { ' ', ';', '\\', '.' },
                    StringSplitOptions.RemoveEmptyEntries)
                    .Reverse()
                    .ToList();
                var folderName = filesAndSize.Last();
                var inType = filesAndSize[1];
                var fileName = filesAndSize[2];
                var sizeFile = filesAndSize[0];
                var name = new List<string> { filesAndSize[1], filesAndSize[2] }.ToString();
                var dic = new SortedDictionary<string, string>();
                var val = new SortedDictionary<string, string>();

                if (!dic.ContainsKey(folderName))
                {
                    dic[folderName] = string.Empty;
                }
                dic[folderName] = inType;

                if (!val.ContainsKey(name))
                {
                    val[name] = string.Empty;
                }
                val[name] = sizeFile;
                output[dic] = val;
            }

            var commandLine = Console.ReadLine().Split();
            string type = commandLine[0];
            string folder = commandLine[2];

            foreach (var item in output)
            {
                foreach (var item1 in item.Key)
                {
                    if (type == item1.Value && folder == item1.Key)
                    {
                        foreach (var item2 in item.Value)
                        {
                            Console.WriteLine($"{item2.Key} - {item2.Value}");
                        }
                    }
                }
            }
        }
    }
}
