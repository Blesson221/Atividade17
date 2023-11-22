// See https://aka.ms/new-console-template for more information
Console.WriteLine ("Digite seu nome: ");
string? nome = Console.ReadLine();

Console.WriteLine ("Digite seu sobrenome: ");
string? sobrenome = Console.ReadLine();

Console.WriteLine ("Digite a sua data de nascimento no formato dd/mm/yy")
DateTime.Tryparse(Console.ReadLine(), out DateTime dataNascimento)

Console.WriteLine ("Digite seu CPF sem ponto ou caracter: ")
int.TryParse (Console.ReadLine(), out int cpf);

Console.WriteLine("Digite seu peso: ");
decimal.TryParse(Console.ReadLine(), out decimal peso);

Console.WriteLine (Digite sua altura: );
decimal.TryParse(Console.ReadLine(), out decimal altura);

Pessoa p = new Pessoa (nome, sobrenome, dataNascimento, cpf, peso,altura);

int idade = p.CalcularIdade();

decimal imc = Math.Round(p.CalculaIMC(),2);

bool sair = false;

while (!sair)
{
Console.WriteLine("Escolha uma das opções abaixo!");    
Console.WriteLine("0 - informações do usuario ");    
Console.WriteLine("1 - Calcular IMC");    
Console.WriteLine("2 - Verificar a maioridade do usuario");    
Console.WriteLine("3 - Sair");    


    Switch(opcao)
    {
    case "0"
    Console.WriteLine($"Nome Completo:{nome} {sobrenome}");
    Console.WriteLine($"Data de Nascimento:{dataNascimento}");
    Console.WriteLine($"Altura:{altura}");
    Console.WriteLine($"CPF{cpf}");
    Console.WriteLine($"Peso{peso}");
    Console.WriteLine($"Idade{idade}");
    break;

    case "1":
    Console.WriteLine($"Seu imc é {imc}");

    if(imc < 16,9)
    {
        Console.WriteLine($"Seu imc esta muito abaixo do peso")
    }-
    else if(imc >= 17 && imc =< 18,4)
    {
        Console.WriteLine($"Seu imc esta abaixo do peso")
    }
    else if(imc >= 18,5 && imc =< 24,9)
    {
        Console.WriteLine($"Seu imc esta no peso normal")
    }
    else if(imc >= 25 && imc =< 29,9)
        Console.WriteLine($"Seu imc esta acima do peso")
    }
    else if(imc >= 30 && imc =< 34,9)
    {
        Console.WriteLine($"Seu imc esta em obesidade I")
    }
    else if(imc >= 35 && imc =<39,9)
    {
        Console.WriteLine($"Seu imc esta em obesidade II")
    }
    else if(imc > 40)
    {
        Console.WriteLine($"Seu imc esta em obesidade III")
    }

    break;

    case "2":
    if (idade >=18)
    {
        Console.WriteLine($"Ola {nome}, parabens voce ja e maior de idade por ja ter {idade}");
    }else

    {
        Console.WriteLine($"Ola {nome}, voce é Menor de idade por ter {idade}");
    }
    break;

    case "3":
    sair = true;
    break;
    }
}