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

Console.WriteLine($"\nO resultado da operação {n1} {operacao} {n2} é {resultado}");

Console.ReadKey();

