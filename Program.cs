using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ƏdədiOrta
            int[] myNum = { 10, 20, 38, 42 };
            Console.WriteLine("Task1= " + Aritmeth(myNum));

            
            //Rəqəmlərin Oxşar Olub-Olmadığı
            Console.WriteLine("Task2= " + checkSameDigit(2355));
            Console.WriteLine("Task2= " + checkSameDigit(222));

            //Mərtəbələrin Cəmi
            Console.WriteLine("Task3= " + FindSum(143));

        }

        #region Task 1-ƏdədiOrta
        public static int Aritmeth(int[] Number)
        {
            int result = 0;
            for (int i = 0; i < Number.Length; i++)
            {
                result = result + Number[i];
            }
            return result / Number.Length;

        }
        #endregion
        #region Task 2-MərtəbələrinOxşarlığı
            static string checkSameDigit(int Number2)
            {

            
            int lastdigit = Number2 % 10;

            while (Number2 != 0)
            {

                
                int current_digit = Number2 % 10;


                Number2 = Number2 / 10;
                if (current_digit != lastdigit)
                {
                    return "Bütün Reqemler Eyni Deyil.";
                }
            }
            return "Bütün Reqemler Eynidir.";
        }
        #endregion      
        #region Task 3-İşləməyən_Kod
        //Mərtəbələrin Eyniliyini Yoxlayan Kod. Tam Qura Bilmədim.
        public static void DigitsDifference(int Number2)
        {
            var result1 = "Eynidir";
            var result2 = "Ferqlidir";
            var Differ=""; 
            int reminder = Number2 % 10;
            while (Number2 != reminder)
            {
                Number2 = Number2 / 10;
                if (Number2 % 10 == reminder)
                {
                    Differ= result1;
                }
                else
                {
                    Differ=result2;
                }
                Console.WriteLine(Differ); ;
            }
            
        }
        #endregion
        #region Task 3-Mərtəbələrin Cəmi
        public static int FindSum(int Number1)
        {
            int sum = 0;
            while (Number1 > 0)
            {
                sum += Number1 % 10;
                Number1 /= 10;
            }
            return sum;
        }
        #endregion
    }

}




