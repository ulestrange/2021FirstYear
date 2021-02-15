using System;
using System.Text;

namespace CA1
{
    class Program
    {
        

        static void Main(string[] args)
        {
            string menuChoice;
            int[] partyDay = new int[100];
            int[] partyCost = new int[100];
            int[] partyNumber = new int[100];

            int currentParty = 0; // the index of the current party


            menuChoice = GetMenuOption();


            while (menuChoice != "3")
            {
                switch (menuChoice)
                {
                    case "1":

                        Console.Write("Please enter the number of children > ");
                        partyNumber[currentParty] = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Please enter the day of the week as a number: " +
                            "Monday is 1 and Sunday is 7 > ");
                        partyDay[currentParty] = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Do you wish to have a disco ? Enter Y or N > ");
                        string discoChoice = Console.ReadLine();


                        partyCost[currentParty] = CalculatePartyCost(partyNumber[currentParty], partyDay[currentParty],
                            discoChoice);

                        Console.WriteLine("The party will cost {0}", partyCost[currentParty]);

                        currentParty++;
                        break;
                    case "2":
                        PrintStatistics(partyDay, partyNumber, currentParty);
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

                menuChoice = GetMenuOption();
            }

        }


        static string GetMenuOption()
        {
            Console.WriteLine("1. Calculate Cost");
            Console.WriteLine("2. Print Report");
            Console.WriteLine("3. Exit");
            Console.Write("Enter Choice > ");
            string choice = Console.ReadLine();
            return choice;
        }

        static int CalculatePartyCost(int numberOfChildren, int day,
                                 string discoChoice)
        {
            int costPerChild;
            int discount = 0;
            int discoCost = 0;
            int totalCost;

            switch (numberOfChildren)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    costPerChild = 13;
                    break;
                case 7:
                case 8:
                    costPerChild = 11;
                    break;
                case 9:
                case 10:
                    costPerChild = 8;
                    break;
                default:
                    costPerChild = 7;
                    break;
            }



            int basicCost = costPerChild * numberOfChildren;

            if (day < 5)
            {
                discount = 10;
            }

            if (discoChoice.ToUpper() == "Y")
            {
                discoCost = 15;
            }

            totalCost = costPerChild * numberOfChildren + discoCost - discount;

            return totalCost;

        }

        static void PrintStatistics(int[] partyDay, int[] partyNumber, int numberOfParties)
        {

            int countWeekDay = 0;
            int countWeekend = 0;

            int sumWeekDayChildren = 0;
            int sumWeekendChildren = 0;

            // loop through and count how many parties were on weekdays
            // and on the weekends and how many children attended on weekdays
            // and on weekends

            for (int i =0; i < numberOfParties; i++)
            {
                if (partyDay[i] < 5)
                {
                    countWeekDay++;
                    sumWeekDayChildren += partyNumber[i];
                }
                else
                {
                    countWeekend++;
                    sumWeekendChildren += partyNumber[i];
                }
            }

            string lineFormat = "{0,-20} {1,-20} {2,-20}";

            Console.WriteLine(lineFormat, "Party Type", "Number of Parties", "Average Party Size");

            if (countWeekDay != 0)
            {
                Console.WriteLine(lineFormat, "Weekday", countWeekDay, sumWeekDayChildren / Convert.ToDouble(countWeekDay));
            }
            else
            {
                Console.WriteLine(lineFormat, "Weekday", countWeekDay, "not applicable");
            }
            if (countWeekend != 0)
            {
                Console.WriteLine(lineFormat, "Weekend", countWeekend, sumWeekendChildren / Convert.ToDouble(countWeekend));
            }
            else
            {
                Console.WriteLine(lineFormat, "Weekend", countWeekend, "not applicable"); 
            }



        }
    }
}
