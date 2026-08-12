using System; 


class URI {

    static void Main(string[] args) {
int opcao = 1;
while (opcao ==1 ) {

int nota1 =int.Parse(Console.ReadLine()!);
int nota2 =int.Parse(Console.ReadLine()!);

if (nota1 < 0 || nota1 > 10 || nota2 < 0 || nota2 > 10) 
{
    Console.WriteLine("Nota inválida");
    
       
}
else if (nota1 >= 0 && nota1 <= 10 && nota2 >= 0 && nota2 <= 10)
{
    double media = (nota1 + nota2) / 2.0;
    Console.WriteLine($"Média: {media:F2}");
    }
Console.WriteLine ("Novo calculo (1-sim 2-nao)");
 opcao = int.Parse(Console.ReadLine());

while (opcao != 1 && opcao != 2) {
    opcao = int.Parse (Console.ReadLine());
}
}
}  
}