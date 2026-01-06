namespace Ex04.src
{
    public class VIP : Ingresso
    {
        public decimal valorAdicional { get; set; }
        public void valorTotalVIP()
        {
           decimal valorTotalVIP = valorEmReais + valorAdicional;
           Console.WriteLine($"O valor do ingresso é {valorTotalVIP}");
        }
    }
}