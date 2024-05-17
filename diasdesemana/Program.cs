using System;

namespace diasdesemana
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("\n Programa para mostrar los dias de semana\n");

            Console.WriteLine("\n Ingrese el dia a Buscar\n");
            int seleccion = int.Parse(Console.ReadLine());

            switch (seleccion)
            {

                case 1: Console.WriteLine("Hoy es Lunes");
                        ; break;
                case 2: Console.WriteLine("Hoy es Martes");
                        ; break;
                case 3: Console.WriteLine("Hoy es Miercoles");
                        ; break;
                case 4: Console.WriteLine("Hoy es Jueves");
                        ; break;
                case 5: Console.WriteLine("Hoy es Viernes");
                        ; break;
                case 6: Console.WriteLine("Hoy es Sabado");
                        ; break;
                case 7: Console.WriteLine("Hoy es Domingo");
                        ; break;
                default: Console.WriteLine("No existe un dia 8");
                        ; break;




            }
        }
    }
}
