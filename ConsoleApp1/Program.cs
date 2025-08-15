


static void SimpleNoKissAndKiss()
{
    Console.WriteLine("NO KISS");
    int sampleNumber = 100;
    string numberString = ConvertToString(sampleNumber);
    Console.WriteLine(sampleNumber);


    string ConvertToString(int number)
    {
        return number.ToString(); 
    }


    Console.WriteLine("KISS");
    int sampleNumberWithKISS = 100;
    Console.WriteLine(sampleNumberWithKISS);


}


SimpleNoKissAndKiss();