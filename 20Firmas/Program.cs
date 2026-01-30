namespace _20Firmas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Saludar();
            MostrarNumero(5);
            Console.WriteLine(RetornarDiez());
            Console.WriteLine(Sumar(2, 3));
            MostrarTexto("Hola");
            Console.WriteLine(Unir("Hola", " Mundo"));
            Console.WriteLine(EsPar(4));
            MostrarArray(new int[] { 1, 2, 3 });
            Console.WriteLine(SumarArray(new int[] { 1, 2, 3 }));
            MostrarMatriz(new int[,] { { 1, 2 }, { 3, 4 } });
            Console.WriteLine(ContarLetras("Hola"));
            Console.WriteLine(Mayor(3, 9));
            MostrarBool(true);
            Console.WriteLine(Cuadrado(5));
            Persona p = new Persona { Nombre = "Juan" };
            MostrarPersona(p);
            Console.WriteLine(ConvertirDouble(5));
            ImprimirLinea();
            Console.WriteLine(Multiplicar(2.5, 2));
            MostrarChar('A');
            Console.WriteLine(EsMayorEdad(20));
        }

        //Lista de las 20 firmas: 

        // 1. Sin parámetros, sin retorno
        static void Saludar() => Console.WriteLine("Hola");

        // 2. Con parámetro, sin retorno
        static void MostrarNumero(int n) => Console.WriteLine(n);

        // 3. Sin parámetros, con retorno
        static int RetornarDiez() => 10;

        // 4. Con parámetros, con retorno
        static int Sumar(int a, int b) => a + b;

        // 5. String sin retorno
        static void MostrarTexto(string t) => Console.WriteLine(t);

        // 6. String con retorno
        static string Unir(string a, string b) => a + b;

        // 7. Bool con retorno
        static bool EsPar(int n) => n % 2 == 0;

        // 8. Array sin retorno
        static void MostrarArray(int[] arr)
        {
            foreach (int n in arr) Console.Write(n + " ");
            Console.WriteLine();
        }

        // 9. Array con retorno
        static int SumarArray(int[] arr)
        {
            int suma = 0;
            foreach (int n in arr) suma += n;
            return suma;
        }

        // 10. Matriz sin retorno
        static void MostrarMatriz(int[,] m)
        {
            for (int i = 0; i < m.GetLength(0); i++)
                for (int j = 0; j < m.GetLength(1); j++)
                    Console.Write(m[i, j] + " ");
            Console.WriteLine();
        }

        // 11. Cadena con retorno
        static int ContarLetras(string t) => t.Length;

        // 12. Condicional
        static int Mayor(int a, int b) => a > b ? a : b;

        // 13. Bool sin retorno
        static void MostrarBool(bool v) => Console.WriteLine(v);

        // 14. Operación matemática
        static int Cuadrado(int n) => n * n;

        // 15. Clase como parámetro
        static void MostrarPersona(Persona p) => Console.WriteLine(p.Nombre);

        // 16. Conversión de tipo
        static double ConvertirDouble(int n) => (double)n;

        // 17. Sin parámetros, sin retorno
        static void ImprimirLinea() => Console.WriteLine("----");

        // 18. Double con retorno
        static double Multiplicar(double a, int b) => a * b;

        // 19. Char como parámetro
        static void MostrarChar(char c) => Console.WriteLine(c);

        // 20. Condicional con bool
        static bool EsMayorEdad(int edad) => edad >= 18;

        //Usando tipo de dato de clase:
        class Persona
        {
            public string Nombre;
        }
    }
}
