using App2021;

ContasNumericas contasnumericas = new ContasNumericas();

contasnumericas.Numero1 = int.Parse(Console.ReadLine());
contasnumericas.Numero2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Soma dos Numeros Digitados : {contasnumericas.Somar()}");
Console.WriteLine($"Subtração dos Numeros Digitados : {contasnumericas.Subtrair()}");
Console.WriteLine($"Mutiplicação dos Numeros Digitados : {contasnumericas.Mutiplicar()}");
Console.WriteLine($"Divição dos Numeros Digitados : {contasnumericas.Dividir()}");