using System;

namespace ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ArrOfNums = new int[] { 1, 1, 2, 3, 5, 8 };

            foreach(int i in ArrOfNums){
                if(i % 2 != 0)
                {
                    System.Console.Write("{0} ", i);
                }
            }
        }
    }
}
