// Um código onde voce pergunta para o usuário o nome dele, a idade, o cargo e no final imprime uma saudação na tela com todas as infos e com data e hora

Console.Write("Nome: ");
string nome = Console.ReadLine();

Console.Write("Idade: ");
int idade = Convert.ToInt32(Console.ReadLine());

Console.Write("Cargo: ");
string cargo = Console.ReadLine();

Console.WriteLine($"\nOlá {nome}, você tem {idade} anos e é {cargo}. Hoje é dia {DateTime.Now} ");

Console.ReadKey();