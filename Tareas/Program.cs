namespace Tareas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de los dos variables a utilizar.
            int lado = 0;
            int total = 0;

            //Mostramos en consola la infromacion necesaria.
            Console.WriteLine("Este programa permite calcular el perimetro de un cuadrado!");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Ingrese el valor de un lado del cuadrado:");

            //Guardamos el valor ingresado por el usuario.
            lado = int.Parse(Console.ReadLine());

            //Calculamos el valor 
            total = lado * 4;

            //Mostramos en consola el resultado.
            Console.WriteLine($"El perimetro del cuadrado es: {total}");
            Console.Read();

        }
    }
}
