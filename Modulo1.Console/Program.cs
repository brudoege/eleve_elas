/*
Aula 15/05
Um código onde voce pergunta para o usuário o nome dele, a idade, o cargo e no final imprime uma saudação na tela com todas as infos e com data e hora

Console.Write("Nome: ");
string nome = Console.ReadLine();

Console.Write("Idade: ");
int idade = Convert.ToInt32(Console.ReadLine());

Console.Write("Cargo: ");
string cargo = Console.ReadLine();

Console.WriteLine($"\nOlá {nome}, você tem {idade} anos e é {cargo}. Hoje é dia {DateTime.Now} ");

Console.ReadKey();
*/

/*
//Aula 17/05
//Um código onde voce informa dois numeros e uma operação matematica

Console.Write("Informe um número: ");
decimal n1 = Convert.ToDecimal(Console.ReadLine());

Console.Write("Informe outro número: ");
decimal n2 = Convert.ToDecimal(Console.ReadLine());

Console.Write("Informe a operação a ser feita(+, -, * ou /): ");
char operacao = Console.ReadKey().KeyChar;

decimal resultado = 0;
switch (operacao)
{
    case '+':
        resultado = n1 + n2;
        break;
    case '-':
        resultado = n1 - n2;
        break;
    case '*':
        resultado = n1 * n2;
        break;
    case '/':
        if (n2 == 0)
        {
            Console.WriteLine("Erro: Divisão por zero não é permitida.");
            return;
        }
        resultado = n1 / n2;
        break;
    default:
        Console.WriteLine("Operação inválida. Por favor, use +, -, * ou /.");
        return;
}

Console.WriteLine($"\n\nO resultado da operação {n1} {operacao} {n2} é {resultado}");

Console.ReadKey();

*/

/*
Exercício 2
1-adicione nome
2-adicione data nascimento
3-adicione estado civil
4-sair

Deseja incluir outro nome (s/n)?
*/


int opcao = 0;
List<string> listaNomes = new List<string>();
List<string> listaDatas = new List<string>();
List<string> listaEstados = new List<string>();
bool continuar = true;

while (opcao != 7)
{
    Console.Clear();
    Console.WriteLine("Menu:");
    Console.WriteLine("1-Adicione nome");
    Console.WriteLine("2-Adicione data nascimento");
    Console.WriteLine("3-Adicione estado civil");
    Console.WriteLine("4-Litar nomes");
    Console.WriteLine("5-Listar datas nascimento");
    Console.WriteLine("6-Listar estados civis");
    Console.WriteLine("7-Sair");
    Console.Write("\nInforme a opção: ");
    opcao = Convert.ToInt32(Console.ReadLine());

    continuar = true;

    switch (opcao)
    {
        case 1:
            while (continuar == true)
            {
                Console.Clear();
                Console.Write("Informe um nome: ");
                listaNomes.Add(Console.ReadLine());
                Console.Write("\nDeseja continuar(s/n)? ");
                if (Console.ReadLine() == "s")
                    continuar = true;
                else
                    continuar = false;
            }
            break;
        case 2:
            while (continuar == true)
            {
                Console.Clear();
                Console.Write("Informe uma data de nascimento: ");
                listaDatas.Add(Console.ReadLine());
                Console.Write("\nDeseja continuar(s/n)? ");
                if (Console.ReadLine() == "s")
                    continuar = true;
                else
                    continuar = false;
            }
            break;
        case 3:
            while (continuar == true)
            {
                Console.Clear();
                Console.Write("Informe um estado civil: ");
                listaEstados.Add(Console.ReadLine());
                Console.Write("\nDeseja continuar(s/n)? ");
                if (Console.ReadLine() == "s")
                    continuar = true;
                else
                    continuar = false;
            }
            break;
        case 4:
            Console.Clear();
            for (int i = 0; i < listaNomes.Count; i++)
            {
                Console.WriteLine($"Nome {i + 1} informado: {listaNomes[i]}");
            }
            Console.ReadKey();
            break;
        case 5:
            Console.Clear();
            for (int i = 0; i < listaDatas.Count; i++)
            {
                Console.WriteLine($"Data nascimento {i + 1} informada: {listaDatas[i]}");
            }
            Console.ReadKey();
            break;
        case 6:
            Console.Clear();
            for (int i = 0; i < listaEstados.Count; i++)
            {
                Console.WriteLine($"Estado civil {i + 1} informado: {listaEstados[i]}");
            }
            Console.ReadKey();
            break;
        case 7:
            Console.WriteLine("\nTchau!");
            Console.ReadKey();
            break;
        default:
            Console.WriteLine("\nOpção inválida!");
            Console.ReadKey();
            break;
    }
}
