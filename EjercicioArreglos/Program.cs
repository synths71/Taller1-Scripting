namespace EjercicioArreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long[] numeros = { 10, 50, -3, 99, 2 };

            long mayor = numeros[0];
            long menor = numeros[0];

            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] > mayor) mayor = numeros[i];
                if (numeros[i] < menor) menor = numeros[i];
            }

            Console.WriteLine("Mayor: " + mayor);
            Console.WriteLine("Menor: " + menor);
            //fhhf
            //hfhfh
            //ybbyub8778

        }
    }
}
