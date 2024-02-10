namespace Tarea_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Realizar un programa que lea por teclado dos números, si el primero es mayor al 
             segundo informar su suma y diferencia, en caso contrario informar el producto y 
            la división del primero respecto al segundo.*/

            //Mostrar en pantalla la informacion
            Console.WriteLine("Este programa permite comparar dos valores con diferente condiciones.");
            Console.WriteLine("---------------------------------------------------------------------");

            //Declaracion de variables
            int num1, num2;
            int producto;
            double division;

            //Mostrar en pantalla.
            Console.WriteLine("Ingrese el primer valor:");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo valor:");
            num2 = int.Parse(Console.ReadLine());

            //Condicional si num1 es mayor que num2.
            if (num1 > num2)
            {
                
                producto = num1 * num2;
                Console.WriteLine($"El primer valor es mayor, el resultado de la multiplicacion es: {producto}");
            }else
            {
                division = (double)num1 / num2;
                Console.WriteLine($"El primer valor es menor, el resultado de la division es: {division}");
            }
        }
    }
}
