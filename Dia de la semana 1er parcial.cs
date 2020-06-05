using System;

namespace Parcial_Dia_de_la_semana
{
    class Program
    {
        static void Main(string[] args)
        {
            string dia;
            Console.WriteLine("Escribe un dia de la semana: ");
            dia = Console.ReadLine();
            dia = dia.ToLower();
            if (dia == "sabado" || dia=="domingo")
            {
                Console.WriteLine("Es un fin de semana, disfrutalo. ");

            }
            else
            {
                Console.WriteLine("No es un fin de semana, debes hacer los deberes.");
            }
        }
    }
}
