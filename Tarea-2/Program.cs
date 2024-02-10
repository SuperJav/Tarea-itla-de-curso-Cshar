namespace Tarea_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Escribir un programa en el cual se ingresen cuatro números,
             calcular e informar la suma de los dos primeros y el producto 
             del tercero y el cuarto.
            */

            //Declaracion de las variables donde almacenaremos los numero entrate y resultado de la misma
            int num1,num2,num3,num4;
            int suma, multiplicacion;

            //Mostrar en pantalla las indicaciones
            Console.WriteLine("Hola, Este programa permite calcular los 4 numeros que ingrese");
            Console.WriteLine("---------------------------------------------------------------");

            Console.WriteLine("Ingrese el primer numero para sumar:");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero para sumar:");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer numero para multiplicar:");
            num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el cuarto numero para multiplicar:");
            num4 = int.Parse(Console.ReadLine());

            //Calculamos los respectivo valores.
            suma = num1 + num2;
            multiplicacion = num3 * num4;

            //Mostramos en pantalla los resultados
            Console.WriteLine($"La suma de los dos primero dos valores insertados es: {suma}.");
            Console.WriteLine($"La multiplicacion de los dos ultimos valores es: {multiplicacion}.");

        }
    }
}
