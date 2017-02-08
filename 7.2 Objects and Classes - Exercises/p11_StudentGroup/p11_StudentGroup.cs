using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace p11_StudentGroup
{
    class p11_StudentGroup
    {
        static void Main(string[] args)
        {
            List<Town> towns = GetTownsAndStudents();
            List<Group> groups = DistributeStudentsIntoGroups(towns);
            PrintGroups(groups, towns);
        }

        private static void PrintGroups(List<Group> groups, List<Town> towns)
        {
            Console.WriteLine("Created {0} groups in {1} towns:", groups.Count, towns.Count);
            foreach (var group in groups)
            {
                Console.WriteLine("{0} => {1}",
                                group.Town,
                                string.Join(", ", group.Students.Select(x => x.Email).ToList()));
            }
        }

        private static List<Group> DistributeStudentsIntoGroups(List<Town> towns)
        {
            List<Group> groups = new List<Group>();
            foreach (var town in towns.OrderBy(x => x.Name))
            {
                List<Student> students = town.Students
                                        .OrderBy(x => x.RegistrationDate)
                                        .ThenBy(x => x.Name).ThenBy(x => x.Email)
                                        .ToList();
                while (students.Any())
                {
                    Group group = new Group();
                    group.Town = town.Name;
                    group.Students = students.Take(town.SeatsCount).ToList();
                    groups.Add(group);
                    students = students.Skip(town.SeatsCount).ToList();
                }
            }
            return groups;
        }

        private static List<Town> GetTownsAndStudents()
        {
            List<Town> towns = new List<Town>();
            List<Student> students = new List<Student>();
            char[] townSeparators = "=>".ToCharArray();
            string[] data;
            string input = "";

            while ((input = Console.ReadLine()) != "End")
            {
                if (input.Contains("=>"))
                {
                    data = input.Split(townSeparators, StringSplitOptions.RemoveEmptyEntries);
                    string[] seats = data[1].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    Town town = new Town()
                    {
                        Name = data[0].Trim(),
                        SeatsCount = int.Parse(seats[0]),
                        Students = new List<Student>()
                    };
                    towns.Add(town);
                }
                else
                {
                    data = input.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                    Student student = new Student()
                    {
                        Name = data[0].Trim(),
                        Email = data[1].Trim(),
                        RegistrationDate = DateTime.ParseExact(data[2].Trim(), "d-MMM-yyyy", CultureInfo.InvariantCulture)
                    };
                    towns[towns.Count - 1].Students.Add(student);
                }
            }
            return towns;
        }
    }
}
