using Atividades_Polimorfismo.Modelos;

void MenuPrincipal()
{
    Console.Clear();
    TituloModelo("Calculando a area de formas geometricas");
    Console.WriteLine($"Escolha uma opcao:");
    voltandoAoTopo:
    Console.WriteLine($"Digite 1 para a area do circulo\nDigite 2 para calcular a area do retangulo\nDigite 3 para calcular a area do trapezio: ");
    string opcao = Console.ReadLine()!;
    Calcular c = new Calcular();
    switch (opcao)
    {
        case "1":
            Console.Write("Digite o valor do raio do circulo: ");
            double r = double.Parse(Console.ReadLine()!);
            c.CalculandoArea(new Circulo(r));
            Console.WriteLine(c.ResumoCirculo);
            //Console.WriteLine($"A area do cirulo é: {c.CalculandoArea(new Circulo(r)):f1}");
            VoltandoAoMenu();
            break;
        case "2":
            Console.Write("Digite o valor da altura do retangulo: ");
            double a = double.Parse(Console.ReadLine()!);
            Console.Write($"Digite o valor da largura do retangulo: ");
            double l = double.Parse(Console.ReadLine()!);
            c.CalculandoArea(new Retangulo(a,l));
            Console.WriteLine(c.ResumoRetangulo);
            
            //Console.WriteLine($"A area do retangulo é: {c.CalculandoArea(new Retangulo(a,l)):f1}");
            VoltandoAoMenu();
            break;
        case "3":
            Console.Write("Digite o valor da base maior do trapezio: ");
            double bMaior = double.Parse(Console.ReadLine()!);
            Console.Write($"Digite o valor da base menor do trapezio: ");
            double bMenor = double.Parse(Console.ReadLine()!);
            Console.Write($"Digite o valor da altura do trapezio: ");
            double al = double.Parse(Console.ReadLine()!);
            c.CalculandoArea(new Trapezio(bMaior,bMenor,al));
            Console.WriteLine(c.ResumoTrapezio);
             
            //Console.WriteLine($"A area do retangulo é: {c.CalculandoArea(new Trapezio(bMaior,bMenor,al)):f1}");
            VoltandoAoMenu();
            break;
        default:
            Console.WriteLine("Valor invalido, por favor digitar um valor valido.");
            goto voltandoAoTopo;
    }
    
    
}

void VoltandoAoMenu()
{
    Console.WriteLine($"Deseja voltar ao menu?");
    VoltandoAoTopo:
    Console.WriteLine($"Digite 1 para continuar\nDigite 2 para sair:");
    
    string opcao = Console.ReadLine()!;
    switch (opcao)
    {
        case "1":
            Console.WriteLine($"Voltando ao Menu em 2 segundos...");
            Thread.Sleep(2000);
            MenuPrincipal();
            break;
        case "2":
            Console.WriteLine("Saindo...");
            break;
        default:
            Console.WriteLine($"Opcao invalida! Por favor digite uma opcao valida:");
            goto VoltandoAoTopo;

    } 
}

void TituloModelo(string titulo)
{
    string traco = string.Empty.PadLeft(5,'-').PadRight(5,'-');
    Console.WriteLine($"{traco}{titulo}{traco}");
}

MenuPrincipal();
