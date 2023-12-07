using System.Text;

namespace objeto_com_atributos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // chama criação do jogador
            novo();
        }

        // metodo para criar jogador
        public static void novo()
        {
            // receber dados
            var nome = Console.ReadLine();
            var nacionalidade = Console.ReadLine();
            var idade = Int32.Parse(Console.ReadLine());
            var posicao = Console.ReadLine();

            // cria objeto jogador
            var jogadorNovoCriado = new Jogador(nome, nacionalidade, idade, posicao);

            // pede para mostrar jogador
            Console.WriteLine(jogadorNovoCriado);
            
        }
    }

    class Jogador
    {
        public string Nome { get; set; }
        public string Nacionalidade { get; set; }
        public int Idade { get; set; }
        public string Posicao { get; set; }

        public Jogador(string nome, string nacionalidade, int idade, string posicao)
        {
            this.Nome = nome;
            this.Nacionalidade = nacionalidade;
            this.Idade = idade;
            this.Posicao = posicao;
        }

        public override string? ToString()
        {
            // cria texto com dados do jogador
            var infoJogador = new StringBuilder();
            infoJogador.AppendLine("Jogador criado!");
            infoJogador.AppendLine($"{this.Nome}");
            infoJogador.AppendLine($"{this.Nacionalidade}");
            infoJogador.AppendLine($"{this.Idade}");
            infoJogador.AppendLine($"Posição: {this.Posicao}");

            // faz um resumo das informações
            var infoJogadorCompleta = infoJogador.ToString();

            return infoJogadorCompleta;
        }

    }
}
