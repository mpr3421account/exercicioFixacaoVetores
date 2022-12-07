/*A dona de um pensionato possui dez quartos para alugar para estudantes,
sendo esses quartos identificados pelos números 0 a 9.
Quando um estudante deseja alugar um quarto, deve-se registrar o nome
e email deste estudante.
Fazer um programa que inicie com todos os dez quartos vazios, e depois
leia uma quantidade N representando o número de estudantes que vão
alugar quartos (N pode ser de 1 a 10). Em seguida, registre o aluguel dos
N estudantes. Para cada registro de aluguel, informar o nome e email do
estudante, bem como qual dos quartos ele escolheu (de 0 a 9). Suponha
que seja escolhido um quarto vago. Ao final, seu programa deve imprimir
um relatório de todas ocupações do pensionato, por ordem de quarto,
conforme exemplo.
*/


using exercicioFixacaoVetores;

Console.Write("Quantos quartos serão ocupados? ");
int n = int.Parse(Console.ReadLine());

Estudante[] estudantes= new Estudante[10];

for(int i = 1; i <= n; i++)
{
    Console.WriteLine();
    Console.WriteLine($"Aluguel #{i}:");
    Console.Write("Nome: ");
    string nome = Console.ReadLine();
    Console.Write("e-mail: ");
    string email = Console.ReadLine();
    Console.Write("Quarto: ");
    int quarto = int.Parse(Console.ReadLine());
    estudantes[quarto] = new Estudante(nome, email);
}
Console.WriteLine("Quartos ocpados:");
Console.WriteLine();
for (int i = 0;i<10; i++)
{
    if (estudantes[i] != null)
    {
        Console.WriteLine(i + ": "+ estudantes[i]);
    }
}