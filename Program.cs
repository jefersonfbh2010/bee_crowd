using System; 

class URI {

    static void Main(string[] args) { 

        int N = int.Parse(Console.ReadLine());
        int[] X = new int[N];
        int posicao = 0;


        for (int i = 0; i < N; i++) {
            X[i] = int.Parse(Console.ReadLine());
        }

        int menor = X[0];

        for (int i = 0; i < N; i++) {
            if (X[i] < menor) {
                menor = X[i];
                posicao = i + 1;
            }
        }

        Console.WriteLine($"Menor valor: {menor}");
        Console.WriteLine($"posicao: {posicao}");
    }

}