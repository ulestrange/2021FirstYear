using System;
/* Name: Keith McNabola
 * Date: 12/02/2021
 * Desc: • Calculate the cost for a party.
• Produce a report on the parties. This will give a breakdown of the numbers of parties on
weekends (Friday-Sunday) and on weekdays (Monday-Thursday) and the average number of
children per party. (You can assume there is a maximum of 100 parties).
The program will be menu driven, the menu will repeat until the exit option is selected.
Menu: 
1. Calculate Cost 
2. Print Report
3. Exit 
Enter Choice >
The following basic rates apply:
Number Of Children Cost Per Child
1-6 €13
7-8 €11
9-10 €8
11 or over €7
Parties on days Monday-Thursday are considered to be “weekday” parties and get a €10 discount.
Parties on days Friday-Sunday are considered to be “weekend” parties and don’t get a discount.
The child can also buy choose to have a disco which costs an additional €15.
Marks will be awarded for programs which make good use of methods and are easy to maintain.
Please use at least one switch statement.
 * 
 */

namespace CA1
{
    class Program
    {
        static void Main(string[] args)
        //declare variables
        {
            string Expression, WeekDay, WeekEnd, Party;
            int Party = 0;
            {
                int[] numbers = { 1 >= 6(€13), 7 >= 8(€11), 9 >= 10(€8), 11< (€7 };
                Console.WriteLine(Party(numbers));
            }
            //method
            switch (WeekDay.WeekEnd())
            {
                case "monday":
                    Expression = -€10;
                    break;
                case "tuesday":
                    Expression = -€10;
                    break;
                case "wedensday":
                    Expression = -€10;
                    break;
                case "thursday":
                    Expression = -€10;
                    break;
                case "friday":
                    Expression = -€0;
                    break;
                case "saturday":
                    Expression = -€0;
                    break;
                case "sunday":
                    Expression = -€0;
                    break;
            } // end switch

            return Expression;

        } // end method

        // calculations
            if (Party % 100 == 0 && party % > 100)
            {
                Console.WriteLine("calculate cost");
            }
            else
            {
                Console.Write("print report");
            }
                Console > writeLine("Exit");

            
           
    }

}
