using System;

namespace C42_G02_OOP03
{
    internal class Program
    {
        #region
        public static int Sum(int x, int y)
        {
            return x + y;
        }

        public static double Sum2Double(double x, double y)
        { 
            return x + y; 
        }

        public static double Sum(int x, double y)
        {
            return x + y;
        }

        public static double Sum(double z, int m)
        {
            return z + m;
        }

        public static int Sum3Numbers(int x, int y, int z)
        {
            return x + y + z;
        }
        #endregion
        static void Main(string[] args)
        {
            #region V1
            //Program.Sum(1, 2); 
            //int Result = Sum(1, 2);
            //Console.WriteLine(Result);

            //double Result2=Sum2Double(1.3, 2.5);
            //Console.WriteLine(Result2);

            //double Result3 = Sum(1, 2.5);
            //Console.WriteLine(Result3);

            //double Result4 = Sum(1.5,2);
            //Console.WriteLine(Result4);



            //Result = Sum3Numbers(1,2,3);
            //Console.WriteLine(Result);

            //Console.WriteLineInt(1);
            //Console.WriteLineDouble(1.2);
            //Console.WriteLineDecimal(1.2M);
            //Console.WriteLine(1.2F);
            //Console.WriteLine("3");
            //Console.WriteLine('3');
            #endregion

            #region V2
            //TypeA typeA =new TypeA(1);
            //typeA.A = 10;
            //typeA.Myfunc01();
            //typeA.Myfunc02();


            //typeB typeB=new typeB(1,2);
            //typeB.A = 10;
            //typeB.B = 20;
            //typeB.Myfunc01();
            //typeB.Myfunc02();
            #endregion

            #region V3
            //TypeA refBase;
            //refBase = new TypeB(1,2);
            //refBase.A = 10;
            //refBase.B = 20;
            //refBase.Myfunc01();
            //refBase.Myfunc02();

            #endregion

            #region V4
            //TypeB ChildRef = new TypeA();
            //TypeB ChildRef =(TypeB) new TypeA(1);

            //TypeA typeA = new TypeA(1);
            //TypeB typeB =(TypeB) typeA;

            //Console.WriteLine(typeB.A);
            //Console.WriteLine(typeB.B);

            //TypeA typeA= new TypeB(1,2);
            //TypeB typeB=(TypeB) TypeA;
            //Console.WriteLine(typeB.A);
            //Console.WriteLine(typeB.B);

            //object o = "2";
            //int x = (int)o;
            //Console.WriteLine(x);
            #endregion
        }
    }
}
