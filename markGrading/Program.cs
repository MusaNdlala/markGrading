using System;

namespace markGrading
{
    class Program
    {
        private static string Grade(int uIntMark){
            if (uIntMark >= 0 && uIntMark <= 49)
            {
                return "Fail";
            }
            else if (uIntMark >= 50 && uIntMark <= 60)
            {
                return "Pass";
            }
            else if (uIntMark >= 70 && uIntMark <= 84)
            {
                return "Credit";
            }
            else if (uIntMark >= 85 && uIntMark <= 100)
            {
                return "Distinction";
            }
            else
                return "invalid data Please enter a number between 0-100";            
        }        
        static void Main(string[] args){
            Console.WriteLine("Please enter a number between 0-100");
            String Mark = Console.ReadLine();            
            int Intmark = 0;

            if (int.TryParse(Mark, out Intmark))
                Console.WriteLine(Grade(Intmark));
            else
                Console.WriteLine("Please enter a number");           
            Console.Read();
        }
    }
}
