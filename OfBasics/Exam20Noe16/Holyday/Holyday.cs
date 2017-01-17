using System;

namespace Holyday
{
    public class Holyday
    {
        public static void Main(string[] args)
        {

            //            влак   автобус кораб самолет
            //  Възрастни 24.99  32.50   42.99  70.00
            //    Ученици 14.99  28.50   39.99  50.00

            double oldPeople = double.Parse(Console.ReadLine());            double yongPeople = double.Parse(Console.ReadLine());            double nights = double.Parse(Console.ReadLine());            string transport = Console.ReadLine();            double price = 0;            double fullPrice = 0;            switch (transport)
            {
                case "train":
                    
                    if ((oldPeople+yongPeople)>=50)
                    {
                        price = ((oldPeople * 24.99 + yongPeople * 14.99)*2)/2;
                    }
                    else
                    {
                        price = (oldPeople * 24.99 + yongPeople * 14.99)*2;
                    }
                    fullPrice = (price + nights * 82.99) * 1.1;
                    break;
                case "bus":
                    price = (oldPeople * 32.5 + yongPeople * 28.5)*2;
                    fullPrice = (price + nights * 82.99) * 1.1;
                    break;
                case "boat":
                    price = (oldPeople * 42.99 + yongPeople * 39.99)*2;
                    fullPrice = (price + nights * 82.99) * 1.1;
                    break;
                case "airplane":
                    price = (oldPeople * 70 + yongPeople * 50)*2;
                    fullPrice = (price + nights * 82.99) * 1.1;
                    break;
            }            Console.WriteLine("{0:f2}",fullPrice);
        }
    }
}
