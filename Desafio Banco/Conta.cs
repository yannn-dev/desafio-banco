namespace banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta1 = new Conta(2345, 89714567, "João Paulo", 24500000);
            Console.WriteLine("Agencia: {0}", conta1.Agencia);
            Console.WriteLine("Número: {0}", conta1.Numero);
            Console.WriteLine("Nome do cliente: {0}", conta1.NomeCliente);
            Console.WriteLine("Saldo disponível: {0}", conta1.ValorDisponivel);
            Console.Write("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }

    class Conta
    {
        private int agencia;
        private int numero;
        private string nomeCliente;
        private double valorDisponivel;

        public Conta(int agencia, int numero, string nomeCliente, float valorDisponivel)
        {
            Agencia = agencia;
            Numero = numero;
            NomeCliente = nomeCliente;
            ValorDisponivel = valorDisponivel;
        }
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public string NomeCliente { get; set; }
        public double ValorDisponivel { get; set; }
    }
}

