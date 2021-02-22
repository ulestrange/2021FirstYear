using System;

namespace assignment1
{


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("changes made");

            printASCII("hello", "hellp");
            printASCII(
                       "module.exports = { getPeopleData : () => { return peopleData } }",
                       "module.exports = { getPeopleData : () => { return peopleData } }​​");
        }

        static void printASCII(string inputString, string inputString2)
        {
            Console.WriteLine(" Last characters");
            Console.WriteLine(" ====");

            int ascii = inputString[inputString.Length - 1];
            int ascii2 = inputString2[inputString2.Length - 1];
            Console.WriteLine(ascii + ":" + inputString[inputString.Length - 1] + ":"
                + ascii2 + inputString2[inputString2.Length - 1]);


            Console.WriteLine(" ====");

            for (int i = 0; i < Math.Min(inputString2.Length, inputString.Length); i++)
            {

                Console.WriteLine(inputString.Length + " : " + inputString2.Length);
                ascii = inputString[i];
                ascii2 = inputString2[i];
                Console.WriteLine(ascii + ":" + inputString[i] + ":"
                    + ascii2 + inputString2[i]);
            }



        }
    }
}
