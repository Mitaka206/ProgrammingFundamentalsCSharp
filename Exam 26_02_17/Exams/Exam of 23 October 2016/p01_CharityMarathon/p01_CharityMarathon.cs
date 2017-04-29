using System;
class p01_CharityMarathon
{
    static void Main(string[] args)
    {
        int daysOfMaraton = int.Parse(Console.ReadLine());
        long coutOfRunners = long.Parse(Console.ReadLine());
        int averageLaps = int.Parse(Console.ReadLine());
        long distanceOfRoad = long.Parse(Console.ReadLine());
        int capacityOfRoad = int.Parse(Console.ReadLine());
        double moneySum = double.Parse(Console.ReadLine());

        int roadsForAllDys = capacityOfRoad * daysOfMaraton;

        long countOfRoads = 0;
        if (coutOfRunners>roadsForAllDys)
        {
            countOfRoads = roadsForAllDys;      
        }
        else
        {
            countOfRoads = coutOfRunners;
        }

        long allKmS = countOfRoads * averageLaps * distanceOfRoad / 1000;

        double allMoney = allKmS * moneySum;

        Console.WriteLine("Money raised: {0:f2}", allMoney);
    }
}