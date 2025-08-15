


#region --About Variables --
// Local Variables/Explicit

int sampleNumber = 3;



// Implicit
var sampleNumberImplicit = 3;
dynamic sampleNumberDynamic = 5;


//Local Variables


#endregion

#region --Parse and Convert --

string textOne = "1";
var intOne = int.Parse(textOne);
var result = intOne * 5;

Console.WriteLine($"text one result: {result}");



#endregion
public class Episode1Class
{

    #region --About Variables--
    int sampleFieldInt = 5; // global variable of the class. can be accessible for all in this class
    static int sampleStaticInt = 6;
    public void sampleMethod1()
    {
        //this two is local variable. it accessible only here in this method/block of code.
        int sampleLocalInt = 1;
        var sampleLocalDouble = 1.5;
        sampleFieldInt = 300; // global varibale accessed.
        sampleStaticInt = 22;
    }

    public void sampleMethod2()
    {
        //this two is local variable. it accessible only here in this method/block of code.
        int sample2Int = 1;
    }

    #endregion
}