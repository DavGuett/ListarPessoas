using Pessoas;

Console.WriteLine("Quantas pessoas serão adicionadas?");
int numeroDePessoas = int.Parse(Console.ReadLine());  

List<Pessoa> listaPessoas = new List<Pessoa>();

for (int i = 0; i < numeroDePessoas; i++)
{
    Console.WriteLine("Digite o nome da pessoa N°" + i + " ");
    string nome = Console.ReadLine();
    Console.WriteLine("Digite a idade da pessoa N°" + i + " ");
    int idade = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o sexo da pessoa N°" + i + " ");
    char sexo = char.Parse(Console.ReadLine());
    listaPessoas.Add(new Pessoa(idade, nome, sexo));
    Console.WriteLine();
}
Console.WriteLine("---------------------------");
foreach (Pessoa pessoa in listaPessoas)
{
    Console.WriteLine(pessoa.listarInformacoes());
}