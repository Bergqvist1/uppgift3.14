using System;
namespace Uppgift_3_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Har du gått ut gymnaaiet, svara j för Ja och n för Nej");
            string rättSvar = Console.ReadLine();

            Console.WriteLine("Hur gammal är du?"); 
            int ålder = int.Parse(Console.ReadLine());

            if(ålder <= 22 & rättSvar=="j" )
            {
                Console.WriteLine("Vi vill gärna anställa dig");
            }

            else 
            {
                Console.WriteLine("tyvärr vi vill inte anställa dig");
            }
 
        }
    }
}
