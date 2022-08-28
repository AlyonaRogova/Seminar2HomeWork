using System;

namespace Seminar2HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            // //Напишите программу, которая принимает на вход трехзначное число 
            // //и на выходе показывает вторую цифру этого числа

            // int CutNumber(){
            //     int num = new Random().Next(100,1000);
            //     Console.WriteLine ("Number is - " + num);

            //     int sot = num % 100;
            //     int dec = num % 10;
            //     int result = (sot - dec)/10;
            //     return result;
            // }
            
            // int number = CutNumber ();
            // Console.WriteLine("Cut number is - " + number);
            
            //Напишите программу, которая выводит третью цифру заданного числа 
            //или сообщает, что третьей цифры нет.

            // int CutNumber (int num){
            //     int dec = num / 10;
            //     int res = dec % 10;
            //     return res;
            // }
            
            // Console.WriteLine("Enter the number: ");
            // int num = Convert.ToInt32(Console.ReadLine());
            // while (num > 99) {
            //     if (num > 999){
            //         Console.WriteLine ("The third number is - " + CutNumber(num));
            //     }
            //     else{
            //         Console.WriteLine ("There is not the third number");
            //     }
            // }
            // НЕ СМОГЛА ДОВЕСТИ ДО УМА

            //Напишите программу, которая принимает на вход цифру, обозначающую день недели,
            // и проверяет, является ли этот день выходным
            
            void Holidays(int day){
                
                if (day >=6 && day <8){
                    Console.WriteLine ("Ура! Выходной!");
                }
                else if (day >=1 && day <6){
                    Console.WriteLine ("Трудовые будни");
                }
                else{
                Console.WriteLine("Такого дня недели нет");
                }
            }

            Console.WriteLine ("Введите номер дня недели: ");
            int day = Convert.ToInt32 (Console.ReadLine());
            Holidays (day);
            

        }
    }
}
