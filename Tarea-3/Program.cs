namespace Tarea_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar un programa que lea cuatro valores numéricos e informar su suma y promedio.

            //Mostramos en pantalla.
            Console.WriteLine("Este programa permite tomar 4 valores ingresado y sumarlo como tambien saber el promedio.");
            Console.WriteLine("-----------------------------------------------------------------------------------------");

            //Declaramos las variables donde almacenaremos los valores y el resultado de la misma.
            int num1,num2,num3,num4;
            int suma;
            double promedio;


            //Mostramos en pantalla.
            Console.WriteLine("Ingrese el primer valor:");
            num1= int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo valor:");
            num2= int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer valor:");
            num3= int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el cuarto valor:");
            num4= int.Parse(Console.ReadLine());

            //Calculamos los varores
            suma= num1+num2+num3+num4;
            promedio = (double) suma / 4;

            //Mostramos en pantalla los resultados.
            Console.WriteLine($"La suma de los cuatro valores es: {suma}");
            Console.WriteLine($"El promedio es: {promedio}"); 

        }
    }
}
