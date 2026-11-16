Console.WriteLine("Informe o titular da conta: ");
string titular = Console.ReadLine();
Console.WriteLine($"Saldo inicial da conta: R$2000");
double saldo = 2000.00;

ContaBancaria cb = new ContaBancaria();

cb.setTitular(titular);
cb.setSaldo(saldo);


Console.WriteLine(cb);

cb.Depositar(500);

Console.WriteLine(cb);

cb.Sacar(3500);

Console.WriteLine(cb);
