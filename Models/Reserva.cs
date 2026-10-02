namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            var suiteCapacidade = Suite.Capacidade;
            var qtdeHospedes = hospedes.Count();

            if (suiteCapacidade >= qtdeHospedes)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("Quantidade de hospedes maior que a suportada");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            var hospedes = Hospedes.Count();
            return hospedes;
        }

        public decimal CalcularValorDiaria()
        {

            decimal valor = DiasReservados * Suite.ValorDiaria;
            decimal desconto = 0.90m;

            var temDesconto = DiasReservados >= 10 ? valor * desconto : valor;
            if (true)
            {
                valor = temDesconto;
            }

            return valor;
        }
    }
}