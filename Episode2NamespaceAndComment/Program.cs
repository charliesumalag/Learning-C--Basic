using System.Collections;
using Episode2NamespaceAndComment.Fruits;
using Episode2NamespaceAndComment.Heroes.MobileLegend.Assasins;
using Episode2NamespaceAndComment.Heroes.MobileLegend.Fighters;
using Episode2NamespaceAndComment.Heroes.MobileLegend.Mages;
using PinoyHeroNaBisaya = Episode2NamespaceAndComment.Heroes.Pinoy.Bisaya;

namespace Episode2NamespaceAndComment
{
    //classname is Program
    class Program
    {
        //create function or method in this class
        static void Main(string[] args)
        {
            Console.WriteLine("Namespace Test");
            var queue = new Queue();

            #region
            //organize becuase its imported above
            var banana = new Banana();

            //long code, this is if does not import or used above.
            var apple = new Episode2NamespaceAndComment.Fruits.Apple();

            #endregion

            #region --Mobile Legends--

            var alpha = new Alpha();
            var ling = new Ling();
            var aurora = new Aurora();

            //create new 
            var valir = new Valir();

            //there is a conflic there. we have two lapulaput here. the mobile legend hero and the heroes lapulaput in cebu
            //long version
            var lapulapu = new Episode2NamespaceAndComment.Heroes.Pinoy.Bisaya.LapuLapu();

            //short version
            var lapulaputShort = new PinoyHeroNaBisaya.LapuLapu();

            #endregion

            #region --comment--
            //Commenting -  comment are use to documents code. this is used for use devlopers identify what is the purpose of the code.
            //this is the single line comment
            /*
                this is the multiline comment
             */

            #endregion

        }
    }
}