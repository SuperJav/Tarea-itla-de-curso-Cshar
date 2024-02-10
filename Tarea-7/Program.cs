namespace Tarea_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Se ingresa por teclado un número positivo de uno o dos dígitos (1..99) mostrar un mensaje 
             indicando si el número tiene uno o dos dígitos.
             (Tener en cuenta que condición debe cumplirse para tener dos dígitos, un número entero).
            */

            //Mostrar en pantalla.
            Console.WriteLine("Programa para saber si el valor de un numero ingresado es de dos o un digito.");
            Console.WriteLine("------------------------------------------------------------------------------");

            //Declaracion de variables.
            int num;

            Console.WriteLine("Ingrese el valor:");
            num = int.Parse(Console.ReadLine());

            //Condicion.
            if (num > 0 && num <= 99)
            {
                if (num > 9)
                {
                    Console.WriteLine("El numero ingresado es de dos digitos.");
                }
                else
                {
                    Console.WriteLine("El numero ingresado es de un digito.");
                }
            }
            else
            {
                Console.WriteLine("El valor debe estar dentro del rango 1....99");
            }
        }
    }
}
