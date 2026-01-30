namespace SegundoEjercicioFuncion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese una palabra: ");
            string palabra = Console.ReadLine();

            Console.WriteLine(EsPalindromo(palabra) ? "Es palíndromo" : "No es palíndromo");
        }

        static bool EsPalindromo(string texto)
        {
            texto = texto.ToLower().Replace(" ", "");
            string invertido = "";

            for (int i = texto.Length - 1; i >= 0; i--)
                invertido += texto[i];

            return texto == invertido;
        }
    }
}
