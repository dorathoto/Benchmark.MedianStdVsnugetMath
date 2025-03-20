using System.Diagnostics;
using MathNet.Numerics.Statistics;


namespace Benchmark.MedianStdVsnugetMath
{
    internal class Program
    {

        private static List<double> amostrasVerificacao = new List<double>();
        static void Main(string[] args)
        {
            Console.WriteLine("Gerando números aleatórios entre 0 e 1...");
            Random random = new Random();
            for (int i = 0; i < 500; i++)
            {
                amostrasVerificacao.Add(random.NextDouble());
            }
            Console.WriteLine("Geração concluída.\n");

            // Medição do tempo para o seu código (Mediana)
            Stopwatch stopwatch = Stopwatch.StartNew();
            double medianaPropria = CalcularMediana(amostrasVerificacao);
            stopwatch.Stop();
            Console.WriteLine($"Tempo para calcular a mediana (raiz): {stopwatch.ElapsedMilliseconds} ms");
            Console.WriteLine($"Mediana calculada (raiz): {medianaPropria}\n");

            // Medição do tempo para o seu código (Desvio Padrão)
            stopwatch.Restart();
            double desvioPadraoProprio = CalcularDesvioPadrao(amostrasVerificacao);
            stopwatch.Stop();
            Console.WriteLine($"Tempo para calcular o desvio padrão (raiz): {stopwatch.ElapsedMilliseconds} ms");
            Console.WriteLine($"Desvio padrão calculado (raiz): {desvioPadraoProprio}\n");

            // Medição do tempo para o Math.NET Numerics (Mediana)
            stopwatch.Restart();
            double medianaMathNet = Statistics.Median(amostrasVerificacao);
            stopwatch.Stop();
            Console.WriteLine($"Tempo para calcular a mediana (Math.NET Numerics): {stopwatch.ElapsedMilliseconds} ms");
            Console.WriteLine($"Mediana calculada (Math.NET Numerics): {medianaMathNet}\n");

            // Medição do tempo para o Math.NET Numerics (Desvio Padrão)
            stopwatch.Restart();
            double desvioPadraoMathNet = Statistics.StandardDeviation(amostrasVerificacao);
            stopwatch.Stop();
            Console.WriteLine($"Tempo para calcular o desvio padrão (Math.NET Numerics): {stopwatch.ElapsedMilliseconds} ms");
            Console.WriteLine($"Desvio padrão calculado (Math.NET Numerics): {desvioPadraoMathNet}\n");
            Console.ReadKey();
        }

        private static double CalcularMediana(List<double> dados)
        {
            var listaOrdenada = dados.OrderBy(x => x).ToList();
            int tamanho = listaOrdenada.Count;
            if (tamanho == 0) return 0;

            if (tamanho % 2 == 0)
                return (listaOrdenada[tamanho / 2 - 1] + listaOrdenada[tamanho / 2]) / 2.0;
            else
                return listaOrdenada[tamanho / 2];
        }

        private static double CalcularDesvioPadrao(List<double> dados)
        {
            if (dados.Count < 2) return 0;

            double media = dados.Average();
            double somaQuadrados = dados.Sum(x => Math.Pow(x - media, 2));
            double variancia = somaQuadrados / (dados.Count - 1);
            return Math.Sqrt(variancia);
        }
    }
}
