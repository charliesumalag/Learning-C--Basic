using System;
using System.Linq.Expressions;

namespace Episode004
{
    class Program
    {
        static void Main(string[] args)
        {
            #region --IF-IFELSE-ELSE--

            const int MAX_MINOR_AGE = 17;
            const int MIN_SENIOR_AGE = 60;
            var isPWD = true;
            var age = 25;

            if(age <= MAX_MINOR_AGE || age >= MIN_SENIOR_AGE)
            {
                Console.WriteLine("Add Minor or Senior Discount");
            }
            else if (isPWD)
            {
                Console.WriteLine("Add PWD Discount");
            }
            else
            {
                Console.WriteLine("No Discount.");
            }

            #endregion

            #region --SWITCH--

            var currentAge = 15;
            switch (currentAge)
            {
                case 1:
                    Console.WriteLine("Baby");
                    break;

                case 10: //10 to 19 is like or operator
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                    Console.WriteLine("Teen");
                    break;
                default:
                    Console.WriteLine("Unknown");
                    break;

            }

            #endregion

            #region --WHILE--

            var count = 0;
            while(count  < 3){
                count++;
                Console.WriteLine(count);
            }
            #endregion

            #region --DO-WHILE--
            var countDoWhile = 0;

            do
            {
                Console.WriteLine("Print using do while");
                Console.WriteLine(countDoWhile);
                countDoWhile++;
            } while (countDoWhile < 3);

            #endregion

            #region --For-Loop--


            for(var index = 0; index <=5; index++)
            {
                Console.WriteLine($"the index is : {index}");//012345
            }


            #endregion

            #region --For-Each-Loop--

            var nameArray = new[] { "charlie", "chelo", "charles" };

            foreach(var name in nameArray)
            {
                Console.WriteLine($"This names is: {name}");
            }

            #endregion
        }

    }
    
}   