namespace ReviãoDoAssunto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = 25;           // numero inteiro
            long numero_palnetas = 8; // numero inteiro grande
            short numero_estados = 24;// numero inteiro pequeno
            byte numero_salas = 2;    // numero inteiro de 0 á 255
            sbyte numero_debito = -30;// numero inteiro de -128 á 127

            uint numero1 = 25;        // somente numeros iteiros positivos
            ulong numero2 = 8;        // somente numeros iteiros grande positivos
            ushort numero3 = 24;      // somente numeros iteiros pequeno positivos

            double altura = 1.75f;    // numero decimal
            string nome = "Nino";     // texto
            bool ligado = true;       // verdadeiro(true) ou falso(false)

            var pais = "Brasil";      // o compilador entende que é string

            Console.WriteLine("Hello, World!");

        }
    }
}
