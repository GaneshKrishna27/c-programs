using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("choice the sports \n1.cricket\n2.hockey");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("enter player name");
                string name = Console.ReadLine();
                Console.WriteLine("enter team name");
                string teamname = Console.ReadLine();
                Console.WriteLine("enter no matches played");
                int noofmatches = int.Parse(Console.ReadLine());
                Console.WriteLine("enter total  runs scored");
                int totalRunsScored = int.Parse(Console.ReadLine());
                Console.WriteLine("enter total  number of wickets taken");
                int noOfWicketsTaken = int.Parse(Console.ReadLine());
                CricketPlayer cp = new CricketPlayer(name, teamname, noofmatches, totalRunsScored, noOfWicketsTaken);
                cp.DisplayPlayerStatistics();
            }
            else if (choice == 2)
            {
                Console.WriteLine("enter player name");
                string name = Console.ReadLine();
                Console.WriteLine("enter team name");
                string teamname = Console.ReadLine();
                Console.WriteLine("enter no matches played");
                int noofmatches = int.Parse(Console.ReadLine());
                Console.WriteLine("enter total  runs scored");
                int position = int.Parse(Console.ReadLine());
                Console.WriteLine("enter total  number of wickets taken");
                int noOfgoals = int.Parse(Console.ReadLine());
                CricketPlayer cp = new CricketPlayer(name, teamname, noofmatches, position, noOfgoals);
                cp.DisplayPlayerStatistics();
            }
            else
                Console.WriteLine("invalid option");


            Console.ReadKey();
        }
    }
}
