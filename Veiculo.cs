
namespace EcxercíciosPOO
{
    public class Veiculo
    {
        private int velocidade;


        public int Velocidade
        {
            get { return velocidade; }
            set 
            {
                if (value >= 0 && value <= 200) 
                {
                    velocidade = value;
                    Console.WriteLine($"Velocidade válida: {velocidade}");
                }
                else
                {
                    Console.WriteLine("Velocidade inválida. A velocidade deve estar entre 0 e 200.");
                }
            }
        }
        
    }
}
