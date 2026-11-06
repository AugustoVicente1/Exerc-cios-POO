
namespace EcxercíciosPOO
{
    public class Funcionario
    {
        public string? Nome { get; set; }

        public string? Cargo { get; set; }

        public decimal Salario { get; private set; }
        private decimal _salario;

        public void AumentarSalario(decimal valor = 3000.00 * 0.10)
        {
            _salario += valor;
        }
        public decimal ConsultarSalario()
        {
            return _salario;
        }

    }
}
