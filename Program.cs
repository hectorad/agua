using System;
namespace botellas
{
    class program
    {
        static void main(string[] args)
        {
            
            
            Console.WriteLine("cuanto tardas en bañarte");
            var tiempo = System.Console.ReadLine();
            int inttiempo = int.Parse(tiempo);
            var botellas = inttiempo * 12;
            Console.WriteLine("Cuando cumples años?    Ejemplo:12/04/2017"); 
            var dias = System.Console.ReadLine(); 
            int diasint = int.Parse(dias);
            var botellasb = botellas *  diasint;
            Console.WriteLine($"tu gastas alrededor de {botellas} botellas de agua cuando te bañas");
            DateTime thisDays = DateTime.Today;
            var time = thisDays;
            Console.WriteLine($"asta tu cumpleaños gastaras {botellasb} botellas de agua al bañarte");

        }
    }
}
