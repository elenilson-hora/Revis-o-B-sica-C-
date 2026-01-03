namespace ReviãoDoAssunto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // tipos de variaveis
            int idade = 25;           // numero inteiro
            long numero_palnetas = 8; // numero inteiro grande
            short numero_estados = 24;// numero inteiro pequeno
            byte numero_salas = 2;    // numero inteiro de 0 á 255
            sbyte numero_debito = -30;// numero inteiro de -128 á 127

            uint numero1 = 25;        // somente numeros iteiros positivos
            ulong numero2 = 8;        // somente numeros iteiros grande positivos
            ushort numero3 = 24;      // somente numeros iteiros pequeno positivos

            float dinheiro = 1.99f;   // numero decimal simples 7 digitos
            double altura = 1.75f;    // numero decimal 16 digitos
            decimal imposto = 3.77M;  // numero decimal 29 digitos

            string nome = "Nino";     // texto
            char letra = 'A';         // caractere

            bool ligado = true;       // verdadeiro(true) ou falso(false)

            object livro = null;      // tipo base de todos os outros tipos em c#
            dynamic capa = null;      // tipo dinâmico, definido em tempo de execução
            var pais = "Brasil";      // o compilador entende que é string

            //operadores
            nome = idade >= 18 ? "É nino" : "Não é nino";
            pais = capa ?? "não tem livro";


            Console.WriteLine("Hello, World!");

        }
    }
}
