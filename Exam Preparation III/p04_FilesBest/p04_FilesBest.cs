using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace p04_FilesBest
{
    class p04_FilesBest
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var regex = new Regex(@"((.+?)\\(.+\\)?(.+)\.(.+));([0-9]+)");

            var files = new Dictionary<string, FileInfo>();

            for (var i = 0; i < n; i++)
            {
                var file = regex.Match(Console.ReadLine());

                if (file.Success)
                {
                    var fileInfo = new FileInfo();
                    fileInfo.Name = file.Groups[4].Value;
                    fileInfo.Root = file.Groups[2].Value;
                    fileInfo.Extension = file.Groups[5].Value;
                    fileInfo.Size = long.Parse(file.Groups[6].Value);

                    files[file.Groups[1].Value] = fileInfo;
                }
            }

            var searchFor = Console.ReadLine().Split();

            var foundFiles = files
                .OrderByDescending(x => x.Value.Size)
                .ThenBy(x => x.Value.Name)
                .Where(x => x.Value.Root == searchFor[2] && x.Value.Extension == searchFor[0]);

            foreach (var kvp in foundFiles)
            {
                Console.WriteLine($"{kvp.Value.Name}.{kvp.Value.Extension} - {kvp.Value.Size} KB");
            }

            if (!foundFiles.Any())
            {
                Console.WriteLine("No");
            }
        }
    }

    class FileInfo
    {
        public string Root { get; set; }
        public string Name { get; set; }
        public string Extension { get; set; }
        public long Size { get; set; }
    }
}
