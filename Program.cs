internal class Program
{
    private static void Main(string[] args)
    {
        {
            Console.WriteLine("Ingrese la medida de la base del rectangulo: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la medida de la altura del rectangulo: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            //llamar a la funcion
            double resultado = num1 * num2;
            Console.WriteLine($"{num1} * {num2} = {resultado}");
            


            Console.WriteLine($"El area del rectangulo es: {resultado}");

            Console.ReadKey();

        }

        
    }
}