using System;

namespace Seminar2HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишите программу, которая принимает на вход трехзначное число 
            //и на выходе показывает вторую цифру этого числа

            int CutNumber(){
                int num = new Random().Next(100,1000);
                Console.WriteLine ("Number is - " + num);

                int sot = num % 100;
                int dec = num % 10;
                int result = (sot - dec)/10;
                return result;
            }
            
            int number = CutNumber ();
            Console.WriteLine("Cut number is - " + number);
            
        }
    }
}
