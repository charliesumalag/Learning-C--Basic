using System;

namespace Episode003
{
    //Program class
    class Program
    {
        //create method for this class
        static void Main(string[] args)
        {

            #region --Input--

            //Console.Write("a");
            //Console.Write("b");
            //Console.WriteLine("c");//write line means new line at the end of this.
            //Console.WriteLine("d");

            //var stringValue = Console.ReadLine();
            //Console.WriteLine($"Enter value: {stringValue}");

            //var readTest = Console.Read(); //read gets only the first char and then return a binary value of that
            //Console.WriteLine(readTest);

            /*
            Console.Write("Enter you age: ");
            var ageString = Console.ReadLine();
            var age = int.Parse(ageString);

            if(age < 18)
            {
                Console.WriteLine("Minor");

            }
            else
            {
                Console.WriteLine("Adult");
            }
            */

            #endregion

            #region --Expressions--

            Console.WriteLine("hello");

            #endregion
            #region --Operators--

            //assignment operator
            var a = 5;
            a = 10;

            //ARITHMETIC operator
            var num1 = 3;
            var num2 = 3;
            var addResult = num1 + num2; // + operator
            var subtractResult = num1 - num2; // - operator
            var multiplacationResult = num1 * num2; // * operator
            var divisionResult = num1 / num2; // / operator
            var moduleResult = num2 % num1; // % operator. divide it frist and then return the remainder. its 1 or 0.

            Console.WriteLine($"Addition : {addResult}");
            Console.WriteLine($"Subtraction : {subtractResult}");
            Console.WriteLine($"Multiplcation : {multiplacationResult}");
            Console.WriteLine($"Division : {divisionResult}");
            Console.WriteLine($"Module/Remainder : {moduleResult}");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Bolean operator");

            //BOLEAN operator
            var isActive = true;
            var isSuspended = false;

            var testAnd = isActive && isSuspended; //return false because there a false in there, the isSuspended
            var testOr = isActive || isSuspended; //return true becuase there a true value in there.

            Console.WriteLine($"testAnd : {testAnd}");
            Console.WriteLine($"testOr : {testOr}");

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Equality");

            var num3 = 100;
            var num4 = 200;
            var num5 = 200;

            var testEq = num3 == num4; //return false becauase its not equal
            var testNotEq = num3 != num4; //return tru because its askin if is it not equal.

            var testGreaterThan = num3 > num4; //return falase becauase 100 is not greater than 200.
            var testLessThan = num3 < num4; //retur true because 100 is less than 200.

            var testGreaterThanOrEqual = num4 >= num5; //return true because its equal.
            var testLessThanOrEqual = num4 <= num3; //return false because its not equal and 200 is not lessthan 100.



            #endregion

            #region --Null-Coalescing--
            Console.WriteLine("----------------------------------");
            Console.WriteLine("-------Null coalescing------------");


            var sampleString = "may laman"; //true because its has a value.
            string nullNaString = null; //false becuase its null.

            var sampleResult1 = sampleString ?? "Nilagyan ng laman"; //return string my laman because the sample string is true.
            var sampleResult2 = nullNaString ?? "nilagyan nang laman";//returns the second "nelagyan ng laman becuase the nullString is not true. in shor when the value is not true then return the next value.


            Console.WriteLine(sampleResult1);
            Console.WriteLine(sampleResult2);

            #endregion

            #region --Unary--
            Console.WriteLine("----------------------------------");
            Console.WriteLine("-------Unary----------------------");

            var trueValue = true;
            trueValue = !trueValue; //from true inverted then the truvalue now is false because it is inverted.

            var numberIncrementDecrement = 10;
            Console.WriteLine("Post Increment");
            numberIncrementDecrement++;
            Console.WriteLine(numberIncrementDecrement); //10 + 1 = 11.
            numberIncrementDecrement--;
            Console.WriteLine(numberIncrementDecrement); // from 11 then subtract 1 since -- so result is 11 - 1 = 10


            numberIncrementDecrement = 10;
            Console.WriteLine("Pre increment");
            ++numberIncrementDecrement;
            Console.WriteLine(numberIncrementDecrement); //result here is 11. since it apply first then evaluate 1 + 10 = 11
            --numberIncrementDecrement;
            Console.WriteLine(numberIncrementDecrement); // from 11 result from code above which is 11 then apply first here so -1 + 11 = 10


            #endregion

            #region --Ternary --
            Console.WriteLine("----------------------------------");
            Console.WriteLine("-------Ternary--------------------");

            var sampleStringTernary = "charlie";
            var result = sampleStringTernary == "charlie" ? "prgrammertv" : "??unkown";
            Console.WriteLine($"ternary result : {result}");//return prgrammertv since the condition is true. if condition is false then return the second value
            

            #endregion

        }
    }
}