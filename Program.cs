namespace _5_ejercicios_scripting
{
    internal class Program
    {
        //Este es uno de los 2 ejercicio de funciones. 
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5 };
            int[] resultado = InvertirArray(nums);

            foreach (int n in resultado)
                Console.Write(n + " ");
        }

        static int[] InvertirArray(int[] arr)
        {
            int[] invertido = new int[arr.Length];
            int j = 0;

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                invertido[j] = arr[i];
                j++;
            }
            return invertido;
        }


    }
}
