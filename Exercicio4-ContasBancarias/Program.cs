int quantidadeContas = 1;

int opcao = 0;

ContaCorrente[] vetorContaCorrente = new ContaCorrente[quantidadeContas];
ContaPolpança[] vetorContaPolpança = new ContaPolpança[quantidadeContas];
ContaSalario[] vetorContaSalario = new ContaSalario[quantidadeContas];


ContaCorrente AdicionarContaCorrente()
{
    ContaCorrente contaCorrente = new();
    Console.WriteLine("Digite o numero da conta: ");
    contaCorrente.Numero = Console.ReadLine();
    Console.WriteLine("Digite o saldo da conta: ");
    contaCorrente.Saldo = double.Parse(Console.ReadLine());
    Console.WriteLine($"o Limite da sua conta: {contaCorrente.DeterminarLimite()}");

    return contaCorrente;
}

ContaPolpança AdicionarContaPolpança()
{
    ContaPolpança contaPolpança = new();
    Console.WriteLine("Digite o numero da conta: ");
    contaPolpança.Numero = Console.ReadLine();
    Console.WriteLine("Digite o saldo da conta: ");
    contaPolpança.Saldo = double.Parse(Console.ReadLine());

    return contaPolpança;
}

ContaSalario AdicionarContaSalario()
{
    ContaSalario contaSalario = new();
    Console.WriteLine("Digite o numero da conta: ");
    contaSalario.Numero = Console.ReadLine();
    Console.WriteLine("Digite o saldo da conta: ");
    contaSalario.Saldo = double.Parse(Console.ReadLine());

    return contaSalario;
}

void CriarContas()
{
    int contadorCorrente = 0;
    int contadorPolpanca = 0;
    int contadorSalario = 0;

    do
    {
        Console.Write("[1] - criar uma Conta Corrente\n" +
                      "[2] - criar uma Conta Polpança\n" +
                      "[3] - criar uma Conta Salario\n" +
                      "[0] - sair\n" +
                      "Digite qual o tipo de Conta que deseja criar: ");
        opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                vetorContaCorrente[contadorCorrente] = AdicionarContaCorrente();
                contadorCorrente++;
                break;

            case 2:
                vetorContaPolpança[contadorPolpanca] = AdicionarContaPolpança();
                contadorPolpanca++;
                break;

            case 3:
                vetorContaSalario[contadorSalario] = AdicionarContaSalario();
                contadorSalario++;
                break;

            default:
                Console.WriteLine("Opcao Invalida!");
                break;

            case 0:
                Console.WriteLine("Saiu da crianção de conta!");
                break;
        }

    } while (opcao != 0);
}

void MostrarContas()
{
    Console.WriteLine("\n=== CONTAS CORRENTES ===");

    for (int i = 0; i < quantidadeContas; i++)
    {
        Console.WriteLine($"Número: {vetorContaCorrente[i].Numero}");
        Console.WriteLine($"Saldo: R$ {vetorContaCorrente[i].Saldo:F2}");
        Console.WriteLine($"Limite: R$ {vetorContaCorrente[i].Limite:F2}");
        Console.WriteLine("-----------------------");
    }

    Console.WriteLine("\n=== CONTAS POUPANÇA ===");

    for (int i = 0; i < quantidadeContas; i++)
    {
        Console.WriteLine($"Número: {vetorContaPolpança[i].Numero}");
        Console.WriteLine($"Saldo: R$ {vetorContaPolpança[i].Saldo:F2}");
        Console.WriteLine("-----------------------");
    }

    Console.WriteLine("\n=== CONTAS SALÁRIO ===");

    for (int i = 0; i < quantidadeContas; i++)
    {
        Console.WriteLine($"Número: {vetorContaSalario[i].Numero}");
        Console.WriteLine($"Saldo: R$ {vetorContaSalario[i].Saldo:F2}");
        Console.WriteLine("-----------------------");
    }
}

CriarContas();

vetorContaCorrente[0].Depositar(500);
MostrarContas();
vetorContaCorrente[0].Sacar(500);
MostrarContas();
vetorContaPolpança[0].Depositar(350);
MostrarContas();
vetorContaPolpança[0].Sacar(100);
MostrarContas();
vetorContaCorrente[0].Transferir(vetorContaPolpança[0], 100);
MostrarContas();
