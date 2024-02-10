namespace Tarea_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              Se ingresan tres notas de un alumno, si el promedio es mayor o igual a
              siete mostrar un mensaje "Promocionado".
            */

            //Mostramos en pantalla 
            Console.WriteLine("Programa que permite calificar a un estudiante mediante sus tres ultimas notas.");
            Console.WriteLine("-------------------------------------------------------------------------------");

            //Declaracion de variables
            double nota1, nota2, nota3;
            string nombre_Alumno;
            double promedio;


            //Mostrar en pantalla
            Console.WriteLine("Ingrese el nombre del estudiante:");
            nombre_Alumno = Console.ReadLine();

            Console.WriteLine("Ingrese la primera nota");
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la segunda nota");
            nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la tercera nota");
            nota3 = double.Parse(Console.ReadLine());

            //Calculo.
            promedio = (nota1 + nota2 + nota3) / 3;

            //Mostrar en pantalla
            Console.WriteLine($"Nombre del estudiante {nombre_Alumno}");
            Console.WriteLine($"Promedio {promedio}.\t");

            //Condicion 
            if (promedio >= 7)
            {
                Console.WriteLine("Promocionado!!!😊");
            }
            else
            {
                Console.WriteLine("Quemado!!!");
            }
        }
    }
}
