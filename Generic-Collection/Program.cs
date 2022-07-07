using System;

namespace Generic_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Explicit,Implicit
            //Dollar dollar = new Dollar(100);

            ////Manat manat = dollar;
            //Manat manat = (Manat)dollar;

            //Console.WriteLine(manat.Azn);
            #endregion

            #region StringList
            //StringList list = new StringList();
            //list.Add("Huseyn");
            //list.Add("Jafarov");
            //list.GetAll();
            #endregion

            #region IntList
            //IntList list = new IntList();
            //list.Add(5);
            //list.Add(7);
            //list.GetAll();
            #endregion

            #region TList
            //TList<string> stringList = new TList<string>();
            //stringList.Add("Huseyn");
            //stringList.Add("Jafarov");
            //stringList.GetAll();

            //TList<int> intList = new TList<int>();
            //intList.Add(5);
            //intList.Add(7);
            //intList.GetAll();
            #endregion




        }
    }


   





    #region Explicit,Implicit
    //public class Dollar
    //{
    //    public double Usd { get; set; }
    //    public Dollar(double usd)
    //    {
    //        Usd = usd;
    //    }

    //}

    //public class Manat
    //{
    //    public double Azn { get; set; }
    //    public Manat(double azn)
    //    {
    //        Azn = azn;
    //    }

    //    //public static implicit operator Manat(Dollar dollar)
    //    //{
    //    //    return new Manat(dollar.Usd * 1.7);
    //    //}

    //    public static explicit operator Manat(Dollar dollar)
    //    {
    //        return new Manat(dollar.Usd * 1.7);
    //    }
    //}

    #endregion

}
