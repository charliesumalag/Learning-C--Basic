
using System;
using System.Collections.Generic;

namespace Episode005
{
    static class Program
    {
        //create method
        static void Main(string[] args)
        {

            #region --Array--
            Console.WriteLine("-------------------");
            /* 
            int[] numbers = new int[10];
            int[] numersWithInit = new int[] { 1, 2, 3 }; //one dimensional
            int[][] multiNumbers = new int[3][] {
                new int[3] { 1, 2, 3 }, 
                new int[3] { 4, 5, 6 }, 
                new int[3] { 7, 8, 9 } 
            }; //multidimentional
            int[,] otherNumbers = new int[2, 2];
            */


            /*
            var names = new[] { "charlie", "chelo", "charles" };
            Console.WriteLine("Before update.");
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }
            names[1] = "Riza";
            Console.WriteLine("After update.");

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine($"Name at index 2: {names[2]}");

            */


            /*

         var rowsAndCells = new int[3][]
         {
             new[] {1,2,3},
             new[] {4,5,6 },
             new[] {7,8,9 }
         };


         for(var row = 0; row < rowsAndCells.Length; row++)
         {
             Console.WriteLine($"row: {row}");
             foreach(var cell in rowsAndCells[row])
             {
                 Console.WriteLine($"value: {cell}");
             }
         }
         */
            //Here is the other version

            /*
            var index = 0;

            foreach(var row in rowsAndCells)
            {
                Console.WriteLine($"row: {index}");
                foreach (var cell in rowsAndCells[index])
                {
                    Console.WriteLine($"value: {cell}");
                }
                index++;
            }

            */

            #endregion

            #region --Enumerable, Collection, List--

            /*

            var countries = new[] { "Philippines", "Korea", "Japan" };
            IEnumerable<string> enumCountries = countries;
            //Console.WriteLine(enumCountries);

            //enumCountries[0] = "PHL"; this will not acceptable since enumerable is read only

            foreach(var country in enumCountries)
            {
                Console.WriteLine(country);
            }


            ICollection<string> colCountries = new List<string>(countries); //use becuase of functions built in. like add and remove. 
            colCountries.Add("Australia");
            colCountries.Remove("Korea");
            //colCountries[0] = "Updated"; this will be error because ICollection doesnt have authority to access array's indices.
            Console.WriteLine("-------------------");
            Console.WriteLine("Collection");
            Console.WriteLine("-------------------");
            foreach (var country in colCountries)
            {
                Console.WriteLine(country);
            }

            */

            //very powerful. inherit all the features above and theres addition stuff like addrange etc

            var listCountries = new List<string>();
            listCountries.Add("Philippines");
            listCountries.Add("USA");
            listCountries.AddRange(new[] { "Canada", "Australia" });
            listCountries.Remove("Philippines");
            listCountries[0] = "America";


            for(var i = 0; i < listCountries.Count; i++)
            {
                Console.WriteLine($"index: {i} : {listCountries[i]}");
            }

            #endregion


        }
    }
}