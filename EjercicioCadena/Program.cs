namespace EjercicioCadena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese una frase: ");
            string frase = Console.ReadLine();

            string[] palabras = frase.Split(' ');
            string resultado = "";

            foreach (string p in palabras)
            {
                resultado += char.ToUpper(p[0]) + p.Substring(1).ToLower() + " ";
            }

            Console.WriteLine(resultado.Trim());
        }
    }
}
