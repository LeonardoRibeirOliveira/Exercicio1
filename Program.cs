using System;

class Program
{
    static void Main(string[] args)
    {
        //Estipula o tamanho do vetor de partida em que A participou.
        Console.WriteLine("Digite a quantidade de partidas do time A:");
        int quantidadePartidasA = int.Parse(Console.ReadLine());
        int[] golsA = new int[quantidadePartidasA];

        //Preenche cada partida com o número de gols com base na quantidade de partidas.
        for (int i = 0; i < golsA.Length; i++)
        {
            Console.WriteLine($"Digite o númeor de gols da {i + 1}° partida do time A:");
            golsA[i] = int.Parse(Console.ReadLine());
        }

        //Estipula o tamanho do vetor de partida em que A participou.
        Console.WriteLine("Digite a quantidade de partidas do time B:");
        int quantidadePartidasB = int.Parse(Console.ReadLine());
        int[] golsB = new int[quantidadePartidasB];

        //Preenche cada partida com o número de gols com base na quantidade de partidas.
        for (int j = 0; j < golsB.Length; j++)
        {
            Console.WriteLine($"Digite o númeor de gols da {j + 1}° partida do time B:");
            golsB[j] = int.Parse(Console.ReadLine());
        }

        int[] qntdBMaisGolsA = QntdBMaisGolsA(golsA, golsB);

        //Imprime os valores da função QntdBMaisGolsA
        for (int j = 0; j < golsB.Length; j++)
        {
            Console.WriteLine($"Número de vezes em que {j + 1}° a partida e B fez mais gols que as demais partidas de A: {qntdBMaisGolsA[j]}");
        }

    }

    //Função que concatena as partidas de B em questão a todas de A, somando um valor inteiro para nGols em B > nGols em A em cada partida de B. 
    static int[] QntdBMaisGolsA(int[] golsA, int[] golsB)
    {
        int[] qntdBMaisGolsA = new int[golsB.Length];

        for (int j = 0; j<golsB.Length; j++)
        {
            for (int i = 0; i < golsA.Length; i++)
            {
                if (golsB[j] >= golsA[i])
                {
                    qntdBMaisGolsA[j]++;
                }
            }
        }
        return qntdBMaisGolsA;
    }
}
